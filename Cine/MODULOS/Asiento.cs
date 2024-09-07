using Cine.ENUM;

namespace Cine.MODULOS
{
    public class Asiento
    {
        private static int letra = 65;
        public char Letra {  get; private set; }
        public int Numero { get; private set; }
        public TipoAsiento Tipo { get; private set; }
        public bool Ocupado { get; private set; } = false;

        public double TarifaBase { get { return (Tipo == TipoAsiento.Estandar) ? 30 : 50; } } 

        public Asiento(int numero, TipoAsiento tipo) 
        {
            Letra = (char)letra++;
            Numero = numero;
            Tipo = tipo;
        }
        public void CambiarOcupado()
        {
            Ocupado = true;
        }
    }
}
