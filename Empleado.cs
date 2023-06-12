//1 . Crear una clase para almacenar la siguiente información: una clase Empleado con
// los siguientes atributos:
// a. Nombre (string), Apellido (string), Fecha de nacimiento (datetime),
// Estado civil (char), Género (char), fecha de ingreso en la empresa
// (datetime), sueldo Básico (double), Cargo (cargos)
// b. La enumeración cargos con los siguientes elementos: Auxiliar;
// Administrativo; Ingeniero; Especialista; Investigador. (investigue enum
// en c# para realizar esto)

// 2. Cree los métodos necesarios para poder obtener los datos que se detallan a
// continuación:

// a. Calcular lo siguiente:
//          i. La antigüedad del empleado en la empresa.
//          ii. La edad del empleado,
//          iii. La cantidad de años que le falta al empleado para poder
//          jubilarse (para la mujer la edad es 60 años, para el varón es 65 años).

// b. Calcular el salario, de acuerdo a la fórmula: Salario = Sueldo Básico +
// Adicional. Para ello el Adicional contempla la antigüedad en años, el
// cargo y si es casado:
//          i) 1 % del sueldo básico por cada año de antigüedad hasta los
//          20 años, a partir de este, el porcentaje se fija en 25%.
//          ii) Si el cargo es Ingeniero o Especialista, el Adicional se
//          incrementa en un 50%.
//          iii) Si es casado al Adicional se le aumenta $15000.
//          Por ejemplo, si la antigüedad es de 15 años y el Sueldo Básico =
//          $65000, el Adicional es 65000 * 0.15 = 9750. Si además el cargo
//          es Ingeniero o Especialista, se incrementa el Adicional en un
//          50%. Esto es: 9750* 1.50 = 14625. Si a su vez es casado el
//          Adicional será: 14625+ 15000= 29625

//          c. Cargue los datos para 3 empleados.
//          d. Obtener el Monto Total de lo que se paga en concepto de Salarios.
//          e. Muestre por pantalla los datos del empleado que esté más próximo a
//          jubilarse (incluyendo los datos del apartado 2.a y el salario
//          correspondiente.

namespace DatosEmpleado
{
    public class Empleado
    {
        public string nombre;
        public string apellido;
        public DateTime fechaNacimiento;
        public char estadoCivil;
        public char genero;
        public DateTime fechaIngresoEmpresa;
        public double sueldoBasico;
        public enum cargos
        {
            auxiliar,
            administrativo,
            ingeniero,
            especialista,
            investigador
        }
        public cargos cargo;
        public int antiguedad()
        {
            DateTime hoy = DateTime.Today;
            return (hoy.Subtract(fechaIngresoEmpresa).Days / 365);
        }
        public int edad()
        {
            DateTime hoy = DateTime.Today;
            return (hoy.Subtract(fechaNacimiento).Days / 365);
        }
        public int añosFaltantesParaJubilacion()
        {
            if (genero == 'M' || genero == 'm')
            {
                return 65 - edad();
            }
            else if (genero == 'F' || genero == 'f')
            {
                return 60 - edad();
            }
            else
            {
                return -9999;
            }
        }
        // b. Calcular el salario, de acuerdo a la fórmula: Salario = Sueldo Básico +
        // Adicional. Para ello el Adicional contempla la antigüedad en años, el
        // cargo y si es casado:
        //          i) 1 % del sueldo básico por cada año de antigüedad hasta los
        //          20 años, a partir de este, el porcentaje se fija en 25%.
        //          ii) Si el cargo es Ingeniero o Especialista, el Adicional se
        //          incrementa en un 50%.
        //          iii) Si es casado al Adicional se le aumenta $15000.
        //          Por ejemplo, si la antigüedad es de 15 años y el Sueldo Básico =
        //          $65000, el Adicional es 65000 * 0.15 = 9750. Si además el cargo
        //          es Ingeniero o Especialista, se incrementa el Adicional en un
        //          50%. Esto es: 9750* 1.50 = 14625. Si a su vez es casado el
        //          Adicional será: 14625+ 15000= 29625

        public double calcularAdicional()
        {
            double adicional = 0.0;
            if (antiguedad() <= 20)
            {
                adicional = 0.01 * antiguedad();
            }
            if (antiguedad() > 20)
            {
                adicional = 0.25 * antiguedad();
            }
            if (cargo == cargos.ingeniero || cargo == cargos.especialista)
            {
                adicional = adicional + (adicional * 0.5);
            }
            if (estadoCivil == 'c')
            {
                adicional = adicional + 15000;
            }
            return adicional;
        }
        public double salario()
        {
            return sueldoBasico + calcularAdicional();
        }
    }
}