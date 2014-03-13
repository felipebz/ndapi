#pragma once

#include "NdapiObject.h"
#include "FormModule.h"
#include "ColumnSpecification.h"

namespace Ndapi
{
	ref class ColumnSpecification;

	public ref class RecordGroup : NdapiObject
	{
	public protected:
		RecordGroup(d2fob* alert);

	public:
		RecordGroup();
		RecordGroup(FormModule^ form, String^ name);

		property String^ Comment { String^ get(); void set(String^ value); }
		property String^ Name { String^ get(); void set(String^ value); }
		property long FetchSize { long get(); void set(long value); }
		property String^ Query { String^ get(); void set(String^ value); }
		property RecordGroupType Type { RecordGroupType get(); void set(RecordGroupType value); }

		property NdapiEnumerator<ColumnSpecification^>^ ColumnSpecifications { NdapiEnumerator<ColumnSpecification^>^ get(); }
	};
}

