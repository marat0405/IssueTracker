using IssueTracker.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IssueTracker.Controllers
{
    public class IssueController : Controller
    {
        private readonly IIssueRepository issueRepository;
        private readonly IStatusRepository statusRepository;

        public IssueController(IIssueRepository _issueRepository,IStatusRepository _statusRepository)
        {
            issueRepository = _issueRepository;
            statusRepository = _statusRepository; 
        }
        public IActionResult List()
        {
            return View(issueRepository.AllIssues);

        }
       
    }
}
