using LoginRegisterXamarin;
using MVVMandDataBinding.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVMandDataBinding.ViewModels
{
    
    public class RegisterValidationViewModel
    {
        public Register Register { get; set; }

        public ICommand registerButtonCommand { get; set; }

        public RegisterValidationViewModel()
        {
            Register = new Register();

            registerButtonCommand = new Command(async () =>
            {
                if(string.IsNullOrEmpty(Register.Name) | string.IsNullOrEmpty(Register.Email) | string.IsNullOrEmpty(Register.Password) | string.IsNullOrEmpty(Register.ConfirmPassword))
                {

                    await App.Current.MainPage.DisplayAlert("Error", "Hay campos si  rellenar", "Cerrar");
                }
                else
                {
                    if(Register.Password == Register.ConfirmPassword)
                    {
                        await App.Current.MainPage.DisplayAlert("Felicidades", "Acabas de crear tu usuario", "Cerrar");
                        await App.Current.MainPage.Navigation.PushModalAsync(new LoginPage());
                    }
                    else
                    {
                        await App.Current.MainPage.DisplayAlert("Error", "El password no coinciden", "Cerrar");
                    }
                }
            }); 
        }
    }

    //private async void registerButton_Clicked(object sender, EventArgs e)
    //{
    //    bool isNameEmpty = string.IsNullOrEmpty(nameEntry.Text);
    //    bool isEmailEmpty = string.IsNullOrEmpty(emailEntry.Text);
    //    bool isPasswordEmpty = string.IsNullOrEmpty(passwordEntry.Text);
    //    bool isConfirmPasswordEntry = string.IsNullOrEmpty(confirmpasswordEntry.Text);



    //    if (isNameEmpty || isEmailEmpty || isPasswordEmpty || isConfirmPasswordEntry)
    //    {
    //        await DisplayAlert("Error", "Hay campos si  rellenar", "Cerrar");
    //    }
    //    else
    //    {
    //        if(isPasswordEmpty == isConfirmPasswordEntry)
    //        {

    //            await DisplayAlert("Felicidades", "Acabas de crear tu usuario", "Cerrar");
    //            await Navigation.PushAsync(new LoginPage());
    //        }
    //        else
    //        {
    //            await DisplayAlert("Error", "El password no coinciden", "Cerrar");
    //        }
    //    }


    //}
}
