<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmOrderDetails
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBoxControls = New System.Windows.Forms.GroupBox()
        Me.DtShippedDate = New System.Windows.Forms.DateTimePicker()
        Me.DtRequiredDate = New System.Windows.Forms.DateTimePicker()
        Me.DtOrderDate = New System.Windows.Forms.DateTimePicker()
        Me.CbShipVia = New System.Windows.Forms.ComboBox()
        Me.CbCustomer = New System.Windows.Forms.ComboBox()
        Me.TbShipCountry = New System.Windows.Forms.TextBox()
        Me.TbPostalCode = New System.Windows.Forms.TextBox()
        Me.TbShipRegion = New System.Windows.Forms.TextBox()
        Me.TbShipCity = New System.Windows.Forms.TextBox()
        Me.TbShipAddress = New System.Windows.Forms.TextBox()
        Me.TbShipName = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TbFraight = New System.Windows.Forms.TextBox()
        Me.LbOrder = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DgvProducts = New System.Windows.Forms.DataGridView()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtNew = New System.Windows.Forms.Button()
        Me.BtSave = New System.Windows.Forms.Button()
        Me.BtDelete = New System.Windows.Forms.Button()
        Me.GroupBoxControls.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DgvProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxControls
        '
        Me.GroupBoxControls.Controls.Add(Me.DtShippedDate)
        Me.GroupBoxControls.Controls.Add(Me.DtRequiredDate)
        Me.GroupBoxControls.Controls.Add(Me.DtOrderDate)
        Me.GroupBoxControls.Controls.Add(Me.CbShipVia)
        Me.GroupBoxControls.Controls.Add(Me.CbCustomer)
        Me.GroupBoxControls.Controls.Add(Me.TbShipCountry)
        Me.GroupBoxControls.Controls.Add(Me.TbPostalCode)
        Me.GroupBoxControls.Controls.Add(Me.TbShipRegion)
        Me.GroupBoxControls.Controls.Add(Me.TbShipCity)
        Me.GroupBoxControls.Controls.Add(Me.TbShipAddress)
        Me.GroupBoxControls.Controls.Add(Me.TbShipName)
        Me.GroupBoxControls.Controls.Add(Me.Label10)
        Me.GroupBoxControls.Controls.Add(Me.Label11)
        Me.GroupBoxControls.Controls.Add(Me.Label12)
        Me.GroupBoxControls.Controls.Add(Me.Label13)
        Me.GroupBoxControls.Controls.Add(Me.Label14)
        Me.GroupBoxControls.Controls.Add(Me.Label15)
        Me.GroupBoxControls.Controls.Add(Me.TbFraight)
        Me.GroupBoxControls.Controls.Add(Me.LbOrder)
        Me.GroupBoxControls.Controls.Add(Me.Label7)
        Me.GroupBoxControls.Controls.Add(Me.Label6)
        Me.GroupBoxControls.Controls.Add(Me.Label5)
        Me.GroupBoxControls.Controls.Add(Me.Label4)
        Me.GroupBoxControls.Controls.Add(Me.Label3)
        Me.GroupBoxControls.Controls.Add(Me.Label2)
        Me.GroupBoxControls.Controls.Add(Me.Label1)
        Me.GroupBoxControls.Location = New System.Drawing.Point(12, 12)
        Me.GroupBoxControls.Name = "GroupBoxControls"
        Me.GroupBoxControls.Size = New System.Drawing.Size(1007, 202)
        Me.GroupBoxControls.TabIndex = 0
        Me.GroupBoxControls.TabStop = False
        '
        'DtShippedDate
        '
        Me.DtShippedDate.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.DtShippedDate.CustomFormat = "dd/MM/yyyy"
        Me.DtShippedDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtShippedDate.Location = New System.Drawing.Point(142, 112)
        Me.DtShippedDate.Name = "DtShippedDate"
        Me.DtShippedDate.Size = New System.Drawing.Size(136, 20)
        Me.DtShippedDate.TabIndex = 59
        Me.DtShippedDate.Value = New Date(2017, 12, 8, 14, 57, 36, 0)
        '
        'DtRequiredDate
        '
        Me.DtRequiredDate.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.DtRequiredDate.CustomFormat = "dd/MM/yyyy"
        Me.DtRequiredDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtRequiredDate.Location = New System.Drawing.Point(142, 86)
        Me.DtRequiredDate.Name = "DtRequiredDate"
        Me.DtRequiredDate.Size = New System.Drawing.Size(136, 20)
        Me.DtRequiredDate.TabIndex = 58
        Me.DtRequiredDate.Value = New Date(2017, 12, 8, 14, 57, 36, 0)
        '
        'DtOrderDate
        '
        Me.DtOrderDate.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.DtOrderDate.CustomFormat = "dd/MM/yyyy"
        Me.DtOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtOrderDate.Location = New System.Drawing.Point(142, 60)
        Me.DtOrderDate.Name = "DtOrderDate"
        Me.DtOrderDate.Size = New System.Drawing.Size(136, 20)
        Me.DtOrderDate.TabIndex = 57
        Me.DtOrderDate.Value = New Date(2017, 12, 8, 14, 57, 36, 0)
        '
        'CbShipVia
        '
        Me.CbShipVia.BackColor = System.Drawing.SystemColors.Menu
        Me.CbShipVia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbShipVia.FormattingEnabled = True
        Me.CbShipVia.Location = New System.Drawing.Point(142, 140)
        Me.CbShipVia.Name = "CbShipVia"
        Me.CbShipVia.Size = New System.Drawing.Size(343, 21)
        Me.CbShipVia.TabIndex = 56
        '
        'CbCustomer
        '
        Me.CbCustomer.BackColor = System.Drawing.SystemColors.Menu
        Me.CbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbCustomer.FormattingEnabled = True
        Me.CbCustomer.Location = New System.Drawing.Point(142, 33)
        Me.CbCustomer.Name = "CbCustomer"
        Me.CbCustomer.Size = New System.Drawing.Size(343, 21)
        Me.CbCustomer.TabIndex = 55
        '
        'TbShipCountry
        '
        Me.TbShipCountry.Location = New System.Drawing.Point(637, 162)
        Me.TbShipCountry.Name = "TbShipCountry"
        Me.TbShipCountry.Size = New System.Drawing.Size(343, 20)
        Me.TbShipCountry.TabIndex = 54
        '
        'TbPostalCode
        '
        Me.TbPostalCode.Location = New System.Drawing.Point(637, 136)
        Me.TbPostalCode.Name = "TbPostalCode"
        Me.TbPostalCode.Size = New System.Drawing.Size(343, 20)
        Me.TbPostalCode.TabIndex = 53
        '
        'TbShipRegion
        '
        Me.TbShipRegion.Location = New System.Drawing.Point(637, 112)
        Me.TbShipRegion.Name = "TbShipRegion"
        Me.TbShipRegion.Size = New System.Drawing.Size(343, 20)
        Me.TbShipRegion.TabIndex = 52
        '
        'TbShipCity
        '
        Me.TbShipCity.Location = New System.Drawing.Point(637, 86)
        Me.TbShipCity.Name = "TbShipCity"
        Me.TbShipCity.Size = New System.Drawing.Size(343, 20)
        Me.TbShipCity.TabIndex = 51
        '
        'TbShipAddress
        '
        Me.TbShipAddress.Location = New System.Drawing.Point(637, 60)
        Me.TbShipAddress.Name = "TbShipAddress"
        Me.TbShipAddress.Size = New System.Drawing.Size(343, 20)
        Me.TbShipAddress.TabIndex = 50
        '
        'TbShipName
        '
        Me.TbShipName.Location = New System.Drawing.Point(637, 34)
        Me.TbShipName.Name = "TbShipName"
        Me.TbShipName.Size = New System.Drawing.Size(343, 20)
        Me.TbShipName.TabIndex = 49
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(521, 169)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 13)
        Me.Label10.TabIndex = 48
        Me.Label10.Text = "Ship Country"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(521, 143)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 13)
        Me.Label11.TabIndex = 47
        Me.Label11.Text = "Ship Postal Code"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(521, 119)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 13)
        Me.Label12.TabIndex = 46
        Me.Label12.Text = "Ship Region"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(521, 93)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(48, 13)
        Me.Label13.TabIndex = 45
        Me.Label13.Text = "Ship City"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(521, 67)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(69, 13)
        Me.Label14.TabIndex = 44
        Me.Label14.Text = "Ship Address"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(521, 41)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(59, 13)
        Me.Label15.TabIndex = 43
        Me.Label15.Text = "Ship Name"
        '
        'TbFraight
        '
        Me.TbFraight.Location = New System.Drawing.Point(142, 166)
        Me.TbFraight.Name = "TbFraight"
        Me.TbFraight.Size = New System.Drawing.Size(110, 20)
        Me.TbFraight.TabIndex = 42
        '
        'LbOrder
        '
        Me.LbOrder.AutoSize = True
        Me.LbOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbOrder.ForeColor = System.Drawing.Color.Blue
        Me.LbOrder.Location = New System.Drawing.Point(139, 13)
        Me.LbOrder.Name = "LbOrder"
        Me.LbOrder.Size = New System.Drawing.Size(15, 13)
        Me.LbOrder.TabIndex = 38
        Me.LbOrder.Text = "#"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(26, 169)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Fraight"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 143)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Shipped Via"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Shipped Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Required Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Order Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Customer"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Order ID"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DgvProducts)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 254)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1007, 250)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'DgvProducts
        '
        Me.DgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvProducts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvProducts.Location = New System.Drawing.Point(3, 16)
        Me.DgvProducts.MultiSelect = False
        Me.DgvProducts.Name = "DgvProducts"
        Me.DgvProducts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvProducts.Size = New System.Drawing.Size(1001, 231)
        Me.DgvProducts.TabIndex = 1
        '
        'BtnClose
        '
        Me.BtnClose.Location = New System.Drawing.Point(860, 225)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(132, 23)
        Me.BtnClose.TabIndex = 2
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'BtNew
        '
        Me.BtNew.Location = New System.Drawing.Point(12, 225)
        Me.BtNew.Name = "BtNew"
        Me.BtNew.Size = New System.Drawing.Size(132, 23)
        Me.BtNew.TabIndex = 3
        Me.BtNew.Text = "New"
        Me.BtNew.UseVisualStyleBackColor = True
        '
        'BtSave
        '
        Me.BtSave.Location = New System.Drawing.Point(722, 225)
        Me.BtSave.Name = "BtSave"
        Me.BtSave.Size = New System.Drawing.Size(132, 23)
        Me.BtSave.TabIndex = 4
        Me.BtSave.Text = "Save"
        Me.BtSave.UseVisualStyleBackColor = True
        '
        'BtDelete
        '
        Me.BtDelete.Location = New System.Drawing.Point(158, 225)
        Me.BtDelete.Name = "BtDelete"
        Me.BtDelete.Size = New System.Drawing.Size(132, 23)
        Me.BtDelete.TabIndex = 5
        Me.BtDelete.Text = "Delete This Order"
        Me.BtDelete.UseVisualStyleBackColor = True
        '
        'FrmOrderDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1031, 528)
        Me.Controls.Add(Me.BtDelete)
        Me.Controls.Add(Me.BtSave)
        Me.Controls.Add(Me.BtNew)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBoxControls)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmOrderDetails"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Order Details "
        Me.GroupBoxControls.ResumeLayout(False)
        Me.GroupBoxControls.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DgvProducts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBoxControls As GroupBox
    Friend WithEvents CbShipVia As ComboBox
    Friend WithEvents CbCustomer As ComboBox
    Friend WithEvents TbShipCountry As TextBox
    Friend WithEvents TbPostalCode As TextBox
    Friend WithEvents TbShipRegion As TextBox
    Friend WithEvents TbShipCity As TextBox
    Friend WithEvents TbShipAddress As TextBox
    Friend WithEvents TbShipName As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents TbFraight As TextBox
    Friend WithEvents LbOrder As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DtOrderDate As DateTimePicker
    Friend WithEvents DtShippedDate As DateTimePicker
    Friend WithEvents DtRequiredDate As DateTimePicker
    Friend WithEvents BtnClose As Button
    Friend WithEvents BtNew As Button
    Friend WithEvents BtSave As Button
    Friend WithEvents DgvProducts As DataGridView
    Friend WithEvents BtDelete As Button
End Class
