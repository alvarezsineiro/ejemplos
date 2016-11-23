namespace Pelotita
{
    partial class Form4
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
            this.btncrear = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnpausar = new System.Windows.Forms.Button();
            this.btndestruir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btncrear
            // 
            this.btncrear.Location = new System.Drawing.Point(12, 214);
            this.btncrear.Name = "btncrear";
            this.btncrear.Size = new System.Drawing.Size(74, 36);
            this.btncrear.TabIndex = 0;
            this.btncrear.Text = "crear";
            this.btncrear.UseVisualStyleBackColor = true;
            this.btncrear.Click += new System.EventHandler(this.btncrear_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(2, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(279, 203);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnpausar
            // 
            this.btnpausar.Location = new System.Drawing.Point(92, 214);
            this.btnpausar.Name = "btnpausar";
            this.btnpausar.Size = new System.Drawing.Size(81, 36);
            this.btnpausar.TabIndex = 2;
            this.btnpausar.Text = "pausar";
            this.btnpausar.UseVisualStyleBackColor = true;
            this.btnpausar.Click += new System.EventHandler(this.btnpausar_Click);
            // 
            // btndestruir
            // 
            this.btndestruir.Location = new System.Drawing.Point(188, 214);
            this.btndestruir.Name = "btndestruir";
            this.btndestruir.Size = new System.Drawing.Size(84, 36);
            this.btndestruir.TabIndex = 3;
            this.btndestruir.Text = "destruir";
            this.btndestruir.UseVisualStyleBackColor = true;
            this.btndestruir.Click += new System.EventHandler(this.btndestruir_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btndestruir);
            this.Controls.Add(this.btnpausar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btncrear);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncrear;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnpausar;
        private System.Windows.Forms.Button btndestruir;
    }
}