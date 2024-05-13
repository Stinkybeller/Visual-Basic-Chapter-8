Public Class frmDisplayPatientInfo

    Public Shared intSizeofArray = 15
    Public Shared strPatients(intSizeofArray) As String
    Public Shared strPatientsHighCholesterol(intSizeofArray) As String
    Private decCholesterolLevel(intSizeofArray) As Decimal
    Private decHighCholesterol(intSizeofArray) As Decimal

    Private Sub frmDisplayPatientInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim objReader As IO.StreamReader
        Dim strLocationAndFileName As String = "E:\Visual Basic\Chapter 8\New Files\consult.txt"
        Dim intCount As Integer = 0
        Dim strFileError As String = "The file is unavailable. Check file location."
        Dim intTrack As Integer
        Dim keepTrack As Integer

        If IO.File.Exists(strLocationAndFileName) Then
            'Checks if file path exists'
            objReader = IO.File.OpenText(strLocationAndFileName)

            Do While objReader.Peek <> -1
                'Goes through the file and adds each line to the approrpriate array'
                strPatients(intCount) = objReader.ReadLine()
                decCholesterolLevel(intCount) = Convert.ToDecimal(objReader.ReadLine())
                intCount += 1

            Loop

            objReader.Close()
        Else
            MsgBox(strFileError,, "Error")
            Close()

        End If

        For intTrack = 0 To (decCholesterolLevel.Length - 1)
            'Adds the names of patients with a cholesterol level of >= 200 and their actual level'
            If decCholesterolLevel(intTrack) >= 200 Then
                decHighCholesterol(intTrack) = decCholesterolLevel(intTrack)
                strPatientsHighCholesterol(intTrack) = strPatients(intTrack)
            End If

            If (decHighCholesterol(intTrack) <> 0) Then
                keepTrack += 1
                lstPatientName.Items.Add(strPatientsHighCholesterol(intTrack))
                lstCholesterolLevel.Items.Add(decHighCholesterol(intTrack))

            End If
        Next

    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        'Returns user to the first form and hides the current form'
        Dim frmFirst As New frmPatientCholesterolScreening

        Hide()
        frmFirst.ShowDialog()
    End Sub
End Class