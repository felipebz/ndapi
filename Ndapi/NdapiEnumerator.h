#pragma once

#include <D2FOB.H>

#include "Ndapi.h"
#include "NdapiContext.h"
#include "NdapiObject.h"

using namespace System;
using namespace System::Collections::Generic;
using namespace System::Runtime::InteropServices;

namespace Ndapi
{
	generic <class T> where T : NdapiObject, gcnew()
		public ref struct NdapiEnumerator : IEnumerable<T>, IEnumerator<T>
	{
	private:
		d2fob* _handler;
		void* _result;
		int _property_id;

	public:
		NdapiEnumerator(dvoid* handler, int property_id)
		{
			_handler = handler;
			_property_id = property_id;
		}

		virtual bool MoveNext() = IEnumerator<T>::MoveNext
		{
			void* result;
			d2fstatus status;

			if (_result == nullptr)
			{
				status = d2fobgo_GetObjProp(NdapiContext::Context, _handler, _property_id, &result);
				if (status != D2FS_SUCCESS)
				{
					throw gcnew NdapiException(String::Format("Error getting the first object from iterator. Property id: {0}", _property_id), status);
				}
			}
			else
			{
				status = d2fobgo_GetObjProp(NdapiContext::Context, _result, D2FP_NEXT, &result);
				if (status != D2FS_SUCCESS)
				{
					throw gcnew NdapiException(String::Format("Error getting the next object from iterator. Property id: {0}", _property_id), status);
				}
			}
			_result = result;

			return _result != nullptr;
		}

		property T Current
		{
			virtual T get() = IEnumerator<T>::Current::get
			{
			if (_result == nullptr)
			{
				MoveNext();
			}

			auto instance = gcnew T();

			instance->FillWithObject(_result);

			return instance;
		}
		};

		property Object^ RawCurrent
		{
			virtual Object^ get() = System::Collections::IEnumerator::Current::get
			{
			return Current;
		}
		};

		virtual void Reset() = IEnumerator<T>::Reset
		{
		}

		~NdapiEnumerator()
		{
		}

		virtual IEnumerator<T>^ GetEnumerator()
		{
			return this;
		}

		virtual System::Collections::IEnumerator^ GetRawEnumerator() = System::Collections::IEnumerable::GetEnumerator
		{
			return this;
		}
	};
}