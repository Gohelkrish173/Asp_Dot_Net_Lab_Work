-- Country insert
ALter PROCEDURE [dbo].[PR_Country_Insert]
@CountryName  NVarchar(25),
@CountryCode	int,
@CreationDate	date,
@ModificationDate	date
As
Begin
	Insert Into [dbo].[Country] 
	(
		[dbo].[Country].[CountryName],
		[dbo].[Country].[CountryCode],
		[dbo].[Country].[CreationDate],
		[dbo].[Country].[ModificationDate]
	)
	Values
	(
		@CountryName,
		@CountryCode,
		@CreationDate,
		@ModificationDate
	)
end

-- 2. Country Select All
CREATE PROCEDURE [dbo].[PR_SelectAll_Contry]
As
Begin
	select
		[dbo].[Country].[CountryName],
		[dbo].[Country].[CountryCode],
		[dbo].[Country].[CreationDate],
		[dbo].[Country].[ModificationDate]
	from [dbo].[Country]
End

--3. Country Update 
CREATE PROCEDURE [dbo].[PR_Update_Contry]
@CountryId int,
@CountryName  NVarchar(25),
@CountryCode	int,
@CreationDate	date,
@ModificationDate	date
As
Begin
	Update Country 
	Set 
		[dbo].[Country].[CountryName] = @CountryName,
		[dbo].[Country].[CountryCode] = @CountryCode,
		[dbo].[Country].[CreationDate] = @CreationDate,
		[dbo].[Country].[ModificationDate] = @ModificationDate
	where [dbo].[country].[countryId] = @CountryId
End

--4. Delete Country
CREATE PROCEDURE [dbo].[PR_Delete_Contry]
@CountryId int
As
Begin
	Delete from
		[dbo].[country]
	where [dbo].[country].[countryId] = @CountryId
End

--5. State Insert
CREATE PROCEDURE [dbo].[PR_State_Insert]
@CountryId int,
@StateName  NVarchar(25),
@StateCode	int,
@CreationDate	date,
@ModificationDate	date
As
Begin
	Insert Into [dbo].[State] 
	(
		[dbo].[State].[StateName],
		[dbo].[State].[StateCode],
		[dbo].[State].[CountryId],
		[dbo].[State].[CreationDate],
		[dbo].[State].[ModificationDate]
	)
	Values
	(
		@StateName,
		@StateCode,
		@CountryId,
		@CreationDate,
		@ModificationDate
	)
end

--6. State selectAll
CREATE PROCEDURE [dbo].[PR_SelectAll_State]
As
Begin
	select
		[dbo].[State].[StateName],
		[dbo].[State].[StateCode],
		[dbo].[State].[CountryId],
		[dbo].[State].[CreationDate],
		[dbo].[State].[ModificationDate]
	from [dbo].[State]
End

--7.State Update
CREATE PROCEDURE [dbo].[PR_Update_State]
@StateId int,
@StateName  NVarchar(25),
@CountryId	int,
@StateCode	int,
@CreationDate	date,
@ModificationDate	date
As
Begin
	Update State 
	Set 
		[dbo].[State].[StateName] = @StateName,
		[dbo].[State].[StateCode] = @StateCode,
		[dbo].[State].[CountryId] = @CountryId,
		[dbo].[State].[CreationDate] = @CreationDate,
		[dbo].[State].[ModificationDate] = @ModificationDate
	where [dbo].[State].[StateId] = @StateId
End

--8. state Delete
CREATE PROCEDURE [dbo].[PR_Delete_State]
@StateId int
As
Begin
	Delete from
		[dbo].[State]
	where [dbo].[State].[StateId] = @StateId
End

--9. select by country id state
CREATE PROCEDURE [dbo].[PR_SelectByCountryId]
@CountryId int
As
Begin
	select
		[dbo].[State].[StateName],
		[dbo].[State].[StateCode],
		[dbo].[State].[CountryId],
		[dbo].[State].[CreationDate],
		[dbo].[State].[ModificationDate]
	from [dbo].[State]
	where [dbo].[State].[CountryId] = @CountryId
End

--10. Contry wise State
CREATE PROCEDURE [dbo].[PR_ContrywiseState]
As
Begin
	select
		[dbo].[country].[countryname],
		[dbo].[State].[StateName]
	from [dbo].[State]
	inner join 
		[dbo].[country] on 
		[dbo].[country].[countryId] = [dbo].[State].[CountryId]
End