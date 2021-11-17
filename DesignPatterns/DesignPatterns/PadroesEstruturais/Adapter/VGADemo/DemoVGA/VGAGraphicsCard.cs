using System;
using System.Collections.Generic;
using System.Text;

namespace DemoVGA
{
    public class VGAGraphicsCard
    {

        public VGAStream GetVGAStream()
        {
            VGAStream gAStream = new VGAStream();

            gAStream.SetData(new byte[] { });

            return gAStream;


        }
    }
}
