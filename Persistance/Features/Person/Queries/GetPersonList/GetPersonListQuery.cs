using MediatR;
using Persistance.Models;

namespace Persistance.Features.Person.Queries.GetPersonList;

public record GetPersonListQuery() : IRequest<List<PersonModel>>;
