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
		if (status != D2FS_SUCCESS)
		{
			throw gcnew NdapiException(String::Format("Error opening the form module. Path: {0}", file), status);
		}

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
		if (status != D2FS_SUCCESS)
		{
			throw gcnew NdapiException(String::Format("Error saving the form module. Path: {0}", path), status);
		}
	}

	NdapiEnumerator<ProgramUnit^>^ FormModule::ProgramUnits::get()
	{
		return gcnew NdapiEnumerator<ProgramUnit^>(_handler, D2FP_PROG_UNIT);
	}

	FormModule::~FormModule() {
		d2ffmdde_Destroy(NdapiContext::Context, (d2ffmd*)_handler);
	}
}