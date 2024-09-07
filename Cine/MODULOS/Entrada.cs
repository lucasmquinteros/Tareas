namespace Cine.MODULOS
{
    public class Entrada
    {
        public cine Cine {  get; private set; }
        public Funcion Funcion { get; private set; }
        public Asiento Asiento { get; private set; }
        public double Precio
        {
            get
            {
                return Funcion.Pelicula.TarifaBase + Asiento.TarifaBase;
            }
        }

        public Entrada(cine cine, Funcion funcion, Asiento asiento) 
        {
            Cine = cine;
            this.Funcion = funcion;
            Asiento = asiento;
        }
        public void MostrarDetalles()
        {
            Console.WriteLine($"Reservo la funcion: ");
            Funcion.MostrarDetalles();
            Console.Write($"En el cine: {Cine.Nombre}\n");
            Console.WriteLine($"Total: {Precio :C}");
        }
    }
}
