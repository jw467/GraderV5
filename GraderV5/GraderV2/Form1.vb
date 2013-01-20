Imports System.Xml

Public Class MainForm

    Private DS As New DataSet
    Private currentTitle As String
    Private tbxName(5) As TextBox
    Private tbxID(5) As TextBox
    Private tbx1Type(5) As TextBox
    Private tbx1Per(5) As TextBox
    Private tbx1Mark(5) As TextBox
    Private tbx2Type(5) As TextBox
    Private tbx2Per(5) As TextBox
    Private tbx2Mark(5) As TextBox
    Private tbxGrade(5) As TextBox

    Private Sub MainForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim dt As DataTable = New DataTable("Module")
        dt.Columns.Add("Year_Title", Type.GetType("System.String"))
        dt.Columns.Add("Mod_Name", Type.GetType("System.String"))
        dt.Columns.Add("Mod_ID", Type.GetType("System.String"))
        dt.Columns.Add("Test1_Type", Type.GetType("System.String"))
        dt.Columns.Add("Test1_Weight", Type.GetType("System.Int32"))
        dt.Columns.Add("Test1_Mark", Type.GetType("System.Int32"))
        dt.Columns.Add("Test2_Type", Type.GetType("System.String"))
        dt.Columns.Add("Test2_Weight", Type.GetType("System.Int32"))
        dt.Columns.Add("Test2_Mark", Type.GetType("System.Int32"))
        dt.Columns.Add("Grade", Type.GetType("System.Int32"))
        If System.IO.File.Exists("grades.xml") Then
            Dim xmlFile As XmlReader
            xmlFile = XmlReader.Create("grades.xml", New XmlReaderSettings())
            DS.ReadXml(xmlFile)
            xmlFile.Close()
        Else
            DS.Tables.Add(dt)
            DS.Tables(0).TableName = "Module"
            EnterData()
            DS.WriteXml("grades.xml")
        End If
        AddControls()
    End Sub

    Private Sub EnterData()
        '' Enter your Data here (optional) '' Need min of 1 row to produce XML file and dataset sync
        fillRows("Russ Year 2 Test", "Computer Networks", "MCOMD2CNE", "A", 40, 71, "E", 60, 0)
        fillRows("Russ Year 2 Test", "Database Development", "MCOMD2DAD", "A", 50, 83, "A", 50, 87)
        fillRows("Russ Year 2 Test", "Interactive Web Programming", "MCOMD2WEB", "T", 40, 56, "A", 60, 0)
        fillRows("Russ Year 2 Test", "Operating Systems", "MCOMD2SYS", "A", 50, 87, "T", 50, 0)
        fillRows("Russ Year 2 Test", "Programming 1", "MCOMD2PRG", "A", 50, 0, "E", 50, 0)
        fillRows("Russ Year 2 Test", "Systems Analysis and Design", "MCOMD2SAD", "A", 50, 0, "E", 50, 0)
        'fillRows("Test", "Test Module", "Test ID", "?", 0, 0, "?", 0, 0) '' Test Data
    End Sub

    Private Sub fillRows(ByVal pTitle As String, ByVal pName As String, ByVal pID As String, ByVal pType1 As String, ByVal pWeight1 As Integer, _
                        ByVal pMark1 As Integer, ByVal pType2 As String, ByVal pWeight2 As Integer, ByVal pMark2 As Integer)
        Dim dr As DataRow = DS.Tables("Module").NewRow()
        dr("Year_Title") = pTitle
        dr("Mod_Name") = pName
        dr("Mod_ID") = pID
        dr("Test1_Type") = pType1
        dr("Test1_Weight") = pWeight1
        dr("Test1_Mark") = pMark1
        dr("Test2_Type") = pType2
        dr("Test2_Weight") = pWeight2
        dr("Test2_Mark") = pMark2
        dr("Grade") = ((pWeight1 * (pMark1 / 100)) + (pWeight2 * (pMark2 / 100)))
        DS.Tables("Module").Rows.Add(dr)
    End Sub

    Private Sub AddControls()
        Dim top As Integer = 54
        For i As Integer = 0 To 5
            tbxName(i) = New TextBox
            tbxID(i) = New TextBox
            tbx1Type(i) = New TextBox
            tbx1Per(i) = New TextBox
            tbx1Mark(i) = New TextBox
            tbx2Type(i) = New TextBox
            tbx2Per(i) = New TextBox
            tbx2Mark(i) = New TextBox
            tbxGrade(i) = New TextBox

            tbxName(i).Name = "tbxName" & CStr(i)
            tbxName(i).Width = 280
            tbxName(i).Left = 3
            tbxName(i).Top = top
            tbxName(i).Enabled = False

            tbxID(i).Name = "tbxID" & CStr(i)
            tbxID(i).Width = 160
            tbxID(i).Left = 310
            tbxID(i).Top = top
            tbxID(i).Enabled = False

            tbx1Type(i).Name = "tbx1Type" & CStr(i)
            tbx1Type(i).Width = 21
            tbx1Type(i).Left = 512
            tbx1Type(i).Top = top
            tbx1Type(i).Enabled = False

            tbx1Per(i).Name = "tbx1Per" & CStr(i)
            tbx1Per(i).Width = 37
            tbx1Per(i).Left = 559
            tbx1Per(i).Top = top
            tbx1Per(i).Enabled = False

            tbx1Mark(i).Name = "tbx1Mark" & CStr(i)
            AddHandler tbx1Mark(i).Leave, AddressOf TbxMark_Leave
            tbx1Mark(i).Width = 37
            tbx1Mark(i).Left = 615
            tbx1Mark(i).Top = top
            tbx1Mark(i).Enabled = False

            tbx2Type(i).Name = "tbx2Type" & CStr(i)
            tbx2Type(i).Width = 21
            tbx2Type(i).Left = 710
            tbx2Type(i).Top = top
            tbx2Type(i).Enabled = False

            tbx2Per(i).Name = "tbx2Per" & CStr(i)
            tbx2Per(i).Width = 37
            tbx2Per(i).Left = 757
            tbx2Per(i).Top = top
            tbx2Per(i).Enabled = False

            tbx2Mark(i).Name = "tbx2Mark" & CStr(i)
            AddHandler tbx2Mark(i).Leave, AddressOf TbxMark_Leave
            tbx2Mark(i).Width = 37
            tbx2Mark(i).Left = 813
            tbx2Mark(i).Top = top
            tbx2Mark(i).Enabled = False

            tbxGrade(i).Name = "tbxGrade" & CStr(i)
            tbxGrade(i).Width = 50
            tbxGrade(i).Left = 900
            tbxGrade(i).Top = top
            tbxGrade(i).Enabled = False
            tbxGrade(i).MaxLength = 4

            pnlGrades.Controls.Add(tbxName(i))
            pnlGrades.Controls.Add(tbxID(i))
            pnlGrades.Controls.Add(tbx1Type(i))
            pnlGrades.Controls.Add(tbx1Per(i))
            pnlGrades.Controls.Add(tbx1Mark(i))
            pnlGrades.Controls.Add(tbx2Type(i))
            pnlGrades.Controls.Add(tbx2Per(i))
            pnlGrades.Controls.Add(tbx2Mark(i))
            pnlGrades.Controls.Add(tbxGrade(i))

            top += 40
        Next
    End Sub

    Private Sub ShowMarks(ByVal title As String)
        For j As Integer = 0 To 5
            tbxName(j).Text = ""
            tbxID(j).Text = ""
            tbx1Mark(j).Text = ""
            tbx1Per(j).Text = ""
            tbx1Type(j).Text = ""
            tbx2Mark(j).Text = ""
            tbx2Per(j).Text = ""
            tbx2Type(j).Text = ""
            tbxGrade(j).Text = ""
        Next
        lblModuleTitle.Text = ""
        Dim aRow As DataRow
        Dim i As Integer = 0
        If DS.Tables.Count > 0 Then
            For Each aRow In DS.Tables("Module").Rows
                If aRow.Item(0).ToString = title Then
                    lblModuleTitle.Text = "Course Title: " & title
                    tbxName(i).Text = aRow.Item(1).ToString
                    tbxID(i).Text = aRow.Item(2).ToString
                    tbx1Type(i).Text = aRow.Item(3).ToString
                    tbx1Per(i).Text = aRow.Item(4).ToString
                    tbx1Mark(i).Text = aRow.Item(5).ToString
                    tbx2Type(i).Text = aRow.Item(6).ToString
                    tbx2Per(i).Text = aRow.Item(7).ToString
                    tbx2Mark(i).Text = aRow.Item(8).ToString
                    tbxGrade(i).Text = CStr(((CInt(aRow.Item(4)) * (CInt(aRow.Item(5)) / 100)) + (CInt(aRow.Item(7)) * (CInt(aRow.Item(8)) / 100))))
                    i += 1
                    If i > 5 Then
                        Exit For
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub ShowExtras()
        Dim num(5) As Double
        For i As Integer = 0 To 5
            If Not Double.TryParse(tbxGrade(i).Text, num(i)) Then
                num(i) = 0
            Else
                Double.TryParse(tbxGrade(i).Text, num(i))
            End If
        Next
        Dim Min As Double = num.Min()
        Dim total As Double
        Dim onlyOne As Boolean = False
        For i As Integer = 0 To 5
            If num(i) <> Min Or onlyOne Then
                If num(i) > 40 Then
                    total += num(i)
                Else
                    MessageBox.Show("Failed")
                    Exit Sub
                End If
            Else
                onlyOne = True
            End If
        Next
        Dim avg As Double = Math.Ceiling(total / 5)
        tbx5Average.Text = CStr(avg)
        avg *= 0.4
        tbxYearPercent.Text = CStr(avg) & "%"
    End Sub

    Private Sub TbxMark_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim aTextbox As TextBox = CType(sender, TextBox)
        Dim index As Integer = -1
        For i As Integer = 0 To 5
            If aTextbox Is tbx1Mark(i) Or aTextbox Is tbx2Mark(i) Then
                index = i
            End If
        Next
        Dim num As Integer
        Dim strA As String = aTextbox.Text
        If Not Integer.TryParse(strA, num) Then
            num = 0
        Else
            If num > 100 Then
                num = 0
            Else
                num = CInt(aTextbox.Text)
            End If
        End If
        aTextbox.Text = CStr(num)
        Dim aRow As DataRow
        Dim j As Integer = 0
        If DS.Tables.Count > 0 Then
            For Each aRow In DS.Tables("Module").Rows
                If ("Course Title: " & aRow.Item(0).ToString) = lblModuleTitle.Text AndAlso aRow.Item(1).ToString = tbxName(index).Text Then
                    aRow.Item(5) = tbx1Mark(index).Text
                    aRow.Item(8) = tbx2Mark(index).Text
                    tbxGrade(index).Text = CStr(((CInt(aRow.Item(4)) * (CInt(aRow.Item(5)) / 100)) + (CInt(aRow.Item(7)) * (CInt(aRow.Item(8)) / 100))))
                End If
            Next
        End If
    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        DS.WriteXml("grades.xml")
        Me.Close()
    End Sub

    Private Sub MainForm_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim FontName As String = "Segoe Print"
        Dim FontSize As Integer = 63
        Dim FS As New Font(FontName, FontSize)
        e.Graphics.DrawString("GRADE DISPLAY", FS, Brushes.Gray, 132, 22)
        e.Graphics.DrawString("GRADE DISPLAY", FS, Brushes.LightGray, 130, 20)
        e.Graphics.DrawString("GRADE DISPLAY", FS, Brushes.Blue, 128, 18)
        FontSize = 30
        Dim FS2 As New Font(FontName, FontSize)
        e.Graphics.DrawString("By Russy P", FS2, Brushes.Gray, 382, 132)
        e.Graphics.DrawString("By Russy P", FS2, Brushes.LightGray, 380, 130)
        e.Graphics.DrawString("By Russy P", FS2, Brushes.Blue, 378, 128)
    End Sub

    Private Sub btnEnterModule_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnterModule.Click
        Dim inputModuleDetails As Integer = dlgModule.ShowDialog()
        Dim title As String = dlgModule.tbxYourTitle.Text
        Dim name As String = dlgModule.tbxModName.Text
        Dim id As String = dlgModule.tbxModID.Text
        Dim type1 As String = dlgModule.cbx1Type.Text
        Dim type2 As String = dlgModule.cbx2Type.Text
        Dim weight1 As Integer = CInt(dlgModule.nud1Weight.Value)
        Dim weight2 As Integer = CInt(dlgModule.nud2Weight.Value)
        If inputModuleDetails = 1 Then
            fillRows(title, name, id, type1, weight1, 0, type2, weight2, 0)
            dlgModule.Dispose()
        End If
    End Sub

    Private Sub btnEnterMarks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnterMarks.Click
        dlgChooseTitle.Dispose()
        If btnEnterMarks.Text = "Enter Marks" Then
            Dim aCourse As Integer = dlgChooseTitle.ShowDialog
            Dim title As String = dlgChooseTitle.cbxChooseTitle.Text
            currentTitle = title
            If title <> "Select Title" Then
                ShowMarks(title)
                AddMarks()
            End If
            btnEnterMarks.Text = "Done"
        Else
            RetainMarks()
            ShowMarks(currentTitle)
            btnEnterMarks.Text = "Enter Marks"
        End If
    End Sub

    Private Sub AddMarks()
        For i As Integer = 0 To 5
            tbx1Mark(i).Enabled = True
            tbx2Mark(i).Enabled = True
        Next
    End Sub

    Private Sub RetainMarks()
        For i As Integer = 0 To 5
            tbx1Mark(i).Enabled = False
            tbx2Mark(i).Enabled = False
        Next
    End Sub

    Private Sub btnShowMarks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowMarks.Click
        dlgChooseTitle.Dispose()
        Dim aCourse As Integer = dlgChooseTitle.ShowDialog()
        Dim title As String = dlgChooseTitle.cbxChooseTitle.Text
        If title <> "Select Title" Then
            ShowMarks(title)
        End If
    End Sub

    Public ReadOnly Property ReadDataset() As DataSet
        Get
            Return DS
        End Get
    End Property


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ShowExtras()
    End Sub
End Class
