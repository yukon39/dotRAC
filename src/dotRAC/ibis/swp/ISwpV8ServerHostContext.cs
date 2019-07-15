﻿/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

using dotRAC.ibis.host;
using dotRAC.swp.codec;

namespace dotRAC.ibis.swp
{
    internal interface ISwpV8ServerHostContext : IV8ServerHostContext
    {
        ServiceWireCodecVersion CodecVersion { get; }
    }
}