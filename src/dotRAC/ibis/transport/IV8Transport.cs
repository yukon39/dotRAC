/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

namespace dotRAC.ibis.transport
{
    public interface IV8Transport
    {
        string Name { get; }
        string Version { get; }

        IV8Message SendMessage(IV8Message paramIV8Message);
        void SendOneWayMessage(IV8Message paramIV8Message);
    }
}
