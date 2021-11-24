using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IssueTracker.Models
{
    interface IDepartmentRepository
    {
        IEnumerable<Department> AllDepartments { get; }
        Department GetDepatmentById(int id);

    }
}
