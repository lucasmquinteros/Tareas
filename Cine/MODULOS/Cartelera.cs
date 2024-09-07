namespace Cine.MODULOS
{
    public class Cartelera
    {
        public List<Pelicula> Peliculas = new List<Pelicula>();
        
        public Cartelera() { }

        public Cartelera(Pelicula pelicula) { 
            Peliculas.Add(pelicula);
        }
        public Cartelera(List<Pelicula> peliculas)
        {
            foreach (var pelicula in peliculas) {
                Peliculas.Add(pelicula);
            }
        }
        public void AgregarPeliculas(Pelicula pelicula)
        {
            Peliculas.Add(pelicula);
        }
        public void QuitarPelicula(Pelicula pelicula)
        {
            Peliculas.Remove(pelicula);
        }
    }
}
