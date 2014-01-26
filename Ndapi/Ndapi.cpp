#include "stdafx.h"
#include "Ndapi.h"

using namespace System;
using namespace System::Runtime::InteropServices;

template<>
Ndapi::NativeString<text>::NativeString(String^ s)
{
	value = (text*)(void*)Marshal::StringToHGlobalAnsi(s);
}
