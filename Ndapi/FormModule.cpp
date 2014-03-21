#include "stdafx.h"
#include "FormModule.h"

using namespace System::IO;

namespace Ndapi
{
	FormModule::FormModule(d2fob* form_module) : NdapiObject(form_module)
	{
	}

	FormModule::FormModule(String^ name) {
		Create(name, D2FFO_FORM_MODULE);
	}

	FormModule^ FormModule::Open(String^ file)
	{
		if (!File::Exists(file)) {
			throw gcnew FileNotFoundException("Module file not found", file);
		}

		NativeString<text> filename(file);

		d2ffmd* form_module;
		auto status = d2ffmdld_Load(NdapiContext::Context, &form_module, filename, FALSE);
		CheckStatusAndThrow(status, String::Format("Error opening the form module. Path: {0}", file));

		return gcnew FormModule(form_module);
	}

	void FormModule::Save()
	{
		Save(nullptr);
	}

	void FormModule::Save(String^ path)
	{
		Save(path, false);
	}

	void FormModule::Save(String^ path, bool saveInDatabase)
	{
		NativeString<text> module_path(path);
		auto status = d2ffmdsv_Save(NdapiContext::Context, _handler, module_path, saveInDatabase);
		CheckStatusAndThrow(status, String::Format("Error saving the form module. Path: {0}", path));
	}

	void FormModule::CompileFile()
	{
		auto status = d2ffmdcf_CompileFile(NdapiContext::Context, _handler);
		CheckStatusAndThrow(status, String::Format("Error compiling the form module."));
	}

	void FormModule::CompileObjects()
	{
		auto status = d2ffmdco_CompileObj(NdapiContext::Context, _handler);
		CheckStatusAndThrow(status, String::Format("Error compiling the PL/SQL objects."));
	}

	String^ FormModule::Comment::get()
	{
		return GetStringProperty(D2FP_COMMENT);
	}

	void FormModule::Comment::set(String^ value)
	{
		SetStringProperty(D2FP_COMMENT, value);
	}

	String^ FormModule::ConsoleWindow::get()
	{
		return GetStringProperty(D2FP_CONSOLE_WIN);
	}

	void FormModule::ConsoleWindow::set(String^ value)
	{
		SetStringProperty(D2FP_CONSOLE_WIN, value);
	}

	bool FormModule::DeferRequiredEnforcement::get()
	{
		return GetBooleanProperty(D2FP_DEFER_REQ_ENF);
	}

	void FormModule::DeferRequiredEnforcement::set(bool value)
	{
		SetBooleanProperty(D2FP_DEFER_REQ_ENF, value);
	}

	NdapiObject^ FormModule::FirstNavigationBlock::get()
	{
		return GetObjectProperty<NdapiObject^>(D2FP_FRST_NAVIGATION_BLK_OBJ);
	}

	void FormModule::FirstNavigationBlock::set(NdapiObject^ value)
	{
		SetObjectProperty(D2FP_FRST_NAVIGATION_BLK_OBJ, value);
	}

	String^ FormModule::HelpBookTitle::get()
	{
		return GetStringProperty(D2FP_HELP_BOOK_TITLE);
	}

	void FormModule::HelpBookTitle::set(String^ value)
	{
		SetStringProperty(D2FP_HELP_BOOK_TITLE, value);
	}

	String^ FormModule::HorizontalToolbarCanvas::get()
	{
		return GetStringProperty(D2FP_HORZ_TLBR_CNV);
	}

	void FormModule::HorizontalToolbarCanvas::set(String^ value)
	{
		SetStringProperty(D2FP_HORZ_TLBR_CNV, value);
	}

	String^ FormModule::InitialMenu::get()
	{
		return GetStringProperty(D2FP_INIT_MNU);
	}

	void FormModule::InitialMenu::set(String^ value)
	{
		SetStringProperty(D2FP_INIT_MNU, value);
	}

	Ndapi::InteractionMode FormModule::InteractionMode::get()
	{
		return GetNumberProperty<Ndapi::InteractionMode>(D2FP_INTERACTION_MODE);
	}

	void FormModule::InteractionMode::set(Ndapi::InteractionMode value)
	{
		SetNumberProperty(D2FP_INTERACTION_MODE, value);
	}

	Ndapi::IsolationMode FormModule::IsolationMode::get()
	{
		return GetNumberProperty<Ndapi::IsolationMode>(D2FP_ISOLATION_MODE);
	}

	void FormModule::IsolationMode::set(Ndapi::IsolationMode value)
	{
		SetNumberProperty(D2FP_ISOLATION_MODE, value);
	}

	Ndapi::LanguageDirection FormModule::LanguageDirection::get()
	{
		return GetNumberProperty<Ndapi::LanguageDirection>(D2FP_LANG_DIR);
	}

	void FormModule::LanguageDirection::set(Ndapi::LanguageDirection value)
	{
		SetNumberProperty(D2FP_LANG_DIR, value);
	}

	long FormModule::MaximumQueryTime::get()
	{
		return GetNumberProperty(D2FP_MAX_QRY_TIME);
	}

	void FormModule::MaximumQueryTime::set(long value)
	{
		if (value < 0) {
			throw gcnew ArgumentOutOfRangeException("value", value, "MaximumQueryTime cannot be negative.");
		}
		SetNumberProperty(D2FP_MAX_QRY_TIME, value);
	}

	long FormModule::MaxRecordsFetched::get()
	{
		return GetNumberProperty(D2FP_MAX_RECS_FETCHED);
	}

	void FormModule::MaxRecordsFetched::set(long value)
	{
		if (value < 0) {
			throw gcnew ArgumentOutOfRangeException("value", value, "MaxRecordsFetched cannot be negative.");
		}
		SetNumberProperty(D2FP_MAX_RECS_FETCHED, value);
	}

