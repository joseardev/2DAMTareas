
using System.Diagnostics.Metrics;
using System.Diagnostics.SymbolStore;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

setup();

 void setup()
{
    bool menu = true;
    bool isNumberOpcionMenu;
    int  opcionMenu;
    while (menu)
    {
        Console.WriteLine("------------------ Menu ------------------------ ");
        Console.WriteLine("1 - Resolver ecuación 2ª grado ");
        Console.WriteLine("2 - Mostrar tabla de multiplicar ");
        Console.WriteLine("3 - Salir ");
        Console.WriteLine("----------------------------------------------- ");
        //Obtenemos y comprobamos la entrada
        isNumberOpcionMenu = int.TryParse(Console.ReadLine(), out opcionMenu);        
        if (isNumberOpcionMenu)
        {
            //Opciones
            switch (opcionMenu)
            {
                case 1:
                    calculaFuncionSegundoGrado();
                    break;
                case 2:
                    calcularTablaMultiplicar();
                    break;
                case 3:
                    menu = false;
                    break;

            }
        }
            
    }    
    //Permite controlar el codigo de salida
    //Aunque por defecto sale como 0
   Environment.Exit(0);
}


void calcularTablaMultiplicar()
{
   
    bool isNumberNumTabla = false;
    bool isNumberElementos = false;   
    int numeroMultiplicar = 0;
    int elementosMostrar = 0;
    bool flag = true;
    
    do
    {
        //Comprobamos que la entrada de datos es correcta
        if (!isNumberNumTabla)
        {
            Console.WriteLine("Introduce numero: ");
            isNumberNumTabla = int.TryParse(Console.ReadLine(), out numeroMultiplicar);
        }

        if (isNumberElementos == false && isNumberNumTabla == true)
        {
            Console.WriteLine("Numero de elementos a mostrar: ");
            isNumberElementos = int.TryParse(Console.ReadLine(), out elementosMostrar);
        }

        //Si la entrada de datos es correcta empezamos a montar el resultado
        if (isNumberNumTabla && isNumberElementos)
        {
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Tabla de multiplicar  de " + numeroMultiplicar);
            Console.WriteLine("----------------------------------------------");

            //inicializamos resultado para que sea 0 la primera vuelta
            int resultado = 1;
            //resultado es igual al numeroMultiplicar * i en cada vuelta
            for (int i = 1; i < elementosMostrar + 1; i++)
            {
                resultado = i * numeroMultiplicar;
                Console.WriteLine("{0} x {1} = {2}"  ,numeroMultiplicar,i, resultado);                
            }
            flag = false;
        }

    } while (flag);
                            
}

void calculaFuncionSegundoGrado()
{
 
    Console.WriteLine("----------------------------------------------");
    Console.WriteLine("Calcular funcion de Segundo Grado  ");
    Console.WriteLine("----------------------------------------------");

    bool isNumberA = false;
    bool isNumberB = false;
    bool isNumberC = false;
    bool flag = true;
    int a = 0;
    int b = 0; 
    int c = 0;

    do { 
        //Validamos cada entrada de datos
        if (!isNumberA)
        {
            Console.WriteLine("valor de a: ");
            isNumberA = int.TryParse(Console.ReadLine(), out a);
        }

        if (isNumberB == false && isNumberA == true)
        {
            Console.WriteLine("valor de b: ");
            isNumberB = int.TryParse(Console.ReadLine(), out b);
        }
        if (isNumberC == false && isNumberA == true && isNumberB == true)
        {
            Console.WriteLine("valor de c: ");
            isNumberC = int.TryParse(Console.ReadLine(), out c);
        }

        //Si la entrada de datos es correcta pasamos a realizar los calculos
        if (isNumberA && isNumberB && isNumberC)
        {
            //Calculo Raiz
            double dentroraiz = a * c;
            dentroraiz = dentroraiz * 4;

            double raizB = Math.Pow(b, 2);
            dentroraiz = raizB - dentroraiz;

            double raizCuadrada = Math.Sqrt(dentroraiz);

            //fin raiz


            double resulSuma = -b + raizCuadrada;
            double resulResta = -b - raizCuadrada;

            //Divisor
            double divisor = a * 2;
            //suma y resta
            resulSuma = resulSuma / divisor;
            resulResta = resulResta / divisor;

            Console.WriteLine("Resultado x1 {0}" , resulSuma);
            Console.WriteLine("Resultado x2 {0}" , resulResta);
            flag = false;
        }
    }while (flag);
}

