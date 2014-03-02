#include "stdafx.h"
#include "Alert.h"


namespace Ndapi
{
	Alert::Alert() : NdapiObject()
	{
	}

	Alert::Alert(d2fob* alert) : NdapiObject(alert)
	{
	}

	Alert::Alert(FormModule^ form, String^ name)
	{
		Create(name, form, D2FFO_ALERT);
	}
	
	String^ Alert::Message::get()
	{
		return GetStringProperty(D2FP_ALT_MSG);
	}

	void Alert::Message::set(String^ value)
	{
		SetStringProperty(D2FP_ALT_MSG, value);
	}

	AlertStyle Alert::AlertStyle::get()
	{
		return safe_cast<Ndapi::AlertStyle>(GetNumberProperty(D2FP_ALT_STY));
	}

	void Alert::AlertStyle::set(Ndapi::AlertStyle value)
	{
		SetNumberProperty(D2FP_ALT_STY, safe_cast<long>(value));
	}

	String^ Alert::BackgroundColor::get()
	{
		return GetStringProperty(D2FP_BACK_COLOR);
	}

	void Alert::BackgroundColor::set(String^ value)
	{
		SetStringProperty(D2FP_BACK_COLOR, value);
	}

	String^ Alert::Button1Label::get()
	{
		return GetStringProperty(D2FP_BTN_1_LBL);
	}

	void Alert::Button1Label::set(String^ value)
	{
		SetStringProperty(D2FP_BTN_1_LBL, value);
	}

	String^ Alert::Button2Label::get()
	{
		return GetStringProperty(D2FP_BTN_2_LBL);
	}

	void Alert::Button2Label::set(String^ value)
	{
		SetStringProperty(D2FP_BTN_2_LBL, value);
	}

	String^ Alert::Button3Label::get()
	{
		return GetStringProperty(D2FP_BTN_3_LBL);
	}

	void Alert::Button3Label::set(String^ value)
	{
		SetStringProperty(D2FP_BTN_3_LBL, value);
	}

	String^ Alert::Comment::get()
	{
		return GetStringProperty(D2FP_COMMENT);
	}

	void Alert::Comment::set(String^ value)
	{
		SetStringProperty(D2FP_COMMENT, value);
	}

	AlertButton Alert::DefaultAlertButton::get()
	{
		return safe_cast<AlertButton>(GetNumberProperty(D2FP_DFLT_ALT_BTN));
	}

	void Alert::DefaultAlertButton::set(AlertButton value)
	{
		SetNumberProperty(D2FP_DFLT_ALT_BTN, safe_cast<long>(value));
	}

	String^ Alert::FillPattern::get()
	{
		return GetStringProperty(D2FP_FILL_PAT);
	}

	void Alert::FillPattern::set(String^ value)
	{
		SetStringProperty(D2FP_FILL_PAT, value);
	}

	String^ Alert::FontName::get()
	{
		return GetStringProperty(D2FP_FONT_NAM);
	}

	void Alert::FontName::set(String^ value)
	{
		SetStringProperty(D2FP_FONT_NAM, value);
	}

	long Alert::FontSize::get()
	{
		return GetNumberProperty(D2FP_FONT_SIZ);
	}

	void Alert::FontSize::set(long value)
	{
		SetNumberProperty(D2FP_FONT_SIZ, value);
	}

	Ndapi::FontSpacing Alert::FontSpacing::get()
	{
		return safe_cast<Ndapi::FontSpacing>(GetNumberProperty(D2FP_FONT_SPCING));
	}

	void Alert::FontSpacing::set(Ndapi::FontSpacing value)
	{
		SetNumberProperty(D2FP_FONT_SPCING, safe_cast<long>(value));
	}

	Ndapi::FontStyle Alert::FontStyle::get()
	{
		return safe_cast<Ndapi::FontStyle>(GetNumberProperty(D2FP_FONT_STY));
	}

	void Alert::FontStyle::set(Ndapi::FontStyle value)
	{
		SetNumberProperty(D2FP_FONT_STY, safe_cast<long>(value));
	}

	Ndapi::FontWeight Alert::FontWeight::get()
	{
		return safe_cast<Ndapi::FontWeight>(GetNumberProperty(D2FP_FONT_WGHT));
	}

	void Alert::FontWeight::set(Ndapi::FontWeight value)
	{
		SetNumberProperty(D2FP_FONT_WGHT, safe_cast<long>(value));
	}

	String^ Alert::ForegroundColor::get()
	{
		return GetStringProperty(D2FP_FORE_COLOR);
	}

	void Alert::ForegroundColor::set(String^ value)
	{
		SetStringProperty(D2FP_FORE_COLOR, value);
	}

	Ndapi::LanguageDirection Alert::LanguageDirection::get()
	{
		return safe_cast<Ndapi::LanguageDirection>(GetNumberProperty(D2FP_LANG_DIR));
	}

	void Alert::LanguageDirection::set(Ndapi::LanguageDirection value)
	{
		SetNumberProperty(D2FP_LANG_DIR, safe_cast<long>(value));
	}

	String^ Alert::Name::get()
	{
		return GetStringProperty(D2FP_NAME);
	}

	void Alert::Name::set(String^ value)
	{
		SetStringProperty(D2FP_NAME, value);
	}

	String^ Alert::Title::get()
	{
		return GetStringProperty(D2FP_TITLE);
	}

	void Alert::Title::set(String^ value)
	{
		SetStringProperty(D2FP_TITLE, value);
	}

	bool Alert::WhiteOnBlack::get()
	{
		return GetBooleanProperty(D2FP_WHITE_ON_BLACK);
	}

	void Alert::WhiteOnBlack::set(bool value)
	{
		SetBooleanProperty(D2FP_WHITE_ON_BLACK, value);
	}
}