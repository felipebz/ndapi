#include "stdafx.h"
#include "Ndapi.h"
#include "NdapiContext.h"

namespace Ndapi
{
	d2fctx* NdapiContext::Context::get()
	{
		if (_context == nullptr)
		{
			d2fctx* context;
			d2fctxa context_attributes;
			context_attributes.mask_d2fctxa = 0;
			auto status = d2fctxcr_Create(&context, &context_attributes);
			if (status != D2FS_SUCCESS) {
				throw gcnew NdapiException("Error while creating a Oracle Forms context", status);
			}

			_context = context;
		}
		return _context;
	}

	long NdapiContext::ProductVersion::get()
	{
		number version;
		auto status = d2fctxbv_BuilderVersion(Context, &version);
		return version;
	}
}