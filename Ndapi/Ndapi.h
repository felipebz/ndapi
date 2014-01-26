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

	template<class T>
	class NativeString
	{
	private:
		T* value;
		NativeString(const NativeString&);
		NativeString& operator = (const NativeString&);

	public:
		NativeString(String^ s);
		~NativeString() { Marshal::FreeHGlobal(IntPtr(value)); }
		operator T* () { return value; }
	};
}