#include "stdafx.h"
#include "Graphic.h"

namespace Ndapi
{
	Graphic::Graphic() : NdapiObject()
	{
	}

	Graphic::Graphic(d2fob* alert) : NdapiObject(alert)
	{
	}

	Graphic::Graphic(FormModule^ form, String^ name)
	{
		Create(name, form, D2FFO_GRAPHIC);
	}

	bool Graphic::AllowExpansion::get()
	{
		return GetBooleanProperty(D2FP_ALLOW_EXPANSION);
	}

	void Graphic::AllowExpansion::set(bool value)
	{
		SetBooleanProperty(D2FP_ALLOW_EXPANSION, value);
	}

	bool Graphic::AllowMultilinePrompts::get()
	{
		return GetBooleanProperty(D2FP_ALLOW_MLT_LIN_PRMPTS);
	}

	void Graphic::AllowMultilinePrompts::set(bool value)
	{
		SetBooleanProperty(D2FP_ALLOW_MLT_LIN_PRMPTS, value);
	}

	bool Graphic::AllowStartAttachedPrompts::get()
	{
		return GetBooleanProperty(D2FP_ALLOW_STRT_ATT_PRMPTS);
	}

	void Graphic::AllowStartAttachedPrompts::set(bool value)
	{
		SetBooleanProperty(D2FP_ALLOW_STRT_ATT_PRMPTS, value);
	}

	bool Graphic::AllowTopAttachedPrompts::get()
	{
		return GetBooleanProperty(D2FP_ALLOW_TOP_ATT_PRMPTS);
	}

	void Graphic::AllowTopAttachedPrompts::set(bool value)
	{
		SetBooleanProperty(D2FP_ALLOW_TOP_ATT_PRMPTS, value);
	}

	Ndapi::LineArrowStyle Graphic::LineArrowStyle::get()
	{
		return GetNumberProperty<Ndapi::LineArrowStyle>(D2FP_ARROW_STY);
	}

	void Graphic::LineArrowStyle::set(Ndapi::LineArrowStyle value)
	{
		SetNumberProperty(D2FP_ARROW_STY, value);
	}

	String^ Graphic::BackgroundColor::get()
	{
		return GetStringProperty(D2FP_BACK_COLOR);
	}

	void Graphic::BackgroundColor::set(String^ value)
	{
		SetStringProperty(D2FP_BACK_COLOR, value);
	}

	Ndapi::Bevel Graphic::Bevel::get()
	{
		return GetNumberProperty<Ndapi::Bevel>(D2FP_BEVEL);
	}

	void Graphic::Bevel::set(Ndapi::Bevel value)
	{
		SetNumberProperty(D2FP_BEVEL, value);
	}

	Ndapi::ObjectEdgeCapStyle Graphic::ObjectEdgeCapStyle::get()
	{
		return GetNumberProperty<Ndapi::ObjectEdgeCapStyle>(D2FP_CAP_STY);
	}

	void Graphic::ObjectEdgeCapStyle::set(Ndapi::ObjectEdgeCapStyle value)
	{
		SetNumberProperty(D2FP_CAP_STY, value);
	}

	long Graphic::ClippingHeight::get()
	{
		return GetNumberProperty(D2FP_CLIP_HGT);
	}

	void Graphic::ClippingHeight::set(long value)
	{
		SetNumberProperty(D2FP_CLIP_HGT, value);
	}

	long Graphic::ClippingWidth::get()
	{
		return GetNumberProperty(D2FP_CLIP_WID);
	}

	void Graphic::ClippingWidth::set(long value)
	{
		SetNumberProperty(D2FP_CLIP_WID, value);
	}

	long Graphic::ClippingXOrigin::get()
	{
		return GetNumberProperty(D2FP_CLIP_X_POS);
	}

	void Graphic::ClippingXOrigin::set(long value)
	{
		SetNumberProperty(D2FP_CLIP_X_POS, value);
	}

	long Graphic::ClippingYOrigin::get()
	{
		return GetNumberProperty(D2FP_CLIP_Y_POS);
	}

	void Graphic::ClippingYOrigin::set(long value)
	{
		SetNumberProperty(D2FP_CLIP_Y_POS, value);
	}

	bool Graphic::Closed::get()
	{
		return GetBooleanProperty(D2FP_CLOSED);
	}

	void Graphic::Closed::set(bool value)
	{
		SetBooleanProperty(D2FP_CLOSED, value);
	}

