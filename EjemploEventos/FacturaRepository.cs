using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploEventos
{
    public class FacturaRepository
    {
        //metodo add() y getAll()
        //llamar al evento uqe cambie el grid
        public static List<Factura> listaFactura;

        static FacturaRepository()
        {
            listaFactura = new List<Factura>();
            Factura factura1 = new Factura(1, "test1", "aaa");
            Factura factura2 = new Factura(2, "test2", "bbb");
            Factura factura3 = new Factura(3, "test3", "ccc");
            listaFactura.Add(factura1);
            listaFactura.Add(factura2);
            listaFactura.Add(factura3);
        }
        
        public static Factura AddFactura(int _id, string _descripcion, string _direccion)
        {
            Factura facturaAux = new Factura(_id, _descripcion, _direccion);
            listaFactura.Add(facturaAux);
            return facturaAux;
        }
        public List<Factura> GetAllFactura()
        {
            return listaFactura;
        }

    }
}
