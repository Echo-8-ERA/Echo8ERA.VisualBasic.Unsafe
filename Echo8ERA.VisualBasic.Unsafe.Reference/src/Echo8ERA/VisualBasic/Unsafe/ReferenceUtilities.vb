
Module ReferenceUtilities

	''' <summary>
	''' Gets a reference to a variable.
	''' </summary>
	''' <param name="var">The variable to get a reference to.</param>
	''' <returns>A reference to the variable <paramref name="var"/>.</returns>
	Public Function VarRef(Of T)(ByRef var As T) As <NoTransform>Reference(Of T)
		Throw DirectCast(Nothing, Exception)
	End Function

	''' <summary>
	''' Dereferences a typed reference and returns a reference to the value at that address.
	''' </summary>
	''' <param name="reference">The reference to dereference.</param>
	''' <returns>A reference to the value at the address of <paramref name="reference"/>.</returns>
	Public Function DeRef(Of T)(<NoTransform> ByVal reference As Reference(Of T)) As Reference(Of T)
		Throw DirectCast(Nothing, Exception)
	End Function

	''' <summary>
	''' Allows a reference to be assigned new target.
	''' </summary>
	''' <param name="reference">The reference to change.</param>
	''' <returns>A reference to the reference allowing it to be used on the left-hand side of an assignment.</returns>
	Public Function [Set](Of T)(<NoTransform> ByVal reference As Reference(Of T)) As <NoTransform(Depth:=1)> Reference(Of Reference(Of T))
		Throw DirectCast(Nothing, Exception)
	End Function

End Module
