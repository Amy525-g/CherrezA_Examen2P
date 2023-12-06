using Microsoft.Maui;

namespace CherrezA_Examen2P.Views;

public partial class AC_ConteoPage : ContentPage
{
	public AC_ConteoPage()
	{
		InitializeComponent();
	}
    private void CalcularEstadisticas(string input)
    {
        int totalCaracteres = input.Length;
        int totalNumeros = 0;
        int totalLetras = 0;
        int totalVocales = 0;
        int totalMayusculas = 0;
        int totalMinusculas = 0;

        foreach (char caracter in input)
        {
            if (char.IsDigit(caracter))
            {
                totalNumeros++;
            }
            else if (char.IsLetter(caracter))
            {
                totalLetras++;
                if ("aeiouAEIOU".Contains(caracter))
                {
                    totalVocales++;
                }

                if (char.IsUpper(caracter))
                {
                    totalMayusculas++;
                }
                else if (char.IsLower(caracter))
                {
                    totalMinusculas++;
                }
            }
        }

        // Actualizar etiquetas en la interfaz con los resultados
        lblTotal.Text = $"Total de caracteres: {totalCaracteres}";
        lblNumeros.Text = $"Números: {totalNumeros}";
        lblLetras.Text = $"Letras: {totalLetras}";
        lblVocales.Text = $"Vocales: {totalVocales}";
        lblMayusculas.Text = $"Mayúsculas: {totalMayusculas}";
        lblMinusculas.Text = $"Minúsculas: {totalMinusculas}";
    }

    private void LimpiarPantalla()
    {
        // Limpiar etiquetas en la interfaz
        lblTotal.Text = string.Empty;
        lblNumeros.Text = string.Empty;
        lblLetras.Text = string.Empty;
        lblVocales.Text = string.Empty;
        lblMayusculas.Text = string.Empty;
        lblMinusculas.Text = string.Empty;

        // Limpiar entrada de texto
        txtInput.Text = string.Empty;
    }

    private void BtnCalcular_Clicked(object sender, EventArgs e)
    {
        string input = txtInput.Text;
        CalcularEstadisticas(input);
    }

    private void BtnLimpiar_Clicked(object sender, EventArgs e)
    {
        LimpiarPantalla();
    }
}

