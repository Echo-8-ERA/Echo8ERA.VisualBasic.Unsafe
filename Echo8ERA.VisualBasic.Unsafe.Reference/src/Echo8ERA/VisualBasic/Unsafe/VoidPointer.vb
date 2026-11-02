''' <summary>
''' Represents an untyped pointer to a memory address.
''' </summary>
<NoTransform>
Public Structure VoidPointer
	Private m_Address As UIntPtr

#Region "Operators: Comparison"
	' ###################################################################
	' #                                                                 #
	' # Operators: Comparison                                           #
	' #                                                                 #
	' ###################################################################

	''' <summary>
	''' Compares two pointers for equality.
	''' </summary>
	''' <param name="pointerA">The first pointer.</param>
	''' <param name="pointerB">The second pointer.</param>
	''' <returns><see langword="True"/> if the two pointers point to the same address; otherwise, <see langword="False"/>.</returns>
	Public Shared Operator =(ByVal pointerA As VoidPointer, ByVal pointerB As VoidPointer) As Boolean
		Throw DirectCast(Nothing, Exception)
	End Operator

	''' <summary>
	''' Compares two pointers for inequality.
	''' </summary>
	''' <param name="pointerA">The first pointer.</param>
	''' <param name="pointerB">The second pointer.</param>
	''' <returns><see langword="True"/> if the two pointers point to different addresses; otherwise, <see langword="False"/>.</returns>
	Public Shared Operator <>(ByVal pointerA As VoidPointer, ByVal pointerB As VoidPointer) As Boolean
		Throw DirectCast(Nothing, Exception)
	End Operator

	''' <summary>
	''' Compares if one pointer is less than another pointer.
	''' </summary>
	''' <param name="pointerA">The first pointer.</param>
	''' <param name="pointerB">The second pointer.</param>
	''' <returns><see langword="True"/> if the first pointer points to a lower address than the second pointer; otherwise, <see langword="False"/>.</returns>
	Public Shared Operator <(ByVal pointerA As VoidPointer, ByVal pointerB As VoidPointer) As Boolean
		Throw DirectCast(Nothing, Exception)
	End Operator

	''' <summary>
	''' Compares if one pointer is greater than another pointer.
	''' </summary>
	''' <param name="pointerA">The first pointer.</param>
	''' <param name="pointerB">The second pointer.</param>
	''' <returns><see langword="True"/> if the first pointer points to a higher address than the second pointer; otherwise, <see langword="False"/>.</returns>
	Public Shared Operator >(ByVal pointerA As VoidPointer, ByVal pointerB As VoidPointer) As Boolean
		Throw DirectCast(Nothing, Exception)
	End Operator

	''' <summary>
	''' Compares if one pointer is less than or equal to another pointer.
	''' </summary>
	''' <param name="pointerA">The first pointer.</param>
	''' <param name="pointerB">The second pointer.</param>
	''' <returns><see langword="True"/> if the first pointer points to a lower or equal address than the second pointer; otherwise, <see langword="False"/>.</returns>
	Public Shared Operator <=(ByVal pointerA As VoidPointer, ByVal pointerB As VoidPointer) As Boolean
		Throw DirectCast(Nothing, Exception)
	End Operator

	''' <summary>
	''' Compares if one pointer is greater than or equal to another pointer.
	''' </summary>
	''' <param name="pointerA">The first pointer.</param>
	''' <param name="pointerB">The second pointer.</param>
	''' <returns><see langword="True"/> if the first pointer points to a higher or equal address than the second pointer; otherwise, <see langword="False"/>.</returns>
	Public Shared Operator >=(ByVal pointerA As VoidPointer, ByVal pointerB As VoidPointer) As Boolean
		Throw DirectCast(Nothing, Exception)
	End Operator

#End Region

#Region "Operators: Conversion"
	' ###################################################################
	' #                                                                 #
	' # Operators: Conversion                                           #
	' #                                                                 #
	' ###################################################################

	''' <summary>
	''' Converts a <see cref="VoidPointer"/> to an <see cref="IntPtr"/> representing the same memory address.
	''' </summary>
	''' <param name="pointer">The pointer to convert.</param>
	''' <returns>An <see cref="IntPtr"/> representing the same memory address as <paramref name="pointer"/>.</returns>
	Public Shared Widening Operator CType(ByVal pointer As VoidPointer) As IntPtr
		Throw DirectCast(Nothing, Exception)
	End Operator

	''' <summary>
	''' Converts a <see cref="UIntPtr"/> to a <see cref="VoidPointer"/> representing the same memory address.
	''' </summary>
	''' <param name="pointer">The pointer to convert.</param>
	''' <returns>A <see cref="VoidPointer"/> representing the same memory address as <paramref name="pointer"/>.</returns>
	Public Shared Widening Operator CType(ByVal pointer As IntPtr) As VoidPointer
		Throw DirectCast(Nothing, Exception)
	End Operator

	''' <summary>
	''' Converts a <see cref="VoidPointer"/> to an <see cref="UIntPtr"/> representing the same memory address.
	''' </summary>
	''' <param name="pointer">The pointer to convert.</param>
	''' <returns>An <see cref="UIntPtr"/> representing the same memory address as <paramref name="pointer"/>.</returns>
	Public Shared Widening Operator CType(ByVal pointer As VoidPointer) As UIntPtr
		Throw DirectCast(Nothing, Exception)
	End Operator

	''' <summary>
	''' Converts a <see cref="IntPtr"/> to a <see cref="VoidPointer"/> representing the same memory address.
	''' </summary>
	''' <param name="pointer">The pointer to convert.</param>
	''' <returns>A <see cref="VoidPointer"/> representing the same memory address as <paramref name="pointer"/>.</returns>
	Public Shared Widening Operator CType(ByVal pointer As UIntPtr) As VoidPointer
		Throw DirectCast(Nothing, Exception)
	End Operator

#End Region

End Structure
