create View PatientFullDetails
As


Select  Person.PersonId ,Person.Name , Email.Email , Phone.PhoneNumber , Person.Gender 
,Person.DateOfBirth , Person.Address 
from Patient 
Inner Join Person On Patient.PatientPersonId = Person.PersonId

Inner Join Email On Email.PersonId =Person.PersonId 
Inner Join Phone On Phone.PersonId = Person.PersonId;

--------------------------------------

Create View AdminFullInfo
As
Select Person.PersonId,AdminLogin.UserName,AdminLogin.AdminPassword
,AdminLogin.AdminPermissions,Person.Name,Person.DateOfBirth,Person.Gender,Person.Address,
Email.Email , Phone.PhoneNumber
From Person
Inner Join AdminLogin On AdminLogin.AdminPersonId = Person.PersonId
Inner Join Email On Email.PersonId = Person.PersonId
Inner Join Phone On Phone.PersonId = Person.PersonId;



------------
create view DoctorPersonID
As
Select Doctor.DoctorPersonId
from Person
Inner Join Doctor  On Doctor.DoctorPersonId = Person.PersonId

----------------------
create view AppointmentDetails
AS 
Select AppointmentDoctorPatient.AppointmentId,AppointmentDoctorPatient.AppointmentDateTime AS DateAndTime ,

DoctorsFullDetails.DoctorName ,DoctorsFullDetails.Specialization,
DoctorsFullDetails.PhoneNumber AS DoctorPhoneNum ,DoctorsFullDetails.Gender As DoctorGender,

PatientFullDetails.Name AS PatientName ,PatientFullDetails.PhoneNumber AS PatientPhoneNum  ,
PatientAge = Year(GetDate() - CAST (PatientFullDetails.DateOfBirth  As datetime) ) 
,AppointmentDoctorPatient.AppoitmentStatus

From AppointmentDoctorPatient
Inner Join DoctorsFullDetails On DoctorsFullDetails.DoctorId = AppointmentDoctorPatient.ADoctorId
Inner Join PatientFullDetails on PatientFullDetails.PatientId = AppointmentDoctorPatient.APatientId

--------
Create View AppointmentIDDetails
As
Select AppointmentDoctorPatient.AppointmentId , AppointmentDoctorPatient.APatientId As PatientId
,AppointmentDoctorPatient.ADoctorId AS DoctorId
From AppointmentDoctorPatient;


----- -------------------
