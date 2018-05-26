using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ianmann.Hr.DataAccess.Abstraction.Employment.DataContracts
{
    public interface IEmployeeContract
    {
        int EmployeeID { get; }
        string FirstName { get; }
        string LastName { get; }
        string MiddleName { get; }
    }
}
