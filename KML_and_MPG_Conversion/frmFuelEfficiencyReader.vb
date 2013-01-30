''' <summary>
''' Fuel Efficiency Converter
''' frmFuelEfficiancyConverter
''' Willie Driscoll, Nathaniel Morra, Brandon Carter
''' 28 January 2013
''' A Program To Convert KPL to MPG and vise versa
''' </summary>
''' <remarks></remarks>
Public Class frmFuelEfficiencyReader
    ''' <summary>
    ''' When the convert button is clicked, it will convert KPL to MPG and vise versa.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnConvert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConvert.Click
        ' Create constants for conversion values
        Const decKPM As Decimal = 1.61 'kilometers per mile
        Const decGPL As Decimal = 0.264 'Gallons per liter

        ' Create variables to hold MPG and KPL
        Dim decMPG, decKPL As Decimal

        ' Get the MPG value that the user entered on the form
        Try
            decMPG = CDec(txtMPG.Text)
        Catch ex As Exception
            MessageBox.Show("Error: The characters you entered are not a valid decimal number. Please use numbers and decimal points only")
            txtMPG.Clear()
            txtKPL.Clear()
            txtMPG.Focus()
            Return
        End Try

        ' Calculate the KPL based on the MPG value and the constant
        decKPL = decMPG * decKPM * decGPL

        ' Output the results back to the form
        txtKPL.Text = decKPL.ToString

        ' Calculate the MPG based on the KPL value and the constant
        'decMPG = decKPL * decKPM * decGPL

        ' Output the results back to the form
        'txtMPG.Text = decMPG.ToString

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtKPL.Clear()
        txtMPG.Clear()

    End Sub
End Class
