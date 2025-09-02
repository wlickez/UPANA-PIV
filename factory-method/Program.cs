using factorymethod.models;
using factorymethod.models.interfaces.Factory;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");


        BebidaEmbriagante bebidaEmbriagante = Creador.CreadorBebida(Creador.VINO_TINTO);
        Console.WriteLine(bebidaEmbriagante.CuantoMeEmbriagaPorHora());

        NotificationFactory factory;

        factory = new EmailFactory();
        var email = factory.CreateNotification();
        email.SendNotification("Hello via Email");

        factory = new SmsFactory();
        var sms = factory.CreateNotification();
        sms.SendNotification("Hello via SMS");

        Console.ReadLine();

    }
}