using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEtudiant.dao
{
    //Peut être une Personne, un Detail ou une classe
   public interface IDao<T>
    {
        int Insert(T obj);
    }
}
