namespace GoogleMap
{
    partial class CoordinatePickerForm
    {        
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.WebBrowser myBrowser;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblCity; 
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblCoord;

        private System.Drawing.Rectangle axisRectX;
        private System.Drawing.Graphics lineX;
        
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoordinatePickerForm));
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.myBrowser = new System.Windows.Forms.WebBrowser();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblZip = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblCoord = new System.Windows.Forms.Label();
            this.galleryImageView = new System.Windows.Forms.PictureBox();
            this.imageBackButton = new System.Windows.Forms.Button();
            this.imageNextButton = new System.Windows.Forms.Button();
            this.textBoxImagePath = new System.Windows.Forms.TextBox();
            this.imageLoaderButton = new System.Windows.Forms.Button();
            this.labelPictureIndex = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.galleryImageView)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(419, 755);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // myBrowser
            // 
            this.myBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myBrowser.Location = new System.Drawing.Point(0, 0);
            this.myBrowser.Margin = new System.Windows.Forms.Padding(450, 5, 4, 5);
            this.myBrowser.MinimumSize = new System.Drawing.Size(30, 31);
            this.myBrowser.Name = "myBrowser";
            this.myBrowser.Size = new System.Drawing.Size(1360, 755);
            this.myBrowser.TabIndex = 2;
            this.myBrowser.Url = new System.Uri("http://maps.google.com", System.UriKind.Absolute);
            this.myBrowser.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.MyBrowser_Navigated);
            // 
            // txtStreet
            // 
            this.txtStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStreet.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtStreet.Location = new System.Drawing.Point(143, 73);
            this.txtStreet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(265, 26);
            this.txtStreet.TabIndex = 2;
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtCity.Location = new System.Drawing.Point(143, 43);
            this.txtCity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(265, 26);
            this.txtCity.TabIndex = 3;
            this.txtCity.Text = "Zalaegerszeg";
            // 
            // txtState
            // 
            this.txtState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtState.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtState.Location = new System.Drawing.Point(143, 14);
            this.txtState.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(265, 26);
            this.txtState.TabIndex = 4;
            // 
            // txtZip
            // 
            this.txtZip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZip.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtZip.Location = new System.Drawing.Point(143, 104);
            this.txtZip.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(265, 26);
            this.txtZip.TabIndex = 5;
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(80, 74);
            this.lblStreet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(64, 25);
            this.lblStreet.TabIndex = 6;
            this.lblStreet.Text = "Street";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(98, 44);
            this.lblCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(46, 25);
            this.lblCity.TabIndex = 7;
            this.lblCity.Text = "City";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(86, 13);
            this.lblState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(58, 25);
            this.lblState.TabIndex = 8;
            this.lblState.Text = "State";
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Location = new System.Drawing.Point(105, 105);
            this.lblZip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(39, 25);
            this.lblZip.TabIndex = 9;
            this.lblZip.Text = "Zip";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnSearch.Location = new System.Drawing.Point(143, 135);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(265, 58);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblCoord
            // 
            this.lblCoord.AutoSize = true;
            this.lblCoord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoord.Location = new System.Drawing.Point(7, 197);
            this.lblCoord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCoord.Name = "lblCoord";
            this.lblCoord.Size = new System.Drawing.Size(118, 25);
            this.lblCoord.TabIndex = 11;
            this.lblCoord.Text = "Coordinates";
            // 
            // galleryImageView
            // 
            this.galleryImageView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.galleryImageView.Cursor = System.Windows.Forms.Cursors.Default;
            this.galleryImageView.Location = new System.Drawing.Point(12, 322);
            this.galleryImageView.Name = "galleryImageView";
            this.galleryImageView.Size = new System.Drawing.Size(396, 325);
            this.galleryImageView.TabIndex = 12;
            this.galleryImageView.TabStop = false;
            // 
            // imageBackButton
            // 
            this.imageBackButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.imageBackButton.Location = new System.Drawing.Point(12, 654);
            this.imageBackButton.Name = "imageBackButton";
            this.imageBackButton.Size = new System.Drawing.Size(78, 55);
            this.imageBackButton.TabIndex = 13;
            this.imageBackButton.Text = "Back";
            this.imageBackButton.UseVisualStyleBackColor = false;
            this.imageBackButton.Click += new System.EventHandler(this.imageBackButton_Click);
            // 
            // imageNextButton
            // 
            this.imageNextButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.imageNextButton.Location = new System.Drawing.Point(330, 654);
            this.imageNextButton.Name = "imageNextButton";
            this.imageNextButton.Size = new System.Drawing.Size(78, 55);
            this.imageNextButton.TabIndex = 14;
            this.imageNextButton.Text = "Next";
            this.imageNextButton.UseVisualStyleBackColor = false;
            this.imageNextButton.Click += new System.EventHandler(this.imageNextButton_Click);
            // 
            // textBoxImagePath
            // 
            this.textBoxImagePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxImagePath.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxImagePath.Location = new System.Drawing.Point(12, 244);
            this.textBoxImagePath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxImagePath.Name = "textBoxImagePath";
            this.textBoxImagePath.Size = new System.Drawing.Size(396, 26);
            this.textBoxImagePath.TabIndex = 15;
            this.textBoxImagePath.Text = "D:\\Letöltések\\Nóri letöltései";
            // 
            // imageLoaderButton
            // 
            this.imageLoaderButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.imageLoaderButton.Location = new System.Drawing.Point(12, 278);
            this.imageLoaderButton.Name = "imageLoaderButton";
            this.imageLoaderButton.Size = new System.Drawing.Size(155, 37);
            this.imageLoaderButton.TabIndex = 16;
            this.imageLoaderButton.Text = "Load";
            this.imageLoaderButton.UseVisualStyleBackColor = false;
            this.imageLoaderButton.Click += new System.EventHandler(this.imageLoaderButton_Click);
            // 
            // labelPictureIndex
            // 
            this.labelPictureIndex.AutoSize = true;
            this.labelPictureIndex.Location = new System.Drawing.Point(171, 669);
            this.labelPictureIndex.Name = "labelPictureIndex";
            this.labelPictureIndex.Size = new System.Drawing.Size(0, 25);
            this.labelPictureIndex.TabIndex = 17;
            // 
            // CoordinatePickerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(1360, 755);
            this.Controls.Add(this.labelPictureIndex);
            this.Controls.Add(this.imageLoaderButton);
            this.Controls.Add(this.textBoxImagePath);
            this.Controls.Add(this.imageNextButton);
            this.Controls.Add(this.imageBackButton);
            this.Controls.Add(this.galleryImageView);
            this.Controls.Add(this.lblCoord);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblZip);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblStreet);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtStreet);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.myBrowser);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CoordinatePickerForm";
            this.Text = "GPS Coordinate Picker Tool by Daniel Korompai";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.CoordinatePickerForm_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.galleryImageView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private System.Windows.Forms.PictureBox galleryImageView;
        private System.Windows.Forms.Button imageBackButton;
        private System.Windows.Forms.Button imageNextButton;
        private System.Windows.Forms.TextBox textBoxImagePath;
        private System.Windows.Forms.Button imageLoaderButton;
        private System.Windows.Forms.Label labelPictureIndex;
    }
}

