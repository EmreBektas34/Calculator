using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calculator
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Del_Clicked(object sender, EventArgs e)
        {
            EntryValue.Text = "";
        }

        private void Plus_Clicked(object sender, EventArgs e)
        {
            EntryValue.Text += Plus.Text;
        }

        private void Minus_Clicked(object sender, EventArgs e)
        {
            EntryValue.Text += Minus.Text;
        }

        private void Cross_Clicked(object sender, EventArgs e)
        {
            EntryValue.Text += Cross.Text;
        }

        private void Slash_Clicked(object sender, EventArgs e)
        {
            EntryValue.Text += Slash.Text;
        }

        private void Seven_Clicked(object sender, EventArgs e)
        {
            EntryValue.Text += Seven.Text;
        }

        private void Eight_Clicked(object sender, EventArgs e)
        {
            EntryValue.Text += Eight.Text;
        }

        private void Nine_Clicked(object sender, EventArgs e)
        {
            EntryValue.Text += Nine.Text;
        }

        private void Four_Clicked(object sender, EventArgs e)
        {
            EntryValue.Text += Four.Text;
        }

        private void Five_Clicked(object sender, EventArgs e)
        {
            EntryValue.Text += Five.Text;
        }

        private void Six_Clicked(object sender, EventArgs e)
        {
            EntryValue.Text += Six.Text;
        }

        private void One_Clicked(object sender, EventArgs e)
        {
            EntryValue.Text += One.Text;
        }

        private void Two_Clicked(object sender, EventArgs e)
        {
            EntryValue.Text += Two.Text;
        }

        private void Three_Clicked(object sender, EventArgs e)
        {
            EntryValue.Text += Three.Text;
        }

        private void Zero_Clicked(object sender, EventArgs e)
        {
            EntryValue.Text += Zero.Text;
        }

        private void Dot_Clicked(object sender, EventArgs e)
        {
            EntryValue.Text += Dot.Text;
        }

        private void Equals_Clicked(object sender, EventArgs e)
        {

        }
    }
}
