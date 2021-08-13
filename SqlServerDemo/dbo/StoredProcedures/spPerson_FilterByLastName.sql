CREATE PROCEDURE [dbo].[spPerson_FilterByLastName]
	@LastName nvarchar(30)
AS
	SELECT [Id], [FirstName], [LastName]
	from dbo.Person
	WHERE [dbo].[Person].[LastName] = @LastName;
RETURN 0
