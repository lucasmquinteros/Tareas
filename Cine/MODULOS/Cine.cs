namespace Cine.MODULOS
{
    public class cine
    {
        public string Nombre { get; private set; }
        public Cartelera Cartelera { get; private set; }
        public List<Sala> Salas { get; private set; } = new List<Sala>();

        public cine(string nombre, Cartelera cartelera, Sala sala)
        {
            Nombre = nombre;
            Cartelera = cartelera;
            Salas.Add(sala);
        }
        public void AgregarSala(Sala sala)
        {
            Salas.Add(sala);
        }
        public void MostrarCartelera()
        {
            Console.Write($"Estan disponibles las peliculas:\n");
            foreach (var pelicula in Cartelera.Peliculas)
            {
                Console.WriteLine($"{pelicula.Nombre}");
            }
        }
        public void FuncionesDisponibles()
        {
            foreach (var sala in Salas)
            {
                Console.WriteLine("Funciones disponibles: ");
                foreach (var funcion in sala.Funciones)
                {
                    funcion.MostrarDetalles();
                }
            }
        }

    }
}
