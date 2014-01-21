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
				throw gcnew NdapiException("Error creating a Oracle Forms context", status);
			}

			_context = context;
		}
		return _context;
	}

	long NdapiContext::ProductVersion::get()
	{
		number version;
		auto status = d2fctxbv_BuilderVersion(Context, &version);
		if (status != D2FS_SUCCESS) {
			throw gcnew NdapiException("Error getting product version", status);
		}
		return version;
	}

	void NdapiContext::Destroy()
	{
		if (_context != nullptr) 
		{
			auto status = d2fctxde_Destroy(_context);
			if (status != D2FS_SUCCESS) {
				throw gcnew NdapiException("Error destroying the context", status);
			}
		}
	}

	void NdapiContext::ConnectToDatabase(String^ connectionString)
	{
		d2fctxcn_Connect(Context, StringToText(connectionString), nullptr);
	}

	void NdapiContext::DisconnectFromDatabase() 
	{
		d2fctxdc_Disconnect(Context);
	}
}