using System;

namespace AbstracFactrory
{
    class Program
    {
        static void Main(string[] args)
        {
            IFabrica fabricaNatural = new FabricaNatural();
            fabricaNatural.CrearProductos();
            IProductoLeche productoLeche = fabricaNatural.ObtenProductoLeche;
            IProductoSaborizante productoSaborizante = fabricaNatural.ObtenProductoSaborizante;

            productoLeche.Producir();
            productoSaborizante.Obtener();
        }
    }
}
