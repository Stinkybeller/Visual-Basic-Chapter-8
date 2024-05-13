'Program Name: Smart Home Electric Savings'
'Developer: Izabella Fortunata'
'Date: 4/2/2024'
'Purpose: Lists the monthly savings of a smart homes elctric bills'
Public Class frmSmartHomeApplications
    'Declaring class variables'
    Dim intSize As Integer = 11
    Dim strMonths(intSize) As String
    Dim decSavings(intSize) As Decimal
    Dim intIndex As Integer
    Private Sub cboMonths_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMonths.SelectedIndexChanged
        'Filling in the combo box'
        If cboMonths.SelectedIndex <> -1 Then
            intIndex = cboMonths.SelectedIndex
        End If

        btnDisplay.Visible = True
    End Sub
    Private Sub frmSmartHomeApplications_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Read the Inventory text file and fill the listbox with inventory items'
        'Initialized the StreamReader Object and Declare variables'
        Dim objReader As IO.StreamReader
        Dim strLocationAndNameOfFile As String = "E:\VB 2017 Resources\Chapter 8\savings.txt"
        Dim strFileError As String = "The file is unavaliable. Check file location."
        Dim intCount As Integer = 0, intFill As Integer

        'Verify that the file exists'
        If IO.File.Exists(strLocationAndNameOfFile) Then
            objReader = IO.File.OpenText(strLocationAndNameOfFile)
            'Read the file line by line until the end of the file'
            Do While objReader.Peek <> -1
                strMonths(intCount) = objReader.ReadLine()
                decSavings(intCount) = Convert.ToDecimal(objReader.ReadLine())
                intCount += 1
            Loop
            'Close the file'
            objReader.Close()
            'Fills the listbox with the savings values'
            For intFill = 0 To (strMonths.GetLength(0) - 1)
                cboMonths.Items.Add(strMonths(intFill))
            Next
        Else
            MsgBox(strFileError, , "Error")
            Close()
        End If
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        'Displays the average savings, savings that month, and the month that had the most signifigant savings'

        Dim intIterations As Integer = 0
        Dim decTotalSavings As Decimal
        Dim decAverageSavings As Decimal

        Do While intIterations <> 12
            decTotalSavings += decSavings(intIterations)
            intIterations += 1
        Loop
        'Displaying the final results
        decAverageSavings = decTotalSavings / 12
        lblAverageSavings.Text = String.Format("The average monthly savings: {0}", decAverageSavings.ToString("C"))
        lblMostSavings.Text = String.Format("{0} had the most significant monthly savings", strMonths(Array.IndexOf(decSavings, decSavings.Max())))
        lblSavings.Text = String.Format("The electric savings for {0} is {1}", strMonths(intIndex), decSavings(intIndex).ToString("C"))

        'Call the objects visible procedure'
        prcMakeObjectsVisible()

    End Sub
    Private Sub prcMakeObjectsVisible()
        'Makes labels visible'
        lblSavings.Visible = True
        lblAverageSavings.Visible = True
        lblMostSavings.Visible = True
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        'Clears from'
        lblSavings.Visible = False
        lblAverageSavings.Visible = False
        lblMostSavings.Visible = False
        btnDisplay.Visible = False
    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'Closes the program'
        Close()
    End Sub
End Class
