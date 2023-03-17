using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Models
{
    public class Rent
    {
        public int Id { get; set; }
        public Book Book { get; set; }
        public int Amount { get; set; }
        public DateTime RentDate { get; set; }
        public int RentDays { get; set; }
        public decimal TotalPayment { get; set; }
    }
}
