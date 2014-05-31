#pragma once

#include <D2FOB.H>
#include <D2FOLB.H>

#include "Ndapi.h"
#include "NdapiContext.h"
#include "NdapiObject.h"

using namespace System;
using namespace System::Collections::Generic;

namespace Ndapi
{
	generic <class T>
	public ref struct NdapiEnumerator abstract : IEnumerable<T>, IEnumerator<T>
	{
		virtual bool MoveNext() abstract = IEnumerator<T>::MoveNext;

		property T Current
		{
			virtual T get() abstract = IEnumerator<T>::Current::get;
		}

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

	generic <class T>
	ref struct NdapiObjectEnumerator : NdapiEnumerator<T>
	{
	private:
		d2fob* _handler;
		d2fob* _result;
		int _property_id;

	public:
		NdapiObjectEnumerator(dvoid* handler, int property_id)
		{
			_handler = handler;
			_property_id = property_id;
		}

		virtual bool MoveNext() new = NdapiEnumerator::MoveNext
		{
			void* result;
			d2fstatus status;

			if (_result == nullptr)
			{
				status = d2fobgo_GetObjProp(NdapiContext::Context, _handler, _property_id, &result);
				CheckStatusAndThrow(status, String::Format("Error getting the first object from iterator. Property id: {0}", _property_id));
			}
			else
			{
				status = d2fobgo_GetObjProp(NdapiContext::Context, _result, D2FP_NEXT, &result);
				CheckStatusAndThrow(status, String::Format("Error getting the next object from iterator. Property id: {0}", _property_id));
			}
			_result = result;

			return _result != nullptr;
		}

		property T Current
		{
			virtual T get() new = NdapiEnumerator::Current::get
			{
				if (_result == nullptr)
				{
					MoveNext();
				}

				NdapiObject^ instance = safe_cast<NdapiObject^>(Activator::CreateInstance<T>());

				instance->FillWithObject(_result);

				return safe_cast<T>(instance);
			}
		};
	};
}