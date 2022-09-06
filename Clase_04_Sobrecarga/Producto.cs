using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_04
{
    public class Producto
    {
        private int id;
        private string nombre;
        private int precio;
        private int stock;
  
        public Producto(int id)
        {
            this.id = id;
            nombre = "";
            precio = 0;
            stock = 0;
        }
        public Producto(int id, string nombre):this(id)
        {
            this.nombre = nombre;

        }
        public Producto(int id, string nombre, int precio): this(id, nombre)
        {
            this.precio = precio;
        }
        public Producto(int id, string nombre, int precio, int stock): this(id, nombre, precio)
        {
            this.stock = stock;
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }

        public void Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("PRODUCTO");
            sb.Append("\t");
            sb.Append("ID");
            sb.Append("\t");
            sb.Append("PRECIO");
            sb.Append("\t");
            sb.Append("STOCK");
            sb.Append("\t");

            Console.WriteLine(sb.ToString());
        }

        public void Mostrar(ConsoleColor backColor)
        {
            Console.BackgroundColor = backColor;

            Mostrar();
        }
        public static int operator +(Producto p1, Producto p2)
        {
            return (p1.Stock * p1.Precio + p2.Stock * p2.Precio);
        }

        public static int operator +(Producto p1, int n1)
        {
            return (p1.Stock + n1);
        }
        public static int operator -(Producto p1, int n1)
        {
            return -(p1.Stock - n1);
        }

        public static bool operator ==(Producto p1, int id)
        {
            return p1.id == id;
        }

        public static bool operator !=(Producto p1, int id)
        {
            return !(p1 == id);
        }

        public static explicit operator int(Producto p1)
        {
            return p1.id;
        }

        public static implicit operator string (Producto p1)
        {
            return p1.Nombre;
        }
    }
}
