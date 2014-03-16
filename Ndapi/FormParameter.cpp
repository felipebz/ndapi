#include "stdafx.h"
#include "FormParameter.h"

namespace Ndapi
{
	FormParameter::FormParameter() : NdapiObject()
	{
	}

	FormParameter::FormParameter(d2fob* program_unit) : NdapiObject(program_unit)
	{
	}

	FormParameter::FormParameter(FormModule^ form, String^ name)
	{
		Create(name, form, D2FFO_FORM_PARAM);
	}

	String^ FormParameter::Comment::get()
	{
		return GetStringProperty(D2FP_COMMENT);
	}

	void FormParameter::Comment::set(String^ value)
	{
		SetStringProperty(D2FP_COMMENT, value);
	}

	long FormParameter::MaximumLength::get()
	{
		return GetNumberProperty(D2FP_MAX_LEN);
	}

	void FormParameter::MaximumLength::set(long value)
	{
		SetNumberProperty(D2FP_MAX_LEN, value);
	}

	String^ FormParameter::Name::get()
	{
		return GetStringProperty(D2FP_NAME);
	}

	void FormParameter::Name::set(String^ value)
	{
		SetStringProperty(D2FP_NAME, value);
	}

	ParameterDataType FormParameter::DataType::get()
	{
		return GetNumberProperty<ParameterDataType>(D2FP_PARAM_DAT_TYP);
	}

	void FormParameter::DataType::set(ParameterDataType value)
	{
		SetNumberProperty(D2FP_PARAM_DAT_TYP, value);
	}

	String^ FormParameter::InitialValue::get()
	{
		return GetStringProperty(D2FP_PARAM_INIT_VAL);
	}

	void FormParameter::InitialValue::set(String^ value)
	{
		SetStringProperty(D2FP_PARAM_INIT_VAL, value);
	}
}