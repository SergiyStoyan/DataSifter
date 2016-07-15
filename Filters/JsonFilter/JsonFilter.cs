//********************************************************************************************
//Author: Sergey Stoyan, CliverSoft.com
//        http://cliversoft.com
//        stoyan@cliversoft.com
//        sergey.stoyan@gmail.com
//        17 February 2008
//Copyright: (C) 2008, Sergey Stoyan
//********************************************************************************************

using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using System.Configuration;
using Cliver.DataSifter;

namespace Cliver
{
    internal class JsonFilter : Filter
    {
        override public Version Version
        {
            get
            {
                return new Version(1, 0);
            }
        }

        public JsonFilter(Version version, string defintion, string input_group_name, string comment)
            : base(version, input_group_name, comment)
        {
            if (defintion == null)
                defintion = get_default_definition();
            if (defintion == null)
                defintion = "\n";
            Match m = Regex.Match(defintion, @"(?'JsonPath'.*)\n(?'GroupName'.*)", RegexOptions.Compiled | RegexOptions.Singleline | RegexOptions.IgnoreCase);
            if (!m.Success)
                throw new Exception("Filter definition could not be parsed:\n" + defintion);
            JsonPath = m.Groups["JsonPath"].Value;
            GroupName = m.Groups["GroupName"].Value;
            InputGroupName = input_group_name;
            fill_group_index2raw_group_names();
        }

        internal string JsonPath;
        internal string GroupName;

        override public string[] GetGroupRawNames()
        {
            if (string.IsNullOrWhiteSpace(GroupName))
                GroupName = "0";
            return new string[] { GroupName };
        }

        override public string GetDefinition()
        {
            if (string.IsNullOrWhiteSpace(GroupName))
                GroupName = "0";
            return JsonPath + "\n" + GroupName;
        }

        override public FilterMatchCollection Matches(FilterGroup group)
        {
            return new JsonMatches(group, JsonPath);
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
        public JsonMatches(FilterGroup parent_group, string json_path)
            : base(parent_group)
        {
            //jt0 = new Newtonsoft.Json.Linq.JObject(parent_group.Text);
            Reset();
        }
        //readonly Newtonsoft.Json.Linq.JToken jt0 = null;
        Newtonsoft.Json.JsonTextReader reader = null;

        //List<string> get_element_list_by_path(string path)
        //{
        //    string[] key_index_pairs = path.Split('/');
        //    List<string> level_es = new List<string>();
        //    level_es.Add(text0);
        //    foreach (string key_index_pair in key_index_pairs)
        //    {
        //        string[] p = key_index_pair.Split(',');
        //        string key = p[0].Trim();
        //        string _index = null;
        //        if (p.Length < 2)
        //            _index = "*";
        //        else
        //            _index = p[1].Trim();
        //        List<string> child_es = new List<string>();
        //        if (_index == "*")
        //        {
        //            foreach (string le in level_es)
        //            {
        //                List<string> es;
        //                dynamic json = Newtonsoft.Json.JsonConvert.DeserializeObject(le);
        //                json[key]
        //                if (!le.child_group_captures.TryGetValue(key, out es))
        //                    throw (new Exception("Key '" + key + "' in the path '" + path + "' was not found."));
        //                child_es.AddRange(es);
        //            }
        //        }
        //        else
        //        {
        //            int index = -1;
        //            if (!int.TryParse(_index, out index))
        //                throw (new Exception("Index '" + _index + "' in the path '" + path + "' is inadmissible. Index might be integer or '*' only."));

        //            foreach (dynamic lgc in level_gcs)
        //            {
        //                List<dynamic> gcs;
        //                if (!lgc.child_group_captures.TryGetValue(key, out gcs))
        //                    throw (new Exception("Key '" + key + "' in the path '" + path + "' was not found."));
        //                if (gcs.Count <= index || index < 0)
        //                    continue;
        //                child_gcs.Add((dynamic)gcs[index]);
        //            }
        //        }
        //        level_gcs = child_gcs;
        //    }

        //    return level_gcs;
        //}

        override public void Reset()
        {
            if (reader != null)
                reader.Close();
            reader = new Newtonsoft.Json.JsonTextReader(new StringReader(ParentGroup.Text.Trim()));
            reset = true;
        }
        bool reset = false;
        
        override public FilterMatch Current
        {
            get
            {
                int position = Regex.Match(ParentGroup.Text, @"(.*?\n){" + reader.LineNumber + "}").Value.Length + reader.LinePosition;
                return new FilterMatch(new List<FilterGroup>() { new FilterGroup(ParentGroup, position, reader.ReadAsString()) });
            }
        }
        
        override public bool MoveNext()
        {
            if (reader == null)
               return false;
            while(reader.Read())
            {
                if (reader.Path == "-")
                    break;
            }
            return reader.Value != null;
        }
    }
}