namespace Cine.MODULOS
{
    public class Funcion
    {
        public Pelicula Pelicula { get; private set; }
        public DateTime Fecha { get; private set; }

        public Funcion(Pelicula pelicula, DateTime fecha)
        {
            Pelicula = pelicula;
            Fecha = fecha;
        }
        public void MostrarDetalles()
        {
            Console.WriteLine($"Pelicula: {Pelicula.Nombre}, Hora; {Fecha}");
        }
    }
}