	long Graphic::XCornerRadius::get()
	{
		return GetNumberProperty(D2FP_CORNER_RADIUS_X);
	}

	void Graphic::XCornerRadius::set(long value)
	{
		SetNumberProperty(D2FP_CORNER_RADIUS_X, value);
	}

	long Graphic::YCornerRadius::get()
	{
		return GetNumberProperty(D2FP_CORNER_RADIUS_Y);
	}

	void Graphic::YCornerRadius::set(long value)
	{
		SetNumberProperty(D2FP_CORNER_RADIUS_Y, value);
	}

	long Graphic::CustomSpacing::get()
	{
		return GetNumberProperty(D2FP_CSTM_SPCING);
	}

	void Graphic::CustomSpacing::set(long value)
	{
		SetNumberProperty(D2FP_CSTM_SPCING, value);
	}

	Ndapi::DashStyle Graphic::DashStyle::get()
	{
		return GetNumberProperty<Ndapi::DashStyle>(D2FP_DASH_STY);
	}

	void Graphic::DashStyle::set(Ndapi::DashStyle value)
	{
		SetNumberProperty(D2FP_DASH_STY, value);
	}

	Ndapi::DisplayQuality Graphic::DisplayQuality::get()
	{
		return GetNumberProperty<Ndapi::DisplayQuality>(D2FP_DISP_QLTY);
	}

	void Graphic::DisplayQuality::set(Ndapi::DisplayQuality value)
	{
		SetNumberProperty(D2FP_DISP_QLTY, value);
	}

	long Graphic::DistanceBetweenRecords::get()
	{
		return GetNumberProperty(D2FP_DIST_BTWN_RECS);
	}

	void Graphic::DistanceBetweenRecords::set(long value)
	{
		SetNumberProperty(D2FP_DIST_BTWN_RECS, value);
	}

	bool Graphic::GraphicsDithersImage::get()
	{
		return GetBooleanProperty(D2FP_DITHER);
	}

	void Graphic::GraphicsDithersImage::set(bool value)
	{
		SetBooleanProperty(D2FP_DITHER, value);
	}

	String^ Graphic::EdgeBackgroundColor::get()
	{
		return GetStringProperty(D2FP_EDGE_BACK_COLOR);
	}

	void Graphic::EdgeBackgroundColor::set(String^ value)
	{
		SetStringProperty(D2FP_EDGE_BACK_COLOR, value);
	}

	String^ Graphic::EdgeForegroundColor::get()
	{
		return GetStringProperty(D2FP_EDGE_FORE_COLOR);
	}

	void Graphic::EdgeForegroundColor::set(String^ value)
	{
		SetStringProperty(D2FP_EDGE_FORE_COLOR, value);
	}

	String^ Graphic::FillPattern::get()
	{
		return GetStringProperty(D2FP_FILL_PAT);
	}

	void Graphic::FillPattern::set(String^ value)
	{
		SetStringProperty(D2FP_FILL_PAT, value);
	}

	bool Graphic::FixedSizeForBoundingBox::get()
	{
		return GetBooleanProperty(D2FP_FIXED_BOUNDING_BX);
	}

	void Graphic::FixedSizeForBoundingBox::set(bool value)
	{
		SetBooleanProperty(D2FP_FIXED_BOUNDING_BX, value);
	}

	bool Graphic::PointSizeScalable::get()
	{
		return GetBooleanProperty(D2FP_FONT_SCALEABLE);
	}

	void Graphic::PointSizeScalable::set(bool value)
	{
		SetBooleanProperty(D2FP_FONT_SCALEABLE, value);
	}

	String^ Graphic::ForegroundColor::get()
	{
		return GetStringProperty(D2FP_FORE_COLOR);
	}

	void Graphic::ForegroundColor::set(String^ value)
	{
		SetStringProperty(D2FP_FORE_COLOR, value);
	}

	Ndapi::FrameAlignment Graphic::FrameAlignment::get()
	{
		return GetNumberProperty<Ndapi::FrameAlignment>(D2FP_FRAME_ALIGN);
	}

	void Graphic::FrameAlignment::set(Ndapi::FrameAlignment value)
	{
		SetNumberProperty(D2FP_FRAME_ALIGN, value);
	}

	String^ Graphic::FrameTitle::get()
	{
		return GetStringProperty(D2FP_FRAME_TTL);
	}

