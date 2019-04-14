namespace Lesson_8
{
    partial class frmBasic
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
            this.lblTask1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.rbTask1 = new System.Windows.Forms.RadioButton();
            this.rbTask2 = new System.Windows.Forms.RadioButton();
            this.rbTask3 = new System.Windows.Forms.RadioButton();
            this.rbTask4 = new System.Windows.Forms.RadioButton();
            this.rbTask5 = new System.Windows.Forms.RadioButton();
            this.lblTask5 = new System.Windows.Forms.Label();
            this.lblTask4 = new System.Windows.Forms.Label();
            this.lblTask3 = new System.Windows.Forms.Label();
            this.lblTask2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTask1
            // 
            this.lblTask1.AutoSize = true;
            this.lblTask1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTask1.Location = new System.Drawing.Point(13, 13);
            this.lblTask1.Name = "lblTask1";
            this.lblTask1.Size = new System.Drawing.Size(161, 17);
            this.lblTask1.TabIndex = 0;
            this.lblTask1.Text = "Информация о классах";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(713, 13);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // rbTask1
            // 
            this.rbTask1.AutoSize = true;
            this.rbTask1.Location = new System.Drawing.Point(313, 13);
            this.rbTask1.Name = "rbTask1";
            this.rbTask1.Size = new System.Drawing.Size(88, 17);
            this.rbTask1.TabIndex = 2;
            this.rbTask1.TabStop = true;
            this.rbTask1.Text = "Задание №1";
            this.rbTask1.UseVisualStyleBackColor = true;
            // 
            // rbTask2
            // 
            this.rbTask2.AutoSize = true;
            this.rbTask2.Location = new System.Drawing.Point(313, 51);
            this.rbTask2.Name = "rbTask2";
            this.rbTask2.Size = new System.Drawing.Size(88, 17);
            this.rbTask2.TabIndex = 3;
            this.rbTask2.TabStop = true;
            this.rbTask2.Text = "Задание №2";
            this.rbTask2.UseVisualStyleBackColor = true;
            // 
            // rbTask3
            // 
            this.rbTask3.AutoSize = true;
            this.rbTask3.Location = new System.Drawing.Point(313, 87);
            this.rbTask3.Name = "rbTask3";
            this.rbTask3.Size = new System.Drawing.Size(88, 17);
            this.rbTask3.TabIndex = 4;
            this.rbTask3.TabStop = true;
            this.rbTask3.Text = "Задание №3";
            this.rbTask3.UseVisualStyleBackColor = true;
            // 
            // rbTask4
            // 
            this.rbTask4.AutoSize = true;
            this.rbTask4.Location = new System.Drawing.Point(313, 125);
            this.rbTask4.Name = "rbTask4";
            this.rbTask4.Size = new System.Drawing.Size(88, 17);
            this.rbTask4.TabIndex = 5;
            this.rbTask4.TabStop = true;
            this.rbTask4.Text = "Задание №4";
            this.rbTask4.UseVisualStyleBackColor = true;
            // 
            // rbTask5
            // 
            this.rbTask5.AutoSize = true;
            this.rbTask5.Location = new System.Drawing.Point(313, 165);
            this.rbTask5.Name = "rbTask5";
            this.rbTask5.Size = new System.Drawing.Size(88, 17);
            this.rbTask5.TabIndex = 6;
            this.rbTask5.TabStop = true;
            this.rbTask5.Text = "Задание №5";
            this.rbTask5.UseVisualStyleBackColor = true;
            // 
            // lblTask5
            // 
            this.lblTask5.AutoSize = true;
            this.lblTask5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTask5.Location = new System.Drawing.Point(12, 165);
            this.lblTask5.Name = "lblTask5";
            this.lblTask5.Size = new System.Drawing.Size(161, 17);
            this.lblTask5.TabIndex = 9;
            this.lblTask5.Text = "Информация о классах";
            // 
            // lblTask4
            // 
            this.lblTask4.AutoSize = true;
            this.lblTask4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTask4.Location = new System.Drawing.Point(13, 125);
            this.lblTask4.Name = "lblTask4";
            this.lblTask4.Size = new System.Drawing.Size(161, 17);
            this.lblTask4.TabIndex = 10;
            this.lblTask4.Text = "Информация о классах";
            // 
            // lblTask3
            // 
            this.lblTask3.AutoSize = true;
            this.lblTask3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTask3.Location = new System.Drawing.Point(13, 87);
            this.lblTask3.Name = "lblTask3";
            this.lblTask3.Size = new System.Drawing.Size(161, 17);
            this.lblTask3.TabIndex = 11;
            this.lblTask3.Text = "Информация о классах";
            // 
            // lblTask2
            // 
            this.lblTask2.AutoSize = true;
            this.lblTask2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTask2.Location = new System.Drawing.Point(13, 51);
            this.lblTask2.Name = "lblTask2";
            this.lblTask2.Size = new System.Drawing.Size(161, 17);
            this.lblTask2.TabIndex = 12;
            this.lblTask2.Text = "Информация о классах";
            // 
            // frmBasic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 807);
            this.Controls.Add(this.lblTask2);
            this.Controls.Add(this.lblTask3);
            this.Controls.Add(this.lblTask4);
            this.Controls.Add(this.lblTask5);
            this.Controls.Add(this.rbTask5);
            this.Controls.Add(this.rbTask4);
            this.Controls.Add(this.rbTask3);
            this.Controls.Add(this.rbTask2);
            this.Controls.Add(this.rbTask1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblTask1);
            this.Name = "frmBasic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTask1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblTask5;
        private System.Windows.Forms.Label lblTask4;
        private System.Windows.Forms.Label lblTask3;
        private System.Windows.Forms.Label lblTask2;
        public System.Windows.Forms.RadioButton rbTask1;
        public System.Windows.Forms.RadioButton rbTask2;
        public System.Windows.Forms.RadioButton rbTask3;
        public System.Windows.Forms.RadioButton rbTask4;
        public System.Windows.Forms.RadioButton rbTask5;
    }
}

