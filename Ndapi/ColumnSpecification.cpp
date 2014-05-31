#include "stdafx.h"
#include "ColumnSpecification.h"

namespace Ndapi
{
	ColumnSpecification::ColumnSpecification() : NdapiObject()
	{
	}

	ColumnSpecification::ColumnSpecification(d2fob* alert) : NdapiObject(alert)
	{
	}

	ColumnSpecification::ColumnSpecification(FormModule^ form, String^ name)
	{
		Create(name, form, D2FFO_RG_COLSPEC);
	}

	Ndapi::ColumnSpecificationDataType ColumnSpecification::DataType::get()
	{
		return GetNumberProperty<Ndapi::ColumnSpecificationDataType>(D2FP_COL_DAT_TYP);
	}

	void ColumnSpecification::DataType::set(Ndapi::ColumnSpecificationDataType value)
	{
		SetNumberProperty(D2FP_COL_DAT_TYP, value);
	}

	long ColumnSpecification::ValueCount::get()
	{
		return GetNumberProperty(D2FP_COL_VALS_COUNT);
	}

	long ColumnSpecification::MaximumLength::get()
	{
		return GetNumberProperty(D2FP_MAX_LEN);
	}

	void ColumnSpecification::MaximumLength::set(long value)
	{
		SetNumberProperty(D2FP_MAX_LEN, value);
	}

	String^ ColumnSpecification::Name::get()
	{
		return GetStringProperty(D2FP_NAME);
	}

	void ColumnSpecification::Name::set(String^ value)
	{
		SetStringProperty(D2FP_NAME, value);
	}

	NdapiEnumerator<NdapiObject^>^ ColumnSpecification::Values::get()
	{
		return gcnew NdapiObjectEnumerator<NdapiObject^>(_handler, D2FP_COLUMN_VALUE);
	}
}