	void Graphic::FrameTitle::set(String^ value)
	{
		SetStringProperty(D2FP_FRAME_TTL, value);
	}

	Ndapi::FrameTitleAlignment Graphic::FrameTitleAlignment::get()
	{
		return GetNumberProperty<Ndapi::FrameTitleAlignment>(D2FP_FRAME_TTL_ALIGN);
	}

	void Graphic::FrameTitleAlignment::set(Ndapi::FrameTitleAlignment value)
	{
		SetNumberProperty(D2FP_FRAME_TTL_ALIGN, value);
	}

	String^ Graphic::FrameTitleBackgroundColor::get()
	{
		return GetStringProperty(D2FP_FRAME_TTL_BACK_COLOR);
	}

	void Graphic::FrameTitleBackgroundColor::set(String^ value)
	{
		SetStringProperty(D2FP_FRAME_TTL_BACK_COLOR, value);
	}

	String^ Graphic::FrameTitleFillPattern::get()
	{
		return GetStringProperty(D2FP_FRAME_TTL_FILL_PAT);
	}

	void Graphic::FrameTitleFillPattern::set(String^ value)
	{
		SetStringProperty(D2FP_FRAME_TTL_FILL_PAT, value);
	}

	String^ Graphic::FrameTitleFontName::get()
	{
		return GetStringProperty(D2FP_FRAME_TTL_FONT_NAM);
	}

	void Graphic::FrameTitleFontName::set(String^ value)
	{
		SetStringProperty(D2FP_FRAME_TTL_FONT_NAM, value);
	}

	long Graphic::FrameTitleFontSize::get()
	{
		return GetNumberProperty(D2FP_FRAME_TTL_FONT_SIZ);
	}

	void Graphic::FrameTitleFontSize::set(long value)
	{
		SetNumberProperty(D2FP_FRAME_TTL_FONT_SIZ, value);
	}

	Ndapi::FontSpacing Graphic::FrameTitleFontSpacing::get()
	{
		return GetNumberProperty<Ndapi::FontSpacing>(D2FP_FRAME_TTL_FONT_SPCING);
	}

	void Graphic::FrameTitleFontSpacing::set(Ndapi::FontSpacing value)
	{
		SetNumberProperty(D2FP_FRAME_TTL_FONT_SPCING, value);
	}

	Ndapi::FontStyle Graphic::FrameTitleFontStyle::get()
	{
		return GetNumberProperty<Ndapi::FontStyle>(D2FP_FRAME_TTL_FONT_STY);
	}

	void Graphic::FrameTitleFontStyle::set(Ndapi::FontStyle value)
	{
		SetNumberProperty(D2FP_FRAME_TTL_FONT_STY, value);
	}

	Ndapi::FontWeight Graphic::FrameTitleFontWeight::get()
	{
		return GetNumberProperty<Ndapi::FontWeight>(D2FP_FRAME_TTL_FONT_WGHT);
	}

	void Graphic::FrameTitleFontWeight::set(Ndapi::FontWeight value)
	{
		SetNumberProperty(D2FP_FRAME_TTL_FONT_WGHT, value);
	}

	String^ Graphic::FrameTitleForegroundColor::get()
	{
		return GetStringProperty(D2FP_FRAME_TTL_FORE_COLOR);
	}

	void Graphic::FrameTitleForegroundColor::set(String^ value)
	{
		SetStringProperty(D2FP_FRAME_TTL_FORE_COLOR, value);
	}

	long Graphic::FrameTitleOffset::get()
	{
		return GetNumberProperty(D2FP_FRAME_TTL_OFST);
	}

	void Graphic::FrameTitleOffset::set(long value)
	{
		SetNumberProperty(D2FP_FRAME_TTL_OFST, value);
	}

	long Graphic::FrameTitleSpacing::get()
	{
		return GetNumberProperty(D2FP_FRAME_TTL_SPCING);
	}

	void Graphic::FrameTitleSpacing::set(long value)
	{
		SetNumberProperty(D2FP_FRAME_TTL_SPCING, value);
	}

	String^ Graphic::FrameTitleVisualAttributeGroup::get()
	{
		return GetStringProperty(D2FP_FRAME_TTL_VAT_NAM);
	}

	void Graphic::FrameTitleVisualAttributeGroup::set(String^ value)
	{
		SetStringProperty(D2FP_FRAME_TTL_VAT_NAM, value);
	}

