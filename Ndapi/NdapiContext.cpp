#include "stdafx.h"
#include "Ndapi.h"
#include "NdapiContext.h"

namespace Ndapi
{
	d2fctx* NdapiContext::Context::get()
	{
		if (_context == nullptr)
		{
			pin_ptr<d2fctx*> context = &_context;
			d2fctxa context_attributes;
			context_attributes.mask_d2fctxa = 0;
			auto status = d2fctxcr_Create(context, &context_attributes);
			CheckStatusAndThrow(status, "Error creating a Oracle Forms context");
		}
		return _context;
	}

	long NdapiContext::ProductVersion::get()
	{
		number version;
		auto status = d2fctxbv_BuilderVersion(Context, &version);
		CheckStatusAndThrow(status, "Error getting product version");
		return version;
	}

	void NdapiContext::Destroy()
	{
		if (_context != nullptr) 
		{
			auto status = d2fctxde_Destroy(_context);
			CheckStatusAndThrow(status, "Error destroying the context");
		}
	}

	void NdapiContext::ConnectToDatabase(String^ connectionString)
	{
		NativeString<text> conn(connectionString);
		d2fctxcn_Connect(Context, conn, nullptr);
	}

	void NdapiContext::DisconnectFromDatabase() 
	{
		d2fctxdc_Disconnect(Context);
	}
}