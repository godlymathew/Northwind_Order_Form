Public Class FrmOrderList
    Private Sub FrmOrderList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeOrderForm()
    End Sub

    Public Sub InitializeOrderForm()
        Dim dTable = AppFunctions.GetOrderList()
        If Not dTable Is Nothing Then
            DgvOrders.DataSource = dTable
        End If
    End Sub

    Private Sub DgvOrders_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvOrders.CellDoubleClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            LoadOrderDeatils(e.RowIndex)
        End If
    End Sub

    Private Sub FrmOrderList_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Application.Exit()
    End Sub

    Private Sub BtNewOrder_Click(sender As Object, e As EventArgs) Handles BtNewOrder.Click
        Dim frm As New FrmOrderDetails(Me)
        frm.InitailizeForm()
        frm.ShowDialog()
    End Sub

    Private Sub Btrefresh_Click(sender As Object, e As EventArgs) Handles Btrefresh.Click
        InitializeOrderForm()
    End Sub

    Private Sub BtEditOrder_Click(sender As Object, e As EventArgs) Handles BtEditOrder.Click
        Dim rowIndex = DgvOrders.CurrentRow.Index
        If rowIndex >= 0 AndAlso rowIndex >= 0 Then
            LoadOrderDeatils(rowIndex)
        End If
    End Sub

    Private Sub LoadOrderDeatils(rowIndex As Long)
        Dim selectedRow = DgvOrders.Rows(rowIndex)
        Dim orderID = CLng(selectedRow.Cells(0).Value)
        Dim frm As New FrmOrderDetails(Me)
        frm.InitailizeForm()
        frm.BindOrderDetails(orderID)
        frm.ShowDialog()
    End Sub

End Class
