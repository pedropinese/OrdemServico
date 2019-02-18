using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdemServico
{
    class Area
    {
        public int codigo { get; set; }
        public double area { get; set; }
        public List<Area> listaAreas { get; set; }

        public Area()
        {
        }

        public Area(int codigo, double area, List<Area> listaAreas)
        {
            this.codigo = codigo;
            this.area = area;
            this.listaAreas = listaAreas;
        }
    }
}
