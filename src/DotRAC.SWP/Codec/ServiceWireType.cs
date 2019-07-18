/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

namespace DotRAC.SWP.Codec
{
    public enum ServiceWireType
    {
        BOOLEAN = 1,
        BYTE = 2,
        SHORT = 3,
        INT = 4,
        LONG = 5,
        FLOAT = 6,
        DOUBLE = 7,
        SIZE = 8,
        NULLABLE_SIZE = 9,
        STRING = 10,
        UUID = 11,
        TYPE = 12,
        ENDPOINT_ID = 13
    }
}
