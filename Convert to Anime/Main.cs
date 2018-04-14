/**
 * Code by Vy Nghia
 * Facebook: https://www.facebook.com/nghiadev
**/

using System;
using System.IO;
using System.Net;
using System.Drawing;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace Convert_to_Anime
{
    public partial class ConvertToAnime : Form
    {
        private Thread convert;
        public ConvertToAnime()
        {
            InitializeComponent();
        }

        public string version = "1.0.0";

        private void selectImage(object sender, EventArgs e)
        {
            OpenFileDialog imageDialog = new OpenFileDialog();

            imageDialog.InitialDirectory = "Pictures";
            imageDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.bmp, *.png) | *.jpg; *.jpeg; *.jpe; *.bmp; *.png";
            imageDialog.FilterIndex = 2;
            imageDialog.RestoreDirectory = true;

            if (imageDialog.ShowDialog() == DialogResult.OK)
            {
                imageAddress.Text = imageDialog.FileName;
                convertButton.Enabled = true;
                Status.Text = "Trạng thái: Vui lòng nhấn Convert để bắt đầu tạo hình ảnh";
            }
        }

        private void convertImage(object sender, EventArgs e)
        {
            convert = new Thread(new ThreadStart(convertImageThread));
            if (convertButton.Text == "Convert")
            {
                convert.Start();

                convertButton.Text = "Stop";

                typeConvert1.Enabled = false;
                typeConvert2.Enabled = false;

                selectImageButton.Enabled = false;
                selectFolderButton.Enabled = false;

                Status.Text = "Trạng thái: Đang thực hiện tác vụ, vui lòng chờ...";
            }
            else
            {
                convert.Abort();

                convertButton.Text = "Convert";

                typeConvert1.Enabled = true;
                typeConvert2.Enabled = true;

                selectImageButton.Enabled = true;
                selectFolderButton.Enabled = true;

                Status.Text = "Trạng thái: Tác vụ đã bị hủy bỏ, vui lòng nhấn nút Convert nếu muốn thực hiện lại!";
            }
        }

        private void convertStatus(bool status)
        {
            if(status)
            {
                convertButton.Invoke(new Action(() => convertButton.Text = "Convert"));

                Status.Invoke(new Action(() => Status.Text = "Trạng thái: Tạo ảnh thành công, ảnh đã được lưu vào thư mục chỉ định!"));

                typeConvert1.Invoke(new Action(() => typeConvert1.Enabled = true));
                typeConvert2.Invoke(new Action(() => typeConvert2.Enabled = true));

                selectImageButton.Invoke(new Action(() => selectImageButton.Enabled = true));
                selectFolderButton.Invoke(new Action(() => selectFolderButton.Enabled = true));
            }
        }

        public void convertImageThread()
        {
            int numOutput, t = (typeConvert1.Checked) ? 0 : 1;
            bool s = (imageAddress.Text == "") ? false : true;

            if (s)
            {
                while (true)
                {
                    if (!convert.IsAlive)
                        break;

                    if (File.Exists(imageAddress.Text))
                    {
                        byte[] imageArray = File.ReadAllBytes(@"" + imageAddress.Text);
                        string encodeImage = Convert.ToBase64String(imageArray);

                        string URI = "https://photoshopvn.com/api/socket/convert-raw-text.php?mode=" + t;
                        string upload = "image=" + encodeImage;

                        using (WebClient wc = new WebClient())
                        {
                            try
                            {
                                //Send data to URI
                                wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                                string responseResult = wc.UploadString(URI, upload);

                                //Read numOutput value
                                if (File.Exists(@".\data.ini"))
                                {
                                    string[] readData = File.ReadAllText(@".\data.ini").Split(new char[] { '\n' });
                                    string[] numData = readData[1].Split(new char[] { '=' });
                                    numOutput = Convert.ToInt32(numData[1]);
                                }
                                else
                                {
                                    writeDataFile(0, @"C:\");

                                    numOutput = 0;
                                }

                                //Handling response data
                                if (HtmlResult.Length > 100)
                                {
                                    if (convert.IsAlive)
                                    {
                                        LoadImage(responseResult, numOutput);
                                        convertStatus(true);
                                        convert.Abort();
                                    }
                                }
                            }
                            catch (Exception e) { }
                        }
                    }
                }
            }
        }

        public void LoadImage(string base64code, int numOutput)
        {
            byte[] bytes = Convert.FromBase64String(base64code);

            string saveToAddress = saveAddress.Text + @"\" + (numOutput + 1) + ".png";

            using (Image image = Image.FromStream(new MemoryStream(bytes)))
            {
                image.Save(saveToAddress, ImageFormat.Png);

                writeDataFile(numOutput + 1, saveAddress.Text);
            }
        }

        private void selectSaveFolder(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    saveAddress.Text = fbd.SelectedPath;

                    //Update new Dir
                    string[] readData = File.ReadAllText(@".\data.ini").Split(new char[] { '\n' });
                    string[] numData = readData[1].Split(new char[] { '=' });
                    writeDataFile(Convert.ToInt32(numData[1]), saveAddress.Text);
                }
            }
        }

        private void ConvertToAnime_Load(object sender, EventArgs e)
        {
            if (!File.Exists(@".\data.ini"))
            {
                writeDataFile(0, @"C:\");
            }
            else if(File.ReadAllText(@".\data.ini") == "")
            {
                writeDataFile(0, @"C:\");
            }

            readFileData();
        }

        public void writeDataFile(int num, string Dir)
        {
            string Data = "[Convert to Anime]\n" +
                          "number=" + num +"\n" +
                          "SvtoDir=" + Dir;
            File.WriteAllText(@".\data.ini", Data);
        }

        public void readFileData()
        {
            string[] readData = File.ReadAllText(@".\data.ini").Split(new char[] { '\n' });
            if(readData.Length == 3)
            {
                string[] numData = readData[1].Split(new char[] { '=' });
                string[] dỉrData = readData[2].Split(new char[] { '=' });

                if (Directory.Exists(dỉrData[1]))
                    saveAddress.Text = dỉrData[1];
                else if (saveAddress.Text == "")
                    saveAddress.Text = @"C:\";
                else
                    writeDataFile(0, @"C:\");


                if (Convert.ToInt32(numData[1]) < 0)
                    writeDataFile(0, saveAddress.Text);
            }
            else
                writeDataFile(0, @"C:\");
        }

        private void copyrightAuthor(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/10002217682048");
        }
    }
}
