using Cine.ENUM;
using Cine.MODULOS;
using System.Security.Cryptography.X509Certificates;
namespace Main
{
    public class Program
    {
        static void Main()
        {
            Asiento asiento1 = new Asiento(2, TipoAsiento.Estandar);
            Asiento asiento2 = new Asiento(2, TipoAsiento.Superseat);
            Asiento asiento3 = new Asiento(2, TipoAsiento.Estandar);
            List<Asiento> asientos = new List<Asiento>();
            asientos.Add(asiento1);
            asientos.Add(asiento2);
            asientos.Add(asiento3);

            Pelicula deadpool = new Pelicula("Deadpool", "Accion", 142, Formato._3D_Doblada);
            Pelicula Oppenheimer = new Pelicula("Oppenheimer", "drama", 312, Formato.IMAX_Subtitulada);
            Sala sala = new Sala();
            sala.AgregarAsiento(asientos);

            Funcion funcionOppenheimer = new Funcion(Oppenheimer, DateTime.Now);
            Funcion funcionDeadpool = new Funcion(deadpool, DateTime.Now);
            sala.DefinirFuncion(funcionDeadpool);
            sala.DefinirFuncion(funcionOppenheimer);

            
            Cartelera cartelera = new Cartelera();
            cartelera.AgregarPeliculas(Oppenheimer);

            cine cine = new cine("ShowCase", cartelera, sala);
            cine.MostrarCartelera();
            Console.WriteLine();
            cine.FuncionesDisponibles();
            Console.WriteLine();

            Entrada entrada = new Entrada(cine, funcionDeadpool, asiento2);
            entrada.MostrarDetalles();
            Console.WriteLine();
            Entrada entrada2 = new Entrada(cine, funcionOppenheimer, asiento2);
            entrada2.MostrarDetalles();
            
        }
    }
}
