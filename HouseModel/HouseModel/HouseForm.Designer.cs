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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.RunInventorButton = new System.Windows.Forms.Button();
            this.SterssTestButton = new System.Windows.Forms.Button();
            this.PeakLength = new House.ParameterObjectControl();
            this.DoorWidth = new House.ParameterObjectControl();
            this.DoorHeight = new House.ParameterObjectControl();
            this.BalconLength = new House.ParameterObjectControl();
            this.BalconWidth = new House.ParameterObjectControl();
            this.BalconHeight = new House.ParameterObjectControl();
            this.WindowDistanceVer = new House.ParameterObjectControl();
            this.WindowDistanceHor = new House.ParameterObjectControl();
            this.WindowWidth = new House.ParameterObjectControl();
            this.WindowHeight = new House.ParameterObjectControl();
            this.FloorsCount = new House.ParameterObjectControl();
            this.HouseLength = new House.ParameterObjectControl();
            this.HouseWidth = new House.ParameterObjectControl();
            this.ChangeArcComboBox = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.ArcHeight = new House.ParameterObjectControl();
            this.label15 = new System.Windows.Forms.Label();
            this.ArcWidth = new House.ParameterObjectControl();
            this.label16 = new System.Windows.Forms.Label();
            this.StartPoint = new House.ParameterObjectControl();
            this.label17 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BuildHouseButton
            // 
            this.BuildHouseButton.Location = new System.Drawing.Point(103, 479);
            this.BuildHouseButton.Name = "BuildHouseButton";
            this.BuildHouseButton.Size = new System.Drawing.Size(89, 44);
            this.BuildHouseButton.TabIndex = 0;
            this.BuildHouseButton.Text = "Построить дом";
            this.BuildHouseButton.UseVisualStyleBackColor = true;
            this.BuildHouseButton.Click += new System.EventHandler(this.buildHouseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ширина дома";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Длина дома";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Количество этажей";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(5, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "Расстояние между окнами по горизонтали";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(5, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 30);
            this.label5.TabIndex = 9;
            this.label5.Text = "Расстояние между окнами по вертикали";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Высота окна";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Ширина окна";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Высота балкона";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 258);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Ширина балкона";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 284);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Длина балкона";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 310);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Высота двери";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 362);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Длина козырька";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 336);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Ширина двери";
            // 
            // RunInventorButton
            // 
            this.RunInventorButton.Location = new System.Drawing.Point(8, 479);
            this.RunInventorButton.Name = "RunInventorButton";
            this.RunInventorButton.Size = new System.Drawing.Size(89, 44);
            this.RunInventorButton.TabIndex = 40;
            this.RunInventorButton.Text = "Запустить Inventor";
            this.RunInventorButton.UseVisualStyleBackColor = true;
            this.RunInventorButton.Click += new System.EventHandler(this.RunInventorButton_Click);
            // 
            // SterssTestButton
            // 
            this.SterssTestButton.Location = new System.Drawing.Point(198, 479);
            this.SterssTestButton.Name = "SterssTestButton";
            this.SterssTestButton.Size = new System.Drawing.Size(89, 44);
            this.SterssTestButton.TabIndex = 41;
            this.SterssTestButton.Text = "Нагрузочное тестиование";
            this.SterssTestButton.UseVisualStyleBackColor = true;
            this.SterssTestButton.Click += new System.EventHandler(this.SterssTestButton_Click);
            // 
            // PeakLength
            // 
            this.PeakLength.Location = new System.Drawing.Point(177, 360);
            this.PeakLength.Name = "PeakLength";
            this.PeakLength.Parameter = null;
            this.PeakLength.Size = new System.Drawing.Size(110, 30);
            this.PeakLength.TabIndex = 39;
            // 
            // DoorWidth
            // 
            this.DoorWidth.Location = new System.Drawing.Point(177, 334);
            this.DoorWidth.Name = "DoorWidth";
            this.DoorWidth.Parameter = null;
            this.DoorWidth.Size = new System.Drawing.Size(110, 25);
            this.DoorWidth.TabIndex = 38;
            // 
            // DoorHeight
            // 
            this.DoorHeight.Location = new System.Drawing.Point(177, 308);
            this.DoorHeight.Name = "DoorHeight";
            this.DoorHeight.Parameter = null;
            this.DoorHeight.Size = new System.Drawing.Size(110, 27);
            this.DoorHeight.TabIndex = 37;
            // 
            // BalconLength
            // 
            this.BalconLength.Location = new System.Drawing.Point(177, 282);
            this.BalconLength.Name = "BalconLength";
            this.BalconLength.Parameter = null;
            this.BalconLength.Size = new System.Drawing.Size(110, 27);
            this.BalconLength.TabIndex = 36;
            // 
            // BalconWidth
            // 
            this.BalconWidth.Location = new System.Drawing.Point(177, 257);
            this.BalconWidth.Name = "BalconWidth";
            this.BalconWidth.Parameter = null;
            this.BalconWidth.Size = new System.Drawing.Size(110, 26);
            this.BalconWidth.TabIndex = 35;
            // 
            // BalconHeight
            // 
            this.BalconHeight.Location = new System.Drawing.Point(177, 230);
            this.BalconHeight.Name = "BalconHeight";
            this.BalconHeight.Parameter = null;
            this.BalconHeight.Size = new System.Drawing.Size(110, 30);
            this.BalconHeight.TabIndex = 34;
            // 
            // WindowDistanceVer
            // 
            this.WindowDistanceVer.Location = new System.Drawing.Point(177, 204);
            this.WindowDistanceVer.Name = "WindowDistanceVer";
            this.WindowDistanceVer.Parameter = null;
            this.WindowDistanceVer.Size = new System.Drawing.Size(110, 28);
            this.WindowDistanceVer.TabIndex = 33;
            // 
            // WindowDistanceHor
            // 
            this.WindowDistanceHor.Location = new System.Drawing.Point(177, 178);
            this.WindowDistanceHor.Name = "WindowDistanceHor";
            this.WindowDistanceHor.Parameter = null;
            this.WindowDistanceHor.Size = new System.Drawing.Size(110, 29);
            this.WindowDistanceHor.TabIndex = 32;
            // 
            // WindowWidth
            // 
            this.WindowWidth.Location = new System.Drawing.Point(177, 152);
            this.WindowWidth.Name = "WindowWidth";
            this.WindowWidth.Parameter = null;
            this.WindowWidth.Size = new System.Drawing.Size(110, 27);
            this.WindowWidth.TabIndex = 31;
            // 
            // WindowHeight
            // 
            this.WindowHeight.Location = new System.Drawing.Point(177, 126);
            this.WindowHeight.Name = "WindowHeight";
            this.WindowHeight.Parameter = null;
            this.WindowHeight.Size = new System.Drawing.Size(110, 27);
            this.WindowHeight.TabIndex = 30;
            // 
            // FloorsCount
            // 
            this.FloorsCount.Location = new System.Drawing.Point(177, 100);
            this.FloorsCount.Name = "FloorsCount";
            this.FloorsCount.Parameter = null;
            this.FloorsCount.Size = new System.Drawing.Size(110, 28);
            this.FloorsCount.TabIndex = 29;
            // 
            // HouseLength
            // 
            this.HouseLength.Location = new System.Drawing.Point(177, 74);
            this.HouseLength.Name = "HouseLength";
            this.HouseLength.Parameter = null;
            this.HouseLength.Size = new System.Drawing.Size(110, 27);
            this.HouseLength.TabIndex = 28;
            // 
            // HouseWidth
            // 
            this.HouseWidth.Location = new System.Drawing.Point(177, 48);
            this.HouseWidth.Name = "HouseWidth";
            this.HouseWidth.Parameter = null;
            this.HouseWidth.Size = new System.Drawing.Size(110, 26);
            this.HouseWidth.TabIndex = 27;
            // 
            // ChangeArcComboBox
            // 
            this.ChangeArcComboBox.FormattingEnabled = true;
            this.ChangeArcComboBox.Location = new System.Drawing.Point(177, 21);
            this.ChangeArcComboBox.Name = "ChangeArcComboBox";
            this.ChangeArcComboBox.Size = new System.Drawing.Size(110, 21);
            this.ChangeArcComboBox.TabIndex = 42;
            this.ChangeArcComboBox.SelectedIndexChanged += new System.EventHandler(this.ChangeArcComboBox_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(5, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 13);
            this.label14.TabIndex = 43;
            this.label14.Text = "Наличие арки";
            // 
            // ArcHeight
            // 
            this.ArcHeight.Location = new System.Drawing.Point(177, 386);
            this.ArcHeight.Name = "ArcHeight";
            this.ArcHeight.Parameter = null;
            this.ArcHeight.Size = new System.Drawing.Size(106, 24);
            this.ArcHeight.TabIndex = 44;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(5, 390);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 13);
            this.label15.TabIndex = 45;
            this.label15.Text = "Высота арки";
            // 
            // ArcWidth
            // 
            this.ArcWidth.Location = new System.Drawing.Point(177, 413);
            this.ArcWidth.Name = "ArcWidth";
            this.ArcWidth.Parameter = null;
            this.ArcWidth.Size = new System.Drawing.Size(106, 24);
            this.ArcWidth.TabIndex = 46;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(5, 417);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 13);
            this.label16.TabIndex = 47;
            this.label16.Text = "Ширина арки";
            // 
            // StartPoint
            // 
            this.StartPoint.Location = new System.Drawing.Point(177, 439);
            this.StartPoint.Name = "StartPoint";
            this.StartPoint.Parameter = null;
            this.StartPoint.Size = new System.Drawing.Size(106, 24);
            this.StartPoint.TabIndex = 48;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(5, 444);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(132, 13);
            this.label17.TabIndex = 49;
            this.label17.Text = "Координата начала арки";
            // 
            // HouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 530);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.StartPoint);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.ArcWidth);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.ArcHeight);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.ChangeArcComboBox);
            this.Controls.Add(this.SterssTestButton);
            this.Controls.Add(this.RunInventorButton);
            this.Controls.Add(this.PeakLength);
            this.Controls.Add(this.DoorWidth);
            this.Controls.Add(this.DoorHeight);
            this.Controls.Add(this.BalconLength);
            this.Controls.Add(this.BalconWidth);
            this.Controls.Add(this.BalconHeight);
            this.Controls.Add(this.WindowDistanceVer);
            this.Controls.Add(this.WindowDistanceHor);
            this.Controls.Add(this.WindowWidth);
            this.Controls.Add(this.WindowHeight);
            this.Controls.Add(this.FloorsCount);
            this.Controls.Add(this.HouseLength);
            this.Controls.Add(this.HouseWidth);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BuildHouseButton);
            this.Name = "HouseForm";
            this.Text = "Жилой дом";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BuildHouseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private ParameterObjectControl HouseWidth;
        private ParameterObjectControl HouseLength;
        private ParameterObjectControl FloorsCount;
        private ParameterObjectControl WindowHeight;
        private ParameterObjectControl WindowWidth;
        private ParameterObjectControl WindowDistanceHor;
        private ParameterObjectControl WindowDistanceVer;
        private ParameterObjectControl BalconHeight;
        private ParameterObjectControl BalconWidth;
        private ParameterObjectControl BalconLength;
        private ParameterObjectControl DoorHeight;
        private ParameterObjectControl DoorWidth;
        private ParameterObjectControl PeakLength;
        private System.Windows.Forms.Button RunInventorButton;
        private System.Windows.Forms.Button SterssTestButton;
        private System.Windows.Forms.ComboBox ChangeArcComboBox;
        private System.Windows.Forms.Label label14;
        private ParameterObjectControl ArcHeight;
        private System.Windows.Forms.Label label15;
        private ParameterObjectControl ArcWidth;
        private System.Windows.Forms.Label label16;
        private ParameterObjectControl StartPoint;
        private System.Windows.Forms.Label label17;
    }
}

