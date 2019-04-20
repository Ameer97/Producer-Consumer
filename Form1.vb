Public Class Form1
    Dim stack, take, give As Integer
    Dim stackSzie As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        stack = 0
        stackSzie = InputBox("input stack")
        take = InputBox("input take")
        give = InputBox("input give")


        Dim cases As String = InputBox("Enter the cases 1:Producer & 2:Consumer")
        Dim state As String = ""
        For i = 1 To cases.Length
            state = Mid(cases, i, 1)
            Select Case state

                Case 1 : producer()

                Case 2 : Consumer()

            End Select
        Next



    End Sub
    Function producer()

        If (stack + give) <= stackSzie Then
            stack += give
        Else
            MessageBox.Show("Err oucuered when stack is over flow")
            Application.Exit()
        End If
        MessageBox.Show("producer give " & give & " and the stack=" & stack)


        Return 0
    End Function

    Function Consumer()

        If (stack - take) >= 0 Then
            stack -= take
        Else
            MessageBox.Show("Err oucuered when stack is Empety")
            Application.Exit()
        End If
        MessageBox.Show("Consumer take " & take & " and the stack=" & stack)
        Return 0
    End Function
End Class
