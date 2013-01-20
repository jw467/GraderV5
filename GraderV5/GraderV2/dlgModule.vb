Imports System.Windows.Forms
Imports System.Text.RegularExpressions

Public Class dlgModule

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Dim correctInput As Boolean = False
        Dim regEx As Regex = New Regex("^[AET?]$")
        If tbxYourTitle.Text <> "" AndAlso tbxModName.Text <> "" AndAlso tbxModID.Text <> "" _
        AndAlso regEx.IsMatch(cbx1Type.Text) AndAlso regEx.IsMatch(cbx2Type.Text) Then
            correctInput = True
        End If
        If correctInput Then
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        Else
            MessageBox.Show("All Fields Must Be Entered")
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub nud1Weight_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nud1Weight.ValueChanged
        nud2Weight.Value = 100 - nud1Weight.Value
    End Sub

    Private Sub dlgModule_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
