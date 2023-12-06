using System;
using Microsoft.Maui.Controls;

namespace Guerrero_AppEvaluacion.DG_Views
{
    public partial class DG_Conteo : ContentPage
    {
        public DG_Conteo()
        {
            InitializeComponent();
            BindingContext = new ConteoViewModel();
        }
        private void DG_CalcularButton_Clicked(object sender, EventArgs e)
        {
            ConteoViewModel viewModel = (ConteoViewModel)BindingContext;
            string texto = viewModel.DG_Text;
            viewModel.DG_Numeros = DG_ContarNumeros(texto).ToString();
            viewModel.DG_Letras = DG_ContarLetras(texto).ToString();
            viewModel.DG_Vocales = DG_ContarVocales(texto).ToString();
            viewModel.DG_Mayusculas = DG_ContarMayusculas(texto).ToString();
            viewModel.DG_Minusculas = DG_ContarMinusculas(texto).ToString();
            viewModel.DG_Total = texto.Length.ToString();
        }
        private void DG_LimpiarButton_Clicked(object sender, EventArgs e)
        {
            ConteoViewModel viewModel = (ConteoViewModel)BindingContext;
            viewModel.DG_Text = string.Empty;
            viewModel.DG_Numeros = string.Empty;
            viewModel.DG_Letras = string.Empty;
            viewModel.DG_Vocales = string.Empty;
            viewModel.DG_Mayusculas = string.Empty;
            viewModel.DG_Minusculas = string.Empty;
            viewModel.DG_Total = string.Empty;
        }
        private int DG_ContarNumeros(string texto)
        {
            return texto.Count(char.IsDigit);

        }
        private int DG_ContarLetras(string texto)
        {
            return texto.Count(char.IsLetter);
        }
        private int DG_ContarVocales(string texto)
        {
            return texto.Count(c => "AEIOUaeiou".Contains(c));
        }
        private int DG_ContarMayusculas(string texto)
        {
            return texto.Count(char.IsUpper);
        }
        private int DG_ContarMinusculas(string texto)
        {
            return texto.Count(char.IsLower);
        }
    }
    public class ConteoViewModel : BindableObject
    {
        private string _DG_Text;
        private string _DG_Numeros;
        private string _DG_Letras;
        private string _DG_Vocales;
        private string _DG_Mayusculas;
        private string _DG_Minusculas;
        private string _DG_Total;
        public string DG_Text
        {
            get { return _DG_Text; }
            set
            {
                if (_DG_Text != value)
                {
                    _DG_Text = value;
                    OnPropertyChanged(nameof(DG_Text));
                }
            }
        }
        public string DG_Numeros
        {
            get { return _DG_Numeros; }
            set
            {
                if (_DG_Numeros != value)
                {
                    _DG_Numeros = value;
                    OnPropertyChanged(nameof(DG_Numeros));
                }
            }
        }
        public string DG_Letras
        {
            get { return _DG_Letras; }
            set
            {
                if (_DG_Letras != value)
                {
                    _DG_Letras = value;
                    OnPropertyChanged(nameof(DG_Letras));
                }
            }
        }
        public string DG_Vocales
        {
            get { return _DG_Vocales; }
            set
            {
                if (_DG_Vocales != value)
                {
                    _DG_Vocales = value;
                    OnPropertyChanged(nameof(DG_Vocales));
                }
            }
        }
        public string DG_Mayusculas
        {
            get { return _DG_Mayusculas; }
            set
            {
                if (_DG_Mayusculas != value)
                {
                    _DG_Mayusculas = value;
                    OnPropertyChanged(nameof(DG_Mayusculas));
                }
            }
        }
        public string DG_Minusculas
        {
            get { return _DG_Minusculas; }
            set
            {
                if (_DG_Minusculas != value)
                {
                    _DG_Minusculas = value;
                    OnPropertyChanged(nameof(DG_Minusculas));
                }
            }
        }
        public string DG_Total
        {
            get { return _DG_Total; }
            set
            {
                if (_DG_Total != value)
                {
                    _DG_Total = value;
                    OnPropertyChanged(nameof(DG_Total));
                }
            }
        }
    }
}
