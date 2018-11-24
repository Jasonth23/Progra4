using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra4.AW.Products.AccesoBL
{
  public  class Productos
    {
       public IList<Model.Product> ListarProductosPorColor(string elColor)
        {
            var elCliente = new SI.WcfProducto.AWProductosClient();

            var elResultado = elCliente.ListarProductosPorColor(elColor);
            elCliente.Close();
            return elResultado;
        }
    }
}
