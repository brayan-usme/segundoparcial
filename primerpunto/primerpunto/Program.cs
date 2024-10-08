using System;

class AdivinaElNumero
{
    static void Main()
    {
        bool jugarDeNuevo = true;

        while (jugarDeNuevo)
        {
            Console.Clear();
            Console.WriteLine("¡Bienvenidos al juego de Adivina el Número!");
            int numeroJugadores = ObtenerNumeroDeJugadores();
            int rangoMaximo = DeterminarRangoMaximo(numeroJugadores);
            int numeroAleatorio = GenerarNumeroAleatorio(rangoMaximo);
            while (!ganadorEncontrado)
            {
                for (int i = 1; i <= numeroJugadores; i++)
                {
                    turno++;
                    Console.WriteLine($"\nTurno {turno} - Jugador {i}, es tu turno.");
                    Console.Write("Adivina el número: ");
                    int intento = Convert.ToInt32(Console.ReadLine());

                    if (intento == numeroAleatorio)
                    {
                        Console.WriteLine("¡HAS GANADO, JUGADOR {0}!", i);
                        ganadorEncontrado = true;
                        break;
                    }
                    else if (intento > numeroAleatorio)
                    {
                        Console.WriteLine("MENOR");
                    }
                    else
                    {
                        Console.WriteLine("MAYOR");
                    }
}
