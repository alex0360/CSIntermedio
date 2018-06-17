using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa1_2IEnumerable.Clases
{
    interface IAutomovil
    {
        // Calcular el impuesto
        void CalcularTenencia(double impusto);

        // Mostral Informacion
        void MuestraInformacion();
    }
}
