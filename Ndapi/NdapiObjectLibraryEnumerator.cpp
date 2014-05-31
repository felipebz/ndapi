#include "stdafx.h"
#include "NdapiObjectLibraryEnumerator.h"

namespace Ndapi
{
	NdapiObjectLibraryEnumerator::NdapiObjectLibraryEnumerator(ObjectLibrary^ olb)
	{
		_olb = olb;
		_count = _olb->ObjectCount;
	}

	bool NdapiObjectLibraryEnumerator::MoveNext()
	{
		_position++;
		return _position <= _count;
	}

	NdapiObject^ NdapiObjectLibraryEnumerator::Current::get()
	{
		if (_position == 0)
		{
			MoveNext();
		}

		return _olb->GetObjectByPosition(_position);
	}
}