	Ndapi::GraphicsObjectType Graphic::GraphicsObjectType::get()
	{
		return GetNumberProperty<Ndapi::GraphicsObjectType>(D2FP_GRAPHICS_TYP);
	}

	void Graphic::GraphicsObjectType::set(Ndapi::GraphicsObjectType value)
	{
		SetNumberProperty(D2FP_GRAPHICS_TYP, value);
	}

	String^ Graphic::GraphicsFontColor::get()
	{
		return GetStringProperty(D2FP_GRA_FONT_COLOR);
	}

	void Graphic::GraphicsFontColor::set(String^ value)
	{
		SetStringProperty(D2FP_GRA_FONT_COLOR, value);
	}

	String^ Graphic::GraphicsFontName::get()
	{
		return GetStringProperty(D2FP_GRA_FONT_NAM);
	}

	void Graphic::GraphicsFontName::set(String^ value)
	{
		SetStringProperty(D2FP_GRA_FONT_NAM, value);
	}

	long Graphic::GraphicsFontSize::get()
	{
		return GetNumberProperty(D2FP_GRA_FONT_SIZ);
	}

	void Graphic::GraphicsFontSize::set(long value)
	{
		SetNumberProperty(D2FP_GRA_FONT_SIZ, value);
	}

	Ndapi::FontSpacing Graphic::GraphicsFontSpacing::get()
	{
		return GetNumberProperty<Ndapi::FontSpacing>(D2FP_GRA_FONT_SPCING);
	}

	void Graphic::GraphicsFontSpacing::set(Ndapi::FontSpacing value)
	{
		SetNumberProperty(D2FP_GRA_FONT_SPCING, value);
	}

	Ndapi::FontStyle Graphic::GraphicsFontStyle::get()
	{
		return GetNumberProperty<Ndapi::FontStyle>(D2FP_GRA_FONT_STY);
	}

	void Graphic::GraphicsFontStyle::set(Ndapi::FontStyle value)
	{
		SetNumberProperty(D2FP_GRA_FONT_STY, value);
	}

	Ndapi::FontWeight Graphic::GraphicsFontWeight::get()
	{
		return GetNumberProperty<Ndapi::FontWeight>(D2FP_GRA_FONT_WGHT);
	}

	void Graphic::GraphicsFontWeight::set(Ndapi::FontWeight value)
	{
		SetNumberProperty(D2FP_GRA_FONT_WGHT, value);
	}

	String^ Graphic::GraphicsText::get()
	{
		return GetStringProperty(D2FP_GRA_TEXT);
	}

	void Graphic::GraphicsText::set(String^ value)
	{
		SetStringProperty(D2FP_GRA_TEXT, value);
	}

	long Graphic::Height::get()
	{
		return GetNumberProperty(D2FP_HEIGHT);
	}

	void Graphic::Height::set(long value)
	{
		SetNumberProperty(D2FP_HEIGHT, value);
	}

	Ndapi::HorizontalJustification Graphic::HorizontalJustification::get()
	{
		return GetNumberProperty<Ndapi::HorizontalJustification>(D2FP_HORZ_JST);
	}

	void Graphic::HorizontalJustification::set(Ndapi::HorizontalJustification value)
	{
		SetNumberProperty(D2FP_HORZ_JST, value);
	}

	long Graphic::HorizontalMargin::get()
	{
		return GetNumberProperty(D2FP_HORZ_MARGN);
	}

	void Graphic::HorizontalMargin::set(long value)
	{
		SetNumberProperty(D2FP_HORZ_MARGN, value);
	}

	long Graphic::HorizontalObjectOffset::get()
	{
		return GetNumberProperty(D2FP_HORZ_OBJ_OFST);
	}

	void Graphic::HorizontalObjectOffset::set(long value)
	{
		SetNumberProperty(D2FP_HORZ_OBJ_OFST, value);
	}

	long Graphic::HorizontalPositionRelativeToOrigin::get()
	{
		return GetNumberProperty(D2FP_HORZ_ORGN);
	}

	void Graphic::HorizontalPositionRelativeToOrigin::set(long value)
	{
		SetNumberProperty(D2FP_HORZ_ORGN, value);
	}

	Ndapi::JoinStyle Graphic::JoinStyle::get()
	{
		return GetNumberProperty<Ndapi::JoinStyle>(D2FP_JOIN_STY);
	}

	void Graphic::JoinStyle::set(Ndapi::JoinStyle value)
	{
		SetNumberProperty(D2FP_JOIN_STY, value);
	}

