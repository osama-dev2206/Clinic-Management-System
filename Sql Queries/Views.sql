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



