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
    public class LoanBL
    {
        //obtener una lista de prestamos
        public List<Loan> GetLoan()
        {
            DataBase dataBase = new DataBase();
            return dataBase.GetLoan();
        }

        //guardar prestamo en la base
        public bool insertLoan(Loan loan)
        {
            DataBase dataBase = new DataBase();
            return dataBase.InsertLoan(loan);
        }
        //verificar si existe un id de prestamo
        public bool existId(int movieId, int customerId)
        {
            DataBase dataBase = new DataBase();
            return dataBase.ExistsLoan(movieId, customerId);
        }

        //obtener una lista de prestamos por cliente
        public List<Loan> getFiltered(Customer customer)
        {
            DataBase dataBase = new DataBase();
            return dataBase.GetFiltered(customer);
        }
    }
}
