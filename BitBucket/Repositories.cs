using System;
using System.Collections.Generic;
using System.Text;

namespace BitBucket
{
    public class Watchers
    {
        public string href { get; set; }
    }

    public class Branches
    {
        public string href { get; set; }
    }

    public class Tags
    {
        public string href { get; set; }
    }

    public class Commits
    {
        public string href { get; set; }
    }

    public class Clone
    {
        public string href { get; set; }
        public string name { get; set; }
    }

    public class SSelf
    {
        public string href { get; set; }
    }

    public class Source
    {
        public string href { get; set; }
    }

    public class HHtml
    {
        public string href { get; set; }
    }

    public class AAvatar
    {
        public string href { get; set; }
    }

    public class HHooks
    {
        public string href { get; set; }
    }

    public class Forks
    {
        public string href { get; set; }
    }

    public class Downloads
    {
        public string href { get; set; }
    }

    public class Pullrequests
    {
        public string href { get; set; }
    }

    public class LLinks
    {
        public Watchers watchers { get; set; }
        public Branches branches { get; set; }
        public Tags tags { get; set; }
        public Commits commits { get; set; }
        public List<Clone> clone { get; set; }
        public Self self { get; set; }
        public Source source { get; set; }
        public Html html { get; set; }
        public Avatar avatar { get; set; }
        public Hooks hooks { get; set; }
        public Forks forks { get; set; }
        public Downloads downloads { get; set; }
        public Pullrequests pullrequests { get; set; }
    }

    public class Owner
    {
        public string display_name { get; set; }
        public string uuid { get; set; }
        public Links links { get; set; }
        public string type { get; set; }
        public string nickname { get; set; }
        public string account_id { get; set; }
    }

    public class OverrideSettings
    {
        public bool branching_model { get; set; }
        public bool default_merge_strategy { get; set; }
        public bool branch_restrictions { get; set; }
    }

    public class Project
    {
        public Links links { get; set; }
        public string type { get; set; }
        public string name { get; set; }
        public string key { get; set; }
        public string uuid { get; set; }
    }

    public class Mainbranch
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Workspace
    {
        public string slug { get; set; }
        public string type { get; set; }
        public string name { get; set; }
        public Links links { get; set; }
        public string uuid { get; set; }
    }

    public class Value
    {
        public string scm { get; set; }
        public bool has_wiki { get; set; }
        public Links links { get; set; }
        public DateTime created_on { get; set; }
        public string full_name { get; set; }
        public Owner owner { get; set; }
        public int size { get; set; }
        public string uuid { get; set; }
        public string type { get; set; }
        public object website { get; set; }
        public OverrideSettings override_settings { get; set; }
        public string description { get; set; }
        public bool has_issues { get; set; }
        public string slug { get; set; }
        public bool is_private { get; set; }
        public string name { get; set; }
        public string language { get; set; }
        public string fork_policy { get; set; }
        public Project project { get; set; }
        public Mainbranch mainbranch { get; set; }
        public Workspace workspace { get; set; }
        public DateTime updated_on { get; set; }
    }

    public class Repositories
    {
        public int pagelen { get; set; }
        public List<Value> values { get; set; }
        public int page { get; set; }
        public int size { get; set; }
    }


}
