using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Fabricante
    {
        public void Construtor(ICelular celularBuilder)
        {
            celularBuilder.BuildBateria();
            celularBuilder.BuildSistema();
            celularBuilder.BuildTela();
            celularBuilder.BuildCamera();
        }
    }
}
