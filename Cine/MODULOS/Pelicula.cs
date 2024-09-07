using Cine.ENUM;

namespace Cine.MODULOS
{
    public class Pelicula
    {
        public string Nombre { get; private set; }
        public string Genero { get; private set; }
        public int Duracion { get; private set; }
        public Formato Formato { get; private set; }

        public double TarifaBase { 
            get {
                switch (Formato)
                {
                    case Formato.IMAX_Doblada: return 60;
                    case Formato.IMAX_Subtitulada: return 55;
                    case Formato._2D_Doblada: return 40;
                    case Formato._2D_subtitulada: return 35;
                    case Formato._3D_Doblada: return 70;
                    case Formato._3D_subtitulada: return 65;
                    default: return 0; 
                }
            } 
        }

        public Pelicula(string nombre, string genero, int duracion, Formato formato)
        {
            Nombre = nombre;
            Genero = genero;
            Duracion = duracion;
            Formato = formato;
        }
    }
}
