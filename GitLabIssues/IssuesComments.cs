using System;
using System.Collections.Generic;
using System.Text;

namespace GitLabIssues
{ 
    public class CommentAuthor
    {
        public int id { get; set; }
        public string username { get; set; }
        public string name { get; set; }
        public string state { get; set; }
        public string avatar_url { get; set; }
        public string web_url { get; set; }
    }

    public class CommandsChanges
    {
    }

    public class IssuesComments
    {
        public int id { get; set; }
        public object type { get; set; }
        public string body { get; set; }
        public object attachment { get; set; }
        public Author author { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public bool system { get; set; }
        public int noteable_id { get; set; }
        public string noteable_type { get; set; }
        public bool resolvable { get; set; }
        public bool confidential { get; set; }
        public int noteable_iid { get; set; }
        public CommandsChanges commands_changes { get; set; }
    }


}
