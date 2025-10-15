using IMC.Model;

namespace IMC.GUI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            LimpiarInformacion();
        }

        private void OnCalcularButtonClicked(object sender, EventArgs e)
        {
            decimal peso = Convert.ToDecimal(PesoEntry.Text);
            decimal estatura = Convert.ToDecimal(EstaturaEntry.Text);
            decimal IMC = IndiceDeMasaCorporalLib.IndiceDeMasaCorporal(peso, estatura);
            ImcLable.Text = IMC.ToString("G6");
            SituacionNutricionalLabel.Text = IndiceDeMasaCorporalLib.DeterminaEstadoNutricional(IMC);
        }

        private void OnLimpiarButtonClicked(object sender, EventArgs e)
        {
            LimpiarInformacion();

        }
        private void LimpiarInformacion(object sender, EventArgs)
        {
            PesoEntry.Text = string.Empty;
            EstaturaEntry.Text = string.Empty;
            ImcLabel.Text = string.Empty;
            SituacionNutricionalLabel.Text = string.Empty;
        }
      

    }
}

