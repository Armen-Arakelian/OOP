using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MyExceptionArgs
{
    private string message;

    public string Message { get { return message; } }
    public MyExceptionArgs(string message)
    {
        this.message = message;
    }

}

