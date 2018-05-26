using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ianmann.Hr.DataAccess.DataAccess.Employment
{
    public class Employment
    {
        public int EmploymentID { get; set; }
        public float Wage { get; set; }
        
        public Position Position { get; set; }
        public Employee Employee { get; set; }
    }
}
