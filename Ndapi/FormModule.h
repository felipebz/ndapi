#pragma once

#include "NdapiObject.h"
#include "NdapiEnumerator.h"
#include "ProgramUnit.h"

#include <D2FFMD.H>

using namespace System;

namespace Ndapi
{
	public ref class FormModule : NdapiObject
	{
	private:
		FormModule(d2fob* form_module);

	public:
		static FormModule^ Open(String^ file);

		property NdapiEnumerator<ProgramUnit^>^ ProgramUnits { NdapiEnumerator<ProgramUnit^>^ get(); }

		~FormModule();
	};
}