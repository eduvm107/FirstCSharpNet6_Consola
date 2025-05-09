// See https://aka.ms/new-console-template for more information
using FirstCSharpNet6;



internal class Program
{
    private static void Main(string[] args)
    {
        var personas1 = new Personas(12345678, "Eduardo", 918162919, true);
        personas1.dni = 12345678;
        personas1.Nombre = "Eduardo";
        personas1.telefono = 123456789;
        personas1.estado = true;

        var personas2 = new Personas();
        {
            personas2.dni = 12345678;
            personas2.Nombre = "Eduardo";
            personas2.telefono = 123456789;
            personas2.estado = true;

        }
        var personas3 = new Personas(12345678, "Eduardo", 918162919, true);

        var personas = new List<Personas>();
        personas.Add(personas1);
        personas.Add(personas2);
        personas.Add(personas3);




        foreach (var item in personas)
        {
            Console.WriteLine(item.dni + "|" + item.Nombre);
        }

        var busqueda = personas.Find(x => x.dni == 12345678);
        if (busqueda != null)
        {
            Console.WriteLine("la persona encontrada es: "+busqueda.Nombre);
        }
        else
        {
            Console.WriteLine("El dni no existe en la lista");
        }




    }
}