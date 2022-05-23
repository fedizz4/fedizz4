
namespace MediaTek86.Vue
{
    partial class frmGestionAbsences
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionAbsences));
            this.lblAbsences = new System.Windows.Forms.Label();
            this.lblListeAbsences = new System.Windows.Forms.Label();
            this.lblGestionAbsences = new System.Windows.Forms.Label();
            this.lblInfosAbsences = new System.Windows.Forms.Label();
            this.lblAdministrationAbs = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.btnAjouterAbs = new System.Windows.Forms.Button();
            this.btnModifierAbs = new System.Windows.Forms.Button();
            this.btnSupprimerAbs = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.dgvAbsences = new System.Windows.Forms.DataGridView();
            this.dtpDebut = new System.Windows.Forms.DateTimePicker();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.cboMotifs = new System.Windows.Forms.ComboBox();
            this.lblDebut = new System.Windows.Forms.Label();
            this.lblFin = new System.Windows.Forms.Label();
            this.lblMotifs = new System.Windows.Forms.Label();
            this.btnVider = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsences)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAbsences
            // 
            this.lblAbsences.AutoSize = true;
            this.lblAbsences.BackColor = System.Drawing.Color.Transparent;
            this.lblAbsences.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbsences.ForeColor = System.Drawing.Color.White;
            this.lblAbsences.Location = new System.Drawing.Point(19, 5);
            this.lblAbsences.Name = "lblAbsences";
            this.lblAbsences.Size = new System.Drawing.Size(188, 20);
            this.lblAbsences.TabIndex = 20;
            this.lblAbsences.Text = "Gestion des absences";
            this.lblAbsences.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblListeAbsences
            // 
            this.lblListeAbsences.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
            this.lblListeAbsences.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListeAbsences.ForeColor = System.Drawing.Color.White;
            this.lblListeAbsences.Location = new System.Drawing.Point(178, 93);
            this.lblListeAbsences.Name = "lblListeAbsences";
            this.lblListeAbsences.Size = new System.Drawing.Size(303, 23);
            this.lblListeAbsences.TabIndex = 21;
            this.lblListeAbsences.Text = "Liste des absences";
            this.lblListeAbsences.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGestionAbsences
            // 
            this.lblGestionAbsences.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
            this.lblGestionAbsences.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionAbsences.ForeColor = System.Drawing.Color.White;
            this.lblGestionAbsences.Location = new System.Drawing.Point(178, 401);
            this.lblGestionAbsences.Name = "lblGestionAbsences";
            this.lblGestionAbsences.Size = new System.Drawing.Size(303, 23);
            this.lblGestionAbsences.TabIndex = 22;
            this.lblGestionAbsences.Text = "Gestion des absences";
            this.lblGestionAbsences.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInfosAbsences
            // 
            this.lblInfosAbsences.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
            this.lblInfosAbsences.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfosAbsences.ForeColor = System.Drawing.Color.White;
            this.lblInfosAbsences.Location = new System.Drawing.Point(39, 445);
            this.lblInfosAbsences.Name = "lblInfosAbsences";
            this.lblInfosAbsences.Size = new System.Drawing.Size(277, 22);
            this.lblInfosAbsences.TabIndex = 23;
            this.lblInfosAbsences.Text = "Informations sur l\'absence";
            this.lblInfosAbsences.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAdministrationAbs
            // 
            this.lblAdministrationAbs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
            this.lblAdministrationAbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdministrationAbs.ForeColor = System.Drawing.Color.White;
            this.lblAdministrationAbs.Location = new System.Drawing.Point(345, 445);
            this.lblAdministrationAbs.Name = "lblAdministrationAbs";
            this.lblAdministrationAbs.Size = new System.Drawing.Size(281, 22);
            this.lblAdministrationAbs.TabIndex = 24;
            this.lblAdministrationAbs.Text = "Administration";
            this.lblAdministrationAbs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.BackColor = System.Drawing.Color.Transparent;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(38, 475);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(37, 16);
            this.lblNom.TabIndex = 25;
            this.lblNom.Text = "Nom";
            // 
            // txtNom
            // 
            this.txtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.txtNom.Location = new System.Drawing.Point(41, 492);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(121, 18);
            this.txtNom.TabIndex = 26;
            // 
            // lblPrenom
            // 
            this.lblPrenom.BackColor = System.Drawing.Color.Transparent;
            this.lblPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenom.Location = new System.Drawing.Point(179, 475);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(59, 23);
            this.lblPrenom.TabIndex = 27;
            this.lblPrenom.Text = "Prénom";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.txtPrenom.Location = new System.Drawing.Point(185, 492);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(130, 18);
            this.txtPrenom.TabIndex = 28;
            // 
            // btnAjouterAbs
            // 
            this.btnAjouterAbs.BackColor = System.Drawing.Color.SandyBrown;
            this.btnAjouterAbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterAbs.ForeColor = System.Drawing.Color.White;
            this.btnAjouterAbs.Location = new System.Drawing.Point(403, 492);
            this.btnAjouterAbs.Name = "btnAjouterAbs";
            this.btnAjouterAbs.Size = new System.Drawing.Size(169, 36);
            this.btnAjouterAbs.TabIndex = 29;
            this.btnAjouterAbs.Text = "Ajouter";
            this.btnAjouterAbs.UseVisualStyleBackColor = false;
            // 
            // btnModifierAbs
            // 
            this.btnModifierAbs.BackColor = System.Drawing.Color.Chocolate;
            this.btnModifierAbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifierAbs.ForeColor = System.Drawing.Color.White;
            this.btnModifierAbs.Location = new System.Drawing.Point(403, 555);
            this.btnModifierAbs.Name = "btnModifierAbs";
            this.btnModifierAbs.Size = new System.Drawing.Size(169, 36);
            this.btnModifierAbs.TabIndex = 30;
            this.btnModifierAbs.Text = "Modifier";
            this.btnModifierAbs.UseVisualStyleBackColor = false;
            // 
            // btnSupprimerAbs
            // 
            this.btnSupprimerAbs.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnSupprimerAbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimerAbs.ForeColor = System.Drawing.Color.White;
            this.btnSupprimerAbs.Location = new System.Drawing.Point(403, 615);
            this.btnSupprimerAbs.Name = "btnSupprimerAbs";
            this.btnSupprimerAbs.Size = new System.Drawing.Size(169, 36);
            this.btnSupprimerAbs.TabIndex = 31;
            this.btnSupprimerAbs.Text = "Supprimer";
            this.btnSupprimerAbs.UseVisualStyleBackColor = false;
            // 
            // btnRetour
            // 
            this.btnRetour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
            this.btnRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetour.ForeColor = System.Drawing.Color.White;
            this.btnRetour.Location = new System.Drawing.Point(372, 670);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(232, 33);
            this.btnRetour.TabIndex = 32;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = false;
            // 
            // dgvAbsences
            // 
            this.dgvAbsences.AllowDrop = true;
            this.dgvAbsences.AllowUserToOrderColumns = true;
            this.dgvAbsences.BackgroundColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAbsences.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAbsences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAbsences.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAbsences.EnableHeadersVisualStyles = false;
            this.dgvAbsences.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
            this.dgvAbsences.Location = new System.Drawing.Point(23, 114);
            this.dgvAbsences.Name = "dgvAbsences";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAbsences.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvAbsences.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAbsences.Size = new System.Drawing.Size(612, 254);
            this.dgvAbsences.TabIndex = 60;
            // 
            // dtpDebut
            // 
            this.dtpDebut.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.dtpDebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.dtpDebut.Location = new System.Drawing.Point(41, 539);
            this.dtpDebut.Name = "dtpDebut";
            this.dtpDebut.Size = new System.Drawing.Size(274, 18);
            this.dtpDebut.TabIndex = 34;
            // 
            // dtpFin
            // 
            this.dtpFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.dtpFin.Location = new System.Drawing.Point(42, 585);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(273, 18);
            this.dtpFin.TabIndex = 35;
            // 
            // cboMotifs
            // 
            this.cboMotifs.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.cboMotifs.FormattingEnabled = true;
            this.cboMotifs.Location = new System.Drawing.Point(41, 634);
            this.cboMotifs.Name = "cboMotifs";
            this.cboMotifs.Size = new System.Drawing.Size(274, 20);
            this.cboMotifs.TabIndex = 36;
            // 
            // lblDebut
            // 
            this.lblDebut.AutoSize = true;
            this.lblDebut.BackColor = System.Drawing.Color.Transparent;
            this.lblDebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebut.Location = new System.Drawing.Point(39, 520);
            this.lblDebut.Name = "lblDebut";
            this.lblDebut.Size = new System.Drawing.Size(93, 16);
            this.lblDebut.TabIndex = 37;
            this.lblDebut.Text = "Date de début";
            // 
            // lblFin
            // 
            this.lblFin.AutoSize = true;
            this.lblFin.BackColor = System.Drawing.Color.Transparent;
            this.lblFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFin.Location = new System.Drawing.Point(39, 566);
            this.lblFin.Name = "lblFin";
            this.lblFin.Size = new System.Drawing.Size(72, 16);
            this.lblFin.TabIndex = 38;
            this.lblFin.Text = "Date de fin";
            // 
            // lblMotifs
            // 
            this.lblMotifs.AutoSize = true;
            this.lblMotifs.BackColor = System.Drawing.Color.Transparent;
            this.lblMotifs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotifs.Location = new System.Drawing.Point(39, 615);
            this.lblMotifs.Name = "lblMotifs";
            this.lblMotifs.Size = new System.Drawing.Size(117, 16);
            this.lblMotifs.TabIndex = 39;
            this.lblMotifs.Text = "Motif de l\'absence";
            // 
            // btnVider
            // 
            this.btnVider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
            this.btnVider.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVider.ForeColor = System.Drawing.Color.White;
            this.btnVider.Location = new System.Drawing.Point(60, 670);
            this.btnVider.Name = "btnVider";
            this.btnVider.Size = new System.Drawing.Size(232, 33);
            this.btnVider.TabIndex = 62;
            this.btnVider.Text = "Réinitialiser";
            this.btnVider.UseVisualStyleBackColor = false;
            this.btnVider.Click += new System.EventHandler(this.btnVider_Click);
            // 
            // frmGestionAbsences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(661, 772);
            this.Controls.Add(this.btnVider);
            this.Controls.Add(this.lblMotifs);
            this.Controls.Add(this.lblFin);
            this.Controls.Add(this.lblDebut);
            this.Controls.Add(this.cboMotifs);
            this.Controls.Add(this.dtpFin);
            this.Controls.Add(this.dtpDebut);
            this.Controls.Add(this.dgvAbsences);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnSupprimerAbs);
            this.Controls.Add(this.btnModifierAbs);
            this.Controls.Add(this.btnAjouterAbs);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblAdministrationAbs);
            this.Controls.Add(this.lblInfosAbsences);
            this.Controls.Add(this.lblGestionAbsences);
            this.Controls.Add(this.lblListeAbsences);
            this.Controls.Add(this.lblAbsences);
            this.Name = "frmGestionAbsences";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion des absences";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsences)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAbsences;
        private System.Windows.Forms.Label lblListeAbsences;
        private System.Windows.Forms.Label lblGestionAbsences;
        private System.Windows.Forms.Label lblInfosAbsences;
        private System.Windows.Forms.Label lblAdministrationAbs;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Button btnAjouterAbs;
        private System.Windows.Forms.Button btnModifierAbs;
        private System.Windows.Forms.Button btnSupprimerAbs;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.DataGridView dgvAbsences;
        private System.Windows.Forms.DateTimePicker dtpDebut;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.ComboBox cboMotifs;
        private System.Windows.Forms.Label lblDebut;
        private System.Windows.Forms.Label lblFin;
        private System.Windows.Forms.Label lblMotifs;
        private System.Windows.Forms.Button btnVider;
    }
}