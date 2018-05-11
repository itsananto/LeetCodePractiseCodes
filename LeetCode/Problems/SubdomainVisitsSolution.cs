using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    class SubdomainVisitsSolution
    {
        //accepted
        public IList<string> SubdomainVisits(string[] cpdomains)
        {
            var dictionary = new Dictionary<string, int>();
            foreach (var cpdomain in cpdomains)
            {
                var split = cpdomain.Split(new char[] { ' ' });
                int count = int.Parse(split[0]);

                var domainSplit = split[1].Split(new char[] { '.' });

                string domain = "";
                for (int i = domainSplit.Length-1; i >=0 ; i--)
                {
                    domain = domainSplit[i]+domain;
                    if (dictionary.ContainsKey(domain))
                    {
                        dictionary[domain] += count;
                    }
                    else
                    {
                        dictionary[domain] = count;
                    }
                    domain = "." + domain;
                }
            }

            return dictionary.Select(x => x.Value + " " + x.Key).ToArray();
        }
    }
}
