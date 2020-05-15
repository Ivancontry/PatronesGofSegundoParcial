using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public class Esmoquin:Prenda
    {
        public List<Prenda> Prendas { get; set; }
        public Esmoquin(string nombre)
        {
            Prendas = new List<Prenda>();
            Color = nombre;         
        }

        public override double GetPrecio()
        {
            foreach (var prenda in Prendas)
            {
                this.Precio += prenda.Precio;
            }
            return this.Precio;
        }
        public void AddPrenda(Prenda prenda) {
            Prendas.Add(prenda);
        }
        public void DeletePrenda(Prenda prenda)
        {
            Prendas.Remove(prenda);
        }
        public void EliminarPrendasAgregadas()
        {
            Prendas.Clear();
        }
    }
}
