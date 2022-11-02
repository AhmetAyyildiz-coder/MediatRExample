using MediatR;

namespace MediatRExample.Med.Queries
{

    /// <summary>
    /// Query oluştuğu zaman onu handle edebilecek sınıftır
    /// </summary>
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductQueryById, GetProductByIdViewModel>
    {
        /*
         * eğer istek bu handler tetiklendiyse birisi getproductquerybyid query'sini tetiklemiş demektir
         * bu tetiklemeden sonra bizim requesti alıp belirli işlemler yapabiliriz.
         * Genel olarak repository'den bir product gönderme işlemi yapacağız temelde
         */
        public Task<GetProductByIdViewModel> Handle(GetProductQueryById request, CancellationToken cancellationToken)
        {
            var viewModel = new GetProductByIdViewModel()
            {
                Id = Guid.NewGuid(),
                Name = "monitör"
            };

            return Task.FromResult(viewModel);
        }

        /*
         * Şimdi bu query çalıştığı zaman bu query handler da tetiklenir ve bu query'yi yakalamış oluruz.
         */
    }
}
