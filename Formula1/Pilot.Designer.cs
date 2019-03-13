namespace Formula1
{
    partial class Pilot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pilot));
            this.pbccBack = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pbxClose = new System.Windows.Forms.PictureBox();
            this.btnModificare = new System.Windows.Forms.Button();
            this.btnSterge = new System.Windows.Forms.Button();
            this.btnEliberare = new System.Windows.Forms.Button();
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.lblPilotID = new System.Windows.Forms.Label();
            this.txtPilotID = new System.Windows.Forms.TextBox();
            this.txtPuncte = new System.Windows.Forms.TextBox();
            this.lblPuncte = new System.Windows.Forms.Label();
            this.lblEchipa = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.txtPrenume = new System.Windows.Forms.TextBox();
            this.lblPrenume = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.lblNume = new System.Windows.Forms.Label();
            this.cmbEchipa = new System.Windows.Forms.ComboBox();
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
            this.pbccBack.TabIndex = 18;
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
            this.btnLogout.TabIndex = 17;
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
            this.pbxClose.TabIndex = 16;
            this.pbxClose.TabStop = false;
            this.pbxClose.Click += new System.EventHandler(this.pbxClose_Click);
            // 
            // btnModificare
            // 
            this.btnModificare.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnModificare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificare.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnModificare.Location = new System.Drawing.Point(160, 425);
            this.btnModificare.Name = "btnModificare";
            this.btnModificare.Size = new System.Drawing.Size(100, 35);
            this.btnModificare.TabIndex = 37;
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
            this.btnSterge.TabIndex = 36;
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
            this.btnEliberare.TabIndex = 35;
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
            this.btnAdaugare.TabIndex = 34;
            this.btnAdaugare.Text = "Adauga";
            this.btnAdaugare.UseVisualStyleBackColor = false;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugare_Click);
            // 
            // lblPilotID
            // 
            this.lblPilotID.AutoSize = true;
            this.lblPilotID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPilotID.Location = new System.Drawing.Point(35, 70);
            this.lblPilotID.Name = "lblPilotID";
            this.lblPilotID.Size = new System.Drawing.Size(60, 20);
            this.lblPilotID.TabIndex = 38;
            this.lblPilotID.Text = "Pilot ID";
            // 
            // txtPilotID
            // 
            this.txtPilotID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPilotID.Location = new System.Drawing.Point(150, 70);
            this.txtPilotID.Name = "txtPilotID";
            this.txtPilotID.ReadOnly = true;
            this.txtPilotID.Size = new System.Drawing.Size(200, 26);
            this.txtPilotID.TabIndex = 39;
            // 
            // txtPuncte
            // 
            this.txtPuncte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPuncte.Location = new System.Drawing.Point(150, 270);
            this.txtPuncte.Name = "txtPuncte";
            this.txtPuncte.Size = new System.Drawing.Size(200, 26);
            this.txtPuncte.TabIndex = 41;
            // 
            // lblPuncte
            // 
            this.lblPuncte.AutoSize = true;
            this.lblPuncte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPuncte.Location = new System.Drawing.Point(35, 270);
            this.lblPuncte.Name = "lblPuncte";
            this.lblPuncte.Size = new System.Drawing.Size(59, 20);
            this.lblPuncte.TabIndex = 42;
            this.lblPuncte.Text = "Puncte";
            // 
            // lblEchipa
            // 
            this.lblEchipa.AutoSize = true;
            this.lblEchipa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEchipa.Location = new System.Drawing.Point(35, 230);
            this.lblEchipa.Name = "lblEchipa";
            this.lblEchipa.Size = new System.Drawing.Size(58, 20);
            this.lblEchipa.TabIndex = 44;
            this.lblEchipa.Text = "Echipa";
            // 
            // txtData
            // 
            this.txtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtData.Location = new System.Drawing.Point(150, 190);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(200, 26);
            this.txtData.TabIndex = 47;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblData.Location = new System.Drawing.Point(35, 190);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(101, 20);
            this.lblData.TabIndex = 46;
            this.lblData.Text = "Data Nasterii";
            // 
            // txtPrenume
            // 
            this.txtPrenume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPrenume.Location = new System.Drawing.Point(150, 150);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(200, 26);
            this.txtPrenume.TabIndex = 49;
            // 
            // lblPrenume
            // 
            this.lblPrenume.AutoSize = true;
            this.lblPrenume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPrenume.Location = new System.Drawing.Point(35, 150);
            this.lblPrenume.Name = "lblPrenume";
            this.lblPrenume.Size = new System.Drawing.Size(73, 20);
            this.lblPrenume.TabIndex = 48;
            this.lblPrenume.Text = "Prenume";
            // 
            // txtNume
            // 
            this.txtNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNume.Location = new System.Drawing.Point(150, 110);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(200, 26);
            this.txtNume.TabIndex = 51;
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNume.Location = new System.Drawing.Point(35, 110);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(51, 20);
            this.lblNume.TabIndex = 50;
            this.lblNume.Text = "Nume";
            // 
            // cmbEchipa
            // 
            this.cmbEchipa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbEchipa.FormattingEnabled = true;
            this.cmbEchipa.Items.AddRange(new object[] {
            "Scuderia Ferrari",
            "Hass",
            "McLaren",
            "Mercedes",
            "RacingPoint",
            "Red Bull Racing",
            "Renault",
            "Sauber",
            "Scuderia Torp Rosso"});
            this.cmbEchipa.Location = new System.Drawing.Point(150, 230);
            this.cmbEchipa.Name = "cmbEchipa";
            this.cmbEchipa.Size = new System.Drawing.Size(200, 26);
            this.cmbEchipa.TabIndex = 52;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(454, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(506, 230);
            this.dataGridView1.TabIndex = 53;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // Pilot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbEchipa);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.txtPrenume);
            this.Controls.Add(this.lblPrenume);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblEchipa);
            this.Controls.Add(this.lblPuncte);
            this.Controls.Add(this.txtPuncte);
            this.Controls.Add(this.txtPilotID);
            this.Controls.Add(this.lblPilotID);
            this.Controls.Add(this.btnModificare);
            this.Controls.Add(this.btnSterge);
            this.Controls.Add(this.btnEliberare);
            this.Controls.Add(this.btnAdaugare);
            this.Controls.Add(this.pbccBack);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.pbxClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pilot";
            this.Text = "Pilot";
            this.Load += new System.EventHandler(this.Pilot_Load);
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
        private System.Windows.Forms.Button btnModificare;
        private System.Windows.Forms.Button btnSterge;
        private System.Windows.Forms.Button btnEliberare;
        private System.Windows.Forms.Button btnAdaugare;
        private System.Windows.Forms.Label lblPilotID;
        private System.Windows.Forms.TextBox txtPilotID;
        private System.Windows.Forms.TextBox txtPuncte;
        private System.Windows.Forms.Label lblPuncte;
        private System.Windows.Forms.Label lblEchipa;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox txtPrenume;
        private System.Windows.Forms.Label lblPrenume;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.ComboBox cmbEchipa;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}