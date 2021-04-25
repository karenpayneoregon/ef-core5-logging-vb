Imports System.Collections.Generic
Imports System.IO
Imports Newtonsoft.Json

Namespace Extensions

    Public Module GenericExtensions
        ''' <summary>
        ''' Format indent
        ''' Prevent Self referencing loop detected
        ''' https://www.newtonsoft.com/json/help/html/ReferenceLoopHandlingIgnore.htm
        ''' </summary>
        Private Function SettingsIgnoreReferenceLooping() As JsonSerializerSettings

            Return New JsonSerializerSettings With {
                    .Formatting = Formatting.Indented,
                    .ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                }

        End Function
        ''' <summary>
        ''' Format indent
        ''' </summary>
        ''' <returns></returns>
        Private Function SettingsDefault() As JsonSerializerSettings
            Return New JsonSerializerSettings With {.Formatting = Formatting.Indented}
        End Function

        ''' <summary>
        ''' Convert <see cref="TModel"/> to json file
        ''' </summary>
        ''' <typeparam name="TModel"></typeparam>
        ''' <param name="list"></param>
        ''' <param name="fileName"></param>
        <Runtime.CompilerServices.Extension>
        Public Sub ModeListToJson(Of TModel)(ByVal list As List(Of TModel), ByVal fileName As String)

            JsonConvert.DefaultSettings = AddressOf SettingsIgnoreReferenceLooping
            File.WriteAllText(fileName, JsonConvert.SerializeObject(list))

        End Sub
        ''' <summary>
        ''' Determine if a value is between two values
        ''' </summary>
        ''' <typeparam name="T">Type</typeparam>
        ''' <param name="value">Value to determine if between lowerValue and upperValue</param>
        ''' <param name="lowerValue">Lower value</param>
        ''' <param name="upperValue">Upper value</param>
        ''' <returns>True if Value is between lowerValue and upperValue</returns>
        <Runtime.CompilerServices.Extension>
        Public Function Between(Of T As {Structure, IComparable(Of T)})(value As T, lowerValue As T, upperValue As T) As Boolean
            Return Comparer(Of T).Default.Compare(value, lowerValue) >= 0 AndAlso Comparer(Of T).Default.Compare(value, upperValue) <= 0
        End Function
    End Module
End Namespace