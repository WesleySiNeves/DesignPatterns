using AplicacaoControleRemoto.Controles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacaoControleRemoto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnradioControl.Click += BtnradioControl_Click;
            btnTvControl.Click += BtnTvControl_Click;
            btnAdvancedControl.Click += BtnAdvancedControl_Click;
               
        }

        private void BtnAdvancedControl_Click(object sender, EventArgs e)
        {
            AdvancedControl controle = new AdvancedControl();
            controle.Show();
        }

        private void BtnTvControl_Click(object sender, EventArgs e)
        {
            ControleTVForm controleTVForm = new ControleTVForm();
            controleTVForm.Show();

        }

        private void BtnradioControl_Click(object sender, EventArgs e)
        {
            ControleRadioForm controleRadioForm = new ControleRadioForm();
            controleRadioForm.Show();
        }
    }
}
