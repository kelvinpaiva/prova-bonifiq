using ProvaPub.Abstract;
using ProvaPub.Models;
using ProvaPub.Services.PaymentType;

namespace ProvaPub.Services
{
	public class OrderService
	{
		public async Task<Order> PayOrder(string paymentMethod, decimal paymentValue, int customerId)
		{
            string objectToInstantiate = "ProvaPub.Services.PaymentType."+ paymentMethod.Trim().ToLower() +", ProvaPub";
            var objectType = Type.GetType(objectToInstantiate);
            dynamic instantiatedObject = Activator.CreateInstance(objectType);

			return instantiatedObject.Pagamento(paymentValue, customerId);
		}
	}
}
