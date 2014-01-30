#pragma once

#include "NdapiObject.h"
#include "NdapiEnumerator.h"
#include "ProgramUnit.h"

#include <D2FFMD.H>

using namespace System;

namespace Ndapi
{
	ref class ProgramUnit;

	public ref class FormModule : NdapiObject
	{
	private:
		FormModule(d2fob* form_module);

	public:
		FormModule(String^ name);
		static FormModule^ Open(String^ file);
		void Save();
		void Save(String^ path);
		void Save(String^ path, bool saveInDatabase);

		property NdapiEnumerator<ProgramUnit^>^ ProgramUnits { NdapiEnumerator<ProgramUnit^>^ get(); }

		~FormModule();
	};
}