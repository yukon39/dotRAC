/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

namespace dotRAC.ibis.swp
{
    public static class ProtocolConstants
    {
        public const string NAME = "swp";
        public const short VERSION_1_0 = 256;
        public const int MAGIC = 475223888;
        public const int DEFAULT_CONNECT_TIMEOUT = 2000;
        public const int MESSAGE_ENCODED = 1;
        public const string PROTOCOL_PARAMETERS_PREFIX = "nipple.swp.protocol.";
        public const string CONNECTION_PARAMETERS_PREFIX = "nipple.swp.connection.";
        public const string SASL_METHODS = "sasl.methods";
        public const string SECURE_REQUIRED = "secure.required";
        public const string KEEP_ALIVE_TIMEOUT = "keep_alive.timeout";
        public const string CONNECT_TIMEOUT = "connect.timeout";
        public const string ENDPOINT_TIMEOUT = "endpoint.timeout";
        public const string ENDPOINT_ENCODING = "endpoint.encoding";
        public const string SERVER_NAME = "server.name";
        public const string SERVER_PORT = "server.port";
        public const string SASL_USERNAME = "sasl.username";
        public const string SASL_PASSWORD = "sasl.password";

        public static string GetProtocolParameterName(string parameterName) => PROTOCOL_PARAMETERS_PREFIX + parameterName;
        public static string GetConnectionParameterName(string parameterName) => PROTOCOL_PARAMETERS_PREFIX + parameterName;
    }
}
