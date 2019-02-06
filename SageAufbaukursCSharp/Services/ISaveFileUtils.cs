using System;


namespace SageAufbaukursCSharp.Services
{
    public interface ISaveFileUtils
    {
        Exception Fault { get; set; }

        string Message { get; }

        string FaultbackPath { get; }

        bool Save(object beleg);
        //bool Save(object beleg, string path);
    }
}
