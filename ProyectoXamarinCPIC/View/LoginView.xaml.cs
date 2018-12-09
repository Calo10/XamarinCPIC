using System;
using System.Collections.Generic;
using ProyectoXamarinCPIC.ViewModel;
using Xamarin.Forms;

namespace ProyectoXamarinCPIC.View
{
    public partial class LoginView : ContentPage
    {
        public LoginView()
        {
            InitializeComponent();

            BindingContext = HomeViewModel.GetInstance();
        }
    }
}
