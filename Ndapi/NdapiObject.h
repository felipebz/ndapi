#pragma once

#include <D2FOB.H>

#include "Ndapi.h"
#include "NdapiContext.h"
#include "NdapiEnums.h"

using namespace System;

namespace Ndapi
{
	public ref class NdapiObject
	{
	public protected:
		d2fob* _handler;

		NdapiObject();
		NdapiObject(d2fob* object);
		void FillWithObject(void* object);

	public:
		String^ GetStringProperty(int property_id);
		void SetStringProperty(int property_id, String^ value);
		long GetNumberProperty(int property_id);
		void SetNumberProperty(int property_id, long value);

		property String^ Name { String^ get(); void set(String^ value); }
		property String^ ParentFileName { String^ get(); void set(String^ value); }
		property String^ ParentFileNamePath { String^ get(); void set(String^ value); }
		property ModuleStorageType ParentModuleStorage { ModuleStorageType get(); void set(ModuleStorageType value); }
		property long ParentModuleType { long get(); void set(long value); }
		property String^ ParentModule { String^ get(); void set(String^ value); }
		property String^ ParentName { String^ get(); void set(String^ value); }
		property long ParentType { long get(); void set(long value); }
	};
}