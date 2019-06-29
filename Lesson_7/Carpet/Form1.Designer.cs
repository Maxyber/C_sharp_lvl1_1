namespace Carpet
{
    partial class frmCarpet
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStart = new System.Windows.Forms.Button();
            this.txtRepeater = new System.Windows.Forms.TextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.rdbTriangle = new System.Windows.Forms.RadioButton();
            this.rdbRectangle = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(700, 10);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 25);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Запуск!";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtRepeater
            // 
            this.txtRepeater.Location = new System.Drawing.Point(590, 10);
            this.txtRepeater.MinimumSize = new System.Drawing.Size(100, 25);
            this.txtRepeater.Name = "txtRepeater";
            this.txtRepeater.Size = new System.Drawing.Size(100, 20);
            this.txtRepeater.TabIndex = 1;
            this.txtRepeater.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRepeater.TextChanged += new System.EventHandler(this.txtRepeater_TextChanged);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(13, 12);
            this.lblInfo.MaximumSize = new System.Drawing.Size(580, 0);
            this.lblInfo.MinimumSize = new System.Drawing.Size(0, 25);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 25);
            this.lblInfo.TabIndex = 2;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(700, 45);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 25);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // rdbTriangle
            // 
            this.rdbTriangle.AutoSize = true;
            this.rdbTriangle.Location = new System.Drawing.Point(700, 77);
            this.rdbTriangle.Name = "rdbTriangle";
            this.rdbTriangle.Size = new System.Drawing.Size(57, 17);
            this.rdbTriangle.TabIndex = 4;
            this.rdbTriangle.TabStop = true;
            this.rdbTriangle.Text = "Треуг.";
            this.rdbTriangle.UseVisualStyleBackColor = true;
            // 
            // rdbRectangle
            // 
            this.rdbRectangle.AutoSize = true;
            this.rdbRectangle.Location = new System.Drawing.Point(700, 100);
            this.rdbRectangle.Name = "rdbRectangle";
            this.rdbRectangle.Size = new System.Drawing.Size(72, 17);
            this.rdbRectangle.TabIndex = 5;
            this.rdbRectangle.TabStop = true;
            this.rdbRectangle.Text = "Прямоуг.";
            this.rdbRectangle.UseVisualStyleBackColor = true;
            // 
            // frmCarpet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 450);
            this.Controls.Add(this.rdbRectangle);
            this.Controls.Add(this.rdbTriangle);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.txtRepeater);
            this.Controls.Add(this.btnStart);
            this.Name = "frmCarpet";
            this.Text = "Коврик на стенку";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtRepeater;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.RadioButton rdbTriangle;
        private System.Windows.Forms.RadioButton rdbRectangle;
    }
}

