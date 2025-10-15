namespace IMC.Model
{
    public static class IndiceDeMasaCorporalLib
    {
        public static decimal IndiceMasaCorporal(decimal peso, decimal estatura)
        {
            return peso / (estatura * estatura);
        }

        public static string DeterminaEstadoNutricional(decimal IMC)
        {
            if (IMC < 18.5m)
            {
                return "Peso Bajo";
            }
            if (IMC < 25.00m)
            {
                return "Peso Normal";
            }
            if (IMC < 30.00m)
            {
                return "Sobrepeso";
            }
            if (IMC < 40.00m)
            {
                return "Obesidad";
            }
            else
            {
                return "Obesidad Extrema";
            }
        }
    }
}
