Module homework8
    Sub Main(args As String())
        Dim N, ver As String
        Dim bulls, cows As Integer

        'TODO:Генерируем число

        N = 1234

        Do

            ver = Console.ReadLine()
            Console.WriteLine(CheckDublicates(N))
            cows = 0
            bulls = 0

            For j As Byte = 0 To 3
                For i As Byte = 0 To 3
                    If (N.Chars(i) = ver.Chars(j)) Then
                        If i = j Then
                            bulls += 1
                        Else
                            cows += 1
                        End If
                    End If
                Next
            Next

            Console.WriteLine("количество коров = {0}", cows)
            Console.WriteLine("количество быков = {0}", bulls)

        Loop Until N = ver

        Console.WriteLine("Victory")

    End Sub

    Function CheckDublicates(Num As String) As Boolean
        CheckDublicates = False

        For j = 0 To 2
            For i = 1 To 3
                If Num.Chars(j) = Num.Chars(i) Then
                    CheckDublicates = True
                End If
            Next
        Next

    End Function

End Module