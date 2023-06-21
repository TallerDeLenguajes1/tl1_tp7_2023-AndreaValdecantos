// using EspacioCalculadora;

// string opcion;
// double termino = 0.0;
// string numeroIngresado;

// Calculadora calculadora = new Calculadora();

// void mostrarMenu()
// {
//     Console.WriteLine("_________________");
//     Console.WriteLine("1_ SUMAR");
//     Console.WriteLine("2_ RESTAR");
//     Console.WriteLine("3_ MULTIPLICAR");
//     Console.WriteLine("4_ DIVIDIR");
//     Console.WriteLine("5_ LIMPIAR");
//     Console.WriteLine("0_ SALIR");
//     Console.WriteLine("_________________");
// }
// string solicitarOpcion()
// {
//     Console.Write("Ingrese una opción: ");
//     string opcion = Console.ReadLine();
//     return opcion;
// }
// string solicitarNumero()
// {
//     Console.Write("Ingrese un número: ");
//     string numeroIngresado = Console.ReadLine();
//     return numeroIngresado;
// }
// void mostrarResultado()
// {
//     Console.WriteLine("---------------\nRESULTADO: " + calculadora.resultado + "\n---------------");
// }

// do
// {
//     mostrarMenu();
//     opcion = solicitarOpcion();

//     if (opcion == "0")
//     {
//         Console.WriteLine("FIN DEL PROGRAMA");
//     }
//     else if (opcion == "5")
//     {
//         calculadora.Limpiar();
//         mostrarResultado();
//     }
//     else
//     {
//         numeroIngresado = solicitarNumero();
//         if (double.TryParse(numeroIngresado, out termino))
//         {
//             switch (opcion)
//             {
//                 case "1":
//                     calculadora.Sumar(termino);
//                     mostrarResultado();
//                     break;
//                 case "2":
//                     calculadora.Restar(termino);
//                     mostrarResultado();
//                     break;
//                 case "3":
//                     calculadora.Multiplicar(termino);
//                     mostrarResultado();
//                     break;
//                 case "4":
//                     calculadora.Dividir(termino);
//                     mostrarResultado();
//                     break;
//                 default:
//                     Console.WriteLine("La opción no es válida");
//                     break;
//             }
//         }
//     }
// } while (opcion != "0");

// c. Cargue los datos para 3 empleados.
// d. Obtener el Monto Total de lo que se paga en concepto de Salarios.
// e. Muestre por pantalla los datos del empleado que esté más próximo a
// jubilarse (incluyendo los datos del apartado 2.a y el salario
// correspondiente

using grupoEmpleados;

Empleados empleadoUno;
empleadoUno = new Empleados();

Empleados empleadoDos;
empleadoDos = new Empleados();

Empleados empleadoTres;
empleadoTres = new Empleados();

empleadoUno.Nombre = "Juan";
empleadoUno.Apellido = "Ledesma";
empleadoUno.FechaDeNacimiento = new DateTime(1990,2,15);
empleadoUno.EstadoCivil = 'c';
empleadoUno.Genero = 'm';
empleadoUno.FechaIngresoALaEmpresa = new DateTime(2008,1,1);
empleadoUno.SueldoBasico = 65000;
empleadoUno.Cargo = Cargos.Ingeniero;

empleadoDos.Nombre = "Juana";
empleadoDos.Apellido = "Torres";
empleadoDos.FechaDeNacimiento = new DateTime(1993,5,20);
empleadoDos.EstadoCivil = 's';
empleadoDos.Genero = 'f';
empleadoDos.FechaIngresoALaEmpresa = new DateTime(2015,1,1);
empleadoDos.SueldoBasico = 50000;
empleadoDos.Cargo = Cargos.Investigador;

empleadoTres.Nombre = "Lucas";
empleadoTres.Apellido = "Gómez";
empleadoTres.FechaDeNacimiento = new DateTime(1985,2,15);
empleadoTres.EstadoCivil = 'c';
empleadoTres.Genero = 'm';
empleadoTres.FechaIngresoALaEmpresa = new DateTime(2000,1,1);
empleadoTres.SueldoBasico = 55000;
empleadoTres.Cargo = Cargos.Especialista;

double totalSalarios = empleadoUno.CalcularSalario() + empleadoDos.CalcularSalario() + empleadoTres.CalcularSalario();

Console.WriteLine($"\nMONTO TOTAL DE SALARIOS A PAGAR: ${totalSalarios}");

Empleados calcularEmpleadoMasProximoAJubilarse(Empleados empleadoUno, Empleados Dos, Empleados empleadoTres){
    Empleados empleado;

    if (empleadoUno.Jubilacion() < empleadoDos.Jubilacion() && empleadoUno.Jubilacion() < empleadoTres.Jubilacion())
    {
        empleado = empleadoUno;
    } else if (empleadoDos.Jubilacion() < empleadoUno.Jubilacion() && empleadoDos.Jubilacion() < empleadoTres.Jubilacion())
    {
        empleado = empleadoDos;
    } else {
        empleado = empleadoTres;
    }

    return empleado;
}

Empleados empleadoMasProximoAJubilarse = calcularEmpleadoMasProximoAJubilarse(empleadoUno, empleadoDos, empleadoTres);

Console.WriteLine($"\nJubilacion 1: {empleadoUno.Jubilacion()}\nJubilacion 2: {empleadoDos.Jubilacion()}\nJubilacion 3: {empleadoTres.Jubilacion()}");

Console.WriteLine($"\n\nEmpleado más próximo a jubilarse: {empleadoMasProximoAJubilarse.Nombre} {empleadoMasProximoAJubilarse.Apellido}\nAntiguedad en la empresa: {empleadoMasProximoAJubilarse.Antiguedad()}\nEdad: {empleadoMasProximoAJubilarse.Edad()}\nCantidad de años para la jubilación: {empleadoMasProximoAJubilarse.Jubilacion()}\nSalario: ${empleadoMasProximoAJubilarse.CalcularSalario()}");