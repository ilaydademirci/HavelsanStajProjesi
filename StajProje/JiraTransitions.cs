using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StajProje
{   
    public class To
    {
        public string self { get; set; }
        public string description { get; set; }
        public string iconUrl { get; set; }
        public string name { get; set; }
        public string id { get; set; }
        public StatusCategory statusCategory { get; set; }

    }

    public class Transition
    {
        public string id { get; set; }
        public string name { get; set; }
        public To to { get; set; }
        public bool hasScreen { get; set; }
        public bool isGlobal { get; set; }
        public bool isInitial { get; set; }
        public bool isAvailable { get; set; }
        public bool isConditional { get; set; }

    }

    public class JiraTransition
    {
        public string expand { get; set; }
        public List<Transition> transitions { get; set; }

    }


}
