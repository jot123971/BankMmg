using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BankMmg.Models
{
    public class BankSystem
    {
        [Key]

        public int Id { get; set; }
        public String employee_Name { get; set; }
        public String employee_Position { get; set; }
        public String employee_Email { get; set; }
        public String employee_Contact { get; set; }

        public String employee_Address { get; set; }
    }
}
