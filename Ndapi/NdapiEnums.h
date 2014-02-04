#pragma once

#include <D2FDEF.H>

namespace Ndapi
{
	public enum class ModuleStorageType : long
	{
		Filesystem = D2FC_PAMO_FILESYSTEM,
		Database = D2FC_PAMO_DATABASE
	};

	public enum class ProgramUnitType : long
	{
		Unknown = D2FC_PGTY_UNKNOWN,
		Procedure = D2FC_PGTY_PROCEDURE,
		Function = D2FC_PGTY_FUNCTION,
		PackageSpecification = D2FC_PGTY_PACKAGESPEC,
		PackageBody = D2FC_PGTY_PACKAGEBODY
	};
}
