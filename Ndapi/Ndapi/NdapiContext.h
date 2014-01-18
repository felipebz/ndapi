#pragma once

#include <D2FCTX.H>

namespace Ndapi
{
	public ref class NdapiContext
	{
	private:
		static d2fctx* _context;

	public protected:
		// wrapper for d2fctxcr_Create
		static property d2fctx* Context { d2fctx* get(); }

	public:
		// Wrapper for d2fctxbv_BuilderVersion
		static property long ProductVersion { long get(); }

	// Missing methods:
	//d2fctxde_Destroy
	//d2fctxsa_SetAttributes
	//d2fctxga_GetAttributes
	//d2fctxcn_Connect
	//d2fctxdc_Disconnect
	//d2fctxcf_ConvertFile
	//d2fctxbi_BuiltIns
	};
}