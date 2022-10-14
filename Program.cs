internal class Program
{
    static void Main(string[] args)
    {

        int moneda;
        double cant;
        Console.WriteLine("Bienvenido al programa para convertir a euros.");
        Console.WriteLine("Para convertir de libras, ingrese 1. Para convertir desde dolares, ingrese 2 y para convertir desde yenes, ingrese 3.");
        moneda = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese la cantidad a convertir");

        cant = Convert.ToDouble(Console.ReadLine());
        if (moneda <1 || moneda>3)
        {
            Console.WriteLine("Moneda invalida");
        }

        else
        {
            double resultado = conversion(moneda, cant);
            Console.WriteLine("Su cantidad es : " + resultado);
        }
        

    }


        static double conversion(int moneda, double cant)
        {
            // libras
            if (moneda == 1)
            {
                return cant*1.22;
            }

            // dolares
            else if (moneda == 2)
            {
            return cant * 0.75;
            }

            else
            {
            return cant * 0.009;
            }

          
        }
}
