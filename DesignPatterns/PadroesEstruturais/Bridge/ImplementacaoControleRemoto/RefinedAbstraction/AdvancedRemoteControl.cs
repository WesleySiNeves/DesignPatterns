using ImplementacaoControleRemoto.Abstraction;
using ImplementacaoControleRemoto.Interface;
using ImplementacaoControleRemoto.RefinedAbstraction.Advanced.Interface;
using System;
using System.Collections.Generic;
using System.Speech.Synthesis;
using System.Text;

namespace ImplementacaoControleRemoto.RefinedAbstraction
{
    // Você pode estender classes a partir dessa hierarquia de
    // abstração independentemente das classes de dispositivo.
    public class AdvancedRemoteControl : RemoteControl ,IAdvancedControl
    {
        SpeechSynthesizer speechSynthesizerObj;


        public AdvancedRemoteControl(IDevice _device) 
            //: base(_device)
        {
            Implementor = _device;

            speechSynthesizerObj = new SpeechSynthesizer();

        }

        public void mute()
        {
            device.setVolume(0);
        }


        public void startAlexa()
        {
            speechSynthesizerObj.SpeakAsync("Essa é uma apresentação sobre padrão de projeto!");
        }
        public void startApp(string app)
        {
            if (app =="netflix")
            {

            }

            if (app =="HBO")
            {

            }
            if (app == "Amazon")
            {

            }
            if (app == "DisneyPlus")
            {

            }
        }

       
    }
}
