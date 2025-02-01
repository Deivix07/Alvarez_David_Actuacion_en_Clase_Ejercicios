using System;
        // Alvarez_David_Actuacion_en_Clase    3ero TSDS
class Program
    {static void Main() 
    {
        do  // El bucle do-while mantiene el programa funcionando hasta que el usuario decida salir
        {
            Console.Clear(); // Limpiamos la pantalla

            // Mostramos el menú con los ejercicios
            Console.WriteLine("----- MENÚ PRINCIPAL -----");
            Console.WriteLine("1. Aréa de un círculo");
            Console.WriteLine("2. Suma serie de números enteros");
            Console.WriteLine("3. Juego Piedra, Papel o Tijera");
            Console.WriteLine("0. Salir");
            Console.WriteLine("--------------------------");

            Console.Write("Seleccione una opción: ");  // Intrucción para que ingrese una opción

            try
            {
                int opcion = int.Parse(Console.ReadLine()); // // Convertir la entrada del usuario a un número entero y guardar la opción

                // Dependiendo de la opción ingresada, ejecutamos el método correspondiente
                switch (opcion)
                {
                    case 1:
                        Area_circulo();
                        break;
                    case 2:
                        Sumar_nums.sum_nums();
                        break;
                    case 3:
                        Juego.ejercicio();
                        break;
                    case 0:
                        Console.WriteLine("¡Gracias por usar el programa!");
                        return; // El programa termina y se sale del bucle
                    
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo");  // Si se ingresa una opción que no está se muestra un error
                        break;
                }
            }
            catch (FormatException)      // Si ocurre un error al ingresar un numero
            {
                // se captura la excepción y se muestra un mensaje de error al usuario
                Console.WriteLine("Entrada no válida. Por favor, ingrese un número");
            }
            Console.WriteLine("\nPresione una tecla para volver al menú...");   // Mensaje de una instrucción
            Console.ReadKey(); // Presionar una tecla antes de continuar

        } while (true); // El bucle seguira ejecutándose hasta que el usuaria eliga 0 para salir
    }

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    
/* 1)   Escribe un programa que calcule el área de un círculo
*/
    static void Area_circulo()
    {
        // Solicitar al usuario el radio del círculo
        Console.Write("Ingresa el radio del círculo: ");
        double radio = Convert.ToDouble(Console.ReadLine());

        // Calcular el área del círculo con la fórmula A = π r²
        double area = 3.1416 * radio * radio;

        // Mostrar el resultado
        Console.WriteLine($"El área del círculo con radio {radio} es: {area:F2}");
    }


/* 2)   Crea un programa que sume una serie de números enteros. Utiliza una variable global para almacenar la suma total y una función para agregar números a esta suma.
        Instrucciones:
        Declara una variable global llamada sumaTotal de tipo int.
        Define una función llamada AgregarNumero que reciba un número entero y lo sume a sumaTotal.
        En el método Main, solicita al usuario que ingrese varios números y llama a la función para cada número ingresado. Al final, muestra la suma total.
*/
class Sumar_nums
{
    static int sumaTotal = 0;  //variable global para almacenar la suma total

    public static void sum_nums()  //// Método para sumar una serie de números enteros
    {
        sumaTotal = 0;  //// Reiniciar la suma total a 0
        // Mensaje de instrucción
        Console.WriteLine("Introduce números enteros para sumarlos (0 para finalizar):");

        // Bucle para permitir que el usuario ingrese números hasta que decida terminar
        while (true)
        {
            // Solicitar al usuario que ingrese un número
            Console.Write("Número: ");
            int numero = int.Parse(Console.ReadLine());

            // Verificar condiciones
            if (numero == 0) //Si se ingresa 0 sale del bucle
            {
                break;
            }
            else
            {
                Agregar_num(numero); //Llamar a la función Agregar_num para sumar el número a la suma total
            }
        }
        // Mostrar la suma total de los números que se ingresaron
        Console.WriteLine($"La suma total es: {sumaTotal}");

    }

    // Función para ir agregando un número a la suma total
    static void Agregar_num(int numero)
    {
        sumaTotal += numero;
    }
}


/* 3)   Juego Piedra Papel o Tijera
*/
class Juego  //Clase Juego
{
    static int vidasUsuario = 3;   //Inicializar variables globales
    static int vidasPc = 3;
    public static void ejercicio()  //Método para ejecutar el Juego
    {
            vidasUsuario = 3; //Reiniciar vidas si se sale
            vidasPc = 3;
        
        // Bucle infinito hasta que el usuario decida salir
        do
        {
            int opcionUsuario = menuOpciones();  // Llamar al método menuOpciones
            int randomPc = new Random().Next(1, 4);  // Generar un número random para la opción de Pc
            logicaJuego(opcionUsuario, randomPc); // Llamar a la lógica del juego
            mostrarGanador();  // Mostrar el ganador
            if (vidasUsuario == 0 || vidasPc == 0) // Verificar condición
            {
                Console.WriteLine("Quieres jugar de nuevo (s/n): "); //Pedir al usuario se quiere jugar de nuevo
                if (Console.ReadLine().ToLower() != "s") break; //Romper el ciclo se ingresa n
                vidasUsuario = 3;  //Reiniciar vidas si se continua
                vidasPc = 3;
            }

        } while (true);
    }
    private static int menuOpciones() // Método menú opciones
    {
        //Mostrar el menú
        Console.WriteLine(  "1. Piedra\n" +
                            "2. Papel\n" +
                            "3. Tijera");
        Console.Write("Selecciona una opción: ");  //Pedir al usuario que seleccione una opción
        return int.Parse(Console.ReadLine());
    }

    private static void logicaJuego(int a, int b) // Método lógica del juego
    {
        // Piedra Papel Tijera   usario a   1->Piedra 2->Papel  3->Tijera
        // Pierdra Papel Tijera  pc     b   3->Tijera 1->Piedra  2->Papel
        string[] opciones = { "Piedra", "Papel", "Tijera" }; //Arreglo de datos para las opciones
        Console.WriteLine($"Usuario => {opciones[a - 1]}\nPC => {opciones[b - 1]}"); //Imprimir según la opción elegida
        
        string cadena = ""; // Inicializar cadena vacía

        // Verificar condicones para imprimir el resultado
        if ((a == 1 && b == 3) || (a == 2 && b == 1) || (a == 3 && b == 2))
        {
            vidasPc--;
            cadena = "Usuario gana";
           
        }
        else if ((a == 3 && b == 1) || (a == 1 && b == 2) || (a == 2 && b == 3))
        {
            vidasUsuario--;
            cadena = "PC gana";
            
        }
        else
        {
            cadena = "Empate";
        }

        Console.WriteLine(cadena); //Imprimir la cadena según la condición

    }

    private static void mostrarGanador()  // Método mostrar ganador
    {
        // Verificar condición para imprimir el ganador del juego
        if (vidasUsuario == 0)
        {
            Console.WriteLine("---PC ha ganado el juego---");
        }
        else if (vidasPc == 0)
        {
            Console.WriteLine("---Usuario ha ganado el juego---");
        }
    }
}
}