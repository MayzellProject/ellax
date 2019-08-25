﻿using System.Threading;
using System.Threading.Tasks;
using FluentValidation;
using MediatR;

namespace Cinder.Api.Infrastructure.Features.Address
{
    public class GetAddressByHash
    {
        public class Validator : AbstractValidator<Query>
        {
            public Validator()
            {
                RuleFor(m => m.Hash).NotEmpty().Length(42);
                RuleFor(m => m.Page).GreaterThanOrEqualTo(1);
                RuleFor(m => m.Size).LessThanOrEqualTo(100);
            }
        }

        public class Query : IRequest<Model>
        {
            public string Hash { get; set; }
            public int? Page { get; set; }
            public int? Size { get; set; }
        }

        public class Model
        {
            public string Hash { get; set; }
        }

        public class Handler : IRequestHandler<Query, Model>
        {
            public Task<Model> Handle(Query request, CancellationToken cancellationToken)
            {
                // TODO
                return Task.FromResult(new Model {Hash = request.Hash});
            }
        }
    }
}
