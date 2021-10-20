using Conceptual.Builders.Concrect;
using Conceptual.Directors;
using Conceptual.Products.Contract;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace EmailUI
{
    public partial class Form1 : Form, IEmail
    {
        public Form1()
        {
            InitializeComponent();
            btnCarregarAnexo.Click += BtnCarregarAnexo_Click;
            btnCarregarLogo.Click += BtnCarregarLogo_Click;
            btnEnviar.Click += BtnEnviar_Click;
        }


        private void BtnCarregarLogo_Click(object sender, EventArgs e)
        {

        }

        private void BtnCarregarAnexo_Click(object sender, EventArgs e)
        {

        }


        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            
            var builder = new EmailBuilder();
           

            //var email = builder.To(To)
            //    .From(From)
            //    .Subject(Subject)
            //    .Body(Body)
            //    .Build();

            //MessageBox.Show($"TO :{email.To}\n From:{email.From} \n Titulo: {email.Subject} \n Assunto:{email.Body} ");

            var director = new EmailDirector();

            director.SetBuilder(builder);

            if (!string.IsNullOrWhiteSpace(Rodape))
            {
                director.BuildIEmailSemImagemEComRodape(To, From, Subject, Body, Rodape);

            }
            else if (ImagemLogo != null)
            {
                director.BuildIEmailComImagem(To, From, Subject, Body, ImagemLogo);
            }
            else
            {
                director.BuildIEmailSimples(To, From, Subject, Body);
            }


            var email = director.GetEmail().Build();

            MessageBox.Show($"TO :{email.To}\n From:{email.From} \n Titulo: {email.Subject} " +
                $"\n Assunto:{email.Body} \n  Rodape:{email.Rodape} ");




        }

        public string Body
        {
            get { return txtAssunto.Text; }
            set { txtAssunto.Text = value; }
        }
        public string From
        {
            get { return txtFrom.Text; }
            set { txtFrom.Text = value; }
        }
        public string Subject
        {
            get { return txtTitulo.Text; }
            set { txtTitulo.Text = value; }
        }
        public string To
        {
            get { return txtTo.Text; }
            set { txtTo.Text = value; }
        }
        public string Rodape
        {
            get { return txtRodape.Text; }
            set { txtRodape.Text = value; }
        }
        public Image ImagemLogo
        {
            get { return pictureBoxLogo.Image; }
            set { pictureBoxLogo.Image = value; }
        }

    }
}
