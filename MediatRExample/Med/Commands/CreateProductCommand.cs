using MediatR;

namespace MediatRExample.Med.Commands
{   

    /// <summary>
    /// Bir product oluşturmak için gerekli komutumuz bu sınıf olacaktır. 
    /// Bunu handle edip product'ı oluşturacağız.
    /// </summary>
    public class CreateProductCommand : IRequest<Guid>
    {//geriye guid dönüyor create ettikten sonra


        /*
         * Örneğin oluşturma için kullanıcıdan bir id istemiyoruz. Bunu oluşturma sırasında biz oluşturacağız.
         * Burada istediklerimiz nesnenin oluşması için en temel gerekli datalar.
         */
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Value { get; set; }



        //Bu sınıfın birde handle sınıfını oluşturalım
        //createProductCommand alıcak ve guid dönicek diye parametre verdik ırequestHandler'a 
        public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, Guid>
        {
            public Task<Guid> Handle(CreateProductCommand request, CancellationToken cancellationToken)
            {
                return Task.FromResult(Guid.NewGuid());
                //guid dönerek sanki nesne oluşmuş ve karşılığında nesnenin id değeri karşı tarafa iletilmiş gibi işlem yapılr.

                //repository'e bağlanıp veritabanına data gönderilir.
            }
        }
    }
}
