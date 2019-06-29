namespace GuessNum
{
    partial class formInputNumber
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
            this.txtInputNumber = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblInputNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInputNumber
            // 
            this.txtInputNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtInputNumber.Location = new System.Drawing.Point(10, 10);
            this.txtInputNumber.Name = "txtInputNumber";
            this.txtInputNumber.Size = new System.Drawing.Size(100, 21);
            this.txtInputNumber.TabIndex = 0;
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCheck.Location = new System.Drawing.Point(10, 36);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(100, 24);
            this.btnCheck.TabIndex = 1;
            this.btnCheck.Text = "Угадать";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblInputNumber
            // 
            this.lblInputNumber.AutoSize = true;
            this.lblInputNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInputNumber.Location = new System.Drawing.Point(15, 70);
            this.lblInputNumber.Margin = new System.Windows.Forms.Padding(0);
            this.lblInputNumber.MaximumSize = new System.Drawing.Size(100, 0);
            this.lblInputNumber.MinimumSize = new System.Drawing.Size(0, 15);
            this.lblInputNumber.Name = "lblInputNumber";
            this.lblInputNumber.Size = new System.Drawing.Size(98, 30);
            this.lblInputNumber.TabIndex = 2;
            this.lblInputNumber.Text = "Введите целое число";
            this.lblInputNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // formInputNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(124, 110);
            this.Controls.Add(this.lblInputNumber);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtInputNumber);
            this.Name = "formInputNumber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "число";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInputNumber;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblInputNumber;
    }
}