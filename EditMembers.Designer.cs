
namespace CircleRacing
{
    partial class EditMembers
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
            this.AddMember_B = new System.Windows.Forms.Button();
            this.DeleteMember_B = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Start_B = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddMember_B
            // 
            this.AddMember_B.Location = new System.Drawing.Point(26, 328);
            this.AddMember_B.Name = "AddMember_B";
            this.AddMember_B.Size = new System.Drawing.Size(139, 65);
            this.AddMember_B.TabIndex = 1;
            this.AddMember_B.Text = "Добавить участника";
            this.AddMember_B.UseVisualStyleBackColor = true;
            this.AddMember_B.Click += new System.EventHandler(this.AddMember_B_Click);
            // 
            // DeleteMember_B
            // 
            this.DeleteMember_B.Location = new System.Drawing.Point(727, 328);
            this.DeleteMember_B.Name = "DeleteMember_B";
            this.DeleteMember_B.Size = new System.Drawing.Size(139, 57);
            this.DeleteMember_B.TabIndex = 2;
            this.DeleteMember_B.Text = "Удалить участника";
            this.DeleteMember_B.UseVisualStyleBackColor = true;
            this.DeleteMember_B.Click += new System.EventHandler(this.DeleteMember_B_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(12, 14);
            this.listBox1.Margin = new System.Windows.Forms.Padding(100);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(855, 304);
            this.listBox1.TabIndex = 3;
            // 
            // Start_B
            // 
            this.Start_B.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Start_B.Location = new System.Drawing.Point(376, 328);
            this.Start_B.Name = "Start_B";
            this.Start_B.Size = new System.Drawing.Size(158, 76);
            this.Start_B.TabIndex = 4;
            this.Start_B.Text = "Начать гонку";
            this.Start_B.UseVisualStyleBackColor = true;
            this.Start_B.Click += new System.EventHandler(this.Start_B_Click);
            // 
            // EditMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 511);
            this.Controls.Add(this.Start_B);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.DeleteMember_B);
            this.Controls.Add(this.AddMember_B);
            this.Name = "EditMembers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список участников";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditMembers_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button AddMember_B;
        private System.Windows.Forms.Button DeleteMember_B;
        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Start_B;
    }
}