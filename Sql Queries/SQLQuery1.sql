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


Select * from Doctor;

-------------------------------- Doctors ----------------------------------------
-- # please note we handle doctors with person id 

Select * From DoctorsFullDetails
where DoctorsFullDetails.PersonId = 2; 

------ Insert Doctor

INSERT  INTO Person (Name, DateOfBirth, Gender, Address)
VALUES             (@Name, @Date, @Gender, @Address);

INSERT  INTO Doctor (DoctorPersonId , DSpecialization)
VALUES              ( ( SELECT Person.PersonId
                      FROM   Person
                      WHERE  Person.Name = @Name
                             AND Person.Address = @Address
                             AND Person.DateOfBirth = @Date
                             AND Person.Gender = @Gender )    ,  @Specialization );

INSERT  INTO Email (Email, PersonId)
VALUES            (@Email, (SELECT Person.PersonId
                            FROM   Person
                            WHERE  Person.Name = @Name
                                   AND Person.Address = @Address
                                   AND Person.DateOfBirth = @Date
                                   AND Person.Gender = @Gender));

INSERT  INTO Phone (PhoneNumber,PersonId)
VALUES            (@Phone, (SELECT Person.PersonId
                            FROM   Person
                            WHERE  Person.Name = @Name
                                   AND Person.Address = @Address
                                   AND Person.DateOfBirth = @Date
                                   AND Person.Gender = @Gender));

SELECT SCOPE_IDENTITY();


------
---- update doctor    

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

-- Specialization
Update Doctor Set
Specialization = '@Specialization'
Where Doctor.DoctorPersonId = '@ID'

 ---- Delete Doctor -----
 -- # program will pass the person id to delete the doctor and all related data
Delete Phone
Where 
Phone.PersonId =
(Select DoctorPersonID.DocID 
from DoctorPersonID
Where DocID = '@ID');


Delete Email 
Where Email.PersonId = 
(Select DoctorPersonID.DocID 
from DoctorPersonID
Where DocID = '@ID');


Delete Appointment
where Appointment.APatientId = 
(Select DoctorPersonID.DocID 
from DoctorPersonID
Where DocID = '@ID');

Delete Doctor
Where Doctor.DoctorPersonId = 
(Select DoctorPersonID.DocID 
from DoctorPersonID
Where DocID = '@ID' );


Alter Table Person
Add Constraint UQ_Name
UNIQUE(Name);


Select * from DoctorsFullDetails;

Select * from PatientFullDetails;

Select * from DoctorsFullDetails
Where DoctorName = 'Lily Ahmed';


----------------- Appointment Table ----------------------------

----- Modify Appointment Table 
Select * From AppointmentDetails;

alter Table AppointmentDoctorPatient
Add Constraint DefaultAppointmentStatus
Default 'NoShow'  FOR AppoitmentStatus;


alter Table AppointmentDoctorPatient
Add Constraint DefaultDateTime
Default GetDate() FOR AppointmentDateTime;

Select *  from Person;

Alter Table Person
Add Constraint UQ_PersonRecord
Unique(Name,DateOfBirth,Gender,Address);


-- add sample appointment
Select * From AppointmentDetails; -- data view 
Select * from  DoctorsFullDetails;
Select * from PatientFullDetails;

select * from AppointmentDoctorPatient;

-- How To Get Age Of Patient By His Date Of Birth
Select ABS (DATEDIFF(YEAR , GETDATE() , 
(Select DoctorsFullDetails.DateOfBirth from DoctorsFullDetails where DoctorsFullDetails.PersonId=10)
) )
as DaysDifference;



insert into AppointmentDoctorPatient(ADoctorId,APatientId,
AppointmentDateTime)
values 
(

( Select DoctorsFullDetails.DoctorId from DoctorsFullDetails where DoctorsFullDetails.PersonId=10) ,
(Select PatientFullDetails.PatientId from PatientFullDetails where PatientFullDetails.PersonId=6) ,
GetDate() 

);


select * from AppointmentDoctorPatient; -- Main table 
Select * from AppointmentIDDetails; -- ids only 

Select * From PatientFullDetails;
Select * From DoctorsFullDetails;

Alter Table AppointmentDoctorPatient
Add Constraint UQ_Record
Unique (ADoctorId,APatientId,AppointmentDateTime,AppoitmentStatus);


--- Insert New Appointment
Insert Into AppointmentDoctorPatient(ADoctorId,APatientId,AppointmentDateTime,AppoitmentStatus)
values 
('@DoctorId' ,'@PatientId' , '@DateTime' , 'Status'  )
Select SCOPE_IDENTITY();

-- Delete Appointment 
Delete AppointmentDoctorPatient
Where AppointmentDoctorPatient.AppointmentId ='@ID';

-- Delete Appointment
Update AppointmentDoctorPatient
Set AppointmentId ='AId' ,
ADoctorId = '@DoctorId' ,
APatientId = '@PatientId' ,
AppointmentDateTime = '@AppointmentDT' ,
AppoitmentStatus = '@Status' ;

--- Find by id 
select * from AppointmentDoctorPatient   -- Main table
where AppointmentId = '@ID' ;  


create Index indx_PatientId
On AppointmentDoctorPatient(APatientId)


create Index indx_DoctorId
On AppointmentDoctorPatient(ADoctorId)

create Index Indx_PatientIDForPatientTable
On Patient(PatientPersonId)

Create Index Indx_DoctorIDForDoctorTable
On Doctor(DoctorPersonId)

Select * From DoctorsFullDetails
      where DoctorsFullDetails.PersonId = 2


 
      Select * from AppointmentDetails ;
      Select * from Doctor;

      Select * From AppointmentDoctorPatient;




      Select * from AppointmentIDDetails;


      Select * From DoctorsFullDetails
      where DoctorId = 12 ;

      Select * From PatientFullDetails
      where PatientId = 7;

      -- Update Appointment
      Update AppointmentDoctorPatient
      Set ADoctorId = 2 , 
      APatientId = 5 ,
      AppointmentDateTime = '11/2/2026',
      AppoitmentStatus = 'Completed' 
      where AppointmentId = 1;

      ----------------- Admins 

      select * from AdminFullInfo
      where AdminFullInfo.PersonId ='@UserName';
      
      select * from AdminLogin ;
      Update AdminLogin
      set AdminPermissions = 30
      where AdminId=3;

      alter Table AdminLogin
      Add Constraint UQ_Username
      Unique(UserName);

