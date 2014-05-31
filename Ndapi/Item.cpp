#include "stdafx.h"
#include "Item.h"

namespace Ndapi
{
	Item::Item() : NdapiObject()
	{
	}

	Item::Item(d2fob* alert) : NdapiObject(alert)
	{
	}

	Item::Item(FormModule^ form, String^ name)
	{
		Create(name, form, D2FFO_ITEM);
	}

	String^ Item::AccessKey::get()
	{
		return GetStringProperty(D2FP_ACCESS_KEY);
	}

	void Item::AccessKey::set(String^ value)
	{
		SetStringProperty(D2FP_ACCESS_KEY, value);
	}

	SoundChannels Item::AudioChannels::get()
	{
		return GetNumberProperty<SoundChannels>(D2FP_AUDIO_CHNNLS);
	}

	void Item::AudioChannels::set(SoundChannels value)
	{
		SetNumberProperty(D2FP_AUDIO_CHNNLS, value);
	}

	bool Item::DisplayHintAutomatically::get()
	{
		return GetBooleanProperty(D2FP_AUTO_HINT);
	}

	void Item::DisplayHintAutomatically::set(bool value)
	{
		SetBooleanProperty(D2FP_AUTO_HINT, value);
	}

	bool Item::AutoSkip::get()
	{
		return GetBooleanProperty(D2FP_AUTO_SKP);
	}

	void Item::AutoSkip::set(bool value)
	{
		SetBooleanProperty(D2FP_AUTO_SKP, value);
	}

	String^ Item::BackgroundColor::get()
	{
		return GetStringProperty(D2FP_BACK_COLOR);
	}

	void Item::BackgroundColor::set(String^ value)
	{
		SetStringProperty(D2FP_BACK_COLOR, value);
	}

	Ndapi::Bevel Item::Bevel::get()
	{
		return GetNumberProperty<Ndapi::Bevel>(D2FP_BEVEL);
	}

	void Item::Bevel::set(Ndapi::Bevel value)
	{
		SetNumberProperty(D2FP_BEVEL, value);
	}

	Ndapi::CalculationMode Item::CalculationMode::get()
	{
		return GetNumberProperty<Ndapi::CalculationMode>(D2FP_CALC_MODE);
	}

	void Item::CalculationMode::set(Ndapi::CalculationMode value)
	{
		SetNumberProperty(D2FP_CALC_MODE, value);
	}

	bool Item::CaseInsensitiveQuery::get()
	{
		return GetBooleanProperty(D2FP_CASE_INSENSITIVE_QRY);
	}

	void Item::CaseInsensitiveQuery::set(bool value)
	{
		SetBooleanProperty(D2FP_CASE_INSENSITIVE_QRY, value);
	}

	Ndapi::CaseRestriction Item::CaseRestriction::get()
	{
		return GetNumberProperty<Ndapi::CaseRestriction>(D2FP_CASE_RSTRCTION);
	}

	void Item::CaseRestriction::set(Ndapi::CaseRestriction value)
	{
		SetNumberProperty(D2FP_CASE_RSTRCTION, value);
	}

	String^ Item::Checked::get()
	{
		return GetStringProperty(D2FP_CHKED_VAL);
	}

	void Item::Checked::set(String^ value)
	{
		SetStringProperty(D2FP_CHKED_VAL, value);
	}

	Ndapi::CheckBoxOtherValues Item::CheckBoxOtherValues::get()
	{
		return GetNumberProperty<Ndapi::CheckBoxOtherValues>(D2FP_CHK_BX_OTHER_VALS);
	}

	void Item::CheckBoxOtherValues::set(Ndapi::CheckBoxOtherValues value)
	{
		SetNumberProperty(D2FP_CHK_BX_OTHER_VALS, value);
	}

	Ndapi::CompressionQuality Item::CompressionQuality::get()
	{
		return GetNumberProperty<Ndapi::CompressionQuality>(D2FP_CMPRSSION_QLTY);
	}

	void Item::CompressionQuality::set(Ndapi::CompressionQuality value)
	{
		SetNumberProperty(D2FP_CMPRSSION_QLTY, value);
	}

	NdapiObject^ Item::Canvas::get()
	{
		return GetObjectProperty<NdapiObject^>(D2FP_CNV_OBJ);
	}

	void Item::Canvas::set(NdapiObject^ value)
	{
		SetObjectProperty(D2FP_CNV_OBJ, value);
	}

	String^ Item::ColumnName::get()
	{
		return GetStringProperty(D2FP_COL_NAM);
	}

	void Item::ColumnName::set(String^ value)
	{
		SetStringProperty(D2FP_COL_NAM, value);
	}

	String^ Item::Comments::get()
	{
		return GetStringProperty(D2FP_COMMENT);
	}

	void Item::Comments::set(String^ value)
	{
		SetStringProperty(D2FP_COMMENT, value);
	}

	Ndapi::CommunicationMode Item::CommunicationMode::get()
	{
		return GetNumberProperty<Ndapi::CommunicationMode>(D2FP_COMM_MODE);
	}

	void Item::CommunicationMode::set(Ndapi::CommunicationMode value)
	{
		SetNumberProperty(D2FP_COMM_MODE, value);
	}

	SoundCompression Item::Compress::get()
	{
		return GetNumberProperty<SoundCompression>(D2FP_COMPRESS);
	}

	void Item::Compress::set(SoundCompression value)
	{
		SetNumberProperty(D2FP_COMPRESS, value);
	}

