Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim ainp As Double = numA.Text
        Dim binp As Double = numB.Text
        Dim cinp As Double = numC.Text

        Dim disc As Double = binp ^ 2 - 4 * ainp * cinp

        If disc >= 0 Then
            Dim x1 As Double = Math.Round(((-1 * binp) - Math.Sqrt(disc)) / (2 * ainp), 2)
            Dim x2 As Double = Math.Round(((-1 * binp) + Math.Sqrt(disc)) / (2 * ainp), 2)

            lblXoneTop.Text = ((-1 * binp) - Math.Round(Math.Sqrt(disc), 4))
            lblXtwoTOp.Text = ((-1 * binp) + Math.Round(Math.Sqrt(disc), 4))

            lblBottom.Text = 2 * ainp
            lblBottom2.Text = 2 * ainp

            lblResX1.Text = x1
            lblResX2.Text = x2

            lblDiscc.Text = disc

            MessageBox.Show("Discriminant: " & disc & vbNewLine & "X1 = " & x1 & vbNewLine & "X2 = " & x2, "Result", MessageBoxButtons.OK)

        Else
            lblXoneTop.Text = ""
            lblXtwoTOp.Text = ""

            lblBottom.Text = ""
            lblBottom2.Text = ""

            lblResX1.Text = ""
            lblResX2.Text = ""

            lblDiscc.Text = ""
            MessageBox.Show("Discriminant is negative!" + vbNewLine + "The function does not cross the x-axis!", "Error", MessageBoxButtons.OK)
        End If




    End Sub


End Class
