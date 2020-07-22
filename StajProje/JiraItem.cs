using StajProje;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StajProje
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Issuetype
    {
        public string self { get; set; }
        public string id { get; set; }
        public string description { get; set; }
        public string iconUrl { get; set; }
        public string name { get; set; }
        public bool subtask { get; set; }
        public int avatarId { get; set; }

    }

    public class Project
    {
        public string self { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string projectTypeKey { get; set; }
        public bool simplified { get; set; }

    }

    public class Issuerestrictions
    {

    }

    public class Issuerestriction
    {
        public Issuerestrictions issuerestrictions { get; set; }
        public bool shouldDisplay { get; set; }

    }

    public class Watches
    {
        public string self { get; set; }
        public int watchCount { get; set; }
        public bool isWatching { get; set; }

    }

    public class Priority
    {
        public string self { get; set; }
        public string iconUrl { get; set; }
        public string name { get; set; }
        public string id { get; set; }

    }

    public class NonEditableReason
    {
        public string reason { get; set; }
        public string message { get; set; }

    }

    public class Customfield10018
    {
        public bool hasEpicLinkFieldDependency { get; set; }
        public bool showField { get; set; }
        public NonEditableReason nonEditableReason { get; set; }

    }

    public class StatusCategory
    {
        public string self { get; set; }
        public int id { get; set; }
        public string key { get; set; }
        public string colorName { get; set; }
        public string name { get; set; }

    }

    public class Status
    {
        public string self { get; set; }
        public string description { get; set; }
        public string iconUrl { get; set; }
        public string name { get; set; }
        public string id { get; set; }
        public StatusCategory statusCategory { get; set; }

    }

    public class Content2
    {
        public string type { get; set; }
        public string text { get; set; }

    }

    public class Content
    {
        public string type { get; set; }
        public List<Content2> content { get; set; }

    }

    public class Description
    {
        public int version { get; set; }
        public string type { get; set; }
        public List<Content> content { get; set; }

    }

    public class Timetracking
    {

    }


    public class Creator
    {
        public string self { get; set; }
        public string accountId { get; set; }
        public string emailAddress { get; set; }
        public string displayName { get; set; }
        public bool active { get; set; }
        public string timeZone { get; set; }
        public string accountType { get; set; }

    }


    public class Reporter
    {
        public string self { get; set; }
        public string accountId { get; set; }
        public string emailAddress { get; set; }
        public string displayName { get; set; }
        public bool active { get; set; }
        public string timeZone { get; set; }
        public string accountType { get; set; }

    }

    public class Aggregateprogress
    {
        public int progress { get; set; }
        public int total { get; set; }

    }

    public class Progress
    {
        public int progress { get; set; }
        public int total { get; set; }

    }

    public class Votes
    {
        public string self { get; set; }
        public int votes { get; set; }
        public bool hasVoted { get; set; }

    }

    public class Comment
    {
        public List<object> comments { get; set; }
        public int maxResults { get; set; }
        public int total { get; set; }
        public int startAt { get; set; }

    }

    public class Worklog
    {
        public int startAt { get; set; }
        public int maxResults { get; set; }
        public int total { get; set; }
        public List<object> worklogs { get; set; }

    }

    public class Fields
    {
        public DateTime statuscategorychangedate { get; set; }
        public Issuetype issuetype { get; set; }
        public object timespent { get; set; }
        public Project project { get; set; }
        public List<object> fixVersions { get; set; }
        public object aggregatetimespent { get; set; }
        public object resolution { get; set; }
        public object resolutiondate { get; set; }
        public int workratio { get; set; }
        public DateTime lastViewed { get; set; }
        public Issuerestriction issuerestriction { get; set; }
        public Watches watches { get; set; }
        public DateTime created { get; set; }
        public object customfield_10020 { get; set; }
        public object customfield_10021 { get; set; }
        public object customfield_10022 { get; set; }
        public Priority priority { get; set; }
        public object customfield_10023 { get; set; }
        public object customfield_10024 { get; set; }
        public object customfield_10025 { get; set; }
        public List<object> labels { get; set; }
        public object customfield_10016 { get; set; }
        public object customfield_10017 { get; set; }
        public Customfield10018 customfield_10018 { get; set; }
        public string customfield_10019 { get; set; }
        public object timeestimate { get; set; }
        public object aggregatetimeoriginalestimate { get; set; }
        public List<object> versions { get; set; }
        public List<object> issuelinks { get; set; }
        public object assignee { get; set; }
        public DateTime updated { get; set; }
        public Status status { get; set; }
        public List<object> components { get; set; }
        public object timeoriginalestimate { get; set; }
        public Description description { get; set; }
        public object customfield_10010 { get; set; }
        public object customfield_10014 { get; set; }
        public object customfield_10015 { get; set; }
        public Timetracking timetracking { get; set; }
        public object customfield_10005 { get; set; }
        public object customfield_10006 { get; set; }
        public object security { get; set; }
        public object customfield_10007 { get; set; }
        public object customfield_10008 { get; set; }
        public List<object> attachment { get; set; }
        public object customfield_10009 { get; set; }
        public object aggregatetimeestimate { get; set; }
        public string summary { get; set; }
        public Creator creator { get; set; }
        public List<object> subtasks { get; set; }
        public Reporter reporter { get; set; }
        public Aggregateprogress aggregateprogress { get; set; }
        public string customfield_10000 { get; set; }
        public object customfield_10001 { get; set; }
        public object customfield_10002 { get; set; }
        public object customfield_10003 { get; set; }
        public object customfield_10004 { get; set; }
        public object environment { get; set; }
        public object duedate { get; set; }
        public Progress progress { get; set; }
        public Votes votes { get; set; }
        public Comment comment { get; set; }
        public Worklog worklog { get; set; }

    }

    public class JiraItem
    {
        public string expand { get; set; }
        public string id { get; set; }
        public string self { get; set; }
        public string key { get; set; }
        public Fields fields { get; set; }

    }


}
