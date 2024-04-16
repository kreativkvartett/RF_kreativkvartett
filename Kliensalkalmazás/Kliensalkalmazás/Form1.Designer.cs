namespace Kliensalkalmazás
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxszuro = new System.Windows.Forms.TextBox();
            this.labelugyfel = new System.Windows.Forms.Label();
            this.labelkereses = new System.Windows.Forms.Label();
            this.buttonSzuroTorl = new System.Windows.Forms.Button();
            this.buttonUgyfelTorl = new System.Windows.Forms.Button();
            this.buttonKereses = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(197)))), ((int)(((byte)(70)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1055, 466);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBoxszuro
            // 
            this.textBoxszuro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(197)))), ((int)(((byte)(70)))));
            this.textBoxszuro.Location = new System.Drawing.Point(507, 79);
            this.textBoxszuro.Name = "textBoxszuro";
            this.textBoxszuro.Size = new System.Drawing.Size(270, 22);
            this.textBoxszuro.TabIndex = 1;
            // 
            // labelugyfel
            // 
            this.labelugyfel.AutoSize = true;
            this.labelugyfel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelugyfel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.labelugyfel.Location = new System.Drawing.Point(26, 27);
            this.labelugyfel.Name = "labelugyfel";
            this.labelugyfel.Size = new System.Drawing.Size(175, 46);
            this.labelugyfel.TabIndex = 2;
            this.labelugyfel.Text = "Ügyfelek";
            // 
            // labelkereses
            // 
            this.labelkereses.AutoSize = true;
            this.labelkereses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelkereses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.labelkereses.Location = new System.Drawing.Point(425, 79);
            this.labelkereses.Name = "labelkereses";
            this.labelkereses.Size = new System.Drawing.Size(76, 20);
            this.labelkereses.TabIndex = 3;
            this.labelkereses.Text = "Keresés:";
            // 
            // buttonSzuroTorl
            // 
            this.buttonSzuroTorl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(197)))), ((int)(((byte)(70)))));
            this.buttonSzuroTorl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(91)))), ((int)(((byte)(105)))));
            this.buttonSzuroTorl.Location = new System.Drawing.Point(941, 76);
            this.buttonSzuroTorl.Name = "buttonSzuroTorl";
            this.buttonSzuroTorl.Size = new System.Drawing.Size(152, 27);
            this.buttonSzuroTorl.TabIndex = 4;
            this.buttonSzuroTorl.Text = "Szűrő törlése";
            this.buttonSzuroTorl.UseVisualStyleBackColor = false;
            // 
            // buttonUgyfelTorl
            // 
            this.buttonUgyfelTorl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUgyfelTorl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(197)))), ((int)(((byte)(70)))));
            this.buttonUgyfelTorl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(91)))), ((int)(((byte)(105)))));
            this.buttonUgyfelTorl.Location = new System.Drawing.Point(937, 582);
            this.buttonUgyfelTorl.Name = "buttonUgyfelTorl";
            this.buttonUgyfelTorl.Size = new System.Drawing.Size(152, 27);
            this.buttonUgyfelTorl.TabIndex = 5;
            this.buttonUgyfelTorl.Text = "Ügyfél törlése";
            this.buttonUgyfelTorl.UseVisualStyleBackColor = false;
            // 
            // buttonKereses
            // 
            this.buttonKereses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(197)))), ((int)(((byte)(70)))));
            this.buttonKereses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(91)))), ((int)(((byte)(105)))));
            this.buttonKereses.Location = new System.Drawing.Point(783, 76);
            this.buttonKereses.Name = "buttonKereses";
            this.buttonKereses.Size = new System.Drawing.Size(152, 27);
            this.buttonKereses.TabIndex = 6;
            this.buttonKereses.Text = "Keresés";
            this.buttonKereses.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(197)))), ((int)(((byte)(70)))));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(91)))), ((int)(((byte)(105)))));
            this.button1.Location = new System.Drawing.Point(779, 582);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 27);
            this.button1.TabIndex = 7;
            this.button1.Text = "Új ügyfél";
            this.button1.UseVisualStyleBackColor = false;
            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(91)))), ((int)(((byte)(101)))));
            this.ClientSize = new System.Drawing.Size(1117, 656);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonKereses);
            this.Controls.Add(this.buttonUgyfelTorl);
            this.Controls.Add(this.buttonSzuroTorl);
            this.Controls.Add(this.labelkereses);
            this.Controls.Add(this.labelugyfel);
            this.Controls.Add(this.textBoxszuro);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxszuro;
        private System.Windows.Forms.Label labelugyfel;
        private System.Windows.Forms.Label labelkereses;
        private System.Windows.Forms.Button buttonSzuroTorl;
        private System.Windows.Forms.Button buttonUgyfelTorl;
        private System.Windows.Forms.Button buttonKereses;
        private System.Windows.Forms.Button button1;
    }
}

