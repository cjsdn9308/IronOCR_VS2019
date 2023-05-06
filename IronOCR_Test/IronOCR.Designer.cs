
namespace IronOCR_Test
{
    partial class IronOCR_Test
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbxImage = new System.Windows.Forms.PictureBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.tlpBase = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tlpOption = new System.Windows.Forms.TableLayoutPanel();
            this.btnTextOutput = new System.Windows.Forms.Button();
            this.pnlFileOption = new System.Windows.Forms.Panel();
            this.rdoNew = new System.Windows.Forms.RadioButton();
            this.rdoPDF = new System.Windows.Forms.RadioButton();
            this.rdoImage = new System.Windows.Forms.RadioButton();
            this.pnlPDFOption = new System.Windows.Forms.Panel();
            this.tlpPDFInfo = new System.Windows.Forms.TableLayoutPanel();
            this.txtPDFPage = new System.Windows.Forms.TextBox();
            this.chkPDFPW = new System.Windows.Forms.CheckBox();
            this.chkPDFPage = new System.Windows.Forms.CheckBox();
            this.txtPDFPW = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).BeginInit();
            this.tlpBase.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tlpOption.SuspendLayout();
            this.pnlFileOption.SuspendLayout();
            this.pnlPDFOption.SuspendLayout();
            this.tlpPDFInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbxImage
            // 
            this.pbxImage.BackColor = System.Drawing.Color.White;
            this.pbxImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxImage.Location = new System.Drawing.Point(3, 3);
            this.pbxImage.Name = "pbxImage";
            this.pbxImage.Size = new System.Drawing.Size(609, 527);
            this.pbxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImage.TabIndex = 0;
            this.pbxImage.TabStop = false;
            // 
            // txtResult
            // 
            this.txtResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResult.Location = new System.Drawing.Point(618, 3);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResult.Size = new System.Drawing.Size(609, 527);
            this.txtResult.TabIndex = 1;
            // 
            // btnOpen
            // 
            this.btnOpen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOpen.Location = new System.Drawing.Point(506, 25);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(1);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(106, 55);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "열기";
            this.btnOpen.UseVisualStyleBackColor = true;
            // 
            // tlpBase
            // 
            this.tlpBase.BackColor = System.Drawing.Color.White;
            this.tlpBase.ColumnCount = 2;
            this.tlpBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBase.Controls.Add(this.txtResult, 1, 0);
            this.tlpBase.Controls.Add(this.pbxImage, 0, 0);
            this.tlpBase.Controls.Add(this.panel1, 0, 1);
            this.tlpBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBase.Location = new System.Drawing.Point(0, 0);
            this.tlpBase.Name = "tlpBase";
            this.tlpBase.RowCount = 2;
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.68831F));
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.31169F));
            this.tlpBase.Size = new System.Drawing.Size(1230, 616);
            this.tlpBase.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.tlpOption);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(1, 534);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(613, 81);
            this.panel1.TabIndex = 2;
            // 
            // tlpOption
            // 
            this.tlpOption.ColumnCount = 4;
            this.tlpOption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.46903F));
            this.tlpOption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.17699F));
            this.tlpOption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.83186F));
            this.tlpOption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.34513F));
            this.tlpOption.Controls.Add(this.btnTextOutput, 3, 0);
            this.tlpOption.Controls.Add(this.pnlFileOption, 0, 0);
            this.tlpOption.Controls.Add(this.pnlPDFOption, 0, 1);
            this.tlpOption.Controls.Add(this.btnOpen, 3, 1);
            this.tlpOption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpOption.Location = new System.Drawing.Point(0, 0);
            this.tlpOption.Margin = new System.Windows.Forms.Padding(1);
            this.tlpOption.Name = "tlpOption";
            this.tlpOption.RowCount = 2;
            this.tlpOption.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpOption.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpOption.Size = new System.Drawing.Size(613, 81);
            this.tlpOption.TabIndex = 11;
            // 
            // btnTextOutput
            // 
            this.btnTextOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTextOutput.Location = new System.Drawing.Point(506, 1);
            this.btnTextOutput.Margin = new System.Windows.Forms.Padding(1);
            this.btnTextOutput.Name = "btnTextOutput";
            this.btnTextOutput.Size = new System.Drawing.Size(106, 22);
            this.btnTextOutput.TabIndex = 4;
            this.btnTextOutput.Text = "텍스트 내보내기";
            this.btnTextOutput.UseVisualStyleBackColor = true;
            // 
            // pnlFileOption
            // 
            this.tlpOption.SetColumnSpan(this.pnlFileOption, 3);
            this.pnlFileOption.Controls.Add(this.rdoNew);
            this.pnlFileOption.Controls.Add(this.rdoPDF);
            this.pnlFileOption.Controls.Add(this.rdoImage);
            this.pnlFileOption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFileOption.Location = new System.Drawing.Point(1, 1);
            this.pnlFileOption.Margin = new System.Windows.Forms.Padding(1);
            this.pnlFileOption.Name = "pnlFileOption";
            this.pnlFileOption.Size = new System.Drawing.Size(503, 22);
            this.pnlFileOption.TabIndex = 0;
            // 
            // rdoNew
            // 
            this.rdoNew.AutoSize = true;
            this.rdoNew.Dock = System.Windows.Forms.DockStyle.Left;
            this.rdoNew.Location = new System.Drawing.Point(144, 0);
            this.rdoNew.Margin = new System.Windows.Forms.Padding(1);
            this.rdoNew.Name = "rdoNew";
            this.rdoNew.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.rdoNew.Size = new System.Drawing.Size(120, 22);
            this.rdoNew.TabIndex = 10;
            this.rdoNew.Text = "New PDF File";
            this.rdoNew.UseVisualStyleBackColor = true;
            // 
            // rdoPDF
            // 
            this.rdoPDF.AutoSize = true;
            this.rdoPDF.Dock = System.Windows.Forms.DockStyle.Left;
            this.rdoPDF.Location = new System.Drawing.Point(78, 0);
            this.rdoPDF.Margin = new System.Windows.Forms.Padding(1);
            this.rdoPDF.Name = "rdoPDF";
            this.rdoPDF.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.rdoPDF.Size = new System.Drawing.Size(66, 22);
            this.rdoPDF.TabIndex = 7;
            this.rdoPDF.Text = "PDF";
            this.rdoPDF.UseVisualStyleBackColor = true;
            // 
            // rdoImage
            // 
            this.rdoImage.AutoSize = true;
            this.rdoImage.Checked = true;
            this.rdoImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.rdoImage.Location = new System.Drawing.Point(0, 0);
            this.rdoImage.Margin = new System.Windows.Forms.Padding(1);
            this.rdoImage.Name = "rdoImage";
            this.rdoImage.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.rdoImage.Size = new System.Drawing.Size(78, 22);
            this.rdoImage.TabIndex = 9;
            this.rdoImage.TabStop = true;
            this.rdoImage.Text = "Image";
            this.rdoImage.UseVisualStyleBackColor = true;
            // 
            // pnlPDFOption
            // 
            this.tlpOption.SetColumnSpan(this.pnlPDFOption, 3);
            this.pnlPDFOption.Controls.Add(this.tlpPDFInfo);
            this.pnlPDFOption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPDFOption.Location = new System.Drawing.Point(1, 25);
            this.pnlPDFOption.Margin = new System.Windows.Forms.Padding(1);
            this.pnlPDFOption.Name = "pnlPDFOption";
            this.pnlPDFOption.Size = new System.Drawing.Size(503, 55);
            this.pnlPDFOption.TabIndex = 3;
            // 
            // tlpPDFInfo
            // 
            this.tlpPDFInfo.ColumnCount = 2;
            this.tlpPDFInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.87475F));
            this.tlpPDFInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.12525F));
            this.tlpPDFInfo.Controls.Add(this.txtPDFPage, 1, 1);
            this.tlpPDFInfo.Controls.Add(this.chkPDFPW, 0, 0);
            this.tlpPDFInfo.Controls.Add(this.chkPDFPage, 0, 1);
            this.tlpPDFInfo.Controls.Add(this.txtPDFPW, 1, 0);
            this.tlpPDFInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPDFInfo.Location = new System.Drawing.Point(0, 0);
            this.tlpPDFInfo.Margin = new System.Windows.Forms.Padding(1);
            this.tlpPDFInfo.Name = "tlpPDFInfo";
            this.tlpPDFInfo.RowCount = 2;
            this.tlpPDFInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPDFInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPDFInfo.Size = new System.Drawing.Size(503, 55);
            this.tlpPDFInfo.TabIndex = 0;
            // 
            // txtPDFPage
            // 
            this.txtPDFPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPDFPage.Enabled = false;
            this.txtPDFPage.Location = new System.Drawing.Point(105, 28);
            this.txtPDFPage.Margin = new System.Windows.Forms.Padding(1);
            this.txtPDFPage.Name = "txtPDFPage";
            this.txtPDFPage.Size = new System.Drawing.Size(397, 21);
            this.txtPDFPage.TabIndex = 3;
            // 
            // chkPDFPW
            // 
            this.chkPDFPW.AutoSize = true;
            this.chkPDFPW.Dock = System.Windows.Forms.DockStyle.Left;
            this.chkPDFPW.Location = new System.Drawing.Point(1, 1);
            this.chkPDFPW.Margin = new System.Windows.Forms.Padding(1);
            this.chkPDFPW.Name = "chkPDFPW";
            this.chkPDFPW.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.chkPDFPW.Size = new System.Drawing.Size(101, 25);
            this.chkPDFPW.TabIndex = 0;
            this.chkPDFPW.Text = "Password";
            this.chkPDFPW.UseVisualStyleBackColor = true;
            // 
            // chkPDFPage
            // 
            this.chkPDFPage.AutoSize = true;
            this.chkPDFPage.Dock = System.Windows.Forms.DockStyle.Left;
            this.chkPDFPage.Location = new System.Drawing.Point(1, 28);
            this.chkPDFPage.Margin = new System.Windows.Forms.Padding(1);
            this.chkPDFPage.Name = "chkPDFPage";
            this.chkPDFPage.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.chkPDFPage.Size = new System.Drawing.Size(73, 26);
            this.chkPDFPage.TabIndex = 1;
            this.chkPDFPage.Text = "Page";
            this.chkPDFPage.UseVisualStyleBackColor = true;
            // 
            // txtPDFPW
            // 
            this.txtPDFPW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPDFPW.Enabled = false;
            this.txtPDFPW.Location = new System.Drawing.Point(105, 1);
            this.txtPDFPW.Margin = new System.Windows.Forms.Padding(1);
            this.txtPDFPW.Name = "txtPDFPW";
            this.txtPDFPW.Size = new System.Drawing.Size(397, 21);
            this.txtPDFPW.TabIndex = 2;
            // 
            // IronOCR_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 616);
            this.Controls.Add(this.tlpBase);
            this.Name = "IronOCR_Test";
            this.Text = "IronOCR_Test";
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).EndInit();
            this.tlpBase.ResumeLayout(false);
            this.tlpBase.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tlpOption.ResumeLayout(false);
            this.pnlFileOption.ResumeLayout(false);
            this.pnlFileOption.PerformLayout();
            this.pnlPDFOption.ResumeLayout(false);
            this.tlpPDFInfo.ResumeLayout(false);
            this.tlpPDFInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxImage;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TableLayoutPanel tlpBase;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdoPDF;
        private System.Windows.Forms.RadioButton rdoNew;
        private System.Windows.Forms.RadioButton rdoImage;
        private System.Windows.Forms.TableLayoutPanel tlpOption;
        private System.Windows.Forms.Panel pnlFileOption;
        private System.Windows.Forms.Panel pnlPDFOption;
        private System.Windows.Forms.TableLayoutPanel tlpPDFInfo;
        private System.Windows.Forms.CheckBox chkPDFPW;
        private System.Windows.Forms.CheckBox chkPDFPage;
        private System.Windows.Forms.TextBox txtPDFPage;
        private System.Windows.Forms.TextBox txtPDFPW;
        private System.Windows.Forms.Button btnTextOutput;
    }
}

