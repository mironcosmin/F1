namespace Formula1
{
    partial class Autentificare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Autentificare));
            this.txtboxUtilizator = new System.Windows.Forms.TextBox();
            this.txtboxParola = new System.Windows.Forms.TextBox();
            this.lblUtilizator = new System.Windows.Forms.Label();
            this.lblParola = new System.Windows.Forms.Label();
            this.btnAutentificare = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtboxUtilizator
            // 
            this.txtboxUtilizator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtboxUtilizator.Location = new System.Drawing.Point(450, 331);
            this.txtboxUtilizator.Name = "txtboxUtilizator";
            this.txtboxUtilizator.Size = new System.Drawing.Size(205, 26);
            this.txtboxUtilizator.TabIndex = 1;
            this.txtboxUtilizator.TextChanged += new System.EventHandler(this.txtboxUtilizator_TextChanged);
            // 
            // txtboxParola
            // 
            this.txtboxParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtboxParola.Location = new System.Drawing.Point(450, 373);
            this.txtboxParola.Name = "txtboxParola";
            this.txtboxParola.PasswordChar = '*';
            this.txtboxParola.Size = new System.Drawing.Size(205, 26);
            this.txtboxParola.TabIndex = 2;
            this.txtboxParola.TextChanged += new System.EventHandler(this.txtboxParola_TextChanged);
            // 
            // lblUtilizator
            // 
            this.lblUtilizator.AutoSize = true;
            this.lblUtilizator.BackColor = System.Drawing.Color.Transparent;
            this.lblUtilizator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUtilizator.Location = new System.Drawing.Point(348, 337);
            this.lblUtilizator.Name = "lblUtilizator";
            this.lblUtilizator.Size = new System.Drawing.Size(81, 20);
            this.lblUtilizator.TabIndex = 3;
            this.lblUtilizator.Text = "Utilizator";
            this.lblUtilizator.Click += new System.EventHandler(this.lblUtilizator_Click);
            // 
            // lblParola
            // 
            this.lblParola.AutoSize = true;
            this.lblParola.BackColor = System.Drawing.Color.Transparent;
            this.lblParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblParola.Location = new System.Drawing.Point(348, 379);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(60, 20);
            this.lblParola.TabIndex = 4;
            this.lblParola.Text = "Parola";
            // 
            // btnAutentificare
            // 
            this.btnAutentificare.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAutentificare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAutentificare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAutentificare.ForeColor = System.Drawing.Color.Snow;
            this.btnAutentificare.Location = new System.Drawing.Point(425, 430);
            this.btnAutentificare.Name = "btnAutentificare";
            this.btnAutentificare.Size = new System.Drawing.Size(150, 40);
            this.btnAutentificare.TabIndex = 5;
            this.btnAutentificare.Text = "Autentificare";
            this.btnAutentificare.UseVisualStyleBackColor = false;
            this.btnAutentificare.Click += new System.EventHandler(this.btnAutentificare_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(280, 70);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(440, 230);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 6;
            this.pictureBoxLogo.TabStop = false;
            this.pictureBoxLogo.Click += new System.EventHandler(this.pictureBoxLogo_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(945, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // Autentificare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.btnAutentificare);
            this.Controls.Add(this.lblParola);
            this.Controls.Add(this.lblUtilizator);
            this.Controls.Add(this.txtboxParola);
            this.Controls.Add(this.txtboxUtilizator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Autentificare";
            this.Text = "Autentficare";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxUtilizator;
        private System.Windows.Forms.TextBox txtboxParola;
        private System.Windows.Forms.Label lblUtilizator;
        private System.Windows.Forms.Label lblParola;
        private System.Windows.Forms.Button btnAutentificare;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

