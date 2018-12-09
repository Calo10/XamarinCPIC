using System;
using System.Collections.Generic;
using ProyectoXamarinCPIC.ViewModel;
using Xamarin.Forms;

namespace ProyectoXamarinCPIC.View
{
    public partial class HomePageView : ContentPage
    {
        public HomePageView()
        {
            InitializeComponent();

            BindingContext = FormViewModel.GetInstance();
        }
    }
}
