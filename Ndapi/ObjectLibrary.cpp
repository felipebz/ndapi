#include "stdafx.h"
#include "ObjectLibrary.h"

using namespace System::IO;

namespace Ndapi
{
	ObjectLibrary::ObjectLibrary(d2fob* form_module) : NdapiObject(form_module)
	{
	}

	ObjectLibrary::ObjectLibrary(String^ name) {
		Create(name, D2FFO_LIBRARY_MODULE);
	}

	ObjectLibrary^ ObjectLibrary::Open(String^ file)
	{
		if (!File::Exists(file)) {
			throw gcnew FileNotFoundException("Module file not found", file);
		}

		NativeString<text> filename(file);

		d2folb* olb_module;
		auto status = d2folbld_Load(NdapiContext::Context, &olb_module, filename, FALSE);
		CheckStatusAndThrow(status, String::Format("Error opening the object library. Path: {0}", file));

		return gcnew ObjectLibrary(olb_module);
	}

	String^ ObjectLibrary::Name::get()
	{
		return GetStringProperty(D2FP_NAME);
	}

	void ObjectLibrary::Name::set(String^ value)
	{
		SetStringProperty(D2FP_NAME, value);
	}

	long ObjectLibrary::ObjectCount::get()
	{
		return GetNumberProperty(D2FP_OBJ_COUNT);
	}

	NdapiObject^ ObjectLibrary::ObjectLibraryTabs::get()
	{
		return GetObjectProperty<NdapiObject^>(D2FP_OBJ_LIB_TAB);
	}

	NdapiEnumerator<NdapiObject^>^ ObjectLibrary::Objects::get()
	{
		return gcnew NdapiObjectLibraryEnumerator(this);
	}

	NdapiObject^ ObjectLibrary::GetObjectByPosition(long position)
	{
		d2fob* object;
		auto status = d2folbf2_Findobjbypos(NdapiContext::Context, _handler, position, &object);
		CheckStatusAndThrow(status, String::Format("Error getting the object at position: {0}", position));

		return gcnew NdapiObject(object);
	}

	ObjectLibrary::~ObjectLibrary() {
		d2folbde_Destroy(NdapiContext::Context, safe_cast<d2folb*>(_handler));
	}
}
