using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IssueTracker.Models
{
    public class MockStatusesRepository : IStatusRepository
    {
        public IEnumerable<Status> AllStatuses =>
            new List<Status>
            {
                new Status { StatusId = 1, StatusDescription = "Waiting for Staff Response", StatusName = "Waiting for Staff Response" },
                new Status { StatusId = 1, StatusDescription = "Waiting for Customer", StatusName = "Waiting for Customer" },
                new Status { StatusId = 1, StatusDescription = "On Hold", StatusName = "On Hold" },
                new Status { StatusId = 1, StatusDescription = "Cancelled", StatusName = "Cancelled" },
                new Status { StatusId = 1, StatusDescription = "Completed", StatusName = "Completed" }

            };
    }
}
