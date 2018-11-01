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
        private List<Image> imageList;
        private string imagePath;

        public CoordinatePickerForm()
        {
            imageList = new List<Image>();
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
                Path.GetFullPath(imagePath);
            }
            catch
            {
                MessageBox.Show("Given text is not a valid path", "Invalid Path", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (Directory.Exists(imagePath))
            {
                var imageCollection = Directory.GetFiles(imagePath, "*.jpg", SearchOption.AllDirectories);

                foreach (var image in imageCollection)
                {
                    imageList.Add(Image.FromFile(image));
                }
            }            
        }
    }
}
