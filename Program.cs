// See https://aka.ms/new-console-template for more information
using WelComeApp;

Console.WriteLine("Hello, World!");


Console.WriteLine("Welcome to Authenticate app");
SignIn obj = new SignIn();
Console.WriteLine(obj.Authenticate("admin", "admin@123"));