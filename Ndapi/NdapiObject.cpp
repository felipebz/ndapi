#include "stdafx.h"
#include "NdapiObject.h"

namespace Ndapi
{
	NdapiObject::NdapiObject()
	{
	}

	NdapiObject::NdapiObject(d2fob* object)
	{
		_handler = object;
	}

	void NdapiObject::FillWithObject(d2fob* object)
	{
		_handler = object;
	}

	void NdapiObject::Create(String^ name, d2fotyp object_type)
	{
		pin_ptr<d2fob*> object = &_handler;
		NativeString<text> internal_name(name);

		auto status = d2fobcr_Create(NdapiContext::Context, NdapiContext::Context, object, internal_name, object_type);
		CheckStatusAndThrow(status, String::Format("Error creating a object. Type: {0}", object_type));
	}

	void NdapiObject::Create(String^ name, NdapiObject^ parent, d2fotyp object_type)
	{
		pin_ptr<d2fob*> object = &_handler;
		NativeString<text> internal_name(name);

		auto status = d2fobcr_Create(NdapiContext::Context, parent->_handler, object, internal_name, object_type);
		CheckStatusAndThrow(status, String::Format("Error creating a object. Type: {0}", object_type));
	}

	String^ NdapiObject::GetStringProperty(int property_id)
	{
		text* property_value;

		auto status = d2fobgt_GetTextProp(NdapiContext::Context, _handler, property_id, &property_value);
		CheckStatusAndThrow(status, String::Format("Error getting a string property. Property id: {0}", property_id));

		return gcnew String((char*)property_value);
	}

	void NdapiObject::SetStringProperty(int property_id, String^ value)
	{
		NativeString<text> internal_value(value);

		auto status = d2fobst_SetTextProp(NdapiContext::Context, _handler, property_id, internal_value);
		CheckStatusAndThrow(status, String::Format("Error setting a string property. Property id: {0}", property_id));

	}

	long NdapiObject::GetNumberProperty(int property_id)
	{
		number property_value;

		auto status = d2fobgn_GetNumProp(NdapiContext::Context, _handler, property_id, &property_value);
		CheckStatusAndThrow(status, String::Format("Error getting a number property. Property id: {0}", property_id));

		return safe_cast<long>(property_value);
	}

	void NdapiObject::SetNumberProperty(int property_id, long value)
	{
		number property_value = (number)value;

		auto status = d2fobsn_SetNumProp(NdapiContext::Context, _handler, property_id, property_value);
		CheckStatusAndThrow(status, String::Format("Error setting a number property. Property id: {0}", property_id));
	}

	bool NdapiObject::GetBooleanProperty(int property_id)
	{
		boolean value;

		auto status = d2fobgb_GetBoolProp(NdapiContext::Context, _handler, property_id, &value);
		CheckStatusAndThrow(status, String::Format("Error getting a boolean property. Property id: {0}", property_id));

		return value == TRUE;
	}

	void NdapiObject::SetBooleanProperty(int property_id, bool value)
	{
		auto status = d2fobsb_SetBoolProp(NdapiContext::Context, _handler, property_id, value);
		CheckStatusAndThrow(status, String::Format("Error setting a boolean property. Property id: {0}", property_id));
	}

	generic <typename T>
	T NdapiObject::GetNumberProperty(int property_id)
	{
		return safe_cast<T>(GetNumberProperty(property_id));
	}

	generic <typename T>
	void NdapiObject::SetNumberProperty(int property_id, T value)
	{
		SetNumberProperty(property_id, safe_cast<long>(value));
	}

	generic <class T>
	T NdapiObject::GetObjectProperty(int property_id)
	{
		d2fob* object;

		auto status = d2fobgo_GetObjProp(NdapiContext::Context, _handler, property_id, &object);
		CheckStatusAndThrow(status, String::Format("Error getting a object property. Property id: {0}", property_id));

		return safe_cast<T>(gcnew NdapiObject(object));
	}

	generic <class T>
	void NdapiObject::SetObjectProperty(int property_id, T value)
	{
		auto status = d2fobso_SetObjProp(NdapiContext::Context, _handler, property_id, value->_handler);
		CheckStatusAndThrow(status, String::Format("Error setting a object property. Property id: {0}", property_id));
	}

	String^ NdapiObject::Name::get()
	{
		return GetStringProperty(D2FP_NAME);
	}

	void NdapiObject::Name::set(String^ value)
	{
		SetStringProperty(D2FP_NAME, value);
	}

	String^ NdapiObject::ParentFileName::get()
	{
		return GetStringProperty(D2FP_PAR_FLNAM);
	}

	void NdapiObject::ParentFileName::set(String^ value)
	{
		SetStringProperty(D2FP_PAR_FLNAM, value);
	}

	String^ NdapiObject::ParentFileNamePath::get()
	{
		return GetStringProperty(D2FP_PAR_FLPATH);
	}

	void NdapiObject::ParentFileNamePath::set(String^ value)
	{
		SetStringProperty(D2FP_PAR_FLPATH, value);
	}

	ModuleStorageType NdapiObject::ParentModuleStorage::get()
	{
		return safe_cast<ModuleStorageType>(GetNumberProperty(D2FP_PAR_MODSTR));
	}

	void NdapiObject::ParentModuleStorage::set(ModuleStorageType value)
	{
		SetNumberProperty(D2FP_PAR_MODSTR, safe_cast<long>(value));
	}

	long NdapiObject::ParentModuleType::get()
	{
		return GetNumberProperty(D2FP_PAR_MODTYP);
	}

	void NdapiObject::ParentModuleType::set(long value)
	{
		SetNumberProperty(D2FP_PAR_MODTYP, value);
	}

	String^ NdapiObject::ParentModule::get()
	{
		return GetStringProperty(D2FP_PAR_MODULE);
	}

	void NdapiObject::ParentModule::set(String^ value)
	{
		SetStringProperty(D2FP_PAR_MODULE, value);
	}

	String^ NdapiObject::ParentName::get()
	{
		return GetStringProperty(D2FP_PAR_NAM);
	}

	void NdapiObject::ParentName::set(String^ value)
	{
		SetStringProperty(D2FP_PAR_NAM, value);
	}

	long NdapiObject::ParentType::get()
	{
		return GetNumberProperty(D2FP_PAR_TYP);
	}

	void NdapiObject::ParentType::set(long value)
	{
		SetNumberProperty(D2FP_PAR_TYP, value);
	}

	String^ NdapiObject::ToString()
	{
		return Name;
	}
}