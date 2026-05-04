namespace 五張撲克牌
{
    partial class frmPicTest
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTest = new System.Windows.Forms.Button();
            this.lblTest = new System.Windows.Forms.Label();
            this.picTest = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picTest)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTest
            // 
            this.btnTest.BackColor = System.Drawing.Color.Lavender;
            this.btnTest.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTest.Location = new System.Drawing.Point(227, 63);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(86, 61);
            this.btnTest.TabIndex = 1;
            this.btnTest.Text = "換牌";
            this.btnTest.UseVisualStyleBackColor = false;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // lblTest
            // 
            this.lblTest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTest.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTest.Location = new System.Drawing.Point(227, 143);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(86, 35);
            this.lblTest.TabIndex = 2;
            // 
            // picTest
            // 
            this.picTest.Image = global::五張撲克牌.Properties.Resources.back;
            this.picTest.Location = new System.Drawing.Point(62, 32);
            this.picTest.Name = "picTest";
            this.picTest.Size = new System.Drawing.Size(85, 115);
            this.picTest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picTest.TabIndex = 0;
            this.picTest.TabStop = false;
            // 
            // frmPicTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 248);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.picTest);
            this.Name = "frmPicTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "圖片資源測試";
            ((System.ComponentModel.ISupportInitialize)(this.picTest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picTest;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label lblTest;
    }
}

