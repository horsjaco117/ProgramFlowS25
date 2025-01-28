﻿'Jacob Horsley
'1/27/25
'RCET 2206


Option Explicit On
Option Strict On
Option Compare Text

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

        Do
            'If one is true it skips the rest
            Console.WriteLine("Please enter your age:")
            userInput = Console.ReadLine()
            Try
                funnyNumber = CInt(userInput)

                Select Case funnyNumber
                    Case 0 To 3
                        Console.WriteLine("Where are your parents?")
                    Case 4 To 10
                        Console.WriteLine("Sorry kid, why don't you try the tea cups...?")
                    Case 11 To 64
                        Console.WriteLine("Enjoy the ride")
                    Case 65 To 99
                        Console.WriteLine("Please sign this liability release form.")
                    Case > 100
                        Console.WriteLine("Someone misplaced their meemah!")
                    Case Else
                        Console.WriteLine("No beans")
                End Select

            Catch ex As Exception
                Console.WriteLine($"You entered {userInput}.")

            End Try


        Loop Until userInput = "Q"
        Console.WriteLine("Have a nice day!")

    End Sub

End Module
