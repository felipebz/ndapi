#pragma once

#include "NdapiObject.h"
#include "FormModule.h"

namespace Ndapi
{
	public ref class Window : NdapiObject
	{
	public protected:
		Window(d2fob* alert);

	public:
		Window();
		Window(FormModule^ form, String^ name);

		property String^ BackgroundColor { String^ get(); void set(String^ value); }
		property Ndapi::Bevel Bevel { Ndapi::Bevel get(); void set(Ndapi::Bevel value); }
		property bool CloseAllowed { bool get(); void set(bool value); }
		property String^ Comment { String^ get(); void set(String^ value); }
		property String^ FillPattern { String^ get(); void set(String^ value); }
		property String^ FontName { String^ get(); void set(String^ value); }
		property long FontSize { long get(); void set(long value); }
		property Ndapi::FontSpacing FontSpacing { Ndapi::FontSpacing get(); void set(Ndapi::FontSpacing value); }
		property Ndapi::FontStyle FontStyle { Ndapi::FontStyle get(); void set(Ndapi::FontStyle value); }
		property long FontWeight { long get(); void set(long value); }
		property String^ ForegroundColor { String^ get(); void set(String^ value); }
		property long Height { long get(); void set(long value); }
		property String^ HelpBookTopic { String^ get(); void set(String^ value); }
		property bool HideOnExit { bool get(); void set(bool value); }
		property String^ HorizontalToolbarCanvas { String^ get(); void set(String^ value); }
		property String^ IconFilename { String^ get(); void set(String^ value); }
		property bool InheritMenu { bool get(); void set(bool value); }
		property Ndapi::LanguageDirection LanguageDirection { Ndapi::LanguageDirection get(); void set(Ndapi::LanguageDirection value); }
		property bool MaximizeAllowed { bool get(); void set(bool value); }
		property bool MinimizedAllowed { bool get(); void set(bool value); }
		property String^ MinimizeTitle { String^ get(); void set(String^ value); }
		property bool Modal { bool get(); void set(bool value); }
		property bool MoveAllowed { bool get(); void set(bool value); }
		property String^ Name { String^ get(); void set(String^ value); }
		property String^ PrimaryCanvas { String^ get(); void set(String^ value); }
		property bool ResizeAllowed { bool get(); void set(bool value); }
		property bool ShowHorizontalScrollBar { bool get(); void set(bool value); }
		property bool ShowVerticalScrollBar { bool get(); void set(bool value); }
		property String^ Title { String^ get(); void set(String^ value); }
		property String^ VisualAttributeGroup { String^ get(); void set(String^ value); }
		property String^ VerticalToolbarCanvas { String^ get(); void set(String^ value); }
		property bool WhiteOnBlack { bool get(); void set(bool value); }
		property long Width { long get(); void set(long value); }
		property Ndapi::WindowStyle WindowStyle { Ndapi::WindowStyle get(); void set(Ndapi::WindowStyle value); }
		property long XPosition { long get(); void set(long value); }
		property long YPosition { long get(); void set(long value); }
	};
}



