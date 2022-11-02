using MediatR;

namespace MediatRExample.Med.Queries
{
    public class GetAllProductQuery : IRequest<List<GetProductByIdViewModel>>
    {
        public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQuery, List<GetProductByIdViewModel>>
        {
            public Task<List<GetProductByIdViewModel>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
            {
                var model = new GetProductByIdViewModel()
                {
                    Id = Guid.NewGuid(),
                    Name = "Bilgisayar"
                };
                var model2 = new GetProductByIdViewModel()
                {
                    Id = Guid.NewGuid(),
                    Name = "Bilgisayar"
                };
                return Task.FromResult(new List<GetProductByIdViewModel> { model, model2 });
            }
        }
    }
}
