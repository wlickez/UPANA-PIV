using System.Text;

namespace AsyncVsParallel
{
    public partial class Form1 : Form
    {
        private int _conteo;
        private StringBuilder _texto = new();

        public Form1()
        {
            InitializeComponent();           
        }

        private void Conteo(int conteo)
        {
           
            label1.Text = $"Elementos operados: {conteo}";
        }

        private void AgregarTexto (string texto)
        {
            _texto.AppendLine(texto);
            textBox1.Text = _texto.ToString();
        }       

        private async void StartButton_ClickAsync(object sender, EventArgs e)
        {
            Metodos m = new();
            await m.OperacionAsync(new Progress<int>(Conteo), new Progress<string>(AgregarTexto), new Progress<Task>((x) => x.Start()));

        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }
    }
}