	Ndapi::LanguageDirection Graphic::LanguageDirection::get()
	{
		return GetNumberProperty<Ndapi::LanguageDirection>(D2FP_LANG_DIR);
	}

	void Graphic::LanguageDirection::set(Ndapi::LanguageDirection value)
	{
		SetNumberProperty(D2FP_LANG_DIR, value);
	}

	String^ Graphic::LayoutDataBlock::get()
	{
		return GetStringProperty(D2FP_LAYOUT_DATA_BLK_NAM);
	}

	void Graphic::LayoutDataBlock::set(String^ value)
	{
		SetStringProperty(D2FP_LAYOUT_DATA_BLK_NAM, value);
	}

	Ndapi::LayoutStyle Graphic::LayoutStyle::get()
	{
		return GetNumberProperty<Ndapi::LayoutStyle>(D2FP_LAYOUT_STY);
	}

	void Graphic::LayoutStyle::set(Ndapi::LayoutStyle value)
	{
		SetNumberProperty(D2FP_LAYOUT_STY, value);
	}

	Ndapi::LineSpacing Graphic::LineSpacing::get()
	{
		return GetNumberProperty<Ndapi::LineSpacing>(D2FP_LIN_SPCING);
	}

	void Graphic::LineSpacing::set(Ndapi::LineSpacing value)
	{
		SetNumberProperty(D2FP_LIN_SPCING, value);
	}

	long Graphic::MaximumObjectsPerLine::get()
	{
		return GetNumberProperty(D2FP_MAX_OBJS);
	}

	void Graphic::MaximumObjectsPerLine::set(long value)
	{
		SetNumberProperty(D2FP_MAX_OBJS, value);
	}

	String^ Graphic::Name::get()
	{
		return GetStringProperty(D2FP_NAME);
	}

	void Graphic::Name::set(String^ value)
	{
		SetStringProperty(D2FP_NAME, value);
	}

	NdapiObject^ Graphic::FontPointSize::get()
	{
		return GetObjectProperty<NdapiObject^>(D2FP_POINT);
	}

	long Graphic::NumberOfRecordsDisplayed::get()
	{
		return GetNumberProperty(D2FP_RECS_DISP_COUNT);
	}

	void Graphic::NumberOfRecordsDisplayed::set(long value)
	{
		SetNumberProperty(D2FP_RECS_DISP_COUNT, value);
	}

	Ndapi::ScrollBarAlignment Graphic::ScrollBarAlignment::get()
	{
		return GetNumberProperty<Ndapi::ScrollBarAlignment>(D2FP_SCRLBR_ALIGN);
	}

	void Graphic::ScrollBarAlignment::set(Ndapi::ScrollBarAlignment value)
	{
		SetNumberProperty(D2FP_SCRLBR_ALIGN, value);
	}

	long Graphic::ScrollBarWidth::get()
	{
		return GetNumberProperty(D2FP_SCRLBR_WID);
	}

	void Graphic::ScrollBarWidth::set(long value)
	{
		SetNumberProperty(D2FP_SCRLBR_WID, value);
	}

	bool Graphic::ShowScrollBar::get()
	{
		return GetBooleanProperty(D2FP_SHOW_SCRLBR);
	}

	void Graphic::ShowScrollBar::set(bool value)
	{
		SetBooleanProperty(D2FP_SHOW_SCRLBR, value);
	}

	bool Graphic::Shrinkwrap::get()
	{
		return GetBooleanProperty(D2FP_SHRINKWRAP);
	}

	void Graphic::Shrinkwrap::set(bool value)
	{
		SetBooleanProperty(D2FP_SHRINKWRAP, value);
	}

	Alignment Graphic::SingleObjectAlignment::get()
	{
		return GetNumberProperty<Alignment>(D2FP_SNGL_OBJ_ALIGN);
	}

	void Graphic::SingleObjectAlignment::set(Alignment value)
	{
		SetNumberProperty(D2FP_SNGL_OBJ_ALIGN, value);
	}

	Alignment Graphic::StartPromptAlignment::get()
	{
		return GetNumberProperty<Alignment>(D2FP_STRT_PRMPT_ALIGN);
	}

	void Graphic::StartPromptAlignment::set(Alignment value)
	{
		SetNumberProperty(D2FP_STRT_PRMPT_ALIGN, value);
	}

	long Graphic::StartPromptOffset::get()
	{
		return GetNumberProperty(D2FP_STRT_PRMPT_OFST);
	}

