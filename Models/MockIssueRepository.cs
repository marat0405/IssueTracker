using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IssueTracker.Models
{
    public class MockIssueRepository : IIssueRepository
    {
        public IEnumerable<Issue> AllIssues =>
            new List<Issue>
            {
                new Issue{IssueId=new Guid().ToString(), Subject = "Issue 1",Description="Lorem ipsum dolor sit amet, consectetur " +
                    "adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua",DepartmentId=1,StatusId=1},
                 new Issue{IssueId=new Guid().ToString(), Subject = "Issue 2",Description="Lorem ipsum dolor sit amet, consectetur " +
                    "adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua",DepartmentId=2,StatusId=2},
                  new Issue{IssueId=new Guid().ToString(), Subject = "Issue 3",Description="Lorem ipsum dolor sit amet, consectetur " +
                    "adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua",DepartmentId=3,StatusId=3}

            };


        public IEnumerable<Issue> GetIssueByStatusId(int statusId)
        {
            return this.AllIssues.Where(i => i.StatusId == statusId);
        }
        public Issue GetIssueById(string issueId)
        {
            return this.AllIssues.Where(i => i.IssueId == issueId).FirstOrDefault();
        }
    }
}
