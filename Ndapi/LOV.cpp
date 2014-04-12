#include "stdafx.h"
#include "LOV.h"

namespace Ndapi
{
	LOV::LOV() : NdapiObject()
	{
	}

	LOV::LOV(d2fob* alert) : NdapiObject(alert)
	{
	}

	LOV::LOV(FormModule^ form, String^ name)
	{
		Create(name, form, D2FFO_LOV);
	}

	bool LOV::AutomaticColumnWidth::get()
	{
		return GetBooleanProperty(D2FP_AUTO_COL_WID);
	}

	void LOV::AutomaticColumnWidth::set(bool value)
	{
		SetBooleanProperty(D2FP_AUTO_COL_WID, value);
	}

	bool LOV::AutomaticDisplay::get()
	{
		return GetBooleanProperty(D2FP_AUTO_DISP);
	}

	void LOV::AutomaticDisplay::set(bool value)
	{
		SetBooleanProperty(D2FP_AUTO_DISP, value);
	}

	bool LOV::AutomaticPosition::get()
	{
		return GetBooleanProperty(D2FP_AUTO_POS);
	}

	void LOV::AutomaticPosition::set(bool value)
	{
		SetBooleanProperty(D2FP_AUTO_POS, value);
	}

	bool LOV::AutomaticRefresh::get()
	{
		return GetBooleanProperty(D2FP_AUTO_RFRSH);
	}

	void LOV::AutomaticRefresh::set(bool value)
	{
		SetBooleanProperty(D2FP_AUTO_RFRSH, value);
	}

	bool LOV::AutomaticSkip::get()
	{
		return GetBooleanProperty(D2FP_AUTO_SKP);
	}

	void LOV::AutomaticSkip::set(bool value)
	{
		SetBooleanProperty(D2FP_AUTO_SKP, value);
	}

	bool LOV::AutomaticSelect::get()
	{
		return GetBooleanProperty(D2FP_AUTO_SLCT);
	}

	void LOV::AutomaticSelect::set(bool value)
	{
		SetBooleanProperty(D2FP_AUTO_SLCT, value);
	}

	String^ LOV::BackgroundColor::get()
	{
		return GetStringProperty(D2FP_BACK_COLOR);
	}

	void LOV::BackgroundColor::set(String^ value)
	{
		SetStringProperty(D2FP_BACK_COLOR, value);
	}

	NdapiObject^ LOV::ColumnMappingProperties::get()
	{
		return GetObjectProperty<NdapiObject^>(D2FP_COL_MAP);
	}

	String^ LOV::Comment::get()
	{
		return GetStringProperty(D2FP_COMMENT);
	}

	void LOV::Comment::set(String^ value)
	{
		SetStringProperty(D2FP_COMMENT, value);
	}

	String^ LOV::FillPattern::get()
	{
		return GetStringProperty(D2FP_FILL_PAT);
	}

	void LOV::FillPattern::set(String^ value)
	{
		SetStringProperty(D2FP_FILL_PAT, value);
	}

	bool LOV::FilterBeforeDisplay::get()
	{
		return GetBooleanProperty(D2FP_FLTR_BEFORE_DISP);
	}

	void LOV::FilterBeforeDisplay::set(bool value)
	{
		SetBooleanProperty(D2FP_FLTR_BEFORE_DISP, value);
	}

	String^ LOV::FontName::get()
	{
		return GetStringProperty(D2FP_FONT_NAM);
	}

	void LOV::FontName::set(String^ value)
	{
		SetStringProperty(D2FP_FONT_NAM, value);
	}

	long LOV::FontSize::get()
	{
		return GetNumberProperty(D2FP_FONT_SIZ);
	}

	void LOV::FontSize::set(long value)
	{
		SetNumberProperty(D2FP_FONT_SIZ, value);
	}

	Ndapi::FontSpacing LOV::FontSpacing::get()
	{
		return GetNumberProperty<Ndapi::FontSpacing>(D2FP_FONT_SPCING);
	}

	void LOV::FontSpacing::set(Ndapi::FontSpacing value)
	{
		SetNumberProperty(D2FP_FONT_SPCING, value);
	}

