﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Easy_Web
{
    public struct Property
    {
        public string PropertyName;
        public string PropertyValue;
    };
    public struct TagWithCSS
    {
        public string TagName;
        public List<Property> Properties;
    };
    public class CSSPARSER
    {
        public override string ToString()
        {
            string ToRreturn = string.Empty;
            foreach (TagWithCSS T in TagWithCSSList)
            {
                ToRreturn += T.TagName;
                ToRreturn += "\n{\n";
                foreach (Property p in T.Properties)
                {
                    ToRreturn += "\t" + p.PropertyName + ":" + p.PropertyValue + ";\n";
                }
                ToRreturn += "}\n";

            }
            return ToRreturn;
        }
        List<TagWithCSS> TagWithCSSList;
        List<TagWithCSS> GetTagWithCSS(string input)
        {
            List<TagWithCSS> TagWithCSSList = new List<TagWithCSS>();
            List<string> IndivisualTag = IndivisualTags(input);
            foreach (string tag in IndivisualTag)
            {
                string[] tagname = Regex.Split(tag, @"[{]");
                TagWithCSS TWCSS = new TagWithCSS();
                if (RemoveWhitespace(tagname[0]) != "")
                {
                    TWCSS.TagName = RemoveWitespaceFormStartAndEnd(tagname[0]);
                    TWCSS.Properties = GetProperty(getBetween(tag, "{", "}"));
                    TagWithCSSList.Add(TWCSS);
                }
            }
            return TagWithCSSList;
        }
        string getBetween(string strSource, string strStart, string strEnd)
        {
            int Start, End;
            if (strSource.Contains(strStart) && strSource.Contains(strEnd))
            {
                Start = strSource.IndexOf(strStart, 0) + strStart.Length;
                End = strSource.IndexOf(strEnd, Start);
                return strSource.Substring(Start, End - Start);
            }
            else
            {
                return null;
            }
        }
        List<string> IndivisualTags(string input)
        {
            string pattern = @"(?<selector>(?:(?:[^,{]+),?)*?)\{(?:(?<name>[^}:]+):?(?<value>[^};]+);?)*?\}";

            List<string> b = new List<string>();

            foreach (Match m in Regex.Matches(input, pattern))
                b.Add(m.Value);

            return b;
        }
        List<Property> GetProperty(string input)
        {
            List<Property> p = new List<Property>();
            string[] s = Regex.Split(input, @"[;]");
            int i = 0;
            foreach (string b in s)
            {
                if (b != "")
                {
                    string[] t = Regex.Split(s[i], @"[:]");
                    Property g = new Property();
                    if (t.Length == 2)
                    {
                        if (t[0] != "")
                            g.PropertyName = RemoveWhitespace(t[0]);
                        if (t[1] != "")
                            g.PropertyValue = RemoveWitespaceFormStartAndEnd(t[1]);
                        p.Add(g);
                    }
                }
                i++;
            }
            return p;
        }
        string RemoveWhitespace(string input)
        {
            return new string(input.ToCharArray()
                .Where(c => !Char.IsWhiteSpace(c))
                .ToArray());
        }
        string RemoveWitespaceFormStartAndEnd(string input)
        {
            input = input.Trim();
            input = input.TrimEnd();
            return input;
        }
        public bool RemoveProperty(string Tag, string ProvertyName)
        {
            int pointinTagWithCSSList = 0;
            int pointinProperties = 0;

            foreach (TagWithCSS T in TagWithCSSList)
            {
                if (T.TagName.Equals(Tag, StringComparison.InvariantCultureIgnoreCase))
                {
                    foreach (Property p in T.Properties)
                    {
                        if (p.PropertyName.Equals(ProvertyName, StringComparison.InvariantCultureIgnoreCase))
                        {
                            TagWithCSSList[pointinTagWithCSSList].Properties.RemoveAt(pointinProperties);
                            return true;
                        }
                        pointinProperties++;
                    }

                }
                pointinTagWithCSSList++;
            }
            return false;
        }
        public bool RemoveTag(string Tag)
        {
            int pointinTagWithCSSList = 0;

            foreach (TagWithCSS T in TagWithCSSList)
            {
                if (T.TagName.Equals(Tag, StringComparison.InvariantCultureIgnoreCase))
                {
                    TagWithCSSList.RemoveAt(pointinTagWithCSSList);
                    return true;
                }
                pointinTagWithCSSList++;
            }
            return false;
        }
        public List<Property> GetProperties(string Tag)
        {
            int pointinTagWithCSSList = 0;

            foreach (TagWithCSS T in TagWithCSSList)
            {
                if (T.TagName.Equals(Tag, StringComparison.InvariantCultureIgnoreCase))
                {
                    return T.Properties;
                }
                pointinTagWithCSSList++;
            }
            return new List<Property>();
        }
        public Property GetPropertie(string Tag, string PropertyName)
        {
            int pointinTagWithCSSList = 0;

            foreach (TagWithCSS T in TagWithCSSList)
            {
                if (T.TagName.Equals(Tag, StringComparison.InvariantCultureIgnoreCase))
                {
                    foreach (Property p in T.Properties)
                    {
                        if (p.PropertyName.Equals(PropertyName, StringComparison.InvariantCultureIgnoreCase))
                            return p;
                    }
                }
                pointinTagWithCSSList++;
            }
            return new Property();
        }
        public void SetCSS(string input)
        {
            TagWithCSSList = GetTagWithCSS(input);
        }
        public bool AddPropery(string Tag, string ProvertyName, string PropertValue)
        {
            int pointinTagWithCSSList = 0;
            int pointinProperties = 0;
            bool notfound = false;
            bool added = false;

            bool tagcannotexist = true;
            bool tagExist = false;

            Tag = "." + Tag;

            foreach (TagWithCSS T in TagWithCSSList)
            {
                if (T.TagName.Equals(Tag, StringComparison.InvariantCultureIgnoreCase))
                {
                    foreach (Property p in T.Properties)
                    {
                        if (p.PropertyName.Equals(ProvertyName, StringComparison.InvariantCultureIgnoreCase))
                        {
                            Property np = new Property();
                            np.PropertyName = ProvertyName;
                            np.PropertyValue = PropertValue;
                            TagWithCSSList[pointinTagWithCSSList].Properties[pointinProperties] = np;
                            added = true;
                            return true;//break;
                        }
                        notfound = true;
                        pointinProperties++;
                    }

                    if (notfound && !added)
                    {
                        Property np = new Property();
                        np.PropertyName = ProvertyName;
                        np.PropertyValue = PropertValue;
                        TagWithCSSList[pointinTagWithCSSList].Properties.Add(np);
                        added = true;
                        return true;//break;                 
                    }
                    tagExist = true;
                    tagcannotexist = false;
                }
                else
                {
                    tagExist = false;
                    tagcannotexist = true;
                }
                pointinTagWithCSSList++;
            }
            if (tagcannotexist && !tagExist)
            {
                TagWithCSS t = new TagWithCSS();
                t.TagName = Tag;
                Property p = new Property();
                p.PropertyName = ProvertyName;
                p.PropertyValue = PropertValue;
                List<Property> pl = new List<Property>();
                pl.Add(p);
                t.Properties = pl;
                TagWithCSSList.Add(t);
                return true;//break;
            }
            return false;
        }
        public CSSPARSER(string input)
        {
            SetCSS(input);
        }
        public CSSPARSER()
        {
            TagWithCSSList = new List<TagWithCSS>();
        }
        public bool TagExist(string Tag)
        {
            foreach (TagWithCSS T in TagWithCSSList)
            {
                if (T.TagName.Equals(Tag, StringComparison.InvariantCultureIgnoreCase))
                {
                    return true;
                }

            }
            return false;
        }
    }
}
