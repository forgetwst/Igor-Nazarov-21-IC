Imports System
Module classwork3
    Sub Main(args As String())
        Dim s As String
        Dim counter As Integer = 0
        Console.WriteLine("������� �������:")
        s = Console.ReadLine()

        For i = 0 To s.Length - 1
            Console.Write(s.Chars(i))
            Console.WriteLine(Asc(s.Chars(i)))

            If Asc(s.Chars(i)) = 32 Then
                counter = counter + 1
            End If

        Next

        Console.WriteLine("� ������� {0} �������� ", counter)
    End Sub
End Module
