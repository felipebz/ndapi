#pragma once

#include "NdapiObject.h"
#include "FormModule.h"

namespace Ndapi
{
	public ref class ColumnSpecification : NdapiObject
	{
	public protected:
		ColumnSpecification(d2fob* alert);

	public:
		ColumnSpecification();
		ColumnSpecification(FormModule^ form, String^ name);

		property Ndapi::ColumnSpecificationDataType DataType { Ndapi::ColumnSpecificationDataType get(); void set(Ndapi::ColumnSpecificationDataType value); }
		property long ValueCount { long get(); }
		property long MaximumLength { long get(); void set(long value); }
		property String^ Name { String^ get(); void set(String^ value); }

		property NdapiEnumerator<NdapiObject^>^ Values { NdapiEnumerator<NdapiObject^>^ get(); }
	};
}



