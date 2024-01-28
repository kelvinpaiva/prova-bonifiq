using ProvaPub.Models;

namespace ProvaPub.Abstract
{
    public abstract class Payment
    {
        public abstract Order Pagamento(decimal paymentValue, int customerId);
    }
}
