using System.Reflection.Emit;
using Ferreteria.Clases;

internal class Program
{
    private static void Main(string[] args)
    {
        Data data = new Data();
        var opc = "-1";
        bool flag = true;
        while (flag)
        {  
            data.menu();
            Console.WriteLine("\nIngrese la opcion que desea realizar");
            opc = Console.ReadLine();
        
            if (opc == "1")
            {
                data.ListaProductos();
            }
            else if (opc == "2")
            {
             
                data.ProductosAgotarse();
            }
            else if (opc == "3")
            {
               
                data.ProductosComprar();
            }
            else if (opc == "4")
            {
             
                data.FacturasEnero();
            }
            else if (opc == "5")
            {
                data.ProductosFactura();
                
            }
            else if (opc == "6")
            {
            
                data.ValorInventario();
            }
            else if (opc == "7")
            {
                System.Console.WriteLine("Saliendo del programa ");
                flag = false;
            }
            else
            {
                System.Console.WriteLine("la opcion que desea ingresar no es valida");
            }


        }

    }
}





/*    data.ListaProductos();
   data.ProductosAgotarse();
   data.FacturasEnero();
*/
