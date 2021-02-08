namespace GestionEtudiant
{
    partial class FrmProfesseur
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btnAttribuerClasse = new System.Windows.Forms.Button();
            this.cboClasse = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboGrade = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomPrenom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMatricule = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboModules = new System.Windows.Forms.ComboBox();
            this.btnAddModules = new System.Windows.Forms.Button();
            this.lboModulesEnseignes = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lboClassesEnseignees = new System.Windows.Forms.ListBox();
            this.btnAddClasse = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddClasse);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.btnAttribuerClasse);
            this.groupBox1.Controls.Add(this.cboClasse);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cboGrade);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNomPrenom);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMatricule);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(33, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1060, 159);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Données Professeur";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(490, 81);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 34);
            this.button3.TabIndex = 10;
            this.button3.Text = "Annuler";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnAttribuerClasse
            // 
            this.btnAttribuerClasse.Location = new System.Drawing.Point(490, 24);
            this.btnAttribuerClasse.Name = "btnAttribuerClasse";
            this.btnAttribuerClasse.Size = new System.Drawing.Size(118, 35);
            this.btnAttribuerClasse.TabIndex = 9;
            this.btnAttribuerClasse.Text = "Attribuer";
            this.btnAttribuerClasse.UseVisualStyleBackColor = true;
            // 
            // cboClasse
            // 
            this.cboClasse.FormattingEnabled = true;
            this.cboClasse.Location = new System.Drawing.Point(791, 83);
            this.cboClasse.Name = "cboClasse";
            this.cboClasse.Size = new System.Drawing.Size(213, 32);
            this.cboClasse.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(686, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Classe";
            // 
            // cboGrade
            // 
            this.cboGrade.FormattingEnabled = true;
            this.cboGrade.Location = new System.Drawing.Point(791, 27);
            this.cboGrade.Name = "cboGrade";
            this.cboGrade.Size = new System.Drawing.Size(213, 32);
            this.cboGrade.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(686, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Grade";
            // 
            // txtNomPrenom
            // 
            this.txtNomPrenom.Location = new System.Drawing.Point(203, 86);
            this.txtNomPrenom.Name = "txtNomPrenom";
            this.txtNomPrenom.Size = new System.Drawing.Size(213, 29);
            this.txtNomPrenom.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nom & Prenom";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtMatricule
            // 
            this.txtMatricule.Location = new System.Drawing.Point(203, 30);
            this.txtMatricule.Name = "txtMatricule";
            this.txtMatricule.Size = new System.Drawing.Size(213, 29);
            this.txtMatricule.TabIndex = 1;
            this.txtMatricule.TextChanged += new System.EventHandler(this.txtMatricule_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matricule";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboModules);
            this.groupBox2.Controls.Add(this.btnAddModules);
            this.groupBox2.Controls.Add(this.lboModulesEnseignes);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(43, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(498, 424);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modules";
            // 
            // cboModules
            // 
            this.cboModules.FormattingEnabled = true;
            this.cboModules.Location = new System.Drawing.Point(193, 56);
            this.cboModules.Name = "cboModules";
            this.cboModules.Size = new System.Drawing.Size(213, 32);
            this.cboModules.TabIndex = 5;
            // 
            // btnAddModules
            // 
            this.btnAddModules.Location = new System.Drawing.Point(257, 94);
            this.btnAddModules.Name = "btnAddModules";
            this.btnAddModules.Size = new System.Drawing.Size(90, 30);
            this.btnAddModules.TabIndex = 4;
            this.btnAddModules.Text = "Ajouter";
            this.btnAddModules.UseVisualStyleBackColor = true;
            // 
            // lboModulesEnseignes
            // 
            this.lboModulesEnseignes.FormattingEnabled = true;
            this.lboModulesEnseignes.ItemHeight = 24;
            this.lboModulesEnseignes.Location = new System.Drawing.Point(45, 204);
            this.lboModulesEnseignes.Name = "lboModulesEnseignes";
            this.lboModulesEnseignes.Size = new System.Drawing.Size(361, 172);
            this.lboModulesEnseignes.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "Modules Enseignés";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Modules";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lboClassesEnseignees);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(642, 177);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(451, 424);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Classes Enseignées";
            // 
            // lboClassesEnseignees
            // 
            this.lboClassesEnseignees.FormattingEnabled = true;
            this.lboClassesEnseignees.ItemHeight = 24;
            this.lboClassesEnseignees.Location = new System.Drawing.Point(27, 92);
            this.lboClassesEnseignees.Name = "lboClassesEnseignees";
            this.lboClassesEnseignees.Size = new System.Drawing.Size(403, 292);
            this.lboClassesEnseignees.TabIndex = 0;
            this.lboClassesEnseignees.SelectedIndexChanged += new System.EventHandler(this.lboClassesEnseignees_SelectedIndexChanged);
            // 
            // btnAddClasse
            // 
            this.btnAddClasse.Location = new System.Drawing.Point(964, 124);
            this.btnAddClasse.Name = "btnAddClasse";
            this.btnAddClasse.Size = new System.Drawing.Size(75, 29);
            this.btnAddClasse.TabIndex = 11;
            this.btnAddClasse.Text = "add";
            this.btnAddClasse.UseVisualStyleBackColor = true;
            this.btnAddClasse.Click += new System.EventHandler(this.btnAddClasse_Click);
            // 
            // FrmProfesseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 657);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmProfesseur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestion Etudiant";
            this.Load += new System.EventHandler(this.FrmProfesseur_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMatricule;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboGrade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomPrenom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboClasse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboModules;
        private System.Windows.Forms.Button btnAddModules;
        private System.Windows.Forms.ListBox lboModulesEnseignes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lboClassesEnseignees;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnAttribuerClasse;
        private System.Windows.Forms.Button btnAddClasse;
    }
}