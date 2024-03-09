using sainsburyAPI.Models;

namespace sainsburyAPI.Services
{
    public interface ICustomerStore
    {
        /// <summary>
        /// This method fetches data and returns a list of Customer.
        /// </summary>
        /// <returns>returns the list of all customers.</returns>
        Task<List<CustomerModel>> GetAllCustomer();

        /// <summary>
        /// Get Customer by Id.
        /// </summary>
        /// <param name="id">id.</param>
        /// <returns>Returns the details of a single customer.</returns>
        Task<CustomerModel> GetCustomer(int id);


        /// <summary>
        /// This method is for add new Customer.
        /// </summary>
        /// <param name="model">CustomerModel.</param>
        /// <returns>Returns the result customer model.</returns>
        Task<CustomerModel> AddCustomer(CustomerModel model);

        /// <summary>
        /// This method is for update Customer existing details.
        /// </summary>
        /// <param name="model">CustomerModel.</param>
        /// <returns>Returns the result customer model.</returns>
        Task<CustomerModel> UpdateCustomer(CustomerModel model);
    }
}