<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmpurchaseitems
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lvipurchaseitems = New System.Windows.Forms.ListView()
        Me.btnnew = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnpurchase = New System.Windows.Forms.Button()
        Me.txtpodrno = New System.Windows.Forms.TextBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.cboposuppliersname = New System.Windows.Forms.ComboBox()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.dtppoarrivaldate = New System.Windows.Forms.DateTimePicker()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.dtpporeceiptdelivery = New System.Windows.Forms.DateTimePicker()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtpodescription = New System.Windows.Forms.TextBox()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.cbopobrand = New System.Windows.Forms.ComboBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.cbopomodel = New System.Windows.Forms.ComboBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.cbopounit = New System.Windows.Forms.ComboBox()
        Me.txtpoquantity = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtpounitcost = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtpodiscount = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtponetcost = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtpototalamount = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtpomargin = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtposuggestedprice = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtpocanvassprice = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtpoterm = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtpordd = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtposellingarea = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtpobodega = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtposoldout = New System.Windows.Forms.TextBox()
        Me.txtpoavailable = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.dtpcurrentdate = New System.Windows.Forms.DateTimePicker()
        Me.txtpoproductid = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Gray
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1284, 38)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Purchase Order Item"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lvipurchaseitems
        '
        Me.lvipurchaseitems.FullRowSelect = True
        Me.lvipurchaseitems.Location = New System.Drawing.Point(-4, 246)
        Me.lvipurchaseitems.Name = "lvipurchaseitems"
        Me.lvipurchaseitems.Size = New System.Drawing.Size(1289, 375)
        Me.lvipurchaseitems.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lvipurchaseitems.TabIndex = 123
        Me.lvipurchaseitems.UseCompatibleStateImageBehavior = False
        Me.lvipurchaseitems.View = System.Windows.Forms.View.Details
        '
        'btnnew
        '
        Me.btnnew.BackColor = System.Drawing.Color.Gray
        Me.btnnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnew.ForeColor = System.Drawing.Color.White
        Me.btnnew.Location = New System.Drawing.Point(1106, 627)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(80, 30)
        Me.btnnew.TabIndex = 124
        Me.btnnew.Text = "New"
        Me.btnnew.UseVisualStyleBackColor = False
        '
        'btnedit
        '
        Me.btnedit.BackColor = System.Drawing.Color.Gray
        Me.btnedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnedit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnedit.ForeColor = System.Drawing.Color.White
        Me.btnedit.Location = New System.Drawing.Point(882, 627)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(80, 30)
        Me.btnedit.TabIndex = 125
        Me.btnedit.Text = "Edit"
        Me.btnedit.UseVisualStyleBackColor = False
        Me.btnedit.Visible = False
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.Color.Gray
        Me.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.ForeColor = System.Drawing.Color.White
        Me.btndelete.Location = New System.Drawing.Point(1192, 627)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(80, 30)
        Me.btndelete.TabIndex = 126
        Me.btndelete.Text = "Remove"
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'btnpurchase
        '
        Me.btnpurchase.BackColor = System.Drawing.Color.Gray
        Me.btnpurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnpurchase.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpurchase.ForeColor = System.Drawing.Color.White
        Me.btnpurchase.Location = New System.Drawing.Point(6, 627)
        Me.btnpurchase.Name = "btnpurchase"
        Me.btnpurchase.Size = New System.Drawing.Size(80, 30)
        Me.btnpurchase.TabIndex = 127
        Me.btnpurchase.Text = "Purchase"
        Me.btnpurchase.UseVisualStyleBackColor = False
        '
        'txtpodrno
        '
        Me.txtpodrno.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpodrno.Location = New System.Drawing.Point(41, 45)
        Me.txtpodrno.Name = "txtpodrno"
        Me.txtpodrno.Size = New System.Drawing.Size(122, 29)
        Me.txtpodrno.TabIndex = 131
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.BackColor = System.Drawing.Color.Transparent
        Me.Label42.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.Black
        Me.Label42.Location = New System.Drawing.Point(2, 51)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(33, 23)
        Me.Label42.TabIndex = 132
        Me.Label42.Text = "DR"
        '
        'cboposuppliersname
        '
        Me.cboposuppliersname.DropDownHeight = 200
        Me.cboposuppliersname.DropDownWidth = 350
        Me.cboposuppliersname.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboposuppliersname.FormattingEnabled = True
        Me.cboposuppliersname.IntegralHeight = False
        Me.cboposuppliersname.Location = New System.Drawing.Point(312, 44)
        Me.cboposuppliersname.Name = "cboposuppliersname"
        Me.cboposuppliersname.Size = New System.Drawing.Size(413, 32)
        Me.cboposuppliersname.Sorted = True
        Me.cboposuppliersname.TabIndex = 186
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.BackColor = System.Drawing.Color.Transparent
        Me.Label54.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.ForeColor = System.Drawing.Color.Black
        Me.Label54.Location = New System.Drawing.Point(193, 58)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(113, 18)
        Me.Label54.TabIndex = 187
        Me.Label54.Text = "Suppliers Name"
        '
        'dtppoarrivaldate
        '
        Me.dtppoarrivaldate.CustomFormat = "dd-MMM-yy"
        Me.dtppoarrivaldate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtppoarrivaldate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtppoarrivaldate.Location = New System.Drawing.Point(159, 107)
        Me.dtppoarrivaldate.Name = "dtppoarrivaldate"
        Me.dtppoarrivaldate.Size = New System.Drawing.Size(147, 26)
        Me.dtppoarrivaldate.TabIndex = 189
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.BackColor = System.Drawing.Color.Transparent
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ForeColor = System.Drawing.Color.DimGray
        Me.Label43.Location = New System.Drawing.Point(156, 89)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(69, 15)
        Me.Label43.TabIndex = 191
        Me.Label43.Text = "Arrival Date"
        '
        'dtpporeceiptdelivery
        '
        Me.dtpporeceiptdelivery.CustomFormat = "dd-MMM-yy"
        Me.dtpporeceiptdelivery.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpporeceiptdelivery.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpporeceiptdelivery.Location = New System.Drawing.Point(6, 107)
        Me.dtpporeceiptdelivery.Name = "dtpporeceiptdelivery"
        Me.dtpporeceiptdelivery.Size = New System.Drawing.Size(147, 26)
        Me.dtpporeceiptdelivery.TabIndex = 188
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.DimGray
        Me.Label20.Location = New System.Drawing.Point(3, 87)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(95, 15)
        Me.Label20.TabIndex = 190
        Me.Label20.Text = "Receipt Delivery"
        '
        'txtpodescription
        '
        Me.txtpodescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpodescription.Location = New System.Drawing.Point(312, 107)
        Me.txtpodescription.Name = "txtpodescription"
        Me.txtpodescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtpodescription.Size = New System.Drawing.Size(220, 26)
        Me.txtpodescription.TabIndex = 198
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.ForeColor = System.Drawing.Color.DimGray
        Me.Label47.Location = New System.Drawing.Point(312, 89)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(69, 15)
        Me.Label47.TabIndex = 199
        Me.Label47.Text = "Description"
        '
        'cbopobrand
        '
        Me.cbopobrand.DropDownWidth = 220
        Me.cbopobrand.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbopobrand.FormattingEnabled = True
        Me.cbopobrand.IntegralHeight = False
        Me.cbopobrand.Location = New System.Drawing.Point(538, 108)
        Me.cbopobrand.Name = "cbopobrand"
        Me.cbopobrand.Size = New System.Drawing.Size(187, 28)
        Me.cbopobrand.Sorted = True
        Me.cbopobrand.TabIndex = 200
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.Color.DimGray
        Me.Label44.Location = New System.Drawing.Point(535, 89)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(40, 15)
        Me.Label44.TabIndex = 201
        Me.Label44.Text = "Brand"
        '
        'cbopomodel
        '
        Me.cbopomodel.DropDownWidth = 220
        Me.cbopomodel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbopomodel.FormattingEnabled = True
        Me.cbopomodel.IntegralHeight = False
        Me.cbopomodel.Location = New System.Drawing.Point(731, 108)
        Me.cbopomodel.Name = "cbopomodel"
        Me.cbopomodel.Size = New System.Drawing.Size(187, 28)
        Me.cbopomodel.Sorted = True
        Me.cbopomodel.TabIndex = 202
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.ForeColor = System.Drawing.Color.DimGray
        Me.Label45.Location = New System.Drawing.Point(728, 89)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(80, 15)
        Me.Label45.TabIndex = 203
        Me.Label45.Text = "Model / Code"
        '
        'cbopounit
        '
        Me.cbopounit.DropDownWidth = 100
        Me.cbopounit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbopounit.FormattingEnabled = True
        Me.cbopounit.IntegralHeight = False
        Me.cbopounit.Location = New System.Drawing.Point(1059, 107)
        Me.cbopounit.Name = "cbopounit"
        Me.cbopounit.Size = New System.Drawing.Size(90, 28)
        Me.cbopounit.Sorted = True
        Me.cbopounit.TabIndex = 205
        '
        'txtpoquantity
        '
        Me.txtpoquantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpoquantity.Location = New System.Drawing.Point(924, 106)
        Me.txtpoquantity.Name = "txtpoquantity"
        Me.txtpoquantity.Size = New System.Drawing.Size(129, 29)
        Me.txtpoquantity.TabIndex = 204
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(921, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 15)
        Me.Label2.TabIndex = 206
        Me.Label2.Text = "Quantity"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(1051, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 15)
        Me.Label3.TabIndex = 207
        Me.Label3.Text = "Unit"
        '
        'txtpounitcost
        '
        Me.txtpounitcost.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpounitcost.Location = New System.Drawing.Point(5, 159)
        Me.txtpounitcost.Name = "txtpounitcost"
        Me.txtpounitcost.Size = New System.Drawing.Size(148, 29)
        Me.txtpounitcost.TabIndex = 220
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(3, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 15)
        Me.Label4.TabIndex = 221
        Me.Label4.Text = "Unit Cost"
        '
        'txtpodiscount
        '
        Me.txtpodiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpodiscount.Location = New System.Drawing.Point(164, 159)
        Me.txtpodiscount.Name = "txtpodiscount"
        Me.txtpodiscount.Size = New System.Drawing.Size(147, 29)
        Me.txtpodiscount.TabIndex = 222
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(164, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 15)
        Me.Label5.TabIndex = 223
        Me.Label5.Text = "Discount"
        '
        'txtponetcost
        '
        Me.txtponetcost.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtponetcost.Location = New System.Drawing.Point(322, 159)
        Me.txtponetcost.Name = "txtponetcost"
        Me.txtponetcost.ReadOnly = True
        Me.txtponetcost.Size = New System.Drawing.Size(150, 29)
        Me.txtponetcost.TabIndex = 224
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(322, 141)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 15)
        Me.Label6.TabIndex = 225
        Me.Label6.Text = "Net Cost"
        '
        'txtpototalamount
        '
        Me.txtpototalamount.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpototalamount.Location = New System.Drawing.Point(483, 159)
        Me.txtpototalamount.Name = "txtpototalamount"
        Me.txtpototalamount.ReadOnly = True
        Me.txtpototalamount.Size = New System.Drawing.Size(150, 29)
        Me.txtpototalamount.TabIndex = 226
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DimGray
        Me.Label7.Location = New System.Drawing.Point(480, 141)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 15)
        Me.Label7.TabIndex = 227
        Me.Label7.Text = "Total Amount"
        '
        'txtpomargin
        '
        Me.txtpomargin.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpomargin.Location = New System.Drawing.Point(644, 159)
        Me.txtpomargin.Name = "txtpomargin"
        Me.txtpomargin.Size = New System.Drawing.Size(157, 29)
        Me.txtpomargin.TabIndex = 228
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DimGray
        Me.Label8.Location = New System.Drawing.Point(641, 141)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 15)
        Me.Label8.TabIndex = 229
        Me.Label8.Text = "Margin"
        '
        'txtposuggestedprice
        '
        Me.txtposuggestedprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtposuggestedprice.Location = New System.Drawing.Point(812, 159)
        Me.txtposuggestedprice.Name = "txtposuggestedprice"
        Me.txtposuggestedprice.ReadOnly = True
        Me.txtposuggestedprice.Size = New System.Drawing.Size(150, 29)
        Me.txtposuggestedprice.TabIndex = 230
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DimGray
        Me.Label9.Location = New System.Drawing.Point(809, 141)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 15)
        Me.Label9.TabIndex = 231
        Me.Label9.Text = "Suggested Price"
        '
        'txtpocanvassprice
        '
        Me.txtpocanvassprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpocanvassprice.Location = New System.Drawing.Point(973, 159)
        Me.txtpocanvassprice.Name = "txtpocanvassprice"
        Me.txtpocanvassprice.Size = New System.Drawing.Size(150, 29)
        Me.txtpocanvassprice.TabIndex = 232
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DimGray
        Me.Label10.Location = New System.Drawing.Point(970, 141)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 15)
        Me.Label10.TabIndex = 233
        Me.Label10.Text = "Canvass Price"
        '
        'txtpoterm
        '
        Me.txtpoterm.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpoterm.Location = New System.Drawing.Point(5, 211)
        Me.txtpoterm.Name = "txtpoterm"
        Me.txtpoterm.ReadOnly = True
        Me.txtpoterm.Size = New System.Drawing.Size(131, 29)
        Me.txtpoterm.TabIndex = 235
        Me.txtpoterm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DimGray
        Me.Label11.Location = New System.Drawing.Point(3, 193)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 15)
        Me.Label11.TabIndex = 236
        Me.Label11.Text = "Varriance"
        '
        'txtpordd
        '
        Me.txtpordd.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpordd.Location = New System.Drawing.Point(147, 209)
        Me.txtpordd.Name = "txtpordd"
        Me.txtpordd.ReadOnly = True
        Me.txtpordd.Size = New System.Drawing.Size(131, 31)
        Me.txtpordd.TabIndex = 238
        Me.txtpordd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DimGray
        Me.Label12.Location = New System.Drawing.Point(144, 193)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(112, 15)
        Me.Label12.TabIndex = 239
        Me.Label12.Text = "Remarks Deys Def."
        '
        'txtposellingarea
        '
        Me.txtposellingarea.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtposellingarea.Location = New System.Drawing.Point(289, 211)
        Me.txtposellingarea.Name = "txtposellingarea"
        Me.txtposellingarea.ReadOnly = True
        Me.txtposellingarea.Size = New System.Drawing.Size(131, 29)
        Me.txtposellingarea.TabIndex = 240
        Me.txtposellingarea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.DimGray
        Me.Label13.Location = New System.Drawing.Point(289, 193)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(71, 15)
        Me.Label13.TabIndex = 241
        Me.Label13.Text = "Bodega Inv."
        '
        'txtpobodega
        '
        Me.txtpobodega.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpobodega.Location = New System.Drawing.Point(431, 211)
        Me.txtpobodega.Name = "txtpobodega"
        Me.txtpobodega.Size = New System.Drawing.Size(131, 29)
        Me.txtpobodega.TabIndex = 242
        Me.txtpobodega.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.DimGray
        Me.Label14.Location = New System.Drawing.Point(428, 193)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(94, 15)
        Me.Label14.TabIndex = 243
        Me.Label14.Text = "Selling Area Inv."
        '
        'txtposoldout
        '
        Me.txtposoldout.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtposoldout.Location = New System.Drawing.Point(573, 209)
        Me.txtposoldout.Name = "txtposoldout"
        Me.txtposoldout.Size = New System.Drawing.Size(131, 31)
        Me.txtposoldout.TabIndex = 244
        Me.txtposoldout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtpoavailable
        '
        Me.txtpoavailable.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpoavailable.Location = New System.Drawing.Point(715, 209)
        Me.txtpoavailable.Name = "txtpoavailable"
        Me.txtpoavailable.ReadOnly = True
        Me.txtpoavailable.Size = New System.Drawing.Size(131, 31)
        Me.txtpoavailable.TabIndex = 245
        Me.txtpoavailable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.DimGray
        Me.Label15.Location = New System.Drawing.Point(573, 193)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(54, 15)
        Me.Label15.TabIndex = 246
        Me.Label15.Text = "Sold Out"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.DimGray
        Me.Label16.Location = New System.Drawing.Point(712, 193)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(56, 15)
        Me.Label16.TabIndex = 247
        Me.Label16.Text = "Available"
        '
        'dtpcurrentdate
        '
        Me.dtpcurrentdate.CustomFormat = "dd-MMM-yy"
        Me.dtpcurrentdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpcurrentdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpcurrentdate.Location = New System.Drawing.Point(860, 44)
        Me.dtpcurrentdate.Name = "dtpcurrentdate"
        Me.dtpcurrentdate.Size = New System.Drawing.Size(220, 29)
        Me.dtpcurrentdate.TabIndex = 249
        Me.dtpcurrentdate.Visible = False
        '
        'txtpoproductid
        '
        Me.txtpoproductid.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpoproductid.Location = New System.Drawing.Point(1086, 45)
        Me.txtpoproductid.Name = "txtpoproductid"
        Me.txtpoproductid.Size = New System.Drawing.Size(186, 29)
        Me.txtpoproductid.TabIndex = 250
        Me.txtpoproductid.Visible = False
        '
        'frmpurchaseitems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 662)
        Me.Controls.Add(Me.dtpcurrentdate)
        Me.Controls.Add(Me.txtpoproductid)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtpoavailable)
        Me.Controls.Add(Me.txtposoldout)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtpobodega)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtposellingarea)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtpordd)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtpoterm)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtpocanvassprice)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtposuggestedprice)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtpomargin)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtpototalamount)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtponetcost)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtpodiscount)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtpounitcost)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbopounit)
        Me.Controls.Add(Me.txtpoquantity)
        Me.Controls.Add(Me.cbopomodel)
        Me.Controls.Add(Me.Label45)
        Me.Controls.Add(Me.cbopobrand)
        Me.Controls.Add(Me.Label44)
        Me.Controls.Add(Me.txtpodescription)
        Me.Controls.Add(Me.Label47)
        Me.Controls.Add(Me.dtppoarrivaldate)
        Me.Controls.Add(Me.Label43)
        Me.Controls.Add(Me.dtpporeceiptdelivery)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.cboposuppliersname)
        Me.Controls.Add(Me.Label54)
        Me.Controls.Add(Me.txtpodrno)
        Me.Controls.Add(Me.Label42)
        Me.Controls.Add(Me.btnpurchase)
        Me.Controls.Add(Me.btnnew)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.lvipurchaseitems)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmpurchaseitems"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmpurchaseitems"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lvipurchaseitems As System.Windows.Forms.ListView
    Friend WithEvents btnnew As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnpurchase As System.Windows.Forms.Button
    Friend WithEvents txtpodrno As System.Windows.Forms.TextBox
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents cboposuppliersname As System.Windows.Forms.ComboBox
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents dtppoarrivaldate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents dtpporeceiptdelivery As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtpodescription As System.Windows.Forms.TextBox
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents cbopobrand As System.Windows.Forms.ComboBox
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents cbopomodel As System.Windows.Forms.ComboBox
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents cbopounit As System.Windows.Forms.ComboBox
    Friend WithEvents txtpoquantity As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtpounitcost As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtpodiscount As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtponetcost As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtpototalamount As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtpomargin As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtposuggestedprice As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtpocanvassprice As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtpoterm As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtpordd As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtposellingarea As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtpobodega As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtposoldout As System.Windows.Forms.TextBox
    Friend WithEvents txtpoavailable As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents dtpcurrentdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtpoproductid As System.Windows.Forms.TextBox
End Class
