#pragma once

#include "NdapiEnumerator.h"
#include "ObjectLibrary.h"

namespace Ndapi
{
	ref class ObjectLibrary;

	ref struct NdapiObjectLibraryEnumerator : NdapiEnumerator<NdapiObject^>
	{
	private:
		ObjectLibrary^ _olb;
		int _count;
		int _position;

	public:
		NdapiObjectLibraryEnumerator(ObjectLibrary^ olb);
		virtual bool MoveNext() override = IEnumerator<NdapiObject^>::MoveNext;

		property NdapiObject^ Current
		{
			virtual NdapiObject^ get() override = IEnumerator<NdapiObject^>::Current::get;
		};
	};
}
