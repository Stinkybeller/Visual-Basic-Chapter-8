'Program Name: Dance Band'
'Developer: Izabella Fortunata'
'Date: 4/3/2024'
'Purpose: This application allows a user to slect a genre of music and a list of songs and their length.'

Public Class frmDanceBand
    'Declaring class variables'
    Public Shared intSize As Integer = 51
    Public Shared strSongName(intSize) As String
    Public Shared strGenre(intSize) As String
    Public Shared strTime(intSize) As String
    Public Shared _genreList() As String
    Public Shared strSongs() As String

    Private Sub frmDanceBand_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Read the Inventory text file and fill the listbox with inventory items'
        'Initialized the StreamReader Object and Declare variables'
        Dim objReader As IO.StreamReader
        Dim strLocationAndNameOfFile As String = "D:\VB 2017 Resources\Chapter 8\songs.txt"
        Dim strFileError As String = "The file is unavaliable. Check file location."
        Dim intCount As Integer = 0, intFill As Integer

        'Verify that the file exists'
        If IO.File.Exists(strLocationAndNameOfFile) Then
            objReader = IO.File.OpenText(strLocationAndNameOfFile)
            'Read the file line by line until the end of the file'
            Do While objReader.Peek <> -1
                strSongName(intCount) = objReader.ReadLine()
                strGenre(intCount) = objReader.ReadLine()
                strTime(intCount) = objReader.ReadLine()
                intCount += 1
            Loop
            'Close the file'
            objReader.Close()
            'Fills the combox with the genre values'
            _genreList = {strGenre(0), strGenre(1), strGenre(2), strGenre(3)}

            For intFill = 0 To (_genreList.Length - 1)
                cboGenre.Items.Add(_genreList(intFill))
            Next
        Else
            MsgBox(strFileError, , "Error")
            Close()
        End If
    End Sub

    Private Sub CboGenre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGenre.SelectedIndexChanged
        'Displaying the songs in the list box'
        lstSongs.Items.Clear()
        For Each strSong In strSongName
            If strGenre(Array.IndexOf(strSongName, strSong)) = cboGenre.Items.Item(cboGenre.SelectedIndex).ToString() Then
                lstSongs.Items.Add(String.Format("{0} - {1}", strSong, strTime(Array.IndexOf(strSongName, strSong))))
            End If
        Next
        picDanceBand.Visible = True
        lstSongs.Visible = True
    End Sub

    Private Sub DisplaySongSetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisplaySongSetToolStripMenuItem.Click
        'Displays new form that has the song list set'
        Dim frmSecond As New frmDisplay
        Hide()
        frmDisplay.ShowDialog()
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        'Clear out items'
        lstSongs.Items.Clear()
        lstSongs.Visible = False
        cboGenre.Text = "Select Genre"
        cboGenre.SelectedIndex = -1
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'Closes the program'
        Close()
    End Sub

End Class

