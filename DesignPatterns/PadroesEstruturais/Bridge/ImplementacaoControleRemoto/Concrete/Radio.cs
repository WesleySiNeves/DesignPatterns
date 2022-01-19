using ImplementacaoControleRemoto.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ImplementacaoControleRemoto.Concrete
{
    // Todos os dispositivos seguem a mesma interface.
    public class Radio : IDevice
    {
        private bool _Enable;
        private decimal Channel;
        private int Volume;

        public bool disable()
        {
            _Enable = false;
            return _Enable;
        }

        public bool enable()
        {
            _Enable = true;
            return _Enable;
        }

        public decimal getChannel()
        {
            return Channel;
        }

        public int getVolume()
        {
            return Volume;
        }

        public bool isEnabled()
        {
            return _Enable;
        }

        public void setChannel(decimal channel)
        {
            Channel = channel;
        }

        public void setVolume(int volume)
        {
            Volume = volume;
        }
    }
}
