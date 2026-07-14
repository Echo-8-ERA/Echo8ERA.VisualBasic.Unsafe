Imports Echo8ERA.VisualBasic.Unsafe

Namespace Global.RefStructProxies.System

	''' <summary>
	''' Span represents a contiguous region of arbitrary memory. Unlike arrays, it can point to either managed
	''' or native memory, or to memory allocated on the stack. It is type-safe and memory-safe.
	''' </summary>
	Public Structure Span(Of T)
		Implements IStackOnlyStructure

#Region "Fields"
		' ###################################################################
		' #                                                                 #
		' # Fields                                                          #
		' #                                                                 #
		' ###################################################################

		''' <summary>A byref or a native ptr.</summary>
		Private m_Reference As Reference(Of T)
		''' <summary>The number of elements this Span contains.</summary>
		Private m_Length As Integer 

#End Region

#Region "Constructors"
		' ###################################################################
		' #                                                                 #
		' # Constructors                                                    #
		' #                                                                 #
		' ###################################################################

		''' <summary>
		''' Creates a new span over the entirety of the target array.
		''' </summary>
		''' <param name="array">The target array.</param>
		''' <remarks>Returns default when <paramref name="array"/> is null.</remarks>
		''' <exception cref="ArrayTypeMismatchException">
		''' Thrown when <paramref name="array"/> is covariant and array's type is not exactly T[].
		''' </exception>
		Public Sub New(ByVal array As T())
			Throw DirectCast(Nothing, Exception)
		End Sub

		''' <summary>
		''' Creates a new span over the portion of the target array beginning
		''' at 'start' index and ending at 'end' index (exclusive).
		''' </summary>
		''' <param name="array">The target array.</param>
		''' <param name="start">The zero-based index at which to begin the span.</param>
		''' <param name="length">The number of items in the span.</param>
		''' <remarks>Returns default when <paramref name="array"/> is null.</remarks>
		''' <exception cref="ArrayTypeMismatchException">
		''' Thrown when <paramref name="array"/> is covariant and array's type is not exactly T[].
		''' </exception>
		''' <exception cref="ArgumentOutOfRangeException">
		''' Thrown when the specified <paramref name="start"/> or end index is not in the range (&lt;0 or &gt;Length).
		''' </exception>
		Public Sub New(ByVal array As T(), ByVal start As Integer, ByVal length As Integer)
			Throw DirectCast(Nothing, Exception)
		End Sub

		''' <summary>
		''' Creates a new span over the target unmanaged buffer. Clearly this
		''' is quite dangerous, because we are creating arbitrarily typed T's
		''' out of a VoidPointer-typed block of memory. And the length is not checked.
		''' But if this creation is correct, then all subsequent uses are correct.
		''' </summary>
		''' <param name="pointer">An unmanaged pointer to memory.</param>
		''' <param name="length">
		''' The number of <typeparamref name="T"/> elements the memory contains.
		''' </param>
		''' <exception cref="ArgumentException">
		''' Thrown when <typeparamref name="T"/> is reference type or contains pointers
		''' and hence cannot be stored in unmanaged memory.
		''' </exception>
		''' <exception cref="ArgumentOutOfRangeException">
		''' Thrown when the specified <paramref name="length"/> is negative.
		''' </exception>
		Public Sub New(<NoTransform> ByVal pointer As VoidPointer, ByVal length As Integer)
			Throw DirectCast(Nothing, Exception)
		End Sub

		''' <summary>
		''' Creates a new <see cref="Span(Of T)"/> of length 1 around the specified reference.
		''' </summary>
		''' <param name="reference">A reference to data.</param>
		Public Sub New(ByRef reference As T)
			Throw DirectCast(Nothing, Exception)
		End Sub

		''' <summary>
		''' Constructor for internal use only. It is not safe to expose publicly,
		''' and is instead exposed via the unsafe MemoryMarshal.CreateSpan.
		''' </summary>
		Friend Sub New(ByRef reference As Reference(Of T), length As Integer)
			Throw DirectCast(Nothing, Exception)
		End Sub

#End Region

#Region "Properties"
		' ###################################################################
		' #                                                                 #
		' # Properties                                                      #
		' #                                                                 #
		' ###################################################################

		''' <summary>
		''' Returns a reference to specified element of the Span.
		''' </summary>
		''' <param name="index">The zero-based index.</param>
		''' <returns></returns>
		''' <exception cref="IndexOutOfRangeException">
		''' Thrown when index less than 0 or index greater than or equal to Length
		''' </exception>
		Default Public ReadOnly Property Item(index As Integer) As Reference(Of T)
			Get
				Throw DirectCast(Nothing, Exception)
			End Get
		End Property

		''' <summary>
		''' The number of items in the span.
		''' </summary>
		Public ReadOnly Property Length As Integer
			Get
				Throw DirectCast(Nothing, Exception)
			End Get
		End Property

		''' <summary>
		''' Gets a value indicating whether this <see cref="Span(Of T)"/> is empty.
		''' </summary>
		''' <value>
		''' <see langword="True"/> if this span is empty; otherwise, <see langword="False"/>.
		''' </value>
		Public ReadOnly Property IsEmpty As Boolean
			Get
				Throw DirectCast(Nothing, Exception)
			End Get
		End Property

		''' <summary>
		''' Returns an empty <see cref="Span(Of T)"/>
		''' </summary>
		Public Shared ReadOnly Property Empty As Span(Of T)
			Get
				Throw DirectCast(Nothing, Exception)
			End Get
		End Property

#End Region

#Region "Operators: Comparison"
		' ###################################################################
		' #                                                                 #
		' # Operators: Comparison                                           #
		' #                                                                 #
		' ###################################################################

		''' <summary>
		''' Returns false if left and right point at the same memory and have the same length.
		''' Note that this does *not* check to see if the *contents* are equal.
		''' </summary>
		Public Shared Operator <>(ByVal left As Span(Of T), ByVal right As Span(Of T)) As Boolean
			Throw DirectCast(Nothing, Exception)
		End Operator

		''' <summary>
		''' Returns true if left and right point at the same memory and have the same length.
		''' Note that this does *not* check to see if the *contents* are equal.
		''' </summary>
		Public Shared Operator =(ByVal left As Span(Of T), ByVal right As Span(Of T)) As Boolean
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
		''' Defines an implicit conversion of an array to a <see cref="Span(Of T)"/>
		''' </summary>
		Public Shared Widening Operator CType(ByVal array As T()) As Span(Of T)
			Throw DirectCast(Nothing, Exception)
		End Operator

		''' <summary>
		''' Defines an implicit conversion of a <see cref="ArraySegment(Of T)"/>
		''' to a <see cref="Span(Of T)"/>
		''' </summary>
		Public Shared Widening Operator CType(ByVal segment As ArraySegment(Of T)) As Span(Of T)
			Throw DirectCast(Nothing, Exception)
		End Operator

		''' <summary>
		''' Defines an implicit conversion of a <see cref="Span(Of T)"/>
		''' to a <see cref="ReadOnlySpan(Of T)"/>
		''' </summary>
		Public Shared Widening Operator CType(span As Span(Of T)) As ReadOnlySpan(Of T)
			Throw DirectCast(Nothing, Exception)
		End Operator

#End Region

#Region "Methods"
		' ###################################################################
		' #                                                                 #
		' # Methods                                                         #
		' #                                                                 #
		' ###################################################################

		''' <summary>
		''' This method is not supported as spans cannot be boxed. To compare two spans, use operator==.
		''' </summary>
		''' <exception cref="NotSupportedException">
		''' Always thrown by this method.
		''' </exception>
		Public Overrides Function Equals(ByVal obj As Object) As Boolean
			Throw DirectCast(Nothing, Exception)
		End Function

		''' <summary>
		''' This method is not supported as spans cannot be boxed.
		''' </summary>
		''' <exception cref="NotSupportedException">
		''' Always thrown by this method.
		''' </exception>
		Public Overrides Function GetHashCode() As Integer
			Throw DirectCast(Nothing, Exception)
		End Function

		''' <summary>
		''' Gets an enumerator for this span.
		''' </summary>
		Public Function GetEnumerator() As Enumerator
			Throw DirectCast(Nothing, Exception)
		End Function

		''' <summary>
		''' Returns a reference to the 0th element of the Span. If the Span is empty,
		''' returns null reference. It can be used for pinning and is required to support
		''' the use of span within a fixed statement.
		''' </summary>
		Public Function GetPinnableReference() As Reference(Of T)
			Throw DirectCast(Nothing, Exception)
		End Function

		''' <summary>
		''' Clears the contents of this span.
		''' </summary>
		Public Sub Clear()
			Throw DirectCast(Nothing, Exception)
		End Sub

		''' <summary>
		''' Fills the contents of this span with the given value.
		''' </summary>
		Public Sub Fill(ByVal value As T)
			Throw DirectCast(Nothing, Exception)
		End Sub

		''' <summary>
		''' Copies the contents of this span into destination span. If the source
		''' and destinations overlap, this method behaves as if the original values in
		''' a temporary location before the destination is overwritten.
		''' </summary>
		''' <param name="destination">The span to copy items into.</param>
		''' <exception cref="ArgumentException">
		''' Thrown when the destination Span is shorter than the source Span.
		''' </exception>
		Public Sub CopyTo(ByVal destination As Span(Of T))
			Throw DirectCast(Nothing, Exception)
		End Sub

		''' <summary>
		''' Copies the contents of this span into destination span. If the source
		''' and destinations overlap, this method behaves as if the original values in
		''' a temporary location before the destination is overwritten.
		''' </summary>
		''' <param name="destination">The span to copy items into.</param>
		''' <returns>
		''' If the destination span is shorter than the source span, this method
		''' returns False and no data is written to the destination.
		''' </returns>
		Public Function TryCopyTo(ByVal destination As Span(Of T)) As Boolean
			Throw DirectCast(Nothing, Exception)
		End Function

		''' <summary>
		''' For <see cref="Span(Of Char)"/>, returns a new instance of String that
		''' represents the characters pointed to by the span.
		''' Otherwise, returns a <see cref="String"/> with the name of the type and
		''' the number of elements.
		''' </summary>
		Public Overrides Function ToString() As String
			Throw DirectCast(Nothing, Exception)
		End Function

		''' <summary>
		''' Forms a slice out of the given span, beginning at 'start'.
		''' </summary>
		''' <param name="start">
		''' The zero-based index at which to begin this slice.
		''' </param>
		''' <exception cref="ArgumentOutOfRangeException">
		''' Thrown when the specified <paramref name="start"/> index is not in range
		''' (&lt;0 or &gt;Length).
		''' </exception>
		Public Function Slice(ByVal start As Integer) As Span(Of T)
			Throw DirectCast(Nothing, Exception)
		End Function

		''' <summary>
		''' Forms a slice out of the given span, beginning at 'start', of given length.
		''' </summary>
		''' <param name="start">
		''' The zero-based index at which to begin this slice.
		''' </param>
		''' <param name="length">
		''' The desired length for the slice (exclusive).
		''' </param>
		''' <exception cref="ArgumentOutOfRangeException">
		''' Thrown when the specified <paramref name="start"/> or end index
		''' is not in range (&lt;0 or &gt;Length).
		''' </exception>
		Public Function Slice(ByVal start As Integer, ByVal length As Integer) As Span(Of T)
			Throw DirectCast(Nothing, Exception)
		End Function

		''' <summary>
		''' Copies the contents of this span into a new array. This heap
		''' allocates, so should generally be avoided; however, it is sometimes
		''' necessary to bridge the gap with APIs written in terms of arrays.
		''' </summary>
		Public Function ToArray() As T()
			Throw DirectCast(Nothing, Exception)
		End Function

