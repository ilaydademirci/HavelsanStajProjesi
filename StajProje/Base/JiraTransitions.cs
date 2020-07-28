using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StajProje
{   //TSI-2 JIRA TRANSITIONS
    public class To
    {
        public string Self { get; set; }
        public string Description { get; set; }
        public string IconUrl { get; set; }
        public string Name { get; set; }
        public string Id { get; set; }
        public StatusCategory StatusCategory { get; set; }

    }

    public class Transition
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public To To { get; set; }
        public bool HasScreen { get; set; }
        public bool IsGlobal { get; set; }
        public bool IsInitial { get; set; }
        public bool IsAvailable { get; set; }
        public bool IsConditional { get; set; }

    }

    public class JiraTransition
    {
        public string Expand { get; set; }
        public List<Transition> Transitions { get; set; }

    }
    //TSI-3 JIRA TRANSITIONS
    public class StatusCategory
    {
        public string Self { get; set; }
        public int Id { get; set; }
        public string Key { get; set; }
        public string ColorName { get; set; }
        public string Name { get; set; }

    }

    public class To2
    {
        public string Self { get; set; }
        public string Description { get; set; }
        public string IconUrl { get; set; }
        public string Name { get; set; }
        public string Id { get; set; }
        public StatusCategory StatusCategory { get; set; }

    }

    public class Transition2
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public To To { get; set; }
        public bool HasScreen { get; set; }
        public bool IsGlobal { get; set; }
        public bool IsInitial { get; set; }
        public bool IsAvailable { get; set; }
        public bool IsConditional { get; set; }

    }

    public class JiraTransition2
    {
        public string Expand { get; set; }
        public List<Transition2> Transitions { get; set; }

    }




}
