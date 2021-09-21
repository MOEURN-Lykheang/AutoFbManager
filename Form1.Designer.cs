
namespace AutoFbManager
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
            this.form_click = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // form_click
            // 
            this.form_click.Location = new System.Drawing.Point(126, 78);
            this.form_click.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.form_click.Name = "form_click";
            this.form_click.Size = new System.Drawing.Size(56, 19);
            this.form_click.TabIndex = 0;
            this.form_click.Text = "Run";
            this.form_click.UseVisualStyleBackColor = true;
            this.form_click.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 232);
            this.Controls.Add(this.form_click);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button form_click;
    }
}

