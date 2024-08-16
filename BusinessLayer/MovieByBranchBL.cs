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
    public class MovieByBranchBL
    {
        //obtener lista de peliculas por sucursal
        public List<MovieByBranch> GetAssociation()
        {
            DataBase dataBase = new DataBase();
            return dataBase.GetAssociation();
        }
        //guardar pelicula por sucursal
        public bool insertAssociation(MovieByBranch movieByBranch)
        {
            DataBase dataBase = new DataBase();
            return dataBase.InsertAssociation(movieByBranch);
        }
        //verificar si ya existe la asociacion
        public bool existAssociation(int idMovie, int idBranch)
        {
            DataBase dataBase = new DataBase();
            return dataBase.ExistsAssociation(idMovie, idBranch);
        }
        //actualizar cantidad de peliculas
        public void updateQty(MovieByBranch movieByBranch)
        {
            DataBase dataBase = new DataBase();
            dataBase.UpdateQty(movieByBranch);
        }
        //validar la cantidad de peliculas
        public bool validateQty(MovieByBranch movieByBranch)
        {
            DataBase dataBase = new DataBase();
            return dataBase.validateQuantity(movieByBranch);
        }
    }
}
