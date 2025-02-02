using CICDProject.Application.Abstractions.Message;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CICDProject.Application.UserCases.V1.Queries.Product
{
    public class GetProductQuery : IQuery<GetProductResponse>
    {
        public string Name { get; set; }
    }
}
