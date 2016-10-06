using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Web
{
    class cssfunctions
    {
        stringfun sf = new stringfun();

        public string applyclass(string tag, string classN)
        {
            string tagtext = sf.getBetween(tag, "<", ">");
            tagtext = tagtext.ToLower();
            if (tagtext.Contains("class"))
            {
                string cname = sf.getBetween(tagtext, "class=\"", "\"");
                cname += " " + classN;
                tag = tag.Replace("class=\"" + sf.getBetween(tagtext, "class=\"", "\"") + "\"", "class=\"" + cname + "\"");
            }
            else
            {
                tag = "<" + tagtext + " class=\"" + classN + "\">";
            }
            return tag;
        }


    }
}
