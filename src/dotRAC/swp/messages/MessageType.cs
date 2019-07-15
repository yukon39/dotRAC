/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

namespace dotRAC.swp.messages
{
    public enum MessageType
    {
        NEGOTIATE = 0,
        CONNECT = 1,
        CONNECT_ACK = 2,
        START_TLS = 3,
        DISCONNECT = 4,
        SASL_NEGOTIATE = 5,
        SASL_AUTH = 6,
        SASL_CHALLENGE = 7,
        SASL_SUCCESS = 8,
        SASL_FAILURE = 9,
        SASL_ABORT = 10,
        ENDPOINT_OPEN = 11,
        ENDPOINT_OPEN_ACK = 12,
        ENDPOINT_CLOSE = 13,
        ENDPOINT_MESSAGE = 14,
        ENDPOINT_FAILURE = 15,
        KEEP_ALIVE = 16
    }
}
