Imports System

Module factorial
    Sub Main(args As String())
        Dim N As Integer, F As Integer = 1
        Console.Write("� ������ ���������. ������� ����� �����: N= ")
        N = Console.ReadLine
        For i As Integer = 1 To N
            If F <= Integer.MaxValue / i Then
                F = F * i
            Else
                Console.WriteLine("������������ ������! ������ �������� ��� N={0}", i - 1)
                Exit For
            End If
        Next
        Console.WriteLine("N! = {0}", F)
    End Sub
End Module
