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
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
            BindingContext = new RegisterValidationViewModel();
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
}