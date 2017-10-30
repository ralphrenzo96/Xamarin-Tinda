using System;
using System.Collections.ObjectModel;
using tinda.Models;

namespace tinda.Utilities
{
    public class DummyDatas
    {
        public static ObservableCollection<CustomerModel> customers = new ObservableCollection<CustomerModel>();

        public static void AddCustomer(String name, int age, string address, string image)
        {
            customers.Add(new CustomerModel { Name = name, Age = age, Address = address, Image = image });
        }
    }
}
