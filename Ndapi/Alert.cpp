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
		return GetNumberProperty<Ndapi::AlertStyle>(D2FP_ALT_STY);
	}

	void Alert::AlertStyle::set(Ndapi::AlertStyle value)
	{
		SetNumberProperty(D2FP_ALT_STY, value);
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
		return GetNumberProperty<AlertButton>(D2FP_DFLT_ALT_BTN);
	}

	void Alert::DefaultAlertButton::set(AlertButton value)
	{
		SetNumberProperty(D2FP_DFLT_ALT_BTN, value);
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
		return GetNumberProperty<Ndapi::FontSpacing>(D2FP_FONT_SPCING);
	}

	void Alert::FontSpacing::set(Ndapi::FontSpacing value)
	{
		SetNumberProperty(D2FP_FONT_SPCING, value);
	}

	Ndapi::FontStyle Alert::FontStyle::get()
	{
		return GetNumberProperty<Ndapi::FontStyle>(D2FP_FONT_STY);
	}

	void Alert::FontStyle::set(Ndapi::FontStyle value)
	{
		SetNumberProperty(D2FP_FONT_STY, value);
	}

	Ndapi::FontWeight Alert::FontWeight::get()
	{
		return GetNumberProperty<Ndapi::FontWeight>(D2FP_FONT_WGHT);
	}

	void Alert::FontWeight::set(Ndapi::FontWeight value)
	{
		SetNumberProperty(D2FP_FONT_WGHT, value);
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
		return GetNumberProperty<Ndapi::LanguageDirection>(D2FP_LANG_DIR);
	}

	void Alert::LanguageDirection::set(Ndapi::LanguageDirection value)
	{
		SetNumberProperty(D2FP_LANG_DIR, value);
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