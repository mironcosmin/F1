namespace Formula1
{
    partial class Circuit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Circuit));
            this.pbccBack = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pbxClose = new System.Windows.Forms.PictureBox();
            this.lblCircuitID = new System.Windows.Forms.Label();
            this.txtboxCircuitID = new System.Windows.Forms.TextBox();
            this.txtboxNrVir = new System.Windows.Forms.TextBox();
            this.lblNume = new System.Windows.Forms.Label();
            this.txtboxNume = new System.Windows.Forms.TextBox();
            this.lblNrViraje = new System.Windows.Forms.Label();
            this.txtboxAdresa = new System.Windows.Forms.TextBox();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.txtboxLungime = new System.Windows.Forms.TextBox();
            this.lblLungime = new System.Windows.Forms.Label();
            this.btnModificare = new System.Windows.Forms.Button();
            this.btnSterge = new System.Windows.Forms.Button();
            this.btnEliberare = new System.Windows.Forms.Button();
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pbccBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbccBack
            // 
            this.pbccBack.Image = ((System.Drawing.Image)(resources.GetObject("pbccBack.Image")));
            this.pbccBack.Location = new System.Drawing.Point(880, 10);
            this.pbccBack.Name = "pbccBack";
            this.pbccBack.Size = new System.Drawing.Size(45, 45);
            this.pbccBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbccBack.TabIndex = 15;
            this.pbccBack.TabStop = false;
            this.pbccBack.Click += new System.EventHandler(this.pbccBack_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Red;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogout.Location = new System.Drawing.Point(780, 15);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(80, 35);
            this.btnLogout.TabIndex = 14;
            this.btnLogout.Text = "Log-out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pbxClose
            // 
            this.pbxClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxClose.Image = ((System.Drawing.Image)(resources.GetObject("pbxClose.Image")));
            this.pbxClose.Location = new System.Drawing.Point(945, 10);
            this.pbxClose.Name = "pbxClose";
            this.pbxClose.Size = new System.Drawing.Size(45, 45);
            this.pbxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxClose.TabIndex = 13;
            this.pbxClose.TabStop = false;
            this.pbxClose.Click += new System.EventHandler(this.pbxClose_Click);
            // 
            // lblCircuitID
            // 
            this.lblCircuitID.AutoSize = true;
            this.lblCircuitID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCircuitID.Location = new System.Drawing.Point(35, 70);
            this.lblCircuitID.Name = "lblCircuitID";
            this.lblCircuitID.Size = new System.Drawing.Size(74, 20);
            this.lblCircuitID.TabIndex = 16;
            this.lblCircuitID.Text = "Circuit ID";
            // 
            // txtboxCircuitID
            // 
            this.txtboxCircuitID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtboxCircuitID.Location = new System.Drawing.Point(150, 70);
            this.txtboxCircuitID.Name = "txtboxCircuitID";
            this.txtboxCircuitID.ReadOnly = true;
            this.txtboxCircuitID.Size = new System.Drawing.Size(200, 26);
            this.txtboxCircuitID.TabIndex = 17;
            // 
            // txtboxNrVir
            // 
            this.txtboxNrVir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtboxNrVir.Location = new System.Drawing.Point(150, 260);
            this.txtboxNrVir.Name = "txtboxNrVir";
            this.txtboxNrVir.Size = new System.Drawing.Size(200, 26);
            this.txtboxNrVir.TabIndex = 19;
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNume.Location = new System.Drawing.Point(35, 195);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(51, 20);
            this.lblNume.TabIndex = 18;
            this.lblNume.Text = "Nume";
            // 
            // txtboxNume
            // 
            this.txtboxNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtboxNume.Location = new System.Drawing.Point(150, 195);
            this.txtboxNume.Multiline = true;
            this.txtboxNume.Name = "txtboxNume";
            this.txtboxNume.Size = new System.Drawing.Size(200, 50);
            this.txtboxNume.TabIndex = 21;
            // 
            // lblNrViraje
            // 
            this.lblNrViraje.AutoSize = true;
            this.lblNrViraje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNrViraje.Location = new System.Drawing.Point(35, 260);
            this.lblNrViraje.Name = "lblNrViraje";
            this.lblNrViraje.Size = new System.Drawing.Size(100, 20);
            this.lblNrViraje.TabIndex = 20;
            this.lblNrViraje.Text = "Numar Viraje";
            // 
            // txtboxAdresa
            // 
            this.txtboxAdresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtboxAdresa.Location = new System.Drawing.Point(150, 110);
            this.txtboxAdresa.Multiline = true;
            this.txtboxAdresa.Name = "txtboxAdresa";
            this.txtboxAdresa.Size = new System.Drawing.Size(200, 70);
            this.txtboxAdresa.TabIndex = 23;
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAdresa.Location = new System.Drawing.Point(35, 110);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(60, 20);
            this.lblAdresa.TabIndex = 22;
            this.lblAdresa.Text = "Adresa";
            // 
            // txtboxLungime
            // 
            this.txtboxLungime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtboxLungime.Location = new System.Drawing.Point(150, 300);
            this.txtboxLungime.Name = "txtboxLungime";
            this.txtboxLungime.Size = new System.Drawing.Size(200, 26);
            this.txtboxLungime.TabIndex = 25;
            // 
            // lblLungime
            // 
            this.lblLungime.AutoSize = true;
            this.lblLungime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLungime.Location = new System.Drawing.Point(35, 300);
            this.lblLungime.Name = "lblLungime";
            this.lblLungime.Size = new System.Drawing.Size(93, 20);
            this.lblLungime.TabIndex = 24;
            this.lblLungime.Text = "Lungime(m)";
            // 
            // btnModificare
            // 
            this.btnModificare.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnModificare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificare.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnModificare.Location = new System.Drawing.Point(160, 425);
            this.btnModificare.Name = "btnModificare";
            this.btnModificare.Size = new System.Drawing.Size(100, 35);
            this.btnModificare.TabIndex = 33;
            this.btnModificare.Text = "Modifica";
            this.btnModificare.UseVisualStyleBackColor = false;
            this.btnModificare.Click += new System.EventHandler(this.btnModificare_Click);
            // 
            // btnSterge
            // 
            this.btnSterge.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSterge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSterge.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSterge.Location = new System.Drawing.Point(285, 425);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(100, 35);
            this.btnSterge.TabIndex = 32;
            this.btnSterge.Text = "Stergere";
            this.btnSterge.UseVisualStyleBackColor = false;
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
            // 
            // btnEliberare
            // 
            this.btnEliberare.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnEliberare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliberare.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEliberare.Location = new System.Drawing.Point(410, 425);
            this.btnEliberare.Name = "btnEliberare";
            this.btnEliberare.Size = new System.Drawing.Size(100, 35);
            this.btnEliberare.TabIndex = 31;
            this.btnEliberare.Text = "Eliberare";
            this.btnEliberare.UseVisualStyleBackColor = false;
            this.btnEliberare.Click += new System.EventHandler(this.btnEliberare_Click);
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAdaugare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdaugare.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdaugare.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdaugare.Location = new System.Drawing.Point(35, 425);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(100, 35);
            this.btnAdaugare.TabIndex = 30;
            this.btnAdaugare.Text = "Adauga";
            this.btnAdaugare.UseVisualStyleBackColor = false;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugare_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(438, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(487, 256);
            this.dataGridView1.TabIndex = 34;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // Circuit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnModificare);
            this.Controls.Add(this.btnSterge);
            this.Controls.Add(this.btnEliberare);
            this.Controls.Add(this.btnAdaugare);
            this.Controls.Add(this.txtboxLungime);
            this.Controls.Add(this.lblLungime);
            this.Controls.Add(this.txtboxAdresa);
            this.Controls.Add(this.lblAdresa);
            this.Controls.Add(this.txtboxNume);
            this.Controls.Add(this.lblNrViraje);
            this.Controls.Add(this.txtboxNrVir);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.txtboxCircuitID);
            this.Controls.Add(this.lblCircuitID);
            this.Controls.Add(this.pbccBack);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.pbxClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Circuit";
            this.Text = "Circuit";
            this.Load += new System.EventHandler(this.Circuit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbccBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbccBack;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.PictureBox pbxClose;
        private System.Windows.Forms.Label lblCircuitID;
        private System.Windows.Forms.TextBox txtboxCircuitID;
        private System.Windows.Forms.TextBox txtboxNrVir;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.TextBox txtboxNume;
        private System.Windows.Forms.Label lblNrViraje;
        private System.Windows.Forms.TextBox txtboxAdresa;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.TextBox txtboxLungime;
        private System.Windows.Forms.Label lblLungime;
        private System.Windows.Forms.Button btnModificare;
        private System.Windows.Forms.Button btnSterge;
        private System.Windows.Forms.Button btnEliberare;
        private System.Windows.Forms.Button btnAdaugare;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}