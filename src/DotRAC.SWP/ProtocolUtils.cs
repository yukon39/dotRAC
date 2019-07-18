/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

using System.Collections.Generic;
using System.Collections.Specialized;
using DotRAC.SWP.Codec;

namespace DotRAC.SWP
{
    public static class ProtocolUtils
    {
        public static string VersionToString(short version)
        {
            byte minor = (byte)version;
            byte major = (byte)(version >> 8);
            return string.Format("{0}.{1}", major, minor);
        }

        public static string GetConnectionParameterName(string propertyName)
        {
            if (propertyName.StartsWith(ProtocolConstants.PROTOCOL_PARAMETERS_PREFIX))
            {
                return propertyName.Substring(ProtocolConstants.PROTOCOL_PARAMETERS_PREFIX.Length);
            }

            return default;
        }

        public static Dictionary<string, object> GetConnectionParameters(NameValueCollection properties)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            foreach (KeyValuePair<string, object> keyValue in properties)
            {
                //if (!(key instanceof String)) 
                //{
                //    continue;
                //}

                string name = GetConnectionParameterName(keyValue.Key);
                if (name != null)
                {
                    object value = keyValue.Value;
                    if (value != null)
                    {
                        ServiceWireType type = CodecUtils.DetectType(value.GetType());
                        if (type != null)
                        {
                            parameters.Add(name, value);
                        }
                    }
                }
            }
            return parameters;
        }
    }
}
