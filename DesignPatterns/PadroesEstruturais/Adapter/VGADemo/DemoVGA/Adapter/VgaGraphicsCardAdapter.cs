using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DemoVGA.Adapter
{
    public class VgaGraphicsCardAdapter
    {
        private VGAGraphicsCard _vGAGraphicsCard;

        public VgaGraphicsCardAdapter(VGAGraphicsCard vGAGraphics)
        {
            _vGAGraphicsCard = vGAGraphics;

        }
        public DviStream GetDviStream()
        {
            byte[] data = _vGAGraphicsCard.GetVGAStream().GetData();

            byte[] dviVideo = ConvertFromVGAToDVi(data);


            var retorno = new DviStream();
            retorno.SetData(dviVideo);

            return retorno;
        }

        private byte[] ConvertFromVGAToDVi(byte[] data)
        {


            byte[] myByteArray = new byte[data.Length];

            using (MemoryStream stream = new MemoryStream())
            {
                stream.Write(myByteArray, 0, myByteArray.Length);
            }
            Console.WriteLine("Convertendo Video VGA para VDI ");

            return myByteArray;
        }
    }
}
