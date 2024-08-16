using DataLayer;
using EntityLayer;
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


namespace BusinessLayer
{
    public class BranchBL
    {
        //obtener lista de sucursal
        public List<Branch> GetBranch()
        {
            DataBase dataBase = new DataBase();
            return dataBase.GetBranch();
        }

        //guardar sucursal en la base
        public bool insertBranch(Branch branch)
        {
            DataBase dataBase = new DataBase();
            return dataBase.InsertBranch(branch);
        }

        //verificar si existe un id de sucursal
        public bool existId(int id)
        {
            DataBase dataBase = new DataBase();
            return dataBase.ExistsBranchId(id);
        }

        //verificar si exiiste un id de encargado
        public bool existAdminId(int id)
        {
            DataBase dataBase = new DataBase();
            return dataBase.ExistsAdminId(id);
        }

    }
}
