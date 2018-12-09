using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using ProyectoXamarinCPIC.Model;
using ProyectoXamarinCPIC.View;
using Xamarin.Forms;

namespace ProyectoXamarinCPIC.ViewModel
{
    public class HomeViewModel : INotifyPropertyChanged
    {
        #region Properties

        private ObservableCollection<MenuModel> _lstMenu { get; set; }

        public ObservableCollection<MenuModel> lstMenu
        {
            get
            {
                return _lstMenu;
            }

            set
            {
                _lstMenu = value;
                OnPropertyChanged("lstMenu");
            }
        }


        private string _User = "";

        public string User
        {
            get
            {
                return _User;
            }

            set
            {
                _User = value;
                OnPropertyChanged("User");
            }
        }

        private string _Pass = "";

        public string Pass
        {
            get
            {
                return _Pass;
            }

            set
            {
                _Pass = value;
                OnPropertyChanged("Pass");
            }
        }

        public ICommand ValidateCredentialCommand { get; set; }
        public ICommand SelectMenuCommand { get; set; }

        #endregion

        #region Singleton
        private static HomeViewModel instance = null;

        private HomeViewModel()
        {
            InitClass();
            InitCommand();
        }

        public static HomeViewModel GetInstance()
        {
            if (instance == null)
            {
                instance = new HomeViewModel();
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

        public void ValidateCredential()
        {

            if (UserModel.ValidateUser(User,Pass))
            {
                //App.Current.MainPage = new MasterContainer();
                NavigationPage navigation = new NavigationPage(new HomePageView());


                App.Current.MainPage = new MasterDetailPage
                {
                    Master = new MenuPageView(),
                    Detail = navigation
                };
            }


        }

        public void SelectMenu(int id)
        {
            switch (id)
            {
                case 1:

                    ((MasterDetailPage)App.Current.MainPage).Detail.Navigation.PushAsync(new FormFirstView());

                    break;

                default:
                    break;
            }
        }

        private void InitClass()
        {
            lstMenu = MenuModel.GetMenu();
        }

        private void InitCommand()
        {
            ValidateCredentialCommand = new Command(ValidateCredential);
            SelectMenuCommand = new Command<int>(SelectMenu);
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
