Imports System
Imports Microsoft.SmallBasic.Library

Module TestOperationsVB
    Public Function Add(value1 As Double, value2 As Double) As Double
        Return value1 + value2
    End Function
End Module

''' <summary>
''' A test creating an extension
''' The resulting dll and xml can be used in the lib folder as an extension
''' 
''' All functions are public
''' All parameters are Primitive
''' Module attribute is SmallBasicType
''' </summary>
<SmallBasicType()> Public Module TestExtensionVB
    ''' <summary>
    ''' Multiply two numbers
    ''' </summary>
    ''' <param name="value1">First value</param>
    ''' <param name="value2">Second value</param>
    ''' <returns>The product</returns>
    Public Function Multiply(value1 As Primitive, value2 As Primitive) As Primitive
        Return value1 * value2
    End Function
End Module
