#include "stdafx.h"
#include "ColumnMapping.h"

namespace Ndapi
{
	ColumnMapping::ColumnMapping() : NdapiObject()
	{
	}

	ColumnMapping::ColumnMapping(d2fob* alert) : NdapiObject(alert)
	{
	}

	ColumnMapping::ColumnMapping(FormModule^ form, String^ name)
	{
		Create(name, form, D2FFO_LV_COLMAP);
	}

	long ColumnMapping::DisplayWidth::get()
	{
		return GetNumberProperty(D2FP_DISP_WID);
	}

	void ColumnMapping::DisplayWidth::set(long value)
	{
		SetNumberProperty(D2FP_DISP_WID, value);
	}

	String^ ColumnMapping::ReturnItem::get()
	{
		return GetStringProperty(D2FP_RTRN_ITM);
	}

	void ColumnMapping::ReturnItem::set(String^ value)
	{
		SetStringProperty(D2FP_RTRN_ITM, value);
	}

	String^ ColumnMapping::Title::get()
	{
		return GetStringProperty(D2FP_TITLE);
	}

	void ColumnMapping::Title::set(String^ value)
	{
		SetStringProperty(D2FP_TITLE, value);
	}
}
