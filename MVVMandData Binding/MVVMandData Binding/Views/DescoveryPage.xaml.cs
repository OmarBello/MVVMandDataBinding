﻿using MVVMandDataBinding.ViewModels;
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
    public partial class DescoveryPage : ContentPage
    {
        public DescoveryPage()
        {
            InitializeComponent();
            BindingContext = new HomeViewModel();
        }
    }
}