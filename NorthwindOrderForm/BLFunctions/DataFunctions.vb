Imports System.Data.SqlClient

Public Class DataConnection
    Public Shared Function DbConnectionString() As String
        Return My.Settings.DBConnectionString
    End Function
End Class


Public Class AppFunctions

    Public Shared LastException As String = ""

    Public Shared Function GetOrderList() As DataTable
        Dim sql = "
                Select Orders.OrderID,Customers.CompanyName, convert(varchar,Orders.OrderDate,103) as OrderDate,
                convert(varchar,Orders.RequiredDate,103) as RequiredDate,isnull(convert(varchar,Orders.ShippedDate,103),'') as ShippedDate,
                Employees.Firstname +' ' +Employees.LastName as [Employee Name]
                from Orders
                inner Join Customers on Customers.CustomerID = Orders.CustomerID
                INNER JOIN Employees on Employees.EmployeeID = Orders.EmployeeID 
                order by Orders.OrderDate desc
                "
        Dim dTable As DataTable
        Using sqlCon As New SqlConnection(DataConnection.DbConnectionString)
            Dim sqlCom As New SqlCommand(sql, sqlCon)
            sqlCon.Open()
            Dim sqlDataReader = sqlCom.ExecuteReader(CommandBehavior.CloseConnection)
            dTable = New DataTable
            dTable.Load(sqlDataReader)
        End Using
        Return dTable
    End Function
    Public Shared Function GetOrderDetailsDropDowns() As DataSet
        Dim sql = "
               Select '' as CustomerID, '-- Select--' CompanyName Union All  Select CustomerID,CompanyName from Customers;
               Select '' as ShipperID, '-- Select--' CompanyName Union All  select ShipperID,CompanyName from Shippers;
                "
        Dim dSet As New DataSet
        Using sqlCon As New SqlConnection(DataConnection.DbConnectionString)
            Dim sqlCom As New SqlCommand(sql, sqlCon)
            sqlCon.Open()
            Dim sqlDataAdp = New SqlDataAdapter With {
                .SelectCommand = sqlCom
            }
            sqlCon.Close()
            sqlDataAdp.Fill(dSet)
        End Using
        Return dSet
    End Function
    Public Shared Function GetOrderDetails(orderID As Long) As DataTable
        Dim sql = "SELECT OrderID, CustomerID, EmployeeID, isnull(OrderDate,'') as OrderDate, isnull(RequiredDate,'') as RequiredDate, isnull(ShippedDate,'') as ShippedDate, ShipVia, Freight, ShipName, ShipAddress, ShipCity, ShipRegion, ShipPostalCode, ShipCountry
            FROM Orders
            WHERE Orders.OrderID = @OrderID"
        Dim dTable As DataTable
        Using sqlCon As New SqlConnection(DataConnection.DbConnectionString)
            Dim sqlCom As New SqlCommand(sql, sqlCon)
            sqlCom.Parameters.AddWithValue("@OrderID", orderID)
            sqlCon.Open()
            Dim sqlDataReader = sqlCom.ExecuteReader(CommandBehavior.CloseConnection)
            dTable = New DataTable
            dTable.Load(sqlDataReader)
        End Using
        Return dTable
    End Function
    Public Shared Function GetProductsDetails(orderID As Long) As DataTable
        Dim sql = "select [Order Details].ProductID,Products.ProductName,Products.UnitPrice,Quantity,Discount from [Order Details]
                    inner join Products on Products.ProductID = [Order Details].ProductID
                    WHERE [Order Details].OrderID = @OrderID"
        Dim dTable As DataTable
        Using sqlCon As New SqlConnection(DataConnection.DbConnectionString)
            Dim sqlCom As New SqlCommand(sql, sqlCon)
            sqlCom.Parameters.AddWithValue("@OrderID", orderID)
            sqlCon.Open()
            Dim sqlDataReader = sqlCom.ExecuteReader(CommandBehavior.CloseConnection)
            dTable = New DataTable
            dTable.Load(sqlDataReader)
        End Using
        Return dTable
    End Function
    Public Shared Function SaveOrderDetails(params As Dictionary(Of String, String), scope As String, orderID As Long) As Boolean
        Dim sqlInsert As String = "INSERT INTO ORDERS({0}) values({1})"
        Dim sqlUpdate As String = "UPDATE ORDERS  SET {0} WHERE OrderID = {1}"
        Dim listKey As New List(Of String)
        Dim listvalues As New List(Of String)
        Dim sqlScript = ""
        If scope = "New" Then
            For Each item As KeyValuePair(Of String, String) In params
                listKey.Add(item.Key)
                listvalues.Add(item.Value)
            Next
            sqlScript = String.Format(sqlInsert, String.Join(",", listKey), String.Join(",", listvalues))
        ElseIf scope = "Edit" Then
            For Each item As KeyValuePair(Of String, String) In params
                listKey.Add(item.Key + " = " + item.Value)
            Next
            sqlScript = String.Format(sqlUpdate, String.Join(",", listKey), orderID)
        Else
            Return False
        End If
        Try
            Using sqlCon As New SqlConnection(DataConnection.DbConnectionString)
                Dim sqlCom As New SqlCommand(sqlScript, sqlCon)
                sqlCon.Open()
                sqlCom.ExecuteNonQuery()
                sqlCon.Close()
            End Using
        Catch ex As Exception
            LastException = ex.Message.ToString
            Return False
        End Try
        Return True
    End Function

    Public Shared Function DeleteOrder(orderID As Long) As Boolean
        Dim sqlScript = "DELETE FROM ORDERS WHERE OrderID = @OrderID"
        Try
            Using sqlCon As New SqlConnection(DataConnection.DbConnectionString)
                Dim sqlCom As New SqlCommand(sqlScript, sqlCon)
                sqlCom.Parameters.AddWithValue("@OrderID", orderID)
                sqlCon.Open()
                sqlCom.ExecuteNonQuery()
                sqlCon.Close()
            End Using
        Catch ex As Exception
            LastException = ex.Message.ToString
            Return False
        End Try
        Return True
    End Function

End Class