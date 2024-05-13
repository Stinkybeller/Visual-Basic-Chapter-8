'Program name: Most Popular Game Sold'
'Developer: Izabella Fortunata'
'Date: 05/06/24'
'Purpose: To show the amount sold for the top 10 games'

Public Class frmMostPopularGamesSold

    Public Shared intSizeOfArray As Integer = 9
    Public Shared strGameTitle(intSizeOfArray) As String
    Public Shared intGameNumbersSold(intSizeOfArray) As Integer

    Private Sub frmMostPopularGamesSold_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim objReader As IO.StreamReader
        Dim strLocationAndFileName As String = "E:\VB 2017 Resources\Chapter 8\mobile.txt"
        Dim intCount As Integer = 0
        Dim intCount1 As Integer
        Dim strFileError As String = "The file is unavailable. Check file location."

        'Checks if file path exists'
        If IO.File.Exists(strLocationAndFileName) Then

            objReader = IO.File.OpenText(strLocationAndFileName)

            'Looks through and assigns correct values to correct array'
            Do While objReader.Peek <> -1

                strGameTitle(intCount) = objReader.ReadLine()
                intGameNumbersSold(intCount) = Convert.ToInt32(objReader.ReadLine())
                intCount += 1
            Loop
            objReader.Close()
        Else
            MsgBox(strFileError,, "Error")
        End If

        'Displays game titles in list box
        For intCount1 = 0 To (strGameTitle.Length - 1)
            lstGameTitle.Items.Add(strGameTitle(intCount1))
        Next

    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        'Displays number sold for the game selected and the total amount for the top games'

        Dim intGameSelect As Integer = lstGameTitle.SelectedIndex
        Dim strSelectionError As String = "Please select a mobile game."
        Dim strError As String = "Error"

        If lstGameTitle.SelectedIndex <> -1 Then
            Select Case intGameSelect
                Case 0
                    lblNumSoldSelected.Text = intGameNumbersSold(0).ToString

                Case 1
                    lblNumSoldSelected.Text = intGameNumbersSold(1).ToString

                Case 2
                    lblNumSoldSelected.Text = intGameNumbersSold(2).ToString

                Case 3
                    lblNumSoldSelected.Text = intGameNumbersSold(3).ToString

                Case 4
                    lblNumSoldSelected.Text = intGameNumbersSold(4).ToString

                Case 5
                    lblNumSoldSelected.Text = intGameNumbersSold(5).ToString

                Case 6
                    lblNumSoldSelected.Text = intGameNumbersSold(6).ToString

                Case 7
                    lblNumSoldSelected.Text = intGameNumbersSold(7).ToString

                Case 8
                    lblNumSoldSelected.Text = intGameNumbersSold(8).ToString

                Case 9
                    lblNumSoldSelected.Text = intGameNumbersSold(9).ToString

            End Select
            prcCalculateTotal()
        Else
            MsgBox(strSelectionError,, strError)

        End If

    End Sub

    Private Sub prcCalculateTotal()
        'Calculates total amount sold for the games'
        Dim intAddition As Integer
        Dim intCount2 As Integer = 0

        For intCount2 = 0 To (intGameNumbersSold.Length - 1)
            intAddition += intGameNumbersSold(intCount2)
        Next
        lblTotalNumSold.Text = intAddition.ToString

    End Sub

    Private Sub DisplaySortedListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisplaySortedListToolStripMenuItem.Click
        'Hides current form and shows first form'
        Dim frmSecond As New frmDisplaySorted

        Hide()
        frmSecond.ShowDialog()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'Exits the program'
        Close()
    End Sub
End Class
