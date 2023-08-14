// See https://aka.ms/new-console-template for more information

int totalJugador = 0;
int totalDealer = 15;
string message = string.Empty;
Random rand = new Random();

string switchControl = "menu";

// Blackjack, juntar 21 pidiendo cartas o en caso de tener menos de 21 igual tener mayor puntuación que el dealer


while (true) {
    switch (switchControl)
    {
        case "menu":
            Console.WriteLine("** Bienvenido al CASINO **");
            Console.WriteLine("Escriba '21' para jugar al 21");
            Console.WriteLine("Escriba '24' para jugar al 24");
            Console.WriteLine("Escriba '27' para jugar al 27");
            Console.Write("Su elección: ");
            switchControl = Console.ReadLine();
            break;

        case "21":
            totalJugador = rand.Next(1, 30);
            if (totalJugador > totalDealer && totalJugador <= 21)
            {
                message = $"Venciste al dealer. Felicidades.\nPuntaje jugador: {totalJugador}";
                switchControl = "menu";
            }
            else if (totalJugador >= totalDealer)
            {
                message = $"Perdiste contra el dealer, te pasaste de 21.\nPuntaje jugador: {totalJugador}";
                switchControl = "menu";
            }
            else if (totalJugador <= totalDealer)
            {
                message = $"Perdiste contra el dealer. Lo sentimos.\nPuntaje jugador: {totalJugador}";
                switchControl = "menu";
            }
            else
            {
                message = $"condición no válida.\nPuntaje jugador: {totalJugador}";
                switchControl = "menu";
            }
            Console.WriteLine(message);
            break;

        case "24":
            totalJugador = rand.Next(1, 30);
            if (totalJugador > totalDealer && totalJugador <= 24)
            {
                message = $"Venciste al dealer. Felicidades.\nPuntaje jugador: {totalJugador}";
                switchControl = "menu";
            }
            else if (totalJugador >= totalDealer)
            {
                message = $"Perdiste contra el dealer, te pasaste de 24.\nPuntaje jugador: {totalJugador}";
                switchControl = "menu";
            }
            else if (totalJugador <= totalDealer)
            {
                message = $"Perdiste contra el dealer. Lo sentimos.\nPuntaje jugador: {totalJugador}";
                switchControl = "menu";
            }
            else
            {
                message = $"condición no válida.\nPuntaje jugador: {totalJugador}";
                switchControl = "menu";
            }
            Console.WriteLine(message);
            break;

        case "27":
            totalJugador = rand.Next(1, 30);
            if (totalJugador > totalDealer && totalJugador <= 27)
            {
                message = $"Venciste al dealer. Felicidades.\nPuntaje jugador: {totalJugador}";
                switchControl = "menu";
            }
            else if (totalJugador >= totalDealer)
            {
                message = $"Perdiste contra el dealer, te pasaste de 27.\nPuntaje jugador: {totalJugador}";
                switchControl = "menu";
            }
            else if (totalJugador <= totalDealer)
            {
                message = $"Perdiste contra el dealer. Lo sentimos.\nPuntaje jugador: {totalJugador}";
                switchControl = "menu";
            }
            else
            {
                message = $"condición no válida.\nPuntaje jugador: {totalJugador}";
                switchControl = "menu";
            }
            Console.WriteLine(message);
            break;

        default:
            Console.WriteLine("Opción incorrecta en el CASINO.");
            break;
    }


}


