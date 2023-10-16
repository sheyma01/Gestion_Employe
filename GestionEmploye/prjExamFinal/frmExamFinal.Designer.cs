namespace prjExamFinal
{
    partial class frmExamFinal
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblnum = new System.Windows.Forms.Label();
            this.grpgestion = new System.Windows.Forms.GroupBox();
            this.lblnom = new System.Windows.Forms.Label();
            this.lblfonction = new System.Windows.Forms.Label();
            this.lnlsalaire = new System.Windows.Forms.Label();
            this.lblnbemploye = new System.Windows.Forms.Label();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.txtfonction = new System.Windows.Forms.TextBox();
            this.txtsalaire = new System.Windows.Forms.TextBox();
            this.btnajouter = new System.Windows.Forms.Button();
            this.btnmodifier = new System.Windows.Forms.Button();
            this.btnsupprimer = new System.Windows.Forms.Button();
            this.btnsauvegarder = new System.Windows.Forms.Button();
            this.btnannuler = new System.Windows.Forms.Button();
            this.btnpremier = new System.Windows.Forms.Button();
            this.btnprecedent = new System.Windows.Forms.Button();
            this.btnsuivant = new System.Windows.Forms.Button();
            this.btndernier = new System.Windows.Forms.Button();
            this.grprecherche = new System.Windows.Forms.GroupBox();
            this.lstnumero = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpinfo = new System.Windows.Forms.GroupBox();
            this.lblinfonum = new System.Windows.Forms.Label();
            this.lblinfonom = new System.Windows.Forms.Label();
            this.lblinfofonction = new System.Windows.Forms.Label();
            this.lblinfosalaire = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpgestion.SuspendLayout();
            this.grprecherche.SuspendLayout();
            this.grpinfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(347, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "ÉVALUATION SOMMATIVE";
            // 
            // lblnum
            // 
            this.lblnum.AutoSize = true;
            this.lblnum.Location = new System.Drawing.Point(46, 61);
            this.lblnum.Name = "lblnum";
            this.lblnum.Size = new System.Drawing.Size(152, 33);
            this.lblnum.TabIndex = 1;
            this.lblnum.Text = "Numéro : ";
            // 
            // grpgestion
            // 
            this.grpgestion.Controls.Add(this.btndernier);
            this.grpgestion.Controls.Add(this.btnsuivant);
            this.grpgestion.Controls.Add(this.btnprecedent);
            this.grpgestion.Controls.Add(this.btnpremier);
            this.grpgestion.Controls.Add(this.btnannuler);
            this.grpgestion.Controls.Add(this.btnsauvegarder);
            this.grpgestion.Controls.Add(this.btnsupprimer);
            this.grpgestion.Controls.Add(this.btnmodifier);
            this.grpgestion.Controls.Add(this.btnajouter);
            this.grpgestion.Controls.Add(this.txtsalaire);
            this.grpgestion.Controls.Add(this.txtfonction);
            this.grpgestion.Controls.Add(this.txtnom);
            this.grpgestion.Controls.Add(this.txtnumero);
            this.grpgestion.Controls.Add(this.lblnbemploye);
            this.grpgestion.Controls.Add(this.lnlsalaire);
            this.grpgestion.Controls.Add(this.lblfonction);
            this.grpgestion.Controls.Add(this.lblnom);
            this.grpgestion.Controls.Add(this.lblnum);
            this.grpgestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpgestion.Location = new System.Drawing.Point(26, 149);
            this.grpgestion.Name = "grpgestion";
            this.grpgestion.Size = new System.Drawing.Size(1040, 485);
            this.grpgestion.TabIndex = 2;
            this.grpgestion.TabStop = false;
            this.grpgestion.Text = "Gestion Des Employés De Microsoft";
            // 
            // lblnom
            // 
            this.lblnom.AutoSize = true;
            this.lblnom.Location = new System.Drawing.Point(46, 125);
            this.lblnom.Name = "lblnom";
            this.lblnom.Size = new System.Drawing.Size(98, 33);
            this.lblnom.TabIndex = 2;
            this.lblnom.Text = "Nom :";
            // 
            // lblfonction
            // 
            this.lblfonction.AutoSize = true;
            this.lblfonction.Location = new System.Drawing.Point(46, 188);
            this.lblfonction.Name = "lblfonction";
            this.lblfonction.Size = new System.Drawing.Size(162, 33);
            this.lblfonction.TabIndex = 3;
            this.lblfonction.Text = "Fonction : ";
            // 
            // lnlsalaire
            // 
            this.lnlsalaire.AutoSize = true;
            this.lnlsalaire.Location = new System.Drawing.Point(46, 249);
            this.lnlsalaire.Name = "lnlsalaire";
            this.lnlsalaire.Size = new System.Drawing.Size(140, 33);
            this.lnlsalaire.TabIndex = 4;
            this.lnlsalaire.Text = "Salaire : ";
            // 
            // lblnbemploye
            // 
            this.lblnbemploye.BackColor = System.Drawing.SystemColors.Window;
            this.lblnbemploye.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblnbemploye.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnbemploye.Location = new System.Drawing.Point(162, 430);
            this.lblnbemploye.Name = "lblnbemploye";
            this.lblnbemploye.Size = new System.Drawing.Size(508, 44);
            this.lblnbemploye.TabIndex = 5;
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(214, 58);
            this.txtnumero.Multiline = true;
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(376, 42);
            this.txtnumero.TabIndex = 6;
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(214, 122);
            this.txtnom.Multiline = true;
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(376, 42);
            this.txtnom.TabIndex = 7;
            // 
            // txtfonction
            // 
            this.txtfonction.Location = new System.Drawing.Point(214, 185);
            this.txtfonction.Multiline = true;
            this.txtfonction.Name = "txtfonction";
            this.txtfonction.Size = new System.Drawing.Size(376, 42);
            this.txtfonction.TabIndex = 8;
            // 
            // txtsalaire
            // 
            this.txtsalaire.Location = new System.Drawing.Point(214, 246);
            this.txtsalaire.Multiline = true;
            this.txtsalaire.Name = "txtsalaire";
            this.txtsalaire.Size = new System.Drawing.Size(376, 42);
            this.txtsalaire.TabIndex = 9;
            // 
            // btnajouter
            // 
            this.btnajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnajouter.Location = new System.Drawing.Point(798, 62);
            this.btnajouter.Name = "btnajouter";
            this.btnajouter.Size = new System.Drawing.Size(214, 53);
            this.btnajouter.TabIndex = 10;
            this.btnajouter.Text = "Ajouter";
            this.btnajouter.UseVisualStyleBackColor = true;
            this.btnajouter.Click += new System.EventHandler(this.btnajouter_Click);
            // 
            // btnmodifier
            // 
            this.btnmodifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodifier.Location = new System.Drawing.Point(798, 128);
            this.btnmodifier.Name = "btnmodifier";
            this.btnmodifier.Size = new System.Drawing.Size(214, 53);
            this.btnmodifier.TabIndex = 11;
            this.btnmodifier.Text = "Modifier";
            this.btnmodifier.UseVisualStyleBackColor = true;
            this.btnmodifier.Click += new System.EventHandler(this.btnmodifier_Click);
            // 
            // btnsupprimer
            // 
            this.btnsupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsupprimer.Location = new System.Drawing.Point(798, 191);
            this.btnsupprimer.Name = "btnsupprimer";
            this.btnsupprimer.Size = new System.Drawing.Size(214, 53);
            this.btnsupprimer.TabIndex = 12;
            this.btnsupprimer.Text = "Supprimer";
            this.btnsupprimer.UseVisualStyleBackColor = true;
            this.btnsupprimer.Click += new System.EventHandler(this.btnsupprimer_Click);
            // 
            // btnsauvegarder
            // 
            this.btnsauvegarder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsauvegarder.Location = new System.Drawing.Point(798, 281);
            this.btnsauvegarder.Name = "btnsauvegarder";
            this.btnsauvegarder.Size = new System.Drawing.Size(214, 53);
            this.btnsauvegarder.TabIndex = 13;
            this.btnsauvegarder.Text = "Sauvegarder";
            this.btnsauvegarder.UseVisualStyleBackColor = true;
            this.btnsauvegarder.Click += new System.EventHandler(this.btnsauvegarder_Click);
            // 
            // btnannuler
            // 
            this.btnannuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnannuler.Location = new System.Drawing.Point(798, 340);
            this.btnannuler.Name = "btnannuler";
            this.btnannuler.Size = new System.Drawing.Size(214, 53);
            this.btnannuler.TabIndex = 14;
            this.btnannuler.Text = "Annuler";
            this.btnannuler.UseVisualStyleBackColor = true;
            this.btnannuler.Click += new System.EventHandler(this.btnannuler_Click);
            // 
            // btnpremier
            // 
            this.btnpremier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpremier.Location = new System.Drawing.Point(23, 349);
            this.btnpremier.Name = "btnpremier";
            this.btnpremier.Size = new System.Drawing.Size(185, 53);
            this.btnpremier.TabIndex = 15;
            this.btnpremier.Text = "Premier";
            this.btnpremier.UseVisualStyleBackColor = true;
            this.btnpremier.Click += new System.EventHandler(this.btnpremier_Click);
            // 
            // btnprecedent
            // 
            this.btnprecedent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprecedent.Location = new System.Drawing.Point(214, 349);
            this.btnprecedent.Name = "btnprecedent";
            this.btnprecedent.Size = new System.Drawing.Size(185, 53);
            this.btnprecedent.TabIndex = 16;
            this.btnprecedent.Text = "Precedent";
            this.btnprecedent.UseVisualStyleBackColor = true;
            this.btnprecedent.Click += new System.EventHandler(this.btnprecedent_Click);
            // 
            // btnsuivant
            // 
            this.btnsuivant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsuivant.Location = new System.Drawing.Point(405, 349);
            this.btnsuivant.Name = "btnsuivant";
            this.btnsuivant.Size = new System.Drawing.Size(185, 53);
            this.btnsuivant.TabIndex = 17;
            this.btnsuivant.Text = "suivant";
            this.btnsuivant.UseVisualStyleBackColor = true;
            this.btnsuivant.Click += new System.EventHandler(this.btnsuivant_Click);
            // 
            // btndernier
            // 
            this.btndernier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndernier.Location = new System.Drawing.Point(596, 349);
            this.btndernier.Name = "btndernier";
            this.btndernier.Size = new System.Drawing.Size(185, 53);
            this.btndernier.TabIndex = 18;
            this.btndernier.Text = "Dernier";
            this.btndernier.UseVisualStyleBackColor = true;
            this.btndernier.Click += new System.EventHandler(this.btndernier_Click);
            // 
            // grprecherche
            // 
            this.grprecherche.Controls.Add(this.grpinfo);
            this.grprecherche.Controls.Add(this.label2);
            this.grprecherche.Controls.Add(this.lstnumero);
            this.grprecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grprecherche.Location = new System.Drawing.Point(26, 651);
            this.grprecherche.Name = "grprecherche";
            this.grprecherche.Size = new System.Drawing.Size(1040, 392);
            this.grprecherche.TabIndex = 3;
            this.grprecherche.TabStop = false;
            this.grprecherche.Text = "Rechercher Employé Par Son Numéro";
            // 
            // lstnumero
            // 
            this.lstnumero.FormattingEnabled = true;
            this.lstnumero.ItemHeight = 33;
            this.lstnumero.Location = new System.Drawing.Point(39, 107);
            this.lstnumero.Name = "lstnumero";
            this.lstnumero.Size = new System.Drawing.Size(276, 268);
            this.lstnumero.TabIndex = 0;
            this.lstnumero.SelectedIndexChanged += new System.EventHandler(this.lstnumero_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choisir un numero";
            // 
            // grpinfo
            // 
            this.grpinfo.Controls.Add(this.lblinfosalaire);
            this.grpinfo.Controls.Add(this.lblinfofonction);
            this.grpinfo.Controls.Add(this.lblinfonom);
            this.grpinfo.Controls.Add(this.lblinfonum);
            this.grpinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpinfo.Location = new System.Drawing.Point(440, 62);
            this.grpinfo.Name = "grpinfo";
            this.grpinfo.Size = new System.Drawing.Size(571, 312);
            this.grpinfo.TabIndex = 2;
            this.grpinfo.TabStop = false;
            this.grpinfo.Text = "Informations d\'Employé Selectionné";
            // 
            // lblinfonum
            // 
            this.lblinfonum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblinfonum.Location = new System.Drawing.Point(43, 65);
            this.lblinfonum.Name = "lblinfonum";
            this.lblinfonum.Size = new System.Drawing.Size(442, 44);
            this.lblinfonum.TabIndex = 0;
            this.lblinfonum.Text = "Numéro : ";
            // 
            // lblinfonom
            // 
            this.lblinfonom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblinfonom.Location = new System.Drawing.Point(43, 128);
            this.lblinfonom.Name = "lblinfonom";
            this.lblinfonom.Size = new System.Drawing.Size(442, 44);
            this.lblinfonom.TabIndex = 1;
            this.lblinfonom.Text = "Nom : ";
            // 
            // lblinfofonction
            // 
            this.lblinfofonction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblinfofonction.Location = new System.Drawing.Point(43, 188);
            this.lblinfofonction.Name = "lblinfofonction";
            this.lblinfofonction.Size = new System.Drawing.Size(442, 44);
            this.lblinfofonction.TabIndex = 2;
            this.lblinfofonction.Text = "Fonction : ";
            // 
            // lblinfosalaire
            // 
            this.lblinfosalaire.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblinfosalaire.Location = new System.Drawing.Point(43, 249);
            this.lblinfosalaire.Name = "lblinfosalaire";
            this.lblinfosalaire.Size = new System.Drawing.Size(442, 44);
            this.lblinfosalaire.TabIndex = 3;
            this.lblinfosalaire.Text = "Salaire : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(401, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(342, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "DE FIN DE SESSION";
            // 
            // frmExamFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 1055);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grprecherche);
            this.Controls.Add(this.grpgestion);
            this.Controls.Add(this.label1);
            this.Name = "frmExamFinal";
            this.Text = "frmExamFinal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmExamFinal_FormClosing);
            this.Load += new System.EventHandler(this.frmExamFinal_Load);
            this.grpgestion.ResumeLayout(false);
            this.grpgestion.PerformLayout();
            this.grprecherche.ResumeLayout(false);
            this.grprecherche.PerformLayout();
            this.grpinfo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblnum;
        private System.Windows.Forms.GroupBox grpgestion;
        private System.Windows.Forms.Button btndernier;
        private System.Windows.Forms.Button btnsuivant;
        private System.Windows.Forms.Button btnprecedent;
        private System.Windows.Forms.Button btnpremier;
        private System.Windows.Forms.Button btnannuler;
        private System.Windows.Forms.Button btnsauvegarder;
        private System.Windows.Forms.Button btnsupprimer;
        private System.Windows.Forms.Button btnmodifier;
        private System.Windows.Forms.Button btnajouter;
        private System.Windows.Forms.TextBox txtsalaire;
        private System.Windows.Forms.TextBox txtfonction;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Label lblnbemploye;
        private System.Windows.Forms.Label lnlsalaire;
        private System.Windows.Forms.Label lblfonction;
        private System.Windows.Forms.Label lblnom;
        private System.Windows.Forms.GroupBox grprecherche;
        private System.Windows.Forms.GroupBox grpinfo;
        private System.Windows.Forms.Label lblinfosalaire;
        private System.Windows.Forms.Label lblinfofonction;
        private System.Windows.Forms.Label lblinfonom;
        private System.Windows.Forms.Label lblinfonum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstnumero;
        private System.Windows.Forms.Label label3;
    }
}