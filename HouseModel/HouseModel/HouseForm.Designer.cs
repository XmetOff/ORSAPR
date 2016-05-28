namespace House
{
    partial class HouseForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.BuildHouseButton = new System.Windows.Forms.Button();
            this.HouseWidth = new System.Windows.Forms.DomainUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HouseLength = new System.Windows.Forms.DomainUpDown();
            this.FloorCount = new System.Windows.Forms.DomainUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.WindowDistanceHor = new System.Windows.Forms.DomainUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.WindowDistanceVer = new System.Windows.Forms.DomainUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.WindowHeight = new System.Windows.Forms.DomainUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.WindowWidth = new System.Windows.Forms.DomainUpDown();
            this.BalconHeight = new System.Windows.Forms.DomainUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.BalconWidth = new System.Windows.Forms.DomainUpDown();
            this.BalconLength = new System.Windows.Forms.DomainUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.DoorHeight = new System.Windows.Forms.DomainUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.PeakLength = new System.Windows.Forms.DomainUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.DoorWidth = new System.Windows.Forms.DomainUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BuildHouseButton
            // 
            this.BuildHouseButton.Location = new System.Drawing.Point(88, 370);
            this.BuildHouseButton.Name = "BuildHouseButton";
            this.BuildHouseButton.Size = new System.Drawing.Size(89, 44);
            this.BuildHouseButton.TabIndex = 0;
            this.BuildHouseButton.Text = "Построить дом";
            this.BuildHouseButton.UseVisualStyleBackColor = true;
            this.BuildHouseButton.Click += new System.EventHandler(this.buildHouseButton_Click);
            // 
            // HouseWidth
            // 
            this.HouseWidth.Location = new System.Drawing.Point(165, 22);
            this.HouseWidth.Name = "HouseWidth";
            this.HouseWidth.Size = new System.Drawing.Size(97, 20);
            this.HouseWidth.TabIndex = 1;
            this.HouseWidth.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ширина дома";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Длина дома";
            // 
            // HouseLength
            // 
            this.HouseLength.Location = new System.Drawing.Point(165, 48);
            this.HouseLength.Name = "HouseLength";
            this.HouseLength.Size = new System.Drawing.Size(97, 20);
            this.HouseLength.TabIndex = 4;
            this.HouseLength.Text = "0";
            // 
            // FloorCount
            // 
            this.FloorCount.Location = new System.Drawing.Point(165, 74);
            this.FloorCount.Name = "FloorCount";
            this.FloorCount.Size = new System.Drawing.Size(97, 20);
            this.FloorCount.TabIndex = 5;
            this.FloorCount.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Количество этажей";
            // 
            // WindowDistanceHor
            // 
            this.WindowDistanceHor.Location = new System.Drawing.Point(165, 152);
            this.WindowDistanceHor.Name = "WindowDistanceHor";
            this.WindowDistanceHor.Size = new System.Drawing.Size(97, 20);
            this.WindowDistanceHor.TabIndex = 7;
            this.WindowDistanceHor.Text = "0";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(9, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "Расстояние между окнами по горизонтали";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(9, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 30);
            this.label5.TabIndex = 9;
            this.label5.Text = "Расстояние между окнами по вертикали";
            // 
            // WindowDistanceVer
            // 
            this.WindowDistanceVer.Location = new System.Drawing.Point(165, 178);
            this.WindowDistanceVer.Name = "WindowDistanceVer";
            this.WindowDistanceVer.Size = new System.Drawing.Size(97, 20);
            this.WindowDistanceVer.TabIndex = 10;
            this.WindowDistanceVer.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Высота окна";
            // 
            // WindowHeight
            // 
            this.WindowHeight.Location = new System.Drawing.Point(165, 100);
            this.WindowHeight.Name = "WindowHeight";
            this.WindowHeight.Size = new System.Drawing.Size(97, 20);
            this.WindowHeight.TabIndex = 12;
            this.WindowHeight.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Ширина окна";
            // 
            // WindowWidth
            // 
            this.WindowWidth.Location = new System.Drawing.Point(165, 126);
            this.WindowWidth.Name = "WindowWidth";
            this.WindowWidth.Size = new System.Drawing.Size(97, 20);
            this.WindowWidth.TabIndex = 14;
            this.WindowWidth.Text = "0";
            // 
            // BalconHeight
            // 
            this.BalconHeight.Location = new System.Drawing.Point(165, 204);
            this.BalconHeight.Name = "BalconHeight";
            this.BalconHeight.Size = new System.Drawing.Size(97, 20);
            this.BalconHeight.TabIndex = 15;
            this.BalconHeight.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Высота балкона";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 232);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Ширина балкона";
            // 
            // BalconWidth
            // 
            this.BalconWidth.Location = new System.Drawing.Point(165, 230);
            this.BalconWidth.Name = "BalconWidth";
            this.BalconWidth.Size = new System.Drawing.Size(97, 20);
            this.BalconWidth.TabIndex = 18;
            this.BalconWidth.Text = "0";
            // 
            // BalconLength
            // 
            this.BalconLength.Location = new System.Drawing.Point(165, 256);
            this.BalconLength.Name = "BalconLength";
            this.BalconLength.Size = new System.Drawing.Size(97, 20);
            this.BalconLength.TabIndex = 19;
            this.BalconLength.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 258);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Длина балкона";
            // 
            // DoorHeight
            // 
            this.DoorHeight.Location = new System.Drawing.Point(165, 282);
            this.DoorHeight.Name = "DoorHeight";
            this.DoorHeight.Size = new System.Drawing.Size(97, 20);
            this.DoorHeight.TabIndex = 21;
            this.DoorHeight.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 284);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Высота двери";
            // 
            // PeakLength
            // 
            this.PeakLength.Location = new System.Drawing.Point(165, 334);
            this.PeakLength.Name = "PeakLength";
            this.PeakLength.Size = new System.Drawing.Size(97, 20);
            this.PeakLength.TabIndex = 23;
            this.PeakLength.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 336);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Длина козырька";
            // 
            // DoorWidth
            // 
            this.DoorWidth.Location = new System.Drawing.Point(165, 308);
            this.DoorWidth.Name = "DoorWidth";
            this.DoorWidth.Size = new System.Drawing.Size(97, 20);
            this.DoorWidth.TabIndex = 25;
            this.DoorWidth.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 310);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Ширина двери";
            // 
            // HouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 426);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.DoorWidth);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.PeakLength);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.DoorHeight);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.BalconLength);
            this.Controls.Add(this.BalconWidth);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BalconHeight);
            this.Controls.Add(this.WindowWidth);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.WindowHeight);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.WindowDistanceVer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.WindowDistanceHor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FloorCount);
            this.Controls.Add(this.HouseLength);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HouseWidth);
            this.Controls.Add(this.BuildHouseButton);
            this.Name = "HouseForm";
            this.Text = "Жилой дом";
            this.Load += new System.EventHandler(this.HouseForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BuildHouseButton;
        private System.Windows.Forms.DomainUpDown HouseWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DomainUpDown HouseLength;
        private System.Windows.Forms.DomainUpDown FloorCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DomainUpDown WindowDistanceHor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DomainUpDown WindowDistanceVer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DomainUpDown WindowHeight;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DomainUpDown WindowWidth;
        private System.Windows.Forms.DomainUpDown BalconHeight;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DomainUpDown BalconWidth;
        private System.Windows.Forms.DomainUpDown BalconLength;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DomainUpDown DoorHeight;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DomainUpDown PeakLength;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DomainUpDown DoorWidth;
        private System.Windows.Forms.Label label13;
    }
}

