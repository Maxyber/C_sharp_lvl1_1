namespace GuessNum
{
    partial class mainForm
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
            this.number = new System.Windows.Forms.Label();
            this.lblTry = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.btnInputNumber = new System.Windows.Forms.Button();
            this.txtInputNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart.Location = new System.Drawing.Point(195, 10);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(105, 25);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Начать игру";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.start_Click);
            // 
            // number
            // 
            this.number.AutoSize = true;
            this.number.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number.Location = new System.Drawing.Point(10, 10);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(171, 15);
            this.number.TabIndex = 1;
            this.number.Text = "Ваше последнее число 0";
            this.number.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTry
            // 
            this.lblTry.AutoSize = true;
            this.lblTry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTry.Location = new System.Drawing.Point(13, 46);
            this.lblTry.Name = "lblTry";
            this.lblTry.Size = new System.Drawing.Size(81, 15);
            this.lblTry.TabIndex = 2;
            this.lblTry.Text = "Попытка №0";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInfo.Location = new System.Drawing.Point(10, 102);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(205, 13);
            this.lblInfo.TabIndex = 3;
            this.lblInfo.Text = "Вас приветствует игра \"Угадай число\"";
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPlayer.Location = new System.Drawing.Point(16, 71);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(81, 15);
            this.lblPlayer.TabIndex = 4;
            this.lblPlayer.Text = "Ход игрока 1";
            // 
            // btnInputNumber
            // 
            this.btnInputNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnInputNumber.Location = new System.Drawing.Point(195, 67);
            this.btnInputNumber.MaximumSize = new System.Drawing.Size(105, 25);
            this.btnInputNumber.Name = "btnInputNumber";
            this.btnInputNumber.Size = new System.Drawing.Size(105, 25);
            this.btnInputNumber.TabIndex = 5;
            this.btnInputNumber.Text = "Ввести число";
            this.btnInputNumber.UseVisualStyleBackColor = true;
            this.btnInputNumber.Click += new System.EventHandler(this.btnInputNumber_Click);
            // 
            // txtInputNumber
            // 
            this.txtInputNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtInputNumber.Location = new System.Drawing.Point(138, 45);
            this.txtInputNumber.Name = "txtInputNumber";
            this.txtInputNumber.Size = new System.Drawing.Size(47, 47);
            this.txtInputNumber.TabIndex = 6;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 138);
            this.Controls.Add(this.txtInputNumber);
            this.Controls.Add(this.btnInputNumber);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblTry);
            this.Controls.Add(this.number);
            this.Controls.Add(this.btnStart);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Угадай число";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.SizeChanged += new System.EventHandler(this.mainForm_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label number;
        private System.Windows.Forms.Label lblTry;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Button btnInputNumber;
        private System.Windows.Forms.TextBox txtInputNumber;
    }
}

