using System;
using System.Collections.Generic;
using System.Text;

namespace BitBucket
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Hooks
    {
        public string href { get; set; }
    }

    public class Self
    {
        public string href { get; set; }
    }


    public class Html
    {
        public string href { get; set; }
    }

    public class Avatar
    {
        public string href { get; set; }
    }

    public class Snippets
    {
        public string href { get; set; }
    }

    public class Links
    {
        public Hooks hooks { get; set; }
        public Self self { get; set; }
        public Repositories repositories { get; set; }
        public Html html { get; set; }
        public Avatar avatar { get; set; }
        public Snippets snippets { get; set; }
    }

    public class UserID
    {
        public string username { get; set; }
        public object has_2fa_enabled { get; set; }
        public string display_name { get; set; }
        public string account_id { get; set; }
        public Links links { get; set; }
        public string nickname { get; set; }
        public DateTime created_on { get; set; }
        public bool is_staff { get; set; }
        public object location { get; set; }
        public string account_status { get; set; }
        public string type { get; set; }
        public string uuid { get; set; }
    }

}
