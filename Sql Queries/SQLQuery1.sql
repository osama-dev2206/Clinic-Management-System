-- Admin Table For Login

Create Table AdminLogin
(
AdminId int identity(1,1) Primary Key, 
AdminFullName varchar(50) not null,
AdminPassword varchar(10) not null ,
AdminPermissions int null 
);

insert into AdminLogin(AdminFullName,AdminPassword,AdminPermissions,UserName)
values ('Full Access Admin', '123' , 0,'Admin12')

alter table AdminLogin 
add 
UserName varchar(10) not null 
Unique(UserName);

select R = 'T'
From AdminLogin 
where AdminPassword = '123' 
and UserName = 'Admin12';


select R = 'T'
From AdminLogin
where UserName= 'Admin12' And AdminPassword = '123' ;

alter table AdminLogin
add
AdminPersonId int  null ,
Constraint FK_AdminPerson 
Foreign Key (AdminPersonId)
 References Person(PersonId);



---------------------------------------------------------------------------------
Select Count(*) As NumOfAppointments From Appointment;



 Select * from AdminLogin;

 Select * from AppointmentDetails;


 Select * from Patient;

 Select * from Person
 inner Join Patient On Patient.PatientPersonId = Person.PersonId;
 --------------------------------------------------------------------------------------------


 -- insert the person as patient data ------------
 
INSERT  INTO Person (Name, DateOfBirth, Gender, Address)
VALUES             (@Name, @Date, @Gender, @Address);

INSERT  INTO Patient (PatientPersonId)
VALUES              ((SELECT Person.PersonId
                      FROM   Person
                      WHERE  Person.Name = @Name
                             AND Person.Address = @Address
                             AND Person.DateOfBirth = @Date
                             AND Person.Gender = @Gender));

INSERT  INTO Email (Email, Email.PersonId)
VALUES            (@Email, (SELECT Person.PersonId
                            FROM   Person
                            WHERE  Person.Name = @Name
                                   AND Person.Address = @Address
                                   AND Person.DateOfBirth = @Date
                                   AND Person.Gender = @Gender));

INSERT  INTO Phone (PhoneNumber, Phone.PersonId)
VALUES            (@Phone, (SELECT Person.PersonId
                            FROM   Person
                            WHERE  Person.Name = @Name
                                   AND Person.Address = @Address
                                   AND Person.DateOfBirth = @Date
                                   AND Person.Gender = @Gender));

SELECT SCOPE_IDENTITY();

 ----------------------------------------------------------------------

 Select * From Appointment;

 -- for viewing 
 Select * From PatientFullDetails;

 
 Select Person.PersonId 
 From Person
 Inner Join Patient 
 On Patient.PatientPersonId = Person.PersonId
 where Patient.PatientPersonId = '@ID' ;

 -- we will store the person id before deleting in bussiness logic 
 Delete Person 
 where PersonId = '@ID';

 -- Delete Patient -----------------------------------------------------------------------------

Delete Phone
Where 
Phone.PersonId = (Select Patient.PatientPersonId 
from Person
Inner Join Patient  On Patient.PatientPersonId = PersonId
Where Patient.PatientPersonId = '@ID');


Delete Email 
Where Email.PersonId = (Select Patient.PatientPersonId 
from Person
Inner Join Patient  On Patient.PatientPersonId = PersonId
Where Patient.PatientPersonId = '@ID');


Delete Appointment
where Appointment.APatientId = (Select Patient.PatientPersonId 
from Person
Inner Join Patient  On Patient.PatientPersonId = PersonId
Where Patient.PatientPersonId = '@ID');

Delete Patient
Where Patient.PatientPersonId= 
(Select Patient.PatientPersonId 
from Person
Inner Join Patient  On Patient.PatientPersonId = PersonId
Where Patient.PatientPersonId = '@ID');


--------------------------------------------------------------------------------------

Select * From Person;
Select * From Patient; 
Select * From Email;
Select * from Phone ;
 Select * From PatientFullDetails;



 insert Into Phone(PhoneNumber,PersonId)
 values('05155555424' , 4)

Select * From Appointment;


-- Find Patient By ID
Select * From PatientDetailsForFinding
Where PatientDetailsForFinding.PersonId = '@ID'; 

Select * From PatientDetailsForFinding

Select * From PatientFullDetails;



---- Update Patient 

-- person 
Update Person Set
Person.Name = '@Name' , Person.Gender = '@Gender' ,
Person.Address = '@Address', Person.DateOfBirth = '@DateOfBirth' 
where Person.PersonId = '@ID'

-- Email
Update Email Set
Email.Email = '@Email'
Where Email.PersonId = '@ID'
-- Phone
Update Phone Set 
PhoneNumber = '@Phone'
Where Phone.PersonId = '@ID' 
------------------------------------
Select * From AdminFullInfo;

Select * from Person;
insert into Person(Name,DateOfBirth,Gender,Address)
values ('Osama-Dev','2006-9-1','M','UNKNOWN');

Insert Into Email(Email,Email.PersonId)
values ('osama-dev@gmail.com',(Select Person.PersonId from Person where Person.Name = 'Osama-Dev' ) );

Insert Into Phone(PhoneNumber,PersonId)
values('011231444',(Select Person.PersonId from Person where Person.Name = 'Osama-Dev' ) ) ;

Update AdminLogin
set AdminPersonId = (Select Person.PersonId from Person where Person.Name = 'Osama-Dev' ) ;

-------------------------------- Doctors ----------------------------------------
-- # please note we handle doctors with person id 

Select * From DoctorsFullDetails; 