#pragma once

#include "NdapiObject.h"
#include "NdapiEnumerator.h"
#include "Alert.h"
#include "AttachedLibrary.h"
#include "Block.h"
#include "Canvas.h"
#include "FormParameter.h"
#include "ProgramUnit.h"
#include "RecordGroup.h"
#include "Trigger.h"

#include <D2FFMD.H>

using namespace System;

namespace Ndapi
{
	ref class Alert;
	ref class AttachedLibrary;
	ref class Block;
	ref class Canvas;
	ref class FormParameter;
	ref class ProgramUnit;
	ref class RecordGroup;
	ref class Trigger;

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
		property Ndapi::InteractionMode InteractionMode { Ndapi::InteractionMode get(); void set(Ndapi::InteractionMode value); }
		property Ndapi::IsolationMode IsolationMode { Ndapi::IsolationMode get(); void set(Ndapi::IsolationMode value); }
		property Ndapi::LanguageDirection LanguageDirection { Ndapi::LanguageDirection get(); void set(Ndapi::LanguageDirection value); }
		property long MaximumQueryTime { long get(); void set(long value); }
		property long MaxRecordsFetched { long get(); void set(long value); }
		property String^ MenuModule { String^ get(); void set(String^ value); }
		property String^ MenuRole { String^ get(); void set(String^ value); }
		property Ndapi::MenuSource MenuSource { Ndapi::MenuSource get(); void set(Ndapi::MenuSource value); }
		property Ndapi::MenuStyle MenuStyle { Ndapi::MenuStyle get(); void set(Ndapi::MenuStyle value); }
		property Ndapi::MouseNavigationLimit MouseNavigationLimit { Ndapi::MouseNavigationLimit get(); void set(Ndapi::MouseNavigationLimit value); }
		property NdapiObject^ CurrentRecordVisualAttribute { NdapiObject^ get(); void set(NdapiObject^ value); }
		property Ndapi::RuntimeCompatibility RuntimeCompatibility { Ndapi::RuntimeCompatibility get(); void set(Ndapi::RuntimeCompatibility value); }
		property String^ Title { String^ get(); void set(String^ value); }
		property bool Use3DControls { bool get(); void set(bool value); }
		property Ndapi::ValidationUnit ValidationUnit { Ndapi::ValidationUnit get(); void set(Ndapi::ValidationUnit value); }
		property String^ VerticalToolbarCanvas { String^ get(); void set(String^ value); }

		property NdapiEnumerator<Alert^>^ Alerts { NdapiEnumerator<Alert^>^ get(); }
		property NdapiEnumerator<AttachedLibrary^>^ AttachedLibraries { NdapiEnumerator<AttachedLibrary^>^ get(); }
		property NdapiEnumerator<Block^>^ Blocks { NdapiEnumerator<Block^>^ get(); }
		property NdapiEnumerator<Canvas^>^ Canvases { NdapiEnumerator<Canvas^>^ get(); }
		property NdapiEnumerator<FormParameter^>^ FormParameters { NdapiEnumerator<FormParameter^>^ get(); }
		property NdapiEnumerator<ProgramUnit^>^ ProgramUnits { NdapiEnumerator<ProgramUnit^>^ get(); }
		property NdapiEnumerator<RecordGroup^>^ RecordGroups { NdapiEnumerator<RecordGroup^>^ get(); }
		property NdapiEnumerator<Trigger^>^ Triggers { NdapiEnumerator<Trigger^>^ get(); }

		~FormModule();
	};
}