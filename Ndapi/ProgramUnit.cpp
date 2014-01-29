#include "stdafx.h"
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
}