// See https://aka.ms/new-console-template for more information
using Question1;
using System.Security.Authentication.ExtendedProtection;

Console.WriteLine("Hello, World!");

//DIP
var logger = new Logger();

var userService = new UsersService(logger);

userService.Register("Julian", "Lorenzo", "abc@abc.com");

//DIP
