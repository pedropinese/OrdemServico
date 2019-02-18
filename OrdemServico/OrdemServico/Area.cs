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

        public List<Area> inserir_areas()
        {
            Area a = new Area();
            a.listaAreas = new List<Area>();
            Console.Write("\nDigite quantas areas deseja inserir: ");
            int qtde_areas = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < qtde_areas; i++)
            {
                Area a1 = new Area();
                Console.Write("\nDigite o codigo da {0}º area: ", i+1);
                a1.codigo = Convert.ToInt32(Console.ReadLine());
                Console.Write("\nDigite o tamanho da {0}º area: ", i+1);
                a1.area = Convert.ToDouble(Console.ReadLine());
                a.listaAreas.Add(a1);
            }
            return a.listaAreas;
        }
    }
}
