using GestionEtudiant.entityframework;
using GestionEtudiant.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionEtudiant
{
    public partial class FrmProfesseur : Form
    {
        ServiceEF metier = new ServiceEF();
        public FrmProfesseur()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmProfesseur_Load(object sender, EventArgs e)
        {
            cboClasse.DataSource = metier.ListerClasse();
            cboClasse.DisplayMember = "libelle";
            cboClasse.ValueMember = "id";

            cboGrade.DataSource = metier.ListerGrade();
            cboModules.DataSource = metier.ListerModule();
        }

        personne prof;
        List<classe> classeEnseignees;
        private void txtMatricule_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtMatricule.Text))
            {
                prof= metier.ChercherProfesseurParMatricule(txtMatricule.Text.Trim());
                if(prof != null)
                {
                    txtNomPrenom.Text = prof.nom_complet;
                    cboGrade.SelectedItem = prof.grade;

                    lboClassesEnseignees.DataSource = metier.ClassesEnseignees(prof);
                    lboClassesEnseignees.DisplayMember = "libelle";
                    classe classeSelected =(classe) lboClassesEnseignees.SelectedItem;
                    lboModulesEnseignes.DataSource = metier.ListerModulesProfesseurParClasse(classeSelected, prof);

                }
                else
                {
                    txtNomPrenom.Clear();
                    cboGrade.SelectedIndex = 0;
                }

            }
        }

        private void lboClassesEnseignees_SelectedIndexChanged(object sender, EventArgs e)
        {
            classe classeSelected = (classe)lboClassesEnseignees.SelectedItem;
            lboModulesEnseignes.DataSource = metier.ListerModulesProfesseurParClasse(classeSelected, prof);
        }

        private void btnAddClasse_Click(object sender, EventArgs e)
        {
            classe classeSelected =(classe) cboClasse.SelectedItem;
            classeEnseignees.Add(classeSelected);

            lboClassesEnseignees.SelectedItem = classeSelected;
        }
    }
}