	bool Item::ConcealData::get()
	{
		return GetBooleanProperty(D2FP_CONCEAL_DATA);
	}

	void Item::ConcealData::set(bool value)
	{
		SetBooleanProperty(D2FP_CONCEAL_DATA, value);
	}

	String^ Item::CopyValueFromItem::get()
	{
		return GetStringProperty(D2FP_COPY_VAL_FROM_ITM);
	}

	void Item::CopyValueFromItem::set(String^ value)
	{
		SetStringProperty(D2FP_COPY_VAL_FROM_ITM, value);
	}

	String^ Item::DataSourceBlock::get()
	{
		return GetStringProperty(D2FP_DAT_SRC_BLK);
	}

	void Item::DataSourceBlock::set(String^ value)
	{
		SetStringProperty(D2FP_DAT_SRC_BLK, value);
	}

	String^ Item::DataSourceXAxis::get()
	{
		return GetStringProperty(D2FP_DAT_SRC_X_AXS);
	}

	void Item::DataSourceXAxis::set(String^ value)
	{
		SetStringProperty(D2FP_DAT_SRC_X_AXS, value);
	}

	String^ Item::DataSourceYAxis::get()
	{
		return GetStringProperty(D2FP_DAT_SRC_Y_AXS);
	}

	void Item::DataSourceYAxis::set(String^ value)
	{
		SetStringProperty(D2FP_DAT_SRC_Y_AXS, value);
	}

	ItemDataType Item::DataType::get()
	{
		return GetNumberProperty<ItemDataType>(D2FP_DAT_TYP);
	}

	void Item::DataType::set(ItemDataType value)
	{
		SetNumberProperty(D2FP_DAT_TYP, value);
	}

	bool Item::DatabaseItem::get()
	{
		return GetBooleanProperty(D2FP_DB_ITM);
	}

	void Item::DatabaseItem::set(bool value)
	{
		SetBooleanProperty(D2FP_DB_ITM, value);
	}

	bool Item::DefaultButton::get()
	{
		return GetBooleanProperty(D2FP_DFLT_BTN);
	}

	void Item::DefaultButton::set(bool value)
	{
		SetBooleanProperty(D2FP_DFLT_BTN, value);
	}

	Ndapi::DisplayQuality Item::DisplayQuality::get()
	{
		return GetNumberProperty<Ndapi::DisplayQuality>(D2FP_DISP_QLTY);
	}

	void Item::DisplayQuality::set(Ndapi::DisplayQuality value)
	{
		SetNumberProperty(D2FP_DISP_QLTY, value);
	}

	long Item::DistanceBetweenRecords::get()
	{
		return GetNumberProperty(D2FP_DIST_BTWN_RECS);
	}

	void Item::DistanceBetweenRecords::set(long value)
	{
		SetNumberProperty(D2FP_DIST_BTWN_RECS, value);
	}

	NdapiObject^ Item::Editor::get()
	{
		return GetObjectProperty<NdapiObject^>(D2FP_EDT_OBJ);
	}

	void Item::Editor::set(NdapiObject^ value)
	{
		SetObjectProperty(D2FP_EDT_OBJ, value);
	}

	long Item::EditorXPosition::get()
	{
		return GetNumberProperty(D2FP_EDT_X_POS);
	}

	void Item::EditorXPosition::set(long value)
	{
		SetNumberProperty(D2FP_EDT_X_POS, value);
	}

	long Item::EditorYPosition::get()
	{
		return GetNumberProperty(D2FP_EDT_Y_POS);
	}

	void Item::EditorYPosition::set(long value)
	{
		SetNumberProperty(D2FP_EDT_Y_POS, value);
	}

	bool Item::Enabled::get()
	{
		return GetBooleanProperty(D2FP_ENABLED);
	}

	void Item::Enabled::set(bool value)
	{
		SetBooleanProperty(D2FP_ENABLED, value);
	}

	Ndapi::ExecutionMode Item::ExecutionMode::get()
	{
		return GetNumberProperty<Ndapi::ExecutionMode>(D2FP_EXEC_MODE);
	}

	void Item::ExecutionMode::set(Ndapi::ExecutionMode value)
	{
		SetNumberProperty(D2FP_EXEC_MODE, value);
	}

	String^ Item::FillPattern::get()
	{
		return GetStringProperty(D2FP_FILL_PAT);
	}

	void Item::FillPattern::set(String^ value)
	{
		SetStringProperty(D2FP_FILL_PAT, value);
	}

	bool Item::FixedLength::get()
	{
		return GetBooleanProperty(D2FP_FIXED_LEN);
	}

	void Item::FixedLength::set(bool value)
	{
		SetBooleanProperty(D2FP_FIXED_LEN, value);
	}

	String^ Item::FileName::get()
	{
		return GetStringProperty(D2FP_FLNAM);
	}

	void Item::FileName::set(String^ value)
	{
		SetStringProperty(D2FP_FLNAM, value);
	}

	String^ Item::FormatMask::get()
	{
		return GetStringProperty(D2FP_FMT_MSK);
	}

	void Item::FormatMask::set(String^ value)
	{
		SetStringProperty(D2FP_FMT_MSK, value);
	}

	String^ Item::FontName::get()
	{
		return GetStringProperty(D2FP_FONT_NAM);
	}

	void Item::FontName::set(String^ value)
	{
		SetStringProperty(D2FP_FONT_NAM, value);
	}

	long Item::FontSize::get()
	{
		return GetNumberProperty(D2FP_FONT_SIZ);
	}

