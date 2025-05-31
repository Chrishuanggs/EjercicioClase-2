

using Entities;

public class Program
{

    public static void Main(String[] args)
    {
        //INSTANCIA DEL GATO

        var myCat = new Cat() { ID = 1, Name = "Chloe" };

        Console.WriteLine("id del gato: " +  myCat.ID);
        Console.WriteLine("Nombre del gato: " + myCat.Name);


        Console.WriteLine("Ingrese una descripcion para el gato: ");

        myCat.Description = Console.ReadLine();
    }
}