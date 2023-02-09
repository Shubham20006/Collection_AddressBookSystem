create procedure SpAddEmployeeDetails
(
@FirstName varchar(255),
@LastName varchar(255),
@Address varchar(255),
@City varchar(255),
@State varchar(255),
@zip varchar(255),
@PhoneNum varchar(255),
@Email varchar(255),
@Type varchar(255),
@Date varchar(255)
)
as
begin

Insert into AddressBook values (@FirstName,@LastName,@Address,@City,@State,@zip,@PhoneNum,
@Email,@Type,@Date);

END

select * from AddressBook