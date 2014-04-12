#include "stdafx.h"
#include "Window.h"

namespace Ndapi
{
	Window::Window() : NdapiObject()
	{
	}

	Window::Window(d2fob* alert) : NdapiObject(alert)
	{
	}

	Window::Window(FormModule^ form, String^ name)
	{
		Create(name, form, D2FFO_WINDOW);
	}

	String^ Window::BackgroundColor::get()
	{
		return GetStringProperty(D2FP_BACK_COLOR);
	}

	void Window::BackgroundColor::set(String^ value)
	{
		SetStringProperty(D2FP_BACK_COLOR, value);
	}

	Ndapi::Bevel Window::Bevel::get()
	{
		return GetNumberProperty<Ndapi::Bevel>(D2FP_BEVEL);
	}

	void Window::Bevel::set(Ndapi::Bevel value)
	{
		SetNumberProperty(D2FP_BEVEL, value);
	}

	bool Window::CloseAllowed::get()
	{
		return GetBooleanProperty(D2FP_CLS_ALLOWED);
	}

	void Window::CloseAllowed::set(bool value)
	{
		SetBooleanProperty(D2FP_CLS_ALLOWED, value);
	}

	String^ Window::Comment::get()
	{
		return GetStringProperty(D2FP_COMMENT);
	}

	void Window::Comment::set(String^ value)
	{
		SetStringProperty(D2FP_COMMENT, value);
	}

	String^ Window::FillPattern::get()
	{
		return GetStringProperty(D2FP_FILL_PAT);
	}

	void Window::FillPattern::set(String^ value)
	{
		SetStringProperty(D2FP_FILL_PAT, value);
	}

	String^ Window::FontName::get()
	{
		return GetStringProperty(D2FP_FONT_NAM);
	}

	void Window::FontName::set(String^ value)
	{
		SetStringProperty(D2FP_FONT_NAM, value);
	}

	long Window::FontSize::get()
	{
		return GetNumberProperty(D2FP_FONT_SIZ);
	}

	void Window::FontSize::set(long value)
	{
		SetNumberProperty(D2FP_FONT_SIZ, value);
	}

	Ndapi::FontSpacing Window::FontSpacing::get()
	{
		return GetNumberProperty<Ndapi::FontSpacing>(D2FP_FONT_SPCING);
	}

	void Window::FontSpacing::set(Ndapi::FontSpacing value)
	{
		SetNumberProperty(D2FP_FONT_SPCING, value);
	}

	Ndapi::FontStyle Window::FontStyle::get()
	{
		return GetNumberProperty<Ndapi::FontStyle>(D2FP_FONT_STY);
	}

	void Window::FontStyle::set(Ndapi::FontStyle value)
	{
		SetNumberProperty(D2FP_FONT_STY, value);
	}

	Ndapi::FontWeight Window::FontWeight::get()
	{
		return GetNumberProperty<Ndapi::FontWeight>(D2FP_FONT_WGHT);
	}

	void Window::FontWeight::set(Ndapi::FontWeight value)
	{
		SetNumberProperty(D2FP_FONT_WGHT, value);
	}

	String^ Window::ForegroundColor::get()
	{
		return GetStringProperty(D2FP_FORE_COLOR);
	}

	void Window::ForegroundColor::set(String^ value)
	{
		SetStringProperty(D2FP_FORE_COLOR, value);
	}

	long Window::Height::get()
	{
		return GetNumberProperty(D2FP_HEIGHT);
	}

	void Window::Height::set(long value)
	{
		SetNumberProperty(D2FP_HEIGHT, value);
	}

	String^ Window::HelpBookTopic::get()
	{
		return GetStringProperty(D2FP_HELP_BOOK_TOPIC);
	}

	void Window::HelpBookTopic::set(String^ value)
	{
		SetStringProperty(D2FP_HELP_BOOK_TOPIC, value);
	}

	bool Window::HideOnExit::get()
	{
		return GetBooleanProperty(D2FP_HIDE_ON_EXIT);
	}

	void Window::HideOnExit::set(bool value)
	{
		SetBooleanProperty(D2FP_HIDE_ON_EXIT, value);
	}

	String^ Window::HorizontalToolbarCanvas::get()
	{
		return GetStringProperty(D2FP_HTB_CNV_NAME);
	}

	void Window::HorizontalToolbarCanvas::set(String^ value)
	{
		SetStringProperty(D2FP_HTB_CNV_NAME, value);
	}

	String^ Window::IconFilename::get()
	{
		return GetStringProperty(D2FP_ICON_FLNAM);
	}

	void Window::IconFilename::set(String^ value)
	{
		SetStringProperty(D2FP_ICON_FLNAM, value);
	}

	bool Window::InheritMenu::get()
	{
		return GetBooleanProperty(D2FP_INHRT_MNU);
	}

	void Window::InheritMenu::set(bool value)
	{
		SetBooleanProperty(D2FP_INHRT_MNU, value);
	}

	Ndapi::LanguageDirection Window::LanguageDirection::get()
	{
		return GetNumberProperty<Ndapi::LanguageDirection>(D2FP_LANG_DIR);
	}

