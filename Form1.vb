Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Btn_Click(sender As Object, e As EventArgs) Handles btn_cl.Click
        Dim taille = lstTaille.SelectedItem.ToString()
        MessageBox.Show(taille)
        Dim ingredient As String = ""
        If rdProp1.Checked Then
            ingredient = "croute farine"
        ElseIf rdProp2.Checked Then
            ingredient = "croute classique"
        ElseIf rdProp3.Checked Then
            ingredient = "croute epaisse"
        End If
        Dim ingrSupp As String
        If ChkProp1.Checked Then
            ingrSupp = ingrSupp + "champion"
        ElseIf ChkProp2.Checked Then
            ingrSupp = ingrSupp + "oliviers"
        ElseIf ChkProp3.Checked Then
            ingrSupp = ingrSupp + "poivrons"
        ElseIf ChkProp4.Checked Then
            ingrSupp = ingrSupp + "fromage supplimentaire"
        End If
        Dim msg As String = "taille :" + taille + "type decimal croute :" + ingredient + " ingredient supplementaires"
        MessageBox.Show(msg)




    End Sub
End Class
