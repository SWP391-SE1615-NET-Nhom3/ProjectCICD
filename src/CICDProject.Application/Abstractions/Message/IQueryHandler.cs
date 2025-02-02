using CICDProject.Domain.Shared;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CICDProject.Application.Abstractions.Message
{
    public interface IQueryHandler<TQuery,TResponse> : IRequestHandler<TQuery,Result<TResponse>> where TQuery : IQuery<TResponse>
    {
    }
}
