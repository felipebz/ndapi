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
		void CompileFile();
		void CompileObjects();

		property String^ Comment { String^ get(); void set(String^ value); }
		property String^ ConsoleWindow { String^ get(); void set(String^ value); }
		property bool DeferRequiredEnforcement { bool get(); void set(bool value); }
		property NdapiObject^ FirstNavigationBlock { NdapiObject^ get(); void set(NdapiObject^ value); }
		property String^ HelpBookTitle { String^ get(); void set(String^ value); }
		property String^ HorizontalToolbarCanvas { String^ get(); void set(String^ value); }
		property String^ InitialMenu { String^ get(); void set(String^ value); }
		property long InteractionMode { long get(); void set(long value); }
		property long IsolationMode { long get(); void set(long value); }
		property long LanguageDirection { long get(); void set(long value); }
		property long MaximumQueryTime { long get(); void set(long value); }
		property long MaxRecordsFetched { long get(); void set(long value); }
		property String^ MenuModule { String^ get(); void set(String^ value); }
		property String^ MenuRole { String^ get(); void set(String^ value); }
		property long MenuSource { long get(); void set(long value); }
		property long MenuStyle { long get(); void set(long value); }
		property long MouseNavigationLimit { long get(); void set(long value); }
		property NdapiObject^ CurrentRecordVisualAttribute { NdapiObject^ get(); void set(NdapiObject^ value); }
		property long RuntimeCompatibility { long get(); void set(long value); }
		property String^ Title { String^ get(); void set(String^ value); }
		property bool Use3DControls { bool get(); void set(bool value); }
		property long ValidationUnit { long get(); void set(long value); }
		property String^ VerticalToolbarCanvas { String^ get(); void set(String^ value); }

		property NdapiEnumerator<ProgramUnit^>^ ProgramUnits { NdapiEnumerator<ProgramUnit^>^ get(); }

		~FormModule();
	};
}