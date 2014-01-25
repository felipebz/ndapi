#pragma once

#include <ORATYPES.H>

using namespace System;
using namespace System::Runtime::InteropServices;

namespace Ndapi
{
	[Serializable]
	public ref class NdapiException : public Exception
	{
	private:
		property long Status;
	public protected:
		NdapiException() : Exception() {}
		NdapiException(String^ message) : Exception(message) {}
		NdapiException(String^ message, Exception^ inner) : Exception(message, inner) {}
		NdapiException(String^ message, long status) : Exception(message)
		{
			Status = status;
		}
	};

	template<class Char_>
	class NativeString
	{
	public:
		NativeString(String^ s);
		~NativeString() { Marshal::FreeHGlobal(IntPtr(p_)); }
		operator Char_* () { return p_; }

	private:
		NativeString(const NativeString&);
		NativeString& operator = (const NativeString&);

	private:
		Char_* p_;
	};
}