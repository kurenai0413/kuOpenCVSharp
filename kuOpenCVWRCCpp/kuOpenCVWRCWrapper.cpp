#include "pch.h"
#include "kuOpenCVWRCWrapper.h"

using namespace kuOpenCVWRCCpp;
using namespace Platform;

kuOpenCVWRCWrapper::kuOpenCVWRCWrapper()
{
}

double kuOpenCVWRCWrapper::kuTestFunctionCpp(int a, int b)
{
	return (double)(a + b);
}
