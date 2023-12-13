using MediatR;
using Persistance.DataAccess;
using Persistance.Models;

namespace Persistance.Features.Person.Queries.GetPersonById;

public class GetPersonByIdHandler : IRequestHandler<GetPersonByIdQuery, PersonModel>
{
	private readonly IDataAccess _dataAccess;
	public GetPersonByIdHandler(IDataAccess dataAccess)
	{
		_dataAccess = dataAccess;
	}

	public Task<PersonModel> Handle(GetPersonByIdQuery request, CancellationToken cancellationToken)
	{
		var person = _dataAccess.GetPeople().FirstOrDefault(x => x.Id.Equals(request.Id));

		return Task.FromResult(person);
	}
}
