using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ArupConsoleService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MathService" in both code and config file together.
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class MathService : IMathService
    {

        int IMathService.Addition(string a, string b)
        {
            try
            {
                int na = convert(a);
                int nb = convert(b);
                return na + nb;
            } 
            catch (ApplicationException ex)
            {
                //throw new FaultException<ApplicationException>(ex, "conv fault code");
                throw new FaultException(ex.Message);
            }
            catch (Exception ex)
            {
                AppFaultData faultdata = new AppFaultData();
                faultdata.ErrorCode = 8876;
                throw new FaultException<AppFaultData>(faultdata, "App fault occured");
            }
        }

        int convert(string n)
        {
            int i = 0;
            try
            {
                i = Convert.ToInt32(n);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Unable to convert string parameter to integer", ex);
            }
            if (i < 5)
            {
                throw new Exception("Politely refusing to add small numbers. Try a bigger number!");
            }
            return i;
        }
    }
}
