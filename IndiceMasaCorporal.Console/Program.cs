using System;
using System.Globalization;

// --- 1. Declarar variables y Títulos ---
Console.WriteLine("=====================================");
Console.WriteLine("    Calculadora de Índice de Masa Corporal (IMC)");
Console.WriteLine("=====================================");

double peso;
double estatura;
double imc;
string entrada;

// --- 2. Obtener Peso ---
Console.Write("Ingrese su peso en kilogramos (ej: 75.5): ");
entrada = Console.ReadLine();

// Validar entrada para Peso
while (!double.TryParse(entrada, NumberStyles.Any, CultureInfo.InvariantCulture, out peso) || peso <= 0)
{
    Console.WriteLine("Error: Ingrese un número positivo válido para el peso.");
    Console.Write("Ingrese su peso en kilogramos (ej: 75.5): ");
    entrada = Console.ReadLine();
}

// --- 3. Obtener Estatura ---
Console.Write("Ingrese su estatura en metros (ej: 1.70): ");
entrada = Console.ReadLine();

// Validar entrada para Estatura
while (!double.TryParse(entrada, NumberStyles.Any, CultureInfo.InvariantCulture, out estatura) || estatura <= 0)
{
    Console.WriteLine("Error: Ingrese un número positivo válido para la estatura.");
    Console.Write("Ingrese su estatura en metros (ej: 1.70): ");
    entrada = Console.ReadLine();
}

// --- 4. Calcular IMC ---
// Fórmula: peso / estatura²
imc = peso / (estatura * estatura); 

// --- 5. Determinar Estado Nutricional (Estructura Condicional) ---
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

// --- 6. Mostrar Resultados ---
Console.WriteLine("\n--- Resultado ---");
Console.WriteLine($"Peso: {peso:F2} kg");
Console.WriteLine($"Estatura: {estatura:F2} m");
Console.WriteLine($"Índice de Masa Corporal (IMC): {imc:F4} kg/m²");
Console.WriteLine($"Estado Nutricional: {estadoNutricional}");
Console.WriteLine("-----------------\n");