// Public Module PointerExtensions
.class public abstract sealed beforefieldinit Echo8ERA.VisualBasic.Unsafe.PointerExtensions
		extends [System.Runtime]System.Object {

	.custom instance void [Microsoft.VisualBasic.Core]Microsoft.VisualBasic.CompilerServices.StandardModuleAttribute::.ctor() = ( 01 00 00 00 )

	/////////////////////////////////////////////////////////////////////////////
	//                                                                         //
	//  Shared Methods                                                         //
	//                                                                         //
	/////////////////////////////////////////////////////////////////////////////

	// Public Function VarPtr(Of T)(ByRef var As T) As Pointer(Of T)
	.method public static valuetype Echo8ERA.VisualBasic.Unsafe.Pointer`1<!!T> VarPtr<T> (
			!!T& var
		) cil managed {
			
		.maxstack 1

		// 	Throw DirectCast(Nothing, Exception)
		ldnull
		throw

	// End Function
	}


	// Public Function DeRef(Of T)(ByVal ptr As Pointer(Of T)) As Reference(Of T)
	.method public static !!T& DeRef<T> (
			valuetype Echo8ERA.VisualBasic.Unsafe.Pointer`1<!!T> ptr
		) cil managed {
			
		.maxstack 1

		// 	Throw DirectCast(Nothing, Exception)
		ldnull
		throw

	// End Function
	} 

// End Module
}
