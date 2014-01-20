#include "stdafx.h"
#include "NdapiObject.h"

namespace Ndapi
{
	NdapiObject::NdapiObject(d2fob* object)
	{
		internal_object = object;
	}

	String^ NdapiObject::GetStringProperty(int property_id)
	{
		text* property_value;

		auto status = d2fobgt_GetTextProp(NdapiContext::Context, internal_object, property_id, &property_value);
		if (status != D2FS_SUCCESS)
		{
			throw gcnew NdapiException(String::Format("Error while getting a string property. Property id: {0}", property_id), status);
		}
		return gcnew String((char*)property_value);
	}

	void NdapiObject::SetStringProperty(int property_id, String^ value)
	{
		auto internal_value = StringToText(value);

		auto status = d2fobst_SetTextProp(NdapiContext::Context, internal_object, property_id, internal_value);
		if (status != D2FS_SUCCESS)
		{
			throw gcnew NdapiException(String::Format("Error while setting a string property. Property id: {0}", property_id), status);
		}

	}

	long NdapiObject::GetNumberProperty(int property_id)
	{
		number property_value;

		auto status = d2fobgn_GetNumProp(NdapiContext::Context, internal_object, property_id, &property_value);
		if (status != D2FS_SUCCESS)
		{
			throw gcnew NdapiException(String::Format("Error while getting a number property. Property id: {0}", property_id), status);
		}

		return (long)property_value;
	}

	void NdapiObject::SetNumberProperty(int property_id, long value)
	{
		number property_value = (number)value;

		auto status = d2fobgn_GetNumProp(NdapiContext::Context, internal_object, property_id, &property_value);
		if (status != D2FS_SUCCESS)
		{
			throw gcnew NdapiException(String::Format("Error while setting a number property. Property id: {0}", property_id), status);
		}
	}
}