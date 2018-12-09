Imports MySql.Data.MySqlClient

Public Class frmpurchaseitems

    Dim purchaseoderfinalizeproductid As String

    Private Sub frmpurchaseitems_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If pomode = "viewmode" Then
            btnnew.Text = "New"
            btnedit.Text = "Edit"
            btnedit.Enabled = True
            btndelete.Enabled = True
            disableobjects()
        ElseIf pomode = "addmode" Then
            txtpodrno.Text = ""
            cboposuppliersname.Text = ""
            clearall()
            btnnew.Text = "Add"
            btnedit.Text = "Edit"
            enableobjects()
            remarksdaydef()
            txtpodrno.Focus()
        ElseIf pomode = "editmode" Then
            btnnew.Text = "New"
            btnedit.Text = "Update"
            enableobjects()
        End If

        lvipurchaseitems.Items.Clear()
        lvipurchaseitemscolumns()
        loadcbopurchaseordersuppliersname()
        loadcbopurchaseorderbrand()
        loadcbopurchaseordermodel()
        loadcbopurchaseorderunit()

    End Sub

    Private Sub lvipurchaseitemscolumns()

        lvipurchaseitems.Columns.Add("RECEIPT DELIVERY", 95, HorizontalAlignment.Left)
        lvipurchaseitems.Columns.Add("ARRIVAL DATE", 95, HorizontalAlignment.Left)
        lvipurchaseitems.Columns.Add("DESCRIPTION", 150, HorizontalAlignment.Left)
        lvipurchaseitems.Columns.Add("BRAND", 100, HorizontalAlignment.Left)
        lvipurchaseitems.Columns.Add("MODEL / CODE", 70, HorizontalAlignment.Center)
        lvipurchaseitems.Columns.Add("QUANTITY", 60, HorizontalAlignment.Center)
        lvipurchaseitems.Columns.Add("UNIT", 60, HorizontalAlignment.Center)
        lvipurchaseitems.Columns.Add("UNIT COST", 90, HorizontalAlignment.Right)
        lvipurchaseitems.Columns.Add("DISCOUNT", 90, HorizontalAlignment.Right)
        lvipurchaseitems.Columns.Add("NET COST", 90, HorizontalAlignment.Right)
        lvipurchaseitems.Columns.Add("TOTAL AMOUNT", 90, HorizontalAlignment.Right)
        lvipurchaseitems.Columns.Add("MARGIN", 90, HorizontalAlignment.Right)
        lvipurchaseitems.Columns.Add("SUGGESTED PRICE", 90, HorizontalAlignment.Right)
        lvipurchaseitems.Columns.Add("CANVASS PRICE", 90, HorizontalAlignment.Right)
        lvipurchaseitems.Columns.Add("TERM", 90, HorizontalAlignment.Center)
        lvipurchaseitems.Columns.Add("SELLING AREA", 90, HorizontalAlignment.Center)
        lvipurchaseitems.Columns.Add("BODEGA", 90, HorizontalAlignment.Center)
        lvipurchaseitems.Columns.Add("SOLD OUT", 90, HorizontalAlignment.Center)
        lvipurchaseitems.Columns.Add("AVAILABLE", 90, HorizontalAlignment.Center)
        lvipurchaseitems.Columns.Add("REMARKS DAYS DEF.", 90, HorizontalAlignment.Center)
        lvipurchaseitems.Columns.Add("PRODUCT ID", 0, HorizontalAlignment.Right)

    End Sub

    Private Sub clearall()

        dtpporeceiptdelivery.Value = Now
        dtppoarrivaldate.Value = Now
        txtpodescription.Text = ""
        cbopobrand.Text = ""
        cbopomodel.Text = ""
        txtpoquantity.Text = ""
        cbopounit.Text = ""
        txtpounitcost.Text = ""
        txtpodiscount.Text = ""
        txtponetcost.Text = ""
        txtpototalamount.Text = ""
        txtpomargin.Text = ""
        txtposuggestedprice.Text = ""
        txtpocanvassprice.Text = ""
        txtpoterm.Text = ""
        txtpordd.Text = ""
        txtposellingarea.Text = ""
        txtpobodega.Text = ""
        txtposoldout.Text = ""
        txtpoavailable.Text = ""
        txtpoproductid.Text = ""

    End Sub

    Public Sub loadcbopurchaseordersuppliersname()
        openconnection()
        cboposuppliersname.Items.Clear()
        Dim ds As New DataSet
        Dim sql As String

        sql = "select supplier_name from tbl_supplier_list"
        sqlda = New MySqlDataAdapter(sql, con)

        sqlda.Fill(ds, "fms")
        For Each r As DataRow In ds.Tables(0).Rows
            cboposuppliersname.Items.Add(r("supplier_name"))
        Next

        con.Close()
    End Sub

    Public Sub loadcbopurchaseorderbrand()
        openconnection()
        cbopobrand.Items.Clear()
        Dim ds As New DataSet
        Dim sql As String

        sql = "select distinct brand from tbl_purchase_order"
        sqlda = New MySqlDataAdapter(sql, con)

        sqlda.Fill(ds, "fms")
        For Each r As DataRow In ds.Tables(0).Rows
            If r("brand") <> "" Then
                cbopobrand.Items.Add(r("brand"))
            End If
        Next

        con.Close()
    End Sub

    Public Sub loadcbopurchaseordermodel()
        openconnection()
        cbopomodel.Items.Clear()
        Dim ds As New DataSet
        Dim sql As String

        sql = "select distinct model from tbl_purchase_order"
        sqlda = New MySqlDataAdapter(sql, con)

        sqlda.Fill(ds, "fms")
        For Each r As DataRow In ds.Tables(0).Rows
            If r("model") <> "" Then
                cbopomodel.Items.Add(r("model"))
            End If
        Next

        con.Close()
    End Sub

    Public Sub loadcbopurchaseorderunit()
        openconnection()
        cbopounit.Items.Clear()
        Dim ds As New DataSet
        Dim sql As String

        sql = "select distinct unit from tbl_purchase_order"
        sqlda = New MySqlDataAdapter(sql, con)

        sqlda.Fill(ds, "fms")
        For Each r As DataRow In ds.Tables(0).Rows
            If r("unit") <> "" Then
                cbopounit.Items.Add(r("unit"))
            End If
        Next

        con.Close()
    End Sub

    Private Sub enableobjects()

        txtpodrno.ReadOnly = False
        cboposuppliersname.Enabled = True
        dtpporeceiptdelivery.Enabled = True
        dtppoarrivaldate.Enabled = True
        txtpodescription.ReadOnly = False
        cbopobrand.Enabled = True
        cbopomodel.Enabled = True
        txtpoquantity.ReadOnly = False
        cbopounit.Enabled = True
        txtpounitcost.ReadOnly = False
        txtpodiscount.ReadOnly = False
        txtpomargin.ReadOnly = False
        txtpocanvassprice.ReadOnly = False
        txtpobodega.ReadOnly = False
        txtposoldout.ReadOnly = False

    End Sub

    Private Sub disableobjects()

        txtpodrno.ReadOnly = True
        cboposuppliersname.Enabled = False
        dtpporeceiptdelivery.Enabled = False
        dtppoarrivaldate.Enabled = False
        txtpodescription.ReadOnly = True
        cbopobrand.Enabled = False
        cbopomodel.Enabled = False
        txtpoquantity.ReadOnly = True
        cbopounit.Enabled = False
        txtpounitcost.ReadOnly = True
        txtpodiscount.ReadOnly = True
        txtpomargin.ReadOnly = True
        txtpocanvassprice.ReadOnly = True
        txtpordd.ReadOnly = True
        txtposellingarea.ReadOnly = True
        txtpobodega.ReadOnly = True
        txtposoldout.ReadOnly = True

    End Sub

    Private Sub remarksdaydef()

        Dim date1 As Date
        Dim date2 As Date
        Dim difference As TimeSpan
        date1 = Convert.ToDateTime(dtpporeceiptdelivery.Value)
        date2 = Convert.ToDateTime(dtppoarrivaldate.Value)
        difference = date2.Subtract(date1)
        Dim totaldays As Integer = FormatNumber(difference.TotalDays, 0)
        If totaldays = 1 Then
            txtpordd.Text = totaldays
        ElseIf totaldays > 1 Then
            txtpordd.Text = totaldays
        ElseIf totaldays < 1 Then
            txtpordd.Text = ""
        End If

    End Sub

    Private Sub getterm()

        Dim date1 As Date
        Dim date2 As Date
        Dim difference As TimeSpan
        date1 = Convert.ToDateTime(dtppoarrivaldate.Value)
        date2 = Convert.ToDateTime(dtpcurrentdate.Value)
        difference = date2.Subtract(date1)
        Dim totaldays As Decimal = FormatNumber(difference.TotalDays / 30)
        If totaldays = 1 Then
            txtpoterm.Text = totaldays
        ElseIf totaldays > 1 Then
            txtpoterm.Text = totaldays
        ElseIf totaldays < 1 Then
            txtpoterm.Text = ""
        End If

    End Sub

    Private Sub dtpporeceiptdelivery_ValueChanged(sender As Object, e As EventArgs) Handles dtpporeceiptdelivery.ValueChanged

        dtppoarrivaldate.Value = dtpporeceiptdelivery.Value
        remarksdaydef()
        getterm()

    End Sub

    Private Sub dtppoarrivaldate_ValueChanged(sender As Object, e As EventArgs) Handles dtppoarrivaldate.ValueChanged

        remarksdaydef()
        getterm()

    End Sub

    Private Sub getmargin()

        Try
            If txtpounitcost.Text <> "" Then
                If txtpoquantity.Text <> "" Then
                    Dim margin As String = "0"
                    If txtpomargin.Text <> "" Then
                        If txtpomargin.Text < 10 Then
                            margin = ".0" & txtpomargin.Text
                        ElseIf txtpomargin.Text > 9 Then
                            margin = "." & txtpomargin.Text
                        End If
                    Else
                        margin = ".0"
                    End If
                    txtposuggestedprice.Text = FormatNumber(txtponetcost.Text * margin + txtponetcost.Text)
                End If
            End If
        Catch ex As Exception
            txtpomargin.Text = ""
            MessageBox.Show("The margin that you inputted is invalid!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtpoquantity_TextChanged(sender As Object, e As EventArgs) Handles txtpoquantity.TextChanged

        Try
            If txtpoquantity.Text <> "" Then
                Dim quantity As Decimal = txtpoquantity.Text
                If txtpounitcost.Text <> "" Then
                    If txtpodiscount.Text <> "" Then
                        Dim discount As String = "." & txtpodiscount.Text
                        txtponetcost.Text = FormatNumber(txtpounitcost.Text - (txtpounitcost.Text * discount))
                        txtpototalamount.Text = FormatNumber(quantity * (txtpounitcost.Text - (txtpounitcost.Text * discount)))
                        getmargin()
                    ElseIf txtpodiscount.Text = "" Then
                        txtponetcost.Text = FormatNumber(txtpounitcost.Text - (txtpounitcost.Text * 0.0))
                        txtpototalamount.Text = FormatNumber(quantity * (txtpounitcost.Text - (txtpounitcost.Text * 0.0)))
                        getmargin()
                    End If
                End If
                txtposellingarea.Text = txtpoquantity.Text
                txtpoavailable.Text = txtpoquantity.Text
            Else
                txtponetcost.Text = ""
                txtpototalamount.Text = ""
                txtposuggestedprice.Text = ""
                txtposellingarea.Text = ""
                txtpoavailable.Text = ""
            End If
            txtpobodega.Text = ""
            txtposoldout.Text = ""
        Catch ex As Exception
            txtpoquantity.Text = ""
            MessageBox.Show("The quantity that you inputted is invalid!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        'bodegafunction()

    End Sub

    Private Sub txtpounitcost_LostFocus(sender As Object, e As EventArgs) Handles txtpounitcost.LostFocus

        If txtpounitcost.Text <> "" Then
            txtpounitcost.Text = FormatNumber(txtpounitcost.Text)
        End If

    End Sub

    Private Sub txtpounitcost_TextChanged(sender As Object, e As EventArgs) Handles txtpounitcost.TextChanged

        Try
            If txtpounitcost.Text <> "" Then
                Dim unitcost As Decimal = txtpounitcost.Text
                If txtpoquantity.Text <> "" Then
                    If txtpodiscount.Text <> "" Then
                        Dim discount As String
                        If txtpodiscount.Text < 10 Then
                            discount = ".0" & txtpodiscount.Text
                        ElseIf txtpodiscount.Text > 9 Then
                            discount = "." & txtpodiscount.Text
                        End If
                        txtponetcost.Text = FormatNumber(unitcost - (unitcost * discount))
                        txtpototalamount.Text = FormatNumber(txtpoquantity.Text * (unitcost - (unitcost * discount)))
                        getmargin()
                    ElseIf txtpodiscount.Text = "" Then
                        txtponetcost.Text = FormatNumber(unitcost - (unitcost * 0.0))
                        txtpototalamount.Text = FormatNumber(txtpoquantity.Text * (unitcost - (unitcost * 0.0)))
                        getmargin()
                    End If
                ElseIf txtpoquantity.Text = "" Then

                End If
            Else
                txtponetcost.Text = ""
                txtpototalamount.Text = ""
                txtposuggestedprice.Text = ""
            End If
        Catch ex As Exception
            txtpounitcost.Text = ""
            MessageBox.Show("The unit cost the you inputted is invalid!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtpodiscount_TextChanged(sender As Object, e As EventArgs) Handles txtpodiscount.TextChanged

        Try
            If txtpounitcost.Text <> "" Then
                If txtpoquantity.Text <> "" Then
                    If txtpodiscount.Text <> "" Then
                        Dim discount As String = "0"
                        If txtpodiscount.Text < 10 Then
                            discount = ".0" & txtpodiscount.Text
                        ElseIf txtpodiscount.Text > 9 Then
                            discount = "." & txtpodiscount.Text
                        End If
                        txtponetcost.Text = FormatNumber(txtpounitcost.Text - (txtpounitcost.Text * discount))
                        txtpototalamount.Text = FormatNumber(txtpoquantity.Text * (txtpounitcost.Text - (txtpounitcost.Text * discount)))
                        getmargin()
                    ElseIf txtpodiscount.Text = "" Then
                        txtponetcost.Text = FormatNumber(txtpounitcost.Text)
                        getmargin()
                    End If
                End If
            End If
        Catch ex As Exception
            txtpodiscount.Text = ""
            MessageBox.Show("The discount that you inputted is invalid!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtpomargin_TextChanged(sender As Object, e As EventArgs) Handles txtpomargin.TextChanged

        getmargin()

    End Sub

    Private Sub txtpocanvassprice_LostFocus(sender As Object, e As EventArgs) Handles txtpocanvassprice.LostFocus

        If txtpocanvassprice.Text <> "" Then
            txtpocanvassprice.Text = FormatNumber(txtpocanvassprice.Text)
        End If

    End Sub

    Private Sub txtpocanvassprice_TextChanged(sender As Object, e As EventArgs) Handles txtpocanvassprice.TextChanged

        Try
            Dim canvassprice As Decimal
            If txtpocanvassprice.Text <> "" Then
                canvassprice = txtpocanvassprice.Text
            End If
        Catch ex As Exception
            txtpocanvassprice.Text = ""
            MessageBox.Show("The quantity that you inputted is invalid!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtposellingarea_TextChanged(sender As Object, e As EventArgs) Handles txtposellingarea.TextChanged

        'Try
        '    If txtposellingarea.Text <> "" Then
        '        Dim sellingarea As Integer = txtposellingarea.Text
        '    End If
        'Catch ex As Exception
        '    txtposellingarea.Text = ""
        '    MessageBox.Show("The quantity that you inputted is invalid!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
        'bodegafunction()

    End Sub

    Private Sub txtpobodega_TextChanged(sender As Object, e As EventArgs) Handles txtpobodega.TextChanged

        Dim quantity As Integer = 0
        Dim sellingarea As Integer = 0
        Dim soldout As Integer = 0
        If txtpoquantity.Text <> "" Then
            quantity = txtpoquantity.Text
        End If
        If txtposellingarea.Text <> "" Then
            sellingarea = txtposellingarea.Text
        End If
        If txtposoldout.Text <> "" Then
            soldout = txtposoldout.Text
        End If
        Try
            If txtpobodega.Text <> "" Then
                Dim bodega As Integer = txtpobodega.Text
                If txtposoldout.Text <> "" Then
                    txtposellingarea.Text = quantity - bodega
                    sellingarea = txtposellingarea.Text
                    txtpoavailable.Text = (sellingarea + bodega) - soldout
                Else
                    txtposellingarea.Text = quantity - bodega
                End If
            Else
                If txtposoldout.Text <> "" Then
                    txtposellingarea.Text = txtpoquantity.Text
                    If txtposellingarea.Text <> "" Then
                        sellingarea = txtposellingarea.Text
                    End If
                    txtpoavailable.Text = sellingarea - soldout
                Else
                    txtposellingarea.Text = txtpoquantity.Text
                    txtpoavailable.Text = txtpoquantity.Text
                End If
            End If
        Catch ex As Exception
            txtpobodega.Text = ""
            MessageBox.Show("The quantity that you inputted is invalid!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtposoldout_TextChanged(sender As Object, e As EventArgs) Handles txtposoldout.TextChanged

        Try
            Dim sellingarea As Integer = 0
            Dim bodega As Integer = 0
            If txtposellingarea.Text <> "" Then
                sellingarea = txtposellingarea.Text
            End If
            If txtpobodega.Text <> "" Then
                bodega = txtpobodega.Text
            End If
            If txtposoldout.Text <> "" Then
                Dim soldout As Integer = txtposoldout.Text
                txtpoavailable.Text = (sellingarea + bodega) - soldout
            Else
                txtpoavailable.Text = sellingarea + bodega
            End If
        Catch ex As Exception
            txtposoldout.Text = ""
            MessageBox.Show("The quantity that you inputted is invalid!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub bodegafunction()

        'If txtpoquantity.Text <> "" Then
        '    Dim quantity As Integer = txtpoquantity.Text
        '    If txtpobodega.Text <> "" Then
        '        Dim bodega As Integer = txtpobodega.Text
        '        If txtposellingarea.Text <> "" Then
        '            Dim sellingarea As Integer = txtposellingarea.Text
        '            txtposoldout.Text = quantity - (sellingarea + bodega)
        '            txtpoavailable.Text = sellingarea + bodega
        '        Else
        '            txtposoldout.Text = quantity - bodega
        '            txtpoavailable.Text = bodega
        '        End If
        '    Else
        '        If txtposellingarea.Text <> "" Then
        '            Dim sellingarea As Integer = txtposellingarea.Text
        '            txtposoldout.Text = quantity - sellingarea
        '            txtpoavailable.Text = sellingarea
        '        Else
        '            txtposoldout.Text = ""
        '            txtpoavailable.Text = ""
        '        End If
        '    End If
        'Else
        '    txtposoldout.Text = ""
        '    txtpoavailable.Text = ""
        'End If

    End Sub

    Private Sub lvipurchaseitems_Click(sender As Object, e As EventArgs) Handles lvipurchaseitems.Click

        disableobjects()
        dtpporeceiptdelivery.Value = lvipurchaseitems.SelectedItems.Item(0).SubItems(0).Text
        dtppoarrivaldate.Value = lvipurchaseitems.SelectedItems.Item(0).SubItems(1).Text
        txtpodescription.Text = lvipurchaseitems.SelectedItems.Item(0).SubItems(2).Text
        cbopobrand.Text = lvipurchaseitems.SelectedItems.Item(0).SubItems(3).Text
        cbopomodel.Text = lvipurchaseitems.SelectedItems.Item(0).SubItems(4).Text
        txtpoquantity.Text = lvipurchaseitems.SelectedItems.Item(0).SubItems(5).Text
        cbopounit.Text = lvipurchaseitems.SelectedItems.Item(0).SubItems(6).Text
        txtpounitcost.Text = lvipurchaseitems.SelectedItems.Item(0).SubItems(7).Text
        txtpodiscount.Text = lvipurchaseitems.SelectedItems.Item(0).SubItems(8).Text.Replace("%", "")
        txtponetcost.Text = lvipurchaseitems.SelectedItems.Item(0).SubItems(9).Text
        txtpototalamount.Text = lvipurchaseitems.SelectedItems.Item(0).SubItems(10).Text
        txtpomargin.Text = lvipurchaseitems.SelectedItems.Item(0).SubItems(11).Text.Replace("%", "")
        txtposuggestedprice.Text = lvipurchaseitems.SelectedItems.Item(0).SubItems(12).Text
        txtpocanvassprice.Text = lvipurchaseitems.SelectedItems.Item(0).SubItems(13).Text
        txtpoterm.Text = lvipurchaseitems.SelectedItems.Item(0).SubItems(14).Text
        txtposellingarea.Text = lvipurchaseitems.SelectedItems.Item(0).SubItems(15).Text
        txtpobodega.Text = lvipurchaseitems.SelectedItems.Item(0).SubItems(16).Text
        txtposoldout.Text = lvipurchaseitems.SelectedItems.Item(0).SubItems(17).Text
        txtpoavailable.Text = lvipurchaseitems.SelectedItems.Item(0).SubItems(18).Text
        txtpordd.Text = lvipurchaseitems.SelectedItems.Item(0).SubItems(19).Text
        txtpoproductid.Text = lvipurchaseitems.SelectedItems.Item(0).SubItems(20).Text

        btnnew.Text = "New"

    End Sub

    Private Sub lvipurchaseitems_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvipurchaseitems.SelectedIndexChanged

    End Sub

    Public Sub purchaseitemproductidgenerator()

        openconnection()
        Dim idinitial As String = "PROD"
        Dim counter As Integer = 1
        Dim idnumber As String = "00"
        purchaseoderfinalizeproductid = idinitial & idnumber & counter.ToString
        Dim isidexists As Boolean = True

        cmd.CommandText = "select product_id from tbl_purchase_order where product_id = '" & purchaseoderfinalizeproductid & "'"
        reader = cmd.ExecuteReader
        If reader.HasRows = False Then
            reader.Close()
            purchaseoderfinalizeproductid = idinitial & idnumber & counter.ToString
        Else
            Do Until isidexists = False
                reader.Close()
                counter += 1
                If counter > 9 And counter < 100 Then
                    idnumber = "0"
                ElseIf counter > 99 Then
                    idnumber = ""
                End If
                purchaseoderfinalizeproductid = idinitial & idnumber & counter.ToString
                cmd.CommandText = "select product_id from tbl_purchase_order where product_id = '" & purchaseoderfinalizeproductid & "'"
                reader = cmd.ExecuteReader
                If reader.HasRows = True Then
                    isidexists = True
                Else
                    isidexists = False
                End If
            Loop
            reader.Close()
        End If

    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click

        If btnnew.Text = "New" Then
            btnnew.Text = "Add"
            clearall()
            enableobjects()
        ElseIf btnnew.Text = "Add" Then
            Dim item As New ListViewItem(dtpporeceiptdelivery.Text)
            item.SubItems.Add(dtppoarrivaldate.Text)
            item.SubItems.Add(txtpodescription.Text)
            item.SubItems.Add(cbopobrand.Text)
            item.SubItems.Add(cbopomodel.Text)
            item.SubItems.Add(txtpoquantity.Text)
            item.SubItems.Add(cbopounit.Text)
            item.SubItems.Add(txtpounitcost.Text)
            If txtpodiscount.Text <> "" Then
                item.SubItems.Add(txtpodiscount.Text & "%")
            Else
                item.SubItems.Add("0%")
            End If
            item.SubItems.Add(txtponetcost.Text)
            item.SubItems.Add(txtpototalamount.Text)
            If txtpomargin.Text <> "" Then
                item.SubItems.Add(txtpomargin.Text & "%")
            Else
                item.SubItems.Add("0%")
            End If
            item.SubItems.Add(txtposuggestedprice.Text)
            item.SubItems.Add(txtpocanvassprice.Text)
            item.SubItems.Add(txtpoterm.Text)
            item.SubItems.Add(txtposellingarea.Text)
            item.SubItems.Add(txtpobodega.Text)
            item.SubItems.Add(txtposoldout.Text)
            item.SubItems.Add(txtpoavailable.Text)
            item.SubItems.Add(txtpordd.Text)
            item.SubItems.Add("")
            lvipurchaseitems.Items.Add(item)

            clearall()
            txtpodescription.Focus()
        End If

    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click

    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click

        For Each item As ListViewItem In lvipurchaseitems.Items
            If lvipurchaseitems.SelectedItems.Count > 0 Then
                item = lvipurchaseitems.SelectedItems.Item(0)
                item.Remove()
            End If
        Next
        clearall()

    End Sub


    Private Sub btnpurchase_Click(sender As Object, e As EventArgs) Handles btnpurchase.Click

        If lvipurchaseitems.Items.Count > 0 Then
            openconnection()
            getterm()
            Dim unitcost, netcost, totalamount, suggestedprice, canvassprice As Decimal

            For Each item As ListViewItem In lvipurchaseitems.Items
                purchaseitemproductidgenerator()
                If lvipurchaseitems.Items.Item(0).SubItems(7).Text <> "" Then
                    unitcost = lvipurchaseitems.Items.Item(0).SubItems(7).Text
                End If
                If lvipurchaseitems.Items.Item(0).SubItems(9).Text <> "" Then
                    netcost = lvipurchaseitems.Items.Item(0).SubItems(9).Text
                End If
                If lvipurchaseitems.Items.Item(0).SubItems(10).Text <> "" Then
                    totalamount = lvipurchaseitems.Items.Item(0).SubItems(10).Text
                End If
                If lvipurchaseitems.Items.Item(0).SubItems(12).Text <> "" Then
                    suggestedprice = lvipurchaseitems.Items.Item(0).SubItems(12).Text
                End If
                If lvipurchaseitems.Items.Item(0).SubItems(13).Text <> "" Then
                    canvassprice = lvipurchaseitems.Items.Item(0).SubItems(13).Text
                End If
                cmd = New MySqlCommand("INSERT INTO `tbl_purchase_order`(`product_id`,`dr`,`supplier`,`receipt_delivery_date`,`arrival_date`,`remark_days_def`,`description`,`brand`,`model`,`quantity`,`unit`,`unit_cost`,`discount`,`net_cost`,`total_amount`,`margin`,`suggested_price`,`canvass_price`,`term`,`selling_area`,`bodega`,`sold_out`,`available`) VALUES (@productid,@dr,@supplier,@receiptdeliverydate,@arrivaldate,@remarksdaysdef,@description,@brand,@model,@quantity,@unit,@unitcost,@discount,@netcost,@totalamount,@margin,@suggestedprice,@canvassprice,@term,@sellingarea,@bodega,@soldout,@available)", con)
                cmd.Parameters.AddWithValue("@productid", purchaseoderfinalizeproductid)
                cmd.Parameters.AddWithValue("@dr", txtpodrno.Text.Replace("'", ""))
                cmd.Parameters.AddWithValue("@supplier", cboposuppliersname.Text)
                cmd.Parameters.AddWithValue("@receiptdeliverydate", lvipurchaseitems.Items.Item(0).SubItems(0).Text)
                cmd.Parameters.AddWithValue("@arrivaldate", lvipurchaseitems.Items.Item(0).SubItems(1).Text)
                cmd.Parameters.AddWithValue("@remarksdaysdef", lvipurchaseitems.Items.Item(0).SubItems(19).Text)
                cmd.Parameters.AddWithValue("@description", lvipurchaseitems.Items.Item(0).SubItems(2).Text)
                cmd.Parameters.AddWithValue("@brand", lvipurchaseitems.Items.Item(0).SubItems(3).Text)
                cmd.Parameters.AddWithValue("@model", lvipurchaseitems.Items.Item(0).SubItems(4).Text)
                cmd.Parameters.AddWithValue("@quantity", lvipurchaseitems.Items.Item(0).SubItems(5).Text)
                cmd.Parameters.AddWithValue("@unit", lvipurchaseitems.Items.Item(0).SubItems(6).Text)
                cmd.Parameters.AddWithValue("@unitcost", unitcost)
                cmd.Parameters.AddWithValue("@discount", lvipurchaseitems.Items.Item(0).SubItems(8).Text)
                cmd.Parameters.AddWithValue("@netcost", netcost)
                cmd.Parameters.AddWithValue("@totalamount", totalamount)
                cmd.Parameters.AddWithValue("@margin", lvipurchaseitems.Items.Item(0).SubItems(11).Text)
                cmd.Parameters.AddWithValue("@suggestedprice", suggestedprice)
                cmd.Parameters.AddWithValue("@canvassprice", canvassprice)
                cmd.Parameters.AddWithValue("@term", lvipurchaseitems.Items.Item(0).SubItems(14).Text)
                cmd.Parameters.AddWithValue("@sellingarea", lvipurchaseitems.Items.Item(0).SubItems(15).Text)
                cmd.Parameters.AddWithValue("@bodega", lvipurchaseitems.Items.Item(0).SubItems(16).Text)
                cmd.Parameters.AddWithValue("@soldout", lvipurchaseitems.Items.Item(0).SubItems(17).Text)
                cmd.Parameters.AddWithValue("@available", lvipurchaseitems.Items.Item(0).SubItems(18).Text)
                cmd.ExecuteNonQuery()
                item.Remove()
            Next

            btnedit.Enabled = True
            btndelete.Enabled = True
            clearall()
            displaypruchaseorder()
            MessageBox.Show("Data has been added successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtpodrno.Focus()
            con.Close()
        Else
            MessageBox.Show("Please specify the items to purchase.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

End Class