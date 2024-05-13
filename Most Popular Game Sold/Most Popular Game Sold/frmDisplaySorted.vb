Public Class frmDisplaySorted

    Public Shared intSizeOfArray As Integer = 9

    Public Shared strGameTitle(intSizeOfArray) As String
    Public Shared intGameNumbersSold(intSizeOfArray) As Integer

    Private Sub frmDisplaySorted_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' reads through text file and sorts game titles alphabetically then displays them in a list box

        Dim objReader As IO.StreamReader
        Dim strLocationAndFileName As String = "E:\VB 2017 Resources\Chapter 8\mobile.txt"
        Dim intCount As Integer = 0
        Dim intCount1 As Integer = 0
        Dim strFileError As String = "The file is unavailable. Check file location."

        If IO.File.Exists(strLocationAndFileName) Then
            ' checks if file path exists

            objReader = IO.File.OpenText(strLocationAndFileName)

            Do While objReader.Peek <> -1
                ' looks through and assigns correct values to correct array

                strGameTitle(intCount) = objReader.ReadLine()

                intGameNumbersSold(intCount) = Convert.ToInt32(objReader.ReadLine())

                intCount += 1

            Loop

            objReader.Close()

        Else

            MsgBox(strFileError,, "Error")

        End If

        ' sorts array alphabetically
        Array.Sort(strGameTitle)

        For intCount1 = 0 To (strGameTitle.Length - 1)
            ' adds each item from the newly sorted array to list box
            lstSortedGameTitle.Items.Add(strGameTitle(intCount1))

        Next

    End Sub

    Private Sub ReturnToFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReturnToFormToolStripMenuItem.Click
        ' shows opening form

        Dim frmFirst As New frmMostPopularGamesSold

        Hide()
        frmFirst.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        ' closes app

        Close()

    End Sub
End Class