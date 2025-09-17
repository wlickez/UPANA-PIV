using Detectores.Api.Models;

namespace Detectores.Mobile
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        public MainPage(LoginRequest login)
        {
            InitializeComponent();
            if (login != null)
            {
                this.BindingContext = login;
            }
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

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.Title = e.NewTextValue;
        }
    }

}
