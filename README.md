# Test

1. Create a new VS .NET Core API project
2. Develop a Person model that has Id, FirstName, LastName property
3. Develop a service IPersonService / PersonService that implements static in-memory list of Persons with some initial data and provides methods to GetById and Save a Person
4. Add a unit test to verify by GetById
5. Develop a PersonsController that has endpoint GET ~/persons/:id which returns JSON representation of Person from DI injected IPersonService
6. Add an endpoint PUT ~/persons/:id that saves a person.  
7. Add validation to make sure FirstName / LastName are required and return 400 if missing
