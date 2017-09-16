'Code to open file click option'
Public Class Form1
    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Dim Open As New OpenFileDialog()
        Dim myStreamReader As System.IO.StreamReader
        Open.Filter = "Plain Text Files (*.txt)|*.txt|All files (*.*)|*.*"
        Open.CheckFileExists = True
        Open.ShowDialog(Me)
        Try
            Open.OpenFile()
            myStreamReader = System.IO.File.OpenText(Open.FileName)
            TxtEditor.Text = myStreamReader.ReadToEnd()
            Me.Text = "Text Editor - " & Open.FileName
        Catch ex As Exception
            ' Do nothing on Exception
        End Try
    End Sub
    ' Code to save text file'
    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Dim Save As New SaveFileDialog()
        Dim myStreamWriter As System.IO.StreamWriter
        Save.Filter = "Plain Text Files (*.txt)|*.txt|All files (*.*)|*.*"
        Save.CheckPathExists = True
        Save.ShowDialog(Me)
        Try
            myStreamWriter = System.IO.File.CreateText(Save.FileName)
            myStreamWriter.Write(TxtEditor.Text)
            myStreamWriter.Flush()
            Me.Text = "Text Editor - " & Save.FileName
        Catch ex As Exception
            ' Do nothing on Exception
        End Try
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim Response As MsgBoxResult
        Response = MsgBox("Are you sure you want to Exit Text Editor?",
                          MsgBoxStyle.Question + MsgBoxStyle.YesNo,
                          "Text Editor")
        If Response = MsgBoxResult.Yes Then
            End
        End If
    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        Dim Font As New FontDialog()
        Font.Font = TxtEditor.Font
        Font.ShowDialog(Me)
        Try
            TxtEditor.Font = Font.Font
        Catch ex As Exception
            ' Do nothing on Exception
        End Try
    End Sub

    Private Sub ColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorToolStripMenuItem.Click
        Dim Colour As New ColorDialog()
        Colour.Color = TxtEditor.ForeColor
        Colour.ShowDialog(Me)
        Try
            TxtEditor.ForeColor = Colour.Color
        Catch ex As Exception
            ' Do nothing on Exception
        End Try
    End Sub

    Private Sub ThemeToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.ShowDialog()
    End Sub

    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.Click

    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        AboutBox1.ShowDialog()
    End Sub
End Class
