using PersonLib.Models;
using MediatR;
using System.Collections.Generic;

namespace PersonLib.Queries
{
    public record GetPersonListQuery() : IRequest<List<PersonModel>>;
}
