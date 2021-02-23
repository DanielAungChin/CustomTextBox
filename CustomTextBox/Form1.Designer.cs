
namespace CustomTextBox
{
    partial class Form1
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
            this.txtBoxUserControl1 = new CustomTextBox.TxtBoxUserControl();
            this.txtBoxClass1 = new CustomTextBox.TxtBoxClass();
            this.SuspendLayout();
            // 
            // txtBoxUserControl1
            // 
            this.txtBoxUserControl1.BackColor = System.Drawing.Color.White;
            this.txtBoxUserControl1.Location = new System.Drawing.Point(108, 46);
            this.txtBoxUserControl1.Name = "txtBoxUserControl1";
            this.txtBoxUserControl1.Size = new System.Drawing.Size(336, 37);
            this.txtBoxUserControl1.TabIndex = 0;
            // 
            // txtBoxClass1
            // 
            this.txtBoxClass1.BackColor = System.Drawing.Color.White;
            this.txtBoxClass1.Location = new System.Drawing.Point(108, 117);
            this.txtBoxClass1.Name = "txtBoxClass1";
            this.txtBoxClass1.Size = new System.Drawing.Size(336, 38);
            this.txtBoxClass1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBoxClass1);
            this.Controls.Add(this.txtBoxUserControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private TxtBoxUserControl txtBoxUserControl1;
        private TxtBoxClass txtBoxClass1;
    }
}

