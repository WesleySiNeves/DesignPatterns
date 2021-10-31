using Conceptual.Builders.Concrect;
using Conceptual.Directors;
using Conceptual.Products.Contract;
using System;
using System.Drawing;
using System.Security;
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
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Filter = "txt files (*.img)|*.png";
            openFileDialog1.Multiselect = false;
        }


        private void BtnCarregarLogo_Click(object sender, EventArgs e)
        {
         

            DialogResult dr = openFileDialog1.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                String arquivo  = openFileDialog1.FileNames[0];

                try
                {
                    
                    Image Imagem = Image.FromFile(arquivo);
                    pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
                    //para exibir as imagens em tamanho natural 
                    //descomente as linhas abaixo e comente as duas seguintes
                    //pb.Height = loadedImage.Height;
                    //pb.Width = loadedImage.Width;
                    pictureBoxLogo.Height = 400;
                    pictureBoxLogo.Width = 400;
                    //atribui a imagem ao PictureBox - pb
                    pictureBoxLogo.Image = Imagem;
                    //inclui a imagem no containter flowLayoutPanel
                    
                }
                catch (SecurityException ex)
                {
                    // O usuário  não possui permissão para ler arquivos
                    MessageBox.Show("Erro de segurança Contate o administrador de segurança da rede.\n\n" +
                                                "Mensagem : " + ex.Message + "\n\n" +
                                                "Detalhes (enviar ao suporte):\n\n" + ex.StackTrace);
                }

               
            }
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
                director.BuildIEmailSemImagemEComRodape(Para, De, Assunto, Conteudo, Rodape);

            }
            if (ImagemLogo != null)
            {
                director.BuildIEmailComImagem(Para, De, Assunto, Conteudo, ImagemLogo);
            }
            else
            {
                director.BuildIEmailSimples(Para, De, Assunto, Conteudo);
            }


            var email = director.GetEmail().Build();

            MessageBox.Show($"TO :{email.Para}\n From:{email.De} \n Titulo: {email.Assunto} " +
                $"\n Assunto:{email.Conteudo} \n  Rodape:{email.Rodape} ");




        }

        public string Conteudo
        {
            get { return txtAssunto.Text; }
            set { txtAssunto.Text = value; }
        }
        public string De
        {
            get { return txtFrom.Text; }
            set { txtFrom.Text = value; }
        }
        public string Assunto
        {
            get { return txtTitulo.Text; }
            set { txtTitulo.Text = value; }
        }
        public string Para
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
