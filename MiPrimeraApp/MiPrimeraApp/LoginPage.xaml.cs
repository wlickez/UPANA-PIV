using MiPrimeraApp.Models;

namespace MiPrimeraApp;

public partial class LoginPage : ContentPage
{
    Usuario user = new();
    public LoginPage()
    {
        InitializeComponent();
        this.BindingContext = user;
    }

    private async void EntrarButton_Clicked(object sender, EventArgs e)
    {
        MensajeLabel.Text = "";

        if (user.IsValid())
        {
            await Navigation.PushAsync(new MainPage());
            return;
        }

        else
        {
            MensajeLabel.Text = "Usuario o contraseña incorrectos";
        }

    }


}