	void Item::FontSize::set(long value)
	{
		SetNumberProperty(D2FP_FONT_SIZ, value);
	}

	Ndapi::FontSpacing Item::FontSpacing::get()
	{
		return GetNumberProperty<Ndapi::FontSpacing>(D2FP_FONT_SPCING);
	}

	void Item::FontSpacing::set(Ndapi::FontSpacing value)
	{
		SetNumberProperty(D2FP_FONT_SPCING, value);
	}

	Ndapi::FontStyle Item::FontStyle::get()
	{
		return GetNumberProperty<Ndapi::FontStyle>(D2FP_FONT_STY);
	}

	void Item::FontStyle::set(Ndapi::FontStyle value)
	{
		SetNumberProperty(D2FP_FONT_STY, value);
	}

	Ndapi::FontWeight Item::FontWeight::get()
	{
		return GetNumberProperty<Ndapi::FontWeight>(D2FP_FONT_WGHT);
	}

	void Item::FontWeight::set(Ndapi::FontWeight value)
	{
		SetNumberProperty(D2FP_FONT_WGHT, value);
	}

	String^ Item::ForegroundColor::get()
	{
		return GetStringProperty(D2FP_FORE_COLOR);
	}

	void Item::ForegroundColor::set(String^ value)
	{
		SetStringProperty(D2FP_FORE_COLOR, value);
	}

	String^ Item::Formula::get()
	{
		return GetStringProperty(D2FP_FORMULA);
	}

	void Item::Formula::set(String^ value)
	{
		SetStringProperty(D2FP_FORMULA, value);
	}

	long Item::Height::get()
	{
		return GetNumberProperty(D2FP_HEIGHT);
	}

	void Item::Height::set(long value)
	{
		SetNumberProperty(D2FP_HEIGHT, value);
	}

	String^ Item::HelpBookTopic::get()
	{
		return GetStringProperty(D2FP_HELP_BOOK_TOPIC);
	}

	void Item::HelpBookTopic::set(String^ value)
	{
		SetStringProperty(D2FP_HELP_BOOK_TOPIC, value);
	}

	String^ Item::HighestAllowedValue::get()
	{
		return GetStringProperty(D2FP_HIGHEST_ALLOWED_VAL);
	}

	void Item::HighestAllowedValue::set(String^ value)
	{
		SetStringProperty(D2FP_HIGHEST_ALLOWED_VAL, value);
	}

	String^ Item::Hint::get()
	{
		return GetStringProperty(D2FP_HINT);
	}

	void Item::Hint::set(String^ value)
	{
		SetStringProperty(D2FP_HINT, value);
	}

	bool Item::Iconic::get()
	{
		return GetBooleanProperty(D2FP_ICONIC);
	}

	void Item::Iconic::set(bool value)
	{
		SetBooleanProperty(D2FP_ICONIC, value);
	}

	String^ Item::IconFilename::get()
	{
		return GetStringProperty(D2FP_ICON_FLNAM);
	}

	void Item::IconFilename::set(String^ value)
	{
		SetStringProperty(D2FP_ICON_FLNAM, value);
	}

	Ndapi::ImageDepth Item::ImageDepth::get()
	{
		return GetNumberProperty<Ndapi::ImageDepth>(D2FP_IMG_DPTH);
	}

	void Item::ImageDepth::set(Ndapi::ImageDepth value)
	{
		SetNumberProperty(D2FP_IMG_DPTH, value);
	}

	Ndapi::ImageStorageFormat Item::ImageFormat::get()
	{
		return GetNumberProperty<Ndapi::ImageStorageFormat>(D2FP_IMG_FMT);
	}

	void Item::ImageFormat::set(Ndapi::ImageStorageFormat value)
	{
		SetNumberProperty(D2FP_IMG_FMT, value);
	}

	Ndapi::InitialKeyboardDirection Item::InitialKeyboardDirection::get()
	{
		return GetNumberProperty<Ndapi::InitialKeyboardDirection>(D2FP_INIT_KBRD_DIR);
	}

	void Item::InitialKeyboardDirection::set(Ndapi::InitialKeyboardDirection value)
	{
		SetNumberProperty(D2FP_INIT_KBRD_DIR, value);
	}

	String^ Item::InitialValue::get()
	{
		return GetStringProperty(D2FP_INIT_VAL);
	}

	void Item::InitialValue::set(String^ value)
	{
		SetStringProperty(D2FP_INIT_VAL, value);
	}

	bool Item::InsertAllowed::get()
	{
		return GetBooleanProperty(D2FP_INSRT_ALLOWED);
	}

	void Item::InsertAllowed::set(bool value)
	{
		SetBooleanProperty(D2FP_INSRT_ALLOWED, value);
	}

	long Item::NumberOfItemsDisplayed::get()
	{
		return GetNumberProperty(D2FP_ITMS_DISP);
	}

	void Item::NumberOfItemsDisplayed::set(long value)
	{
		SetNumberProperty(D2FP_ITMS_DISP, value);
	}

	Ndapi::ItemType Item::ItemType::get()
	{
		return GetNumberProperty<Ndapi::ItemType>(D2FP_ITM_TYP);
	}

	void Item::ItemType::set(Ndapi::ItemType value)
	{
		SetNumberProperty(D2FP_ITM_TYP, value);
	}

	Ndapi::Justification Item::Justification::get()
	{
		return GetNumberProperty<Ndapi::Justification>(D2FP_JUSTIFICATION);
	}

