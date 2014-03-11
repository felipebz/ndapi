#pragma once

#include "NdapiObject.h"
#include "FormModule.h"

namespace Ndapi
{
	ref class FormModule;

	public ref class AttachedLibrary : NdapiObject
	{
	public protected:
		AttachedLibrary(d2fob* program_unit);

	public:
		AttachedLibrary();
		property String^ Comment { String^ get(); void set(String^ value); }
		property String^ Location { String^ get(); }
		property Ndapi::SourceType SourceType { Ndapi::SourceType get(); }
		property String^ Name { String^ get(); }
	};
}