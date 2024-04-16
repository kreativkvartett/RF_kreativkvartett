namespace Kliensalkalmazás
{
    partial class Form2
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
            this.labelkereses = new System.Windows.Forms.Label();
            this.textBoxszuro = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelkereses
            // 
            this.labelkereses.AutoSize = true;
            this.labelkereses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelkereses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(91)))), ((int)(((byte)(105)))));
            this.labelkereses.Location = new System.Drawing.Point(102, 419);
            this.labelkereses.Name = "labelkereses";
            this.labelkereses.Size = new System.Drawing.Size(76, 20);
            this.labelkereses.TabIndex = 5;
            this.labelkereses.Text = "Keresés:";
            // 
            // textBoxszuro
            // 
            this.textBoxszuro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(91)))), ((int)(((byte)(105)))));
            this.textBoxszuro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(252)))));
            this.textBoxszuro.Location = new System.Drawing.Point(184, 419);
            this.textBoxszuro.Name = "textBoxszuro";
            this.textBoxszuro.Size = new System.Drawing.Size(270, 22);
            this.textBoxszuro.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 531);
            this.Controls.Add(this.labelkereses);
            this.Controls.Add(this.textBoxszuro);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelkereses;
        private System.Windows.Forms.TextBox textBoxszuro;
    }
}