using LoginRegisterXamarin;
using MVVMandDataBinding.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVMandDataBinding.ViewModels
{
    public class LogicValidationViewModel : View
    {
      public Login Login { get; set; }
      public ICommand LoginButtonCommand { get; set; }
      public ICommand RegisterButtonCommand { get; set; }

        public LogicValidationViewModel()
        {
            Login = new Login();
            LoginButtonCommand = new Command(async () =>
            {
               if(string.IsNullOrEmpty(Login.Username) | string.IsNullOrEmpty(Login.Password))
                {
                    await App.Current.MainPage.DisplayAlert("Error", "Campo Email/Password no pueden estar vacios", "OK");
                }
                else
                {
                    await App.Current.MainPage.DisplayAlert("Bienvenido", "Hola " + Login.Username, "OK");
                    await App.Current.MainPage.Navigation.PushModalAsync(new HomePage());
                }

            });

            RegisterButtonCommand = new Command(async () =>
            {
                await App.Current.MainPage.Navigation.PushModalAsync(new RegisterPage());
            });


        }


        //bool isEmailEmpty = string.IsNullOrEmpty(emailEntry.Text);
        //bool isPasswordEmpty = string.IsNullOrEmpty(passwordEntry.Text);
        //private async void LoginButton_Clicked(object sender, EventArgs e)
        //{


        //    if (isEmailEmpty || isPasswordEmpty)
        //    {
        //        await DisplayAlert("Error", "Campo Email/Password no pueden estar vacios", "OK");
        //    }
        //    else
        //    {
        //        await DisplayAlert("Bienvenido", "Hola " + emailEntry.Text, "OK");
        //        await Navigation.PushAsync(new HomePage());
        //    }
        //}


        //private async void RegisterButton_Clicked(object sender, EventArgs e)
        //{
        //    await Navigation.PushAsync(new RegisterPage());
        //}
    }
}
