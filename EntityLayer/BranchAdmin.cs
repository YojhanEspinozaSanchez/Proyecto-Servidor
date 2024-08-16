using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 UNED II Cuatrimestre
Proyecto II: Registro de Rentas de Peliculas
Yojhan Espinoza
Fecha: 11/7/2024
 */
//clase encargado
namespace EntityLayer
{
    public class BranchAdmin : Person
    {
        public BranchAdmin() { }
        public BranchAdmin(int systemId, string id, string name, string firstLastName, string secondLastName, DateTime birthDate, DateTime entryDate) : base(systemId, id, name, firstLastName, secondLastName, birthDate, entryDate)
        {
        }
    }
}
