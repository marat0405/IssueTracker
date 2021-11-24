using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IssueTracker.Models
{
    public class MockDepartmentRepository : IDepartmentRepository
    {
       public IEnumerable<Department> AllDepartments =>
            new List<Department>
            {
                new Department{DepartmentId=1,DepartmentName = "EMC"},
                new Department{DepartmentId=2,DepartmentName = "HR"},
                new Department{DepartmentId=2,DepartmentName = "Solution Delivery"},

            };
       public Department GetDepatmentById(int id)
        {
            return this.AllDepartments.Where(d => d.DepartmentId == id).FirstOrDefault();
        }
    }
}
