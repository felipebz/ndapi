#pragma once

#include "LOV.h"
#include "NdapiObject.h"
#include "FormModule.h"
#include "Trigger.h"

namespace Ndapi
{
	ref class LOV;
	ref class Trigger;

	public ref class Item : NdapiObject
	{
	public protected:
		Item(d2fob* alert);

	public:
		Item();
		Item(FormModule^ form, String^ name);

		property String^ AccessKey { String^ get(); void set(String^ value); }
		property SoundChannels AudioChannels { SoundChannels get(); void set(SoundChannels value); }
		property bool DisplayHintAutomatically { bool get(); void set(bool value); }
		property bool AutoSkip { bool get(); void set(bool value); }
		property String^ BackgroundColor { String^ get(); void set(String^ value); }
		property Ndapi::Bevel Bevel { Ndapi::Bevel get(); void set(Ndapi::Bevel value); }
		property Ndapi::CalculationMode CalculationMode { Ndapi::CalculationMode get(); void set(Ndapi::CalculationMode value); }
		property bool CaseInsensitiveQuery { bool get(); void set(bool value); }
		property Ndapi::CaseRestriction CaseRestriction { Ndapi::CaseRestriction get(); void set(Ndapi::CaseRestriction value); }
		property String^ Checked { String^ get(); void set(String^ value); }
		property Ndapi::CheckBoxOtherValues CheckBoxOtherValues { Ndapi::CheckBoxOtherValues get(); void set(Ndapi::CheckBoxOtherValues value); }
		property Ndapi::CompressionQuality CompressionQuality { Ndapi::CompressionQuality get(); void set(Ndapi::CompressionQuality value); }
		property NdapiObject^ Canvas { NdapiObject^ get(); void set(NdapiObject^ value); }
		property String^ ColumnName { String^ get(); void set(String^ value); }
		property String^ Comments { String^ get(); void set(String^ value); }
		property Ndapi::CommunicationMode CommunicationMode { Ndapi::CommunicationMode get(); void set(Ndapi::CommunicationMode value); }
		property SoundCompression Compress { SoundCompression get(); void set(SoundCompression value); }
		property bool ConcealData { bool get(); void set(bool value); }
		property String^ CopyValueFromItem { String^ get(); void set(String^ value); }
		property String^ DataSourceBlock { String^ get(); void set(String^ value); }
		property String^ DataSourceXAxis { String^ get(); void set(String^ value); }
		property String^ DataSourceYAxis { String^ get(); void set(String^ value); }
		property ItemDataType DataType { ItemDataType get(); void set(ItemDataType value); }
		property bool DatabaseItem { bool get(); void set(bool value); }
		property bool DefaultButton { bool get(); void set(bool value); }
		property Ndapi::DisplayQuality DisplayQuality { Ndapi::DisplayQuality get(); void set(Ndapi::DisplayQuality value); }
		property long DistanceBetweenRecords { long get(); void set(long value); }
		property NdapiObject^ Editor { NdapiObject^ get(); void set(NdapiObject^ value); }
		property long EditorXPosition { long get(); void set(long value); }
		property long EditorYPosition { long get(); void set(long value); }
		property bool Enabled { bool get(); void set(bool value); }
		property Ndapi::ExecutionMode ExecutionMode { Ndapi::ExecutionMode get(); void set(Ndapi::ExecutionMode value); }
		property String^ FillPattern { String^ get(); void set(String^ value); }
		property bool FixedLength { bool get(); void set(bool value); }
		property String^ FileName { String^ get(); void set(String^ value); }
		property String^ FormatMask { String^ get(); void set(String^ value); }
		property String^ FontName { String^ get(); void set(String^ value); }
		property long FontSize { long get(); void set(long value); }
		property Ndapi::FontSpacing FontSpacing { Ndapi::FontSpacing get(); void set(Ndapi::FontSpacing value); }
		property Ndapi::FontStyle FontStyle { Ndapi::FontStyle get(); void set(Ndapi::FontStyle value); }
		property Ndapi::FontWeight FontWeight { Ndapi::FontWeight get(); void set(Ndapi::FontWeight value); }
		property String^ ForegroundColor { String^ get(); void set(String^ value); }
		property String^ Formula { String^ get(); void set(String^ value); }
		property long Height { long get(); void set(long value); }
		property String^ HelpBookTopic { String^ get(); void set(String^ value); }
		property String^ HighestAllowedValue { String^ get(); void set(String^ value); }
		property String^ Hint { String^ get(); void set(String^ value); }
		property bool Iconic { bool get(); void set(bool value); }
		property String^ IconFilename { String^ get(); void set(String^ value); }
		property Ndapi::ImageDepth ImageDepth { Ndapi::ImageDepth get(); void set(Ndapi::ImageDepth value); }
		property ImageStorageFormat ImageFormat { ImageStorageFormat get(); void set(ImageStorageFormat value); }
		property Ndapi::InitialKeyboardDirection InitialKeyboardDirection { Ndapi::InitialKeyboardDirection get(); void set(Ndapi::InitialKeyboardDirection value); }
		property String^ InitialValue { String^ get(); void set(String^ value); }
		property bool InsertAllowed { bool get(); void set(bool value); }
		property long NumberOfItemsDisplayed { long get(); void set(long value); }
		property Ndapi::ItemType ItemType { Ndapi::ItemType get(); void set(Ndapi::ItemType value); }
		property Ndapi::Justification Justification { Ndapi::Justification get(); void set(Ndapi::Justification value); }
		property bool KeyboardNavigable { bool get(); void set(bool value); }
		property bool KeepCursorPosition { bool get(); void set(bool value); }
		property String^ Label { String^ get(); void set(String^ value); }
		property Ndapi::LanguageDirection LanguageDirection { Ndapi::LanguageDirection get(); void set(Ndapi::LanguageDirection value); }
		property bool LockRecord { bool get(); void set(bool value); }
		property Ndapi::LOV^ LOV { Ndapi::LOV^ get(); void set(Ndapi::LOV^ value); }
		property long LOVXPosition { long get(); void set(long value); }
		property long LOVXYosition { long get(); void set(long value); }
		property String^ LowestAllowedValue { String^ get(); void set(String^ value); }
		property long ListElementCount { long get(); }
		property Ndapi::ListStyle ListStyle { Ndapi::ListStyle get(); void set(Ndapi::ListStyle value); }
		property long MaximumLength { long get(); void set(long value); }
		property bool MultiLine { bool get(); void set(bool value); }
		property bool MouseNavigate { bool get(); void set(bool value); }
		property String^ Name { String^ get(); void set(String^ value); }
		property NdapiObject^ NextNavigationItem { NdapiObject^ get(); void set(NdapiObject^ value); }
		property long OLEActivationStyle { long get(); void set(long value); }
		property String^ OLEClass { String^ get(); void set(String^ value); }
		property bool OLEInsideOutSupport { bool get(); void set(bool value); }
		property bool OLEInPlaceActivation { bool get(); void set(bool value); }
		property long OLEPopUpMenuItems { long get(); void set(long value); }
		property Ndapi::OleResizeStyle OLEResizeStyle { Ndapi::OleResizeStyle get(); void set(Ndapi::OleResizeStyle value); }
		property bool ShowOLETenantType { bool get(); void set(bool value); }
		property Ndapi::OleTenantAspect OLETenantAspect { Ndapi::OleTenantAspect get(); void set(Ndapi::OleTenantAspect value); }
		property Ndapi::OleTenantTypes OLETenantTypes { Ndapi::OleTenantTypes get(); void set(Ndapi::OleTenantTypes value); }
		property String^ MappingOfOtherValues { String^ get(); void set(String^ value); }
		property String^ PopupMenu { String^ get(); void set(String^ value); }
		property String^ PopUpMenu { String^ get(); void set(String^ value); }
		property NdapiObject^ PopUpVisualAttribute { NdapiObject^ get(); void set(NdapiObject^ value); }
		property NdapiObject^ PreviousNavigationItem { NdapiObject^ get(); void set(NdapiObject^ value); }
		property String^ Prompt { String^ get(); void set(String^ value); }
		property Alignment PromptAlignment { Alignment get(); void set(Alignment value); }
		property long PromptAlignmentOffset { long get(); void set(long value); }
		property EdgeAtachmentType PromptAttachmentEdge { EdgeAtachmentType get(); void set(EdgeAtachmentType value); }
		property long PromptAttachementOffset { long get(); void set(long value); }
		property String^ PromptBackgroundColor { String^ get(); void set(String^ value); }
		property Ndapi::PromptDisplayStyle PromptDisplayStyle { Ndapi::PromptDisplayStyle get(); void set(Ndapi::PromptDisplayStyle value); }
		property String^ PromptFillPattern { String^ get(); void set(String^ value); }
		property String^ PromptFontName { String^ get(); void set(String^ value); }
		property long PromptFontSize { long get(); void set(long value); }
		property Ndapi::FontSpacing PromptFontSpacing { Ndapi::FontSpacing get(); void set(Ndapi::FontSpacing value); }
		property Ndapi::FontStyle PromptFontStyle { Ndapi::FontStyle get(); void set(Ndapi::FontStyle value); }
		property Ndapi::FontWeight PromptFontWeight { Ndapi::FontWeight get(); void set(Ndapi::FontWeight value); }
		property String^ PromptForegroundColor { String^ get(); void set(String^ value); }
		property Ndapi::Justification PromptJustification { Ndapi::Justification get(); void set(Ndapi::Justification value); }
		property Ndapi::ReadingOrder PromptReadingOrder { Ndapi::ReadingOrder get(); void set(Ndapi::ReadingOrder value); }
		property String^ PromptVisualAttributeGroup { String^ get(); void set(String^ value); }
		property NdapiObject^ PromptVisualAttribute { NdapiObject^ get(); void set(NdapiObject^ value); }
		property bool PrimaryKey { bool get(); void set(bool value); }
		property bool QueryAllowed { bool get(); void set(bool value); }
		property long QueryLength { long get(); void set(long value); }
		property bool QueryOnly { bool get(); void set(bool value); }
		property NdapiObject^ RadioButtons { NdapiObject^ get(); }
		property Ndapi::ReadingOrder ReadingOrder { Ndapi::ReadingOrder get(); void set(Ndapi::ReadingOrder value); }
		property String^ CurrentRecordVisualAttributeGroup { String^ get(); void set(String^ value); }
		property NdapiObject^ CurrentRecordVisualAttribute { NdapiObject^ get(); void set(NdapiObject^ value); }
		property bool Rendered { bool get(); void set(bool value); }
		property bool Required { bool get(); void set(bool value); }
		property bool ShowFastForwardButton { bool get(); void set(bool value); }
		property bool ShowHorizonatalScrollbar { bool get(); void set(bool value); }
		property bool ShowPalette { bool get(); void set(bool value); }
		property bool ShowPlayButton { bool get(); void set(bool value); }
		property bool ShowRecordButton { bool get(); void set(bool value); }
		property bool ShowRewindButton { bool get(); void set(bool value); }
		property bool ShowSlider { bool get(); void set(bool value); }
		property bool ShowTimeIndicator { bool get(); void set(bool value); }
		property bool ShowVerticalScrollBar { bool get(); void set(bool value); }
		property bool ShowVolumeControl { bool get(); void set(bool value); }
		property Ndapi::ImageSizingStyle SizingStyle { Ndapi::ImageSizingStyle get(); void set(Ndapi::ImageSizingStyle value); }
		property Ndapi::SoundFormat SoundFormat { Ndapi::SoundFormat get(); void set(Ndapi::SoundFormat value); }
		property Ndapi::SoundQuality SoundQuality { Ndapi::SoundQuality get(); void set(Ndapi::SoundQuality value); }
		property String^ SummarizedBlock { String^ get(); void set(String^ value); }
		property SummaryFunction SummarizedFunction { SummaryFunction get(); void set(SummaryFunction value); }
		property String^ SummarizedItem { String^ get(); void set(String^ value); }
		property NdapiObject^ SynchronizeWithItem { NdapiObject^ get(); void set(NdapiObject^ value); }
		property NdapiObject^ TabPage { NdapiObject^ get(); void set(NdapiObject^ value); }
		property String^ Tooltip { String^ get(); void set(String^ value); }
		property String^ TooltipVisualAttributeGroup { String^ get(); void set(String^ value); }
		property String^ ValueWhenUnchecked { String^ get(); void set(String^ value); }
		property bool UpdateAllowed { bool get(); void set(bool value); }
		property bool UpdateCommit { bool get(); void set(bool value); }
		property bool UpdateOnlyIfNull { bool get(); void set(bool value); }
		property bool UpdateQuery { bool get(); void set(bool value); }
		property bool ValidateFromList { bool get(); void set(bool value); }
		property String^ VisualAttributeGroup { String^ get(); void set(String^ value); }
		property NdapiObject^ VisualAttribute { NdapiObject^ get(); void set(NdapiObject^ value); }
		property bool Visible { bool get(); void set(bool value); }
		property bool WhiteOnBlack { bool get(); void set(bool value); }
		property long Width { long get(); void set(long value); }
		property Ndapi::WrapStyle WrapStyle { Ndapi::WrapStyle get(); void set(Ndapi::WrapStyle value); }
		property long XPosition { long get(); void set(long value); }
		property long YPosition { long get(); void set(long value); }

		property NdapiEnumerator<Trigger^>^ Triggers { NdapiEnumerator<Trigger^>^ get(); }
	};
}



