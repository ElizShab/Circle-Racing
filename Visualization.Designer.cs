
namespace CircleRacing
{
    partial class Visualization
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
            this.components = new System.ComponentModel.Container();
            this.Move_T = new System.Windows.Forms.Timer(this.components);
            this.Picture_PB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_PB)).BeginInit();
            this.SuspendLayout();
            // 
            // Move_T
            // 
            this.Move_T.Tick += new System.EventHandler(this.Move_T_Tick);
            // 
            // Picture_PB
            // 
            this.Picture_PB.BackColor = System.Drawing.SystemColors.Control;
            this.Picture_PB.Location = new System.Drawing.Point(2, 0);
            this.Picture_PB.Name = "Picture_PB";
            this.Picture_PB.Size = new System.Drawing.Size(1003, 543);
            this.Picture_PB.TabIndex = 0;
            this.Picture_PB.TabStop = false;
            this.Picture_PB.Paint += new System.Windows.Forms.PaintEventHandler(this.Picture_PB_Paint);
            // 
            // Visualization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 555);
            this.Controls.Add(this.Picture_PB);
            this.Name = "Visualization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualization";
            ((System.ComponentModel.ISupportInitialize)(this.Picture_PB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer Move_T;
        private System.Windows.Forms.PictureBox Picture_PB;
    }
}