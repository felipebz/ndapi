#include "stdafx.h"
#include "Block.h"

namespace Ndapi
{
	Block::Block() : NdapiObject()
	{
	}

	Block::Block(d2fob* alert) : NdapiObject(alert)
	{
	}

	Block::Block(FormModule^ form, String^ name)
	{
		Create(name, form, D2FFO_BLOCK);
	}

	String^ Block::BackgroundColor::get()
	{
		return GetStringProperty(D2FP_BACK_COLOR);
	}

	void Block::BackgroundColor::set(String^ value)
	{
		SetStringProperty(D2FP_BACK_COLOR, value);
	}

	String^ Block::Description::get()
	{
		return GetStringProperty(D2FP_BLK_DESCRIPTION);
	}

	void Block::Description::set(String^ value)
	{
		SetStringProperty(D2FP_BLK_DESCRIPTION, value);
	}

	String^ Block::Comment::get()
	{
		return GetStringProperty(D2FP_COMMENT);
	}

	void Block::Comment::set(String^ value)
	{
		SetStringProperty(D2FP_COMMENT, value);
	}

	bool Block::DeleteAllowed::get()
	{
		return GetBooleanProperty(D2FP_DEL_ALLOWED);
	}

	void Block::DeleteAllowed::set(bool value)
	{
		SetBooleanProperty(D2FP_DEL_ALLOWED, value);
	}

	String^ Block::DeleteProcedureName::get()
	{
		return GetStringProperty(D2FP_DEL_PROC_NAM);
	}

	void Block::DeleteProcedureName::set(String^ value)
	{
		SetStringProperty(D2FP_DEL_PROC_NAM, value);
	}

	long Block::DMLArraySize::get()
	{
		return GetNumberProperty(D2FP_DML_ARY_SIZ);
	}

	void Block::DMLArraySize::set(long value)
	{
		SetNumberProperty(D2FP_DML_ARY_SIZ, value);
	}

	String^ Block::DMLDataTargetName::get()
	{
		return GetStringProperty(D2FP_DML_DAT_NAM);
	}

	void Block::DMLDataTargetName::set(String^ value)
	{
		SetStringProperty(D2FP_DML_DAT_NAM, value);
	}

	Ndapi::DMLDataTargetType Block::DMLDataTargetType::get()
	{
		return safe_cast<Ndapi::DMLDataTargetType>(GetNumberProperty(D2FP_DML_DAT_TYP));
	}

	void Block::DMLDataTargetType::set(Ndapi::DMLDataTargetType value)
	{
		SetNumberProperty(D2FP_DML_DAT_TYP, safe_cast<long>(value));
	}

	bool Block::EnforceColumnSecurity::get()
	{
		return GetBooleanProperty(D2FP_ENFRC_COL_SECURITY);
	}

	void Block::EnforceColumnSecurity::set(bool value)
	{
		SetBooleanProperty(D2FP_ENFRC_COL_SECURITY, value);
	}

	bool Block::EnforcePrimaryKey::get()
	{
		return GetBooleanProperty(D2FP_ENFRC_PRMRY_KEY);
	}

	void Block::EnforcePrimaryKey::set(bool value)
	{
		SetBooleanProperty(D2FP_ENFRC_PRMRY_KEY, value);
	}

	String^ Block::FillPattern::get()
	{
		return GetStringProperty(D2FP_FILL_PAT);
	}

	void Block::FillPattern::set(String^ value)
	{
		SetStringProperty(D2FP_FILL_PAT, value);
	}

	String^ Block::FontName::get()
	{
		return GetStringProperty(D2FP_FONT_NAM);
	}

	void Block::FontName::set(String^ value)
	{
		SetStringProperty(D2FP_FONT_NAM, value);
	}

	long Block::FontSize::get()
	{
		return GetNumberProperty(D2FP_FONT_SIZ);
	}

	void Block::FontSize::set(long value)
	{
		SetNumberProperty(D2FP_FONT_SIZ, value);
	}

	Ndapi::FontSpacing Block::FontSpacing::get()
	{
		return safe_cast<Ndapi::FontSpacing>(GetNumberProperty(D2FP_FONT_SPCING));
	}

	void Block::FontSpacing::set(Ndapi::FontSpacing value)
	{
		SetNumberProperty(D2FP_FONT_SPCING, safe_cast<long>(value));
	}

