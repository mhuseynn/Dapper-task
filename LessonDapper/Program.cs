using Dapper;
using System.Data;
using System.Data.SqlClient;

string constr = "Data Source=DESKTOP-R8Q6LD3\\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True;Connect Timeout=30;Encrypt=False;";

SqlConnection sqlConnection = new SqlConnection(constr);

sqlConnection.Open();


//Insert 
//string insertqueryAuthor = "INSERT INTO Authors(Id,FirstName, LastName) VALUES (15,'Author1', 'Author1') , (16,'Author2', 'Author2') , (17,'Author3', 'Author3')";
//string insertQuery = "Insert INTO Authors (Id,FirstName, LastName) Values (80 ,   'filankes'  ,    'mehdiyev')";
//string insertQuery1 = "Insert INTO Authors (Id,FirstName, LastName) Values (81 ,  'filankes1'  ,    'aliyev')";
//string insertQuery2 = "Insert INTO Authors (Id,FirstName, LastName) Values (82 ,  'filankes2'  ,    'filankesov1')";
//string insertQuery3 = "Insert INTO Authors (Id,FirstName, LastName) Values (444 ,  'filankes3'  ,    'filankesov2')";
//string insertQuery4 = "Insert INTO Authors (Id,FirstName, LastName) Values (333 ,  'filankes4'  ,    'filankesov3')";
//string insertQuery5 = "Insert INTO Authors (Id,FirstName, LastName) Values (222 ,  'filankes5'  ,    'filankesov4')";
//string insertQuery6 = "Insert INTO Authors (Id,FirstName, LastName) Values (111 ,  'filankes6'  ,    'filankesov5')";
//string insertQuery7 = "Insert INTO Authors (Id,FirstName, LastName) Values (109 ,  'filankes7'  ,    'filankesov6')";
//string insertQuery8 = "Insert INTO Authors (Id,FirstName, LastName) Values (108 ,  'filankes8'  ,    'filankesov7')";
//string insertQuery9 = "Insert INTO Authors (Id,FirstName, LastName) Values (88 ,  'filankes9'  ,    'filankesov0')";



////Delete
//string deletequeryAuthor = "DELETE  FROM Authors WHERE Id Between 15 and 17";
//string deleteQuery1 = "DELETE FROM Authors WHERE Id = 1";
//string deleteQuery2 = "DELETE FROM Authors WHERE FirstName = 'John' AND LastName = 'Doe'";
//string deleteQuery3 = "DELETE FROM Authors WHERE LastName LIKE 'Smith%'";
//string deleteQuery4 = "DELETE FROM Authors WHERE Id IN (1, 2, 3)";
//string deleteQuery5 = "DELETE FROM Authors WHERE FirstName = 'Jane' OR LastName = 'Doe'";
//string deleteQuery21 = "DELETE FROM Books WHERE Id = 1";
//string deleteQuery22 = "DELETE FROM Books WHERE Name = 'Book1'";
//string deleteQuery23 = "DELETE FROM Books WHERE YearPress < 2000";
//string deleteQuery24 = "DELETE FROM Books WHERE Pages > 500";
//string deleteQuery25 = "DELETE FROM Books WHERE Id_Author = 1";


////Update
//string updatequery1 = "Update  Authors SET FirstName = 'Updated'  WHERE Id Between 15 and 17";


////Insert 
//sqlConnection.Execute(insertqueryAuthor);
//sqlConnection.Execute(insertQuery1);
//sqlConnection.Execute(insertQuery2);
//sqlConnection.Execute(insertQuery3);
//sqlConnection.Execute(insertQuery4);
//sqlConnection.Execute(insertQuery5);
//sqlConnection.Execute(insertQuery6);
//sqlConnection.Execute(insertQuery7);
//sqlConnection.Execute(insertQuery8);
//sqlConnection.Execute(insertQuery9);
//sqlConnection.Execute(insertQuery);



////Delete
//sqlConnection.Execute(deleteQuery1);
//sqlConnection.Execute(deleteQuery2);
//sqlConnection.Execute(deleteQuery3);
//sqlConnection.Execute(deleteQuery4);
//sqlConnection.Execute(deleteQuery5);
//sqlConnection.Execute(deleteQuery21);
//sqlConnection.Execute(deleteQuery22);
//sqlConnection.Execute(deleteQuery23);
//sqlConnection.Execute(deleteQuery24);
//sqlConnection.Execute(deleteQuery25);






//Update
//sqlConnection.Execute(updatequery1);