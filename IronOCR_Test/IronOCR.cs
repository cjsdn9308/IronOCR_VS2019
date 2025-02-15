using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using IronOcr;

/*https://ironsoftware.com/csharp/ocr/examples/simple-csharp-ocr-tesseract/     IronOCR for.NET   Code Exemples*/

namespace IronOCR_Test
{
    public partial class IronOCR_Test : Form
    {
        public IronOCR_Test()
        {
            InitializeComponent();
            this.Load += new EventHandler(IronOCR_Test_Load);
            this.Shown += new EventHandler(IronOCR_Test_Shown);

            this.btnOpen.Click += new EventHandler(BtnOpen_Click);
            this.btnTextOutput.Click += new EventHandler(BtnTextOutput_Click);

            this.rdoImage.CheckedChanged += new EventHandler(Rdo_CheckedChanged);
            this.rdoPDF.CheckedChanged += new EventHandler(Rdo_CheckedChanged);
            this.rdoNew.CheckedChanged += new EventHandler(Rdo_CheckedChanged);

            this.chkPDFPW.CheckedChanged += new EventHandler(chkPDF_CheckedChanged);
            this.chkPDFPage.CheckedChanged += new EventHandler(chkPDF_CheckedChanged);


        }

        // Load
        private void IronOCR_Test_Load(object sender, EventArgs e)
        {
        }

        // Shown
        private void IronOCR_Test_Shown(object sender, EventArgs e)
        {
            Rdo_CheckedChanged(null, null);
        }

        

        // 열기버튼 클릭 (FileOpen Button Click)
        private void BtnOpen_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
            string imgfile = string.Empty;
            string strResult = string.Empty;
            string ImageArr;

            OpenFileDialog dialog = new OpenFileDialog();
            if(this.rdoNew.Checked)                         // 새로운 PDF파일을 만든다면 여러개의 파일을 선택하도록 함. (If you create a new PDF file, make sure to select multiple files.)
                dialog.Multiselect = true;

            dialog.InitialDirectory = @"C:\";
            dialog.Title = "열기";
            dialog.Filter = "그림 파일 (*.jpg, *.jpge, *.gif, *.bmp, *.png) | *.jpg; *.jpge; *.gif; *.bmp; *png; | 모든 파일 (*.*) | *.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgfile = dialog.FileName;
                ImageArr = dialog.FileName;
            }
            else
                return;

