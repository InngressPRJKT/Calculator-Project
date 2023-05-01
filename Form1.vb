Public Class Form1

    Dim dFirstValue As Double
    Dim dSecondValue As Double
    Dim dResult As Double
    Dim op As String

    Private Sub clickNumber(sender As Object, e As EventArgs) Handles Button6.Click, Button7.Click, Button8.Click, Button10.Click, Button11.Click, Button12.Click, Button16.Click, Button17.Click, Button18.Click, Button19.Click, Button15.Click

        Dim b As Button = sender

        If (textDisplay.Text = "0") Then
            textDisplay.Text = ""
            textDisplay.Text = b.Text

        ElseIf (b.Text = ".") Then
            If (Not textDisplay.Text.Contains(".")) Then
                textDisplay.Text = textDisplay.Text + b.Text
            End If
        Else
            textDisplay.Text = textDisplay.Text + b.Text

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (textDisplay.Text.Length > 0) Then
            textDisplay.Text = textDisplay.Text.Remove(textDisplay.Text.Length - 1, 1)
        End If

        If (textDisplay.Text = "") Then
            textDisplay.Text = "0"
        End If
    End Sub

    Private Sub clickOperator(sender As Object, e As EventArgs) Handles Button5.Click, Button9.Click, Button13.Click, Button20.Click

        Dim b As Button = sender
        dFirstValue = textDisplay.Text
        op = b.Text
        textDisplay.Text = ""


    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        dSecondValue = textDisplay.Text
        If op = "+" Then
            dResult = dFirstValue + dSecondValue
            textDisplay.Text = dResult
        ElseIf op = "-" Then
            dResult = dFirstValue - dSecondValue
            textDisplay.Text = dResult
        ElseIf op = "*" Then
            dResult = dFirstValue * dSecondValue
            textDisplay.Text = dResult
        ElseIf op = "/" Then
            dResult = dFirstValue / dSecondValue
            textDisplay.Text = dResult
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If (textDisplay.Text.Contains("-")) Then
            textDisplay.Text = textDisplay.Text.Remove(0, 1)
        Else
            textDisplay.Text = "-" + textDisplay.Text
        End If


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        textDisplay.Text = "0"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        textDisplay.Text = "0"
    End Sub
End Class
