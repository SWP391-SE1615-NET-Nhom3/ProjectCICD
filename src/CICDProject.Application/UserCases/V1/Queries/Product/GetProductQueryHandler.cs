using CICDProject.Application.Abstractions.Message;
using CICDProject.Domain.Shared;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CICDProject.Application.UserCases.V1.Queries.Product
{
    public class GetProductQueryHandler : IQueryHandler<GetProductQuery, GetProductResponse>
    {
        public Task<Result<GetProductResponse>> Handle(GetProductQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
