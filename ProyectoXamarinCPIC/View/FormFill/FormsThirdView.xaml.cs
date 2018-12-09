using System;
using System.Collections.Generic;
using ProyectoXamarinCPIC.ViewModel;
using Xamarin.Forms;

namespace ProyectoXamarinCPIC.View
{
    public partial class FormsThirdView : ContentPage
    {
        public FormsThirdView()
        {
            InitializeComponent();

            BindingContext = FormViewModel.GetInstance();
        }
    }
}
