// See https://aka.ms/new-console-template for more information

Console.WriteLine("Ricardo Pérez ID");
int altura = 168;
int edad = 89;
string nombre = "Ricardo Pérez";
string informacion = "Nació en Hidalgo, es estudiante de gastronomía y astronomía";
var hobby = "deportista";

string tarjetaDeIdentificacion = $"La información de {nombre}\n" +
    $"es la siguiente, \nsu edad son {edad}, \nsu altura es {altura}. \n{informacion}" +
    $"\ny como hobby es {hobby}";

Console.WriteLine(tarjetaDeIdentificacion);