using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1;

public class UsersService
{
    private readonly Logger _logger;

    public UsersService(Logger logger)
    {
        _logger = logger;
    }

    public bool Register(string name, string lastName, string email)
    {
        //validate input info
        //check in DB if the email already exist
        //register user
        //return true if all is ok
        _logger.Log($"User registered: {name} {lastName}, {email}");
        return true;
    }

    public bool RegisterViolating(string name, string lastName, string email)
    {
        //validate input info
        //check in DB if the email already exist
        //register user
        Console.WriteLine($"User registered: {name} {lastName}, {email}"); //logging user registration
        //return true if all is ok
        return true;
    }
}
