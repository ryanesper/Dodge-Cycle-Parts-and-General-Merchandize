<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmpurchaseitem
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
        Me.txtpodrno = New System.Windows.Forms.TextBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.cboposuppliersname = New System.Windows.Forms.ComboBox()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.dtppoarrivaldate = New System.Windows.Forms.DateTimePicker()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.dtpporeceiptdelivery = New System.Windows.Forms.DateTimePicker()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cbopobrand = New System.Windows.Forms.ComboBox()
        Me.cbopomodel = New System.Windows.Forms.ComboBox()
        Me.cbopounit = New System.Windows.Forms.ComboBox()
        Me.txtpoquantity = New System.Windows.Forms.TextBox()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.txtpodescription = New System.Windows.Forms.TextBox()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.btnnew = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.txtpocanvassprice = New System.Windows.Forms.TextBox()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.txtposuggestedprice = New System.Windows.Forms.TextBox()
        Me.txtpomargin = New System.Windows.Forms.TextBox()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.txtpototalamount = New System.Windows.Forms.TextBox()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.txtponetcost = New System.Windows.Forms.TextBox()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.txtpounitcost = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtpodiscount = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.txtpobodega = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtposellingarea = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtpoavailable = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtposoldout = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtpordd = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtpoterm = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtpoproductid = New System.Windows.Forms.TextBox()
        Me.dtpcurrentdate = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Gray
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1037, 42)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Purchase Order Item"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtpodrno
        '
        Me.txtpodrno.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpodrno.Location = New System.Drawing.Point(48, 69)
        Me.txtpodrno.Name = "txtpodrno"
        Me.txtpodrno.Size = New System.Drawing.Size(122, 29)
        Me.txtpodrno.TabIndex = 1
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.BackColor = System.Drawing.Color.Transparent
        Me.Label42.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.Black
        Me.Label42.Location = New System.Drawing.Point(9, 75)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(33, 23)
        Me.Label42.TabIndex = 130
        Me.Label42.Text = "DR"
        '
        'cboposuppliersname
        '
        Me.cboposuppliersname.DropDownHeight = 200
        Me.cboposuppliersname.DropDownWidth = 350
        Me.cboposuppliersname.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboposuppliersname.FormattingEnabled = True
        Me.cboposuppliersname.IntegralHeight = False
        Me.cboposuppliersname.Location = New System.Drawing.Point(137, 124)
        Me.cboposuppliersname.Name = "cboposuppliersname"
        Me.cboposuppliersname.Size = New System.Drawing.Size(220, 32)
        Me.cboposuppliersname.Sorted = True
        Me.cboposuppliersname.TabIndex = 2
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.BackColor = System.Drawing.Color.Transparent
        Me.Label54.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.ForeColor = System.Drawing.Color.Black
        Me.Label54.Location = New System.Drawing.Point(10, 138)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(113, 18)
        Me.Label54.TabIndex = 185
        Me.Label54.Text = "Suppliers Name"
        '
        'dtppoarrivaldate
        '
        Me.dtppoarrivaldate.CustomFormat = "dd-MMM-yy"
        Me.dtppoarrivaldate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtppoarrivaldate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtppoarrivaldate.Location = New System.Drawing.Point(137, 198)
        Me.dtppoarrivaldate.Name = "dtppoarrivaldate"
        Me.dtppoarrivaldate.Size = New System.Drawing.Size(220, 29)
        Me.dtppoarrivaldate.TabIndex = 4
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.BackColor = System.Drawing.Color.Transparent
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ForeColor = System.Drawing.Color.Black
        Me.Label43.Location = New System.Drawing.Point(10, 209)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(83, 18)
        Me.Label43.TabIndex = 183
        Me.Label43.Text = "Arrival Date"
        '
        'dtpporeceiptdelivery
        '
        Me.dtpporeceiptdelivery.CustomFormat = "dd-MMM-yy"
        Me.dtpporeceiptdelivery.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpporeceiptdelivery.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpporeceiptdelivery.Location = New System.Drawing.Point(137, 163)
        Me.dtpporeceiptdelivery.Name = "dtpporeceiptdelivery"
        Me.dtpporeceiptdelivery.Size = New System.Drawing.Size(220, 29)
        Me.dtpporeceiptdelivery.TabIndex = 3
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(10, 174)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(114, 18)
        Me.Label20.TabIndex = 181
        Me.Label20.Text = "Receipt Delivery"
        '
        'cbopobrand
        '
        Me.cbopobrand.DropDownWidth = 220
        Me.cbopobrand.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbopobrand.FormattingEnabled = True
        Me.cbopobrand.IntegralHeight = False
        Me.cbopobrand.Location = New System.Drawing.Point(137, 299)
        Me.cbopobrand.Name = "cbopobrand"
        Me.cbopobrand.Size = New System.Drawing.Size(220, 32)
        Me.cbopobrand.Sorted = True
        Me.cbopobrand.TabIndex = 6
        '
        'cbopomodel
        '
        Me.cbopomodel.DropDownWidth = 220
        Me.cbopomodel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbopomodel.FormattingEnabled = True
        Me.cbopomodel.IntegralHeight = False
        Me.cbopomodel.Location = New System.Drawing.Point(137, 337)
        Me.cbopomodel.Name = "cbopomodel"
        Me.cbopomodel.Size = New System.Drawing.Size(220, 32)
        Me.cbopomodel.Sorted = True
        Me.cbopomodel.TabIndex = 7
        '
        'cbopounit
        '
        Me.cbopounit.DropDownWidth = 100
        Me.cbopounit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbopounit.FormattingEnabled = True
        Me.cbopounit.IntegralHeight = False
        Me.cbopounit.Location = New System.Drawing.Point(267, 375)
        Me.cbopounit.Name = "cbopounit"
        Me.cbopounit.Size = New System.Drawing.Size(90, 28)
        Me.cbopounit.Sorted = True
        Me.cbopounit.TabIndex = 9
        '
        'txtpoquantity
        '
        Me.txtpoquantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpoquantity.Location = New System.Drawing.Point(137, 375)
        Me.txtpoquantity.Name = "txtpoquantity"
        Me.txtpoquantity.Size = New System.Drawing.Size(129, 29)
        Me.txtpoquantity.TabIndex = 8
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.Location = New System.Drawing.Point(10, 386)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(62, 18)
        Me.Label46.TabIndex = 201
        Me.Label46.Text = "Quantity"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.Location = New System.Drawing.Point(10, 351)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(97, 18)
        Me.Label45.TabIndex = 199
        Me.Label45.Text = "Model / Code"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(10, 313)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(47, 18)
        Me.Label44.TabIndex = 198
        Me.Label44.Text = "Brand"
        '
        'txtpodescription
        '
        Me.txtpodescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpodescription.Location = New System.Drawing.Point(137, 233)
        Me.txtpodescription.Multiline = True
        Me.txtpodescription.Name = "txtpodescription"
        Me.txtpodescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtpodescription.Size = New System.Drawing.Size(220, 60)
        Me.txtpodescription.TabIndex = 5
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.Location = New System.Drawing.Point(10, 233)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(83, 18)
        Me.Label47.TabIndex = 197
        Me.Label47.Text = "Description"
        '
        'btnnew
        '
        Me.btnnew.BackColor = System.Drawing.Color.Gray
        Me.btnnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnew.ForeColor = System.Drawing.Color.White
        Me.btnnew.Location = New System.Drawing.Point(771, 464)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(80, 35)
        Me.btnnew.TabIndex = 23
        Me.btnnew.Text = "New"
        Me.btnnew.UseVisualStyleBackColor = False
        '
        'btnedit
        '
        Me.btnedit.BackColor = System.Drawing.Color.Gray
        Me.btnedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnedit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnedit.ForeColor = System.Drawing.Color.White
        Me.btnedit.Location = New System.Drawing.Point(857, 464)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(80, 35)
        Me.btnedit.TabIndex = 24
        Me.btnedit.Text = "Edit"
        Me.btnedit.UseVisualStyleBackColor = False
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.Color.Gray
        Me.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.ForeColor = System.Drawing.Color.White
        Me.btndelete.Location = New System.Drawing.Point(943, 464)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(80, 35)
        Me.btndelete.TabIndex = 25
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'txtpocanvassprice
        '
        Me.txtpocanvassprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpocanvassprice.Location = New System.Drawing.Point(516, 367)
        Me.txtpocanvassprice.Name = "txtpocanvassprice"
        Me.txtpocanvassprice.Size = New System.Drawing.Size(197, 31)
        Me.txtpocanvassprice.TabIndex = 16
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.Location = New System.Drawing.Point(392, 380)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(96, 18)
        Me.Label53.TabIndex = 217
        Me.Label53.Text = "Canvas Price"
        '
        'txtposuggestedprice
        '
        Me.txtposuggestedprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtposuggestedprice.Location = New System.Drawing.Point(516, 323)
        Me.txtposuggestedprice.Name = "txtposuggestedprice"
        Me.txtposuggestedprice.ReadOnly = True
        Me.txtposuggestedprice.Size = New System.Drawing.Size(197, 38)
        Me.txtposuggestedprice.TabIndex = 15
        '
        'txtpomargin
        '
        Me.txtpomargin.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpomargin.Location = New System.Drawing.Point(516, 286)
        Me.txtpomargin.Name = "txtpomargin"
        Me.txtpomargin.Size = New System.Drawing.Size(197, 31)
        Me.txtpomargin.TabIndex = 14
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.Location = New System.Drawing.Point(392, 299)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(80, 18)
        Me.Label51.TabIndex = 214
        Me.Label51.Text = "Margin (%)"
        '
        'txtpototalamount
        '
        Me.txtpototalamount.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpototalamount.Location = New System.Drawing.Point(516, 242)
        Me.txtpototalamount.Name = "txtpototalamount"
        Me.txtpototalamount.ReadOnly = True
        Me.txtpototalamount.Size = New System.Drawing.Size(197, 38)
        Me.txtpototalamount.TabIndex = 13
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.Location = New System.Drawing.Point(392, 262)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(96, 18)
        Me.Label50.TabIndex = 212
        Me.Label50.Text = "Total Amount"
        '
        'txtponetcost
        '
        Me.txtponetcost.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtponetcost.Location = New System.Drawing.Point(516, 198)
        Me.txtponetcost.Name = "txtponetcost"
        Me.txtponetcost.ReadOnly = True
        Me.txtponetcost.Size = New System.Drawing.Size(197, 38)
        Me.txtponetcost.TabIndex = 12
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.Location = New System.Drawing.Point(392, 218)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(67, 18)
        Me.Label49.TabIndex = 210
        Me.Label49.Text = "Net Cost"
        '
        'txtpounitcost
        '
        Me.txtpounitcost.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpounitcost.Location = New System.Drawing.Point(516, 124)
        Me.txtpounitcost.Name = "txtpounitcost"
        Me.txtpounitcost.Size = New System.Drawing.Size(197, 31)
        Me.txtpounitcost.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(392, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 18)
        Me.Label2.TabIndex = 219
        Me.Label2.Text = "Unit Cost"
        '
        'txtpodiscount
        '
        Me.txtpodiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpodiscount.Location = New System.Drawing.Point(516, 161)
        Me.txtpodiscount.Name = "txtpodiscount"
        Me.txtpodiscount.Size = New System.Drawing.Size(197, 31)
        Me.txtpodiscount.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(392, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 18)
        Me.Label3.TabIndex = 221
        Me.Label3.Text = "Discount (%)"
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.Location = New System.Drawing.Point(392, 343)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(116, 18)
        Me.Label52.TabIndex = 223
        Me.Label52.Text = "Suggested Price"
        '
        'txtpobodega
        '
        Me.txtpobodega.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpobodega.Location = New System.Drawing.Point(892, 196)
        Me.txtpobodega.Name = "txtpobodega"
        Me.txtpobodega.ReadOnly = True
        Me.txtpobodega.Size = New System.Drawing.Size(131, 29)
        Me.txtpobodega.TabIndex = 20
        Me.txtpobodega.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(755, 207)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 18)
        Me.Label4.TabIndex = 230
        Me.Label4.Text = "Bodega Inv."
        '
        'txtposellingarea
        '
        Me.txtposellingarea.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtposellingarea.Location = New System.Drawing.Point(892, 234)
        Me.txtposellingarea.Name = "txtposellingarea"
        Me.txtposellingarea.Size = New System.Drawing.Size(131, 29)
        Me.txtposellingarea.TabIndex = 19
        Me.txtposellingarea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(755, 245)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 18)
        Me.Label5.TabIndex = 228
        Me.Label5.Text = "Selling Area Inv."
        '
        'txtpoavailable
        '
        Me.txtpoavailable.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpoavailable.Location = New System.Drawing.Point(892, 308)
        Me.txtpoavailable.Name = "txtpoavailable"
        Me.txtpoavailable.ReadOnly = True
        Me.txtpoavailable.Size = New System.Drawing.Size(131, 31)
        Me.txtpoavailable.TabIndex = 22
        Me.txtpoavailable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(755, 321)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 18)
        Me.Label6.TabIndex = 226
        Me.Label6.Text = "Available"
        '
        'txtposoldout
        '
        Me.txtposoldout.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtposoldout.Location = New System.Drawing.Point(892, 271)
        Me.txtposoldout.Name = "txtposoldout"
        Me.txtposoldout.Size = New System.Drawing.Size(131, 31)
        Me.txtposoldout.TabIndex = 21
        Me.txtposoldout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(755, 284)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 18)
        Me.Label7.TabIndex = 224
        Me.Label7.Text = "Sold Out"
        '
        'txtpordd
        '
        Me.txtpordd.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpordd.Location = New System.Drawing.Point(892, 159)
        Me.txtpordd.Name = "txtpordd"
        Me.txtpordd.ReadOnly = True
        Me.txtpordd.Size = New System.Drawing.Size(131, 31)
        Me.txtpordd.TabIndex = 18
        Me.txtpordd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(755, 172)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(138, 18)
        Me.Label8.TabIndex = 233
        Me.Label8.Text = "Remarks Days Def."
        '
        'txtpoterm
        '
        Me.txtpoterm.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpoterm.Location = New System.Drawing.Point(892, 124)
        Me.txtpoterm.Name = "txtpoterm"
        Me.txtpoterm.ReadOnly = True
        Me.txtpoterm.Size = New System.Drawing.Size(131, 29)
        Me.txtpoterm.TabIndex = 17
        Me.txtpoterm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(755, 135)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 18)
        Me.Label9.TabIndex = 234
        Me.Label9.Text = "Term"
        '
        'txtpoproductid
        '
        Me.txtpoproductid.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpoproductid.Location = New System.Drawing.Point(838, 69)
        Me.txtpoproductid.Name = "txtpoproductid"
        Me.txtpoproductid.Size = New System.Drawing.Size(186, 29)
        Me.txtpoproductid.TabIndex = 27
        Me.txtpoproductid.Visible = False
        '
        'dtpcurrentdate
        '
        Me.dtpcurrentdate.CustomFormat = "dd-MMM-yy"
        Me.dtpcurrentdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpcurrentdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpcurrentdate.Location = New System.Drawing.Point(612, 68)
        Me.dtpcurrentdate.Name = "dtpcurrentdate"
        Me.dtpcurrentdate.Size = New System.Drawing.Size(220, 29)
        Me.dtpcurrentdate.TabIndex = 26
        Me.dtpcurrentdate.Visible = False
        '
        'frmpurchaseitem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1036, 511)
        Me.Controls.Add(Me.dtpcurrentdate)
        Me.Controls.Add(Me.txtpoproductid)
        Me.Controls.Add(Me.txtpoterm)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtpordd)
        Me.Controls.Add(Me.txtpobodega)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtposellingarea)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtpoavailable)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtposoldout)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label52)
        Me.Controls.Add(Me.txtpodiscount)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtpounitcost)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtpocanvassprice)
        Me.Controls.Add(Me.Label53)
        Me.Controls.Add(Me.txtposuggestedprice)
        Me.Controls.Add(Me.txtpomargin)
        Me.Controls.Add(Me.Label51)
        Me.Controls.Add(Me.txtpototalamount)
        Me.Controls.Add(Me.Label50)
        Me.Controls.Add(Me.txtponetcost)
        Me.Controls.Add(Me.Label49)
        Me.Controls.Add(Me.btnnew)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.cbopobrand)
        Me.Controls.Add(Me.cbopomodel)
        Me.Controls.Add(Me.cbopounit)
        Me.Controls.Add(Me.txtpoquantity)
        Me.Controls.Add(Me.Label46)
        Me.Controls.Add(Me.Label45)
        Me.Controls.Add(Me.Label44)
        Me.Controls.Add(Me.txtpodescription)
        Me.Controls.Add(Me.Label47)
        Me.Controls.Add(Me.cboposuppliersname)
        Me.Controls.Add(Me.Label54)
        Me.Controls.Add(Me.dtppoarrivaldate)
        Me.Controls.Add(Me.Label43)
        Me.Controls.Add(Me.dtpporeceiptdelivery)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.txtpodrno)
        Me.Controls.Add(Me.Label42)
        Me.Controls.Add(Me.Label1)
        Me.MaximumSize = New System.Drawing.Size(1052, 549)
        Me.MinimumSize = New System.Drawing.Size(1052, 549)
        Me.Name = "frmpurchaseitem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmpurchaseitems"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtpodrno As System.Windows.Forms.TextBox
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents btnnew As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents txtpocanvassprice As System.Windows.Forms.TextBox
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents txtposuggestedprice As System.Windows.Forms.TextBox
    Friend WithEvents txtpomargin As System.Windows.Forms.TextBox
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents txtpototalamount As System.Windows.Forms.TextBox
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents txtponetcost As System.Windows.Forms.TextBox
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents txtpounitcost As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtpodiscount As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents txtpobodega As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtposellingarea As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtpoavailable As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtposoldout As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboposuppliersname As System.Windows.Forms.ComboBox
    Friend WithEvents dtppoarrivaldate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpporeceiptdelivery As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbopobrand As System.Windows.Forms.ComboBox
    Friend WithEvents cbopomodel As System.Windows.Forms.ComboBox
    Friend WithEvents cbopounit As System.Windows.Forms.ComboBox
    Friend WithEvents txtpoquantity As System.Windows.Forms.TextBox
    Friend WithEvents txtpodescription As System.Windows.Forms.TextBox
    Friend WithEvents txtpordd As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtpoterm As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtpoproductid As System.Windows.Forms.TextBox
    Friend WithEvents dtpcurrentdate As System.Windows.Forms.DateTimePicker
End Class
