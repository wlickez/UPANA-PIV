// See https://aka.ms/new-console-template for more information
using resume.models;

Console.WriteLine("Hello, World!");

Loro l = new Loro();

Loro l2 = new Loro();
l2.CalcularEdad(new DateTime(2020, 5, 1));
int edad = l2.DevolverEdad();
l2.Hablar();

l = l2;