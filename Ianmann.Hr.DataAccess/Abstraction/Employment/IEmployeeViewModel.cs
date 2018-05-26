using Ianmann.Hr.DataAccess.Abstraction.Employment.DataContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ianmann.Hr.DataAccess.Abstraction.Employment
{
    interface IEmployeeViewModel
    {
        IEmployeeContract CreateEmployee(string lirstName, string lastName, string middleName, DateTime birthDate);

        IEmployeeContract GetEmployee(int employeeId);
    }
}
