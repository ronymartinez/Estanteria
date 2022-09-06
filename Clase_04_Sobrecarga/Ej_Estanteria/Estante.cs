using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_Estanteria
{
    public class Estante
    {
        private Producto[] productos;
        private int ubicacionEstante;

        private Estante(int capacidad)
        {
            this.productos = new Producto[capacidad];
        }
        public Estante(int capacidad, int ubicacion):this(capacidad)
        {
            ubicacionEstante = ubicacion;
        }
        
        public Producto[] GetProducto { get { return productos; } }

        public string MostrarEstante(Estante e)
        {
            StringBuilder sb = new StringBuilder();
            int contador = 1;

            if(e is not null)
            {
                foreach (var item in e.GetProducto)
                {
                    if(item is not null)
                    {
                        sb.AppendLine($"Producto {contador}:\n{item.MostrarProducto(item)}");
                        contador++;
                    }
                }
            }

            return sb.ToString();
        }

        public static bool operator ==(Estante e, Producto p)
        {
            if(p is not null)
            {
                foreach (var item in e.GetProducto)
                {
                    if(p == item)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }

        public static bool operator +(Estante e, Producto p)
        {
            if(e != p)
            {
                for (int i = 0; i < e.GetProducto.Length; i++)
                {
                    if (e.GetProducto[i] is null)
                    {
                        e.GetProducto[i] = p;
                        return true;
                    }
                }
            }
            return false;
        }

        public static Estante operator -(Estante e, Producto p)
        {
            for (int i = 0; i < e.GetProducto.Length; i++)
            {
                if (e == p)
                {
                    e.GetProducto[i] = null;
                }
            }

            return e;
        }



    }
}
