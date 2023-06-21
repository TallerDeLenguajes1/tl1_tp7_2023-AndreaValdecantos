namespace grupoEmpleados
{
    public class Empleados
    {
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public DateTime FechaDeNacimiento { get; set; }
        public char EstadoCivil { get; set; }
        public char Genero { get; set; }
        public DateTime FechaIngresoALaEmpresa { get; set; }
        public double SueldoBasico { get; set; }
        internal Cargos Cargo { get; set; }

        public int Antiguedad(){
            TimeSpan antiguedad = DateTime.Now - FechaIngresoALaEmpresa;
            return (int)(antiguedad.TotalDays/365);
        }
        public int Edad(){
            TimeSpan edad = DateTime.Now - FechaDeNacimiento;
            return (int)(edad.TotalDays/365);
        }
        public int Jubilacion(){
            int aniosFaltantes;
            if (Genero == 'f' || Genero == 'F')
            {
                aniosFaltantes = 60 - Edad();
            } else if(Genero == 'm' || Genero == 'M'){
                aniosFaltantes = 65 - Edad();
            } else {
                aniosFaltantes = 0;
            }
            return aniosFaltantes;
        }
        public double CalcularSalario(){
            double adicional;
            if (Antiguedad() <= 20)
            {
                adicional = (SueldoBasico*0.01)*Antiguedad();
            } else {
                adicional = (SueldoBasico*0.25)*Antiguedad();
            }

            if (Cargo.ToString() == "Ingeniero" || Cargo.ToString() == "Especialista")
            {
                adicional = adicional + (adicional*0.5);
            }
            if (EstadoCivil == 'c')
            {
                adicional = adicional + 15000;
            }
            
            return SueldoBasico + adicional;
        }
    }
}