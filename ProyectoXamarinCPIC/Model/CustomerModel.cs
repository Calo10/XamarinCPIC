using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ProyectoXamarinCPIC.Model
{
    public class CustomerModel : INotifyPropertyChanged
    {

        #region Properties

        private int _Id { get; set; }
        public int Id
        {
            get
            {
                return _Id;
            }
            set
            {
                _Id = value;
                OnPropertyChanged("Id");
            }
        }

        private string _Name { get; set; }
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
                OnPropertyChanged("Name");
            }
        }

        public string LastName
        {
            get;
            set;
        }

        public string Detail
        {
            get;
            set;
        }

        public string Gender
        {
            get;
            set;
        }

        public int Age
        {
            get;
            set;
        }

        #endregion

        #region Methods


        public static async Task<ObservableCollection<CustomerModel>> GetAllCustomers()
        {
            using (HttpClient client = new HttpClient())
            {
                var uri = new Uri("");

                HttpResponseMessage response = await client.GetAsync(uri);
                string ans = await response.Content.ReadAsStringAsync();

                var respuesta = JsonConvert.DeserializeObject<ObservableCollection<CustomerModel>>(ans);

                return respuesta;
            }
        }

        public static async Task<bool> SaveCustomer(CustomerModel customer)
        {
            using (HttpClient client = new HttpClient())
            {
                var uri = new Uri("");

                var json = JsonConvert.SerializeObject(new
                {
                    Id = customer.Id,
                    Name = customer.Name,
                    LastName = customer.LastName,
                    Detail = customer.Detail    
                });

                var content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(uri, content).ConfigureAwait(false);
                string ans = await response.Content.ReadAsStringAsync();

                bool respuesta = JsonConvert.DeserializeObject<bool>(ans);

                return respuesta;
            }
        }

        #endregion

        public CustomerModel()
        {
        }

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
