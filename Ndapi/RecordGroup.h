#pragma once

#include "NdapiObject.h"
#include "FormModule.h"

namespace Ndapi
{
	public ref class RecordGroup : NdapiObject
	{
	public protected:
		RecordGroup(d2fob* alert);

	public:
		RecordGroup();
		RecordGroup(FormModule^ form, String^ name);

		property NdapiObject^ ColumnSpecifications { NdapiObject^ get(); }
		property String^ Comment { String^ get(); void set(String^ value); }
		property String^ Name { String^ get(); void set(String^ value); }
		property long FetchSize { long get(); void set(long value); }
		property String^ Query { String^ get(); void set(String^ value); }
		property RecordGroupType Type { RecordGroupType get(); void set(RecordGroupType value); }
	};
}

