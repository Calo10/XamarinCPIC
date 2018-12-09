using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using ProyectoXamarinCPIC.Model;
using ProyectoXamarinCPIC.View;
using Xamarin.Forms;

namespace ProyectoXamarinCPIC.ViewModel
{
    public class FormViewModel : INotifyPropertyChanged
    {
        #region Properties

        private ObservableCollection<CustomerModel> _lstCustomers = new ObservableCollection<CustomerModel>();

        public ObservableCollection<CustomerModel> lstCustomers
        {
            get
            {
                return _lstCustomers;
            }
            set
            {
                lstCustomers = value;
                OnPropertyChanged("lstCustomers");
            }
        }

        private CustomerModel _Customer = new CustomerModel();

        public CustomerModel Customer
        {
            get
            {
                return _Customer;
            }
            set
            {
                Customer = value;
                OnPropertyChanged("Customer");
            }
        }

        public ICommand ContinueCommand { get; set; }


        #endregion

        #region Singleton
        private static FormViewModel instance = null;

        private FormViewModel()
        {
            InitClass();
            InitCommand();
        }

        public static FormViewModel GetInstance()
        {
            if (instance == null)
            {
                instance = new FormViewModel();
            }

            return instance;
        }

        public static void DeleteInstance()
        {
            if (instance != null)
            {
                instance = null;
            }
        }
        #endregion

        #region Methods

        public void Continue(string currentPage)
        {
            switch (currentPage)
            {

                case "1":
                    ((MasterDetailPage)App.Current.MainPage).Detail.Navigation.PushAsync(new FormsSecondView());
                    break;

                case "2":
                    ((MasterDetailPage)App.Current.MainPage).Detail.Navigation.PushAsync(new FormsThirdView());
                    break;


                case "3":

                    lstCustomers.Add(Customer);

                    Customer = new CustomerModel();

                    break;
                default:
                    break;
            }
        }


        private void InitClass()
        {
         
        }

        private void InitCommand()
        {
            ContinueCommand = new Command<string>(Continue);
        }
        #endregion

        #region Property Changed
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string info)
        {

            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(info));
        }
        #endregion
    }
}
