namespace Cine.MODULOS
{
    public class Sala
    {
        public static int num = 0;
        public int Numero {  get; private set; }
        public List<Asiento> Asientos { get; private set; } = new List<Asiento>();  
        public List<Funcion> Funciones { get; private set; } = new List<Funcion>();

        public Sala() { 
            Numero = ++num;
        }
        public Sala(List<Asiento> asientos)
        {
            Numero = ++num;
            Asientos = asientos;
        }
        
        public void AgregarAsiento(Asiento asiento)
        {
            Asientos.Add(asiento);
        }
        public void AgregarAsiento(List<Asiento> asientos)
        {
            foreach (var asiento in asientos)
            {
                Asientos.Add(asiento);
            }
        }
        public void DefinirFuncion(Funcion funcion)
        {
            Funciones.Add(funcion);
        }
    }
}