	void Item::Justification::set(Ndapi::Justification value)
	{
		SetNumberProperty(D2FP_JUSTIFICATION, value);
	}

	bool Item::KeyboardNavigable::get()
	{
		return GetBooleanProperty(D2FP_KBRD_NAVIGABLE);
	}

	void Item::KeyboardNavigable::set(bool value)
	{
		SetBooleanProperty(D2FP_KBRD_NAVIGABLE, value);
	}

	bool Item::KeepCursorPosition::get()
	{
		return GetBooleanProperty(D2FP_KEEP_CRSR_POS);
	}

	void Item::KeepCursorPosition::set(bool value)
	{
		SetBooleanProperty(D2FP_KEEP_CRSR_POS, value);
	}

	String^ Item::Label::get()
	{
		return GetStringProperty(D2FP_LABEL);
	}

	void Item::Label::set(String^ value)
	{
		SetStringProperty(D2FP_LABEL, value);
	}

	Ndapi::LanguageDirection Item::LanguageDirection::get()
	{
		return GetNumberProperty<Ndapi::LanguageDirection>(D2FP_LANG_DIR);
	}

	void Item::LanguageDirection::set(Ndapi::LanguageDirection value)
	{
		SetNumberProperty(D2FP_LANG_DIR, value);
	}

	bool Item::LockRecord::get()
	{
		return GetBooleanProperty(D2FP_LOCK_REC);
	}

	void Item::LockRecord::set(bool value)
	{
		SetBooleanProperty(D2FP_LOCK_REC, value);
	}

	Ndapi::LOV^ Item::LOV::get()
	{
		return GetObjectProperty<Ndapi::LOV^>(D2FP_LOV_OBJ);
	}

	void Item::LOV::set(Ndapi::LOV^ value)
	{
		SetObjectProperty(D2FP_LOV_OBJ, value);
	}

	String^ Item::LOVName::get()
	{
		return GetStringProperty(D2FP_LOV_NAM);
	}

	void Item::LOVName::set(String^ value)
	{
		SetStringProperty(D2FP_LOV_NAM, value);
	}

	long Item::LOVXPosition::get()
	{
		return GetNumberProperty(D2FP_LOV_X_POS);
	}

	void Item::LOVXPosition::set(long value)
	{
		SetNumberProperty(D2FP_LOV_X_POS, value);
	}

	long Item::LOVXYosition::get()
	{
		return GetNumberProperty(D2FP_LOV_Y_POS);
	}

	void Item::LOVXYosition::set(long value)
	{
		SetNumberProperty(D2FP_LOV_Y_POS, value);
	}

	String^ Item::LowestAllowedValue::get()
	{
		return GetStringProperty(D2FP_LOWEST_ALLOWED_VAL);
	}

	void Item::LowestAllowedValue::set(String^ value)
	{
		SetStringProperty(D2FP_LOWEST_ALLOWED_VAL, value);
	}

	long Item::ListElementCount::get()
	{
		return GetNumberProperty(D2FP_LST_ELEMENT_COUNT);
	}

	Ndapi::ListStyle Item::ListStyle::get()
	{
		return GetNumberProperty<Ndapi::ListStyle>(D2FP_LST_STY);
	}

	void Item::ListStyle::set(Ndapi::ListStyle value)
	{
		SetNumberProperty(D2FP_LST_STY, value);
	}

	long Item::MaximumLength::get()
	{
		return GetNumberProperty(D2FP_MAX_LEN);
	}

	void Item::MaximumLength::set(long value)
	{
		SetNumberProperty(D2FP_MAX_LEN, value);
	}

	bool Item::MultiLine::get()
	{
		return GetBooleanProperty(D2FP_MLT_LIN);
	}

	void Item::MultiLine::set(bool value)
	{
		SetBooleanProperty(D2FP_MLT_LIN, value);
	}

	bool Item::MouseNavigate::get()
	{
		return GetBooleanProperty(D2FP_MOUSE_NAVIGATE);
	}

	void Item::MouseNavigate::set(bool value)
	{
		SetBooleanProperty(D2FP_MOUSE_NAVIGATE, value);
	}

	String^ Item::Name::get()
	{
		return GetStringProperty(D2FP_NAME);
	}

	void Item::Name::set(String^ value)
	{
		SetStringProperty(D2FP_NAME, value);
	}

	NdapiObject^ Item::NextNavigationItem::get()
	{
		return GetObjectProperty<NdapiObject^>(D2FP_NXT_NAVIGATION_ITM_OBJ);
	}

	void Item::NextNavigationItem::set(NdapiObject^ value)
	{
		SetObjectProperty(D2FP_NXT_NAVIGATION_ITM_OBJ, value);
	}

	long Item::OLEActivationStyle::get()
	{
		return GetNumberProperty(D2FP_OLE_ACT_STY);
	}

	void Item::OLEActivationStyle::set(long value)
	{
		SetNumberProperty(D2FP_OLE_ACT_STY, value);
	}

	String^ Item::OLEClass::get()
	{
		return GetStringProperty(D2FP_OLE_CLASS);
	}

	void Item::OLEClass::set(String^ value)
	{
		SetStringProperty(D2FP_OLE_CLASS, value);
	}

	bool Item::OLEInsideOutSupport::get()
	{
		return GetBooleanProperty(D2FP_OLE_INSD_OUT_SUPPORT);
	}

	void Item::OLEInsideOutSupport::set(bool value)
	{
		SetBooleanProperty(D2FP_OLE_INSD_OUT_SUPPORT, value);
	}

