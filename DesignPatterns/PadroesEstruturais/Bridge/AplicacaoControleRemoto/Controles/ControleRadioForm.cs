using ImplementacaoControleRemoto.Abstraction;
using ImplementacaoControleRemoto.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AplicacaoControleRemoto.Controles
{
    public partial class ControleRadioForm : Form
    {
        private Radio _radio;
        private RemoteControl _remoteControl;
        private readonly object MyLock = new object();
        public Radio DeviceRadio
        {
            get
            {
                if (_radio == null)
                {
                    lock (MyLock)
                    {
                        _radio = new Radio();
                    }
                }
                return _radio;
            }
        }

        public RemoteControl Control
        {
            get
            {
                if (_remoteControl == null)
                {
                    lock (MyLock)
                    {
                        _remoteControl = new RemoteControl();
                        _remoteControl.Implementor = DeviceRadio;
                    }
                }
                return _remoteControl;
            }
        }

        public ControleRadioForm()
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
        }

         private void BtnDiminuirVolume_Click(object sender, EventArgs e)
        {
            Control.volumeDown();
        }

        private void BtnAumentarVolume_Click(object sender, EventArgs e)
        {
            Control.volumeDown();
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
