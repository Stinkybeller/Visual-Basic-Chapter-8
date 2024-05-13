'Program Name: Chef Shack Food Truck Decpreciation'
'Developer: Izabella Fortunata'
'Date: 4/1/24'
'Purpose: This app determines depreciation based on a 5 year life of items in inventory using striaght line and declining methods.'

Option Strict On
Public Class frmFoodTruck
    'Declare class variables'
    Private intLifeofItems As Integer = 5
    Public Shared intSizeofArray As Integer = 7
    Public Shared strArrInventoryItem(intSizeofArray) As String
    Private strArrItemID(intSizeofArray) As String
    Private decArrInitialPrice(intSizeofArray) As Decimal
    Private intArrQuantity(intSizeofArray) As Integer

    Private Sub frmFoodTruck_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Read the Inventory text file and fill the listbox with inventory items'
        'Initialized the StreamReader Object and Declare variables'
        Dim objReader As IO.StreamReader
        Dim strLocationandFileName As String = "E:\VB 2017 Resources\Chapter 8\inventory.txt"
        Dim intCount As Integer = 0
        Dim intFill As Integer
        Dim strFileError As String = "The file is unavaliable. Check file location."

        'Verify that the file exists'
        If IO.File.Exists(strLocationandFileName) Then
            objReader = IO.File.OpenText(strLocationandFileName)
            'Read the file line by the line until end of file'
            Do While objReader.Peek <> -1
                strArrInventoryItem(intCount) = objReader.ReadLine()
                strArrItemID(intCount) = objReader.ReadLine()
                decArrInitialPrice(intCount) = Convert.ToDecimal(objReader.ReadLine())
                intArrQuantity(intCount) = Convert.ToInt32(objReader.ReadLine())
                intCount += 1
            Loop
            'Close the file'
            objReader.Close()

            'Fill listbox with inventory IDs'
            For intFill = 0 To (strArrItemID.Length - 1)
                lstInventoryID.Items.Add(strArrItemID(intFill))
            Next
        Else
            MsgBox(strFileError,, "Error")
        End If

    End Sub
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Calulate Depreciation'
        Dim intSelectedItemID As Integer
        Dim strMissingSelection As String = "Missing Selection"
        Dim strSelectedDepreciationErorr As String = "Select a depreciation method"
        Dim strSelectedInventoryItemIDErorr As String = "Select an Inventory Item ID"

        'If the listbox and a depreciation method are selected call the depreciation procedures'
        If lstInventoryID.SelectedIndex > 0 Then
            intSelectedItemID = lstInventoryID.SelectedIndex
            'Check radiobutton'
            If radStraightLine.Checked Then
                prcStraightLineDepreciation(intSelectedItemID)
            ElseIf radDeclineBalance.Checked Then
                prcDoubleDeclineDepreciation(intSelectedItemID)
            Else
                'Error for for not selecting depreciation method'
                MsgBox(strSelectedDepreciationErorr,, strMissingSelection)
            End If
        Else
            'Error for not selecting Item ID'
            MsgBox(strSelectedInventoryItemIDErorr,, strMissingSelection)
        End If
    End Sub

    Private Sub prcStraightLineDepreciation(ByVal intItemID As Integer)
        'Compute and display the straight line depreciation for he seleced item'
        'Declare variables'
        Dim intStraightPresentYear As Integer
        Dim decStraightPresentValue As Decimal = 0
        Dim decStraightDepreciation As Decimal
        Dim decStraightTotal As Decimal
        Dim strDepreciationItem As String = "The depreciation of the item: "
        Dim strQuantityMessage As String = "Quantity: "

        'Call the procedure to make objects visible'
        prcMakeObjectsVisible()

        'Display the item and Quanitity of the selected Item'
        lblItem.Text = strDepreciationItem & strArrInventoryItem(intItemID)
        lblQuantity.Text = strQuantityMessage & intArrQuantity(intItemID).ToString()
        'Calculate Straight Line Depreciation'
        decStraightDepreciation = decArrInitialPrice(intItemID) / intLifeofItems
        decStraightPresentValue = decArrInitialPrice(intItemID)

        'Repeat loop for life of items'
        For intStraightPresentYear = 1 To intLifeofItems
            'Accumulate the total Depreciation'
            decStraightTotal += decStraightDepreciation
            'Display our depreciation amounts in list boxes'
            lstYear.Items.Add(intStraightPresentYear.ToString())
            lstPresentValue.Items.Add(decStraightPresentValue.ToString("C"))
            lstYearDepreciation.Items.Add(decStraightDepreciation.ToString("C"))
            lstTotalDepreciation.Items.Add(decStraightTotal.ToString("C"))
            decStraightPresentValue -= decStraightDepreciation

        Next
    End Sub
    Private Sub prcDoubleDeclineDepreciation(ByVal intItemID As Integer)
        'Compute and display the straight line depreciation for he seleced item'
        'Declare variables'
        Dim intDoublePresentYear As Integer
        Dim decDoublePresentYearValue As Decimal = 0
        Dim decDoubleDepreciation As Decimal
        Dim decDoubleTotal As Decimal

        'Call the procedure to make objects visible'
        prcMakeObjectsVisible()

        'Display the item and Quanitity of the selected Item'
        lblItem.Text = "The depreciation of the item: " & strArrInventoryItem(intItemID)
        lblQuantity.Text = "Quantity: " & intArrQuantity(intItemID).ToString()
        'Calculate Double DecliningLine Depreciation'

        decDoublePresentYearValue = decArrInitialPrice(intItemID)

        'Repeat loop for life of items'
        For intDoublePresentYear = 1 To intLifeofItems
            'The formula for double declining depreciation inside the loop to repeat the process'
            decDoubleDepreciation = (decDoublePresentYearValue * 2D) / intLifeofItems
            'Accumulate the total depreciation'
            decDoubleTotal += decDoubleDepreciation

            'Display our depreciation amounts in list boxes'
            lstYear.Items.Add(intDoublePresentYear.ToString())
            lstPresentValue.Items.Add(decDoublePresentYearValue.ToString("C"))
            lstYearDepreciation.Items.Add(decDoubleDepreciation.ToString("C"))
            lstTotalDepreciation.Items.Add(decDoubleTotal.ToString("C"))
            decDoublePresentYearValue -= decDoubleDepreciation
        Next
    End Sub

    Private Sub prcMakeObjectsVisible()
        'Display the objects and resulats'
        lblItem.Visible = True
        lblQuantity.Visible = True
        lblPresentYear.Visible = True
        lstYear.Visible = True
        lblPresentValue.Visible = True
        lstPresentValue.Visible = True
        lblYearDepreciation.Visible = True
        lstYearDepreciation.Visible = True
        lstTotalDepreciation.Visible = True
        lblTotalDepreciation.Visible = True
        'Clear the listboxes'
        lstYear.Items.Clear()
        lstPresentValue.Items.Clear()
        lstYearDepreciation.Items.Clear()
        lstYear.Items.Clear()
    End Sub

    Private Sub mnuDisplayInventory_Click(sender As Object, e As EventArgs) Handles mnuDisplayInventory.Click
        'When the user clicks 'display inventory' on the menu strip'
        Dim frmSecond As New frmDisplayInventory
        'Hide the current form and display the inventory form'
        Hide()
        frmSecond.ShowDialog()
    End Sub

    Private Sub mnuClear_Click(sender As Object, e As EventArgs) Handles mnuClear.Click
        'Clear the form'
        lstInventoryID.SelectedIndex = -1
        radStraightLine.Checked = False
        radDeclineBalance.Checked = False
        lblItem.Visible = False
        lblQuantity.Visible = False
        lblPresentYear.Visible = False
        lstYear.Visible = False
        lstYear.Items.Clear()
        lblPresentValue.Visible = False
        lstPresentValue.Visible = False
        lstPresentValue.Items.Clear()
        lblYearDepreciation.Visible = False
        lstYearDepreciation.Visible = False
        lstYearDepreciation.Items.Clear()
        lblTotalDepreciation.Visible = False
        lstTotalDepreciation.Visible = False
        lstTotalDepreciation.Items.Clear()
    End Sub
    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        'Closes the program'
        Close()
    End Sub
End Class
