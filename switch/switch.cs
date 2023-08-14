// See https://aka.ms/new-console-template for more information

int totalJugador = 0;
int totalDealer = 15;
string message = string.Empty;
Random rand = new Random();
totalJugador = rand.Next(1, 30);
string switchControl = "menu";

// Blackjack, juntar 21 pidiendo cartas o en caso de tener menos de 21 igual tener mayor puntuación que el dealer

Console.WriteLine("** Bienvenido al CASINO **");
Console.WriteLine("Escriba '21' para jugar al 21");
Console.WriteLine("Escriba '24' para jugar al 24");
Console.WriteLine("Escriba '27' para jugar al 27");
Console.Write("Su elección: ");
switchControl = Console.ReadLine();

switch (switchControl)
{
    case "21":
        if (totalJugador > totalDealer && totalJugador <= 21)
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
        break;

    case "24":
        if (totalJugador > totalDealer && totalJugador <= 24)
        {
            message = $"Venciste al dealer. Felicidades.\nPuntaje jugador: {totalJugador}";
        }
        else if (totalJugador >= totalDealer)
        {
            message = $"Perdiste contra el dealer, te pasaste de 24.\nPuntaje jugador: {totalJugador}";
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
        break;

    case "27":
        if (totalJugador > totalDealer && totalJugador <= 27)
        {
            message = $"Venciste al dealer. Felicidades.\nPuntaje jugador: {totalJugador}";
        }
        else if (totalJugador >= totalDealer)
        {
            message = $"Perdiste contra el dealer, te pasaste de 27.\nPuntaje jugador: {totalJugador}";
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
        break;

    default:
        Console.WriteLine("Opción incorrecta en el CASINO.");
        break;
}

