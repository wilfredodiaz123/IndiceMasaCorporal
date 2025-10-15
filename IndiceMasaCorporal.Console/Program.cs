using IMC.Model;

Console.WriteLine("Aplicación que calcula el indice de masa corporal de una persona\n");

decimal peso =
    ReadDecimal("Proporcion el peso en kilogramos de la persona: ");

decimal estatura =
    ReadDecimal("Proporcion la estatura en metros de la persona: ");

decimal imc = IndiceDeMasaCorporalLib.IndiceMasaCorporal(peso, estatura);

Console.WriteLine(
    $"El índice de masa coporal de la persona es: {imc:G6}");
Console.WriteLine(
    $"El estado nutricional de la persona es: {IndiceDeMasaCorporalLib.DeterminaEstadoNutricional(imc)}");

Console.WriteLine();

static decimal ReadDecimal(string indicacion)
{
    Console.Write(indicacion);
    var entradaComoTexto = Console.ReadLine();
    return Convert.ToDecimal(entradaComoTexto);
}