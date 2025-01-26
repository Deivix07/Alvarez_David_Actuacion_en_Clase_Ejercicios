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
            Console.WriteLine("1. Adivina el número");
            Console.WriteLine("2. Verificar si puedes votar");
            Console.WriteLine("3. Convertir calificación númerica a letra (if)");
            Console.WriteLine("4. Número par o impar");
            Console.WriteLine("5. Determina el número mayor");
            Console.WriteLine("6. Edad suficiente para votar");
            Console.WriteLine("7. Mostrar el día de la semana");
            Console.WriteLine("8. Determinar calificacion (switch)");
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
                        numero_random();
                        break;
                    case 2:
                        edad_votar();
                        break;
                    case 3:
                        Convertir_calif();
                        break;
                    case 4:
                        par_impar();
                        break;
                    case 5:
                        mayor_menor();
                        break;
                    case 6:
                        determinar_votar();
                        break;
                    case 7:
                        Mostrar_dia_semana();
                        break;
                    case 8:
                        calificacion();
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
    
    /* 1)   Escribe un programa que genere un número
            *   aleatorio entre 1 y 100 y le pida al usuario 
            *   que adivine el número. El programa debe dar 
            *   pistas al usuario (mayor que, menor que, igual) 
            *   hasta que logre adivinar el número correcto.
    
    */
    static void numero_random()
        /// ejercicio = realizar un menu de opciones 
        /// pasos que vamos a utilizar son :
        /// paso 1= generar el numer 
        /// paso 2= pedir que igrese un numero al usuario
        /// paso 3= guardar el numero por el usuario
        /// paso 4= conparat si el numero es = al numero del usuario 
        /// paso 5= si el numero es igual ahi queda 
        /// paso 6= comparar si el numero es mayor o menor que  el numero areatoriamente 
        /// paso 7= si es menor imprimir por consola debe ser un numero mayor 
        /// paso 8= sio el es mayor debe imprimir  un numero menor 
        /// paso 9= se repite del paso 4 hasta que que el usuario cumpla
    {
        // Método para generar un número aleatorio entre 1 y 100
        int generanumero()
        {
            Random random = new Random();
            return random.Next(1, 101); // Genera un número entre 1 y 100
        }

        // Método que simula un juego de adivinar el número
        void adivinarnumero()
        {
            int intento;      //numero ingresado
            int numero_secreto = generanumero(); // Genera el número secreto
            bool adivinar = false;  //inicializar en false para que una vez q se adivina se true y salga del programa

            Console.WriteLine("-----Adivina un número entre 1 y 100-----");  //instrucción

            while (!adivinar)  //ciclo while, mientras no se adivina no va a salir del programa
            {
                Console.Write("Ingrese un número entre 1 y 100: ");
                intento = int.Parse(Console.ReadLine());   //Pedir un número al usuario

                //Verificar la condiciones para imprimir el resultado
                if (intento > numero_secreto)
                {
                    Console.WriteLine($"El número secreto es menor que {intento}. Intenta de nuevo");
                }
                else if (intento < numero_secreto)
                {
                    Console.WriteLine($"El número secreto es mayor que {intento}. Intenta de nuevo");
                }
                else
                {
                    Console.WriteLine("¡Adivinaste el número!");
                    adivinar = true;
                }
            }
        }
        // Llamamos a la función que ejecuta el juego de adivinar el número
        adivinarnumero();
    }


    //  2)  Escribe un programa que pida la edad del usuario y determine si puede votar (mayor o igual a 18 años)
    static void edad_votar()
    {
        Console.Write("Ingresa tu edad: ");     //Mensaje de instruccion
        int edad = int.Parse(Console.ReadLine());   // Pedir al usuario su edad

        // Comprobar la condición y ver si puede votar
        if (edad >= 18)
        {
            Console.WriteLine("Puedes votar");
        }
        else
        {
            Console.WriteLine("No puedes votar");
        }
    }


    /*  3)  Escribe un programa que convierta una calificación numérica (0-100) en una letra según el siguiente criterio:
                90-100: A
                80-89: B
                70-79: C
                60-69: D
                0-59: F
    */
    static void Convertir_calif()
    {
        // Pedir al usuario que ingrese la calificación
        Console.Write("Ingresa la calificación (0-100): ");
        int calificacion = int.Parse(Console.ReadLine());

        // Verificar la condición e imprimir la letra correspondiente a la calificación
        if (calificacion >= 90 && calificacion <= 100)
        {
            Console.WriteLine("Tu calificación es: A");
        }
        else if (calificacion >= 80 && calificacion < 90)
        {
            Console.WriteLine("Tu calificación es: B");
        }
        else if (calificacion >= 70 && calificacion < 80)
        {
            Console.WriteLine("Tu calificación es: C");
        }
        else if (calificacion >= 60 && calificacion < 70)
        {
            Console.WriteLine("Tu calificación es: D");
        }
        else if (calificacion >= 0 && calificacion < 60)
        {
            Console.WriteLine("Tu calificación es: F");
        }
        else
        {
            Console.WriteLine("Calificación no válida. Debe estar entre 0 y 100");
        }
    }


    //  4)  Pide al usuario un número entero y determina si es par o impar
    static void par_impar()
    {
        try
        {
            // Pedir al usuario que ingrese un número entero
            Console.Write("Ingresa un número entero: ");
            int numero = int.Parse(Console.ReadLine());

            // Verificar la condición para determinar si el número es par o impar
            if (numero % 2 == 0)
            {
                Console.WriteLine($"El número {numero} es par");
            }
            else
            {
                Console.WriteLine($"El número {numero} es impar");
            }
        }
        catch (FormatException)
        {
            // Mensaje si el usuario no ingresa un número entero
            Console.WriteLine("Error _ Ingresa un número entero");
        }
    }

    //  5)  Escribe un programa que pida dos números al usuario y determine cuál es el mayor
    static void mayor_menor()
    {
        try
        {
            // Pedir el primer número
            Console.Write("Ingresa el primer número: ");
            int numero1 = int.Parse(Console.ReadLine());

            // Pedir el segundo número
            Console.Write("Ingresa el segundo número: ");
            int numero2 = int.Parse(Console.ReadLine());

            // Comparar los números y determinar cuál es mayor
            if (numero1 > numero2)
            {
                Console.WriteLine($"El número mayor es: {numero1}");
            }
            else if (numero2 > numero1)
            {
                Console.WriteLine($"El número mayor es: {numero2}");
            }
            else
            {
                Console.WriteLine("Los números son iguales.");
            }
        }
        catch (FormatException)
        {
            // Mensaje si el usuario no ingresa números enteros
            Console.WriteLine("Error...Debes ingresar números enteros");
        }
    }


    /*  6)  Escribe un programa que solicite al usuario su edad y determine 
            si tiene la edad suficiente para votar utilizando sentencias if. 
            El programa debe mostrar un mensaje indicando si el usuario puede votar o no.
    */
    static void determinar_votar()
    {
        Console.Write("Ingresa tu edad: ");     //Mensaje de instruccion
        int edad = int.Parse(Console.ReadLine());   // Pedir al usuario su edad

        /*  En Ecuador
            El voto es obligatorio para personas de 18 hasta 64 años. 
            
            El voto facultativo, es decir que no es obligatorio, 
            es para los jóvenes de entre 16 y 17 años de edad. 
            Las personas de 65 años o más también tienen el voto facultativo
        */

        // Comprobar la condición y determinar si tiene la edad suficiente para votar
        if (edad < 0)
        {
            Console.WriteLine("Ingresa una edad válida");
        }
        else if (edad < 16)
        {
            Console.WriteLine("No tienes la suficiente edad para votar");
        }
        else if (edad >= 16 && edad <= 17)
        {
            Console.WriteLine("Puedes votar, pero tu voto es opcional");
        }
        else if (edad >= 18 && edad <= 64)
        {
            Console.WriteLine("Puedes votar y tu voto es obligatorio");
        }
        else
        {
            Console.WriteLine("Puedes votar, pero tu voto es opcional");
        }
    }


    /*  7)  Escribe un programa que solicite al usuario un número que represente un día de la semana 
            (1 para lunes, 2 para martes, etc.) y muestre el nombre completo del día correspondiente 
            utilizando la sentencia switch.
    */
    static void Mostrar_dia_semana()
    {
        while (true) // Bucle que continuará hasta que se ingrese un número válido
        {
            try
            {
                Console.Write("Ingrese un número del 1 al 7: ");    // Pedir al usuario un número
                int dia = int.Parse(Console.ReadLine());            // Convertir la entrada del usuario a un entero

                if (dia >= 1 && dia <= 7)    // Verificar si el número está en el rango correcto (1 a 7)
                {
                    // Usamos switch para mostrar el día correspondiente
                    switch (dia)
                    {
                        case 1: Console.WriteLine("Lunes"); break;
                        case 2: Console.WriteLine("Martes"); break;
                        case 3: Console.WriteLine("Miércoles"); break;
                        case 4: Console.WriteLine("Jueves"); break;
                        case 5: Console.WriteLine("Viernes"); break;
                        case 6: Console.WriteLine("Sábado"); break;
                        case 7: Console.WriteLine("Domingo"); break;
                    }
                    break; // Sale del bucle si el número es válido
                }
                else
                {
                    Console.WriteLine("Número fuera de rango. Ingrese un número del 1 al 7.");  // Si el número está fuera del rango, se muestra un error y se vuelve a pedir
                }
            }
            catch (FormatException)
            {
                // Si ocurre un error en la entrada dará error
                Console.WriteLine("Entrada no válida. Intente nuevamente.");
            }
        }
    }

    static void calificacion()
    {
        try
        {
            // Pedir al usuario una calificación
            Console.Write("Ingresa tu calificación (0-100): ");
            int calificacion = int.Parse(Console.ReadLine());

            // Validar que la calificación esté dentro del rango permitido
            if (calificacion < 0  ||  calificacion > 100)
            {
                Console.WriteLine("Error... La calificación debe estar entre 0 y 100.");
                return;
            }

            // Determinar la letra equivalente usando switch
            switch (calificacion / 10)  //La calificación se divide entre 10 para determinar su decena
            {
                case 10: // Para 100
                case 9:  // Para 90-99
                    Console.WriteLine("Tu calificación es: A");
                    break;
                case 8:  // Para 80-89
                    Console.WriteLine("Tu calificación es: B");
                    break;
                case 7:  // Para 70-79
                    Console.WriteLine("Tu calificación es: C");
                    break;
                case 6:  // Para 60-69
                    Console.WriteLine("Tu calificación es: D");
                    break;
                default: // Para 0-59
                    Console.WriteLine("Tu calificación es: F");
                    break;
            }
        }
        catch (FormatException)
        {
            // Mostar erros si la entrada no es válidad
            Console.WriteLine("Error... Ingresa un número válido");
        }
    }
}