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
        
        public void RandomEnigma(object sender, EventArgs e)
        {
            var enigmas = new List<string>()
            {
                "My first is the main color of the earth, my second can be used to move, my third is for surviving. My everything is a liquid. What is that ?",
                "Very childish, I can introduce children to programming. What is my name ?",
                "I'm famous by it's revolutionary product and I am also a fruit, what am I?",
                "",
                "",
                "",
                "",
            };
            int range = enigmas.Count;

            Random rnd = new Random();
            int number = rnd.Next(0, range - 7);  // creates a number between 0 and range-1

            Label_Enigma.Text = enigmas[number];
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string checkAnswer = Label_Answer.Text;

            if (checkAnswer == "Water")
            {
                if (Label_Enigma.Text == "My first is the main color of the earth, my second can be used to move, my third is for surviving. My everything is a liquid. What is that ?")
                {
                    DisplayAlert("Congratulation!", "You solved the enigma of the day!\n\nCome back tomorrow!", "OK");
                }
                else
                {
                    return;
                }
            }
            else if (checkAnswer == "Scratch")
            {
                if (Label_Enigma.Text == "Very childish, I can introduce children to programming. What is my name ?")
                {
                    DisplayAlert("Congratulation!", "You solved the enigma of the day!\n\nCome back tomorrow!", "OK");
                }
                else
                {
                    return;
                }
            }
            else if (checkAnswer == "Apple")
            {
                if (Label_Enigma.Text == "I'm famous by it's revolutionary product and I am also a fruit, what am I?")
                {
                    DisplayAlert("Congratulation!", "You solved the enigma of the day!\n\nCome back tomorrow!", "OK");
                }
                else
                {
                    return;
                }
            }
            else
            {
                if (Label_Answer.Text == "")
                {
                    DisplayAlert("Error", "Please enter an answer", "OK");
                }
                else
                {
                    DisplayAlert("Try Again!", "This is not the correct answer...\n\nTry again or wait tomorrow.", "OK");
                }
            }
        }
    }
}