	bool Item::OLEInPlaceActivation::get()
	{
		return GetBooleanProperty(D2FP_OLE_IN_PLACE_ACT);
	}

	void Item::OLEInPlaceActivation::set(bool value)
	{
		SetBooleanProperty(D2FP_OLE_IN_PLACE_ACT, value);
	}

	long Item::OLEPopUpMenuItems::get()
	{
		return GetNumberProperty(D2FP_OLE_POPUP_MNU_ITMS);
	}

	void Item::OLEPopUpMenuItems::set(long value)
	{
		SetNumberProperty(D2FP_OLE_POPUP_MNU_ITMS, value);
	}

	OleResizeStyle Item::OLEResizeStyle::get()
	{
		return GetNumberProperty<OleResizeStyle>(D2FP_OLE_RESIZ_STY);
	}

	void Item::OLEResizeStyle::set(OleResizeStyle value)
	{
		SetNumberProperty(D2FP_OLE_RESIZ_STY, value);
	}

	bool Item::ShowOLETenantType::get()
	{
		return GetBooleanProperty(D2FP_OLE_SHOW_TNNT_TYP);
	}

	void Item::ShowOLETenantType::set(bool value)
	{
		SetBooleanProperty(D2FP_OLE_SHOW_TNNT_TYP, value);
	}

	OleTenantAspect Item::OLETenantAspect::get()
	{
		return GetNumberProperty<OleTenantAspect>(D2FP_OLE_TNNT_ASPCT);
	}

	void Item::OLETenantAspect::set(OleTenantAspect value)
	{
		SetNumberProperty(D2FP_OLE_TNNT_ASPCT, value);
	}

	OleTenantTypes Item::OLETenantTypes::get()
	{
		return GetNumberProperty<OleTenantTypes>(D2FP_OLE_TNNT_TYP);
	}

	void Item::OLETenantTypes::set(OleTenantTypes value)
	{
		SetNumberProperty(D2FP_OLE_TNNT_TYP, value);
	}

	String^ Item::MappingOfOtherValues::get()
	{
		return GetStringProperty(D2FP_OTHER_VALS);
	}

	void Item::MappingOfOtherValues::set(String^ value)
	{
		SetStringProperty(D2FP_OTHER_VALS, value);
	}

	String^ Item::PopupMenu::get()
	{
		return GetStringProperty(D2FP_POPUP_MNU_NAM);
	}

	void Item::PopupMenu::set(String^ value)
	{
		SetStringProperty(D2FP_POPUP_MNU_NAM, value);
	}

	String^ Item::PopUpMenu::get()
	{
		return GetStringProperty(D2FP_POPUP_MNU_OBJ);
	}

	void Item::PopUpMenu::set(String^ value)
	{
		SetStringProperty(D2FP_POPUP_MNU_OBJ, value);
	}

	NdapiObject^ Item::PopUpVisualAttribute::get()
	{
		return GetObjectProperty<NdapiObject^>(D2FP_POPUP_VA_OBJ);
	}

	void Item::PopUpVisualAttribute::set(NdapiObject^ value)
	{
		SetObjectProperty(D2FP_POPUP_VA_OBJ, value);
	}

	NdapiObject^ Item::PreviousNavigationItem::get()
	{
		return GetObjectProperty<NdapiObject^>(D2FP_PREV_NAVIGATION_ITM_OBJ);
	}

	void Item::PreviousNavigationItem::set(NdapiObject^ value)
	{
		SetObjectProperty(D2FP_PREV_NAVIGATION_ITM_OBJ, value);
	}

	String^ Item::Prompt::get()
	{
		return GetStringProperty(D2FP_PRMPT);
	}

	void Item::Prompt::set(String^ value)
	{
		SetStringProperty(D2FP_PRMPT, value);
	}

	Ndapi::Alignment Item::PromptAlignment::get()
	{
		return GetNumberProperty<Ndapi::Alignment>(D2FP_PRMPT_ALIGN);
	}

	void Item::PromptAlignment::set(Ndapi::Alignment value)
	{
		SetNumberProperty(D2FP_PRMPT_ALIGN, value);
	}

	long Item::PromptAlignmentOffset::get()
	{
		return GetNumberProperty(D2FP_PRMPT_ALIGN_OFST);
	}

	void Item::PromptAlignmentOffset::set(long value)
	{
		SetNumberProperty(D2FP_PRMPT_ALIGN_OFST, value);
	}

	EdgeAtachmentType Item::PromptAttachmentEdge::get()
	{
		return GetNumberProperty<EdgeAtachmentType>(D2FP_PRMPT_ATT_EDGE);
	}

	void Item::PromptAttachmentEdge::set(EdgeAtachmentType value)
	{
		SetNumberProperty(D2FP_PRMPT_ATT_EDGE, value);
	}

	long Item::PromptAttachementOffset::get()
	{
		return GetNumberProperty(D2FP_PRMPT_ATT_OFST);
	}

	void Item::PromptAttachementOffset::set(long value)
	{
		SetNumberProperty(D2FP_PRMPT_ATT_OFST, value);
	}

	String^ Item::PromptBackgroundColor::get()
	{
		return GetStringProperty(D2FP_PRMPT_BACK_COLOR);
	}

	void Item::PromptBackgroundColor::set(String^ value)
	{
		SetStringProperty(D2FP_PRMPT_BACK_COLOR, value);
	}

