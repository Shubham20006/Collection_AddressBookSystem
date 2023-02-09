
/* UC1:- Create database AddressBookService */
create database AddressBookService

/* UC2:- Create table address book */
create table AddressBook
(
FirstName varchar(255),
LastName varchar(255),
Address varchar(255),
City varchar(255),
State varchar(255),
zip varchar(255),
PhoneNum varchar(255),
Email varchar(255)
)

/*UC3:- Insert new contact into addressbook*/

insert into AddressBook values('shubham','chaudhari','143 street','pune','MH','356562','9457841454','shubham@gmail.com')
insert into AddressBook values('suraj','raut','45 area','banglore','MH','598552','9614522532','suraj@gmail.com')
insert into AddressBook values('srushti','jadhav','can not palace','Aurangabad','MH','545635','8054542536','srushti@gmail.com')
insert into AddressBook values('raj','patil','Abc street','mumbai','MH','878562','8612412222','raj@gmail.com')

/* UC4:- Edit contact/person using name.*/

update AddressBook
set State='UP'
where FirstName='raj'

/* UC5:- Delete contact/person by using persons name.*/

delete from AddressBook
where FirstName='raj'

/* UC6:- Retrive persons belonging to city or state */

select * from AddressBook
where City='pune' or State='MH'

/* UC7:- Size of AddressBook.*/

select COUNT(City) from AddressBook
select COUNT(State) from AddressBook

/*UC8:- Ability to retrieve entries sorted alphabetically by Person’s name for a given city. */

select * from AddressBook order by FirstName asc
/*UC9:- Ability to identify each Address Book with name and Type.*/

Alter table AddressBook
 add Type varchar(255)
 select * from AddressBook
 update AddressBook
set type='friend'
where FirstName='suraj'
update AddressBook
set type='family'
where FirstName='srushti'
update AddressBook
set type='profession'
where FirstName='shubham'

/*UC10:- Ability to get number of contact persons i.e. count by type*/

select COUNT(type) from AddressBook

/*UC11:- Ability to add person both family and friend.*/
insert into AddressBook values('srushti','jadhav','can not palace','Aurangabad','MH','545635','8054542536','srushti@gmail.com','friend')

/*UC12:- Draw the ER Diagram for Address Book Service DB*/
create table FNameAndType
(
FirstName varchar(255),
Type varchar(255),
)
insert into FNameAndType values('shubham','profession')
insert into FNameAndType values('suraj','friend')
insert into FNameAndType values('srushti','family')
insert into FNameAndType values('srushti','friend')

create table person
(
FirstName varchar(255),
LastName varchar(255),
PhoneNum varchar(255),
Email varchar(255)
)
insert into person values('shubham','chaudhari','9457841454','shubham@gmail.com')
insert into person values('suraj','raut','9614522532','suraj@gmail.com')
insert into person values('srushti','jadhav','8054542536','srushti@gmail.com')

create table Addressdata
(
FirstName varchar(255),
Address varchar(255),
City varchar(255),
State varchar(255),
zip varchar(255),
)
insert into Addressdata values('shubham','143 street','pune','MH','356562')
insert into Addressdata values('suraj','45 area','banglore','MH','598552')
insert into Addressdata values('srushti','can not palace','Aurangabad','MH','545635')

/*UC13:- Ensure all retrieve queries done*/
select * from FNameAndType
select * from person
select * from Addressdata