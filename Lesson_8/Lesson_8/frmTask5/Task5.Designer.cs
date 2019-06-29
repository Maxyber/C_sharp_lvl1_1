namespace frmTask5
{
    partial class Task5
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
            this.btnConvert = new System.Windows.Forms.Button();
            this.tbInfo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(13, 13);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(375, 113);
            this.btnConvert.TabIndex = 0;
            this.btnConvert.Text = "Конвертация *.cs в *.xml";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // tbInfo
            // 
            this.tbInfo.Location = new System.Drawing.Point(13, 133);
            this.tbInfo.Multiline = true;
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.Size = new System.Drawing.Size(775, 305);
            this.tbInfo.TabIndex = 1;
            // 
            // Task5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbInfo);
            this.Controls.Add(this.btnConvert);
            this.Name = "Task5";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.TextBox tbInfo;
    }
}

