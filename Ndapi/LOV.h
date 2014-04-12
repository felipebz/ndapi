#pragma once

#include "NdapiObject.h"
#include "FormModule.h"

namespace Ndapi
{
	public ref class LOV : NdapiObject
	{
	public protected:
		LOV(d2fob* alert);

	public:
		LOV();
		LOV(FormModule^ form, String^ name);

		property bool AutomaticColumnWidth { bool get(); void set(bool value); }
		property bool AutomaticDisplay { bool get(); void set(bool value); }
		property bool AutomaticPosition { bool get(); void set(bool value); }
		property bool AutomaticRefresh { bool get(); void set(bool value); }
		property bool AutomaticSkip { bool get(); void set(bool value); }
		property bool AutomaticSelect { bool get(); void set(bool value); }
		property String^ BackgroundColor { String^ get(); void set(String^ value); }
		property NdapiObject^ ColumnMappingProperties { NdapiObject^ get(); }
		property String^ Comment { String^ get(); void set(String^ value); }
		property String^ FillPattern { String^ get(); void set(String^ value); }
		property bool FilterBeforeDisplay { bool get(); void set(bool value); }
		property String^ FontName { String^ get(); void set(String^ value); }
		property long FontSize { long get(); void set(long value); }
		property Ndapi::FontSpacing FontSpacing { Ndapi::FontSpacing get(); void set(Ndapi::FontSpacing value); }
		property Ndapi::FontStyle FontStyle { Ndapi::FontStyle get(); void set(Ndapi::FontStyle value); }
		property Ndapi::FontWeight FontWeight { Ndapi::FontWeight get(); void set(Ndapi::FontWeight value); }
		property String^ ForegroundColor { String^ get(); void set(String^ value); }
		property long Height { long get(); void set(long value); }
		property Ndapi::LanguageDirection LanguageDirection { Ndapi::LanguageDirection get(); void set(Ndapi::LanguageDirection value); }
		property Ndapi::ListType ListType { Ndapi::ListType get(); void set(Ndapi::ListType value); }
		property String^ Name { String^ get(); void set(String^ value); }
		property String^ OldLOVText { String^ get(); void set(String^ value); }
		property NdapiObject^ RecordGroup { NdapiObject^ get(); void set(NdapiObject^ value); }
		property String^ Title { String^ get(); void set(String^ value); }
		property String^ VisualAttributeGroup { String^ get(); void set(String^ value); }
		property bool WhiteOnBlack { bool get(); void set(bool value); }
		property long Width { long get(); void set(long value); }
		property long XPosition { long get(); void set(long value); }
		property long YPosition { long get(); void set(long value); }
	};
}



