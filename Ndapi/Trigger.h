#pragma once

#include "NdapiObject.h"
#include "FormModule.h"

namespace Ndapi
{
	ref class FormModule;

	public ref class Trigger : NdapiObject
	{
	public protected:
		Trigger(d2fob* program_unit);

	public:
		Trigger();
		Trigger(FormModule^ form, String^ name);
		void Compile();
		property String^ Comment { String^ get(); void set(String^ value); }
		property bool DisplayInKeyboardHelp { bool get(); void set(bool value); }
		property Ndapi::ExecutionStyle ExecutionStyle { Ndapi::ExecutionStyle get(); void set(Ndapi::ExecutionStyle value); }
		property bool FireInEnterQueryMode { bool get(); void set(bool value); }
		property String^ KeyboardHelpDescription { String^ get(); void set(String^ value); }
		property String^ Name { String^ get(); void set(String^ value); }
		property TriggerStyle Style { TriggerStyle get(); void set(TriggerStyle value); }
		property String^ Text { String^ get(); void set(String^ value); }
	};
}