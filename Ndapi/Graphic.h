#pragma once

#include "NdapiObject.h"
#include "FormModule.h"

namespace Ndapi
{
	public ref class Graphic : NdapiObject
	{
	public protected:
		Graphic(d2fob* alert);

	public:
		Graphic();
		Graphic(FormModule^ form, String^ name);

		property bool AllowExpansion { bool get(); void set(bool value); }
		property bool AllowMultilinePrompts { bool get(); void set(bool value); }
		property bool AllowStartAttachedPrompts { bool get(); void set(bool value); }
		property bool AllowTopAttachedPrompts { bool get(); void set(bool value); }
		property Ndapi::LineArrowStyle LineArrowStyle { Ndapi::LineArrowStyle get(); void set(Ndapi::LineArrowStyle value); }
		property String^ BackgroundColor { String^ get(); void set(String^ value); }
		property Ndapi::Bevel Bevel { Ndapi::Bevel get(); void set(Ndapi::Bevel value); }
		property Ndapi::ObjectEdgeCapStyle ObjectEdgeCapStyle { Ndapi::ObjectEdgeCapStyle get(); void set(Ndapi::ObjectEdgeCapStyle value); }
		property long ClippingHeight { long get(); void set(long value); }
		property long ClippingWidth { long get(); void set(long value); }
		property long ClippingXOrigin { long get(); void set(long value); }
		property long ClippingYOrigin { long get(); void set(long value); }
		property bool Closed { bool get(); void set(bool value); }
		property long XCornerRadius { long get(); void set(long value); }
		property long YCornerRadius { long get(); void set(long value); }
		property long CustomSpacing { long get(); void set(long value); }
		property Ndapi::DashStyle DashStyle { Ndapi::DashStyle get(); void set(Ndapi::DashStyle value); }
		property Ndapi::DisplayQuality DisplayQuality { Ndapi::DisplayQuality get(); void set(Ndapi::DisplayQuality value); }
		property long DistanceBetweenRecords { long get(); void set(long value); }
		property bool GraphicsDithersImage { bool get(); void set(bool value); }
		property String^ EdgeBackgroundColor { String^ get(); void set(String^ value); }
		property String^ EdgeForegroundColor { String^ get(); void set(String^ value); }
		property String^ FillPattern { String^ get(); void set(String^ value); }
		property bool FixedSizeForBoundingBox { bool get(); void set(bool value); }
		property bool PointSizeScalable { bool get(); void set(bool value); }
		property String^ ForegroundColor { String^ get(); void set(String^ value); }
		property Ndapi::FrameAlignment FrameAlignment { Ndapi::FrameAlignment get(); void set(Ndapi::FrameAlignment value); }
		property String^ FrameTitle { String^ get(); void set(String^ value); }
		property Ndapi::FrameTitleAlignment FrameTitleAlignment { Ndapi::FrameTitleAlignment get(); void set(Ndapi::FrameTitleAlignment value); }
		property String^ FrameTitleBackgroundColor { String^ get(); void set(String^ value); }
		property String^ FrameTitleFillPattern { String^ get(); void set(String^ value); }
		property String^ FrameTitleFontName { String^ get(); void set(String^ value); }
		property long FrameTitleFontSize { long get(); void set(long value); }
		property Ndapi::FontSpacing FrameTitleFontSpacing { Ndapi::FontSpacing get(); void set(Ndapi::FontSpacing value); }
		property Ndapi::FontStyle FrameTitleFontStyle { Ndapi::FontStyle get(); void set(Ndapi::FontStyle value); }
		property Ndapi::FontWeight FrameTitleFontWeight { Ndapi::FontWeight get(); void set(Ndapi::FontWeight value); }
		property String^ FrameTitleForegroundColor { String^ get(); void set(String^ value); }
		property long FrameTitleOffset { long get(); void set(long value); }
		property long FrameTitleSpacing { long get(); void set(long value); }
		property String^ FrameTitleVisualAttributeGroup { String^ get(); void set(String^ value); }
		property Ndapi::GraphicsObjectType GraphicsObjectType { Ndapi::GraphicsObjectType get(); void set(Ndapi::GraphicsObjectType value); }
		property String^ GraphicsFontColor { String^ get(); void set(String^ value); }
		property String^ GraphicsFontName { String^ get(); void set(String^ value); }
		property long GraphicsFontSize { long get(); void set(long value); }
		property Ndapi::FontSpacing GraphicsFontSpacing { Ndapi::FontSpacing get(); void set(Ndapi::FontSpacing value); }
		property Ndapi::FontStyle GraphicsFontStyle { Ndapi::FontStyle get(); void set(Ndapi::FontStyle value); }
		property Ndapi::FontWeight GraphicsFontWeight { Ndapi::FontWeight get(); void set(Ndapi::FontWeight value); }
		property String^ GraphicsText { String^ get(); void set(String^ value); }
		property long Height { long get(); void set(long value); }
		property Ndapi::HorizontalJustification HorizontalJustification { Ndapi::HorizontalJustification get(); void set(Ndapi::HorizontalJustification value); }
		property long HorizontalMargin { long get(); void set(long value); }
		property long HorizontalObjectOffset { long get(); void set(long value); }
		property long HorizontalPositionRelativeToOrigin { long get(); void set(long value); }
		property Ndapi::JoinStyle JoinStyle { Ndapi::JoinStyle get(); void set(Ndapi::JoinStyle value); }
		property Ndapi::LanguageDirection LanguageDirection { Ndapi::LanguageDirection get(); void set(Ndapi::LanguageDirection value); }
		property String^ LayoutDataBlock { String^ get(); void set(String^ value); }
		property Ndapi::LayoutStyle LayoutStyle { Ndapi::LayoutStyle get(); void set(Ndapi::LayoutStyle value); }
		property Ndapi::LineSpacing LineSpacing { Ndapi::LineSpacing get(); void set(Ndapi::LineSpacing value); }
		property long MaximumObjectsPerLine { long get(); void set(long value); }
		property String^ Name { String^ get(); void set(String^ value); }
		property NdapiObject^ FontPointSize { NdapiObject^ get(); }
		property long NumberOfRecordsDisplayed { long get(); void set(long value); }
		property Ndapi::ScrollBarAlignment ScrollBarAlignment { Ndapi::ScrollBarAlignment get(); void set(Ndapi::ScrollBarAlignment value); }
		property long ScrollBarWidth { long get(); void set(long value); }
		property bool ShowScrollBar { bool get(); void set(bool value); }
		property bool Shrinkwrap { bool get(); void set(bool value); }
		property Alignment SingleObjectAlignment { Alignment get(); void set(Alignment value); }
		property Alignment StartPromptAlignment { Alignment get(); void set(Alignment value); }
		property long StartPromptOffset { long get(); void set(long value); }
		property Alignment TopPromptAlignment { Alignment get(); void set(Alignment value); }
		property long TopPromptOffset { long get(); void set(long value); }
		property Ndapi::TitleReadingOrder TitleReadingOrder { Ndapi::TitleReadingOrder get(); void set(Ndapi::TitleReadingOrder value); }
		property Ndapi::UpdateLayout UpdateLayout { Ndapi::UpdateLayout get(); void set(Ndapi::UpdateLayout value); }
		property String^ VisualAttributeGroup { String^ get(); void set(String^ value); }
		property bool VerticalFill { bool get(); void set(bool value); }
		property Ndapi::VerticalJustification VerticalJustification { Ndapi::VerticalJustification get(); void set(Ndapi::VerticalJustification value); }
		property long VerticalMargin { long get(); void set(long value); }
		property long VerticalObjectOffset { long get(); void set(long value); }
		property long VerticalPositionRelativeToOrigin { long get(); void set(long value); }
		property long Width { long get(); void set(long value); }
		property bool WrapText { bool get(); void set(bool value); }
		property long XPosition { long get(); void set(long value); }
		property long YPosition { long get(); void set(long value); }

		property NdapiEnumerator<Graphic^>^ Graphics { NdapiEnumerator<Graphic^>^ get(); }
	};
}



