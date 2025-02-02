﻿using CICDProject.Domain.Shared;
using MediatR;


namespace CICDProject.Application.Abstractions.Message
{
    public interface IQuery<TResponse> : IRequest<Result<TResponse>>
    {

    }
}
