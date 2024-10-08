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
        }
}
