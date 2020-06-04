

--Insert Query to insert new record to Customer Table


INSERT INTO Customer(Customer_IDNumber,Customer_Name,Customer_SSNumber,Customer_BDate, 
Customer_Address,Customer_Phone,Customer_Email)

VALUES('1122','Mohammad Khan','424-45-4523','03/01/1989','127 st street , Astoria NY',
 '212 342-2341','khan@mail.com');



 INSERT INTO Customer(Customer_IDNumber,Customer_Name,Customer_SSNumber,Customer_BDate, 
Customer_Address,Customer_Phone,Customer_Email)

VALUES('1133','Mohammad Chowdhury','424-45-4333','03/01/1990','128 st street , Astoria NY',
 '212 342-2342','chowdhury@mail.com');


 
 --Select query

 SELECT *
 FROM Customer;

  --Update query

 UPDATE Customer
 SET Customer_Name ='Kamal Khan',Customer_SSNumber ='563-24-4523' ,Customer_BDate ='02/12/1992',
 Customer_Address ='127 st street , Astoria NY',Customer_Phone ='212 342-2342',Customer_Email = 'khan@mail.com'
 WHERE Customer_IDNumber = '1122';

 
 

 --Delete query

  DELETE FROM Customer
  WHERE Customer_IDNumber = '1122';





