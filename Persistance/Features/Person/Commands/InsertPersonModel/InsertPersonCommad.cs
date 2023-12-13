using MediatR;
using Persistance.Models;

namespace Persistance.Features.Person.Commands.InsertPersonModel;

public record InsertPersonCommad(string FirstName, string LastName) : IRequest<PersonModel>;
