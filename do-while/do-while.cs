int num = 0;
int coins = 0;
int totalJugador = 0;
int totalDealer = 0;
string messagePlayer = string.Empty;
string controlOtraCarta = string.Empty;
string switchControl = "menu";

System.Random random = new System.Random();

// Blackjack, juntar 21 pidiendo cartas o en caso de tener menos de 21 igual tener mayor puntuación que el dealer


while (true)
{
    Console.WriteLine("** Bienvenido al CASINO **\n");
    Console.WriteLine("¿Cuántas monedas deseas? Escriba un número entero \nRecuerda que necesitas una por ronda.");
    coins = int.Parse(Console.ReadLine());

    for (int i = 0; i < coins; i++)
    {
        totalJugador = 0;
        totalDealer = 0;

        switch (switchControl)
        {
            case "menu":
                Console.WriteLine("Escriba '21' para jugar al 21");
                Console.WriteLine("Escriba '24' para jugar al 24");
                Console.WriteLine("Escriba '27' para jugar al 27");
                Console.Write("Su elección: ");
                switchControl = Console.ReadLine();
                i = i - 1; 
                break;

            case "21":
                do
                {
                    num = random.Next(1, 12);
                    totalJugador = totalJugador + num;
                    Console.WriteLine($"Toma tu carta, jugador. \nTe salio el número {num}");
                    Console.Write("¿Deseas otra carta?: ");
                    controlOtraCarta = Console.ReadLine().ToLower();

                } while (controlOtraCarta == "si");

                totalDealer = random.Next(14, 23);
                Console.WriteLine($"¡El dealer tiene {totalDealer}!");

                if (totalJugador > totalDealer && totalJugador <= 21)
                {
                    messagePlayer = $"Venciste al dealer. Felicidades.\nPuntaje jugador: {totalJugador}.\n";
                    switchControl = "menu";
                }
                else if (totalJugador >= 22)
                {
                    messagePlayer = $"Perdiste contra el dealer, te pasaste de 21.\nPuntaje jugador: {totalJugador}.";
                    switchControl = "menu";
                }
                else if (totalJugador <= totalDealer)
                {
                    messagePlayer = $"Perdiste contra el dealer. Lo sentimos.\nPuntaje jugador: {totalJugador}.";
                    switchControl = "menu";
                }
                else
                {
                    messagePlayer = $"condición no válida.";
                }
                Console.WriteLine(messagePlayer);
                break;

            case "24":
                do
                {
                    num = random.Next(1, 12);
                    totalJugador = totalJugador + num;
                    Console.WriteLine($"Toma tu carta, jugador. \nTe salio el número {num}");
                    Console.Write("¿Deseas otra carta?: ");
                    controlOtraCarta = Console.ReadLine().ToLower();
                } while (controlOtraCarta == "si");

                totalDealer = random.Next(14, 25);
                Console.WriteLine($"¡El dealer tiene {totalDealer}!");
                if (totalJugador > totalDealer && totalJugador <= 24)
                {
                    messagePlayer = $"Venciste al dealer. Felicidades.\nPuntaje jugador: {totalJugador}.";
                    switchControl = "menu";
                }
                else if (totalJugador >= 24)
                {
                    messagePlayer = $"Perdiste contra el dealer, te pasaste de 24.\nPuntaje jugador: {totalJugador}.";
                    switchControl = "menu";
                }
                else if (totalJugador <= totalDealer)
                {
                    messagePlayer = $"Perdiste contra el dealer. Lo sentimos.\nPuntaje jugador: {totalJugador}.";
                    switchControl = "menu";
                }
                else
                {
                    messagePlayer = $"condición no válida.";
                }
                Console.WriteLine(messagePlayer);
                break;

            case "27":
                do
                {
                    num = random.Next(1, 12);
                    totalJugador = totalJugador + num;
                    Console.WriteLine($"Toma tu carta, jugador. \nTe salio el número {num}");
                    Console.Write("¿Deseas otra carta?: ");
                    controlOtraCarta = Console.ReadLine().ToLower();

                } while (controlOtraCarta == "si");

                totalDealer = random.Next(14, 28);
                Console.WriteLine($"¡El dealer tiene {totalDealer}!");

                if (totalJugador > totalDealer && totalJugador <= 27)
                {
                    messagePlayer = $"Venciste al dealer. Felicidades.\nPuntaje jugador: {totalJugador}.";
                    switchControl = "menu";
                }
                else if (totalJugador >= 27)
                {
                    messagePlayer = $"Perdiste contra el dealer, te pasaste de 27.\nPuntaje jugador: {totalJugador}.";
                    switchControl = "menu";
                }
                else if (totalJugador <= totalDealer)
                {
                    messagePlayer = $"Perdiste contra el dealer. Lo sentimos.\nPuntaje jugador: {totalJugador}.";
                    switchControl = "menu";
                }
                else
                {
                    messagePlayer = $"condición no válida.";
                }
                Console.WriteLine(messagePlayer);
                break;

            default:
                Console.WriteLine("Opción incorrecta en el CASINO.");
                break;
        }
    }
}


