#pragma once

#include "NdapiObject.h"

namespace Ndapi
{
	public ref class ProgramUnit : NdapiObject
	{
	public protected:
		ProgramUnit(d2fob* program_unit);

	public:
		property String^ Comment { String^ get(); void set(String^ value); }
		property String^ Text { String^ get(); void set(String^ value); }
	};
}