	Ndapi::FontStyle Block::FontStyle::get()
	{
		return safe_cast<Ndapi::FontStyle>(GetNumberProperty(D2FP_FONT_STY));
	}

	void Block::FontStyle::set(Ndapi::FontStyle value)
	{
		SetNumberProperty(D2FP_FONT_STY, safe_cast<long>(value));
	}

	Ndapi::FontWeight Block::FontWeight::get()
	{
		return safe_cast<Ndapi::FontWeight>(GetNumberProperty(D2FP_FONT_WGHT));
	}

	void Block::FontWeight::set(Ndapi::FontWeight value)
	{
		SetNumberProperty(D2FP_FONT_WGHT, safe_cast<long>(value));
	}

	String^ Block::ForegroundColor::get()
	{
		return GetStringProperty(D2FP_FORE_COLOR);
	}

	void Block::ForegroundColor::set(String^ value)
	{
		SetStringProperty(D2FP_FORE_COLOR, value);
	}

	bool Block::InsertAllowed::get()
	{
		return GetBooleanProperty(D2FP_INSRT_ALLOWED);
	}

	void Block::InsertAllowed::set(bool value)
	{
		SetBooleanProperty(D2FP_INSRT_ALLOWED, value);
	}

	String^ Block::InsertProcedureName::get()
	{
		return GetStringProperty(D2FP_INSRT_PROC_NAM);
	}

	void Block::InsertProcedureName::set(String^ value)
	{
		SetStringProperty(D2FP_INSRT_PROC_NAM, value);
	}

	Ndapi::KeyMode Block::KeyMode::get()
	{
		return safe_cast<Ndapi::KeyMode>(GetNumberProperty(D2FP_KEY_MODE));
	}

	void Block::KeyMode::set(Ndapi::KeyMode value)
	{
		SetNumberProperty(D2FP_KEY_MODE, safe_cast<long>(value));
	}

	Ndapi::LanguageDirection Block::LanguageDirection::get()
	{
		return safe_cast<Ndapi::LanguageDirection>(GetNumberProperty(D2FP_LANG_DIR));
	}

	void Block::LanguageDirection::set(Ndapi::LanguageDirection value)
	{
		SetNumberProperty(D2FP_LANG_DIR, safe_cast<long>(value));
	}

	Ndapi::LockingMode Block::LockingMode::get()
	{
		return safe_cast<Ndapi::LockingMode>(GetNumberProperty(D2FP_LOCK_MODE));
	}

	void Block::LockingMode::set(Ndapi::LockingMode value)
	{
		SetNumberProperty(D2FP_LOCK_MODE, safe_cast<long>(value));
	}

	String^ Block::LockProcedureName::get()
	{
		return GetStringProperty(D2FP_LOCK_PROC_NAM);
	}

	void Block::LockProcedureName::set(String^ value)
	{
		SetStringProperty(D2FP_LOCK_PROC_NAM, value);
	}

	bool Block::ListedInBlockMenu::get()
	{
		return GetBooleanProperty(D2FP_LST_IN_BLK_MNU);
	}

	void Block::ListedInBlockMenu::set(bool value)
	{
		SetBooleanProperty(D2FP_LST_IN_BLK_MNU, value);
	}

	long Block::MaximumQueryTime::get()
	{
		return GetNumberProperty(D2FP_MAX_QRY_TIME);
	}

	void Block::MaximumQueryTime::set(long value)
	{
		SetNumberProperty(D2FP_MAX_QRY_TIME, value);
	}

	long Block::MaxRecordsFetched::get()
	{
		return GetNumberProperty(D2FP_MAX_RECS_FETCHED);
	}

	void Block::MaxRecordsFetched::set(long value)
	{
		SetNumberProperty(D2FP_MAX_RECS_FETCHED, value);
	}

	String^ Block::Name::get()
	{
		return GetStringProperty(D2FP_NAME);
	}

	void Block::Name::set(String^ value)
	{
		SetStringProperty(D2FP_NAME, value);
	}

	Ndapi::NavigationStyle Block::NavigationStyle::get()
	{
		return safe_cast<Ndapi::NavigationStyle>(GetNumberProperty(D2FP_NAVIGATION_STY));
	}

	void Block::NavigationStyle::set(Ndapi::NavigationStyle value)
	{
		SetNumberProperty(D2FP_NAVIGATION_STY, safe_cast<long>(value));
	}

