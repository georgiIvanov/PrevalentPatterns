using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IEmployeeRepository
    {
        void Add(Employee newEmployee);
        void Remove(Employee employee);
        IQueryable<Employee> Find(Expression<Func<Employee, bool>> predicate);
    }
}
