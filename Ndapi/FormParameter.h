#pragma once

#include "NdapiObject.h"
#include "FormModule.h"

namespace Ndapi
{
	ref class FormModule;

	public ref class FormParameter : NdapiObject
	{
	public protected:
		FormParameter(d2fob* program_unit);

	public:
		FormParameter();
		FormParameter(FormModule^ form, String^ name);
		property String^ Comment { String^ get(); void set(String^ value); }
		property long MaximumLength { long get(); void set(long value); }
		property String^ Name { String^ get(); void set(String^ value); }
		property ParameterDataType DataType { ParameterDataType get(); void set(ParameterDataType value); }
		property String^ InitialValue { String^ get(); void set(String^ value); }
	};
}