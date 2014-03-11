#include "stdafx.h"
#include "AttachedLibrary.h"

namespace Ndapi
{
	AttachedLibrary::AttachedLibrary()
	{
	}

	AttachedLibrary::AttachedLibrary(d2fob* program_unit) : NdapiObject(program_unit)
	{
	}

	String^ AttachedLibrary::Comment::get()
	{
		return GetStringProperty(D2FP_COMMENT);
	}

	void AttachedLibrary::Comment::set(String^ value)
	{
		SetStringProperty(D2FP_COMMENT, value);
	}

	String^ AttachedLibrary::Location::get()
	{
		return GetStringProperty(D2FP_LIB_LOC);
	}

	Ndapi::SourceType AttachedLibrary::SourceType::get()
	{
		return safe_cast<Ndapi::SourceType>(GetNumberProperty(D2FP_LIB_SRC));
	}

	String^ AttachedLibrary::Name::get()
	{
		return GetStringProperty(D2FP_NAME);
	}
}