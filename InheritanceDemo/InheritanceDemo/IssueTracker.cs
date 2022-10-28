using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    internal class IssueTracker
    {
        private int IssueId;
        private string IssueSummary;
        private string IssueStatus;
        private string IssuePriority;

        public IssueTracker(int issueId, string issueSummary, string issueStatus, string issuePriority)
        {
            IssueId = issueId;
            IssueSummary = issueSummary;
            IssueStatus = issueStatus;
            IssuePriority = issuePriority;
        }

        public override string? ToString()
        {
            return "Issue id is " + IssueId + " Issue summary is " + IssueSummary + " issue status is " + IssueStatus + " and Issue priority is " + IssuePriority;
        }
    }
}