	void Graphic::StartPromptOffset::set(long value)
	{
		SetNumberProperty(D2FP_STRT_PRMPT_OFST, value);
	}

	Alignment Graphic::TopPromptAlignment::get()
	{
		return GetNumberProperty<Alignment>(D2FP_TOP_PRMPT_ALIGN);
	}

	void Graphic::TopPromptAlignment::set(Alignment value)
	{
		SetNumberProperty(D2FP_TOP_PRMPT_ALIGN, value);
	}

	long Graphic::TopPromptOffset::get()
	{
		return GetNumberProperty(D2FP_TOP_PRMPT_OFST);
	}

	void Graphic::TopPromptOffset::set(long value)
	{
		SetNumberProperty(D2FP_TOP_PRMPT_OFST, value);
	}

	ReadingOrder Graphic::TitleReadingOrder::get()
	{
		return GetNumberProperty<ReadingOrder>(D2FP_TTL_READING_ORDR);
	}

	void Graphic::TitleReadingOrder::set(ReadingOrder value)
	{
		SetNumberProperty(D2FP_TTL_READING_ORDR, value);
	}

	Ndapi::UpdateLayout Graphic::UpdateLayout::get()
	{
		return GetNumberProperty<Ndapi::UpdateLayout>(D2FP_UPDT_LAYOUT);
	}

	void Graphic::UpdateLayout::set(Ndapi::UpdateLayout value)
	{
		SetNumberProperty(D2FP_UPDT_LAYOUT, value);
	}

	String^ Graphic::VisualAttributeGroup::get()
	{
		return GetStringProperty(D2FP_VAT_NAM);
	}

	void Graphic::VisualAttributeGroup::set(String^ value)
	{
		SetStringProperty(D2FP_VAT_NAM, value);
	}

	bool Graphic::VerticalFill::get()
	{
		return GetBooleanProperty(D2FP_VERT_FILL);
	}

	void Graphic::VerticalFill::set(bool value)
	{
		SetBooleanProperty(D2FP_VERT_FILL, value);
	}

	Ndapi::VerticalJustification Graphic::VerticalJustification::get()
	{
		return GetNumberProperty<Ndapi::VerticalJustification>(D2FP_VERT_JST);
	}

	void Graphic::VerticalJustification::set(Ndapi::VerticalJustification value)
	{
		SetNumberProperty(D2FP_VERT_JST, value);
	}

	long Graphic::VerticalMargin::get()
	{
		return GetNumberProperty(D2FP_VERT_MARGN);
	}

	void Graphic::VerticalMargin::set(long value)
	{
		SetNumberProperty(D2FP_VERT_MARGN, value);
	}

	long Graphic::VerticalObjectOffset::get()
	{
		return GetNumberProperty(D2FP_VERT_OBJ_OFST);
	}

	void Graphic::VerticalObjectOffset::set(long value)
	{
		SetNumberProperty(D2FP_VERT_OBJ_OFST, value);
	}

	long Graphic::VerticalPositionRelativeToOrigin::get()
	{
		return GetNumberProperty(D2FP_VERT_ORGN);
	}

	void Graphic::VerticalPositionRelativeToOrigin::set(long value)
	{
		SetNumberProperty(D2FP_VERT_ORGN, value);
	}

	long Graphic::Width::get()
	{
		return GetNumberProperty(D2FP_WIDTH);
	}

	void Graphic::Width::set(long value)
	{
		SetNumberProperty(D2FP_WIDTH, value);
	}

	bool Graphic::WrapText::get()
	{
		return GetBooleanProperty(D2FP_WRAP_TXT);
	}

	void Graphic::WrapText::set(bool value)
	{
		SetBooleanProperty(D2FP_WRAP_TXT, value);
	}

	long Graphic::XPosition::get()
	{
		return GetNumberProperty(D2FP_X_POS);
	}

	void Graphic::XPosition::set(long value)
	{
		SetNumberProperty(D2FP_X_POS, value);
	}

	long Graphic::YPosition::get()
	{
		return GetNumberProperty(D2FP_Y_POS);
	}

	void Graphic::YPosition::set(long value)
	{
		SetNumberProperty(D2FP_Y_POS, value);
	}

	NdapiEnumerator<Graphic^>^ Graphic::Graphics::get()
	{
		return gcnew NdapiEnumerator<Graphic^>(_handler, D2FP_GRAPHIC);
	}
}
