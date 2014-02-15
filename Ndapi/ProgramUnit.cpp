#include "stdafx.h"

#include <D2FPGU.H>
#include "ProgramUnit.h"

namespace Ndapi
{
	ProgramUnit::ProgramUnit() : NdapiObject()
	{
	}

	ProgramUnit::ProgramUnit(d2fob* program_unit) : NdapiObject(program_unit)
	{
	}

	ProgramUnit::ProgramUnit(FormModule^ form, String^ name)
	{
		Create(name, form, D2FFO_PROG_UNIT);
	}

	void ProgramUnit::Compile()
	{
		auto status = d2fpguco_CompileObj(NdapiContext::Context, _handler);
		CheckStatusAndThrow(status, String::Format("Error compiling the object. Name: {0}, Type: {1}", Name, Type));
	}

	String^ ProgramUnit::Comment::get()
	{
		return GetStringProperty(D2FP_COMMENT);
	}

	void ProgramUnit::Comment::set(String^ value)
	{
		SetStringProperty(D2FP_COMMENT, value);
	}

	String^ ProgramUnit::Text::get()
	{
		return GetStringProperty(D2FP_PGU_TXT);
	}

	void ProgramUnit::Text::set(String^ value)
	{
		SetStringProperty(D2FP_PGU_TXT, value);
	}

	String^ ProgramUnit::Name::get()
	{
		return GetStringProperty(D2FP_NAME);
	}

	ProgramUnitType ProgramUnit::Type::get()
	{
		return safe_cast<ProgramUnitType>(GetNumberProperty(D2FP_PGU_TYP));
	}
}