using Persistance.Models;

namespace Persistance.DataAccess;

public interface IDataAccess
{
	List<PersonModel> GetPeople();
	PersonModel InsertPersonModel(string firstName, string lastName);
}