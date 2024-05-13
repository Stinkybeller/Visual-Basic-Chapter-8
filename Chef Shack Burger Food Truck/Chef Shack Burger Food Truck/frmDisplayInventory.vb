'Display the inventory'
Option Strict On
Public Class frmDisplayInventory
    Private Sub frmDisplayInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Call the array from the previous form'
        Dim strItem As String

        'Sort the strArrInventoryItem Array'
        Array.Sort(frmFoodTruck.strArrInventoryItem)

        'Display content of the array into the listbox'
        For Each strItem In frmFoodTruck.strArrInventoryItem
            lstDisplay.Items.Add(strItem)
        Next
    End Sub
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        'Opens the main form'
        Dim frmFirst As New frmFoodTruck

        Hide()
        frmFirst.ShowDialog()
    End Sub
End Class