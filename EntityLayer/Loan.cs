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
//clase prestamo
namespace EntityLayer
{
    public class Loan
    {
        public int LoanId { get; set; }
        public int CustomerId { get; set; }
        public int BranchId { get; set; }
        public int MovieId { get; set; }
        public DateTime Date { get; set; }
        public bool Pending { get; set; }
        public Loan() { }

        public Loan(int loanId, int customerId, int branchId, int movieId, DateTime date, bool pending)
        {
            this.LoanId = loanId;
            this.CustomerId = customerId;
            this.BranchId = branchId;
            this.MovieId = movieId;
            this.Date = date;
            this.Pending = pending;
        }
    }
}
