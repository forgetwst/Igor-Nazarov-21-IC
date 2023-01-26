Imports System

Module Coas
    Sub Main(args As String())
        Dim number, ver As String
        'TOOO: генерируем число
        number = "1234"
        Console.WriteLine("Угадай число")
        Do
            ver = Console.ReadLine()
            For i = 0 To 3
                If i = 0 Then
                    Console.WriteLine("Первая цифра вашей версии = бык")
                Else
                    Console.WriteLine("Первая цифра вашей версии = корова")
                End If
                End If
            Next
        Loop Until number = ver
    End Sub
End Module