	String^ Block::NextNavigationBlock::get()
	{
		return GetStringProperty(D2FP_NXT_NAVIGATION_BLK_NAM);
	}

	void Block::NextNavigationBlock::set(String^ value)
	{
		SetStringProperty(D2FP_NXT_NAVIGATION_BLK_NAM, value);
	}

	String^ Block::OptimizerHint::get()
	{
		return GetStringProperty(D2FP_OPT_HINT);
	}

	void Block::OptimizerHint::set(String^ value)
	{
		SetStringProperty(D2FP_OPT_HINT, value);
	}

	String^ Block::PreviousNavigationBlock::get()
	{
		return GetStringProperty(D2FP_PREV_NAVIGATION_BLK_NAM);
	}

	void Block::PreviousNavigationBlock::set(String^ value)
	{
		SetStringProperty(D2FP_PREV_NAVIGATION_BLK_NAM, value);
	}

	bool Block::QueryAllowed::get()
	{
		return GetBooleanProperty(D2FP_QRY_ALLOWED);
	}

	void Block::QueryAllowed::set(bool value)
	{
		SetBooleanProperty(D2FP_QRY_ALLOWED, value);
	}

	bool Block::QueryAllRecord::get()
	{
		return GetBooleanProperty(D2FP_QRY_ALL_RECS);
	}

	void Block::QueryAllRecord::set(bool value)
	{
		SetBooleanProperty(D2FP_QRY_ALL_RECS, value);
	}

	String^ Block::QueryDataSourceName::get()
	{
		return GetStringProperty(D2FP_QRY_DAT_SRC_NAM);
	}

	void Block::QueryDataSourceName::set(String^ value)
	{
		SetStringProperty(D2FP_QRY_DAT_SRC_NAM, value);
	}

	long Block::QueryDataSourceType::get()
	{
		return GetNumberProperty(D2FP_QRY_DAT_SRC_TYP);
	}

	void Block::QueryDataSourceType::set(long value)
	{
		SetNumberProperty(D2FP_QRY_DAT_SRC_TYP, value);
	}

	long Block::NumberorRecordsBuffered::get()
	{
		return GetNumberProperty(D2FP_RECS_BUFFERED_COUNT);
	}

	void Block::NumberorRecordsBuffered::set(long value)
	{
		SetNumberProperty(D2FP_RECS_BUFFERED_COUNT, value);
	}

	long Block::NumberOfRecordsDisplayed::get()
	{
		return GetNumberProperty(D2FP_RECS_DISP_COUNT);
	}

	void Block::NumberOfRecordsDisplayed::set(long value)
	{
		SetNumberProperty(D2FP_RECS_DISP_COUNT, value);
	}

	long Block::RecordsToFetch::get()
	{
		return GetNumberProperty(D2FP_RECS_FETCHED_COUNT);
	}

	void Block::RecordsToFetch::set(long value)
	{
		SetNumberProperty(D2FP_RECS_FETCHED_COUNT, value);
	}

	Ndapi::RecordOrientation Block::RecordOrientation::get()
	{
		return safe_cast<Ndapi::RecordOrientation>(GetNumberProperty(D2FP_REC_ORNT));
	}

	void Block::RecordOrientation::set(Ndapi::RecordOrientation value)
	{
		SetNumberProperty(D2FP_REC_ORNT, safe_cast<long>(value));
	}

	String^ Block::CurrentRecordVisualAttributeGroup::get()
	{
		return GetStringProperty(D2FP_REC_VAT_GRP_NAM);
	}

	void Block::CurrentRecordVisualAttributeGroup::set(String^ value)
	{
		SetStringProperty(D2FP_REC_VAT_GRP_NAM, value);
	}

	NdapiObject^ Block::CurrentRecordVisualAttribute::get()
	{
		return GetObjectProperty<NdapiObject^>(D2FP_REC_VAT_GRP_OBJ);
	}

	void Block::CurrentRecordVisualAttribute::set(NdapiObject^ value)
	{
		SetObjectProperty(D2FP_REC_VAT_GRP_OBJ, value);
	}

	bool Block::ReverseDirection::get()
	{
		return GetBooleanProperty(D2FP_REV_DIR);
	}

	void Block::ReverseDirection::set(bool value)
	{
		SetBooleanProperty(D2FP_REV_DIR, value);
	}

	String^ Block::ScrollBarCanvas::get()
	{
		return GetStringProperty(D2FP_SCRLBR_CNV_NAM);
	}

