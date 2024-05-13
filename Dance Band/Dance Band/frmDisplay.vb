Public Class frmDisplay
    Public Shared intSizeOfArray = 51
    Public Shared strSongName(intSizeOfArray) As String
    Public Shared strSongGenre(intSizeOfArray) As String
    Public Shared decSongLength(intSizeOfArray) As Decimal

    Private Sub frmDisplay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Loads information from file to appropriate arrays'
        Dim objReader As IO.StreamReader
        Dim strLocationAndFileName As String = "E:\VB 2017 Resources\Chapter 8\songs.txt"
        Dim intCount As Integer = 0
        Dim strFileError As String = "The file is unavailable. Check file location."

        If IO.File.Exists(strLocationAndFileName) Then
            'Check if file path is valid'
            objReader = IO.File.OpenText(strLocationAndFileName)
            Do While objReader.Peek <> -1
                'Looks through and assigns correct values to correct array'
                strSongName(intCount) = objReader.ReadLine()
                strSongGenre(intCount) = objReader.ReadLine()
                decSongLength(intCount) = Convert.ToDecimal(objReader.ReadLine())
                intCount += 1

            Loop
            objReader.Close()

        Else
            'Tells user file path does not exist or is unavailable'
            MsgBox(strFileError,, "Error")
        End If
    End Sub
    Private Sub btnCurrentOrder_Click(sender As Object, e As EventArgs) Handles btnCurrentOrder.Click

        'Display the list of songs as it originally was'
        Dim intGenre As String = cboGenres.SelectedIndex
        Dim strGenre As String
        Dim intCount1 As Integer = 0
        Dim intTest As Integer = 1

        Select Case intGenre
            Case 0
                strGenre = "Country"
                prcDisplayCurrent(intGenre, strGenre)
            Case 1
                strGenre = "Pop"
                prcDisplayCurrent(intGenre, strGenre)
            Case 2
                strGenre = "Rap"
                prcDisplayCurrent(intGenre, strGenre)
            Case 3
                strGenre = "Rock"
                prcDisplayCurrent(intGenre, strGenre)
            Case 4
                strGenre = "R&B"
                prcDisplayCurrent(intGenre, strGenre)
        End Select
    End Sub
    Private Sub btnSort_Click(sender As Object, e As EventArgs) Handles btnSort.Click

        'Displays the song list in alphabetical order'
        Dim intGenre As String = cboGenres.SelectedIndex
        Dim strGenre As String
        Dim intCount1 As Integer = 0
        Dim intTest As Integer = 1

        Select Case intGenre
            Case 0
                strGenre = "Country"
                prcDisplaySort(intGenre, strGenre)

            Case 1
                strGenre = "Pop"
                prcDisplaySort(intGenre, strGenre)
            Case 2
                strGenre = "Rap"
                prcDisplaySort(intGenre, strGenre)
            Case 3
                strGenre = "Rock"
                prcDisplaySort(intGenre, strGenre)
            Case 4
                strGenre = "R&B"
                prcDisplaySort(intGenre, strGenre)

        End Select
    End Sub

    Private Sub prcDisplayCurrent(ByVal intGenre As Integer, ByVal strGenre As String)
        'Sorts the list'
        Dim intCount1 As Integer = 0

        lstSongs2.Items.Clear()
        For intCount1 = 0 To (strSongGenre.Length - 1)
            If (strSongGenre(intCount1) = strGenre) Then
                lstSongs2.Items.Add(strSongName(intCount1))
            End If
        Next

    End Sub

    Private Sub prcDisplaySort(ByVal intGenre As Integer, ByVal strGenre As String)
        'Sorts the list of songs in alphabetical order'
        lstSongs2.Items.Clear()
        Array.Sort(strSongName)
        For intCount1 = 0 To (strSongName.Length - 1)
            If (strSongGenre(intCount1) = strGenre) Then
                lstSongs2.Items.Add(strSongName(intCount1))
            End If
        Next

    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        'Goes back to the original form'
        Dim frmFirst As New frmDanceBand
        Hide()
        frmFirst.ShowDialog()

    End Sub

    Private Sub cboGenre1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGenres.SelectedIndexChanged
        'When option is selected, the rest of the form appears'
        lstSongs2.Visible = True
        btnCurrentOrder.Visible = True
        btnSort.Visible = True
        btnReturn.Visible = True

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstSongs2.Items.Clear()
    End Sub
End Class