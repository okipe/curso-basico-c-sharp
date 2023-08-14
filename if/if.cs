// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int totalJugador = 0;
int totalDealer = 15;
string message = string.Empty;
Random rand = new Random();
totalJugador = rand.Next(1, 25);

// Blackjack, juntar 21 pidiendo cartas o en caso de tener menos de 21 igual tener mayor puntuación que el dealer

if (totalJugador > totalDealer && totalJugador < 22)
{
    message = $"Venciste al dealer. Felicidades.\nPuntaje jugador: {totalJugador}";
}
else if (totalJugador >= totalDealer)
{
    message = $"Perdiste contra el dealer, te pasaste de 21.\nPuntaje jugador: {totalJugador}";
} 
else if (totalJugador <= totalDealer)
{
    message = $"Perdiste contra el dealer. Lo sentimos.\nPuntaje jugador: {totalJugador}";
}
else
{
    message = $"condición no válida.\nPuntaje jugador: {totalJugador}";
}

Console.WriteLine(message);