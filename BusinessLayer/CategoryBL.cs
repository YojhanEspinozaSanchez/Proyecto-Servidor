using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using EntityLayer;

/*
 UNED II Cuatrimestre
Proyecto II: Registro de Rentas de Peliculas
Yojhan Espinoza
Fecha: 11/7/2024
 */

namespace BusinessLayer
{
    public class CategoryBL
    {
        //obtener lista de categorias
        public List<Category> GetCategory()
        {
            DataBase adminsDB = new DataBase();
            return adminsDB.GetCategory();
        }
        //buscar una categoria por el id
        public Category SearchCategory(int id)
        {
            DataBase adminsDB = new DataBase();
            return adminsDB.searchCategory(id);
        }

        //guardar categoria en la base
        public bool InsertCategory(Category category)
        {
            DataBase adminsDB = new DataBase();
            return adminsDB.InsertCategory(category);
        }

        //verificar si existe un id de categoria
        public bool existId(int id)
        {
            DataBase adminsDB = new DataBase();
            return adminsDB.ExistsCategoryId(id);
        }
    }
}
