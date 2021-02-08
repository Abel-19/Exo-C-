using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEtudiant.models
{
   public class Classe
    {
        //Attribut
        private int id;
        private String libelle;
        private int nbreEtudiant;

        //Constructeur
        //Surcharge
        public Classe()
        {
        }

        
        //Insertion
        public Classe(string libelle, int nbreEtudiant)
        {
            this.Libelle = libelle;
            this.NbreEtudiant = nbreEtudiant;
        }
        //Slection
        public Classe(int id, string libelle, int nbreEtudiant)
        {
            this.Id = id;
            this.Libelle = libelle;
            this.NbreEtudiant = nbreEtudiant;
        }

        //Get et Set == Proprieté
        public int Id { get => id; set => id = value; }
        public string Libelle { get => libelle; set => libelle = value; }
        public int NbreEtudiant { get => nbreEtudiant; set => nbreEtudiant = value; }

        //ToString()
        public override string ToString()
        {
            return libelle;
        }

        public Classe(int id)
        {
            this.id = id;
        }
    }
}