	Ndapi::PromptDisplayStyle Item::PromptDisplayStyle::get()
	{
		return GetNumberProperty<Ndapi::PromptDisplayStyle>(D2FP_PRMPT_DISP_STY);
	}

	void Item::PromptDisplayStyle::set(Ndapi::PromptDisplayStyle value)
	{
		SetNumberProperty(D2FP_PRMPT_DISP_STY, value);
	}

	String^ Item::PromptFillPattern::get()
	{
		return GetStringProperty(D2FP_PRMPT_FILL_PAT);
	}

	void Item::PromptFillPattern::set(String^ value)
	{
		SetStringProperty(D2FP_PRMPT_FILL_PAT, value);
	}

	String^ Item::PromptFontName::get()
	{
		return GetStringProperty(D2FP_PRMPT_FONT_NAM);
	}

	void Item::PromptFontName::set(String^ value)
	{
		SetStringProperty(D2FP_PRMPT_FONT_NAM, value);
	}

	long Item::PromptFontSize::get()
	{
		return GetNumberProperty(D2FP_PRMPT_FONT_SIZ);
	}

	void Item::PromptFontSize::set(long value)
	{
		SetNumberProperty(D2FP_PRMPT_FONT_SIZ, value);
	}

	Ndapi::FontSpacing Item::PromptFontSpacing::get()
	{
		return GetNumberProperty<Ndapi::FontSpacing>(D2FP_PRMPT_FONT_SPCING);
	}

	void Item::PromptFontSpacing::set(Ndapi::FontSpacing value)
	{
		SetNumberProperty(D2FP_PRMPT_FONT_SPCING, value);
	}

	Ndapi::FontStyle Item::PromptFontStyle::get()
	{
		return GetNumberProperty<Ndapi::FontStyle>(D2FP_PRMPT_FONT_STY);
	}

	void Item::PromptFontStyle::set(Ndapi::FontStyle value)
	{
		SetNumberProperty(D2FP_PRMPT_FONT_STY, value);
	}

	Ndapi::FontWeight Item::PromptFontWeight::get()
	{
		return GetNumberProperty<Ndapi::FontWeight>(D2FP_PRMPT_FONT_WGHT);
	}

	void Item::PromptFontWeight::set(Ndapi::FontWeight value)
	{
		SetNumberProperty(D2FP_PRMPT_FONT_WGHT, value);
	}

	String^ Item::PromptForegroundColor::get()
	{
		return GetStringProperty(D2FP_PRMPT_FORE_COLOR);
	}

	void Item::PromptForegroundColor::set(String^ value)
	{
		SetStringProperty(D2FP_PRMPT_FORE_COLOR, value);
	}

	Ndapi::Justification Item::PromptJustification::get()
	{
		return GetNumberProperty<Ndapi::Justification>(D2FP_PRMPT_JST);
	}

	void Item::PromptJustification::set(Ndapi::Justification value)
	{
		SetNumberProperty(D2FP_PRMPT_JST, value);
	}

	Ndapi::ReadingOrder Item::PromptReadingOrder::get()
	{
		return GetNumberProperty<Ndapi::ReadingOrder>(D2FP_PRMPT_READING_ORDR);
	}

	void Item::PromptReadingOrder::set(Ndapi::ReadingOrder value)
	{
		SetNumberProperty(D2FP_PRMPT_READING_ORDR, value);
	}

	String^ Item::PromptVisualAttributeGroup::get()
	{
		return GetStringProperty(D2FP_PRMPT_VAT_NAM);
	}

	void Item::PromptVisualAttributeGroup::set(String^ value)
	{
		SetStringProperty(D2FP_PRMPT_VAT_NAM, value);
	}

	NdapiObject^ Item::PromptVisualAttribute::get()
	{
		return GetObjectProperty<NdapiObject^>(D2FP_PRMPT_VAT_OBJ);
	}

	void Item::PromptVisualAttribute::set(NdapiObject^ value)
	{
		SetObjectProperty(D2FP_PRMPT_VAT_OBJ, value);
	}

	bool Item::PrimaryKey::get()
	{
		return GetBooleanProperty(D2FP_PRMRY_KEY);
	}

	void Item::PrimaryKey::set(bool value)
	{
		SetBooleanProperty(D2FP_PRMRY_KEY, value);
	}

	bool Item::QueryAllowed::get()
	{
		return GetBooleanProperty(D2FP_QRY_ALLOWED);
	}

	void Item::QueryAllowed::set(bool value)
	{
		SetBooleanProperty(D2FP_QRY_ALLOWED, value);
	}

	long Item::QueryLength::get()
	{
		return GetNumberProperty(D2FP_QRY_LEN);
	}

	void Item::QueryLength::set(long value)
	{
		SetNumberProperty(D2FP_QRY_LEN, value);
	}

	bool Item::QueryOnly::get()
	{
		return GetBooleanProperty(D2FP_QRY_ONLY);
	}

	void Item::QueryOnly::set(bool value)
	{
		SetBooleanProperty(D2FP_QRY_ONLY, value);
	}

	NdapiObject^ Item::RadioButtons::get()
	{
		return GetObjectProperty<NdapiObject^>(D2FP_RAD_BUT);
	}

	Ndapi::ReadingOrder Item::ReadingOrder::get()
	{
		return GetNumberProperty<Ndapi::ReadingOrder>(D2FP_READING_ORDR);
	}

	void Item::ReadingOrder::set(Ndapi::ReadingOrder value)
	{
		SetNumberProperty(D2FP_READING_ORDR, value);
	}

