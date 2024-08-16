using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataLayer;

/*
 UNED II Cuatrimestre
Proyecto II: Registro de Rentas de Peliculas
Yojhan Espinoza
Fecha: 11/7/2024
 */

namespace BusinessLayer
{
    public class AdminsBL
    {
        //Obtener la lista de encargados
        public List<BranchAdmin> getAdmins()
        {
            DataBase adminsDB = new DataBase();
            return adminsDB.GetAdmins();
        }

        //buscar un encargado por el id
        public BranchAdmin searchAdmin(int id)
        {
            DataBase adminsDB = new DataBase();
            return adminsDB.searchAdmin(id);
        }

        //guardar encargado en la base
        public bool insertAdmin(BranchAdmin admin)
        {
            DataBase adminsDB = new DataBase();
            return adminsDB.InsertAdmin(admin);
        }

        //verificar si existe el id de encargado
        public bool existId(int id)
        {
            DataBase adminsDB = new DataBase();
            return adminsDB.ExistsAdminId(id);
        }


    }
}