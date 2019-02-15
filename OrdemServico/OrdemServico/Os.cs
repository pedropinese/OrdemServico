using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdemServico
{
    class Os
    {
        public int numero { get; set; }
        public DateTime data_abertura { get; set; }
        public DateTime? data_encerramento { get; set; }
        public string responsavel{ get; set; }
        public List<Area> listaAreas { get; set; }

        public Os(int numero, DateTime data_abertura, DateTime? data_encerramento, string responsavel, List<Area> listaAreas)
        {
            this.numero = numero;
            this.data_abertura = data_abertura;
            this.data_encerramento = data_encerramento;
            this.responsavel = responsavel;
            this.listaAreas = listaAreas;
        }
    }
}
