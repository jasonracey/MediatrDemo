using PersonLib.Models;
using MediatR;

namespace PersonLib.Commands
{
    public record InsertPersonCommand(string FirstName, string LastName) : IRequest<PersonModel>;
}
