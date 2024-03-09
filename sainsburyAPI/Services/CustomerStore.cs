using sainsburyAPI.Models;
using System.Collections.Generic;

namespace sainsburyAPI.Services
{
    public class CustomerStore : ICustomerStore
    {
        private List<CustomerModel> _customerModel;

        public CustomerStore()
        {
            _customerModel = new List<CustomerModel>()
            {
                new CustomerModel
                {
                    Id = 1,
                    Name = "Shane",
                    Age = 35,
                    PostCode = "TW33RJ",
                    Height = 1.25,
                },

                new CustomerModel
                {
                    Id = 2,
                    Name = "Jack",
                    Age = 40,
                    PostCode = "SL11JH",
                    Height = 2.25,
                },

                new CustomerModel
                {
                    Id = 3,
                    Name = "Tom",
                    Age = 45,
                    PostCode = "CV12GT",
                    Height = 2.10,
                }
            };
        }

        public async Task<List<CustomerModel>> GetAllCustomer()
        {
            return _customerModel;
        }

        public async Task<CustomerModel> GetCustomer(int id)
        {
            var customer = _customerModel.Where(x => x.Id == id).FirstOrDefault();

            return customer;
        }

        public async Task<CustomerModel> AddCustomer(CustomerModel model)
        {
            var count = _customerModel.Count;
            model.Id = count + 1;

           _customerModel.Add(model);

            return model;
        }

        public async Task<CustomerModel> UpdateCustomer(CustomerModel model)
        {
            var record = _customerModel.Where(x => x.Id == model.Id).FirstOrDefault();

            record.Name = model.Name;
            record.Age = model.Age;
            record.PostCode = model.PostCode;
            record.Height = model.Height;

            return record;
        }


    }
}
