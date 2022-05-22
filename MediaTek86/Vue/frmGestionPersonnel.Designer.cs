
namespace MediaTek86.Vue
{
    partial class frmGestionPersonnel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionPersonnel));
            this.dgvPersonnel = new System.Windows.Forms.DataGridView();
            this.lblGestion = new System.Windows.Forms.Label();
            this.lblListePersonnel = new System.Windows.Forms.Label();
            this.lblGestionPersonnel = new System.Windows.Forms.Label();
            this.lblPersonnel = new System.Windows.Forms.Label();
            this.lblAdministration = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnAbsences = new System.Windows.Forms.Button();
            this.cboServices = new System.Windows.Forms.ComboBox();
            this.lblService = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.btnVider = new System.Windows.Forms.Button();
            this.lblPrenom = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPersonnel
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvPersonnel.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPersonnel.BackgroundColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPersonnel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPersonnel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPersonnel.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPersonnel.EnableHeadersVisualStyles = false;
            this.dgvPersonnel.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
            this.dgvPersonnel.Location = new System.Drawing.Point(23, 114);
            this.dgvPersonnel.Name = "dgvPersonnel";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPersonnel.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
            this.dgvPersonnel.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPersonnel.Size = new System.Drawing.Size(612, 254);
            this.dgvPersonnel.TabIndex = 60;
            this.dgvPersonnel.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPersonnels_CellEnter);
            // 
            // lblGestion
            // 
            this.lblGestion.AutoSize = true;
            this.lblGestion.BackColor = System.Drawing.Color.Transparent;
            this.lblGestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestion.ForeColor = System.Drawing.Color.White;
            this.lblGestion.Location = new System.Drawing.Point(19, 5);
            this.lblGestion.Name = "lblGestion";
            this.lblGestion.Size = new System.Drawing.Size(181, 20);
            this.lblGestion.TabIndex = 1;
            this.lblGestion.Text = "Gestion du personnel";
            this.lblGestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblListePersonnel
            // 
            this.lblListePersonnel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
            this.lblListePersonnel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListePersonnel.ForeColor = System.Drawing.Color.White;
            this.lblListePersonnel.Location = new System.Drawing.Point(178, 93);
            this.lblListePersonnel.Name = "lblListePersonnel";
            this.lblListePersonnel.Size = new System.Drawing.Size(303, 23);
            this.lblListePersonnel.TabIndex = 2;
            this.lblListePersonnel.Text = "Liste du personnel";
            this.lblListePersonnel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGestionPersonnel
            // 
            this.lblGestionPersonnel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
            this.lblGestionPersonnel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionPersonnel.ForeColor = System.Drawing.Color.White;
            this.lblGestionPersonnel.Location = new System.Drawing.Point(178, 401);
            this.lblGestionPersonnel.Name = "lblGestionPersonnel";
            this.lblGestionPersonnel.Size = new System.Drawing.Size(303, 23);
            this.lblGestionPersonnel.TabIndex = 3;
            this.lblGestionPersonnel.Text = "Gestion du personnel";
            this.lblGestionPersonnel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPersonnel
            // 
            this.lblPersonnel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
            this.lblPersonnel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonnel.ForeColor = System.Drawing.Color.White;
            this.lblPersonnel.Location = new System.Drawing.Point(39, 445);
            this.lblPersonnel.Name = "lblPersonnel";
            this.lblPersonnel.Size = new System.Drawing.Size(277, 22);
            this.lblPersonnel.TabIndex = 4;
            this.lblPersonnel.Text = "Informations personnelles";
            this.lblPersonnel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAdministration
            // 
            this.lblAdministration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
            this.lblAdministration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdministration.ForeColor = System.Drawing.Color.White;
            this.lblAdministration.Location = new System.Drawing.Point(345, 445);
            this.lblAdministration.Name = "lblAdministration";
            this.lblAdministration.Size = new System.Drawing.Size(281, 22);
            this.lblAdministration.TabIndex = 5;
            this.lblAdministration.Text = "Administration";
            this.lblAdministration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.SandyBrown;
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Location = new System.Drawing.Point(403, 492);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(169, 36);
            this.btnAjouter.TabIndex = 9;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.Chocolate;
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.ForeColor = System.Drawing.Color.White;
            this.btnModifier.Location = new System.Drawing.Point(403, 555);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(169, 36);
            this.btnModifier.TabIndex = 10;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.ForeColor = System.Drawing.Color.White;
            this.btnSupprimer.Location = new System.Drawing.Point(403, 615);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(169, 36);
            this.btnSupprimer.TabIndex = 11;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnAbsences
            // 
            this.btnAbsences.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
            this.btnAbsences.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbsences.ForeColor = System.Drawing.Color.White;
            this.btnAbsences.Location = new System.Drawing.Point(372, 670);
            this.btnAbsences.Name = "btnAbsences";
            this.btnAbsences.Size = new System.Drawing.Size(232, 33);
            this.btnAbsences.TabIndex = 12;
            this.btnAbsences.Text = "Gestion des absences";
            this.btnAbsences.UseVisualStyleBackColor = false;
            this.btnAbsences.Click += new System.EventHandler(this.btnAbsences_Click);
            // 
            // cboServices
            // 
            this.cboServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.cboServices.FormattingEnabled = true;
            this.cboServices.Location = new System.Drawing.Point(41, 634);
            this.cboServices.Name = "cboServices";
            this.cboServices.Size = new System.Drawing.Size(274, 20);
            this.cboServices.TabIndex = 15;
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.BackColor = System.Drawing.Color.Transparent;
            this.lblService.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblService.Location = new System.Drawing.Point(39, 615);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(54, 16);
            this.lblService.TabIndex = 14;
            this.lblService.Text = "Service";
            // 
            // txtNom
            // 
            this.txtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.txtNom.Location = new System.Drawing.Point(41, 492);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(121, 18);
            this.txtNom.TabIndex = 16;
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.txtTel.Location = new System.Drawing.Point(41, 539);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(273, 18);
            this.txtTel.TabIndex = 18;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.txtPrenom.Location = new System.Drawing.Point(185, 492);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(130, 18);
            this.txtPrenom.TabIndex = 17;
            // 
            // txtMail
            // 
            this.txtMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.txtMail.Location = new System.Drawing.Point(42, 585);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(273, 18);
            this.txtMail.TabIndex = 19;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.BackColor = System.Drawing.Color.Transparent;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(38, 475);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(37, 16);
            this.lblNom.TabIndex = 6;
            this.lblNom.Text = "Nom";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.BackColor = System.Drawing.Color.Transparent;
            this.lblTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel.Location = new System.Drawing.Point(39, 520);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(28, 16);
            this.lblTel.TabIndex = 8;
            this.lblTel.Text = "Tel";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.BackColor = System.Drawing.Color.Transparent;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.Location = new System.Drawing.Point(39, 566);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(33, 16);
            this.lblMail.TabIndex = 13;
            this.lblMail.Text = "Mail";
            // 
            // btnVider
            // 
            this.btnVider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
            this.btnVider.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVider.ForeColor = System.Drawing.Color.White;
            this.btnVider.Location = new System.Drawing.Point(60, 670);
            this.btnVider.Name = "btnVider";
            this.btnVider.Size = new System.Drawing.Size(232, 33);
            this.btnVider.TabIndex = 61;
            this.btnVider.Text = "Réinitialiser";
            this.btnVider.UseVisualStyleBackColor = false;
            this.btnVider.Click += new System.EventHandler(this.btnVider_Click);
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.BackColor = System.Drawing.Color.Transparent;
            this.lblPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblPrenom.Location = new System.Drawing.Point(182, 475);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(55, 16);
            this.lblPrenom.TabIndex = 62;
            this.lblPrenom.Text = "Prenom";
            // 
            // frmGestionPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(661, 772);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.btnVider);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblService);
            this.Controls.Add(this.cboServices);
            this.Controls.Add(this.btnAbsences);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.lblAdministration);
            this.Controls.Add(this.lblPersonnel);
            this.Controls.Add(this.lblGestionPersonnel);
            this.Controls.Add(this.lblListePersonnel);
            this.Controls.Add(this.lblGestion);
            this.Controls.Add(this.dgvPersonnel);
            this.Name = "frmGestionPersonnel";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion du personnel";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPersonnel;
        private System.Windows.Forms.Label lblGestion;
        private System.Windows.Forms.Label lblListePersonnel;
        private System.Windows.Forms.Label lblGestionPersonnel;
        private System.Windows.Forms.Label lblPersonnel;
        private System.Windows.Forms.Label lblAdministration;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnAbsences;
        private System.Windows.Forms.ComboBox cboServices;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Button btnVider;
        private System.Windows.Forms.Label lblPrenom;
    }
}