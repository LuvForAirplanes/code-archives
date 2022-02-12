using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace Kendra_AI_Server.Controllers
{
    public class KendraController : ApiController
    {

        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(string id)
        {
            string output = "";
            List<string> words = new List<string> {"a", "", "aa" };
            
            List<string> nodeArray = new List<string> {"2", "", "3" };
            List<int> processItems = new List<int> { };
            List<int> valueArray = new List<int> { };
            List<int> newProcessItems = new List<int> { };
            List<int> newValueArray = new List<int> { };

            var regExp = @"\w+";
            Match wordMatch = Regex.Match(id, regExp);
            for (int i = 0; i < wordMatch.Groups.Count; i++)
            {
                processItems.Add(words.IndexOf(wordMatch.Value[i].ToString()));
            }

            for (int i = 0; i < wordMatch.Groups.Count; i++)
            {
                valueArray.Add(200);
            }

            List<int> tempOutput = new List<int> { };


            foreach (var loop in processItems)
            {
                int idd = 0;
                string tempNode = nodeArray[idd]; // "1 2 3"
                Match node2 = Regex.Match(tempNode, regExp); //"1", "2", "3"
                List<int> node = new List<int> { };
                for (int i = 0; i < node2.Length; i++)
                {
                    string a = node2.Value[i].ToString();
                    node.Add(Convert.ToInt16(a));
                }

                var value = valueArray[idd] * 2;
                foreach (var doCount in node)
                {
                    value = value /*Math.Floor(value)*/ / 2;
                    if (value > 100)
                    {
                        value = value + 100;
                        if (node[0] == 2 && value > 100)
                        {
                            tempOutput.Add(node[0]);
                        }
                        newProcessItems.Add(doCount);
                        newValueArray.Add(value);
                    }
                }
                processItems = newProcessItems;
                valueArray = newValueArray;
                foreach (var item in tempOutput)
                {
                    output += " " + words[item];
                }
            }
            return output;
        }
    }
}
