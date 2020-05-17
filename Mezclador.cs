using System;
using System.Collections.Generic;
using System.Text;

namespace Prueba.Net1
{
    class Mezclador : VehiculoComponentes
    {
        private string _tipo;

        public Mezclador(string tipo)
                        
        {
            _tipo = tipo;
        }

        public string Tipo { get => _tipo; set => _tipo = value; }
    }
}
