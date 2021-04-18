using PersonLib.Models;
using MediatR;

namespace PersonLib.Queries
{
    public record GetPersonByIdQuery(int Id) : IRequest<PersonModel>;
}
