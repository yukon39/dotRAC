/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotRAC.core.security
{
    public class SaslProperties
    {
        public readonly string ServerName;

        public string[] Mechanisms
        {
            get
            {
                string[] result = new string[mechanisms.Count];

                int index = 0;
                foreach(string key in mechanisms.Keys)
                {
                    result[index++] = key;
                }

                return result;
            }
        }

        public Attributes GetAttributes(string name) => mechanisms.First(x => x.Key == name).Value;

        private readonly Dictionary<string, Attributes> mechanisms;
               
        public SaslProperties(string serverName)
        {
            ServerName = serverName;
            mechanisms = new Dictionary<string, Attributes>();
        }
    }
}
