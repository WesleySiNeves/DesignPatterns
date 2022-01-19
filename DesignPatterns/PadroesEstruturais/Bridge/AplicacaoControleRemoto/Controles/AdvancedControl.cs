using ImplementacaoControleRemoto.Abstraction;
using ImplementacaoControleRemoto.Concrete;
using ImplementacaoControleRemoto.RefinedAbstraction;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AplicacaoControleRemoto.Controles
{

    public partial class AdvancedControl : Form
    {
        private AdvancedRemoteControl _remoteControl;
        private Tv _tv;
        private readonly object MyLock = new object();


        public Tv DeviceTV
        {
            get
            {
                if (_tv == null)
                {
                    lock (MyLock)
                    {
                        _tv = new Tv();
                    }
                }
                return _tv;
            }
        }


        public AdvancedRemoteControl Control
        {
            get
            {
                if (_remoteControl == null)
                {
                    lock (MyLock)
                    {
                        _remoteControl = new AdvancedRemoteControl(DeviceTV);
                    }
                }
                return _remoteControl;
            }
        }

        public AdvancedControl()
        {
            InitializeComponent();
            inicialize();
        }

        private void inicialize()
        {
            btnAumentarCanal.Click += BtnAumentarCanal_Click;
            btnDiminuirCanal.Click += BtnDiminuirCanal_Click;


            btnAumentarVolume.Click += BtnAumentarVolume_Click;
            btnDiminuirVolume.Click += BtnDiminuirVolume_Click;

            btnCanal1.Click += (o, e) => Control.setChannel(1);
            btnCanal2.Click += (o, e) => Control.setChannel(2);
            btnCanal3.Click += (o, e) => Control.setChannel(3);
            btnCanal4.Click += (o, e) => Control.setChannel(4);
            btnCanal5.Click += (o, e) => Control.setChannel(5);
            btnCanal6.Click += (o, e) => Control.setChannel(6);
            btnCanal7.Click += (o, e) => Control.setChannel(7);
            btnCanal8.Click += (o, e) => Control.setChannel(8);
            btnCanal9.Click += (o, e) => Control.setChannel(9);

            btnOff.Click += BtnOff_Click;


            btnAlexa.Click += (o, e) => Control.startAlexa();
            btnMute.Click += (o, e) => Control.mute();
            btnDisneyPlus.Click += (o, e) => Control.startApp("DisneyPlus");
            btnNetFlix.Click += (o, e) => Control.startApp("netflix");
            btnHbo.Click += (o, e) => Control.startApp("HBO");
            btnAmazon.Click += (o, e) => Control.startApp("Amazon");

        }



        private void BtnDiminuirVolume_Click(object sender, EventArgs e)
        {
            Control.volumeDown();
        }

        private void BtnAumentarVolume_Click(object sender, EventArgs e)
        {
            Control.volumeUp();
        }

        private void BtnDiminuirCanal_Click(object sender, EventArgs e)
        {
            Control.channelDown();
        }


        private void BtnAumentarCanal_Click(object sender, EventArgs e)
        {
            Control.channelUp();
        }

        private void BtnOff_Click(object sender, EventArgs e)
        {
            Control.togglePower();
        }
    }
}
