using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IssueTracker.Models
{
    public interface IIssueRepository
    {
        Issue GetIssueById(string issueId);
        IEnumerable<Issue> AllIssues { get; }
        IEnumerable<Issue> GetIssueByStatusId(int categoryId);
       
    }
}
