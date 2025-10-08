namespace IMC.GUI
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            PesoEntry.Text = string.Empty;
            EstaturaEntry.Text = string.Empty;
            ImcLabel.Text = string.Empty;
            SituacionNutricionalLabel.Text = string.Empty
        }

        private void OnCalcularButtonClicked(object sender, EventArgs e)
        {
            decimal peso = Convert.ToDecimal(PesoEntry.Text);
            decimal estatura = Convert.ToDecimal(EstaturaEntry.Text);
            decimal IMC = peso / (estatura * estatura);
            ImcLabel.Text = IMC.ToString("G6");
            SituacionNutricionalLabel.Text = DeterminaEstadoNutricional(IMC);
        }

        private void OnLimpiarButtonClicked(object sender, EventArgs e)
        {
            PesoEntry.Text = string.Empty;
            EstaturaEntry.Text = string.Empty;
            ImcLabel.Text = string.Empty;
            SituacionNutricionalLabel.Text = string.Empty
        }
        private decimal IndiceMasaCorporal (decimal peso, decimal estatura)
        {
            return peso / (estatura * estatura);
        }
        
        private string DeterminaEstadoNutricional (decimal IMC)
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

