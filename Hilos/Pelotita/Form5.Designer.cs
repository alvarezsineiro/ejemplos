namespace Pelotita
{
    partial class Form5
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
            this.btnpausar = new System.Windows.Forms.Button();
            this.btnreanudar = new System.Windows.Forms.Button();
            this.btndestruir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btncrear
            // 
            this.btncrear.Location = new System.Drawing.Point(11, 232);
            this.btncrear.Name = "btncrear";
            this.btncrear.Size = new System.Drawing.Size(72, 27);
            this.btncrear.TabIndex = 0;
            this.btncrear.Text = "crear";
            this.btncrear.UseVisualStyleBackColor = true;
            // 
            // btnpausar
            // 
            this.btnpausar.Location = new System.Drawing.Point(106, 231);
            this.btnpausar.Name = "btnpausar";
            this.btnpausar.Size = new System.Drawing.Size(55, 27);
            this.btnpausar.TabIndex = 1;
            this.btnpausar.Text = "pausar";
            this.btnpausar.UseVisualStyleBackColor = true;
            this.btnpausar.Click += new System.EventHandler(this.btnpausar_Click);
            // 
            // btnreanudar
            // 
            this.btnreanudar.Location = new System.Drawing.Point(167, 231);
            this.btnreanudar.Name = "btnreanudar";
            this.btnreanudar.Size = new System.Drawing.Size(61, 28);
            this.btnreanudar.TabIndex = 2;
            this.btnreanudar.Text = "reanudar";
            this.btnreanudar.UseVisualStyleBackColor = true;
            // 
            // btndestruir
            // 
            this.btndestruir.Location = new System.Drawing.Point(234, 231);
            this.btndestruir.Name = "btndestruir";
            this.btndestruir.Size = new System.Drawing.Size(50, 27);
            this.btndestruir.TabIndex = 3;
            this.btndestruir.Text = "destruir";
            this.btndestruir.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 218);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btndestruir);
            this.Controls.Add(this.btnreanudar);
            this.Controls.Add(this.btnpausar);
            this.Controls.Add(this.btncrear);
            this.Name = "Form5";
            this.Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncrear;
        private System.Windows.Forms.Button btnpausar;
        private System.Windows.Forms.Button btnreanudar;
        private System.Windows.Forms.Button btndestruir;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}