	String^ Item::CurrentRecordVisualAttributeGroup::get()
	{
		return GetStringProperty(D2FP_REC_VAT_GRP_NAM);
	}

	void Item::CurrentRecordVisualAttributeGroup::set(String^ value)
	{
		SetStringProperty(D2FP_REC_VAT_GRP_NAM, value);
	}

	NdapiObject^ Item::CurrentRecordVisualAttribute::get()
	{
		return GetObjectProperty<NdapiObject^>(D2FP_REC_VAT_GRP_OBJ);
	}

	void Item::CurrentRecordVisualAttribute::set(NdapiObject^ value)
	{
		SetObjectProperty(D2FP_REC_VAT_GRP_OBJ, value);
	}

	bool Item::Rendered::get()
	{
		return GetBooleanProperty(D2FP_RENDERED);
	}

	void Item::Rendered::set(bool value)
	{
		SetBooleanProperty(D2FP_RENDERED, value);
	}

	bool Item::Required::get()
	{
		return GetBooleanProperty(D2FP_REQUIRED);
	}

	void Item::Required::set(bool value)
	{
		SetBooleanProperty(D2FP_REQUIRED, value);
	}

	bool Item::ShowFastForwardButton::get()
	{
		return GetBooleanProperty(D2FP_SHOW_FAST_FWD);
	}

	void Item::ShowFastForwardButton::set(bool value)
	{
		SetBooleanProperty(D2FP_SHOW_FAST_FWD, value);
	}

	bool Item::ShowHorizonatalScrollbar::get()
	{
		return GetBooleanProperty(D2FP_SHOW_HORZ_SCRLBR);
	}

	void Item::ShowHorizonatalScrollbar::set(bool value)
	{
		SetBooleanProperty(D2FP_SHOW_HORZ_SCRLBR, value);
	}

	bool Item::ShowPalette::get()
	{
		return GetBooleanProperty(D2FP_SHOW_PALETTE);
	}

	void Item::ShowPalette::set(bool value)
	{
		SetBooleanProperty(D2FP_SHOW_PALETTE, value);
	}

	bool Item::ShowPlayButton::get()
	{
		return GetBooleanProperty(D2FP_SHOW_PLAY);
	}

	void Item::ShowPlayButton::set(bool value)
	{
		SetBooleanProperty(D2FP_SHOW_PLAY, value);
	}

	bool Item::ShowRecordButton::get()
	{
		return GetBooleanProperty(D2FP_SHOW_REC);
	}

	void Item::ShowRecordButton::set(bool value)
	{
		SetBooleanProperty(D2FP_SHOW_REC, value);
	}

	bool Item::ShowRewindButton::get()
	{
		return GetBooleanProperty(D2FP_SHOW_REWIND);
	}

	void Item::ShowRewindButton::set(bool value)
	{
		SetBooleanProperty(D2FP_SHOW_REWIND, value);
	}

	bool Item::ShowSlider::get()
	{
		return GetBooleanProperty(D2FP_SHOW_SLIDER);
	}

	void Item::ShowSlider::set(bool value)
	{
		SetBooleanProperty(D2FP_SHOW_SLIDER, value);
	}

	bool Item::ShowTimeIndicator::get()
	{
		return GetBooleanProperty(D2FP_SHOW_TIME);
	}

	void Item::ShowTimeIndicator::set(bool value)
	{
		SetBooleanProperty(D2FP_SHOW_TIME, value);
	}

	bool Item::ShowVerticalScrollBar::get()
	{
		return GetBooleanProperty(D2FP_SHOW_VERT_SCRLBR);
	}

	void Item::ShowVerticalScrollBar::set(bool value)
	{
		SetBooleanProperty(D2FP_SHOW_VERT_SCRLBR, value);
	}

	bool Item::ShowVolumeControl::get()
	{
		return GetBooleanProperty(D2FP_SHOW_VOLUME);
	}

	void Item::ShowVolumeControl::set(bool value)
	{
		SetBooleanProperty(D2FP_SHOW_VOLUME, value);
	}

	ImageSizingStyle Item::SizingStyle::get()
	{
		return GetNumberProperty<ImageSizingStyle>(D2FP_SIZING_STY);
	}

	void Item::SizingStyle::set(ImageSizingStyle value)
	{
		SetNumberProperty(D2FP_SIZING_STY, value);
	}

	Ndapi::SoundFormat Item::SoundFormat::get()
	{
		return GetNumberProperty<Ndapi::SoundFormat>(D2FP_SND_FMT);
	}

	void Item::SoundFormat::set(Ndapi::SoundFormat value)
	{
		SetNumberProperty(D2FP_SND_FMT, value);
	}

	Ndapi::SoundQuality Item::SoundQuality::get()
	{
		return GetNumberProperty<Ndapi::SoundQuality>(D2FP_SND_QLTY);
	}

	void Item::SoundQuality::set(Ndapi::SoundQuality value)
	{
		SetNumberProperty(D2FP_SND_QLTY, value);
	}

	String^ Item::SummarizedBlock::get()
	{
		return GetStringProperty(D2FP_SUMM_BLK_NAM);
	}

	void Item::SummarizedBlock::set(String^ value)
	{
		SetStringProperty(D2FP_SUMM_BLK_NAM, value);
	}

	SummaryFunction Item::SummarizedFunction::get()
	{
		return GetNumberProperty<SummaryFunction>(D2FP_SUMM_FUNC);
	}

	void Item::SummarizedFunction::set(SummaryFunction value)
	{
		SetNumberProperty(D2FP_SUMM_FUNC, value);
	}

