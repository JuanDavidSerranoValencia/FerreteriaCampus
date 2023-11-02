using Ferreteria.Clases;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Data data = new Data();

        /* data.fecha(); */
        data.ListaProductos();
        data.ProductosAgotarse();
        data.FacturasEnero();

    }
}