''' <summary>
''' Represents a typed pointer to a memory address.
''' </summary>
<NoTransform>
Public Structure Pointer(Of T)
	Private m_Address As IntPtr

#Region "Operators: Arithmetic"
	' ###################################################################
	' #                                                                 #
	' # Operators: Arithmetic                                           #
	' #                                                                 #
	' ###################################################################

	''' <summary>
	''' Adds an offset to a pointer and returns a new pointer with the updated address.
	''' </summary>
	''' <param name="pointer">The pointer to offset.</param>
	''' <param name="offset">The number of bytes to offset the pointer by.</param>
	''' <returns>The updated, offsetted pointer.</returns>
	Public Shared Operator +(ByVal pointer As Pointer(Of T), ByVal offset As Integer) As Pointer(Of T)
		Throw DirectCast(Nothing, Exception)
	End Operator

	''' <summary>
	''' Adds an offset to a pointer and returns a new pointer with the updated address.
	''' </summary>
	''' <param name="pointer">The pointer to offset.</param>
	''' <param name="offset">The number of bytes to offset the pointer by.</param>
	''' <returns>The updated, offsetted pointer.</returns>
	Public Shared Operator +(ByVal offset As Integer, ByVal pointer As Pointer(Of T)) As Pointer(Of T)
		Throw DirectCast(Nothing, Exception)
	End Operator

	''' <summary>
	''' Subtracts an offset from a pointer and returns a new pointer with the updated address.
	''' </summary>
	''' <param name="pointer">The pointer to offset.</param>
	''' <param name="offset">The number of bytes to offset the pointer by.</param>
	''' <returns>The updated, offsetted pointer.</returns>
	Public Shared Operator -(ByVal pointer As Pointer(Of T), ByVal offset As Integer) As Pointer(Of T)
		Throw DirectCast(Nothing, Exception)
	End Operator

	''' <summary>
	''' Subtracts one pointer from another and returns the difference in <see cref="SizeOf(Of T)"/> bytes between the two pointers.
	''' </summary>
	''' <param name="pointerA">The first pointer.</param>
	''' <param name="pointerB">The second pointer.</param>
	''' <returns>The number of <typeparamref name="T"/> elements between the two pointers.</returns>
	Public Shared Operator -(ByVal pointerA As Pointer(Of T), ByVal pointerB As Pointer(Of T)) As Integer
		Throw DirectCast(Nothing, Exception)
	End Operator

#End Region

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
	Public Shared Operator =(ByVal pointerA As Pointer(Of T), ByVal pointerB As Pointer(Of T)) As Boolean
		Throw DirectCast(Nothing, Exception)
	End Operator

	''' <summary>
	''' Compares two pointers for inequality.
	''' </summary>
	''' <param name="pointerA">The first pointer.</param>
	''' <param name="pointerB">The second pointer.</param>
	''' <returns><see langword="True"/> if the two pointers point to different addresses; otherwise, <see langword="False"/>.</returns>
	Public Shared Operator <>(ByVal pointerA As Pointer(Of T), ByVal pointerB As Pointer(Of T)) As Boolean
		Throw DirectCast(Nothing, Exception)
	End Operator

	''' <summary>
	''' Compares if one pointer is less than another pointer.
	''' </summary>
	''' <param name="pointerA">The first pointer.</param>
	''' <param name="pointerB">The second pointer.</param>
	''' <returns><see langword="True"/> if the first pointer points to a lower address than the second pointer; otherwise, <see langword="False"/>.</returns>
	Public Shared Operator <(ByVal pointerA As Pointer(Of T), ByVal pointerB As Pointer(Of T)) As Boolean
		Throw DirectCast(Nothing, Exception)
	End Operator

	''' <summary>
	''' Compares if one pointer is greater than another pointer.
	''' </summary>
	''' <param name="pointerA">The first pointer.</param>
	''' <param name="pointerB">The second pointer.</param>
	''' <returns><see langword="True"/> if the first pointer points to a higher address than the second pointer; otherwise, <see langword="False"/>.</returns>
	Public Shared Operator >(ByVal pointerA As Pointer(Of T), ByVal pointerB As Pointer(Of T)) As Boolean
		Throw DirectCast(Nothing, Exception)
	End Operator

	''' <summary>
	''' Compares if one pointer is less than or equal to another pointer.
	''' </summary>
	''' <param name="pointerA">The first pointer.</param>
	''' <param name="pointerB">The second pointer.</param>
	''' <returns><see langword="True"/> if the first pointer points to a lower or equal address than the second pointer; otherwise, <see langword="False"/>.</returns>
	Public Shared Operator <=(ByVal pointerA As Pointer(Of T), ByVal pointerB As Pointer(Of T)) As Boolean
		Throw DirectCast(Nothing, Exception)
	End Operator

	''' <summary>
	''' Compares if one pointer is greater than or equal to another pointer.
	''' </summary>
	''' <param name="pointerA">The first pointer.</param>
	''' <param name="pointerB">The second pointer.</param>
	''' <returns><see langword="True"/> if the first pointer points to a higher or equal address than the second pointer; otherwise, <see langword="False"/>.</returns>
	Public Shared Operator >=(ByVal pointerA As Pointer(Of T), ByVal pointerB As Pointer(Of T)) As Boolean
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
	''' Converts a typed <see cref="Pointer(Of T)"/> to a <see cref="VoidPointer"/> representing the same memory address.
	''' </summary>
	''' <param name="pointer">The pointer to convert.</param>
	''' <returns>A <see cref="VoidPointer"/> representing the same memory address as <paramref name="pointer"/>.</returns>
	Public Shared Widening Operator CType(ByVal pointer As Pointer(Of T)) As VoidPointer
		Throw DirectCast(Nothing, Exception)
	End Operator

	''' <summary>
	''' Converts an untyped <see cref="VoidPointer"/> to a typed <see cref="Pointer(Of T)"/> representing the same memory address.
	''' </summary>
	''' <param name="pointer">The pointer to convert.</param>
	''' <returns>A <see cref="Pointer(Of T)"/> representing the same memory address as <paramref name="pointer"/>.</returns>
	Public Shared Narrowing Operator CType(ByVal pointer As VoidPointer) As Pointer(Of T)
		Throw DirectCast(Nothing, Exception)
	End Operator

	''' <summary>
	''' Converts a typed <see cref="Pointer(Of T)"/> to a <see cref="IntPtr"/> representing the same memory address.
	''' </summary>
	''' <param name="pointer">The pointer to convert.</param>
	''' <returns>A <see cref="IntPtr"/> representing the same memory address as <paramref name="pointer"/>.</returns>
	Public Shared Widening Operator CType(ByVal pointer As Pointer(Of T)) As IntPtr
		Throw DirectCast(Nothing, Exception)
	End Operator

	''' <summary>
	''' Converts an untyped <see cref="IntPtr"/> to a typed <see cref="Pointer(Of T)"/> representing the same memory address.
	''' </summary>
	''' <param name="pointer">The pointer to convert.</param>
	''' <returns>A <see cref="Pointer(Of T)"/> representing the same memory address as <paramref name="pointer"/>.</returns>
	Public Shared Narrowing Operator CType(ByVal pointer As IntPtr) As Pointer(Of T)
		Throw DirectCast(Nothing, Exception)
	End Operator

	''' <summary>
	''' Converts a typed <see cref="Pointer(Of T)"/> to a <see cref="UIntPtr"/> representing the same memory address.
	''' </summary>
	''' <param name="pointer">The pointer to convert.</param>
	''' <returns>A <see cref="UIntPtr"/> representing the same memory address as <paramref name="pointer"/>.</returns>
	Public Shared Widening Operator CType(ByVal pointer As Pointer(Of T)) As UIntPtr
		Throw DirectCast(Nothing, Exception)
	End Operator

	''' <summary>
	''' Converts an untyped <see cref="UIntPtr"/> to a typed <see cref="Pointer(Of T)"/> representing the same memory address.
	''' </summary>
	''' <param name="pointer">The pointer to convert.</param>
	''' <returns>A <see cref="Pointer(Of T)"/> representing the same memory address as <paramref name="pointer"/>.</returns>
	Public Shared Narrowing Operator CType(ByVal pointer As UIntPtr) As Pointer(Of T)
		Throw DirectCast(Nothing, Exception)
	End Operator

#End Region

#Region "Indexers"
	' ###################################################################
	' #                                                                 #
	' # Indexers                                                        #
	' #                                                                 #
	' ###################################################################

	''' <summary>
	''' Gets a reference to the value at a specified offset from the memory address of the pointer.
	''' </summary>
	''' <param name="offset">The offset from the memory address of the pointer to get the reference to in <typeparamref name="T"/> units.</param>
	''' <returns>A reference to the value at at the specified offset of the pointer.</returns>
	Public Default ReadOnly Property Item(ByVal offset As Integer) As Reference(Of T)
		Get
			Throw DirectCast(Nothing, Exception)
		End Get
	End Property

#End Region


End Structure
