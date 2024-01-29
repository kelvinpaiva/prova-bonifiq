using ProvaPub.Models;

namespace ProvaPub.Interface
{
    public interface ICustomerService
    {
        /// <summary>
        /// Lista os kCustomers
        /// </summary>
        /// <param name="page">Número da página da lista</param>
        /// <returns>Uma lista de Customer</returns>
        public CustomerList ListCustomers(int page);

        /// <summary>
        /// Executa o CanPurshase
        /// </summary>
        /// <param name="customerId">Id do customer</param>
        /// <param name="purchaseValue">Valor da Compra</param>
        /// <returns>Um objeto de acordo com a validação da venda</returns>
        public Task<bool> CanPurchase(int customerId, decimal purchaseValue);
    }
}
