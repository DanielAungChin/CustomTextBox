
namespace CustomTextBox
{
    partial class TxtBoxUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Control_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Control_textBox
            // 
            this.Control_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Control_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Control_textBox.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Control_textBox.Location = new System.Drawing.Point(0, 0);
            this.Control_textBox.Name = "Control_textBox";
            this.Control_textBox.Size = new System.Drawing.Size(336, 32);
            this.Control_textBox.TabIndex = 0;
            // 
            // TxtBoxUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Control_textBox);
            this.Name = "TxtBoxUserControl";
            this.Size = new System.Drawing.Size(336, 37);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.TxtBoxUserControl_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox Control_textBox;
    }
}
