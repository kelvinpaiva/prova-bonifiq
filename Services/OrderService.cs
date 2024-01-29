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
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            dynamic instantiatedObject = Activator.CreateInstance(objectType);
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

            return await instantiatedObject.Pagamento(paymentValue, customerId);
		}
	}
}
