using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_De_Datos_Programing_II
{
    public class Program     //La lista va dirijida a un supuesto X coleccionista de zapatos marca Adidas con su respectivos detalles
    {
        static void Main(string[] args)
        {



            //
            ListaZapatos listaZapaos = new ListaZapatos();

            AñadirZapato C1 = new AñadirZapato();

            C1.Marca = "Adidas- Tenis Day Jogger";
            C1.Precio = 120000;
            C1.Talla = 39;
            C1.Genero = "Masculino";
            listaZapaos.Insertar(C1);


            AñadirZapato C2 = new AñadirZapato();

            C2.Marca = "Adidada- Tenis SL 7200";
            C2.Precio = 100000;
            C2.Talla = 42;
            C2.Genero = "Masculino";
            listaZapaos.Insertar(C2); 


            AñadirZapato C3 = new AñadirZapato();

            C3.Marca = "Adidas- Tenis NMD_R1";   
            C3.Precio = 99000;
            C3.Talla = 35;
            C3.Genero = "Femeninos";
            listaZapaos.Insertar(C3);
            //

            //Catalogo previo del coleccionista
            CatalogoDeZapatos CatalogoDeZapatos = new CatalogoDeZapatos();

            CatalogoDeZapatos Z1 = new CatalogoDeZapatos();

            Z1.Talla = 36;
            Z1.Precio = 200000;
            Z1.Marca = "Adidas- Tenis Superstar";   //Los nombres de los tenis fueron sacados de internet
            Z1.Genero = "Femeninos";


            CatalogoDeZapatos Z2 = new CatalogoDeZapatos();

            Z2.Talla = 39;
            Z2.Precio = 230000;
            Z2.Marca = "Adidas- Tenis X9000L4";   //Los nombres de los tenis fueron sacados de internet
            Z2.Genero = "Masculino";


            CatalogoDeZapatos Z3 = new CatalogoDeZapatos();

            Z3.Talla = 37;
            Z3.Precio = 270000;
            Z3.Marca = "Adidas- Tenis Bravada";   //Los nombres de los tenis fueron sacados de internet
            Z3.Genero = "Masculino";


            CatalogoDeZapatos Z4 = new CatalogoDeZapatos();

            Z4.Talla = 42;
            Z4.Precio = 190000;
            Z4.Marca = "Adidas- Tenis NMD_R";   //Los nombres de los tenis fueron sacados de internet
            Z4.Genero = "Masculino";
            //

            Console.WriteLine("La colecion de X persona de zapatos marca Adidas");

            Console.WriteLine("La collecion antigua");

            Console.WriteLine("Los zapatos son de genero " + Z1.Genero + "  Su marca es: " + Z1.Marca + 
                             "  Tienen un precio de: " + Z1.Precio + "$" + "Vienen en talla de" + Z1.Talla);

            Console.WriteLine("Los zapatos son de genero " + Z2.Genero + "  Su marca es: " + Z2.Marca +
                            "  Tienen un precio de: " + Z2.Precio + "$" + "Vienen en talla de" + Z2.Talla);

            Console.WriteLine("Los zapatos son de genero " + Z3.Genero + "  Su marca es: " + Z3.Marca +
                            "  Tienen un precio de: " + Z3.Precio + "$" + "Vienen en talla de" + Z3.Talla);

            Console.WriteLine("Los zapatos son de genero " + Z4.Genero + "  Su marca es: " + Z4.Marca +
                            "  Tienen un precio de: " + Z4.Precio + "$" + "Vienen en talla de" + Z4.Talla);

            Console.WriteLine("La collecion agregada");

            listaZapaos.Imprimir();

            Console.ReadKey();

        }
    }
}
