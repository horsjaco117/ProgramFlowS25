'Jacob Horsley
'1/27/25
'RCET 2206


Option Explicit On
Option Strict On


Module ProgramFlowS25


    Sub Main()
        Dim funnynumber As Integer

        'Assign number to 5
        funnynumber = 5

        'test is the number greater than 6
        'display the result on the console
        '(doesn't display because it results in a false)
        If funnynumber > 6 Then
            Console.WriteLine(funnynumber > 6)
        End If


        If funnynumber > 3 Then
            Console.WriteLine(funnynumber > 3)
        End If

        If funnynumber > 4 Then
            Console.WriteLine(funnynumber > 4)
        End If



        'Due to the else if statement it become an or gate essentially
        If funnynumber > 6 Then
            Console.WriteLine(funnynumber > 6)

        ElseIf funnynumber > 3 Then
            Console.WriteLine(funnynumber > 3)


        ElseIf funnynumber > 4 Then
            Console.WriteLine(funnynumber > 4)
        End If


    End Sub

End Module
