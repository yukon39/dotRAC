/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

using System;

namespace DotRAC.SWP.Compression
{
    public class CompressionException : Exception
    {
        public CompressionException() : base() { }

        public CompressionException(string message) : base(message) { }

        public CompressionException(string message, Exception innerException) : base(message, innerException) { }

        public CompressionException(Exception innerException)
            : base(null, innerException)
        {
        }
    }
}