#End Region

#Region "Inner Types"

		''' <summary>
		''' Enumerates the elements of a <see cref="Span(Of T)"/>.
		''' </summary>
		Public Structure Enumerator
			Implements IEnumerator(Of T), IStackOnlyStructure

			''' <summary>
			''' The span being enumerated.
			''' </summary>
			Private ReadOnly _span As Span(Of T)

			''' <summary>
			''' The next index to yield.
			''' </summary>
			Private _index As Integer

			''' <summary>
			''' Initialize the enumerator.
			''' </summary>
			''' <param name="span">The span to enumerate.</param>
			Friend Sub New(span As Span(Of T))
				Throw DirectCast(Nothing, Exception)
			End Sub

			''' <summary>
			''' Advances the enumerator to the next element of the span.
			''' </summary>
			Public Function MoveNext() As Boolean Implements IEnumerator(Of T).MoveNext
				Throw DirectCast(Nothing, Exception)
			End Function

			''' <summary>
			''' Gets the element at the current position of the enumerator.
			''' </summary>
			Public ReadOnly Property Current As Reference(Of T)
				Get
					Throw DirectCast(Nothing, Exception)
				End Get
			End Property

			''' <inheritdoc />
			Private ReadOnly Property IEnumerator_Of_T_Current As T _
					Implements IEnumerator(Of T).Current
				Get
					Throw DirectCast(Nothing, Exception)
				End Get
			End Property

			''' <inheritdoc />
			Private ReadOnly Property IEnumerator_Current As Object _
					Implements IEnumerator.Current
				Get
					Throw DirectCast(Nothing, Exception)
				End Get
			End Property

			''' <inheritdoc />
			Private Sub Reset() Implements IEnumerator.Reset
				Throw DirectCast(Nothing, Exception)
			End Sub

			''' <inheritdoc />
			Private Sub Dispose() Implements IDisposable.Dispose
				Throw DirectCast(Nothing, Exception)
			End Sub

		End Structure
	
#End Region

	End Structure
	
End Namespace
