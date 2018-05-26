using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ianmann.Hr.DataAccess.Abstraction.Employment.DataContracts;
using Ianmann.Hr.DataAccess.DataAccess.Employment;

namespace Ianmann.Hr.DataAccess.Abstraction.Employment
{
    public class EmployeeViewModel : ViewModelBase, IEmployeeViewModel
    {
        public IEmployeeContract CreateEmployee(string firstName, string lastName, string middleName, DateTime birthDate)
        {
            using (EmploymentContext ctx = new EmploymentContext())
            {
                Employee emp = new Employee()
                {
                    FirstName=firstName,
                    LastName=lastName,
                    MiddleName=middleName,
                    BirthDate=birthDate
                };
                ctx.Employees.Add(emp);
                int numObjectsSaved = ctx.SaveChanges();
                if (numObjectsSaved == 1)
                {
                    return new EmployeeContract(emp);
                }
            }
            return null;
        }

        public IEmployeeContract GetEmployee(int employeeId)
        {
            throw new NotImplementedException();
        }
    }
}
