using MementoCalc.Carectaker;
using MementoCalc.Interface;
using MementoCalc.Originator;

namespace MementoCalc
{
    public partial class Form1 : Form
    {
        ICalculadora calculadora = new Calculadora();
        private ICarectaker memento;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Executar();
        }

        void Executar()
        {
            
            ICalculadora calculadora  =new Calculadora();


            calculadora.SetPrimeiroNumero(10);

            calculadora.SetSegundoNumero(100);


            var result = calculadora.GetCalculoResultado();

            //Armazena o resultado no memento
            memento = calculadora.CreateMemento();

            //Calcula uma nova soma


            calculadora.SetPrimeiroNumero(17);

            calculadora.SetSegundoNumero(-200);


            var segundoResultado = calculadora.GetCalculoResultado();



            //Operção de Undo
            calculadora.SetMemento(memento);


            var undo = calculadora.GetCalculoResultado();


        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            calculadora.SetPrimeiroNumero(int.Parse(txtNumeroIncial.Text));

            calculadora.SetSegundoNumero(int.Parse(txtNumeroFinal.Text));


            var result = calculadora.GetCalculoResultado();

            lblResultadoAtual.Text = result.ToString("N2");

            //Armazena o resultado no memento
            ICarectaker memento = calculadora.CreateMemento();

        }

        private void btnVerResultadoAnterior_Click(object sender, EventArgs e)
        {

            //Operção de Undo
            calculadora.SetMemento(memento);

            var undo = calculadora.GetCalculoResultado();

            lblResultadoAnterior.Text = undo.ToString("N2");

        }
    }
}