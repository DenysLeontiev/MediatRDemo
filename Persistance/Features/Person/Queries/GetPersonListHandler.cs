using MediatR;
using Persistance.DataAccess;
using Persistance.Models;

namespace Persistance.Features.Person.Queries;

public class GetPersonListQueryHandler : IRequestHandler<GetPersonListQuery, List<PersonModel>>
{
	private readonly IDataAccess _dataAccess;

	public GetPersonListQueryHandler(IDataAccess dataAccess)
	{
		_dataAccess = dataAccess;
	}

	public Task<List<PersonModel>> Handle(GetPersonListQuery request, CancellationToken cancellationToken)
	{
		var people = _dataAccess.GetPeople();

		return Task.FromResult(people);
	}
}
