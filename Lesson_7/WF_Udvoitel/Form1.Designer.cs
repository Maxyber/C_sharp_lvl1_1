namespace WF_Udvoitel
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.plusBtn = new System.Windows.Forms.Button();
            this.muliBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.numberLbl = new System.Windows.Forms.Label();
            this.targetLbl = new System.Windows.Forms.Label();
            this.timeLbl = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.Label();
            this.target = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.playTime = new System.Windows.Forms.Timer(this.components);
            this.cancel = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // plusBtn
            // 
            this.plusBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plusBtn.Location = new System.Drawing.Point(150, 10);
            this.plusBtn.Name = "plusBtn";
            this.plusBtn.Size = new System.Drawing.Size(75, 40);
            this.plusBtn.TabIndex = 0;
            this.plusBtn.Text = "+1";
            this.plusBtn.UseVisualStyleBackColor = true;
            this.plusBtn.Click += new System.EventHandler(this.plusBtn_Click);
            // 
            // muliBtn
            // 
            this.muliBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.muliBtn.Location = new System.Drawing.Point(150, 55);
            this.muliBtn.Name = "muliBtn";
            this.muliBtn.Size = new System.Drawing.Size(75, 40);
            this.muliBtn.TabIndex = 1;
            this.muliBtn.Text = "х2";
            this.muliBtn.UseVisualStyleBackColor = true;
            this.muliBtn.Click += new System.EventHandler(this.muliBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearBtn.Location = new System.Drawing.Point(150, 145);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 40);
            this.clearBtn.TabIndex = 2;
            this.clearBtn.Text = "Сброс";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // numberLbl
            // 
            this.numberLbl.AutoSize = true;
            this.numberLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberLbl.Location = new System.Drawing.Point(10, 10);
            this.numberLbl.Name = "numberLbl";
            this.numberLbl.Size = new System.Drawing.Size(91, 15);
            this.numberLbl.TabIndex = 3;
            this.numberLbl.Text = "Текущее число";
            // 
            // targetLbl
            // 
            this.targetLbl.AutoSize = true;
            this.targetLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.targetLbl.Location = new System.Drawing.Point(10, 55);
            this.targetLbl.Name = "targetLbl";
            this.targetLbl.Size = new System.Drawing.Size(94, 15);
            this.targetLbl.TabIndex = 4;
            this.targetLbl.Text = "Искомое число";
            // 
            // timeLbl
            // 
            this.timeLbl.AutoSize = true;
            this.timeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeLbl.Location = new System.Drawing.Point(10, 100);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(124, 15);
            this.timeLbl.TabIndex = 5;
            this.timeLbl.Text = "Затрачено времени";
            // 
            // number
            // 
            this.number.AutoSize = true;
            this.number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number.Location = new System.Drawing.Point(10, 30);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(19, 20);
            this.number.TabIndex = 6;
            this.number.Text = "0";
            // 
            // target
            // 
            this.target.AutoSize = true;
            this.target.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.target.Location = new System.Drawing.Point(10, 75);
            this.target.Name = "target";
            this.target.Size = new System.Drawing.Size(19, 20);
            this.target.TabIndex = 7;
            this.target.Text = "0";
            // 
            // timer
            // 
            this.timer.AutoSize = true;
            this.timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timer.Location = new System.Drawing.Point(10, 120);
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(69, 20);
            this.timer.TabIndex = 8;
            this.timer.Text = "0:00:00";
            // 
            // start
            // 
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.start.Location = new System.Drawing.Point(10, 190);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(215, 40);
            this.start.TabIndex = 9;
            this.start.Text = "Новая игра";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // playTime
            // 
            this.playTime.Interval = 1000;
            this.playTime.Tick += new System.EventHandler(this.playTime_Tick);
            // 
            // cancel
            // 
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancel.Location = new System.Drawing.Point(150, 100);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 40);
            this.cancel.TabIndex = 10;
            this.cancel.Text = "Отмена";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // info
            // 
            this.info.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.info.Location = new System.Drawing.Point(10, 235);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(215, 20);
            this.info.TabIndex = 0;
            this.info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 261);
            this.Controls.Add(this.info);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.start);
            this.Controls.Add(this.timer);
            this.Controls.Add(this.target);
            this.Controls.Add(this.number);
            this.Controls.Add(this.timeLbl);
            this.Controls.Add(this.targetLbl);
            this.Controls.Add(this.numberLbl);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.muliBtn);
            this.Controls.Add(this.plusBtn);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Удвоитель";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button plusBtn;
        private System.Windows.Forms.Button muliBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Label numberLbl;
        private System.Windows.Forms.Label targetLbl;
        private System.Windows.Forms.Label timeLbl;
        private System.Windows.Forms.Label number;
        private System.Windows.Forms.Label target;
        private System.Windows.Forms.Label timer;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Timer playTime;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label info;
    }
}

