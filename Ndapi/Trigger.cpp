#include "stdafx.h"
#include "Trigger.h"

#include <D2FTRG.H>

namespace Ndapi
{
	Trigger::Trigger() : NdapiObject()
	{
	}

	Trigger::Trigger(d2fob* program_unit) : NdapiObject(program_unit)
	{
	}

	Trigger::Trigger(FormModule^ form, String^ name)
	{
		Create(name, form, D2FFO_TRIGGER);
	}

	void Trigger::Compile()
	{
		auto status = d2ftrgco_CompileObj(NdapiContext::Context, _handler);
		CheckStatusAndThrow(status, String::Format("Error compiling the object. Name: {0}", Name));
	}

	String^ Trigger::Comment::get()
	{
		return GetStringProperty(D2FP_COMMENT);
	}

	void Trigger::Comment::set(String^ value)
	{
		SetStringProperty(D2FP_COMMENT, value);
	}

	bool Trigger::DisplayInKeyboardHelp::get()
	{
		return GetBooleanProperty(D2FP_DISP_IN_KBRD_HLP);
	}

	void Trigger::DisplayInKeyboardHelp::set(bool value)
	{
		SetBooleanProperty(D2FP_DISP_IN_KBRD_HLP, value);
	}

	Ndapi::ExecutionStyle Trigger::ExecutionStyle::get()
	{
		return safe_cast<Ndapi::ExecutionStyle>(GetNumberProperty(D2FP_EXEC_HIERARCHY));
	}

	void Trigger::ExecutionStyle::set(Ndapi::ExecutionStyle value)
	{
		SetNumberProperty(D2FP_EXEC_HIERARCHY, safe_cast<long>(value));
	}

	bool Trigger::FireInEnterQueryMode::get()
	{
		return GetBooleanProperty(D2FP_FIRE_IN_QRY);
	}

	void Trigger::FireInEnterQueryMode::set(bool value)
	{
		SetBooleanProperty(D2FP_FIRE_IN_QRY, value);
	}

	String^ Trigger::KeyboardHelpDescription::get()
	{
		return GetStringProperty(D2FP_KBRD_HLP_TXT);
	}

	void Trigger::KeyboardHelpDescription::set(String^ value)
	{
		SetStringProperty(D2FP_KBRD_HLP_TXT, value);
	}

	String^ Trigger::Name::get()
	{
		return GetStringProperty(D2FP_NAME);
	}

	void Trigger::Name::set(String^ value)
	{
		SetStringProperty(D2FP_NAME, value);
	}

	TriggerStyle Trigger::Style::get()
	{
		return safe_cast<TriggerStyle>(GetNumberProperty(D2FP_TRG_STY));
	}

	void Trigger::Style::set(TriggerStyle value)
	{
		SetNumberProperty(D2FP_TRG_STY, safe_cast<long>(value));
	}

	String^ Trigger::Text::get()
	{
		return GetStringProperty(D2FP_TRG_TXT);
	}

	void Trigger::Text::set(String^ value)
	{
		SetStringProperty(D2FP_TRG_TXT, value);
	}
}