#pragma once

#include <D2FOB.H>

#include "Ndapi.h"
#include "NdapiContext.h"

using namespace System;

namespace Ndapi
{
	public ref class NdapiObject
	{
	public protected:
		d2fob* internal_object;

		NdapiObject();
		NdapiObject(d2fob* object);
		void FillWithObject(void* object);

	public:
		String^ GetStringProperty(int property_id);
		void SetStringProperty(int property_id, String^ value);
		long GetNumberProperty(int property_id);
		void SetNumberProperty(int property_id, long value);
	};
}