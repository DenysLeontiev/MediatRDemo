using MediatR;
using Persistance.Models;

namespace Persistance.Features.Person.Queries;

public record GetPersonListQuery() : IRequest<List<PersonModel>>;
