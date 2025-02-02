using CICDProject.Domain.Shared;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CICDProject.Application.Abstractions.Message
{
    public class ICommand : IRequest<Result>
    {

    }

    public class ICommand<TRespone> : IRequest<Result<TRespone>>
    {

    }
}