	Ndapi::FontStyle LOV::FontStyle::get()
	{
		return GetNumberProperty<Ndapi::FontStyle>(D2FP_FONT_STY);
	}

	void LOV::FontStyle::set(Ndapi::FontStyle value)
	{
		SetNumberProperty(D2FP_FONT_STY, value);
	}

	Ndapi::FontWeight LOV::FontWeight::get()
	{
		return GetNumberProperty<Ndapi::FontWeight>(D2FP_FONT_WGHT);
	}

	void LOV::FontWeight::set(Ndapi::FontWeight value)
	{
		SetNumberProperty(D2FP_FONT_WGHT, value);
	}

	String^ LOV::ForegroundColor::get()
	{
		return GetStringProperty(D2FP_FORE_COLOR);
	}

	void LOV::ForegroundColor::set(String^ value)
	{
		SetStringProperty(D2FP_FORE_COLOR, value);
	}

	long LOV::Height::get()
	{
		return GetNumberProperty(D2FP_HEIGHT);
	}

	void LOV::Height::set(long value)
	{
		SetNumberProperty(D2FP_HEIGHT, value);
	}

	Ndapi::LanguageDirection LOV::LanguageDirection::get()
	{
		return GetNumberProperty<Ndapi::LanguageDirection>(D2FP_LANG_DIR);
	}

	void LOV::LanguageDirection::set(Ndapi::LanguageDirection value)
	{
		SetNumberProperty(D2FP_LANG_DIR, value);
	}

	Ndapi::ListType LOV::ListType::get()
	{
		return GetNumberProperty<Ndapi::ListType>(D2FP_LST_TYP);
	}

	void LOV::ListType::set(Ndapi::ListType value)
	{
		SetNumberProperty(D2FP_LST_TYP, value);
	}

	String^ LOV::Name::get()
	{
		return GetStringProperty(D2FP_NAME);
	}

	void LOV::Name::set(String^ value)
	{
		SetStringProperty(D2FP_NAME, value);
	}

	String^ LOV::OldLOVText::get()
	{
		return GetStringProperty(D2FP_OLD_LOV_TXT);
	}

	void LOV::OldLOVText::set(String^ value)
	{
		SetStringProperty(D2FP_OLD_LOV_TXT, value);
	}

	Ndapi::RecordGroup^ LOV::RecordGroup::get()
	{
		return GetObjectProperty<Ndapi::RecordGroup^>(D2FP_REC_GRP_OBJ);
	}

	void LOV::RecordGroup::set(Ndapi::RecordGroup^ value)
	{
		SetObjectProperty(D2FP_REC_GRP_OBJ, value);
	}

	String^ LOV::Title::get()
	{
		return GetStringProperty(D2FP_TITLE);
	}

	void LOV::Title::set(String^ value)
	{
		SetStringProperty(D2FP_TITLE, value);
	}

	String^ LOV::VisualAttributeGroup::get()
	{
		return GetStringProperty(D2FP_VAT_NAM);
	}

	void LOV::VisualAttributeGroup::set(String^ value)
	{
		SetStringProperty(D2FP_VAT_NAM, value);
	}

	bool LOV::WhiteOnBlack::get()
	{
		return GetBooleanProperty(D2FP_WHITE_ON_BLACK);
	}

	void LOV::WhiteOnBlack::set(bool value)
	{
		SetBooleanProperty(D2FP_WHITE_ON_BLACK, value);
	}

	long LOV::Width::get()
	{
		return GetNumberProperty(D2FP_WIDTH);
	}

	void LOV::Width::set(long value)
	{
		SetNumberProperty(D2FP_WIDTH, value);
	}

	long LOV::XPosition::get()
	{
		return GetNumberProperty(D2FP_X_POS);
	}

	void LOV::XPosition::set(long value)
	{
		SetNumberProperty(D2FP_X_POS, value);
	}

	long LOV::YPosition::get()
	{
		return GetNumberProperty(D2FP_Y_POS);
	}

	void LOV::YPosition::set(long value)
	{
		SetNumberProperty(D2FP_Y_POS, value);
	}
}