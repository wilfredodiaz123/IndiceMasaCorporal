using System;
using System.Globalization;

//01. Declarar los variables
Console.WriteLine("=====================================");
Console.WriteLine("    Calculadora de Índice de Masa Corporal (IMC)");
Console.WriteLine("=====================================");

double peso;
double estatura;
double imc;
string entrada;

//02. Obtener Peso
Console.Write("Ingrese su peso en kilogramos (ej: 75.5): ");
entrada = Console.ReadLine();

// Validar si numero (entrada)es correcto para Peso
while (!double.TryParse(entrada, NumberStyles.Any, CultureInfo.InvariantCulture, out peso) || peso <= 0)
{
    Console.WriteLine("Error: Ingresastes mal tu peso.");
    Console.Write("Ingrese su peso en kilogramos (ej: 75.5): ");
    entrada = Console.ReadLine();
}

//03. Obtener Estatura 
Console.Write("Ingrese su estatura en metros (ej: 1.70): ");
entrada = Console.ReadLine();

// Validar numero (entrada)si es correcto para Estatura
while (!double.TryParse(entrada, NumberStyles.Any, CultureInfo.InvariantCulture, out estatura) || estatura <= 0)
{
    Console.WriteLine("Error: No ingresastes bien tu estatura.");
    Console.Write("Ingrese su estatura en metros (ej: 1.70): ");
    entrada = Console.ReadLine();
}

//04. Calcular IMC
// Fórmula: peso / estatura²
imc = peso / (estatura * estatura); 

//05. Determinar Estado Nutricional (Estructuras con if-else)
string estadoNutricional;

if (imc < 18.5)
{
    estadoNutricional = "Peso bajo";
}
else if (imc < 25.0)
{
    estadoNutricional = "Peso normal";
}
else if (imc < 30.0)
{
    estadoNutricional = "Sobrepeso";
}
else if (imc < 40.0)
{
    estadoNutricional = "Obesidad";
}
else
{
    estadoNutricional = "Obesidad extrema";
}

// 6. Mostrar Resultados
Console.WriteLine("\n-- Resultados: -");
Console.WriteLine($"Peso: {peso:F2} kg");
Console.WriteLine($"Estatura: {estatura:F2} m");
Console.WriteLine($"Índice de Masa Corporal (IMC): {imc:F4} kg/m²");
Console.WriteLine($"Estado Nutricional: {estadoNutricional}");
Console.WriteLine("-----------------\n");