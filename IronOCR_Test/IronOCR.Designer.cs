
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.rdoImage = new System.Windows.Forms.RadioButton();
            this.rdoPDF = new System.Windows.Forms.RadioButton();
            this.rdoNew = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 350);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(410, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(350, 350);
            this.textBox1.TabIndex = 1;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(229, 383);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(132, 42);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "열기";
            this.btnOpen.UseVisualStyleBackColor = true;
            // 
            // rdoImage
            // 
            this.rdoImage.AutoSize = true;
            this.rdoImage.Location = new System.Drawing.Point(12, 396);
            this.rdoImage.Name = "rdoImage";
            this.rdoImage.Size = new System.Drawing.Size(58, 16);
            this.rdoImage.TabIndex = 3;
            this.rdoImage.Text = "Image";
            this.rdoImage.UseVisualStyleBackColor = true;
            // 
            // rdoPDF
            // 
            this.rdoPDF.AutoSize = true;
            this.rdoPDF.Checked = true;
            this.rdoPDF.Location = new System.Drawing.Point(76, 396);
            this.rdoPDF.Name = "rdoPDF";
            this.rdoPDF.Size = new System.Drawing.Size(46, 16);
            this.rdoPDF.TabIndex = 4;
            this.rdoPDF.TabStop = true;
            this.rdoPDF.Text = "PDF";
            this.rdoPDF.UseVisualStyleBackColor = true;
            // 
            // rdoNew
            // 
            this.rdoNew.AutoSize = true;
            this.rdoNew.Location = new System.Drawing.Point(128, 396);
            this.rdoNew.Name = "rdoNew";
            this.rdoNew.Size = new System.Drawing.Size(49, 16);
            this.rdoNew.TabIndex = 5;
            this.rdoNew.Text = "New";
            this.rdoNew.UseVisualStyleBackColor = true;
            // 
            // IronOCR_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 446);
            this.Controls.Add(this.rdoNew);
            this.Controls.Add(this.rdoPDF);
            this.Controls.Add(this.rdoImage);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "IronOCR_Test";
            this.Text = "IronOCR_Test";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.RadioButton rdoImage;
        private System.Windows.Forms.RadioButton rdoPDF;
        private System.Windows.Forms.RadioButton rdoNew;
    }
}

