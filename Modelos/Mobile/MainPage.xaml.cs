
using Modelos;

namespace Mobile
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        IConexionApi _conexionApi;
        public MainPage(IConexionApi conexionApi)
        {
            InitializeComponent();
            _conexionApi = conexionApi;
            var data = _conexionApi.Peticion("Alumnos", 1);
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);

        }
    }

}
