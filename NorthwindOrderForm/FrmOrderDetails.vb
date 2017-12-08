Public Class FrmOrderDetails

    Private _FrmOrderList As FrmOrderList

    Public Sub New(frm As FrmOrderList)
        InitializeComponent()
        _FrmOrderList = frm
    End Sub


    Private FormMode As String = "New"
    Private _OrderID As Long = 0
    Private Sub FrmOrderDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub InitailizeForm()
        Dim dTables = AppFunctions.GetOrderDetailsDropDowns()
        For Each dt As DataTable In dTables.Tables
            If dt.Columns(0).ColumnName = "CustomerID" Then
                CbCustomer.DataSource = dt
                CbCustomer.DisplayMember = "CompanyName"
                CbCustomer.ValueMember = "CustomerID"
            ElseIf dt.Columns(0).ColumnName = "ShipperID" Then
                CbShipVia.DataSource = dt
                CbShipVia.DisplayMember = "CompanyName"
                CbShipVia.ValueMember = "ShipperID"
            End If
        Next
    End Sub


    Public Sub BindOrderDetails(orderId As Long)
        FormMode = "Edit"
        BtSave.Text = "Update"
        _OrderID = orderId
        Dim dTable = AppFunctions.GetOrderDetails(_OrderID)

        LbOrder.Text = _OrderID
        For Each dr As DataRow In dTable.Rows
            DtOrderDate.Value = dr("OrderDate").ToString()
            DtRequiredDate.Value = dr("RequiredDate").ToString()
            DtShippedDate.Value = dr("ShippedDate").ToString()
            TbShipName.Text = dr("ShipName").ToString()
            TbFraight.Text = dr("Freight").ToString()
            TbShipAddress.Text = dr("ShipAddress").ToString()
            TbPostalCode.Text = dr("ShipPostalCode").ToString()
            TbShipCity.Text = dr("ShipCity").ToString()
            TbShipRegion.Text = dr("ShipRegion").ToString()
            TbShipCountry.Text = dr("ShipCountry").ToString()
            SelectComboxValue(CbCustomer, dr("CustomerID"))
            SelectComboxValue(CbShipVia, dr("ShipVia"))
        Next
        GetProductsDetails()
    End Sub

    Private Sub GetProductsDetails()
        DgvProducts.DataSource = AppFunctions.GetProductsDetails(_OrderID)
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtNew_Click(sender As Object, e As EventArgs) Handles BtNew.Click
        ClearAll()
    End Sub

    Private Sub BtSave_Click(sender As Object, e As EventArgs) Handles BtSave.Click
        Dim sqlsParams As Dictionary(Of String, String)
        Try

            sqlsParams = New Dictionary(Of String, String) From {
            {"CustomerID", SqlStringData(CbCustomer.SelectedValue)},
            {"EmployeeID", 5},
            {"OrderDate", SqlStringData(DtOrderDate.Value.ToString("yyyy/MM/dd"))},
            {"RequiredDate", SqlStringData(DtRequiredDate.Value.ToString("yyyy/MM/dd"))},
            {"ShippedDate", SqlStringData(DtShippedDate.Value.ToString("yyyy/MM/dd"))},
            {"Freight", Convert.ToDecimal(TbFraight.Text)},
            {"ShipVia", CInt(CbShipVia.SelectedValue)},
            {"ShipName", SqlStringData(TbShipName.Text)},
            {"ShipAddress", SqlStringData(TbShipAddress.Text)},
            {"ShipCity", SqlStringData(TbShipCity.Text)},
            {"ShipRegion", SqlStringData(TbShipRegion.Text)},
            {"ShipPostalCode", SqlStringData(TbPostalCode.Text)},
            {"ShipCountry", SqlStringData(TbShipCountry.Text)}
        }
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Information", MessageBoxButtons.OK)
            Return
        End Try
        If AppFunctions.SaveOrderDetails(sqlsParams, FormMode, _OrderID) Then
            MessageBox.Show("Successfully Saved", "Information", MessageBoxButtons.OK)
            ClearAll()
            _FrmOrderList.InitializeOrderForm()
        Else
            MessageBox.Show(AppFunctions.LastException, "Exception", MessageBoxButtons.OK)
        End If
    End Sub

    Private Function SqlStringData(value As String) As String
        Return "'" + value + "'"
    End Function

    Private Sub ClearAll()
        FormMode = "New"
        BtSave.Text = "Save"
        DgvProducts.DataSource = Nothing
        TbFraight.Text = ""
        TbPostalCode.Text = ""
        TbShipAddress.Text = ""
        TbShipCity.Text = ""
        TbShipCountry.Text = ""
        TbShipName.Text = ""
        TbShipRegion.Text = ""
        CbCustomer.SelectedIndex = 0
        CbShipVia.SelectedIndex = 0
        LbOrder.Text = "#"
        _OrderID = 0

    End Sub

    Private Sub BtDelete_Click(sender As Object, e As EventArgs) Handles BtDelete.Click
        If _OrderID = 0 Then
            Exit Sub
        End If
        If (MessageBox.Show("Are you sure want to delete this?.", "", MessageBoxButtons.YesNo) = DialogResult.Yes) Then
            If AppFunctions.DeleteOrder(_OrderID) Then
                ClearAll()
                _FrmOrderList.InitializeOrderForm()
            Else
                MessageBox.Show(AppFunctions.LastException, "Exception", MessageBoxButtons.OK)
            End If
        End If
    End Sub
    Private Sub SelectComboxValue(ctrl As ComboBox, value As Object)
        '' ShortCut logic....
        Dim itemValue As String = value.ToString()
        Try
            ctrl.SelectedValue = itemValue
        Catch ex As Exception
            ctrl.SelectedIndex = 0
        End Try
    End Sub
End Class