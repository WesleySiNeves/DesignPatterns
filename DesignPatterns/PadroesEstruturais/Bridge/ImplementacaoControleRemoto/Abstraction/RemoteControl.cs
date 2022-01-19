using ImplementacaoControleRemoto.Interface;
using System;

namespace ImplementacaoControleRemoto.Abstraction
{

    // A "abstração" define a interface para a parte "controle" das
    // duas hierarquias de classe. Ela mantém uma referência a um
    // objeto da hierarquia de "implementação" e delega todo o
    // trabalho real para esse objeto.
    public class RemoteControl
    {
        /// <summary>
        /// Implementor
        /// </summary>
        protected IDevice device;

        public RemoteControl()
        {
        }

        public IDevice Implementor
        {
            set { device = value; }
        }

        public void togglePower()
        {
            if (device.isEnabled())
            {
                device.disable();
            }
            else
                device.enable();

        }

        public void volumeDown()
        {
            device.setVolume(device.getVolume() - 10);
        }

        public void volumeUp()
        {
            device.setVolume(device.getVolume() + 10);
        }

        public void channelDown()
        {
            device.setChannel(device.getChannel() - 1);
        }

        public void channelUp()
        {
            device.setChannel(device.getChannel() + 1);
        }

        public void setVolume(int volume)
        {
            device.setVolume(volume);
        }

        public void setChannel(decimal channel)
        {
            device.setChannel(channel);
        }
    }
}
