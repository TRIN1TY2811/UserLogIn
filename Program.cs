// See https://aka.ms/new-console-template for more information

using System.Xml.Serialization;


string username = "TRIN1TY";
string password = "sigmaboi67";

Console.WriteLine("Account Management System");
Console.Write("Enter Username: ");
string usernameInput = Console.ReadLine();
Console.Write("Enter Password: ");
string userPasswordInput = Console.ReadLine();

if (usernameInput == username && userPasswordInput == password)
{

    Console.WriteLine("Login successful! Welcome, " + username + "!");



}

else
{


    Console.WriteLine("Incorrect username and password!");
}


