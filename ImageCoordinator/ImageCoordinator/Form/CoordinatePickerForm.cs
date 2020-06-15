using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GoogleMap
{   
    public partial class CoordinatePickerForm : Form
    {
        private long memoryLimit = 1073741824 / 4; // 1GB/4 in bytes
        private bool isThereAnyHugeFile;
        private bool isHitimageCollectionLimit;
        private List<string> hugeFileList;

        private Dictionary<int, Image> imageCollection;
        string[] imagePathArray;
        private int actualPictureIndex;


        private long fileSizeCounter = 0;
        private string imagePath;
        
        private int allImageNumber;
        private int possiblePictureIndex = 0;

        public CoordinatePickerForm()
        {
            InitializeComponent();
        }

        private void CoordinatePickerForm_Load(object sender, EventArgs e)
        {                        
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string street = txtStreet.Text;
            string city = txtCity.Text;
            string state = txtState.Text;
            string zip = txtZip.Text;

            try
            {
                StringBuilder queryAddres = new StringBuilder();
                queryAddres.Append("http://maps.google.com/maps?q=");

                if(street != string.Empty)
                {
                    queryAddres.Append(street + "," + "+");
                }
                if (city != string.Empty)
                {
                    queryAddres.Append(city + "," + "+");
                }
                if (state != string.Empty)
                {
                    queryAddres.Append(state + "," + "+");
                }
                if (zip != string.Empty)
                {
                    queryAddres.Append(zip + "," + "+");
                }

                myBrowser.Navigate(queryAddres.ToString());
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message.ToString(), "Error");
            }
        }

        private void MyBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            string entireUrl = myBrowser.Url.ToString();
            string firstCoordinate = null;
            string secondCoordinate = null;

            if(entireUrl != string.Empty)
            {
                if (entireUrl.Contains("@"))
                {
                    IList<string> listOfString = new List<string>();

                    listOfString = entireUrl.Split('@');

                    var list = listOfString[1].Split(',');

                    firstCoordinate = list[0];
                    secondCoordinate = list[1];
                }
            }

            StringBuilder coordinates = new StringBuilder();
            coordinates.Append(firstCoordinate + ", " + secondCoordinate);
            lblCoord.Text = coordinates.ToString();
        }

        private void CoordinatePickerForm_Paint(object sender, PaintEventArgs e)
        {                        
            Graphics verticalLine = e.Graphics;
            Pen blackPen = new Pen(Color.Black, 1);
            verticalLine.DrawLine(blackPen, 50, 50, 100, 100);
            verticalLine.Dispose();
        }

        private void imageLoaderButton_Click(object sender, EventArgs e)
        {
            try
            {
                imagePath = textBoxImagePath.Text;
                Path.GetFullPath(imagePath);               
            }
            catch
            {
                MessageBox.Show("Given text is not a valid path", "Invalid Path", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (Directory.Exists(imagePath))
            {
                imagePathArray = Directory.GetFiles(imagePath, "*.jpg", SearchOption.AllDirectories);
                allImageNumber = imagePathArray.Length;

                LoadImageCollectionFromPathArray(0);

                if (imageCollection.Count > 0)
                {
                    LoadImage(imageCollection[0]);
                    actualPictureIndex = 0;
                }
                else
                {
                    labelPictureIndex.Text = String.Format("Pictures Cannot be load due .jpg files can not be found or file size exceeds {0} MB", memoryLimit / 1048576);
                }
            }
        }

        private void LoadImageCollectionFromPathArray(int startIndex, bool isForwardDirection = true)
        {
            try
            {
                long fileSizeCounter = 0;
                DisposeAllImagesInImageCollection();

                imageCollection = new Dictionary<int, Image>();

                if (isForwardDirection)
                {
                    for (int i = startIndex; i < imagePathArray.Length; i++)
                    {
                        AddImageToTheCollectionInMemorySafeMode(i);
                        if (isHitimageCollectionLimit)
                        {
                            break;
                        }
                    }
                }
                else
                {
                    for (int i = startIndex; i > 0; i--)
                    {
                        AddImageToTheCollectionInMemorySafeMode(i);
                        if (isHitimageCollectionLimit)
                        {
                            break;
                        }
                    }
                }               
            }
            catch(OutOfMemoryException)
            {
                ////TODO:
                //handle following: dispose all item
                //write to file
                //write log entry
                memoryLimit /= 2;
                LoadImageCollectionFromPathArray(startIndex, isForwardDirection);
                MessageBox.Show("There is not enough memory to load all images", "Out of Memory", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                isHitimageCollectionLimit = false;
                if (isThereAnyHugeFile)
                {
                    isThereAnyHugeFile = false;
                    string textBuffer = String.Empty;
                    foreach (var path in hugeFileList)
                    {
                        var fileName = new FileInfo(path).Name;
                        textBuffer += fileName + "/n";
                    }
                    var text = String.Format("File size exceeds the {0} MB in the following cases:/n", memoryLimit);
                    MessageBox.Show(text + textBuffer, "Large files", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            
        }

        private void AddImageToTheCollectionInMemorySafeMode(int iteration)
        {
            var fileSize = new FileInfo(imagePathArray[iteration]).Length;
            if (fileSize > memoryLimit)
            {
                isThereAnyHugeFile = true;
                hugeFileList = new List<string>();
                hugeFileList.Add(imagePathArray[iteration]);
                return;
            }

            fileSizeCounter += fileSize;

            if (fileSizeCounter < memoryLimit)
            {
                imageCollection.Add(iteration, Image.FromFile(imagePathArray[iteration]));
            }
            else
            {
                isHitimageCollectionLimit = true;
                fileSizeCounter = 0;
            }
        }

        private Image GetImageByIndex(int arrayIndex, bool isForwardDirection)
        {
            Image image = null;

            if(!imageCollection.TryGetValue(arrayIndex, out image))
            {
                LoadImageCollectionFromPathArray(arrayIndex, isForwardDirection);
                imageCollection.TryGetValue(arrayIndex, out image);
            }

            return image;
        }

        private void LoadImage(Image image)
        {
            galleryImageView.BackgroundImage = image;
            labelPictureIndex.Text = String.Format("{0}/{1}", allImageNumber, possiblePictureIndex + 1);
        }

        private void imageNextButton_Click(object sender, EventArgs e)
        {
            possiblePictureIndex = actualPictureIndex + 1;

            if (allImageNumber > possiblePictureIndex)
            {                
                LoadImage(GetImageByIndex(possiblePictureIndex, true));
                actualPictureIndex = possiblePictureIndex;
            }
        }

        private void DisposeAllImagesInImageCollection()
        {
            if (imageCollection != null)
            {
                foreach (var entry in imageCollection)
                {
                    entry.Value.Dispose();
                }
                imageCollection = null;
            }
            GC.Collect();
        }

        private void imageBackButton_Click(object sender, EventArgs e)
        {
            possiblePictureIndex = actualPictureIndex - 1;

            if (possiblePictureIndex >= 0)
            {
                LoadImage(GetImageByIndex(possiblePictureIndex, false));
                actualPictureIndex = possiblePictureIndex;
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // CoordinatePickerForm
            // 
            this.ClientSize = new System.Drawing.Size(1375, 749);
            this.Name = "CoordinatePickerForm";
            this.ResumeLayout(false);

        }
    }
}
