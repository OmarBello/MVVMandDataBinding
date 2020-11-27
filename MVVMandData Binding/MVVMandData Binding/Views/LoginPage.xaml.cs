using MVVMandDataBinding.Models;
using MVVMandDataBinding.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LoginRegisterXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {

        public LoginPage()
        {
            InitializeComponent();
            BindingContext = new LogicValidationViewModel();


        }
        

        //bool isEmailEmpty = string.IsNullOrEmpty(emailEntry.Text);
        //bool isPasswordEmpty = string.IsNullOrEmpty(passwordEntry.Text);
        //private async void LoginButton_Clicked(object sender, EventArgs e)
        //{


        ////    if (isEmailEmpty || isPasswordEmpty)
        ////    {
        ////        await DisplayAlert("Error", "Campo Email/Password no pueden estar vacios", "OK");
        ////    }
        ////    else
        ////    {
        ////        await DisplayAlert("Bienvenido", "Hola " + emailEntry.Text, "OK");
        ////        await Navigation.PushAsync(new HomePage());
        ////    }
        //}


        //private async void RegisterButton_Clicked(object sender, EventArgs e)
        //{
        //    await Navigation.PushAsync(new RegisterPage());
        //}
    }
}