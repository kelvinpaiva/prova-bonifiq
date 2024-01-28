using ProvaPub.Abstract;
using ProvaPub.Models;
using ProvaPub.Services.PaymentType;

namespace ProvaPub.Services
{
	public class OrderService
	{
		public async Task<Order> PayOrder(string paymentMethod, decimal paymentValue, int customerId)
		{
            string objectToInstantiate = "ProvaPub.Services.PaymentType."+ paymentMethod +", ProvaPub";
            var objectType = Type.GetType(objectToInstantiate);
            dynamic instantiatedObject = Activator.CreateInstance(objectType);

			return instantiatedObject.Pagamento(paymentValue, customerId);

            
			//Payment payment = new t();

            //return await t.PayOrder(paymentMethod, paymentValue, customerId);
			if (paymentMethod == "pix")
			{
				//Faz pagamento...
			}
			else if (paymentMethod == "creditcard")
			{
				//Faz pagamento...
			}
			else if (paymentMethod == "paypal")
			{
				//Faz pagamento...
			}

			return await Task.FromResult( new Order()
			{
				Value = paymentValue
			});
		}
	}
}
