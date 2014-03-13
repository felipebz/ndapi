#pragma once

#include "NdapiObject.h"
#include "FormModule.h"

namespace Ndapi
{
	public ref class BlockRelation : NdapiObject
	{
	public protected:
		BlockRelation(d2fob* alert);

	public:
		BlockRelation();
		BlockRelation(FormModule^ form, String^ name);

		property bool AutomaticQuery { bool get(); void set(bool value); }
		property String^ Comment { String^ get(); void set(String^ value); }
		property bool Deferred { bool get(); void set(bool value); }
		property Ndapi::DeleteRecordBehavior DeleteRecordBehavior { Ndapi::DeleteRecordBehavior get(); void set(Ndapi::DeleteRecordBehavior value); }
		property String^ DetailBlock { String^ get(); void set(String^ value); }
		property String^ JoinCondition { String^ get(); void set(String^ value); }
		property String^ Name { String^ get(); void set(String^ value); }
		property bool PreventMasterlessOperations { bool get(); void set(bool value); }
	};
}