	String^ Item::SummarizedItem::get()
	{
		return GetStringProperty(D2FP_SUMM_ITM_NAM);
	}

	void Item::SummarizedItem::set(String^ value)
	{
		SetStringProperty(D2FP_SUMM_ITM_NAM, value);
	}

	NdapiObject^ Item::SynchronizeWithItem::get()
	{
		return GetObjectProperty<NdapiObject^>(D2FP_SYNC_ITM_OBJ);
	}

	void Item::SynchronizeWithItem::set(NdapiObject^ value)
	{
		SetObjectProperty(D2FP_SYNC_ITM_OBJ, value);
	}

	NdapiObject^ Item::TabPage::get()
	{
		return GetObjectProperty<NdapiObject^>(D2FP_TBP_OBJ);
	}

	void Item::TabPage::set(NdapiObject^ value)
	{
		SetObjectProperty(D2FP_TBP_OBJ, value);
	}

	String^ Item::Tooltip::get()
	{
		return GetStringProperty(D2FP_TOOLTIP);
	}

	void Item::Tooltip::set(String^ value)
	{
		SetStringProperty(D2FP_TOOLTIP, value);
	}

	String^ Item::TooltipVisualAttributeGroup::get()
	{
		return GetStringProperty(D2FP_TOOLTIP_VAT_GRP);
	}

	void Item::TooltipVisualAttributeGroup::set(String^ value)
	{
		SetStringProperty(D2FP_TOOLTIP_VAT_GRP, value);
	}

	String^ Item::ValueWhenUnchecked::get()
	{
		return GetStringProperty(D2FP_UNCHKED_VAL);
	}

	void Item::ValueWhenUnchecked::set(String^ value)
	{
		SetStringProperty(D2FP_UNCHKED_VAL, value);
	}

	bool Item::UpdateAllowed::get()
	{
		return GetBooleanProperty(D2FP_UPDT_ALLOWED);
	}

	void Item::UpdateAllowed::set(bool value)
	{
		SetBooleanProperty(D2FP_UPDT_ALLOWED, value);
	}

	bool Item::UpdateCommit::get()
	{
		return GetBooleanProperty(D2FP_UPDT_COMMIT);
	}

	void Item::UpdateCommit::set(bool value)
	{
		SetBooleanProperty(D2FP_UPDT_COMMIT, value);
	}

	bool Item::UpdateOnlyIfNull::get()
	{
		return GetBooleanProperty(D2FP_UPDT_IF_NULL);
	}

	void Item::UpdateOnlyIfNull::set(bool value)
	{
		SetBooleanProperty(D2FP_UPDT_IF_NULL, value);
	}

	bool Item::UpdateQuery::get()
	{
		return GetBooleanProperty(D2FP_UPDT_QRY);
	}

	void Item::UpdateQuery::set(bool value)
	{
		SetBooleanProperty(D2FP_UPDT_QRY, value);
	}

	bool Item::ValidateFromList::get()
	{
		return GetBooleanProperty(D2FP_VALIDATE_FROM_LST);
	}

	void Item::ValidateFromList::set(bool value)
	{
		SetBooleanProperty(D2FP_VALIDATE_FROM_LST, value);
	}

	String^ Item::VisualAttributeGroup::get()
	{
		return GetStringProperty(D2FP_VAT_NAM);
	}

	void Item::VisualAttributeGroup::set(String^ value)
	{
		SetStringProperty(D2FP_VAT_NAM, value);
	}

	NdapiObject^ Item::VisualAttribute::get()
	{
		return GetObjectProperty<NdapiObject^>(D2FP_VAT_OBJ);
	}

	void Item::VisualAttribute::set(NdapiObject^ value)
	{
		SetObjectProperty(D2FP_VAT_OBJ, value);
	}

	bool Item::Visible::get()
	{
		return GetBooleanProperty(D2FP_VISIBLE);
	}

	void Item::Visible::set(bool value)
	{
		SetBooleanProperty(D2FP_VISIBLE, value);
	}

	bool Item::WhiteOnBlack::get()
	{
		return GetBooleanProperty(D2FP_WHITE_ON_BLACK);
	}

	void Item::WhiteOnBlack::set(bool value)
	{
		SetBooleanProperty(D2FP_WHITE_ON_BLACK, value);
	}

	long Item::Width::get()
	{
		return GetNumberProperty(D2FP_WIDTH);
	}

	void Item::Width::set(long value)
	{
		SetNumberProperty(D2FP_WIDTH, value);
	}

	Ndapi::WrapStyle Item::WrapStyle::get()
	{
		return GetNumberProperty<Ndapi::WrapStyle>(D2FP_WRAP_STY);
	}

	void Item::WrapStyle::set(Ndapi::WrapStyle value)
	{
		SetNumberProperty(D2FP_WRAP_STY, value);
	}

	long Item::XPosition::get()
	{
		return GetNumberProperty(D2FP_X_POS);
	}

	void Item::XPosition::set(long value)
	{
		SetNumberProperty(D2FP_X_POS, value);
	}

	long Item::YPosition::get()
	{
		return GetNumberProperty(D2FP_Y_POS);
	}

	void Item::YPosition::set(long value)
	{
		SetNumberProperty(D2FP_Y_POS, value);
	}

	NdapiEnumerator<Trigger^>^ Item::Triggers::get()
	{
		return gcnew NdapiObjectEnumerator<Trigger^>(_handler, D2FP_TRIGGER);
	}
}
