﻿using Daily_Enigma.Models;
using Daily_Enigma.ViewModels;
using Daily_Enigma.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}