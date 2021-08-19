
namespace CircleRacing
{
    partial class ConfigurationPanel
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
            this.PeopleInAuto_NUD = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AutoPunctureProbability_Text = new System.Windows.Forms.TextBox();
            this.Auto_GB = new System.Windows.Forms.GroupBox();
            this.ASpeed_L = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.AutoSpeed_TB = new System.Windows.Forms.TrackBar();
            this.RegAuto_B = new System.Windows.Forms.Button();
            this.Truck_GB = new System.Windows.Forms.GroupBox();
            this.TSpeed_L = new System.Windows.Forms.Label();
            this.TruckSpeed_TB = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.RegTruck_B = new System.Windows.Forms.Button();
            this.TruckWeight_Text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TruckPunctureProbability_Text = new System.Windows.Forms.TextBox();
            this.Motorcycle_GB = new System.Windows.Forms.GroupBox();
            this.MSpeed_L = new System.Windows.Forms.Label();
            this.RegMotorcycle_B = new System.Windows.Forms.Button();
            this.MotorSpeed_TB = new System.Windows.Forms.TrackBar();
            this.label13 = new System.Windows.Forms.Label();
            this.Presence_Chek = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.MotorPunctureProbability_Text = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PeopleInAuto_NUD)).BeginInit();
            this.Auto_GB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AutoSpeed_TB)).BeginInit();
            this.Truck_GB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TruckSpeed_TB)).BeginInit();
            this.Motorcycle_GB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MotorSpeed_TB)).BeginInit();
            this.SuspendLayout();
            // 
            // PeopleInAuto_NUD
            // 
            this.PeopleInAuto_NUD.Location = new System.Drawing.Point(226, 114);
            this.PeopleInAuto_NUD.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.PeopleInAuto_NUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PeopleInAuto_NUD.Name = "PeopleInAuto_NUD";
            this.PeopleInAuto_NUD.Size = new System.Drawing.Size(54, 27);
            this.PeopleInAuto_NUD.TabIndex = 1;
            this.PeopleInAuto_NUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Количество чел.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Скорость";
            // 
            // AutoPunctureProbability_Text
            // 
            this.AutoPunctureProbability_Text.Location = new System.Drawing.Point(226, 75);
            this.AutoPunctureProbability_Text.Name = "AutoPunctureProbability_Text";
            this.AutoPunctureProbability_Text.Size = new System.Drawing.Size(101, 27);
            this.AutoPunctureProbability_Text.TabIndex = 4;
            // 
            // Auto_GB
            // 
            this.Auto_GB.Controls.Add(this.ASpeed_L);
            this.Auto_GB.Controls.Add(this.label11);
            this.Auto_GB.Controls.Add(this.AutoSpeed_TB);
            this.Auto_GB.Controls.Add(this.RegAuto_B);
            this.Auto_GB.Controls.Add(this.PeopleInAuto_NUD);
            this.Auto_GB.Controls.Add(this.label2);
            this.Auto_GB.Controls.Add(this.AutoPunctureProbability_Text);
            this.Auto_GB.Controls.Add(this.label3);
            this.Auto_GB.Location = new System.Drawing.Point(3, 126);
            this.Auto_GB.Name = "Auto_GB";
            this.Auto_GB.Size = new System.Drawing.Size(360, 190);
            this.Auto_GB.TabIndex = 7;
            this.Auto_GB.TabStop = false;
            this.Auto_GB.Text = "Автомобиль";
            // 
            // ASpeed_L
            // 
            this.ASpeed_L.AutoSize = true;
            this.ASpeed_L.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ASpeed_L.Location = new System.Drawing.Point(153, 43);
            this.ASpeed_L.Name = "ASpeed_L";
            this.ASpeed_L.Size = new System.Drawing.Size(17, 20);
            this.ASpeed_L.TabIndex = 12;
            this.ASpeed_L.Text = "1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(211, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "Вероятность прокола колеса";
            // 
            // AutoSpeed_TB
            // 
            this.AutoSpeed_TB.Location = new System.Drawing.Point(209, 18);
            this.AutoSpeed_TB.Maximum = 120;
            this.AutoSpeed_TB.Minimum = 1;
            this.AutoSpeed_TB.Name = "AutoSpeed_TB";
            this.AutoSpeed_TB.Size = new System.Drawing.Size(143, 56);
            this.AutoSpeed_TB.SmallChange = 5;
            this.AutoSpeed_TB.TabIndex = 12;
            this.AutoSpeed_TB.Value = 60;
            this.AutoSpeed_TB.Scroll += new System.EventHandler(this.AutoSpeed_TB_Scroll);
            // 
            // RegAuto_B
            // 
            this.RegAuto_B.Location = new System.Drawing.Point(6, 155);
            this.RegAuto_B.Name = "RegAuto_B";
            this.RegAuto_B.Size = new System.Drawing.Size(346, 29);
            this.RegAuto_B.TabIndex = 10;
            this.RegAuto_B.Text = "Зарегистрировать";
            this.RegAuto_B.UseVisualStyleBackColor = true;
            this.RegAuto_B.Click += new System.EventHandler(this.RegAuto_B_Click);
            // 
            // Truck_GB
            // 
            this.Truck_GB.Controls.Add(this.TSpeed_L);
            this.Truck_GB.Controls.Add(this.TruckSpeed_TB);
            this.Truck_GB.Controls.Add(this.label6);
            this.Truck_GB.Controls.Add(this.RegTruck_B);
            this.Truck_GB.Controls.Add(this.TruckWeight_Text);
            this.Truck_GB.Controls.Add(this.label1);
            this.Truck_GB.Controls.Add(this.label5);
            this.Truck_GB.Controls.Add(this.TruckPunctureProbability_Text);
            this.Truck_GB.Location = new System.Drawing.Point(369, 126);
            this.Truck_GB.Name = "Truck_GB";
            this.Truck_GB.Size = new System.Drawing.Size(399, 190);
            this.Truck_GB.TabIndex = 8;
            this.Truck_GB.TabStop = false;
            this.Truck_GB.Text = "Грузовик";
            // 
            // TSpeed_L
            // 
            this.TSpeed_L.AutoSize = true;
            this.TSpeed_L.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TSpeed_L.Location = new System.Drawing.Point(176, 43);
            this.TSpeed_L.Name = "TSpeed_L";
            this.TSpeed_L.Size = new System.Drawing.Size(17, 20);
            this.TSpeed_L.TabIndex = 15;
            this.TSpeed_L.Text = "1";
            // 
            // TruckSpeed_TB
            // 
            this.TruckSpeed_TB.Location = new System.Drawing.Point(238, 17);
            this.TruckSpeed_TB.Maximum = 180;
            this.TruckSpeed_TB.Minimum = 1;
            this.TruckSpeed_TB.Name = "TruckSpeed_TB";
            this.TruckSpeed_TB.Size = new System.Drawing.Size(143, 56);
            this.TruckSpeed_TB.SmallChange = 5;
            this.TruckSpeed_TB.TabIndex = 14;
            this.TruckSpeed_TB.Value = 60;
            this.TruckSpeed_TB.Scroll += new System.EventHandler(this.TruckSpeed_TB_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(161, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Скорость";
            // 
            // RegTruck_B
            // 
            this.RegTruck_B.Location = new System.Drawing.Point(7, 155);
            this.RegTruck_B.Name = "RegTruck_B";
            this.RegTruck_B.Size = new System.Drawing.Size(386, 29);
            this.RegTruck_B.TabIndex = 11;
            this.RegTruck_B.Text = "Зарегистрировать";
            this.RegTruck_B.UseVisualStyleBackColor = true;
            this.RegTruck_B.Click += new System.EventHandler(this.RegTruck_B_Click);
            // 
            // TruckWeight_Text
            // 
            this.TruckWeight_Text.Location = new System.Drawing.Point(240, 114);
            this.TruckWeight_Text.Name = "TruckWeight_Text";
            this.TruckWeight_Text.Size = new System.Drawing.Size(125, 27);
            this.TruckWeight_Text.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Вероятность прокола колеса";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(161, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Вес груза";
            // 
            // TruckPunctureProbability_Text
            // 
            this.TruckPunctureProbability_Text.Location = new System.Drawing.Point(240, 76);
            this.TruckPunctureProbability_Text.Name = "TruckPunctureProbability_Text";
            this.TruckPunctureProbability_Text.Size = new System.Drawing.Size(125, 27);
            this.TruckPunctureProbability_Text.TabIndex = 4;
            // 
            // Motorcycle_GB
            // 
            this.Motorcycle_GB.Controls.Add(this.MSpeed_L);
            this.Motorcycle_GB.Controls.Add(this.RegMotorcycle_B);
            this.Motorcycle_GB.Controls.Add(this.MotorSpeed_TB);
            this.Motorcycle_GB.Controls.Add(this.label13);
            this.Motorcycle_GB.Controls.Add(this.Presence_Chek);
            this.Motorcycle_GB.Controls.Add(this.label7);
            this.Motorcycle_GB.Controls.Add(this.label8);
            this.Motorcycle_GB.Controls.Add(this.MotorPunctureProbability_Text);
            this.Motorcycle_GB.Location = new System.Drawing.Point(774, 126);
            this.Motorcycle_GB.Name = "Motorcycle_GB";
            this.Motorcycle_GB.Size = new System.Drawing.Size(394, 190);
            this.Motorcycle_GB.TabIndex = 9;
            this.Motorcycle_GB.TabStop = false;
            this.Motorcycle_GB.Text = "Мотоцикл";
            // 
            // MSpeed_L
            // 
            this.MSpeed_L.AutoSize = true;
            this.MSpeed_L.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MSpeed_L.Location = new System.Drawing.Point(177, 48);
            this.MSpeed_L.Name = "MSpeed_L";
            this.MSpeed_L.Size = new System.Drawing.Size(17, 20);
            this.MSpeed_L.TabIndex = 15;
            this.MSpeed_L.Text = "1";
            // 
            // RegMotorcycle_B
            // 
            this.RegMotorcycle_B.Location = new System.Drawing.Point(4, 155);
            this.RegMotorcycle_B.Name = "RegMotorcycle_B";
            this.RegMotorcycle_B.Size = new System.Drawing.Size(386, 29);
            this.RegMotorcycle_B.TabIndex = 12;
            this.RegMotorcycle_B.Text = "Зарегистрировать";
            this.RegMotorcycle_B.UseVisualStyleBackColor = true;
            this.RegMotorcycle_B.Click += new System.EventHandler(this.RegMotorcycle_B_Click);
            // 
            // MotorSpeed_TB
            // 
            this.MotorSpeed_TB.Location = new System.Drawing.Point(233, 20);
            this.MotorSpeed_TB.Maximum = 150;
            this.MotorSpeed_TB.Minimum = 1;
            this.MotorSpeed_TB.Name = "MotorSpeed_TB";
            this.MotorSpeed_TB.Size = new System.Drawing.Size(143, 56);
            this.MotorSpeed_TB.SmallChange = 5;
            this.MotorSpeed_TB.TabIndex = 14;
            this.MotorSpeed_TB.Value = 60;
            this.MotorSpeed_TB.Scroll += new System.EventHandler(this.MotorSpeed_TB_Scroll);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(162, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 20);
            this.label13.TabIndex = 13;
            this.label13.Text = "Скорость";
            // 
            // Presence_Chek
            // 
            this.Presence_Chek.AutoSize = true;
            this.Presence_Chek.Location = new System.Drawing.Point(241, 124);
            this.Presence_Chek.Name = "Presence_Chek";
            this.Presence_Chek.Size = new System.Drawing.Size(18, 17);
            this.Presence_Chek.TabIndex = 7;
            this.Presence_Chek.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(211, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Вероятность прокола колеса";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(106, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Наличие коляски";
            // 
            // MotorPunctureProbability_Text
            // 
            this.MotorPunctureProbability_Text.Location = new System.Drawing.Point(241, 79);
            this.MotorPunctureProbability_Text.Name = "MotorPunctureProbability_Text";
            this.MotorPunctureProbability_Text.Size = new System.Drawing.Size(125, 27);
            this.MotorPunctureProbability_Text.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(74, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(1061, 46);
            this.label10.TabIndex = 11;
            this.label10.Text = "Зарегистрируйте свои транспортные средства для участия в гонке";
            // 
            // ConfigurationPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 338);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Motorcycle_GB);
            this.Controls.Add(this.Truck_GB);
            this.Controls.Add(this.Auto_GB);
            this.Name = "ConfigurationPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация транспортных средств";
            ((System.ComponentModel.ISupportInitialize)(this.PeopleInAuto_NUD)).EndInit();
            this.Auto_GB.ResumeLayout(false);
            this.Auto_GB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AutoSpeed_TB)).EndInit();
            this.Truck_GB.ResumeLayout(false);
            this.Truck_GB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TruckSpeed_TB)).EndInit();
            this.Motorcycle_GB.ResumeLayout(false);
            this.Motorcycle_GB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MotorSpeed_TB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown PeopleInAuto_NUD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AutoPunctureProbability_Text;
        private System.Windows.Forms.GroupBox Auto_GB;
        private System.Windows.Forms.GroupBox Truck_GB;
        private System.Windows.Forms.TextBox TruckWeight_Text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TruckPunctureProbability_Text;
        private System.Windows.Forms.GroupBox Motorcycle_GB;
        private System.Windows.Forms.CheckBox Presence_Chek;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox MotorPunctureProbability_Text;
        private System.Windows.Forms.Button RegAuto_B;
        private System.Windows.Forms.Button RegTruck_B;
        private System.Windows.Forms.Button RegMotorcycle_B;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TrackBar AutoSpeed_TB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label ASpeed_L;
        private System.Windows.Forms.Label TSpeed_L;
        private System.Windows.Forms.TrackBar TruckSpeed_TB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label MSpeed_L;
        private System.Windows.Forms.TrackBar MotorSpeed_TB;
        private System.Windows.Forms.Label label13;
    }
}