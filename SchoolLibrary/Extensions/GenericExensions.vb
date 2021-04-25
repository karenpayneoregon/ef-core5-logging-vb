Imports System.Collections.Generic
Imports System.IO
Imports Newtonsoft.Json

Namespace Extensions

    Public Module GenericExtensions
        ''' <summary>
        ''' Format indent
        ''' Prevent Self referencing loop detected
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

    End Module
End Namespace