using System;
using System.Collections.Generic;
using ProyectoXamarinCPIC.ViewModel;
using Xamarin.Forms;

namespace ProyectoXamarinCPIC.View
{
    public partial class MenuPageView : ContentPage
    {
        public MenuPageView()
        {
            InitializeComponent();

            BindingContext = HomeViewModel.GetInstance();
        }
    }
}
