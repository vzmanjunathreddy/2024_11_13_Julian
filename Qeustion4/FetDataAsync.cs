using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qeustion4;

public class FetDataAsync
{
    public async Task<string> FetchDataFromAPI1()
    {
        return "data from API 1";
    }

    public async Task<string> FetchDataFromAPI2()
    {
        return "data from API 2";
    }
}
