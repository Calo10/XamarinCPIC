using System;
using System.Collections.Generic;
using ProyectoXamarinCPIC.ViewModel;
using Xamarin.Forms;

namespace ProyectoXamarinCPIC.View
{
    public partial class FormsSecondView : ContentPage
    {
        public FormsSecondView()
        {
            InitializeComponent();

            BindingContext = FormViewModel.GetInstance();
        }
    }
}
