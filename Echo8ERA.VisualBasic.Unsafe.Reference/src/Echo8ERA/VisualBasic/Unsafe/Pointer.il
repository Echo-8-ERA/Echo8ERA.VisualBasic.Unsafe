// Public Structure Pointer(Of T)
.class public sequential ansi sealed Echo8ERA.VisualBasic.Unsafe.Pointer`1<T>	extends [System.Runtime]System.ValueType {

	/////////////////////////////////////////////////////////////////////////////
	//                                                                         //
	//  Fields                                                                 //
	//                                                                         //
	/////////////////////////////////////////////////////////////////////////////

	// Private m_Address As IntPtr
	.field private native int m_Address

	/////////////////////////////////////////////////////////////////////////////
	//                                                                         //
	//  Operators                                                              //
	//                                                                         //
	/////////////////////////////////////////////////////////////////////////////

	// Public Shared Operator +(ByVal lhs As Integer, ByVal rhs As Pointer(Of T)) As Pointer(Of T)
	.method public specialname static valuetype Echo8ERA.VisualBasic.Unsafe.Pointer`1<!T> op_Addition (
			int32 lhs,
			valuetype Echo8ERA.VisualBasic.Unsafe.Pointer`1<!T> rhs
		) cil managed {

		.maxstack 1

		// 	Throw DirectCast(Nothing, Exception)
		ldnull
		throw

	// End Operator
	} 

	// Public Shared Operator +(ByVal lhs As Pointer(Of T), ByVal rhs As Integer) As Pointer(Of T)
	.method public specialname static valuetype Echo8ERA.VisualBasic.Unsafe.Pointer`1<!T> op_Addition (
			valuetype Echo8ERA.VisualBasic.Unsafe.Pointer`1<!T> lhs,
			int32 rhs
		) cil managed {

		.maxstack 1

		// 	Throw DirectCast(Nothing, Exception)
		ldnull
		throw

	// End Operator
	} 

	// Public Shared Operator -(ByVal lhs As Pointer(Of T), ByVal rhs As Integer) As Pointer(Of T)
	.method public specialname static  valuetype Echo8ERA.VisualBasic.Unsafe.Pointer`1<!T> op_Subtraction (
			valuetype Echo8ERA.VisualBasic.Unsafe.Pointer`1<!T> lhs,
			int32 rhs
		) cil managed {

		.maxstack 1

		// 	Throw DirectCast(Nothing, Exception)
		ldnull
		throw

	// End Operator
	} 

	// Public Shared Operator -(ByVal a As Pointer(Of T), ByVal b As Pointer(Of T)) As Long
	.method public specialname static int64 op_Subtraction (
			valuetype Echo8ERA.VisualBasic.Unsafe.Pointer`1<!T> lhs,
			valuetype Echo8ERA.VisualBasic.Unsafe.Pointer`1<!T> rhs
		) cil managed {
			
		.maxstack 1

		// 	Throw DirectCast(Nothing, Exception)
		ldnull
		throw

	// End Operator
	} 

	/////////////////////////////////////////////////////////////////////////////
	//                                                                         //
	//  Conversion Operators                                                   //
	//                                                                         //
	/////////////////////////////////////////////////////////////////////////////

	// Public Shared Widening Operator CType(ByVal p As Pointer(Of T)) As VoidPointer
	.method public specialname static valuetype Echo8ERA.VisualBasic.Unsafe.VoidPointer op_Implicit (
			valuetype Echo8ERA.VisualBasic.Unsafe.Pointer`1<!T> ptr
		) cil managed {
			
		.maxstack 1

		// 	Throw DirectCast(Nothing, Exception)
		ldnull
		throw

	// End Operator
	} 

	// Public Shared Narrowing Operator CType(ByVal p As VoidPointer) As Pointer(Of T)
	.method public specialname static valuetype Echo8ERA.VisualBasic.Unsafe.Pointer`1<!T> op_Explicit (
			valuetype Echo8ERA.VisualBasic.Unsafe.VoidPointer ptr
		) cil managed {

		.maxstack 1

		// 	Throw DirectCast(Nothing, Exception)
		ldnull
		throw

	// End Operator
	} 

// End Structure
}
