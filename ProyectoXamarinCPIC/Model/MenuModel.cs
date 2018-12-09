using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ProyectoXamarinCPIC.Model
{
    public class MenuModel
    {

        public int Id
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }

        public string Icon
        {
            get;
            set;
        }

        public static ObservableCollection<MenuModel> GetMenu()
        {
            return new ObservableCollection<MenuModel> {
                new MenuModel{Id=1, Icon = "", Name= "Create User"},
                new MenuModel{Id=2, Icon = "", Name= ""},
                new MenuModel{Id=3, Icon = "", Name= ""},
                new MenuModel{Id=4, Icon = "", Name= ""},
                };
        }
        public MenuModel()
        {
        }
    }
}
