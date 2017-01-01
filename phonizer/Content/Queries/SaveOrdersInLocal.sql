if(exists (select [Id] from [dbo].[Order] where [Id] = @Id)) begin
	update [dbo].[Order]
		set [Date] = @Date,
			[Name] = @Name,
			[Phone] = @Phone,
			[Email] = @Email,
			[Street] = @Street,
			[HouseNumber] = @HouseNumber,
			[OrderItems] = @OrderItems,
			[OrderSum] = @OrderSum,
			[PaymentMethod] = @PaymentMethod,
			[Note] = @Note
end
else begin
	insert into [dbo].[Order]
	(
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
	)
		values
		(
			@Id,
			@Date,
			@Name,
			@Phone,
			@Email,
			@Street,
			@HouseNumber,
			@OrderItems,
			@OrderSum,
			@PaymentMethod,
			@Note
		)
end;