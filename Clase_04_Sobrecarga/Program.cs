using System;

namespace Clase_04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Persona persona1 = new Persona();
            //Persona persona2 = new Persona("Juan");
            //Persona persona3 = new Persona("Carla", 33344343);
            //Persona persona4 = new Persona("Sandra", 23244433, "11011");

            Producto p1 = new Producto(100, "Alfajor", 150, 100);
            Producto p2 = new Producto(101, "Chupetín", 50, 12);

            int id = (int) p1;

            int stockTotal = p1.Stock * p1.Precio + p2.Stock * p2.Precio ;
            int stockTotal2 = p1 + p2;
            int stockTotal3 = p1 + 10;
            int stockTotal4 = p1 - 10;
            string productoNombre = p1;


            //Console.WriteLine("Stock total: {0}", stockTotal);
            //Console.WriteLine("Stock total: {0}", stockTotal2);
            //Console.WriteLine("Stock total: {0}", stockTotal3);
            Console.WriteLine("id: {0}", id);
            Console.WriteLine("productoNombre: {0}", productoNombre);

            //Console.WriteLine(persona4._legajo);
        }
    }
    public class Persona
    {
        private int _dni;
        private string nombre;
        private string _legajo;

        public Persona(string nombre)
        {
            this.nombre = nombre;
        }

        public Persona (string nombre, int dni): this(nombre)
        {
            _dni = dni;
        }
        public Persona(string nombre, int dni, string legajo): this(nombre, dni)
        {
            _legajo = legajo;
        }

    }


 
}
