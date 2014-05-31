#pragma once

#include "NdapiObject.h"
#include "NdapiObjectLibraryEnumerator.h"

#include <D2FOLB.H>

namespace Ndapi
{
	public ref class ObjectLibrary : NdapiObject
	{
	public protected:
		ObjectLibrary(d2fob* alert);

	public:
		ObjectLibrary(String^ name);
		static ObjectLibrary^ Open(String^ file);

		property String^ Name { String^ get(); void set(String^ value); }
		property long ObjectCount { long get(); }
		property NdapiObject^ ObjectLibraryTabs { NdapiObject^ get(); }
		property NdapiEnumerator<NdapiObject^>^ Objects { NdapiEnumerator<NdapiObject^>^ get(); }

		NdapiObject^ GetObjectByPosition(long position);

		~ObjectLibrary();
	};
}


