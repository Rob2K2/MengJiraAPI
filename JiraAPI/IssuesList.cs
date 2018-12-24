﻿using System;
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
        public Fields Fields { get; set; }
    }

    public partial class Fields
    {
        public long? Timespent { get; set; }
        public List<object> FixVersions { get; set; }
        public long? Aggregatetimespent { get; set; }
        public object Resolution { get; set; }
        public object Customfield10027 { get; set; }
        public object Customfield10028 { get; set; }
        public object Resolutiondate { get; set; }
        public long Workratio { get; set; }
        public string LastViewed { get; set; }
        public string Created { get; set; }
        public object Customfield10020 { get; set; }
        public List<string> Customfield10021 { get; set; }
        public string Customfield10022 { get; set; }
        public List<object> Customfield10026 { get; set; }
        public List<string> Labels { get; set; }
        public object Customfield10016 { get; set; }
        public object Customfield10017 { get; set; }
        public object Customfield10019 { get; set; }
        public long? Timeestimate { get; set; }
        public long Aggregatetimeoriginalestimate { get; set; }
        public List<object> Versions { get; set; }
        public List<object> Issuelinks { get; set; }
        public string Updated { get; set; }
        public List<object> Components { get; set; }
        public long Timeoriginalestimate { get; set; }
        public string Description { get; set; }
        public object Customfield10010 { get; set; }
        public object Customfield10014 { get; set; }
        public object Customfield10015 { get; set; }
        public object Customfield10005 { get; set; }
        public object Customfield10006 { get; set; }
        public object Security { get; set; }
        public object Customfield10007 { get; set; }
        public object Customfield10008 { get; set; }
        public object Customfield10009 { get; set; }
        public long? Aggregatetimeestimate { get; set; }
        public string Summary { get; set; }
        public List<object> Subtasks { get; set; }
        public object Customfield10001 { get; set; }
        public object Customfield10002 { get; set; }
        public object Customfield10003 { get; set; }
        public object Customfield10004 { get; set; }
        public object Environment { get; set; }
        public object Duedate { get; set; }
        public long? Customfield10023 { get; set; }
    }
}
