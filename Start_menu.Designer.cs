
namespace CircleRacing
{
    partial class Start_menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Start_B = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TrackLength_NUD = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.EditListMembers_B = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TrackLength_NUD)).BeginInit();
            this.SuspendLayout();
            // 
            // Start_B
            // 
            this.Start_B.Location = new System.Drawing.Point(129, 227);
            this.Start_B.Name = "Start_B";
            this.Start_B.Size = new System.Drawing.Size(118, 57);
            this.Start_B.TabIndex = 0;
            this.Start_B.Text = "Перейти к гонке";
            this.Start_B.UseVisualStyleBackColor = true;
            this.Start_B.Click += new System.EventHandler(this.Start_B_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Длина трассы";
            // 
            // TrackLength_NUD
            // 
            this.TrackLength_NUD.Location = new System.Drawing.Point(205, 176);
            this.TrackLength_NUD.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.TrackLength_NUD.Minimum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.TrackLength_NUD.Name = "TrackLength_NUD";
            this.TrackLength_NUD.Size = new System.Drawing.Size(70, 27);
            this.TrackLength_NUD.TabIndex = 2;
            this.TrackLength_NUD.Value = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.TrackLength_NUD.ValueChanged += new System.EventHandler(this.TrackLength_NUD_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Количество участников: 0";
            // 
            // EditListMembers_B
            // 
            this.EditListMembers_B.Location = new System.Drawing.Point(330, 12);
            this.EditListMembers_B.Name = "EditListMembers_B";
            this.EditListMembers_B.Size = new System.Drawing.Size(33, 29);
            this.EditListMembers_B.TabIndex = 4;
            this.EditListMembers_B.Text = "button1";
            this.EditListMembers_B.UseVisualStyleBackColor = true;
            this.EditListMembers_B.Click += new System.EventHandler(this.EditListMembers_B_Click);
            // 
            // Start_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 296);
            this.Controls.Add(this.EditListMembers_B);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TrackLength_NUD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Start_B);
            this.Name = "Start_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.Shown += new System.EventHandler(this.Start_menu_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.TrackLength_NUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start_B;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EditListMembers_B;
        public System.Windows.Forms.NumericUpDown TrackLength_NUD;
        public System.Windows.Forms.Label label2;
    }
}

