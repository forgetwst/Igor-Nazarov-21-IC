Imports System
Module homework2
    Sub Main(args As String())
        Dim N As Integer, F As Integer = 1
        Console.Write("� ������ ������������ �����! ������� �����:")
        Do
            N = Console.ReadLine
            F = F * N
        Loop Until N = 1
        Console.WriteLine("������������ = {0}", F)

    End Sub
End Module
