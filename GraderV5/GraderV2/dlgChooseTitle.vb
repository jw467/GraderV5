Imports System.Windows.Forms

Public Class dlgChooseTitle

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub ChooseTitle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim mUniqueList As New List(Of String)
        Dim aRow As DataRow
        Dim ds As DataSet = MainForm.ReadDataset
        If ds.Tables.Count > 0 Then
            For Each aRow In ds.Tables("Module").Rows
                If Not mUniqueList.Contains(aRow.Item(0).ToString) Then
                    mUniqueList.Add(aRow.Item(0).ToString)
                End If
            Next
            Dim title As String
            For Each title In mUniqueList
                cbxChooseTitle.Items.Add(title)
            Next
        Else
            MessageBox.Show("no modules found")
            Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.Close()
        End If
    End Sub

End Class
