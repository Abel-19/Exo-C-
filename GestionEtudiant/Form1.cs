using GestionEtudiant.models;
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
    public partial class Form1 : Form
    {
        private Service metier = new Service();

        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }
        
        private void LoadDataGridView()
        {
            dtgvClasses.DataSource = metier.ListerClasse();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtLibelle.Text) || string.IsNullOrEmpty(txtNbreEtudiant.Text))
            {
                MessageBox.Show("Libelle ou Nombre Etudiant Obligatoire","Message D'Erreur", MessageBoxButtons.OK,MessageBoxIcon.Error);
                
            }
            else
            {
                Classe classe = new Classe()
                {
                    Libelle=txtLibelle.Text.Trim(),
                    NbreEtudiant=int.Parse(txtNbreEtudiant.Text.Trim())
                };
                if(metier.CreerClasse(classe))
                {
                    MessageBox.Show("Classe Creer avec Succes", "Message Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtLibelle.Clear();
                    txtNbreEtudiant.Clear();
                    LoadDataGridView();

                }
            }
        }

        private void dtgvClasses_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dtgvClasses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtgvClasses.Rows[e.RowIndex];
            row.Selected = true;
            int id = int.Parse(row.Cells[0].Value.ToString());
            Classe classe = new Classe()
            {
                Id=id
            };

            dtgvEtudiant.DataSource = metier.ListerEtudiantParClasse(classe);
        }
    }
}
