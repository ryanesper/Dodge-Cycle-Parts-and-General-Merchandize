Imports MySql.Data.MySqlClient

Public Class frmpurchaseitem

    Dim purchaseoderfinalizeproductid As String

    Private Sub frmpurchaseitems_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If pomode = "viewmode" Then
            btnnew.Text = "New"
            btnedit.Text = "Edit"
            btnedit.Enabled = True
            btndelete.Enabled = True
            disableobjects()
        ElseIf pomode = "addmode" Then
            clearall()
            btnnew.Text = "Add"
            btnedit.Text = "Edit"
            btnedit.Enabled = False
            btndelete.Enabled = False
            remarksdaydef()
        ElseIf pomode = "editmode" Then
            btnnew.Text = "New"
            btnedit.Text = "Update"
            enableobjects()
        End If

        loadcbopurchaseordersuppliersname()
        loadcbopurchaseorderbrand()
        loadcbopurchaseordermodel()
        loadcbopurchaseorderunit()

    End Sub

    Private Sub clearall()

        txtpodrno.Text = ""
        cboposuppliersname.Text = ""
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
        txtposellingarea.ReadOnly = False
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
            Else
                txtponetcost.Text = ""
                txtpototalamount.Text = ""
                txtposuggestedprice.Text = ""
                txtposellingarea.Text = ""
                txtpoavailable.Text = ""
            End If
            txtpobodega.Text = ""
            txtpoavailable.Text = ""
            txtposellingarea.Text = ""
            txtposoldout.Text = ""
        Catch ex As Exception
            txtpoquantity.Text = ""
            MessageBox.Show("The quantity that you inputted is invalid!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

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

    Private Sub getmargin()

        'Try
        If txtpounitcost.Text <> "" Then
            If txtpoquantity.Text <> "" Then
                Dim margin As String
                If txtpomargin.Text <> "" Then
                    Dim margin0 As Integer = txtpomargin.Text
                    margin = "." & txtpomargin.Text
                Else
                    margin = ".0"
                End If
                txtposuggestedprice.Text = FormatNumber(txtponetcost.Text * margin + txtponetcost.Text)
            End If
        End If
        'Catch ex As Exception
        '    txtpomargin.Text = ""
        '    MessageBox.Show("The margin that you inputted is invalid!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try

    End Sub

    Private Sub txtpodiscount_TextChanged(sender As Object, e As EventArgs) Handles txtpodiscount.TextChanged

        'Try
        If txtpounitcost.Text <> "" Then
            If txtpoquantity.Text <> "" Then
                If txtpodiscount.Text <> "" Then
                    Dim discount As String
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
        'Catch ex As Exception
        '    txtpodiscount.Text = ""
        '    MessageBox.Show("The discount that you inputted is invalid!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try

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

        Dim quantity As Integer = 0
        If txtpoquantity.Text <> "" Then
            quantity = txtpoquantity.Text
        End If

        Try
            If txtposellingarea.Text <> "" Then
                Dim sellingarea As Integer = txtposellingarea.Text
                txtpobodega.Text = quantity - sellingarea
                If txtposoldout.Text <> "" Then
                    Dim soldout As Integer = txtposoldout.Text
                    txtpoavailable.Text = quantity - soldout
                Else
                    txtpoavailable.Text = txtpoquantity.Text
                End If
            Else
                If txtposoldout.Text <> "" Then
                    Dim soldout As Integer = txtposoldout.Text
                    txtpobodega.Text = txtpoquantity.Text
                    txtpoavailable.Text = quantity - soldout
                Else
                    txtpobodega.Text = txtpoquantity.Text
                    txtpoavailable.Text = txtpoquantity.Text
                End If
            End If
        Catch ex As Exception
            txtposellingarea.Text = ""
            MessageBox.Show("The quantity that you inputted is invalid!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtposoldout_TextChanged(sender As Object, e As EventArgs) Handles txtposoldout.TextChanged

        Dim sellingarea As Integer = 0
        Dim bodega As Integer = 0
        If txtpobodega.Text <> "" Then
            bodega = txtpobodega.Text
        End If
        If txtposellingarea.Text <> "" Then
            sellingarea = txtposellingarea.Text
        End If

        Try
            If txtposoldout.Text <> "" Then
                Dim soldout As Integer = txtposoldout.Text
                If txtposellingarea.Text <> "" Then
                    txtpoavailable.Text = (sellingarea + bodega) - soldout
                Else
                    txtpoavailable.Text = bodega - soldout
                End If
            Else
                txtpoavailable.Text = txtpoquantity.Text
            End If
        Catch ex As Exception
            txtposoldout.Text = ""
            MessageBox.Show("The quantity that you inputted is invalid!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtpobodega_TextChanged(sender As Object, e As EventArgs) Handles txtpobodega.TextChanged

        Try
            If txtpobodega.Text <> "" Then
                Dim bodega As Decimal = txtpobodega.Text
            End If
        Catch ex As Exception
            txtpobodega.Text = ""
            MessageBox.Show("The quantity that you inputted is invalid!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub bodegafunction()

        If txtpoquantity.Text <> "" Then
            Dim quantity As Integer = txtpoquantity.Text
            If txtpobodega.Text <> "" Then
                Dim bodega As Integer = txtpobodega.Text
                If txtposellingarea.Text <> "" Then
                    Dim sellingarea As Integer = txtposellingarea.Text
                    txtposoldout.Text = quantity - (sellingarea + bodega)
                    txtpoavailable.Text = sellingarea + bodega
                Else
                    txtposoldout.Text = quantity - bodega
                    txtpoavailable.Text = bodega
                End If
            Else
                If txtposellingarea.Text <> "" Then
                    Dim sellingarea As Integer = txtposellingarea.Text
                    txtposoldout.Text = quantity - sellingarea
                    txtpoavailable.Text = sellingarea
                Else
                    txtposoldout.Text = ""
                    txtpoavailable.Text = ""
                End If
            End If
        Else
            txtposoldout.Text = ""
            txtpoavailable.Text = ""
        End If

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

        pomode = "viewmode"
        frmpurchaseitems.ShowInTaskbar = False
        frmpurchaseitems.ShowDialog()
        Me.Close()

    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click

        If accounttype = "admin" Then
            If btnedit.Text = "Edit" Then
                btnedit.Text = "Update"
                enableobjects()
            ElseIf btnedit.Text = "Update" Then
                openconnection()

                Dim unitcost, netcost, totalamount, suggestedprice, canvassprice As Decimal
                If txtpounitcost.Text <> "" Then
                    unitcost = txtpounitcost.Text
                End If
                If txtponetcost.Text <> "" Then
                    netcost = txtponetcost.Text
                End If
                If txtpototalamount.Text <> "" Then
                    totalamount = txtpototalamount.Text
                End If
                If txtposuggestedprice.Text <> "" Then
                    suggestedprice = txtposuggestedprice.Text
                End If
                If txtpocanvassprice.Text <> "" Then
                    canvassprice = txtpocanvassprice.Text
                End If
                cmd = New MySqlCommand("UPDATE `tbl_purchase_order` SET `dr`= @dr, `supplier`= @supplier, `receipt_delivery_date`= @receiptdeliverydate, `arrival_date`= @arrivaldate, `remark_days_def`= @remarksdaysdef, `description`= @description, `brand`= @brand, `model`= @model, `quantity`= @quantity, `unit`= @unit, `unit_cost`= @unitcost, `discount`= @discount, `net_cost`= @netcost, `total_amount`= @totalamount, `margin`= @margin, `suggested_price`= @suggestedprice, `canvass_price`= @canvassprice, `term`= @term, `selling_area`= @sellingarea, `bodega`= @bodega, `sold_out`= @soldout, `available`= @available where product_id=@productid", con)
                cmd.Parameters.AddWithValue("@productid", txtpoproductid.Text)
                cmd.Parameters.AddWithValue("@dr", txtpodrno.Text.Replace("'", ""))
                cmd.Parameters.AddWithValue("@supplier", cboposuppliersname.Text)
                cmd.Parameters.AddWithValue("@receiptdeliverydate", dtpporeceiptdelivery.Text)
                cmd.Parameters.AddWithValue("@arrivaldate", dtppoarrivaldate.Text)
                cmd.Parameters.AddWithValue("@remarksdaysdef", txtpordd.Text)
                cmd.Parameters.AddWithValue("@description", txtpodescription.Text)
                cmd.Parameters.AddWithValue("@brand", cbopobrand.Text)
                cmd.Parameters.AddWithValue("@model", cbopomodel.Text)
                cmd.Parameters.AddWithValue("@quantity", txtpoquantity.Text)
                cmd.Parameters.AddWithValue("@unit", cbopounit.Text)
                cmd.Parameters.AddWithValue("@unitcost", unitcost)
                cmd.Parameters.AddWithValue("@discount", txtpodiscount.Text & "%")
                cmd.Parameters.AddWithValue("@netcost", txtponetcost.Text)
                cmd.Parameters.AddWithValue("@totalamount", totalamount)
                cmd.Parameters.AddWithValue("@margin", txtpomargin.Text & "%")
                cmd.Parameters.AddWithValue("@suggestedprice", suggestedprice)
                cmd.Parameters.AddWithValue("@canvassprice", canvassprice)
                cmd.Parameters.AddWithValue("@term", txtpoterm.Text)
                cmd.Parameters.AddWithValue("@sellingarea", txtposellingarea.Text)
                cmd.Parameters.AddWithValue("@bodega", txtpobodega.Text)
                cmd.Parameters.AddWithValue("@soldout", txtposoldout.Text)
                cmd.Parameters.AddWithValue("@available", txtpoavailable.Text)
                cmd.ExecuteNonQuery()

                con.Close()
                disableobjects()
                btnedit.Text = "Edit"
                displaypruchaseorder()
                MessageBox.Show("Updated successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("You do not have a permission to edit.", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click

        If accounttype = "admin" Then
            If txtpoproductid.Text <> "" Then
                confirm = MessageBox.Show("Are you sure?", "Delete Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                If confirm = vbOK Then
                    openconnection()
                    cmddelete = "DELETE FROM `tbl_purchase_order` where product_id='" & txtpoproductid.Text & "'"
                    sqlda = New MySqlDataAdapter(cmddelete, con)
                    ds = New DataSet()
                    sqlda.Fill(ds)

                    con.Close()
                    MessageBox.Show("Deleted successfully.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    displaypruchaseorder()
                    Me.Close()
                End If
            Else
                MessageBox.Show("Please select an item to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("You do not have a permission to delete.", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

End Class