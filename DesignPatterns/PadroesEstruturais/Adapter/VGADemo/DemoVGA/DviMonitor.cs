using System;
using System.Collections.Generic;
using System.Text;

namespace DemoVGA
{
    public class DviMonitor
    {
        private byte[] _inputStream;

        public void SetInput(DviStream dviStream)
        {
            _inputStream = dviStream.GetData();
        }
    }
}