            try
            {
                var OCR = new IronTesseract();
                OCR.Language = OcrLanguage.English;
                OCR.AddSecondaryLanguage(OcrLanguage.Korean);

                if (this.rdoImage.Checked)                                      // 이미지 (image)
                {
                    int width = this.pbxImage.Width;
                    int height = this.pbxImage.Height;
                    Size resize1 = new Size(width, height);
                    Bitmap bmp = new Bitmap(imgfile);

                    Bitmap ReSizeBitMap = new Bitmap(bmp, resize1);

                    this.pbxImage.Image = ReSizeBitMap;

                    strResult = OCR.Read(dialog.FileName.ToString()).Text;
                    this.txtResult.Text = strResult;
                }
                else if (this.rdoPDF.Checked)                                   // PDF (PDF)
                {
                    this.pbxImage.Image = null;
                    List<int> lisPDFPage = new List<int>();

                    if (this.chkPDFPage.Checked)                                                        // 페이지가 지정되어 있는경우 (If a page is specified)
                    {
                        string[] strarrPDFPageSpl = this.txtPDFPage.Text.Split(',');
                        foreach (string range in strarrPDFPageSpl)
                        {
                            if(range.Contains("~"))
                            {
                                string[] parts = range.Split('~');
                                int start = int.Parse(parts[0]);
                                int end = int.Parse(parts[1]);

                                for (int i = start; i <= end; i++)
                                    lisPDFPage.Add(i-1); 
                            }
                            else
                            {
                                lisPDFPage.Add(int.Parse(range)-1);
                            }

                        }
                    }
                    

                    using (var Input = new OcrInput())
                    {
                        if (chkPDFPW.Checked)                                                           // PDF파일에 비밀번호가 있는지 확인 (Verify that the PDF file has a password)
                        {
                            if (chkPDFPage.Checked)                                                         // 비밀번호 + 페이지 지정한 경우 (Password + Page specified)
                                Input.AddPdfPages(dialog.FileName, lisPDFPage, this.txtPDFPW.Text);
                            else                                                                           // 비밀번호만 지정된 경우 (If only the password is specified)
                                Input.AddPdf(dialog.FileName, txtPDFPW.Text);
                        }
                        else                                                                            // 아무것도 체크된게 없음 (Nothing is checked)
                            Input.AddPdf(dialog.FileName);

                        strResult = OCR.Read(Input).Text;
                        this.txtResult.Text = strResult;


                    }
                }
                else                                                            // 이미지 합쳐서 PDF만들기 (Create PDF by combining images)
                {
                    try
                    {
                        using (var ocrInput = new OcrInput())
                        {
                            foreach (string filename in dialog.FileNames)
                                ocrInput.AddImage(filename);

                            ocrInput.Deskew();

                            SaveFileDialog OutputPath = new SaveFileDialog();
                            OutputPath.Filter = "PDF files (*.pdf)|*.pdf";
                            OutputPath.FileName = "*.pdf";
                            var ocrResult = OCR.Read(ocrInput);
                            if (OutputPath.ShowDialog() == DialogResult.OK)
                            {
                                ocrResult.SaveAsSearchablePdf(OutputPath.FileName);
                                MessageBox.Show("작업이 완료되었습니다.");
                            }
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("파일을 열 수 없습니다.\r\n파일정보를 확인하세요.","에러",MessageBoxButtons.OK, MessageBoxIcon.Error);
                //          Unable to open file.\r\nCheck file information          Error
            }


        }

        // 텍스트 내보내기 버튼 클릭 (Click the Export Text button)
        private void BtnTextOutput_Click(object sender, EventArgs e)
        {
            SaveFileDialog Dio_txtResult = new SaveFileDialog();
            Dio_txtResult.Filter = "텍스트 파일 (*.txt)|*.txt";          // "text file (*.txt)|*.txt";
            Dio_txtResult.FileName = "*.txt";
            if (Dio_txtResult.ShowDialog() == DialogResult.OK)
            {
                // 파일 경로 가져오기 (Import File Path)
                string filePath = Dio_txtResult.FileName;

                // TextBox의 내용을 파일에 쓰기 (Write the contents of TextBox to a file)
                File.WriteAllText(filePath, this.txtResult.Text);
                MessageBox.Show("작업이 완료되었습니다.");                // The operation has been completed.
            }
        }


        // PDF Radio버튼에 대해서만 옵션을 표시하는 이벤트 (Events that display options only for PDF Radio buttons)
        void Rdo_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rdoPDF.Checked)
            {
                tlpOption.SetRowSpan(pnlFileOption, 1);
                pnlPDFOption.Visible = true;
            }
            else
            {
                pnlPDFOption.Visible = false;
                tlpOption.SetRowSpan(pnlFileOption, 2);
            }
        }

        // PDF Radio를 선택 했을 때 나타나는 옵션들을 선택 및 해제시 이벤트 (Events when you select and turn off options that appear when you select PDF Radio)
        void chkPDF_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkPDFPW.Checked)
                this.txtPDFPW.Enabled = true;
            else
            {
                this.txtPDFPW.Text = "";
                this.txtPDFPW.Enabled = false;
            }

            if (this.chkPDFPage.Checked)
                this.txtPDFPage.Enabled = true;
            else
            {
                this.txtPDFPage.Text = "";
                this.txtPDFPage.Enabled = false;
            }
        }
    }
}
