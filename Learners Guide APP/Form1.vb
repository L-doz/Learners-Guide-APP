Public Class Form1
    Private Sub ComboBox3_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles Cmbuser.SelectedIndexChanged
        If sender.selectedindex = 0 Then
            Panel2.Visible = True
            Panel1.Visible = False
        ElseIf sender.selectedindex = 1 Then
            Panel2.Visible = False
            Panel1.Visible = True
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim A As New Form2
        A.Show()
        Dim i As Integer
        Dim lname As String
        If txtlname.Text <> "" Then

            lname = ((txtlname.Text).Trim).ToUpper

            For i = 0 To lname.Length - 1

                Select Case lname.Substring(i, 1)

                    Case "A" To "Z", " "

                    Case Else

                        MsgBox("Invalid characters in learner name")

                        Exit Sub

                End Select

            Next

            MsgBox("correct characters")



        Else

            MsgBox("learner name not input")
        End If
        Dim j As Integer

        Dim surname As String

        If txtlsurname.Text <> "" Then

            surname = ((txtlsurname.Text).Trim).ToUpper

            For j = 0 To surname.Length - 1

                Select Case surname.Substring(j, 1)

                    Case "A" To "Z", " "

                    Case Else

                        MsgBox("Invalid characters in surname")

                        Exit Sub

                End Select

            Next

            MsgBox("correct characters")



        Else

            MsgBox("learner's surname not input")
        End If
        Dim f As Integer
        Dim stuffname As String
        If txtsname.Text <> "" Then

            stuffname = ((txtsname.Text).Trim).ToUpper

            For i = 0 To stuffname.Length - 1

                Select Case stuffname.Substring(i, 1)

                    Case "A" To "Z", " "

                    Case Else

                        MsgBox("Invalid characters in stuff name")

                        Exit Sub

                End Select

            Next

            MsgBox("correct characters")



        Else

            MsgBox("stuff name not input")
        End If
        Dim g As Integer

        Dim stuffsurname As String

        If txtlsurname.Text <> "" Then

            stuffsurname = ((txtlsurname.Text).Trim).ToUpper

            For g = 0 To stuffsurname.Length - 1

                Select Case stuffsurname.Substring(g, 1)

                    Case "A" To "Z", " "

                    Case Else

                        MsgBox("Invalid characters in stuff surname")

                        Exit Sub

                End Select

            Next

            MsgBox("correct characters")



        Else

            MsgBox("stuff surname not input")
        End If
    End Sub
End Class
