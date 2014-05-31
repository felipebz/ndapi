#pragma once

#include <D2FOB.H>
#include <D2FDEF.H>

#include "Ndapi.h"
#include "NdapiContext.h"
#include "NdapiEnums.h"

using namespace System;
using namespace System::Text;

namespace Ndapi
{
	public ref class NdapiObject
	{
	public protected:
		d2fob* _handler;

		NdapiObject(d2fob* object);
		void FillWithObject(d2fob* object);
		void Create(String^ name, d2fotyp object_type);
		void Create(String^ name, NdapiObject^ parent, d2fotyp object_type);

	public:
		NdapiObject();
		String^ GetStringProperty(int property_id);
		void SetStringProperty(int property_id, String^ value);
		long GetNumberProperty(int property_id);
		void SetNumberProperty(int property_id, long value);
		bool GetBooleanProperty(int property_id);
		void SetBooleanProperty(int property_id, bool value);

		generic <typename T>
		T GetNumberProperty(int property_id);

		generic <typename T>
		void SetNumberProperty(int property_id, T value);

		generic <class T> where T : NdapiObject
		T GetObjectProperty(int property_id);
		
		generic <class T> where T : NdapiObject
		void SetObjectProperty(int property_id, T value);

		property bool IsSubclassed { bool get(); }
		property String^ Name { String^ get(); void set(String^ value); }
		property NdapiObject^ Owner { NdapiObject^ get(); }
		property String^ ParentFileName { String^ get(); void set(String^ value); }
		property String^ ParentFileNamePath { String^ get(); void set(String^ value); }
		property ModuleStorageType ParentModuleStorage { ModuleStorageType get(); void set(ModuleStorageType value); }
		property long ParentModuleType { long get(); void set(long value); }
		property String^ ParentModule { String^ get(); void set(String^ value); }
		property String^ ParentName { String^ get(); void set(String^ value); }
		property long ParentType { long get(); void set(long value); }

		String^ GetQualifiedName(bool includeModule);
		bool HasOverriddenProperty(int property_id);
		virtual String^ ToString() override;
	};
}