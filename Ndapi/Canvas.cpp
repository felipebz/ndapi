#include "stdafx.h"
#include "Canvas.h"

namespace Ndapi
{
	Canvas::Canvas() : NdapiObject()
	{
	}

	Canvas::Canvas(d2fob* alert) : NdapiObject(alert)
	{
	}

	Canvas::Canvas(FormModule^ form, String^ name)
	{
		Create(name, form, D2FFO_CANVAS);
	}

	String^ Canvas::BackgroundColor::get()
	{
		return GetStringProperty(D2FP_BACK_COLOR);
	}

	void Canvas::BackgroundColor::set(String^ value)
	{
		SetStringProperty(D2FP_BACK_COLOR, value);
	}

	Ndapi::Bevel Canvas::Bevel::get()
	{
		return safe_cast<Ndapi::Bevel>(GetNumberProperty(D2FP_BEVEL));
	}

	void Canvas::Bevel::set(Ndapi::Bevel value)
	{
		SetNumberProperty(D2FP_BEVEL, safe_cast<long>(value));
	}

	Ndapi::CanvasType Canvas::CanvasType::get()
	{
		return safe_cast<Ndapi::CanvasType>(GetNumberProperty(D2FP_CNV_TYP));
	}

	void Canvas::CanvasType::set(Ndapi::CanvasType value)
	{
		SetNumberProperty(D2FP_CNV_TYP, safe_cast<long>(value));
	}

	String^ Canvas::Comment::get()
	{
		return GetStringProperty(D2FP_COMMENT);
	}

	void Canvas::Comment::set(String^ value)
	{
		SetStringProperty(D2FP_COMMENT, value);
	}

	String^ Canvas::FillPattern::get()
	{
		return GetStringProperty(D2FP_FILL_PAT);
	}

	void Canvas::FillPattern::set(String^ value)
	{
		SetStringProperty(D2FP_FILL_PAT, value);
	}

	String^ Canvas::FontName::get()
	{
		return GetStringProperty(D2FP_FONT_NAM);
	}

	void Canvas::FontName::set(String^ value)
	{
		SetStringProperty(D2FP_FONT_NAM, value);
	}

	long Canvas::FontSize::get()
	{
		return GetNumberProperty(D2FP_FONT_SIZ);
	}

	void Canvas::FontSize::set(long value)
	{
		SetNumberProperty(D2FP_FONT_SIZ, value);
	}

	Ndapi::FontSpacing Canvas::FontSpacing::get()
	{
		return safe_cast<Ndapi::FontSpacing>(GetNumberProperty(D2FP_FONT_SPCING));
	}

	void Canvas::FontSpacing::set(Ndapi::FontSpacing value)
	{
		SetNumberProperty(D2FP_FONT_SPCING, safe_cast<long>(value));
	}

	Ndapi::FontStyle Canvas::FontStyle::get()
	{
		return safe_cast<Ndapi::FontStyle>(GetNumberProperty(D2FP_FONT_STY));
	}

	void Canvas::FontStyle::set(Ndapi::FontStyle value)
	{
		SetNumberProperty(D2FP_FONT_STY, safe_cast<long>(value));
	}

	Ndapi::FontWeight Canvas::FontWeight::get()
	{
		return safe_cast<Ndapi::FontWeight>(GetNumberProperty(D2FP_FONT_WGHT));
	}

	void Canvas::FontWeight::set(Ndapi::FontWeight value)
	{
		SetNumberProperty(D2FP_FONT_WGHT, safe_cast<long>(value));
	}

	String^ Canvas::ForegroundColor::get()
	{
		return GetStringProperty(D2FP_FORE_COLOR);
	}

	void Canvas::ForegroundColor::set(String^ value)
	{
		SetStringProperty(D2FP_FORE_COLOR, value);
	}

	long Canvas::Height::get()
	{
		return GetNumberProperty(D2FP_HEIGHT);
	}

	void Canvas::Height::set(long value)
	{
		SetNumberProperty(D2FP_HEIGHT, value);
	}

	String^ Canvas::HelpBookTopic::get()
	{
		return GetStringProperty(D2FP_HELP_BOOK_TOPIC);
	}

	void Canvas::HelpBookTopic::set(String^ value)
	{
		SetStringProperty(D2FP_HELP_BOOK_TOPIC, value);
	}

	long Canvas::LanguageDirection::get()
	{
		return GetNumberProperty(D2FP_LANG_DIR);
	}

	void Canvas::LanguageDirection::set(long value)
	{
		SetNumberProperty(D2FP_LANG_DIR, value);
	}

	String^ Canvas::Name::get()
	{
		return GetStringProperty(D2FP_NAME);
	}

	void Canvas::Name::set(String^ value)
	{
		SetStringProperty(D2FP_NAME, value);
	}

