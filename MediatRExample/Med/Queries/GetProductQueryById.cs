using MediatR;

namespace MediatRExample.Med.Queries
{

    /// <summary>
    /// Get isteği oluşturacak bir query sınıfıdır.
    /// Response olarak bir model döner.
    /// </summary>
    public class GetProductQueryById : IRequest<GetProductByIdViewModel>
    {
        /*
         * Bu sınıf ile bir query yaparız ve ırequest'den kalıtım alarak response modeli önceden belirleyebiliriz.
         */
        public Guid Id { get; set; }
    }
}
