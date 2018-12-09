using System;
using System.Collections.Generic;
using ProyectoXamarinCPIC.ViewModel;
using Xamarin.Forms;

namespace ProyectoXamarinCPIC.View
{
    public partial class FormFirstView : ContentPage
    {
        public FormFirstView()
        {
            InitializeComponent();

            BindingContext = FormViewModel.GetInstance();
        }
    }
}
