using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ArupConsoleService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MathService" in both code and config file together.
    public class MathService : IMathService
    {

        int IMathService.Addition(int a, int b)
        {
            return a + b;
        }
    }
}
