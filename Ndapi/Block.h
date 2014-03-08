#pragma once

#include "NdapiObject.h"
#include "FormModule.h"

namespace Ndapi
{
	ref class FormModule;

	public ref class Block : NdapiObject
	{
	public protected:
		Block(d2fob* alert);

	public:
		Block();
		Block(FormModule^ form, String^ name);

		property String^ BackgroundColor { String^ get(); void set(String^ value); }
		property String^ Description { String^ get(); void set(String^ value); }
		property String^ Comment { String^ get(); void set(String^ value); }
		property bool DeleteAllowed { bool get(); void set(bool value); }
		property String^ DeleteProcedureName { String^ get(); void set(String^ value); }
		property long DMLArraySize { long get(); void set(long value); }
		property String^ DMLDataTargetName { String^ get(); void set(String^ value); }
		property Ndapi::DMLDataTargetType DMLDataTargetType { Ndapi::DMLDataTargetType get(); void set(Ndapi::DMLDataTargetType value); }
		property bool EnforceColumnSecurity { bool get(); void set(bool value); }
		property bool EnforcePrimaryKey { bool get(); void set(bool value); }
		property String^ FillPattern { String^ get(); void set(String^ value); }
		property String^ FontName { String^ get(); void set(String^ value); }
		property long FontSize { long get(); void set(long value); }
		property Ndapi::FontSpacing FontSpacing { Ndapi::FontSpacing get(); void set(Ndapi::FontSpacing value); }
		property Ndapi::FontStyle FontStyle { Ndapi::FontStyle get(); void set(Ndapi::FontStyle value); }
		property Ndapi::FontWeight FontWeight { Ndapi::FontWeight get(); void set(Ndapi::FontWeight value); }
		property String^ ForegroundColor { String^ get(); void set(String^ value); }
		property bool InsertAllowed { bool get(); void set(bool value); }
		property String^ InsertProcedureName { String^ get(); void set(String^ value); }
		property Ndapi::KeyMode KeyMode { Ndapi::KeyMode get(); void set(Ndapi::KeyMode value); }
		property Ndapi::LanguageDirection LanguageDirection { Ndapi::LanguageDirection get(); void set(Ndapi::LanguageDirection value); }
		property Ndapi::LockingMode LockingMode { Ndapi::LockingMode get(); void set(Ndapi::LockingMode value); }
		property String^ LockProcedureName { String^ get(); void set(String^ value); }
		property bool ListedInBlockMenu { bool get(); void set(bool value); }
		property long MaximumQueryTime { long get(); void set(long value); }
		property long MaxRecordsFetched { long get(); void set(long value); }
		property String^ Name { String^ get(); void set(String^ value); }
		property Ndapi::NavigationStyle NavigationStyle { Ndapi::NavigationStyle get(); void set(Ndapi::NavigationStyle value); }
		property String^ NextNavigationBlock { String^ get(); void set(String^ value); }
		property String^ OptimizerHint { String^ get(); void set(String^ value); }
		property String^ PreviousNavigationBlock { String^ get(); void set(String^ value); }
		property bool QueryAllowed { bool get(); void set(bool value); }
		property bool QueryAllRecord { bool get(); void set(bool value); }
		property String^ QueryDataSourceName { String^ get(); void set(String^ value); }
		property long QueryDataSourceType { long get(); void set(long value); }
		property long NumberorRecordsBuffered { long get(); void set(long value); }
		property long NumberOfRecordsDisplayed { long get(); void set(long value); }
		property long RecordsToFetch { long get(); void set(long value); }
		property Ndapi::RecordOrientation RecordOrientation { Ndapi::RecordOrientation get(); void set(Ndapi::RecordOrientation value); }
		property String^ CurrentRecordVisualAttributeGroup { String^ get(); void set(String^ value); }
		property NdapiObject^ CurrentRecordVisualAttribute { NdapiObject^ get(); void set(NdapiObject^ value); }
		property bool ReverseDirection { bool get(); void set(bool value); }
		property String^ ScrollBarCanvas { String^ get(); void set(String^ value); }
		property Ndapi::ScrollBarOrientation ScrollBarOrientation { Ndapi::ScrollBarOrientation get(); void set(Ndapi::ScrollBarOrientation value); }
		property String^ ScrollBarTabPage { String^ get(); void set(String^ value); }
		property long ScrollBarWidth { long get(); void set(long value); }
		property long ScrollBarXPosition { long get(); void set(long value); }
		property long ScrollBarYPosition { long get(); void set(long value); }
		property bool ShowScrollBar { bool get(); void set(bool value); }
		property bool SingleRecord { bool get(); void set(bool value); }
		property bool UpdateAllowed { bool get(); void set(bool value); }
		property bool UpdateChangedColumnsOnly { bool get(); void set(bool value); }
		property String^ UpdateProcedureName { String^ get(); void set(String^ value); }
		property String^ VisualAttributeGroup { String^ get(); void set(String^ value); }
		property String^ WhereClause { String^ get(); void set(String^ value); }
		property bool WhiteOnBlack { bool get(); void set(bool value); }

	};
}