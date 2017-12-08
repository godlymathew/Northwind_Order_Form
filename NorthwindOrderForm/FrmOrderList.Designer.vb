<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOrderList
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DgvOrders = New System.Windows.Forms.DataGridView()
        Me.BtNewOrder = New System.Windows.Forms.Button()
        Me.Btrefresh = New System.Windows.Forms.Button()
        Me.BtEditOrder = New System.Windows.Forms.Button()
        Me.CbEmployee = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgvOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.DgvOrders)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(907, 429)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Orders"
        '
        'DgvOrders
        '
        Me.DgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvOrders.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvOrders.Location = New System.Drawing.Point(3, 16)
        Me.DgvOrders.MultiSelect = False
        Me.DgvOrders.Name = "DgvOrders"
        Me.DgvOrders.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvOrders.Size = New System.Drawing.Size(901, 410)
        Me.DgvOrders.TabIndex = 0
        '
        'BtNewOrder
        '
        Me.BtNewOrder.Location = New System.Drawing.Point(479, 10)
        Me.BtNewOrder.Name = "BtNewOrder"
        Me.BtNewOrder.Size = New System.Drawing.Size(75, 23)
        Me.BtNewOrder.TabIndex = 1
        Me.BtNewOrder.Text = "New Order"
        Me.BtNewOrder.UseVisualStyleBackColor = True
        '
        'Btrefresh
        '
        Me.Btrefresh.Location = New System.Drawing.Point(652, 10)
        Me.Btrefresh.Name = "Btrefresh"
        Me.Btrefresh.Size = New System.Drawing.Size(75, 23)
        Me.Btrefresh.TabIndex = 2
        Me.Btrefresh.Text = "Refresh"
        Me.Btrefresh.UseVisualStyleBackColor = True
        '
        'BtEditOrder
        '
        Me.BtEditOrder.Location = New System.Drawing.Point(560, 10)
        Me.BtEditOrder.Name = "BtEditOrder"
        Me.BtEditOrder.Size = New System.Drawing.Size(86, 23)
        Me.BtEditOrder.TabIndex = 3
        Me.BtEditOrder.Text = "Edit Order"
        Me.BtEditOrder.UseVisualStyleBackColor = True
        '
        'CbEmployee
        '
        Me.CbEmployee.BackColor = System.Drawing.SystemColors.Window
        Me.CbEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbEmployee.FormattingEnabled = True
        Me.CbEmployee.Location = New System.Drawing.Point(80, 12)
        Me.CbEmployee.Name = "CbEmployee"
        Me.CbEmployee.Size = New System.Drawing.Size(393, 21)
        Me.CbEmployee.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Employee"
        '
        'FrmOrderList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(931, 482)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CbEmployee)
        Me.Controls.Add(Me.BtEditOrder)
        Me.Controls.Add(Me.Btrefresh)
        Me.Controls.Add(Me.BtNewOrder)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmOrderList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Northwind- Order Form"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DgvOrders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DgvOrders As DataGridView
    Friend WithEvents BtNewOrder As Button
    Friend WithEvents Btrefresh As Button
    Friend WithEvents BtEditOrder As Button
    Friend WithEvents CbEmployee As ComboBox
    Friend WithEvents Label1 As Label
End Class
