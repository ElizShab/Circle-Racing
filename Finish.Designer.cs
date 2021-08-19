
namespace CircleRacing
{
    partial class Finish
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
            this.Repeat_B = new System.Windows.Forms.Button();
            this.BackMenu_B = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Repeat_B
            // 
            this.Repeat_B.Location = new System.Drawing.Point(143, 390);
            this.Repeat_B.Name = "Repeat_B";
            this.Repeat_B.Size = new System.Drawing.Size(173, 29);
            this.Repeat_B.TabIndex = 0;
            this.Repeat_B.Text = "Ещё один круг";
            this.Repeat_B.UseVisualStyleBackColor = true;
            this.Repeat_B.Click += new System.EventHandler(this.Repeat_B_Click);
            // 
            // BackMenu_B
            // 
            this.BackMenu_B.Location = new System.Drawing.Point(143, 431);
            this.BackMenu_B.Name = "BackMenu_B";
            this.BackMenu_B.Size = new System.Drawing.Size(173, 70);
            this.BackMenu_B.TabIndex = 1;
            this.BackMenu_B.Text = "Перейти в главное меню";
            this.BackMenu_B.UseVisualStyleBackColor = true;
            this.BackMenu_B.Click += new System.EventHandler(this.BackMenu_B_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 28;
            this.listBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.listBox1.Location = new System.Drawing.Point(12, 63);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(448, 312);
            this.listBox1.TabIndex = 2;
            // 
            // Finish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 514);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.BackMenu_B);
            this.Controls.Add(this.Repeat_B);
            this.Name = "Finish";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Результат гонки";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Repeat_B;
        private System.Windows.Forms.Button BackMenu_B;
        private System.Windows.Forms.ListBox listBox1;
    }
}