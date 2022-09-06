using System;
using System.Text;

namespace Ej_Estanteria
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;


        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }

        public string GetMarca() { return this.marca; }
        public float GetPrecio() { return this.precio; }

        //public string GetMarca() { get { return marca; } set { marca = value; } }
        //public float GetPrecio { get { return precio; } set { precio = value; } }

        public string MostrarProducto(Producto p)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Codigo de Barra: {this.codigoDeBarra}");
            sb.AppendLine($"Marca: {this.marca}");
            sb.AppendLine($"Precio: {this.precio}");

            return sb.ToString();
        }

        public static bool operator !=(Producto p, string marca)
        {
            return !(p == marca);
        }
        public static bool operator ==(Producto p, string marca)
        {
            //if(p is not null && marca is not null && p.marca == marca)
            if (p.marca == marca)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }
        public static bool operator ==(Producto p1, Producto p2)
        {
            if( p1 is not null && p2 is not null && p1 == p2.marca && p1.codigoDeBarra == p2.codigoDeBarra)
            {
                return true;
            }
            return false;
        }

        public Producto(string codigoDeBarra, string marca, float precio)
        {
            this.codigoDeBarra = codigoDeBarra;
            this.marca = marca;
            this.precio = precio;
        }
    }
}
