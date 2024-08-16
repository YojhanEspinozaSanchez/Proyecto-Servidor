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
    public class CustomersBL
    {
        //obtener lista de clientes
        public List<Customer> GetCustomers()
        {
            DataBase dataBase = new DataBase();
            return dataBase.GetCustomers();
        }


        //guardar clientes en la base
        public bool insertCustomer(Customer customer)
        {
            DataBase dataBase = new DataBase();
            return dataBase.InsertCustomer(customer);
        }


        //vreficar si existe un id de cliente
        public bool existId(int id)
        {
            DataBase dataBase = new DataBase();
            return dataBase.ExistsCustomerId(id);
        }

    }
}
