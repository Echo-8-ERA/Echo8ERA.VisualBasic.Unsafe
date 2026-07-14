<NoTransform>
Module PointerUtilities

	''' <summary>
	''' Gets the memory address of a variable and returns a typed pointer to that address.
	''' </summary>
	''' <param name="var">The variable to take the address of.</param>
	''' <returns>A <see cref="Pointer(Of T)"/> to the address of <paramref name="var"/>.</returns>
	Public Function VarPtr(Of T)(ByRef var As T) As Pointer(Of T)
		Throw DirectCast(Nothing, Exception)
	End Function

	''' <summary>
	''' Dereferences a typed pointer and returns a reference to the value at that address.
	''' </summary>
	''' <param name="pointer">The pointer to dereference.</param>
	''' <returns>A reference to the value at the address of <paramref name="pointer"/>.</returns>
	Public Function DeRef(Of T)(ByVal pointer As Pointer(Of T)) As Reference(Of T)
		Throw DirectCast(Nothing, Exception)
	End Function

	''' <summary>
	''' Gets the size of a type in bytes.
	''' </summary>
	''' <typeparam name="T">The type to get the size of.</typeparam>
	''' <returns>The size of <typeparamref name="T"/> in bytes.</returns>
	Public Function SizeOf(Of T)() As Integer
		Throw DirectCast(Nothing, Exception)
	End Function

End Module
