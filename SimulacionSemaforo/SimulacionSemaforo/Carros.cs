using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SimulacionSemaforo
{

    public enum Rutas
    {
        Macoris = 0,
        Tenares = 1,
        Nordestana = 2
    }

    public class Carros
    {
        int TiempoDeEspera;

        Rutas RutaInicio;
        Rutas RutaDestino;


        public Carros(Rutas RutaInicio)
        {
            this.RutaInicio = RutaInicio;
        }

    }


}
