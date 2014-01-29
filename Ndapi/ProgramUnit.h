#pragma once

#include "NdapiObject.h"
#include "FormModule.h"

namespace Ndapi
{
	ref class FormModule;

	public ref class ProgramUnit : NdapiObject
	{
	public protected:
		ProgramUnit(d2fob* program_unit);

	public:
		ProgramUnit();
		ProgramUnit(FormModule^ form, String^ name);
		property String^ Comment { String^ get(); void set(String^ value); }
		property String^ Text { String^ get(); void set(String^ value); }
	};
}