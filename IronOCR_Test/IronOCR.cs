using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IronOcr;

//https://ironsoftware.com/csharp/ocr/examples/simple-csharp-ocr-tesseract/     IronOCR for.NET   Code Exemples


namespace IronOCR_Test
{
    public partial class IronOCR_Test : Form
    {
        public IronOCR_Test()
        {
            InitializeComponent();

            this.btnOpen.Click += BtnOpen_Click;
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            string imgfile = string.Empty;
            string Result = string.Empty;

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = @"C:\";

            if(dialog.ShowDialog() == DialogResult.OK)
            {
                imgfile = dialog.FileName;
            }
            else
            {
                return;
            }


            try
            {
                if (this.rdoImage.Checked)                                      // 이미지
                {
                    int width = 350;
                    int height = 350;
                    Size resize1 = new Size(width, height);
                    Bitmap bmp = new Bitmap(imgfile);

                    Bitmap ReSizeBitMap = new Bitmap(bmp, resize1);


                    this.pictureBox1.Image = ReSizeBitMap;


                    var OCR = new IronTesseract();

                    OCR.Language = OcrLanguage.English;
                    OCR.AddSecondaryLanguage(OcrLanguage.Korean);

                    Result = OCR.Read(dialog.FileName.ToString()).Text;



                    this.textBox1.Text = Result;
                }
                else if (this.rdoPDF.Checked)                                   // PDF
                {
                    this.pictureBox1.Image = null;

                    using (var Input = new OcrInput())
                    {
                        var Ocr = new IronTesseract();

                        // Unit : Pixel
                        var ContentArea = new CropRectangle(x: 0, y: 2150, width: 435, height: 50);

                        Input.AddPdfPages(dialog.FileName, new[] { 1 },"", ContentArea);
                        Result = Ocr.Read(Input).Text;
                        this.textBox1.Text = Result;
                    }
                }
                else                                                            // 이미지 합쳐서 PDF만들기
                {
                    var ocrTesseract = new IronTesseract();
                    ocrTesseract.Language = OcrLanguage.English;
                    ocrTesseract.AddSecondaryLanguage(OcrLanguage.Korean);
                    using (var ocrInput = new OcrInput())
                    {
                        ocrInput.AddImage(@"D:\dev\TestImage01.png");
                        ocrInput.AddImage(@"D:\dev\TestImage02.png");
                        ocrInput.AddImage(dialog.FileName);

                        ocrInput.Deskew();

                        var ocrResult = ocrTesseract.Read(ocrInput);

                        ocrResult.SaveAsSearchablePdf(@"D:\dev\searchable.pdf");
                        return;
                    }
                }

            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }
    }
}