	String^ Canvas::PopupMenu::get()
	{
		return GetStringProperty(D2FP_POPUP_MNU_NAM);
	}

	void Canvas::PopupMenu::set(String^ value)
	{
		SetStringProperty(D2FP_POPUP_MNU_NAM, value);
	}

	bool Canvas::RaiseOnEntry::get()
	{
		return GetBooleanProperty(D2FP_RAISE_ON_ENT);
	}

	void Canvas::RaiseOnEntry::set(bool value)
	{
		SetBooleanProperty(D2FP_RAISE_ON_ENT, value);
	}

	Ndapi::TabAttachmentEdge Canvas::TabAttachmentEdge::get()
	{
		return safe_cast<Ndapi::TabAttachmentEdge>(GetNumberProperty(D2FP_TAB_ATT_EDGE));
	}

	void Canvas::TabAttachmentEdge::set(Ndapi::TabAttachmentEdge value)
	{
		SetNumberProperty(D2FP_TAB_ATT_EDGE, safe_cast<long>(value));
	}

	Ndapi::TabStyle Canvas::TabStyle::get()
	{
		return safe_cast<Ndapi::TabStyle>(GetNumberProperty(D2FP_TAB_STY));
	}

	void Canvas::TabStyle::set(Ndapi::TabStyle value)
	{
		SetNumberProperty(D2FP_TAB_STY, safe_cast<long>(value));
	}

	String^ Canvas::VisualAttributeGroup::get()
	{
		return GetStringProperty(D2FP_VAT_NAM);
	}

	void Canvas::VisualAttributeGroup::set(String^ value)
	{
		SetStringProperty(D2FP_VAT_NAM, value);
	}

	bool Canvas::Visible::get()
	{
		return GetBooleanProperty(D2FP_VISIBLE);
	}

	void Canvas::Visible::set(bool value)
	{
		SetBooleanProperty(D2FP_VISIBLE, value);
	}

	long Canvas::ViewportHeight::get()
	{
		return GetNumberProperty(D2FP_VPRT_HGT);
	}

	void Canvas::ViewportHeight::set(long value)
	{
		SetNumberProperty(D2FP_VPRT_HGT, value);
	}

	long Canvas::ViewportWidth::get()
	{
		return GetNumberProperty(D2FP_VPRT_WID);
	}

	void Canvas::ViewportWidth::set(long value)
	{
		SetNumberProperty(D2FP_VPRT_WID, value);
	}

	long Canvas::ViewportXPosition::get()
	{
		return GetNumberProperty(D2FP_VPRT_X_POS);
	}

	void Canvas::ViewportXPosition::set(long value)
	{
		SetNumberProperty(D2FP_VPRT_X_POS, value);
	}

	long Canvas::ViewportXPositionOnCanvas::get()
	{
		return GetNumberProperty(D2FP_VPRT_X_POS_ON_CNV);
	}

	void Canvas::ViewportXPositionOnCanvas::set(long value)
	{
		SetNumberProperty(D2FP_VPRT_X_POS_ON_CNV, value);
	}

	long Canvas::ViewportYPosition::get()
	{
		return GetNumberProperty(D2FP_VPRT_Y_POS);
	}

	void Canvas::ViewportYPosition::set(long value)
	{
		SetNumberProperty(D2FP_VPRT_Y_POS, value);
	}

	long Canvas::ViewportYPositionOnCanvas::get()
	{
		return GetNumberProperty(D2FP_VPRT_Y_POS_ON_CNV);
	}

	void Canvas::ViewportYPositionOnCanvas::set(long value)
	{
		SetNumberProperty(D2FP_VPRT_Y_POS_ON_CNV, value);
	}

	bool Canvas::WhiteOnBlack::get()
	{
		return GetBooleanProperty(D2FP_WHITE_ON_BLACK);
	}

	void Canvas::WhiteOnBlack::set(bool value)
	{
		SetBooleanProperty(D2FP_WHITE_ON_BLACK, value);
	}

	long Canvas::Width::get()
	{
		return GetNumberProperty(D2FP_WIDTH);
	}

	void Canvas::Width::set(long value)
	{
		SetNumberProperty(D2FP_WIDTH, value);
	}

	String^ Canvas::Window::get()
	{
		return GetStringProperty(D2FP_WND_NAM);
	}

	void Canvas::Window::set(String^ value)
	{
		SetStringProperty(D2FP_WND_NAM, value);
	}

	NdapiEnumerator<Graphic^>^ Canvas::Graphics::get()
	{
		return gcnew NdapiEnumerator<Graphic^>(_handler, D2FP_GRAPHIC);
	}

	NdapiEnumerator<NdapiObject^>^ Canvas::TabPage::get()
	{
		return gcnew NdapiEnumerator<NdapiObject^>(_handler, D2FP_TAB_PAGE);
	}
}

