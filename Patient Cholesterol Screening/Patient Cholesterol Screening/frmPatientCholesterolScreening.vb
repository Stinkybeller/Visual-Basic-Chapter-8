'Program name: Patient Cholesterol Screening'
'Developer: Izabella Fortunata'
'Date: 4/26/24'
'Purpose: To display patients cholesterol levels'
Public Class frmPatientCholesterolScreening

    Public Shared intSizeofArray = 15
    Public Shared strPatients(intSizeofArray) As String
    Public Shared strPatientsHighCholesterol(intSizeofArray)
    Private decCholesterolLevel(intSizeofArray) As Decimal
    Private decHighCholesterol(intSizeofArray) As Decimal

    Private Sub frmPatientCholesterolScreening_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'When form loads information from specified text file is loaded in'
        Threading.Thread.Sleep(3000)

        Dim objReader As IO.StreamReader
        Dim strLocationAndFileName As String = "E:\VB 2017 Resources\Chapter 8\patient.txt"
        Dim intCount As Integer = 0
        Dim strFileError As String = "The file is unavaible. Check file location."
        Dim objWriter As New IO.StreamWriter("E:\Visual Basic\Chapter 8\New Files\consult.txt")
        Dim strLocationAndFileName1 As String = "E:\Visual Basic\Chapter 8\New Files\consult.txt"
        Dim intCount1 As Integer = 0

        If IO.File.Exists(strLocationAndFileName) Then
            'Check if file exists'
            objReader = IO.File.OpenText(strLocationAndFileName)

            Do While objReader.Peek <> -1
                'Looks through the file and adds each line to the approrpriate array'
                strPatients(intCount) = objReader.ReadLine()
                decCholesterolLevel(intCount) = Convert.ToDecimal(objReader.ReadLine())
                intCount += 1

            Loop

            objReader.Close()
        Else
            'If file doesn't appear to exist, a message pops up'
            MsgBox(strFileError,, "Error")
            Close()
        End If

        If IO.File.Exists(strLocationAndFileName1) Then
            'Looks through the file and adds each line that is a number greater than or equal to 200 to the appropriate array'

            For intCount1 = 0 To (decCholesterolLevel.Length - 1)
                If decCholesterolLevel(intCount1) >= 200 Then
                    strPatientsHighCholesterol(intCount1) = strPatients(intCount1)
                    objWriter.WriteLine(strPatientsHighCholesterol(intCount1))
                    objWriter.WriteLine(decCholesterolLevel(intCount1))

                End If
            Next
            objWriter.Close()

        Else
            MsgBox(strFileError,, "Error")
            Close()
        End If

    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        'When button is clicked the number of patients with a cholesterol level of >= 200 and average cholesterol is displayed'
        Dim intTrack As Integer
        Dim keepTrack As Integer
        Dim intAddition As Integer
        Dim intDivision As Integer = 16
        Dim decAverage As Decimal

        For intTrack = 0 To (decCholesterolLevel.Length - 1)
            'Counts the number of patients with a cholesterol level of >= 200'

            If decCholesterolLevel(intTrack) >= 200 Then
                decHighCholesterol(intTrack) = decCholesterolLevel(intTrack)
            End If

            If (decHighCholesterol(intTrack) <> 0) Then
                keepTrack += 1
            End If
        Next

        For intTrack = 0 To (decCholesterolLevel.Length - 1)
            'Adds up all values'

            intAddition += decCholesterolLevel(intTrack)
        Next

        'Calculates average'
        decAverage = intAddition / intDivision

        lblNumberResult.Text = keepTrack.ToString
        lblAvgResult.Text = decAverage.ToString("N2")

        lblNumber.Visible = True
        lblNumberResult.Visible = True
        lblAvg.Visible = True
        lblAvgResult.Visible = True

    End Sub

    Private Sub DisplayPatientInformationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisplayPatientInformationToolStripMenuItem.Click
        'Hides first form and shows second form'
        Dim frmSecond As New frmDisplayPatientInfo

        Hide()
        frmSecond.ShowDialog()

    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        'Clears form'

        lblNumberResult.Text = ""
        lblAvgResult.Text = ""

        lblNumber.Visible = False
        lblNumberResult.Visible = False
        lblAvg.Visible = False
        lblAvgResult.Visible = False

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'Closes program'
        Close()

    End Sub
End Class
