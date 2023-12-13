using MediatR;
using Persistance.DataAccess;
using Persistance.Models;

namespace Persistance.Features.Person.Commands.InsertPersonModel;

public class InsertPersonHandler : IRequestHandler<InsertPersonCommad, PersonModel>
{
	private readonly IDataAccess _dataAccess;
	public InsertPersonHandler(IDataAccess dataAccess)
	{
		_dataAccess = dataAccess;
	}

	public async Task<PersonModel> Handle(InsertPersonCommad request, CancellationToken cancellationToken)
	{
		var createdPerson = _dataAccess.InsertPersonModel(request.FirstName, request.LastName);

		return createdPerson;
	}
}
