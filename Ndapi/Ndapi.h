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
		long _status;

	public:		
		property long Status 
		{ 
			long get() 
			{
				return _status;
			}
		};

	public protected:
		NdapiException() : Exception() {}
		NdapiException(String^ message) : Exception(message) {}
		NdapiException(String^ message, Exception^ inner) : Exception(message, inner) {}
		NdapiException(String^ message, long status) : Exception(message)
		{
			_status = status;
		}
	};

	template<class T>
	class NativeString
	{
	private:
		T* value;

	public:
		NativeString(String^ s);
		NativeString(const NativeString&) = delete;
		NativeString& operator = (const NativeString&) = delete;
		~NativeString() { Marshal::FreeHGlobal(IntPtr(value)); }
		operator T* () { return value; }
	};
}