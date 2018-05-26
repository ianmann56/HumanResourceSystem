using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ianmann.Hr.DataAccess.DataAccess.Employment
{
    public class Position
    {
        public int PositionID { get; set; }
        public string Name { get; set; }
        
        public ICollection<Employment> Employments { get; set; }
    }
}
