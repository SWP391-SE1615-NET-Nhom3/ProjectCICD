using CICDProject.Application.Abstractions.Message;
using CICDProject.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CICDProject.Application.UserCases.V1.Commands.Product
{
    public class CreateProductCommandHandler : ICommandHandler<CreateProductCommand>
    {
        public Task<Result> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
