Console.WriteLine("!Ingrese su nombre!: ");
String NombreEmpleado = Console.ReadLine();
Console.WriteLine("!Ingrese su salario por hora!: ");
decimal SalarioHora = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("!Ingrese la cantidad de horas trabajadas!: ");
decimal HorasTrabajadas = Convert.ToDecimal(Console.ReadLine());

static decimal SalarioBruto(decimal SalarioHora, decimal HorasTrabajadas)
{
    return SalarioHora * HorasTrabajadas;
}

decimal salarioBruto = SalarioBruto(SalarioHora, HorasTrabajadas);
Console.WriteLine($@"
El salario bruto de :        {NombreEmpleado} 
es:                          {salarioBruto} 
y las horas trabajadas son : {HorasTrabajadas}");