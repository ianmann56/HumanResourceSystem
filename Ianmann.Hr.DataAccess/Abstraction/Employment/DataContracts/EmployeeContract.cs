using Ianmann.Hr.DataAccess.DataAccess.Employment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ianmann.Hr.DataAccess.Abstraction.Employment.DataContracts
{
    public class EmployeeContract : IEmployeeContract
    {
        public EmployeeContract(int employeeId, string firstName, string lastName, string middleName)
        {
            this.EmployeeID = employeeId;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.MiddleName = middleName;
        }

        public EmployeeContract(Employee dataModel)
        {
            this.EmployeeID = dataModel.EmployeeID;
            this.FirstName = dataModel.FirstName;
            this.LastName = dataModel.LastName;
            this.MiddleName = dataModel.MiddleName;
        }

        public int EmployeeID { get; private set; }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public string MiddleName { get; private set; }
    }
}
