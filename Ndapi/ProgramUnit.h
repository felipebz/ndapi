#pragma once

#include "NdapiObject.h"
#include <D2FPGU.H>

namespace Ndapi
{
	public ref class ProgramUnit : NdapiObject
	{
	public protected:
		ProgramUnit(d2fob* program_unit);
	};
}