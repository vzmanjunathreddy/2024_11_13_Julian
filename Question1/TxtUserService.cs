using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1;

public class TxtUserService : UsersService
{
    private readonly Logger _logger;
    public TxtUserService(Logger logger) : base(logger)
    {
        _logger = logger;
    }

    public bool Register(string name, string lastName, string email)
    {
        //use input validation from base
        //use input verification from base
        //register to txt
        //log action
        _logger.Log("User registered to txt file");
        //return apropiately
        return true;
    }
}
