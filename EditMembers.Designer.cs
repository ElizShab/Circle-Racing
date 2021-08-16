
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AddMember_B = new System.Windows.Forms.Button();
            this.DeleteMember_B = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(575, 426);
            this.dataGridView1.TabIndex = 0;
            // 
            // AddMember_B
            // 
            this.AddMember_B.Location = new System.Drawing.Point(615, 308);
            this.AddMember_B.Name = "AddMember_B";
            this.AddMember_B.Size = new System.Drawing.Size(139, 65);
            this.AddMember_B.TabIndex = 1;
            this.AddMember_B.Text = "Добавить участника";
            this.AddMember_B.UseVisualStyleBackColor = true;
            this.AddMember_B.Click += new System.EventHandler(this.AddMember_B_Click);
            // 
            // DeleteMember_B
            // 
            this.DeleteMember_B.Location = new System.Drawing.Point(615, 388);
            this.DeleteMember_B.Name = "DeleteMember_B";
            this.DeleteMember_B.Size = new System.Drawing.Size(139, 50);
            this.DeleteMember_B.TabIndex = 2;
            this.DeleteMember_B.Text = "Удалить участника";
            this.DeleteMember_B.UseVisualStyleBackColor = true;
            // 
            // EditMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteMember_B);
            this.Controls.Add(this.AddMember_B);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EditMembers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditMembers";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddMember_B;
        private System.Windows.Forms.Button DeleteMember_B;
    }
}