	String^ FormModule::MenuModule::get()
	{
		return GetStringProperty(D2FP_MNU_MOD);
	}

	void FormModule::MenuModule::set(String^ value)
	{
		SetStringProperty(D2FP_MNU_MOD, value);
	}

	String^ FormModule::MenuRole::get()
	{
		return GetStringProperty(D2FP_MNU_ROLE);
	}

	void FormModule::MenuRole::set(String^ value)
	{
		SetStringProperty(D2FP_MNU_ROLE, value);
	}

	Ndapi::MenuSource FormModule::MenuSource::get()
	{
		return GetNumberProperty<Ndapi::MenuSource>(D2FP_MNU_SRC);
	}

	void FormModule::MenuSource::set(Ndapi::MenuSource value)
	{
		SetNumberProperty(D2FP_MNU_SRC, value);
	}

	Ndapi::MenuStyle FormModule::MenuStyle::get()
	{
		return GetNumberProperty<Ndapi::MenuStyle>(D2FP_MNU_STY);
	}

	void FormModule::MenuStyle::set(Ndapi::MenuStyle value)
	{
		SetNumberProperty(D2FP_MNU_STY, value);
	}

	Ndapi::MouseNavigationLimit FormModule::MouseNavigationLimit::get()
	{
		return GetNumberProperty<Ndapi::MouseNavigationLimit>(D2FP_MOUSE_NAVIGATION_LMT);
	}

	void FormModule::MouseNavigationLimit::set(Ndapi::MouseNavigationLimit value)
	{
		SetNumberProperty(D2FP_MOUSE_NAVIGATION_LMT, value);
	}

	NdapiObject^ FormModule::CurrentRecordVisualAttribute::get()
	{
		return GetObjectProperty<NdapiObject^>(D2FP_REC_VAT_GRP_OBJ);
	}

	void FormModule::CurrentRecordVisualAttribute::set(NdapiObject^ value)
	{
		SetObjectProperty(D2FP_REC_VAT_GRP_OBJ, value);
	}

	Ndapi::RuntimeCompatibility FormModule::RuntimeCompatibility::get()
	{
		return GetNumberProperty<Ndapi::RuntimeCompatibility>(D2FP_RUNTIME_COMP);
	}

	void FormModule::RuntimeCompatibility::set(Ndapi::RuntimeCompatibility value)
	{
		SetNumberProperty(D2FP_RUNTIME_COMP, value);
	}

	String^ FormModule::Title::get()
	{
		return GetStringProperty(D2FP_TITLE);
	}

	void FormModule::Title::set(String^ value)
	{
		SetStringProperty(D2FP_TITLE, value);
	}

	bool FormModule::Use3DControls::get()
	{
		return GetBooleanProperty(D2FP_USE_3D_CNTRLS);
	}

	void FormModule::Use3DControls::set(bool value)
	{
		SetBooleanProperty(D2FP_USE_3D_CNTRLS, value);
	}

	Ndapi::ValidationUnit FormModule::ValidationUnit::get()
	{
		return GetNumberProperty<Ndapi::ValidationUnit>(D2FP_VALIDATION_UNIT);
	}

	void FormModule::ValidationUnit::set(Ndapi::ValidationUnit value)
	{
		SetNumberProperty(D2FP_VALIDATION_UNIT, value);
	}

	String^ FormModule::VerticalToolbarCanvas::get()
	{
		return GetStringProperty(D2FP_VERT_TLBR_CNV);
	}

	void FormModule::VerticalToolbarCanvas::set(String^ value)
	{
		SetStringProperty(D2FP_VERT_TLBR_CNV, value);
	}

	NdapiEnumerator<Alert^>^ FormModule::Alerts::get()
	{
		return gcnew NdapiEnumerator<Alert^>(_handler, D2FP_ALERT);
	}

	NdapiEnumerator<Block^>^ FormModule::Blocks::get()
	{
		return gcnew NdapiEnumerator<Block^>(_handler, D2FP_BLOCK);
	}

	NdapiEnumerator<Canvas^>^ FormModule::Canvases::get()
	{
		return gcnew NdapiEnumerator<Canvas^>(_handler, D2FP_CANVAS);
	}

	NdapiEnumerator<FormParameter^>^ FormModule::FormParameters::get()
	{
		return gcnew NdapiEnumerator<FormParameter^>(_handler, D2FP_FORM_PARAM);
	}

	NdapiEnumerator<ProgramUnit^>^ FormModule::ProgramUnits::get()
	{
		return gcnew NdapiEnumerator<ProgramUnit^>(_handler, D2FP_PROG_UNIT);
	}

	NdapiEnumerator<RecordGroup^>^ FormModule::RecordGroups::get()
	{
		return gcnew NdapiEnumerator<RecordGroup^>(_handler, D2FP_REC_GRP);
	}

	NdapiEnumerator<Trigger^>^ FormModule::Triggers::get()
	{
		return gcnew NdapiEnumerator<Trigger^>(_handler, D2FP_TRIGGER);
	}

	NdapiEnumerator<AttachedLibrary^>^ FormModule::AttachedLibraries::get()
	{
		return gcnew NdapiEnumerator<AttachedLibrary^>(_handler, D2FP_ATT_LIB);
	}

	NdapiEnumerator<Window^>^ FormModule::Windows::get()
	{
		return gcnew NdapiEnumerator<Window^>(_handler, D2FP_WINDOW);
	}

	FormModule::~FormModule() {
		d2ffmdde_Destroy(NdapiContext::Context, safe_cast<d2ffmd*>(_handler));
	}
}