#pragma once

#include "NdapiObject.h"
#include "FormModule.h"
#include "Graphic.h"

namespace Ndapi
{
	ref class Graphic;

	public ref class Canvas : NdapiObject
	{
	public protected:
		Canvas(d2fob* alert);

	public:
		Canvas();
		Canvas(FormModule^ form, String^ name);

		property String^ BackgroundColor { String^ get(); void set(String^ value); }
		property Ndapi::Bevel Bevel { Ndapi::Bevel get(); void set(Ndapi::Bevel value); }
		property Ndapi::CanvasType CanvasType { Ndapi::CanvasType get(); void set(Ndapi::CanvasType value); }
		property String^ Comment { String^ get(); void set(String^ value); }
		property String^ FillPattern { String^ get(); void set(String^ value); }
		property String^ FontName { String^ get(); void set(String^ value); }
		property long FontSize { long get(); void set(long value); }
		property Ndapi::FontSpacing FontSpacing { Ndapi::FontSpacing get(); void set(Ndapi::FontSpacing value); }
		property Ndapi::FontStyle FontStyle { Ndapi::FontStyle get(); void set(Ndapi::FontStyle value); }
		property Ndapi::FontWeight FontWeight { Ndapi::FontWeight get(); void set(Ndapi::FontWeight value); }
		property String^ ForegroundColor { String^ get(); void set(String^ value); }
		property long Height { long get(); void set(long value); }
		property String^ HelpBookTopic { String^ get(); void set(String^ value); }
		property long LanguageDirection { long get(); void set(long value); }
		property String^ Name { String^ get(); void set(String^ value); }
		property String^ PopupMenu { String^ get(); void set(String^ value); }
		property bool RaiseOnEntry { bool get(); void set(bool value); }
		property Ndapi::TabAttachmentEdge TabAttachmentEdge { Ndapi::TabAttachmentEdge get(); void set(Ndapi::TabAttachmentEdge value); }
		property Ndapi::TabStyle TabStyle { Ndapi::TabStyle get(); void set(Ndapi::TabStyle value); }
		property String^ VisualAttributeGroup { String^ get(); void set(String^ value); }
		property bool Visible { bool get(); void set(bool value); }
		property long ViewportHeight { long get(); void set(long value); }
		property long ViewportWidth { long get(); void set(long value); }
		property long ViewportXPosition { long get(); void set(long value); }
		property long ViewportXPositionOnCanvas { long get(); void set(long value); }
		property long ViewportYPosition { long get(); void set(long value); }
		property long ViewportYPositionOnCanvas { long get(); void set(long value); }
		property bool WhiteOnBlack { bool get(); void set(bool value); }
		property long Width { long get(); void set(long value); }
		property String^ Window { String^ get(); void set(String^ value); }

		property NdapiEnumerator<Graphic^>^ Graphics { NdapiEnumerator<Graphic^>^ get(); }
		property NdapiEnumerator<NdapiObject^>^ TabPage { NdapiEnumerator<NdapiObject^>^ get(); }

	};
}


