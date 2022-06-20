using Daily_Enigma.Models;
using Daily_Enigma.ViewModels;
using Daily_Enigma.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Daily_Enigma.Views
{
    public partial class EnigmaPage : ContentPage
    {
        EnigmaViewModel _viewModel;

        public EnigmaPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new EnigmaViewModel();
        }

        private void RandomEnigma()
        {
            var enigmas = new List<string>()
            {
                "My first is the main color of the earth, my second can be used to move, my third is for surviving. My everything is a liquid. What is that ?",
                "Very childish, I can introduce children to programming. What is my name ?",
            };

        }
    }
}