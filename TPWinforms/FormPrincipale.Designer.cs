﻿
namespace TPWinforms
{
    partial class FormPrincipale
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            this.listViewBanqueComptes = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblActifsTotal = new System.Windows.Forms.Label();
            this.lblActifsGele = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelNbComptes = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelNbActifs = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelNbGeles = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelNbFermes = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnAjouterCompte = new System.Windows.Forms.Button();
            this.btnVerserInterets = new System.Windows.Forms.Button();
            this.btnSupprimerCompte = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemReset = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Helvetica LT Std", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(67)))));
            this.label1.Location = new System.Drawing.Point(51, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 85);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jedi";
            // 
            // listViewBanqueComptes
            // 
            this.listViewBanqueComptes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewBanqueComptes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.listViewBanqueComptes.HideSelection = false;
            this.listViewBanqueComptes.Location = new System.Drawing.Point(51, 373);
            this.listViewBanqueComptes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listViewBanqueComptes.MultiSelect = false;
            this.listViewBanqueComptes.Name = "listViewBanqueComptes";
            this.listViewBanqueComptes.Size = new System.Drawing.Size(816, 335);
            this.listViewBanqueComptes.TabIndex = 1;
            this.listViewBanqueComptes.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Helvetica LT Std", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(125)))), ((int)(((byte)(152)))));
            this.label2.Location = new System.Drawing.Point(31, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Helvetica LT Std", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(125)))), ((int)(((byte)(152)))));
            this.label3.Location = new System.Drawing.Point(31, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Gelé:";
            // 
            // lblActifsTotal
            // 
            this.lblActifsTotal.Font = new System.Drawing.Font("Helvetica LT Std", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblActifsTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(59)))), ((int)(((byte)(83)))));
            this.lblActifsTotal.Location = new System.Drawing.Point(93, 27);
            this.lblActifsTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActifsTotal.Name = "lblActifsTotal";
            this.lblActifsTotal.Size = new System.Drawing.Size(203, 29);
            this.lblActifsTotal.TabIndex = 4;
            this.lblActifsTotal.Text = "5 408,00 $";
            // 
            // lblActifsGele
            // 
            this.lblActifsGele.Font = new System.Drawing.Font("Helvetica LT Std", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblActifsGele.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(59)))), ((int)(((byte)(83)))));
            this.lblActifsGele.Location = new System.Drawing.Point(93, 73);
            this.lblActifsGele.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActifsGele.Name = "lblActifsGele";
            this.lblActifsGele.Size = new System.Drawing.Size(203, 29);
            this.lblActifsGele.TabIndex = 6;
            this.lblActifsGele.Text = "1 926,00 $";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblActifsTotal);
            this.groupBox1.Controls.Add(this.lblActifsGele);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Helvetica LT Std", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(125)))), ((int)(((byte)(152)))));
            this.groupBox1.Location = new System.Drawing.Point(51, 163);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(322, 115);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actifs";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelNbComptes,
            this.toolStripStatusLabelNbActifs,
            this.toolStripStatusLabelNbGeles,
            this.toolStripStatusLabelNbFermes});
            this.statusStrip1.Location = new System.Drawing.Point(0, 755);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(915, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip";
            // 
            // toolStripStatusLabelNbComptes
            // 
            this.toolStripStatusLabelNbComptes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(78)))), ((int)(((byte)(104)))));
            this.toolStripStatusLabelNbComptes.Name = "toolStripStatusLabelNbComptes";
            this.toolStripStatusLabelNbComptes.Size = new System.Drawing.Size(134, 17);
            this.toolStripStatusLabelNbComptes.Text = "Nombre de comptes: 12";
            // 
            // toolStripStatusLabelNbActifs
            // 
            this.toolStripStatusLabelNbActifs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(78)))), ((int)(((byte)(104)))));
            this.toolStripStatusLabelNbActifs.Name = "toolStripStatusLabelNbActifs";
            this.toolStripStatusLabelNbActifs.Size = new System.Drawing.Size(98, 17);
            this.toolStripStatusLabelNbActifs.Text = "Comptes actifs: 5";
            // 
            // toolStripStatusLabelNbGeles
            // 
            this.toolStripStatusLabelNbGeles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(78)))), ((int)(((byte)(104)))));
            this.toolStripStatusLabelNbGeles.Name = "toolStripStatusLabelNbGeles";
            this.toolStripStatusLabelNbGeles.Size = new System.Drawing.Size(97, 17);
            this.toolStripStatusLabelNbGeles.Text = "Comptes gelés: 3";
            // 
            // toolStripStatusLabelNbFermes
            // 
            this.toolStripStatusLabelNbFermes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(78)))), ((int)(((byte)(104)))));
            this.toolStripStatusLabelNbFermes.Name = "toolStripStatusLabelNbFermes";
            this.toolStripStatusLabelNbFermes.Size = new System.Drawing.Size(106, 17);
            this.toolStripStatusLabelNbFermes.Text = "Comptes fermés: 4";
            // 
            // btnAjouterCompte
            // 
            this.btnAjouterCompte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAjouterCompte.AutoSize = true;
            this.btnAjouterCompte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(249)))), ((int)(((byte)(229)))));
            this.btnAjouterCompte.FlatAppearance.BorderSize = 0;
            this.btnAjouterCompte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(230)))), ((int)(((byte)(151)))));
            this.btnAjouterCompte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(242)))), ((int)(((byte)(199)))));
            this.btnAjouterCompte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouterCompte.Font = new System.Drawing.Font("Helvetica LT Std", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAjouterCompte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(96)))), ((int)(((byte)(14)))));
            this.btnAjouterCompte.Location = new System.Drawing.Point(645, 309);
            this.btnAjouterCompte.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAjouterCompte.Name = "btnAjouterCompte";
            this.btnAjouterCompte.Size = new System.Drawing.Size(224, 39);
            this.btnAjouterCompte.TabIndex = 9;
            this.btnAjouterCompte.Text = "Ajouter un compte";
            this.btnAjouterCompte.UseVisualStyleBackColor = false;
            // 
            // btnVerserInterets
            // 
            this.btnVerserInterets.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerserInterets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.btnVerserInterets.FlatAppearance.BorderSize = 0;
            this.btnVerserInterets.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(204)))), ((int)(((byte)(220)))));
            this.btnVerserInterets.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(226)))), ((int)(((byte)(236)))));
            this.btnVerserInterets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerserInterets.Font = new System.Drawing.Font("Helvetica LT Std", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVerserInterets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(78)))), ((int)(((byte)(104)))));
            this.btnVerserInterets.Location = new System.Drawing.Point(701, 249);
            this.btnVerserInterets.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnVerserInterets.Name = "btnVerserInterets";
            this.btnVerserInterets.Size = new System.Drawing.Size(167, 39);
            this.btnVerserInterets.TabIndex = 10;
            this.btnVerserInterets.Text = "Verser intérêts (2%)\r\n";
            this.btnVerserInterets.UseVisualStyleBackColor = false;
            // 
            // btnSupprimerCompte
            // 
            this.btnSupprimerCompte.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSupprimerCompte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.btnSupprimerCompte.FlatAppearance.BorderSize = 0;
            this.btnSupprimerCompte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.btnSupprimerCompte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.btnSupprimerCompte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimerCompte.Font = new System.Drawing.Font("Helvetica LT Std", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSupprimerCompte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(9)))), ((int)(((byte)(30)))));
            this.btnSupprimerCompte.Location = new System.Drawing.Point(51, 309);
            this.btnSupprimerCompte.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSupprimerCompte.Name = "btnSupprimerCompte";
            this.btnSupprimerCompte.Size = new System.Drawing.Size(224, 39);
            this.btnSupprimerCompte.TabIndex = 11;
            this.btnSupprimerCompte.Text = "Supprimer le compte";
            this.btnSupprimerCompte.UseVisualStyleBackColor = false;
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(67)))));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemReset});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(915, 27);
            this.menuStrip.TabIndex = 12;
            this.menuStrip.Text = "menuStrip1";
            // 
            // toolStripMenuItemReset
            // 
            this.toolStripMenuItemReset.Checked = true;
            this.toolStripMenuItemReset.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItemReset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuItemReset.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripMenuItemReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.toolStripMenuItemReset.Name = "toolStripMenuItemReset";
            this.toolStripMenuItemReset.Size = new System.Drawing.Size(54, 23);
            this.toolStripMenuItemReset.Text = "Reset";
            // 
            // FormPrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(915, 777);
            this.Controls.Add(this.btnSupprimerCompte);
            this.Controls.Add(this.btnVerserInterets);
            this.Controls.Add(this.btnAjouterCompte);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listViewBanqueComptes);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(581, 571);
            this.Name = "FormPrincipale";
            this.Text = "Dany Gagnon";
            this.groupBox1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnSupprimerCompte;

        private System.Windows.Forms.Button btnVerserInterets;

        private System.Windows.Forms.ListView listViewBanqueComptes;

        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemReset;
        private System.Windows.Forms.MenuStrip menuStrip;


        private System.Windows.Forms.Button btnAjouterCompte;

        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelNbComptes;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelNbActifs;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelNbGeles;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelNbFermes;

        private System.Windows.Forms.StatusStrip statusStrip1;

        private System.Windows.Forms.GroupBox groupBox1;

        private System.Windows.Forms.Label lblActifsGele;

        private System.Windows.Forms.Label lblActifsTotal;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}
