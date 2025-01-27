'Jacob Horsley
'1/27/25
'RCET 2206


Option Explicit On
Option Strict On


Module ProgramFlowS25


    Sub Main()
        Dim funnyNumber As Integer
        Dim userInput As String

        'Assign number to 5
        funnyNumber = 5

        'test is the number greater than 6
        'display the result on the console
        '(doesn't display because it results in a false)
        If funnyNumber > 6 Then
            Console.WriteLine(funnyNumber > 6)
        End If


        If funnynumber > 3 Then
            Console.WriteLine(funnynumber > 3)
        End If

        If funnynumber > 4 Then
            Console.WriteLine(funnynumber > 4)
        End If


        funnynumber -= 3

        'Due to the else if statement it become an or gate essentially
        If funnynumber > 6 Then
            Console.WriteLine(funnynumber > 6)

        ElseIf funnynumber > 3 Then
            Console.WriteLine(funnynumber > 3)


        ElseIf funnynumber > 4 Then
            Console.WriteLine(funnynumber > 4)
        End If

        'If nothing evaluates true the else will be selected
        If funnyNumber > 6 Then
            Console.WriteLine($"{funnyNumber} is a big number!")

        ElseIf funnyNumber > 3 Then
            Console.WriteLine($"Sorry not tall enough...")
        ElseIf funnyNumber > 4 Then
            Console.WriteLine($"Who cares")
        Else
            Console.WriteLine($"Not sure what happened")
        End If

        'If one is true it skips the rest
        Console.WriteLine("Please enter your age:")
        userInput = Console.ReadLine()
        funnyNumber = CInt(userInput)

        Select Case funnyNumber
            Case 0 To 3

            Case 4 To 10

            Case 11 To 64

            Case 65 To 99

            Case > 100

            Case Else

        End Select
    End Sub

End Module
