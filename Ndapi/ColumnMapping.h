#pragma once

#include "NdapiObject.h"
#include "FormModule.h"

namespace Ndapi
{
	public ref class ColumnMapping : NdapiObject
	{
	public protected:
		ColumnMapping(d2fob* alert);

	public:
		ColumnMapping();
		ColumnMapping(FormModule^ form, String^ name);

		property long DisplayWidth { long get(); void set(long value); }
		property String^ ReturnItem { String^ get(); void set(String^ value); }
		property String^ Title { String^ get(); void set(String^ value); }
	};
}

