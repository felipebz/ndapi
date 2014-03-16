#include "stdafx.h"
#include "RecordGroup.h"

namespace Ndapi
{
	RecordGroup::RecordGroup() : NdapiObject()
	{
	}

	RecordGroup::RecordGroup(d2fob* alert) : NdapiObject(alert)
	{
	}

	RecordGroup::RecordGroup(FormModule^ form, String^ name)
	{
		Create(name, form, D2FFO_REC_GROUP);
	}

	String^ RecordGroup::Comment::get()
	{
		return GetStringProperty(D2FP_COMMENT);
	}

	void RecordGroup::Comment::set(String^ value)
	{
		SetStringProperty(D2FP_COMMENT, value);
	}

	String^ RecordGroup::Name::get()
	{
		return GetStringProperty(D2FP_NAME);
	}

	void RecordGroup::Name::set(String^ value)
	{
		SetStringProperty(D2FP_NAME, value);
	}

	long RecordGroup::FetchSize::get()
	{
		return GetNumberProperty(D2FP_REC_GRP_FETCH_SIZ);
	}

	void RecordGroup::FetchSize::set(long value)
	{
		SetNumberProperty(D2FP_REC_GRP_FETCH_SIZ, value);
	}

	String^ RecordGroup::Query::get()
	{
		return GetStringProperty(D2FP_REC_GRP_QRY);
	}

	void RecordGroup::Query::set(String^ value)
	{
		SetStringProperty(D2FP_REC_GRP_QRY, value);
	}

	RecordGroupType RecordGroup::Type::get()
	{
		return GetNumberProperty<RecordGroupType>(D2FP_REC_GRP_TYP);
	}

	void RecordGroup::Type::set(RecordGroupType value)
	{
		SetNumberProperty(D2FP_REC_GRP_TYP, value);
	}

	NdapiEnumerator<ColumnSpecification^>^ RecordGroup::ColumnSpecifications::get()
	{
		return gcnew NdapiEnumerator<ColumnSpecification^>(_handler, D2FP_COL_SPEC);
	}
}
