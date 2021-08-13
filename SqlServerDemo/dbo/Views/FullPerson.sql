CREATE VIEW [dbo].[FullPerson]
	AS 
	SELECT [p].[Id] AS PersonId, [p].[FirstName], [p].[LastName], [a].[Id], [a].[StreetAddress], [a].[City], [a].[State] FROM [dbo].Person p
	LEFT JOIN [dbo].Address a ON p.Id = a.PersonId
