using Tienda.Enumeration;
using Tienda.Models;
namespace Tienda
{
    public class Program
    {
        static void Main()
        {
            Producto Bananas = new Producto(Categoria.Alimento, "Banana", 200);
            Producto Cargadores = new Producto(Categoria.DispositivoElectronico, "Cargador", 2000);
            Producto Buzo = new Producto(Categoria.Ropa, "Buzo", 5000);
            List<Producto> lista = new List<Producto>();
            lista.Add(Buzo);
            lista.Add(Bananas);
            lista.Add(Cargadores);
            Inventario inventario = new Inventario(lista);

            Producto Celular = new Producto(Categoria.DispositivoElectronico, "Nokia 1100", 10000);

            inventario.AgregarProducto(Celular);

            inventario.ConsultarProducto(Celular);
            Console.WriteLine();

            inventario.QuitarProducto(Celular);

            inventario.MostrarDetalles();

            lista.Add(Celular);
            Console.WriteLine();

            inventario.ActualizarLista(lista);

            inventario.MostrarDetalles();

        }
            
    }

}