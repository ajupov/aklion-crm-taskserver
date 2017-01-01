select
	[Id],
	[Date],
	[Name],  
	[Phone],
	[Email],
	[Street],
	[HouseNumber],
	[OrderItems],
	[OrderSum],
	[PaymentMethod],
	[Note]
	from [dbo].[Order]
	where [Phone] like '%' + @phonePattern + '%';