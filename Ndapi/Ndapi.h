#pragma once

using namespace System;

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
}