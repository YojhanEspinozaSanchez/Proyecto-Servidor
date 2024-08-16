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
//clase categoria
namespace EntityLayer
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Category() { }

        public Category(int id, string name, string description)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
        }

    }
}
