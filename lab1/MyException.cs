using System;

class MyException : Exception
{
    MyExceptionArgs args;
    public MyExceptionArgs Args
    {
        get { return args; }
    }
    public MyException(MyExceptionArgs args) : base(args.Message)
    {
        this.args = args;
    }

} 