	void Block::ScrollBarCanvas::set(String^ value)
	{
		SetStringProperty(D2FP_SCRLBR_CNV_NAM, value);
	}

	Ndapi::ScrollBarOrientation Block::ScrollBarOrientation::get()
	{
		return safe_cast<Ndapi::ScrollBarOrientation>(GetNumberProperty(D2FP_SCRLBR_ORNT));
	}

	void Block::ScrollBarOrientation::set(Ndapi::ScrollBarOrientation value)
	{
		SetNumberProperty(D2FP_SCRLBR_ORNT, safe_cast<long>(value));
	}

	String^ Block::ScrollBarTabPage::get()
	{
		return GetStringProperty(D2FP_SCRLBR_TBP_NAM);
	}

	void Block::ScrollBarTabPage::set(String^ value)
	{
		SetStringProperty(D2FP_SCRLBR_TBP_NAM, value);
	}

	long Block::ScrollBarWidth::get()
	{
		return GetNumberProperty(D2FP_SCRLBR_WID);
	}

	void Block::ScrollBarWidth::set(long value)
	{
		SetNumberProperty(D2FP_SCRLBR_WID, value);
	}

	long Block::ScrollBarXPosition::get()
	{
		return GetNumberProperty(D2FP_SCRLBR_X_POS);
	}

	void Block::ScrollBarXPosition::set(long value)
	{
		SetNumberProperty(D2FP_SCRLBR_X_POS, value);
	}

	long Block::ScrollBarYPosition::get()
	{
		return GetNumberProperty(D2FP_SCRLBR_Y_POS);
	}

	void Block::ScrollBarYPosition::set(long value)
	{
		SetNumberProperty(D2FP_SCRLBR_Y_POS, value);
	}

	bool Block::ShowScrollBar::get()
	{
		return GetBooleanProperty(D2FP_SHOW_SCRLBR);
	}

	void Block::ShowScrollBar::set(bool value)
	{
		SetBooleanProperty(D2FP_SHOW_SCRLBR, value);
	}

	bool Block::SingleRecord::get()
	{
		return GetBooleanProperty(D2FP_SNGL_REC);
	}

	void Block::SingleRecord::set(bool value)
	{
		SetBooleanProperty(D2FP_SNGL_REC, value);
	}

	bool Block::UpdateAllowed::get()
	{
		return GetBooleanProperty(D2FP_UPDT_ALLOWED);
	}

	void Block::UpdateAllowed::set(bool value)
	{
		SetBooleanProperty(D2FP_UPDT_ALLOWED, value);
	}

	bool Block::UpdateChangedColumnsOnly::get()
	{
		return GetBooleanProperty(D2FP_UPDT_CHANGED_COLS);
	}

	void Block::UpdateChangedColumnsOnly::set(bool value)
	{
		SetBooleanProperty(D2FP_UPDT_CHANGED_COLS, value);
	}

	String^ Block::UpdateProcedureName::get()
	{
		return GetStringProperty(D2FP_UPDT_PROC_NAM);
	}

	void Block::UpdateProcedureName::set(String^ value)
	{
		SetStringProperty(D2FP_UPDT_PROC_NAM, value);
	}

	String^ Block::VisualAttributeGroup::get()
	{
		return GetStringProperty(D2FP_VAT_NAM);
	}

	void Block::VisualAttributeGroup::set(String^ value)
	{
		SetStringProperty(D2FP_VAT_NAM, value);
	}

	String^ Block::WhereClause::get()
	{
		return GetStringProperty(D2FP_WHERE_CLAUSE);
	}

	void Block::WhereClause::set(String^ value)
	{
		SetStringProperty(D2FP_WHERE_CLAUSE, value);
	}

	bool Block::WhiteOnBlack::get()
	{
		return GetBooleanProperty(D2FP_WHITE_ON_BLACK);
	}

	void Block::WhiteOnBlack::set(bool value)
	{
		SetBooleanProperty(D2FP_WHITE_ON_BLACK, value);
	}

	NdapiEnumerator<BlockRelation^>^ Block::BlockRelations::get()
	{
		return gcnew NdapiEnumerator<BlockRelation^>(_handler, D2FP_REL);
	}

	NdapiEnumerator<Trigger^>^ Block::Triggers::get()
	{
		return gcnew NdapiEnumerator<Trigger^>(_handler, D2FP_TRIGGER);
	}
}