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
    public partial class FrmInscription : Form
    {
        private ServiceEF metierEF = new ServiceEF();
        public FrmInscription()
        {
            InitializeComponent();
        }

        private void txtNomPrenom_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtNomPrenom.Text) || string.IsNullOrEmpty(txtTuteur.Text))
            {
                MessageBox.Show(
                    "Champs Obligatoire",
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
            else
            {
                personne pers = new personne()
                {
                    nom_complet = txtNomPrenom.Text.Trim(),
                    tuteur = txtTuteur.Text.Trim(),
                    type = "Etudiant",
                    classe_id=int.Parse(cboClasse.SelectedValue.ToString()) 
                    
                };
                if(metierEF.CreerPersonne(pers))
                {
                    MessageBox.Show(
                   "Etudiant Inscrit avec Succes",
                   "Information",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information
                   );
                }
                else
                {
                    MessageBox.Show(
                                   "Erreur D'inscription",
                                   "Erreur",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error
                                   );
                }
            }
        }

        private void FrmInscription_Load(object sender, EventArgs e)
        {
            cboClasse.DataSource = metierEF.ListerClasse();
            cboClasse.DisplayMember = "libelle";
            cboClasse.ValueMember = "id";
        }
    }
}
