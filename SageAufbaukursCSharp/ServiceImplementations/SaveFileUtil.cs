using SageAufbaukursCSharp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SageAufbaukursCSharp.ServiceImplementations
{
    public class SaveFileUtil : ISaveFileUtils
    {

        #region ISaveFileUtil
        public Exception Fault { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string Message { get; private set; }

        public string FaultbackPath { get; private set; }

        public bool Save(object beleg)
        {
            try
            {
                using (var sw = new StreamWriter(""))
                {
                    sw.Write("hello");
                }
                return true;
            }
            catch(UnauthorizedAccessException uae)
            {
                Message = uae.Message;
                Fault = uae;
                return false;
            }
            catch (ArgumentException ae)
            {

                try
                {
                    FaultbackPath = "%ProgramData%";
                    using (var sw = new StreamWriter(FaultbackPath))
                    {
                        sw.Write("hello");
                    }

                    //Aufruf Service für Verschieben von Faultback in Work-Verzeichnis
                    return true;
                }
                catch (Exception ex)
                {
                    Message = ex.Message;
                    Fault = ex;

                    return false;
                }

                                
            }

            catch (PathTooLongException ptle)
            {

            }
            catch (Exception ex)
            {
                Fault = ex;
                return false;
            }
        }
        #endregion ISaveFileUtil

        #region services

        #endregion services
    }
}
