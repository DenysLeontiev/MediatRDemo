using Persistance.Models;

namespace Persistance.DataAccess;

public class DemoDataAccess : IDataAccess
{
	private List<PersonModel> people = new List<PersonModel>();

	public DemoDataAccess()
	{
		people.Add(new PersonModel { Id = 1, FirstName = "Den", LastName = "Leon" });
		people.Add(new PersonModel { Id = 2, FirstName = "Tim", LastName = "Correy" });
	}

	public List<PersonModel> GetPeople()
	{
		return people;
	}

	public PersonModel InsertPersonModel(string firstName, string lastName)
	{
		PersonModel personModel = new() { FirstName = firstName, LastName = lastName };
		personModel.Id = people.Max(x => x.Id) + 1;

		people.Add(personModel);

		return personModel;
	}
}
