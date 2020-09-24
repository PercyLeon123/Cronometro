using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cronometro.Utilitario
{
    public class XXCronometro
    {
        protected int h = 0;
        protected int m = 0;
        protected int s = 0;

        public string ShowTimer()
        {
            var segundos = "";
            var minutos = "";
            var horas = "";

            s++;

            if (s > 59) { m++; s = 0; }
            if (m > 59) { h++; m = 0; }
            if (h > 24) { h = 0; }

            segundos = (s < 10) ? ("0" + s.ToString()) : (s.ToString());
            minutos = (m < 10) ? ("0" + m.ToString()) : (m.ToString());
            horas = (h < 10) ? ("0" + h.ToString()) : (h.ToString());

            return horas + ":" + minutos + ":" + segundos;
        }

        public void Inicializar()
        {
            h = 0;
            m = 0;
            s = 0;
        }
    }
}