	void Window::LanguageDirection::set(Ndapi::LanguageDirection value)
	{
		SetNumberProperty(D2FP_LANG_DIR, value);
	}

	bool Window::MaximizeAllowed::get()
	{
		return GetBooleanProperty(D2FP_MAXIMIZE_ALLOWED);
	}

	void Window::MaximizeAllowed::set(bool value)
	{
		SetBooleanProperty(D2FP_MAXIMIZE_ALLOWED, value);
	}

	bool Window::MinimizedAllowed::get()
	{
		return GetBooleanProperty(D2FP_MINIMIZE_ALLOWED);
	}

	void Window::MinimizedAllowed::set(bool value)
	{
		SetBooleanProperty(D2FP_MINIMIZE_ALLOWED, value);
	}

	String^ Window::MinimizeTitle::get()
	{
		return GetStringProperty(D2FP_MINIMIZE_TTL);
	}

	void Window::MinimizeTitle::set(String^ value)
	{
		SetStringProperty(D2FP_MINIMIZE_TTL, value);
	}

	bool Window::Modal::get()
	{
		return GetBooleanProperty(D2FP_MODAL);
	}

	void Window::Modal::set(bool value)
	{
		SetBooleanProperty(D2FP_MODAL, value);
	}

	bool Window::MoveAllowed::get()
	{
		return GetBooleanProperty(D2FP_MV_ALLOWED);
	}

	void Window::MoveAllowed::set(bool value)
	{
		SetBooleanProperty(D2FP_MV_ALLOWED, value);
	}

	String^ Window::Name::get()
	{
		return GetStringProperty(D2FP_NAME);
	}

	void Window::Name::set(String^ value)
	{
		SetStringProperty(D2FP_NAME, value);
	}

	String^ Window::PrimaryCanvas::get()
	{
		return GetStringProperty(D2FP_PRMRY_CNV);
	}

	void Window::PrimaryCanvas::set(String^ value)
	{
		SetStringProperty(D2FP_PRMRY_CNV, value);
	}

	bool Window::ResizeAllowed::get()
	{
		return GetBooleanProperty(D2FP_RESIZE_ALLOWED);
	}

	void Window::ResizeAllowed::set(bool value)
	{
		SetBooleanProperty(D2FP_RESIZE_ALLOWED, value);
	}

	bool Window::ShowHorizontalScrollBar::get()
	{
		return GetBooleanProperty(D2FP_SHOW_HORZ_SCRLBR);
	}

	void Window::ShowHorizontalScrollBar::set(bool value)
	{
		SetBooleanProperty(D2FP_SHOW_HORZ_SCRLBR, value);
	}

	bool Window::ShowVerticalScrollBar::get()
	{
		return GetBooleanProperty(D2FP_SHOW_VERT_SCRLBR);
	}

	void Window::ShowVerticalScrollBar::set(bool value)
	{
		SetBooleanProperty(D2FP_SHOW_VERT_SCRLBR, value);
	}

	String^ Window::Title::get()
	{
		return GetStringProperty(D2FP_TITLE);
	}

	void Window::Title::set(String^ value)
	{
		SetStringProperty(D2FP_TITLE, value);
	}

	String^ Window::VisualAttributeGroup::get()
	{
		return GetStringProperty(D2FP_VAT_NAM);
	}

	void Window::VisualAttributeGroup::set(String^ value)
	{
		SetStringProperty(D2FP_VAT_NAM, value);
	}

	String^ Window::VerticalToolbarCanvas::get()
	{
		return GetStringProperty(D2FP_VTB_CNV_NAME);
	}

	void Window::VerticalToolbarCanvas::set(String^ value)
	{
		SetStringProperty(D2FP_VTB_CNV_NAME, value);
	}

	bool Window::WhiteOnBlack::get()
	{
		return GetBooleanProperty(D2FP_WHITE_ON_BLACK);
	}

	void Window::WhiteOnBlack::set(bool value)
	{
		SetBooleanProperty(D2FP_WHITE_ON_BLACK, value);
	}

	long Window::Width::get()
	{
		return GetNumberProperty(D2FP_WIDTH);
	}

	void Window::Width::set(long value)
	{
		SetNumberProperty(D2FP_WIDTH, value);
	}

	Ndapi::WindowStyle Window::WindowStyle::get()
	{
		return GetNumberProperty<Ndapi::WindowStyle>(D2FP_WIN_STY);
	}

	void Window::WindowStyle::set(Ndapi::WindowStyle value)
	{
		SetNumberProperty(D2FP_WIN_STY, value);
	}

	long Window::XPosition::get()
	{
		return GetNumberProperty(D2FP_X_POS);
	}

	void Window::XPosition::set(long value)
	{
		SetNumberProperty(D2FP_X_POS, value);
	}

	long Window::YPosition::get()
	{
		return GetNumberProperty(D2FP_Y_POS);
	}

	void Window::YPosition::set(long value)
	{
		SetNumberProperty(D2FP_Y_POS, value);
	}
}

