﻿Class IntCalcWindow
    Private Sub TextBox_TextChanged(sender As Object, e As TextChangedEventArgs)

    End Sub

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Dim result As Decimal
        Dim p As Decimal = Decimal.Parse(pInput.Text)
        Dim i As Decimal = Decimal.Parse(iInput.Text)
        Dim days As Decimal = Decimal.Parse(dInput.Text)

        result = p * i / 100 * days / 365


        resultDisplay.Text = "Principal: $" & p & vbCrLf & "Interest Rate: " & i & "%" & vbCrLf & "Days: " & days & vbCrLf &
            "Calculated Interest is $" & Format(result, "##,##0.00")
        REM MessageBox.Show("Interest is $" & result.ToString)
    End Sub
End Class
