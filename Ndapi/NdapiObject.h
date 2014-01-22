#pragma once

#include "Ndapi.h"
#include "NdapiContext.h"
#include <D2FOB.H>

using namespace System;

namespace Ndapi
{
	public ref class NdapiObject
	{
	private:
		d2fob* internal_object;

	public protected:
		NdapiObject(d2fob* object);

	public:
		String^ GetStringProperty(int property_id);
		void SetStringProperty(int property_id, String^ value);
		long GetNumberProperty(int property_id);
		void SetNumberProperty(int property_id, long value);
	};
}