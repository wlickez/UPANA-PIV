using Detectores.Api.Models;

namespace Detectores.Mobile;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    private async void IngresarButton_Clicked(object sender, EventArgs e)
    {
        MensajeLabel.IsVisible = false;
        if (string.IsNullOrWhiteSpace(UserEntry.Text) || string.IsNullOrWhiteSpace(PasswordEntry.Text))
        {
            MensajeLabel.Text = "Debe ingresar usuario y contraseña.";
            MensajeLabel.IsVisible = true;
            return;
        }

        LoginRequest login = new() { Password = PasswordEntry.Text, User = UserEntry.Text };

        if (login.IsValid())
            await Navigation.PushAsync(new MainPage(login));

        else
        {
            MensajeLabel.Text = "Debe ingresar usuario y contraseña.";
            MensajeLabel.IsVisible = true;
        }
    }

    private async Task<string> Login(LoginRequest login)
    {
        try
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Post, "https://10.0.2.2:7211/api/Login");
            var content = new StringContent(System.Text.Json.JsonSerializer.Serialize(login), null, "application/json");
            request.Content = content;
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsStringAsync();
        }
        catch (Exception ex)
        {

            return null;
        }
    }




}