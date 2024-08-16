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
    public class MovieBL
    {
        //obtener lista de peliculas
        public List<Movie> GetMovie()
        {
            DataBase dataBase = new DataBase();
            return dataBase.GetMovie();
        }

        //guardar pelicula
        public bool insertMovie(Movie movie)
        {
            DataBase dataBase = new DataBase();
            return dataBase.InsertMovie(movie);
        }

        //verificar si existe un id
        public bool existId(int id)
        {
            DataBase dataBase = new DataBase();
            return dataBase.ExistsMovieId(id);
        }
    }
}
