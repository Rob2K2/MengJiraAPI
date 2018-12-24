using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiraAPI
{
    public partial class IssuesList
    {
        public string Expand { get; set; }
        public long StartAt { get; set; }
        public long MaxResults { get; set; }
        public long Total { get; set; }
        public List<Issue> Issues { get; set; }
    }

    public partial class Issue
    {
        public string Expand { get; set; }
        public long Id { get; set; }
        public Uri Self { get; set; }
        public string Key { get; set; }

    }
}
   