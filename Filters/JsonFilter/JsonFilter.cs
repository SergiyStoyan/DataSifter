//********************************************************************************************
//Author: Sergey Stoyan, CliverSoft.com
//        http://cliversoft.com
//        stoyan@cliversoft.com
//        sergey.stoyan@gmail.com
//        17 February 2008
//Copyright: (C) 2008, Sergey Stoyan
//********************************************************************************************

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using Cliver.DataSifter;

namespace Cliver
{
    internal class JsonFilter : Filter
    {
        override protected Version get_version()
        {
            return new Version(1, 1);
        }

        override protected string get_description()
        {
            return @"Based on Newtonsoft.Json.9.0.1 library.
Json paths must comply with the following format:

property{or}array[index]<. ...property{or}array[index]...>

where any substring of the path can be replaced by '*'. 
PATH EXAMPLES:
Countries.USA.Users[0].Phones[0]
*.Users[*].Phones
*hones*";
        }

        override internal string HelpUrl
        {
            get
            {
                return "";
            }
        }

        public JsonFilter(Version version, string serialized_filter, string input_group_name, string comment)
            : base(version, input_group_name, comment)
        {
            if (serialized_filter == null)
                serialized_filter = get_default_serialized_filter();
            if (serialized_filter == null)
                serialized_filter = "\n";
            Match m = Regex.Match(serialized_filter, @"(?'JsonPath'.*?)\n(?'GroupName'.*?)(?:\n(?'TrimQuotation'.*))?$", RegexOptions.Compiled | RegexOptions.Singleline | RegexOptions.IgnoreCase);
            if (!m.Success)
                throw new Exception("Filter definition could not be parsed:\n" + serialized_filter);
            JsonPath = m.Groups["JsonPath"].Value;
            GroupName = m.Groups["GroupName"].Value;
            if (!string.IsNullOrEmpty(m.Groups["TrimQuotation"].Value))
                TrimQuotation = bool.Parse(m.Groups["TrimQuotation"].Value);
            InputGroupName = input_group_name;
            fill_group_index2raw_group_names();
        }

        internal string JsonPath;
        internal string GroupName;
        internal bool TrimQuotation = false;

        override public string[] GetGroupRawNames()
        {
            if (string.IsNullOrWhiteSpace(GroupName))
                GroupName = "0";
            return new string[] { GroupName };
        }

        override public string GetSerializedFilter()
        {
            if (string.IsNullOrWhiteSpace(GroupName))
                GroupName = "0";
            return JsonPath + "\n" + GroupName + "\n" + TrimQuotation;
        }

        override public FilterMatchCollection Matches(FilterGroup group)
        {
            return new JsonMatches(group, JsonPath, TrimQuotation);
        }

        override internal FilterControl CreateControl()
        {
            JsonControl c = new JsonControl(this);
            return c;
        }

        //internal override bool IsEqual(Filter filter)
        //{
        //    if (filter == null)
        //        return false;
        //    RegexFilter node = filter as RegexFilter;
        //    if (node == null)
        //        return false;
        //    if (InputGroupName == node.InputGroupName
        //        && Regex.ToString() == node.Regex.ToString()
        //        && Regex.Options == node.Regex.Options
        //        )
        //        return true;
        //    return false;
        //}  

        override internal string ReadableTypeName
        {
            get
            {
                return "Json Path";
            }
        }

        public override string GetVisibleDefinition()
        {
            return JsonPath;
        }
    }

    public class JsonMatches : FilterMatchCollection
    {
        public JsonMatches(FilterGroup parent_group, string json_path, bool trim_quotation)
            : base(parent_group)
        {
            json_path = Regex.Replace(json_path, @"\s+", "");
            //json_path = Regex.Escape(json_path);
            json_path = Regex.Replace(json_path, @"\.", @"\.");
            //json_path = Regex.Replace(json_path, @"\[\*\]", @"[\d+]");
            json_path = Regex.Replace(json_path, @"\[", @"\[");
            json_path = Regex.Replace(json_path, @"\]", @"\]");
            json_path = Regex.Replace(json_path, @"\*", @".*?");
            json_path = @"^" + json_path + @"$";
            json_path_regex = new Regex(json_path, RegexOptions.IgnoreCase);
            //jt0 = new Newtonsoft.Json.Linq.JObject(parent_group.Text);
            Reset();

            this.trim_quotation = trim_quotation;
        }
        readonly Regex json_path_regex = null;
        readonly bool trim_quotation;
        Newtonsoft.Json.JsonTextReader reader = null;

        override public void Reset()
        {
            if (reader != null)
                reader.Close();
            reader = new Newtonsoft.Json.JsonTextReader(new StringReader(ParentGroup.Text.Trim()));
            current_start = -1;
            current_end = -1;
        }

        override public FilterMatch Current
        {
            get
            {
                return new FilterMatch(new List<FilterGroup>() { new FilterGroup(ParentGroup, current_start, ParentGroup.Text.Substring(current_start, current_end - current_start)) });
            }
        }

        override public bool MoveNext()
        {
            if (reader == null)
                return false;

            do
            {
                if (!reader.Read())
                    return false;
            }
            while (!json_path_regex.IsMatch(reader.Path));
            
            current_start = Regex.Match(ParentGroup.Text, @"(.*?\n){" + (reader.LineNumber - 1) + "}").Value.Length + reader.LinePosition - 1;
            if (reader.TokenType == Newtonsoft.Json.JsonToken.PropertyName)
                current_start = Regex.Match(ParentGroup.Text, @".{" + current_start + @"}\s*\:\s*", RegexOptions.Singleline).Length;

            reader.Skip();

            current_end = Regex.Match(ParentGroup.Text, @"(.*?\n){" + (reader.LineNumber - 1) + "}").Value.Length + reader.LinePosition;

            if (trim_quotation)
            {
                if (ParentGroup.Text[current_start] == '"' && ParentGroup.Text[current_end - 1] == '"' && current_start - 1 < current_end)
                {
                    current_start += 1;
                    current_end -= 1;
                }
            }

            return true;
        }

        int current_start = -1;
        int current_end = -1;
    }
}