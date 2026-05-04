namespace 五張撲克牌
{
    partial class frmPoker
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
            this.grpPoker = new System.Windows.Forms.GroupBox();
            this.grButton = new System.Windows.Forms.GroupBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnChangeCard = new System.Windows.Forms.Button();
            this.btnDealCard = new System.Windows.Forms.Button();
            this.grpAnte = new System.Windows.Forms.GroupBox();
            this.lblPs = new System.Windows.Forms.Label();
            this.txtBet = new System.Windows.Forms.TextBox();
            this.txtTotalFunds = new System.Windows.Forms.TextBox();
            this.btnBet = new System.Windows.Forms.Button();
            this.lblBet = new System.Windows.Forms.Label();
            this.lblTotalFunds = new System.Windows.Forms.Label();
            this.grButton.SuspendLayout();
            this.grpAnte.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPoker
            // 
            this.grpPoker.AutoSize = true;
            this.grpPoker.BackColor = System.Drawing.Color.DarkGreen;
            this.grpPoker.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpPoker.ForeColor = System.Drawing.Color.Goldenrod;
            this.grpPoker.Location = new System.Drawing.Point(22, 26);
            this.grpPoker.Margin = new System.Windows.Forms.Padding(4);
            this.grpPoker.Name = "grpPoker";
            this.grpPoker.Padding = new System.Windows.Forms.Padding(4);
            this.grpPoker.Size = new System.Drawing.Size(485, 160);
            this.grpPoker.TabIndex = 0;
            this.grpPoker.TabStop = false;
            this.grpPoker.Text = "牌桌";
            // 
            // grButton
            // 
            this.grButton.AutoSize = true;
            this.grButton.BackColor = System.Drawing.Color.DarkGreen;
            this.grButton.Controls.Add(this.lblResult);
            this.grButton.Controls.Add(this.btnCheck);
            this.grButton.Controls.Add(this.btnChangeCard);
            this.grButton.Controls.Add(this.btnDealCard);
            this.grButton.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.grButton.ForeColor = System.Drawing.Color.Goldenrod;
            this.grButton.Location = new System.Drawing.Point(22, 371);
            this.grButton.Margin = new System.Windows.Forms.Padding(4);
            this.grButton.Name = "grButton";
            this.grButton.Padding = new System.Windows.Forms.Padding(4);
            this.grButton.Size = new System.Drawing.Size(485, 139);
            this.grButton.TabIndex = 1;
            this.grButton.TabStop = false;
            this.grButton.Text = "功能";
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.White;
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.lblResult.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblResult.Location = new System.Drawing.Point(25, 37);
            this.lblResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(433, 30);
            this.lblResult.TabIndex = 3;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.Goldenrod;
            this.btnCheck.Enabled = false;
            this.btnCheck.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.btnCheck.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnCheck.Location = new System.Drawing.Point(315, 81);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(116, 32);
            this.btnCheck.TabIndex = 0;
            this.btnCheck.Text = "判斷牌型";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnChangeCard
            // 
            this.btnChangeCard.BackColor = System.Drawing.Color.Goldenrod;
            this.btnChangeCard.Enabled = false;
            this.btnChangeCard.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.btnChangeCard.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnChangeCard.Location = new System.Drawing.Point(183, 81);
            this.btnChangeCard.Margin = new System.Windows.Forms.Padding(4);
            this.btnChangeCard.Name = "btnChangeCard";
            this.btnChangeCard.Size = new System.Drawing.Size(116, 32);
            this.btnChangeCard.TabIndex = 0;
            this.btnChangeCard.Text = "換牌";
            this.btnChangeCard.UseVisualStyleBackColor = false;
            this.btnChangeCard.Click += new System.EventHandler(this.btnChangeCard_Click);
            // 
            // btnDealCard
            // 
            this.btnDealCard.BackColor = System.Drawing.Color.Goldenrod;
            this.btnDealCard.Enabled = false;
            this.btnDealCard.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.btnDealCard.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnDealCard.Location = new System.Drawing.Point(52, 81);
            this.btnDealCard.Margin = new System.Windows.Forms.Padding(4);
            this.btnDealCard.Name = "btnDealCard";
            this.btnDealCard.Size = new System.Drawing.Size(116, 32);
            this.btnDealCard.TabIndex = 0;
            this.btnDealCard.Text = "發牌";
            this.btnDealCard.UseVisualStyleBackColor = false;
            this.btnDealCard.Click += new System.EventHandler(this.btnDealCard_Click);
            // 
            // grpAnte
            // 
            this.grpAnte.AutoSize = true;
            this.grpAnte.BackColor = System.Drawing.Color.DarkGreen;
            this.grpAnte.Controls.Add(this.lblPs);
            this.grpAnte.Controls.Add(this.txtBet);
            this.grpAnte.Controls.Add(this.txtTotalFunds);
            this.grpAnte.Controls.Add(this.btnBet);
            this.grpAnte.Controls.Add(this.lblBet);
            this.grpAnte.Controls.Add(this.lblTotalFunds);
            this.grpAnte.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.grpAnte.ForeColor = System.Drawing.Color.Goldenrod;
            this.grpAnte.Location = new System.Drawing.Point(22, 204);
            this.grpAnte.Margin = new System.Windows.Forms.Padding(4);
            this.grpAnte.Name = "grpAnte";
            this.grpAnte.Padding = new System.Windows.Forms.Padding(4);
            this.grpAnte.Size = new System.Drawing.Size(485, 150);
            this.grpAnte.TabIndex = 2;
            this.grpAnte.TabStop = false;
            this.grpAnte.Text = "下注";
            // 
            // lblPs
            // 
            this.lblPs.BackColor = System.Drawing.Color.Transparent;
            this.lblPs.Font = new System.Drawing.Font("微軟正黑體", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPs.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblPs.Location = new System.Drawing.Point(20, 36);
            this.lblPs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPs.Name = "lblPs";
            this.lblPs.Size = new System.Drawing.Size(444, 19);
            this.lblPs.TabIndex = 7;
            this.lblPs.Text = "*初始總資金僅能在開局前設定。買定離手，遊戲一旦開始便無法再作修改，請謹慎決定！";
            // 
            // txtBet
            // 
            this.txtBet.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.txtBet.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBet.Location = new System.Drawing.Point(94, 98);
            this.txtBet.Margin = new System.Windows.Forms.Padding(4);
            this.txtBet.Name = "txtBet";
            this.txtBet.Size = new System.Drawing.Size(287, 25);
            this.txtBet.TabIndex = 2;
            this.txtBet.Text = "1000";
            // 
            // txtTotalFunds
            // 
            this.txtTotalFunds.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.txtTotalFunds.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTotalFunds.Location = new System.Drawing.Point(94, 64);
            this.txtTotalFunds.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalFunds.Name = "txtTotalFunds";
            this.txtTotalFunds.Size = new System.Drawing.Size(287, 25);
            this.txtTotalFunds.TabIndex = 1;
            this.txtTotalFunds.Text = "1000000";
            // 
            // btnBet
            // 
            this.btnBet.BackColor = System.Drawing.Color.Goldenrod;
            this.btnBet.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.btnBet.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnBet.Location = new System.Drawing.Point(390, 64);
            this.btnBet.Margin = new System.Windows.Forms.Padding(4);
            this.btnBet.Name = "btnBet";
            this.btnBet.Size = new System.Drawing.Size(69, 59);
            this.btnBet.TabIndex = 3;
            this.btnBet.Text = "押注";
            this.btnBet.UseVisualStyleBackColor = false;
            this.btnBet.Click += new System.EventHandler(this.btnBet_Click);
            // 
            // lblBet
            // 
            this.lblBet.AutoSize = true;
            this.lblBet.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.lblBet.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblBet.Location = new System.Drawing.Point(22, 101);
            this.lblBet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBet.Name = "lblBet";
            this.lblBet.Size = new System.Drawing.Size(64, 18);
            this.lblBet.TabIndex = 2;
            this.lblBet.Text = "押注金額";
            // 
            // lblTotalFunds
            // 
            this.lblTotalFunds.AutoSize = true;
            this.lblTotalFunds.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalFunds.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblTotalFunds.Location = new System.Drawing.Point(22, 67);
            this.lblTotalFunds.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalFunds.Name = "lblTotalFunds";
            this.lblTotalFunds.Size = new System.Drawing.Size(50, 18);
            this.lblTotalFunds.TabIndex = 0;
            this.lblTotalFunds.Text = "總資金";
            // 
            // frmPoker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(529, 529);
            this.Controls.Add(this.grpAnte);
            this.Controls.Add(this.grButton);
            this.Controls.Add(this.grpPoker);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPoker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "五張撲克牌";
            this.grButton.ResumeLayout(false);
            this.grpAnte.ResumeLayout(false);
            this.grpAnte.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPoker;
        private System.Windows.Forms.GroupBox grButton;
        private System.Windows.Forms.Button btnChangeCard;
        private System.Windows.Forms.Button btnDealCard;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.GroupBox grpAnte;
        private System.Windows.Forms.Label lblTotalFunds;
        private System.Windows.Forms.Label lblBet;
        private System.Windows.Forms.Button btnBet;
        private System.Windows.Forms.TextBox txtBet;
        private System.Windows.Forms.TextBox txtTotalFunds;
        private System.Windows.Forms.Label lblPs;
    }
}