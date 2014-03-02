#pragma once

#include "NdapiObject.h"
#include "FormModule.h"

namespace Ndapi
{
	ref class FormModule;

	public ref class Alert : NdapiObject
	{
	public protected:
		Alert(d2fob* alert);

	public:
		Alert();
		Alert(FormModule^ form, String^ name);

		property String^ Message { String^ get(); void set(String^ value); }
		property Ndapi::AlertStyle AlertStyle { Ndapi::AlertStyle get(); void set(Ndapi::AlertStyle value); }
		property String^ BackgroundColor { String^ get(); void set(String^ value); }
		property String^ Button1Label { String^ get(); void set(String^ value); }
		property String^ Button2Label { String^ get(); void set(String^ value); }
		property String^ Button3Label { String^ get(); void set(String^ value); }
		property String^ Comment { String^ get(); void set(String^ value); }
		property AlertButton DefaultAlertButton { AlertButton get(); void set(AlertButton value); }
		property String^ FillPattern { String^ get(); void set(String^ value); }
		property String^ FontName { String^ get(); void set(String^ value); }
		property long FontSize { long get(); void set(long value); }
		property Ndapi::FontSpacing FontSpacing { Ndapi::FontSpacing get(); void set(Ndapi::FontSpacing value); }
		property Ndapi::FontStyle FontStyle { Ndapi::FontStyle get(); void set(Ndapi::FontStyle value); }
		property Ndapi::FontWeight FontWeight { Ndapi::FontWeight get(); void set(Ndapi::FontWeight value); }
		property String^ ForegroundColor { String^ get(); void set(String^ value); }
		property Ndapi::LanguageDirection LanguageDirection { Ndapi::LanguageDirection get(); void set(Ndapi::LanguageDirection value); }
		property String^ Name { String^ get(); void set(String^ value); }
		property String^ Title { String^ get(); void set(String^ value); }
		property bool WhiteOnBlack { bool get(); void set(bool value); }
	};
}