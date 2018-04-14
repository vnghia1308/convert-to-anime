namespace Convert_to_Anime
{
    partial class ConvertToAnime
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.imageAddress = new System.Windows.Forms.TextBox();
            this.selectImageButton = new System.Windows.Forms.Button();
            this.convertButton = new System.Windows.Forms.Button();
            this.imageAddressLabel = new System.Windows.Forms.Label();
            this.saveLabel = new System.Windows.Forms.Label();
            this.saveAddress = new System.Windows.Forms.TextBox();
            this.selectFolderButton = new System.Windows.Forms.Button();
            this.Status = new System.Windows.Forms.Label();
            this.CopyrightLabel = new System.Windows.Forms.Label();
            this.typeConvert1 = new System.Windows.Forms.RadioButton();
            this.typeConvert2 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // imageAddress
            // 
            this.imageAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageAddress.Location = new System.Drawing.Point(133, 53);
            this.imageAddress.Name = "imageAddress";
            this.imageAddress.ReadOnly = true;
            this.imageAddress.Size = new System.Drawing.Size(333, 26);
            this.imageAddress.TabIndex = 0;
            // 
            // selectImageButton
            // 
            this.selectImageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectImageButton.Location = new System.Drawing.Point(472, 54);
            this.selectImageButton.Name = "selectImageButton";
            this.selectImageButton.Size = new System.Drawing.Size(108, 26);
            this.selectImageButton.TabIndex = 1;
            this.selectImageButton.Text = "Select image...";
            this.selectImageButton.UseVisualStyleBackColor = true;
            this.selectImageButton.Click += new System.EventHandler(this.selectImage);
            // 
            // convertButton
            // 
            this.convertButton.Enabled = false;
            this.convertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertButton.Location = new System.Drawing.Point(586, 54);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(82, 25);
            this.convertButton.TabIndex = 2;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertImage);
            // 
            // imageAddressLabel
            // 
            this.imageAddressLabel.AutoSize = true;
            this.imageAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageAddressLabel.Location = new System.Drawing.Point(12, 56);
            this.imageAddressLabel.Name = "imageAddressLabel";
            this.imageAddressLabel.Size = new System.Drawing.Size(115, 20);
            this.imageAddressLabel.TabIndex = 4;
            this.imageAddressLabel.Text = "Image address";
            // 
            // saveLabel
            // 
            this.saveLabel.AutoSize = true;
            this.saveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveLabel.Location = new System.Drawing.Point(12, 15);
            this.saveLabel.Name = "saveLabel";
            this.saveLabel.Size = new System.Drawing.Size(63, 20);
            this.saveLabel.TabIndex = 5;
            this.saveLabel.Text = "Save to";
            // 
            // saveAddress
            // 
            this.saveAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveAddress.Location = new System.Drawing.Point(133, 12);
            this.saveAddress.Name = "saveAddress";
            this.saveAddress.ReadOnly = true;
            this.saveAddress.Size = new System.Drawing.Size(333, 26);
            this.saveAddress.TabIndex = 6;
            this.saveAddress.Text = "C:\\";
            // 
            // selectFolderButton
            // 
            this.selectFolderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectFolderButton.Location = new System.Drawing.Point(472, 12);
            this.selectFolderButton.Name = "selectFolderButton";
            this.selectFolderButton.Size = new System.Drawing.Size(108, 29);
            this.selectFolderButton.TabIndex = 7;
            this.selectFolderButton.Text = "Select folder...";
            this.selectFolderButton.UseVisualStyleBackColor = true;
            this.selectFolderButton.Click += new System.EventHandler(this.selectSaveFolder);
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status.Location = new System.Drawing.Point(12, 113);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(229, 16);
            this.Status.TabIndex = 8;
            this.Status.Text = "Trạng thái: Vui lòng chọn file hình ảnh!";
            // 
            // CopyrightLabel
            // 
            this.CopyrightLabel.AutoSize = true;
            this.CopyrightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyrightLabel.Location = new System.Drawing.Point(562, 113);
            this.CopyrightLabel.Name = "CopyrightLabel";
            this.CopyrightLabel.Size = new System.Drawing.Size(105, 16);
            this.CopyrightLabel.TabIndex = 9;
            this.CopyrightLabel.Text = "© 2018 Vy Nghia";
            this.CopyrightLabel.Click += new System.EventHandler(this.copyrightAuthor);
            // 
            // typeConvert1
            // 
            this.typeConvert1.AutoSize = true;
            this.typeConvert1.Checked = true;
            this.typeConvert1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeConvert1.Location = new System.Drawing.Point(16, 90);
            this.typeConvert1.Name = "typeConvert1";
            this.typeConvert1.Size = new System.Drawing.Size(87, 20);
            this.typeConvert1.TabIndex = 10;
            this.typeConvert1.TabStop = true;
            this.typeConvert1.Tag = "";
            this.typeConvert1.Text = "Sáng sớm";
            this.typeConvert1.UseVisualStyleBackColor = true;
            // 
            // typeConvert2
            // 
            this.typeConvert2.AutoSize = true;
            this.typeConvert2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeConvert2.Location = new System.Drawing.Point(109, 90);
            this.typeConvert2.Name = "typeConvert2";
            this.typeConvert2.Size = new System.Drawing.Size(74, 20);
            this.typeConvert2.TabIndex = 11;
            this.typeConvert2.Text = "Chiều tà";
            this.typeConvert2.UseVisualStyleBackColor = true;
            // 
            // ConvertToAnime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 138);
            this.Controls.Add(this.typeConvert2);
            this.Controls.Add(this.typeConvert1);
            this.Controls.Add(this.CopyrightLabel);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.selectFolderButton);
            this.Controls.Add(this.saveAddress);
            this.Controls.Add(this.saveLabel);
            this.Controls.Add(this.imageAddressLabel);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.selectImageButton);
            this.Controls.Add(this.imageAddress);
            this.MaximizeBox = false;
            this.Name = "ConvertToAnime";
            this.Text = "Convert to Anime";
            this.Load += new System.EventHandler(this.ConvertToAnime_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox imageAddress;
        private System.Windows.Forms.Button selectImageButton;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Label imageAddressLabel;
        private System.Windows.Forms.Label saveLabel;
        private System.Windows.Forms.TextBox saveAddress;
        private System.Windows.Forms.Button selectFolderButton;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Label CopyrightLabel;
        private System.Windows.Forms.RadioButton typeConvert1;
        private System.Windows.Forms.RadioButton typeConvert2;
    }
}

