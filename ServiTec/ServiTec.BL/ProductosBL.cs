using System;

namespace ServiTec.BL
{
    public class ProductosBL
    {
        public List<Producto> ObtenerProductos() 
        {
            var producto1 = new Producto();
            producto1.Id = 1;
            producto1.Descripcion = "MB. Dell Latitud E6430";

            var producto2 = new Producto();
            producto2.Id = 2;
            producto2.Descripcion = "Case Gamer CG327-1";

            var producto3 = new Producto();
            producto3.Id = 3;
            producto3.Descripcion = "Monitor Z326-2A";

            var listadeProductos = new List<Producto>();
            listadeProductos.Add(producto1);
            listadeProductos.Add(producto2);
            listadeProductos.Add(producto3);

            return listadeProductos;
        }
    }
}
