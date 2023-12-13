using MediatR;
using Persistance.Models;

namespace Persistance.Features.Person.Queries.GetPersonById;

public record GetPersonByIdQuery(int Id) : IRequest<PersonModel>;
