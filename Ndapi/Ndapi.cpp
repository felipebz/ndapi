#include "stdafx.h"
#include "Ndapi.h"

using namespace System::Runtime::InteropServices;

text* Ndapi::StringToText(String^ value) {
	auto value_handler = Marshal::StringToHGlobalAnsi(value);
	auto result = static_cast<text*>(value_handler.ToPointer());
	Marshal::FreeHGlobal(value_handler);

	return result;
}