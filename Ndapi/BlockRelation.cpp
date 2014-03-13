#include "stdafx.h"
#include "BlockRelation.h"

namespace Ndapi
{
	BlockRelation::BlockRelation() : NdapiObject()
	{
	}

	BlockRelation::BlockRelation(d2fob* alert) : NdapiObject(alert)
	{
	}

	BlockRelation::BlockRelation(FormModule^ form, String^ name)
	{
		Create(name, form, D2FFO_RELATION);
	}

	bool BlockRelation::AutomaticQuery::get()
	{
		return GetBooleanProperty(D2FP_AUTO_QRY);
	}

	void BlockRelation::AutomaticQuery::set(bool value)
	{
		SetBooleanProperty(D2FP_AUTO_QRY, value);
	}

	String^ BlockRelation::Comment::get()
	{
		return GetStringProperty(D2FP_COMMENT);
	}

	void BlockRelation::Comment::set(String^ value)
	{
		SetStringProperty(D2FP_COMMENT, value);
	}

	bool BlockRelation::Deferred::get()
	{
		return GetBooleanProperty(D2FP_DEFERRED);
	}

	void BlockRelation::Deferred::set(bool value)
	{
		SetBooleanProperty(D2FP_DEFERRED, value);
	}

	Ndapi::DeleteRecordBehavior BlockRelation::DeleteRecordBehavior::get()
	{
		return safe_cast<Ndapi::DeleteRecordBehavior>(GetNumberProperty(D2FP_DEL_REC));
	}

	void BlockRelation::DeleteRecordBehavior::set(Ndapi::DeleteRecordBehavior value)
	{
		SetNumberProperty(D2FP_DEL_REC, safe_cast<long>(value));
	}

	String^ BlockRelation::DetailBlock::get()
	{
		return GetStringProperty(D2FP_DETAIL_BLK);
	}

	void BlockRelation::DetailBlock::set(String^ value)
	{
		SetStringProperty(D2FP_DETAIL_BLK, value);
	}

	String^ BlockRelation::JoinCondition::get()
	{
		return GetStringProperty(D2FP_JOIN_COND);
	}

	void BlockRelation::JoinCondition::set(String^ value)
	{
		SetStringProperty(D2FP_JOIN_COND, value);
	}

	String^ BlockRelation::Name::get()
	{
		return GetStringProperty(D2FP_NAME);
	}

	void BlockRelation::Name::set(String^ value)
	{
		SetStringProperty(D2FP_NAME, value);
	}

	bool BlockRelation::PreventMasterlessOperations::get()
	{
		return GetBooleanProperty(D2FP_PRVNT_MSTRLESS_OPS);
	}

	void BlockRelation::PreventMasterlessOperations::set(bool value)
	{
		SetBooleanProperty(D2FP_PRVNT_MSTRLESS_OPS, value);
	}
}