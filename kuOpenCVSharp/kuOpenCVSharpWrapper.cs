using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kuOpenCVWRCCpp;

namespace kuOpenCVSharp
{
    public sealed class kuOpenCVSharpWrapper
    {
        kuOpenCVWRCWrapper CppWrapper = new kuOpenCVWRCWrapper();

        public double kuTestFunctionSharp(int a, int b)
        {
            return CppWrapper.kuTestFunctionCpp(a, b);
        }
    }
}
