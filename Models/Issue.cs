using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IssueTracker.Models
{
    public class Issue
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string IssueId { get; set; }
       public string Description { get; set; }
       public string Subject { get; set; }
       public int DepartmentId { get; set; }
       public Department Department { get; set; }
       public int StatusId { get; set; }
       public Status Status { get; set; } 

    }
}
