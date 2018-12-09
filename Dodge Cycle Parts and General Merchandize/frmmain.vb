Imports MySql.Data.MySqlClient

Public Class frmmain

    Dim alaccountfinalizedid As String
    Dim supplieridfinalizedid As String
    Dim salesandexpensesidfinalizedid As String

    Dim scecustomername As String
    Dim scetotalsalestodelete As Decimal
    Dim scepaymenttodelete As Decimal
    Dim scebalancetominus1 As Decimal
    Dim scebalancetominus2 As Decimal
    Dim scemonth As String

    Dim definedcustomercounter As Integer = 0

    Private Property purchaseorderoridfinalizedid As String

    Const wm_nchittest As Integer = &H84
    Const htclient As Integer = &H1
    Const htcaption As Integer = &H2
    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        Select Case m.Msg
            Case wm_nchittest
                MyBase.WndProc(m)
                If m.Result = htclient Then m.Result = htcaption
            Case Else
                MyBase.WndProc(m)
        End Select
    End Sub

    Private Sub frmmain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        currentdate = System.DateTime.Now.ToString("dd-MMM-yy")

        lvidodgesalescolumns()
        lvisalesandcollectionentrycolumns()
        lviaccountledgercolumns()
        lvisupplierlistcolumns()
        lvipurchaseordercolumns()
        lvisalesandexpensescolumns()
        lvimonthlymonitoringscolumns()

        loadcboaccountledgerlocalcode()
        loadcbosalesandcollectionentrycustomer()
        loadcbosalesandexpensescodingagent()
        'loadcbopurchaseorderbrand()
        'loadcbopurchaseordermodel()
        'loadcbopurchaseorderunit()

        displaydodgesales()
        displaysalesanccollectionentry()
        displayaccountledger()
        displaysupplierlist()
        displaypruchaseorder()
        displaysalesandexpenses()
        displaymonthlymonitoring()

        lblme.Text = username
        cbodssearch.Text = "OR No."
        cbosaesearch.Text = "Date"
        cboscesearch.Text = "Transaction No."
        cboalsearch.Text = "Business Name"
        cboslsearch.Text = "Suppliers Name"
        cboposearch.Text = "DR"
        cbommsearch.Text = "Month"

    End Sub

    Private Sub lvidodgesalescolumns()

        lvidodgesales.Columns.Clear()
        If btndsexpandshrink.Text = "<" Then
            lvidodgesales.Columns.Add("OR NO.", 90, HorizontalAlignment.Left)
            lvidodgesales.Columns.Add("DATE", 80, HorizontalAlignment.Left)
            lvidodgesales.Columns.Add("M-CODE", 80, HorizontalAlignment.Center)
            lvidodgesales.Columns.Add("CUSTOMERS NAME / TIN", 130, HorizontalAlignment.Left)
            lvidodgesales.Columns.Add("DESCRIPTION / SUPPLIER", 160, HorizontalAlignment.Left)
            lvidodgesales.Columns.Add("SALES (VAT INCLUSIVE)", 90, HorizontalAlignment.Right)
            lvidodgesales.Columns.Add("LESS: VAT", 90, HorizontalAlignment.Right)
            lvidodgesales.Columns.Add("NET: VAT", 90, HorizontalAlignment.Right)
            lvidodgesales.Columns.Add("DISCOUNT", 50, HorizontalAlignment.Center)
            lvidodgesales.Columns.Add("AMOUNT DUE", 90, HorizontalAlignment.Right)
            lvidodgesales.Columns.Add("ADD: VAT", 90, HorizontalAlignment.Right)
            lvidodgesales.Columns.Add("TOTAL AMOUNT DUE", 90, HorizontalAlignment.Right)
        ElseIf btndsexpandshrink.Text = ">" Then
            lvidodgesales.Columns.Add("OR NO.", 100, HorizontalAlignment.Left)
            lvidodgesales.Columns.Add("DATE", 100, HorizontalAlignment.Left)
            lvidodgesales.Columns.Add("M-CODE", 90, HorizontalAlignment.Center)
            lvidodgesales.Columns.Add("CUSTOMERS NAME/ TIN", 200, HorizontalAlignment.Left)
            lvidodgesales.Columns.Add("DESCRIPTION / SUPPLIER", 260, HorizontalAlignment.Left)
            lvidodgesales.Columns.Add("SALES (VAT INCLUSIVE)", 120, HorizontalAlignment.Right)
            lvidodgesales.Columns.Add("LESS: VAT)", 120, HorizontalAlignment.Right)
            lvidodgesales.Columns.Add("NET: VAT", 120, HorizontalAlignment.Right)
            lvidodgesales.Columns.Add("DISCOUNT", 50, HorizontalAlignment.Center)
            lvidodgesales.Columns.Add("AMOUNT DUE", 90, HorizontalAlignment.Right)
            lvidodgesales.Columns.Add("ADD: VAT", 90, HorizontalAlignment.Right)
            lvidodgesales.Columns.Add("TOTAL AMOUNT DUE", 120, HorizontalAlignment.Right)
        End If

    End Sub

    Private Sub lvisalesandcollectionentrycolumns()

        lvisalesandcollectionentry.Columns.Clear()
        If btnsceexpandshrink.Text = "<" Then
            lvisalesandcollectionentry.Columns.Add("DATE CODE", 0, HorizontalAlignment.Left)
            lvisalesandcollectionentry.Columns.Add("TRANSACTION NO.", 150, HorizontalAlignment.Left)
            lvisalesandcollectionentry.Columns.Add("CUSTOMER", 230, HorizontalAlignment.Left)
            lvisalesandcollectionentry.Columns.Add("SALES DATE", 100, HorizontalAlignment.Left)
            lvisalesandcollectionentry.Columns.Add("PERIOD", 90, HorizontalAlignment.Left)
            lvisalesandcollectionentry.Columns.Add("CHARGE ACCOUNT", 120, HorizontalAlignment.Right)
            lvisalesandcollectionentry.Columns.Add("SETTLEMENT/ PAYMENT", 120, HorizontalAlignment.Right)
            lvisalesandcollectionentry.Columns.Add("BALANCE", 120, HorizontalAlignment.Right)
            lvisalesandcollectionentry.Columns.Add("AGING IN DAYS", 100, HorizontalAlignment.Center)
        ElseIf btnsceexpandshrink.Text = ">" Then
            lvisalesandcollectionentry.Columns.Add("DATE CODE", 0, HorizontalAlignment.Left)
            lvisalesandcollectionentry.Columns.Add("TRANSACTION NO.", 160, HorizontalAlignment.Left)
            lvisalesandcollectionentry.Columns.Add("CUSTOMER", 400, HorizontalAlignment.Left)
            lvisalesandcollectionentry.Columns.Add("SALES DATE", 120, HorizontalAlignment.Left)
            lvisalesandcollectionentry.Columns.Add("PERIOD", 110, HorizontalAlignment.Left)
            lvisalesandcollectionentry.Columns.Add("CHARGE ACCOUNT", 160, HorizontalAlignment.Right)
            lvisalesandcollectionentry.Columns.Add("SETTLEMENT/ PAYMENT", 160, HorizontalAlignment.Right)
            lvisalesandcollectionentry.Columns.Add("BALANCE", 120, HorizontalAlignment.Right)
            lvisalesandcollectionentry.Columns.Add("AGING IN DAYS", 120, HorizontalAlignment.Center)
        End If

    End Sub

    Private Sub lviaccountledgercolumns()

        lviaccountledger.Columns.Clear()
        If btnalexpandshrink.Text = "<" Then
            lviaccountledger.Columns.Add("BUSINESS NAME", 100, HorizontalAlignment.Left)
            lviaccountledger.Columns.Add("REGISTERED OWNER", 100, HorizontalAlignment.Left)
            lviaccountledger.Columns.Add("ADDRESS", 100, HorizontalAlignment.Left)
            lviaccountledger.Columns.Add("CONTACT NO.", 90, HorizontalAlignment.Left)
            lviaccountledger.Columns.Add("LOC CODE", 70, HorizontalAlignment.Center)
            lviaccountledger.Columns.Add("TERM", 65, HorizontalAlignment.Center)
            lviaccountledger.Columns.Add("TOTAL SALES", 100, HorizontalAlignment.Right)
            lviaccountledger.Columns.Add("TOTAL PAYMENTS", 100, HorizontalAlignment.Right)
            lviaccountledger.Columns.Add("BALANCE", 100, HorizontalAlignment.Right)
            lviaccountledger.Columns.Add("REMARKS", 60, HorizontalAlignment.Left)
            lviaccountledger.Columns.Add("DUE ACCT TODATE", 70, HorizontalAlignment.Left)
            lviaccountledger.Columns.Add("ACCOUNT ID", 0, HorizontalAlignment.Left)
        ElseIf btnalexpandshrink.Text = ">" Then
            lviaccountledger.Columns.Add("BUSINESS NAME", 160, HorizontalAlignment.Left)
            lviaccountledger.Columns.Add("REGISTERED OWNER", 150, HorizontalAlignment.Left)
            lviaccountledger.Columns.Add("ADDRESS", 185, HorizontalAlignment.Left)
            lviaccountledger.Columns.Add("CONTACT NO.", 110, HorizontalAlignment.Left)
            lviaccountledger.Columns.Add("LOC CODE", 70, HorizontalAlignment.Center)
            lviaccountledger.Columns.Add("TERM", 65, HorizontalAlignment.Center)
            lviaccountledger.Columns.Add("TOTAL SALES", 115, HorizontalAlignment.Right)
            lviaccountledger.Columns.Add("TOTAL PAYMENTS", 115, HorizontalAlignment.Right)
            lviaccountledger.Columns.Add("BALANCE", 115, HorizontalAlignment.Right)
            lviaccountledger.Columns.Add("REMARKS", 70, HorizontalAlignment.Left)
            lviaccountledger.Columns.Add("DUE ACCT TODATE", 115, HorizontalAlignment.Left)
            lviaccountledger.Columns.Add("ACCOUNT ID", 0, HorizontalAlignment.Left)
        End If

    End Sub

    Private Sub lvisupplierlistcolumns()

        lvisupplierlist.Columns.Clear()
        If btnslexpandshrink.Text = "<" Then
            lvisupplierlist.Columns.Add("SUPPLIER'S NAME", 150, HorizontalAlignment.Left)
            lvisupplierlist.Columns.Add("CONTACT PERSON", 120, HorizontalAlignment.Left)
            lvisupplierlist.Columns.Add("ADDRESS", 150, HorizontalAlignment.Left)
            lvisupplierlist.Columns.Add("CONTACT NO.", 150, HorizontalAlignment.Left)
            lvisupplierlist.Columns.Add("EMAIL ADDRESS", 160, HorizontalAlignment.Left)
            lvisupplierlist.Columns.Add("TERM", 70, HorizontalAlignment.Center)
            lvisupplierlist.Columns.Add("TIN NUMBER", 110, HorizontalAlignment.Left)
            lvisupplierlist.Columns.Add("SUPPLIER ID", 0, HorizontalAlignment.Left)
        ElseIf btnslexpandshrink.Text = ">" Then
            lvisupplierlist.Columns.Add("SUPPLIER'S NAME", 240, HorizontalAlignment.Left)
            lvisupplierlist.Columns.Add("CONTACT PERSON", 150, HorizontalAlignment.Left)
            lvisupplierlist.Columns.Add("ADDRESS", 240, HorizontalAlignment.Left)
            lvisupplierlist.Columns.Add("CONTACT NO.", 220, HorizontalAlignment.Left)
            lvisupplierlist.Columns.Add("EMAIL ADDRESS", 230, HorizontalAlignment.Left)
            lvisupplierlist.Columns.Add("TERM", 70, HorizontalAlignment.Center)
            lvisupplierlist.Columns.Add("TIN NUMBER", 110, HorizontalAlignment.Left)
            lvisupplierlist.Columns.Add("SUPPLIER ID", 0, HorizontalAlignment.Left)
        End If

    End Sub

    Private Sub lvipurchaseordercolumns()

        lvipurchaseorder.Columns.Add("DR", 90, HorizontalAlignment.Left)
        lvipurchaseorder.Columns.Add("SUPPLIER", 200, HorizontalAlignment.Left)
        lvipurchaseorder.Columns.Add("RECEIPT DELIVERY", 95, HorizontalAlignment.Left)
        lvipurchaseorder.Columns.Add("ARRIVAL DATE", 95, HorizontalAlignment.Left)
        lvipurchaseorder.Columns.Add("DESCRIPTION", 150, HorizontalAlignment.Left)
        lvipurchaseorder.Columns.Add("BRAND", 100, HorizontalAlignment.Left)
        lvipurchaseorder.Columns.Add("MODEL / CODE", 70, HorizontalAlignment.Center)
        lvipurchaseorder.Columns.Add("QUANTITY", 60, HorizontalAlignment.Center)
        lvipurchaseorder.Columns.Add("UNIT", 60, HorizontalAlignment.Center)
        lvipurchaseorder.Columns.Add("UNIT COST", 90, HorizontalAlignment.Right)
        lvipurchaseorder.Columns.Add("DISCOUNT", 90, HorizontalAlignment.Right)
        lvipurchaseorder.Columns.Add("NET COST", 90, HorizontalAlignment.Right)
        lvipurchaseorder.Columns.Add("TOTAL AMOUNT", 90, HorizontalAlignment.Right)
        lvipurchaseorder.Columns.Add("MARGIN", 90, HorizontalAlignment.Right)
        lvipurchaseorder.Columns.Add("SUGGESTED PRICE", 90, HorizontalAlignment.Right)
        lvipurchaseorder.Columns.Add("CANVASS PRICE", 90, HorizontalAlignment.Right)
        lvipurchaseorder.Columns.Add("TERM", 90, HorizontalAlignment.Center)
        lvipurchaseorder.Columns.Add("SELLING AREA", 90, HorizontalAlignment.Center)
        lvipurchaseorder.Columns.Add("BODEGA", 90, HorizontalAlignment.Center)
        lvipurchaseorder.Columns.Add("SOLD OUT", 90, HorizontalAlignment.Center)
        lvipurchaseorder.Columns.Add("AVAILABLE", 90, HorizontalAlignment.Center)
        lvipurchaseorder.Columns.Add("REMARKS DAYS DEF.", 90, HorizontalAlignment.Center)
        lvipurchaseorder.Columns.Add("PRODUCT ID", 0, HorizontalAlignment.Right)

    End Sub

    Private Sub lvisalesandexpensescolumns()

        lvisalesandexpenses.Columns.Clear()
        If btnsaeexpandshrink.Text = "<" Then
            lvisalesandexpenses.Columns.Add("DATE", 100, HorizontalAlignment.Left)
            lvisalesandexpenses.Columns.Add("PARTICULAR", 140, HorizontalAlignment.Left)
            lvisalesandexpenses.Columns.Add("CODING AGENT", 70, HorizontalAlignment.Center)
            lvisalesandexpenses.Columns.Add("CASH PAYMENT", 100, HorizontalAlignment.Right)
            lvisalesandexpenses.Columns.Add("CHECK PAYMENT", 100, HorizontalAlignment.Right)
            lvisalesandexpenses.Columns.Add("TOTAL SALES", 100, HorizontalAlignment.Right)
            lvisalesandexpenses.Columns.Add("TOTAL EXPENSES", 100, HorizontalAlignment.Right)
            lvisalesandexpenses.Columns.Add("NET SALES", 100, HorizontalAlignment.Right)
            lvisalesandexpenses.Columns.Add("GROSS PERCENT", 50, HorizontalAlignment.Right)
            lvisalesandexpenses.Columns.Add("POSSIBLE G-INCOMING", 100, HorizontalAlignment.Right)
            lvisalesandexpenses.Columns.Add("SALES AND EXPENSES ID", 0, HorizontalAlignment.Left)
        ElseIf btnsaeexpandshrink.Text = ">" Then
            lvisalesandexpenses.Columns.Add("DATE", 110, HorizontalAlignment.Left)
            lvisalesandexpenses.Columns.Add("PARTICULAR", 300, HorizontalAlignment.Left)
            lvisalesandexpenses.Columns.Add("CODING AGENT", 100, HorizontalAlignment.Center)
            lvisalesandexpenses.Columns.Add("CASH PAYMENT", 120, HorizontalAlignment.Right)
            lvisalesandexpenses.Columns.Add("CHECK PAYMENT", 120, HorizontalAlignment.Right)
            lvisalesandexpenses.Columns.Add("TOTAL SALES", 120, HorizontalAlignment.Right)
            lvisalesandexpenses.Columns.Add("TOTAL EXPENSES", 120, HorizontalAlignment.Right)
            lvisalesandexpenses.Columns.Add("NET SALES", 120, HorizontalAlignment.Right)
            lvisalesandexpenses.Columns.Add("GROSS PERCENT", 50, HorizontalAlignment.Right)
            lvisalesandexpenses.Columns.Add("POSSIBLE G-INCOMING", 150, HorizontalAlignment.Right)
            lvisalesandexpenses.Columns.Add("SALES AND EXPENSES ID", 0, HorizontalAlignment.Left)
        End If

    End Sub

    Private Sub lvimonthlymonitoringscolumns()

        lvimonthlymonitoring.Columns.Clear()
        lvimonthlymonitoring.Columns.Add("MONTH", 0, HorizontalAlignment.Left)
        lvimonthlymonitoring.Columns.Add("MONTH", 250, HorizontalAlignment.Center)
        lvimonthlymonitoring.Columns.Add("CHARGE ACCOUNT", 250, HorizontalAlignment.Right)
        lvimonthlymonitoring.Columns.Add("PAYMENT", 250, HorizontalAlignment.Right)
        lvimonthlymonitoring.Columns.Add("PERCENT RATIO", 250, HorizontalAlignment.Right)
        lvimonthlymonitoring.Columns.Add("BALANCE", 250, HorizontalAlignment.Right)

    End Sub

    Public Sub alaccountidgenerator()

        openconnection()
        Dim idinitial As String = "ALID"
        Dim counter As Integer = 1
        Dim idnumber As String = "00"
        alaccountfinalizedid = idinitial & idnumber & counter.ToString
        Dim isidexists As Boolean = True

        cmd.CommandText = "select account_id from tbl_account_ledger where account_id = '" & alaccountfinalizedid & "'"
        reader = cmd.ExecuteReader
        If reader.HasRows = False Then
            reader.Close()
            alaccountfinalizedid = idinitial & idnumber & counter.ToString
        Else
            Do Until isidexists = False
                reader.Close()
                counter += 1
                If counter > 9 And counter < 100 Then
                    idnumber = "0"
                ElseIf counter > 99 Then
                    idnumber = ""
                End If
                alaccountfinalizedid = idinitial & idnumber & counter.ToString
                cmd.CommandText = "select account_id from tbl_account_ledger where account_id = '" & alaccountfinalizedid & "'"
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

    Public Sub supplieridgenerator()

        openconnection()
        Dim idinitial As String = "SLID"
        Dim counter As Integer = 1
        Dim idnumber As String = "00"
        supplieridfinalizedid = idinitial & idnumber & counter.ToString
        Dim isidexists As Boolean = True

        cmd.CommandText = "select supplier_id from tbl_supplier_list where supplier_id = '" & supplieridfinalizedid & "'"
        reader = cmd.ExecuteReader
        If reader.HasRows = False Then
            reader.Close()
            supplieridfinalizedid = idinitial & idnumber & counter.ToString
        Else
            Do Until isidexists = False
                reader.Close()
                counter += 1
                If counter > 9 And counter < 100 Then
                    idnumber = "0"
                ElseIf counter > 99 Then
                    idnumber = ""
                End If
                supplieridfinalizedid = idinitial & idnumber & counter.ToString
                cmd.CommandText = "select supplier_id from tbl_supplier_list where supplier_id = '" & supplieridfinalizedid & "'"
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

    Public Sub salesandexpensesidgenerator()

        openconnection()
        Dim idinitial As String = "SEID"
        Dim counter As Integer = 1
        Dim idnumber As String = "00"
        salesandexpensesidfinalizedid = idinitial & idnumber & counter.ToString
        Dim isidexists As Boolean = True

        cmd.CommandText = "select sales_and_expenses_id from tbl_sales_and_expenses where sales_and_expenses_id = '" & salesandexpensesidfinalizedid & "'"
        reader = cmd.ExecuteReader
        If reader.HasRows = False Then
            reader.Close()
            salesandexpensesidfinalizedid = idinitial & idnumber & counter.ToString
        Else
            Do Until isidexists = False
                reader.Close()
                counter += 1
                If counter > 9 And counter < 100 Then
                    idnumber = "0"
                ElseIf counter > 99 Then
                    idnumber = ""
                End If
                salesandexpensesidfinalizedid = idinitial & idnumber & counter.ToString
                cmd.CommandText = "select sales_and_expenses_id from tbl_sales_and_expenses where sales_and_expenses_id = '" & salesandexpensesidfinalizedid & "'"
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

    Public Sub loadcboaccountledgerlocalcode()
        openconnection()
        cboallocalcode.Items.Clear()
        Dim ds As New DataSet
        Dim sql As String

        sql = "select distinct local_code from tbl_account_ledger"
        sqlda = New MySqlDataAdapter(sql, con)

        sqlda.Fill(ds, "fms")
        For Each r As DataRow In ds.Tables(0).Rows
            cboallocalcode.Items.Add(r("local_code"))
        Next

        con.Close()
    End Sub

    Public Sub loadcbosalesandcollectionentrycustomer()
        openconnection()
        cboscecustomer.Items.Clear()
        Dim ds As New DataSet
        Dim sql As String

        sql = "select business_name from tbl_account_ledger"
        sqlda = New MySqlDataAdapter(sql, con)

        sqlda.Fill(ds, "fms")
        For Each r As DataRow In ds.Tables(0).Rows
            cboscecustomer.Items.Add(r("business_name"))
        Next

        con.Close()
    End Sub

    Public Sub loadcbosalesandexpensescodingagent()
        openconnection()
        cbosaecodingagent.Items.Clear()
        Dim ds As New DataSet
        Dim sql As String

        sql = "select distinct coding_agent from tbl_sales_and_expenses"
        sqlda = New MySqlDataAdapter(sql, con)

        sqlda.Fill(ds, "fms")
        For Each r As DataRow In ds.Tables(0).Rows
            cbosaecodingagent.Items.Add(r("coding_agent"))
        Next

        con.Close()
    End Sub

    Private Sub lblme_Click(sender As Object, e As EventArgs) Handles lblme.Click

        frmchangepassword.ShowInTaskbar = False
        frmchangepassword.ShowDialog()

    End Sub

    Private Sub btnminimize_Click(sender As Object, e As EventArgs) Handles btnminimize.Click

        Me.WindowState = FormWindowState.Minimized


    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click

        frmlogin.Show()
        Me.Close()

    End Sub

    Private Sub btndsexpandshrink_Click(sender As Object, e As EventArgs) Handles btndsexpandshrink.Click

        lvidodgesales.Items.Clear()
        displaydodgesales()
        If btndsexpandshrink.Text = "<" Then
            btndsexpandshrink.Text = ">"
            lvidodgesalescolumns()
            lvidodgesales.Location = New System.Drawing.Point(3, 39)
            lvidodgesales.Size = New System.Drawing.Size(1349, 514)
        ElseIf btndsexpandshrink.Text = ">" Then
            btndsexpandshrink.Text = "<"
            lvidodgesalescolumns()
            lvidodgesales.Location = New System.Drawing.Point(358, 39)
            lvidodgesales.Size = New System.Drawing.Size(994, 514)
        End If

    End Sub

    Private Sub cbxdsgridlines_CheckedChanged(sender As Object, e As EventArgs) Handles cbxdsgridlines.CheckedChanged

        If cbxdsgridlines.Checked = True Then
            lvidodgesales.GridLines = True
        Else
            lvidodgesales.GridLines = False
        End If

    End Sub

    Private Sub cbodssearch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbodssearch.SelectedIndexChanged

        txtdssearch.Text = ""

    End Sub

    Private Sub btndssearch_Click(sender As Object, e As EventArgs) Handles btndssearch.Click

        If txtdssearch.Text <> "" Then
            displaydodgesales()
            If cbodssearch.Text = "OR No." Then
                For Each birsales As ListViewItem In lvidodgesales.Items
                    If Not birsales.SubItems(0).Text.ToLower.Contains(txtdssearch.Text.ToLower) Then
                        birsales.Remove()
                    End If
                Next
            ElseIf cbodssearch.Text = "Date" Then
                For Each birsales As ListViewItem In lvidodgesales.Items
                    If Not birsales.SubItems(1).Text.ToLower.Contains(txtdssearch.Text.ToLower) Then
                        birsales.Remove()
                    End If
                Next
            ElseIf cbodssearch.Text = "M-code" Then
                For Each birsales As ListViewItem In lvidodgesales.Items
                    If Not birsales.SubItems(2).Text.ToLower.Contains(txtdssearch.Text.ToLower) Then
                        birsales.Remove()
                    End If
                Next
            ElseIf cbodssearch.Text = "Customers Name / Tin" Then
                For Each birsales As ListViewItem In lvidodgesales.Items
                    If Not birsales.SubItems(3).Text.ToLower.Contains(txtdssearch.Text.ToLower) Then
                        birsales.Remove()
                    End If
                Next
            ElseIf cbodssearch.Text = "Description / Supplier" Then
                For Each birsales As ListViewItem In lvidodgesales.Items
                    If Not birsales.SubItems(4).Text.ToLower.Contains(txtdssearch.Text.ToLower) Then
                        birsales.Remove()
                    End If
                Next
            End If
        Else
            displaydodgesales()
        End If

        computedodgesalesgrandtotal()

    End Sub

    Private Sub txtdssearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtdssearch.KeyDown

        If e.KeyCode = Keys.Enter Then
            btndssearch.PerformClick()
        End If

    End Sub

    Private Sub txtdssearch_TextChanged(sender As Object, e As EventArgs) Handles txtdssearch.TextChanged

        If txtdssearch.Text = "" Then
            displaydodgesales()
        End If

    End Sub

    Private Sub computedodgesalesgrandtotal()

        Dim salesvatinclusive, lessvat, netvat, totalamountdue As Decimal
        For Each birsales As ListViewItem In lvidodgesales.Items
            salesvatinclusive += birsales.SubItems(5).Text
            lessvat += birsales.SubItems(6).Text
            netvat += birsales.SubItems(7).Text
            totalamountdue += birsales.SubItems(9).Text
        Next
        lbldssalesvat.Text = FormatNumber(salesvatinclusive)
        lbldslessvat.Text = FormatNumber(lessvat)
        lbldsnetvat.Text = FormatNumber(netvat)
        lbldstotalamountdue.Text = FormatNumber(totalamountdue)

    End Sub

    Private Sub btndsrefresh_Click(sender As Object, e As EventArgs) Handles btndsrefresh.Click

        txtdssearch.Text = ""
        displaydodgesales()
        lvidodgesalescolumns()
        cleartextboxesindodgesales()

    End Sub

    Private Sub dtpdsdate_ValueChanged(sender As Object, e As EventArgs) Handles dtpdsdate.ValueChanged

        dtpdsyearcode.Value = dtpdsdate.Value

    End Sub

    Private Sub txtdssalesc_LostFocus(sender As Object, e As EventArgs) Handles txtdssalesvat.LostFocus

        If txtdssalesvat.Text <> "" Then
            txtdssalesvat.Text = FormatNumber(txtdssalesvat.Text)
        End If

    End Sub

    Private Sub txtdssalesc_TextChanged(sender As Object, e As EventArgs) Handles txtdssalesvat.TextChanged

        Try
            If txtdssalesvat.Text <> "" Then
                Dim salesvatinclusive As Decimal = txtdssalesvat.Text
            End If
        Catch ex As Exception
            txtdssalesvat.Text = ""
            MessageBox.Show("The value that you entered is invalid!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try

        getlessvatinbirsales()
        getnetvat()
        getamountdue()
        addvat()
        gettotalamountdue()

    End Sub

    Private Sub txtdsdiscount_TextChanged(sender As Object, e As EventArgs) Handles txtdsdiscount.TextChanged

        Try
            If txtdsdiscount.Text <> "" Then
                Dim scpwddiscount As Integer = "." & txtdsdiscount.Text
            End If
        Catch ex As Exception
            txtdsdiscount.Text = ""
            MessageBox.Show("The value that you entered is invalid!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try

        getamountdue()
        gettotalamountdue()

    End Sub

    Private Sub txtdsaddvat_LostFocus(sender As Object, e As EventArgs) Handles txtdsaddvat.LostFocus

        If txtdsaddvat.Text <> "" Then
            txtdsaddvat.Text = FormatNumber(txtdsaddvat.Text)
        End If

    End Sub

    Private Sub txtdsaddvat_TextChanged(sender As Object, e As EventArgs) Handles txtdsaddvat.TextChanged

        Try
            If txtdsaddvat.Text <> "" Then
                addvat()
            Else
                txtdstotalamountdue.Text = txtdsamountdue.Text
            End If
        Catch ex As Exception
            txtdsaddvat.Text = ""
            MessageBox.Show("The value that you entered is invalid!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try

    End Sub

    Private Sub getlessvatinbirsales()

        If txtdssalesvat.Text <> "" Then
            Dim salesvatinclusive As Decimal = txtdssalesvat.Text
            Dim lessvat As Decimal = salesvatinclusive / 1.12 * 0.12
            txtdslessvat.Text = FormatNumber(lessvat)
        Else
            txtdslessvat.Text = ""
        End If

    End Sub

    Private Sub getnetvat()

        If txtdssalesvat.Text <> "" Then
            Dim salesvatinclusive As Decimal = txtdssalesvat.Text
            Dim lessvat As Decimal = txtdslessvat.Text
            txtdsnetvat.Text = FormatNumber(salesvatinclusive - lessvat)
        Else
            txtdsnetvat.Text = ""
        End If

    End Sub

    Private Sub getamountdue()

        If txtdssalesvat.Text <> "" Then
            Dim salesvatinclusive As Decimal = txtdssalesvat.Text
            If txtdsdiscount.Text <> "" Then
                Dim discount As String
                If txtdsdiscount.Text < 10 Then
                    discount = ".0" & txtdsdiscount.Text
                ElseIf txtdsdiscount.Text > 9 Then
                    discount = "." & txtdsdiscount.Text
                End If
                txtdsamountdue.Text = FormatNumber(salesvatinclusive - (salesvatinclusive * discount))
            Else
                txtdsamountdue.Text = FormatNumber(salesvatinclusive)
            End If
        Else
            txtdsamountdue.Text = ""
        End If

    End Sub

    Private Sub addvat()

        If txtdssalesvat.Text <> "" Then
            If txtdsamountdue.Text <> "" Then
                If txtdsaddvat.Text <> "" Then
                    Dim amountdue As Decimal = txtdsamountdue.Text
                    Dim addvat As Decimal = txtdsaddvat.Text
                    txtdstotalamountdue.Text = FormatNumber(amountdue + addvat)
                End If
            End If
        End If

    End Sub

    Private Sub gettotalamountdue()

        If txtdssalesvat.Text <> "" Then
            If txtdsdiscount.Text = "" Then
                If txtdsaddvat.Text = "" Then
                    Dim salesvatinclusive As Decimal = txtdssalesvat.Text
                    txtdstotalamountdue.Text = FormatNumber(salesvatinclusive)
                Else
                    Dim amountdue As Decimal = txtdsamountdue.Text
                    Dim addvat As Decimal = txtdsaddvat.Text
                    txtdstotalamountdue.Text = FormatNumber(amountdue + addvat)
                End If
            Else
                If txtdsaddvat.Text <> "" Then
                    Dim amountdue As Decimal = txtdsamountdue.Text
                    Dim addvat As Decimal = txtdsaddvat.Text
                    txtdstotalamountdue.Text = FormatNumber(amountdue + addvat)
                Else
                    txtdstotalamountdue.Text = txtdsamountdue.Text
                End If
            End If
        Else
            txtdstotalamountdue.Text = ""
        End If

    End Sub

    Private Sub lvidodgesales_Click(sender As Object, e As EventArgs) Handles lvidodgesales.Click

        Try
            If lvidodgesales.SelectedItems.Count < 2 Then
                txtdsorno.Text = lvidodgesales.SelectedItems.Item(0).SubItems(0).Text
                txtdsorno2.Text = lvidodgesales.SelectedItems.Item(0).SubItems(0).Text
                dtpdsdate.Value = lvidodgesales.SelectedItems.Item(0).SubItems(1).Text
                txtdscustomersname.Text = lvidodgesales.SelectedItems.Item(0).SubItems(3).Text
                txtdsdescription.Text = lvidodgesales.SelectedItems.Item(0).SubItems(4).Text
                txtdssalesvat.Text = lvidodgesales.SelectedItems.Item(0).SubItems(5).Text
                txtdslessvat.Text = lvidodgesales.SelectedItems.Item(0).SubItems(6).Text
                txtdsnetvat.Text = lvidodgesales.SelectedItems.Item(0).SubItems(7).Text
                txtdsdiscount.Text = lvidodgesales.SelectedItems.Item(0).SubItems(8).Text.Replace("%", "")
                txtdsamountdue.Text = lvidodgesales.SelectedItems.Item(0).SubItems(9).Text
                txtdsaddvat.Text = lvidodgesales.SelectedItems.Item(0).SubItems(10).Text
                txtdstotalamountdue.Text = lvidodgesales.SelectedItems.Item(0).SubItems(11).Text
            Else
                cleartextboxesindodgesales()
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cleartextboxesindodgesales()

        txtdsorno.Text = ""
        dtpdsdate.Value = Now
        dtpdsyearcode.Value = Now
        txtdscustomersname.Text = ""
        txtdsdescription.Text = ""
        txtdssalesvat.Text = ""
        txtdslessvat.Text = ""
        txtdsnetvat.Text = ""
        txtdsdiscount.Text = ""
        txtdsamountdue.Text = ""
        txtdsaddvat.Text = ""
        txtdstotalamountdue.Text = ""

    End Sub

    Private Sub lvidodgesales_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvidodgesales.SelectedIndexChanged

    End Sub

    Private Sub btndsnew_Click(sender As Object, e As EventArgs) Handles btndsnew.Click

        If btndsnew.Text = "New" Then
            btndsnew.Text = "Add"
            txtdsorno.ReadOnly = False
            dtpdsdate.Enabled = True
            txtdscustomersname.ReadOnly = False
            txtdsdescription.ReadOnly = False
            txtdssalesvat.ReadOnly = False
            txtdsdiscount.ReadOnly = False
            txtdsaddvat.ReadOnly = False
            btndsedit.Enabled = False
            btndsdelete.Enabled = False
            lvidodgesales.Enabled = False
            cleartextboxesindodgesales()
            lvidodgesales.Enabled = False
            txtdsorno.Focus()
        ElseIf btndsnew.Text = "Add" Then
            openconnection()
            definedcustomercounter += 1
            cmd.CommandText = "Select or_number from tbl_bir_sales where or_number = @orno" & definedcustomercounter & ""
            cmd.Parameters.AddWithValue("@orno" & definedcustomercounter & "", txtdsorno.Text)
            reader = cmd.ExecuteReader
            If reader.HasRows Then
                reader.Close()
                MessageBox.Show("OR Number is already used.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Else
                reader.Close()
                Dim salesvatinlcusive, lessvat, netvat, amountdue, addvat, totalamountdue As Decimal
                If txtdssalesvat.Text <> "" Then
                    salesvatinlcusive = txtdssalesvat.Text
                End If
                If txtdslessvat.Text <> "" Then
                    lessvat = txtdslessvat.Text
                End If
                If txtdsnetvat.Text <> "" Then
                    netvat = txtdsnetvat.Text
                End If
                If txtdsamountdue.Text <> "" Then
                    amountdue = txtdsamountdue.Text
                End If
                If txtdsaddvat.Text <> "" Then
                    addvat = txtdsaddvat.Text
                End If
                If txtdstotalamountdue.Text <> "" Then
                    totalamountdue = txtdstotalamountdue.Text
                End If

                cmd = New MySqlCommand("INSERT INTO `tbl_bir_sales`(`or_number`,`m_code`,`date`,`customer_name`,`description`,`sales_vat_inclusive`,`less_vat`,`net_vat`,`discount`,`amount_due`,`addvat`,`total_amount_due`) VALUES (@ornumber, @mcode, @date, @customername, @description, @salesvatinclusive, @lessvat, @netvat, @discount, @amountdue, @addvat, @totalamountdue)", con)
                cmd.Parameters.AddWithValue("@ornumber", txtdsorno.Text.Replace("'", ""))
                cmd.Parameters.AddWithValue("@mcode", dtpdsyearcode.Text)
                cmd.Parameters.AddWithValue("@date", dtpdsdate.Text)
                cmd.Parameters.AddWithValue("@customername", txtdscustomersname.Text)
                cmd.Parameters.AddWithValue("@description", txtdsdescription.Text)
                cmd.Parameters.AddWithValue("@salesvatinclusive", salesvatinlcusive)
                cmd.Parameters.AddWithValue("@lessvat", lessvat)
                cmd.Parameters.AddWithValue("@netvat", netvat)
                cmd.Parameters.AddWithValue("@discount", txtdsdiscount.Text)
                cmd.Parameters.AddWithValue("@amountdue", amountdue)
                cmd.Parameters.AddWithValue("@addvat", addvat)
                cmd.Parameters.AddWithValue("@totalamountdue", totalamountdue)
                cmd.ExecuteNonQuery()

                displaydodgesales()
                cleartextboxesindodgesales()
                MessageBox.Show("Data has been added successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                confirm = MessageBox.Show("Do you want to add again?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
                If confirm = vbYes Then
                    txtdsorno.Focus()
                Else
                    btndscancel.PerformClick()
                End If
            End If
            con.Close()
        End If

    End Sub

    Private Sub btndsedit_Click(sender As Object, e As EventArgs) Handles btndsedit.Click

        If accounttype = "admin" Then
            If lvidodgesales.SelectedItems.Count > 0 Then
                If btndsedit.Text = "Edit" Then
                    btndsedit.Text = "Update"
                    txtdsorno.ReadOnly = False
                    dtpdsdate.Enabled = True
                    txtdscustomersname.ReadOnly = False
                    txtdsdescription.ReadOnly = False
                    txtdssalesvat.ReadOnly = False
                    txtdsdiscount.ReadOnly = False
                    txtdsaddvat.ReadOnly = False
                    lvidodgesales.Enabled = False
                ElseIf btndsedit.Text = "Update" Then

                    openconnection()

                    Dim salesvatinlcusive, lessvat, netvat, amountdue, addvat, totalamountdue As Decimal
                    If txtdssalesvat.Text <> "" Then
                        salesvatinlcusive = txtdssalesvat.Text
                    End If
                    If txtdslessvat.Text <> "" Then
                        lessvat = txtdslessvat.Text
                    End If
                    If txtdsnetvat.Text <> "" Then
                        netvat = txtdsnetvat.Text
                    End If
                    If txtdsamountdue.Text <> "" Then
                        amountdue = txtdsamountdue.Text
                    End If
                    If txtdsaddvat.Text <> "" Then
                        addvat = txtdsaddvat.Text
                    End If
                    If txtdstotalamountdue.Text <> "" Then
                        totalamountdue = txtdstotalamountdue.Text
                    End If

                    cmd = New MySqlCommand("UPDATE `tbl_bir_sales` SET `or_number`= @ornumber ,`m_code`= @mcode ,`date`= @date , `customer_name`= @customername ,`description`= @description , `sales_vat_inclusive`= @salesvatinclusive , `less_vat`= @lessvat , `net_vat`= @netvat , `discount`= @discount , `amount_due`= @amountdue , `addvat`= @addvat , `total_amount_due`= @totalamountdue where or_number= @ornumber2", con)
                    cmd.Parameters.AddWithValue("@ornumber", txtdsorno.Text.Replace("'", ""))
                    cmd.Parameters.AddWithValue("@ornumber2", txtdsorno2.Text.Replace("'", ""))
                    cmd.Parameters.AddWithValue("@mcode", dtpdsyearcode.Text)
                    cmd.Parameters.AddWithValue("@date", dtpdsdate.Text)
                    cmd.Parameters.AddWithValue("@customername", txtdscustomersname.Text)
                    cmd.Parameters.AddWithValue("@description", txtdsdescription.Text)
                    cmd.Parameters.AddWithValue("@salesvatinclusive", salesvatinlcusive)
                    cmd.Parameters.AddWithValue("@lessvat", lessvat)
                    cmd.Parameters.AddWithValue("@netvat", netvat)
                    cmd.Parameters.AddWithValue("@discount", txtdsdiscount.Text)
                    cmd.Parameters.AddWithValue("@amountdue", amountdue)
                    cmd.Parameters.AddWithValue("@addvat", addvat)
                    cmd.Parameters.AddWithValue("@totalamountdue", totalamountdue)
                    cmd.ExecuteNonQuery()

                    reader.Close()
                    con.Close()

                    btndsedit.Text = "Edit"
                    txtdsorno.ReadOnly = True
                    dtpdsdate.Enabled = False
                    txtdscustomersname.ReadOnly = True
                    txtdsdescription.ReadOnly = True
                    txtdssalesvat.ReadOnly = True
                    txtdslessvat.ReadOnly = True
                    txtdsnetvat.ReadOnly = True
                    txtdsdiscount.ReadOnly = True
                    txtdsaddvat.ReadOnly = True
                    txtdstotalamountdue.ReadOnly = True
                    lvidodgesales.Enabled = True
                    displaydodgesales()

                    MessageBox.Show("Updated successfully.", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Please select an item to edit.", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("You do not have a permission to edit.", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub btndsdelete_Click(sender As Object, e As EventArgs) Handles btndsdelete.Click

        If accounttype = "admin" Then
            If lvidodgesales.SelectedItems.Count > 0 Then
                confirm = MessageBox.Show("Are you sure?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If confirm = vbYes Then
                    openconnection()
                    For Each account As ListViewItem In lvidodgesales.Items
                        If lvidodgesales.SelectedItems.Count > 0 Then
                            cmddelete = "DELETE FROM `tbl_bir_sales` where or_number='" & lvidodgesales.SelectedItems.Item(0).SubItems(0).Text & "'"
                            sqlda = New MySqlDataAdapter(cmddelete, con)
                            ds = New DataSet()
                            sqlda.Fill(ds)
                            lvidodgesales.SelectedItems.Item(0).Remove()
                        End If
                    Next
                    computedodgesalesgrandtotal()
                    btndscancel.PerformClick()
                    con.Close()
                    MessageBox.Show("Deleted successfully.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Please select an item to delete.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("You do not have a permission to delete.", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub btndscancel_Click(sender As Object, e As EventArgs) Handles btndscancel.Click

        btndsnew.Text = "New"
        btndsedit.Text = "Edit"
        txtdsorno.ReadOnly = True
        dtpdsdate.Enabled = False
        txtdscustomersname.ReadOnly = True
        txtdsdescription.ReadOnly = True
        txtdssalesvat.ReadOnly = True
        txtdsdiscount.ReadOnly = True
        txtdsaddvat.ReadOnly = True
        btndsedit.Enabled = True
        btndsdelete.Enabled = True
        cleartextboxesindodgesales()
        lvidodgesales.Enabled = True

    End Sub

    Private Sub btnalexpandshrink_Click(sender As Object, e As EventArgs) Handles btnalexpandshrink.Click

        lviaccountledger.Items.Clear()
        displayaccountledger()
        If btnalexpandshrink.Text = "<" Then
            btnalexpandshrink.Text = ">"
            lviaccountledgercolumns()
            lviaccountledger.Location = New System.Drawing.Point(3, 39)
            lviaccountledger.Size = New System.Drawing.Size(1349, 514)
        ElseIf btnalexpandshrink.Text = ">" Then
            btnalexpandshrink.Text = "<"
            lviaccountledgercolumns()
            lviaccountledger.Location = New System.Drawing.Point(358, 39)
            lviaccountledger.Size = New System.Drawing.Size(994, 514)
        End If

    End Sub

    Private Sub cbxalgridlines_CheckedChanged(sender As Object, e As EventArgs) Handles cbxalgridlines.CheckedChanged

        If cbxalgridlines.Checked = True Then
            lviaccountledger.GridLines = True
        Else
            lviaccountledger.GridLines = False
        End If

    End Sub

    Private Sub cboalsearch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboalsearch.SelectedIndexChanged

        txtalsearch.Text = ""

    End Sub

    Private Sub btnalsearch_Click(sender As Object, e As EventArgs) Handles btnalsearch.Click

        If txtalsearch.Text <> "" Then
            displayaccountledger()
            If cboalsearch.Text = "Business Name" Then
                For Each account As ListViewItem In lviaccountledger.Items
                    If Not account.SubItems(0).Text.ToLower.Contains(txtalsearch.Text.ToLower) Then
                        account.Remove()
                    End If
                Next
            ElseIf cboalsearch.Text = "Register Owner" Then
                For Each account As ListViewItem In lviaccountledger.Items
                    If Not account.SubItems(1).Text.ToLower.Contains(txtalsearch.Text.ToLower) Then
                        account.Remove()
                    End If
                Next
            ElseIf cboalsearch.Text = "Address" Then
                For Each account As ListViewItem In lviaccountledger.Items
                    If Not account.SubItems(2).Text.ToLower.Contains(txtalsearch.Text.ToLower) Then
                        account.Remove()
                    End If
                Next
            ElseIf cboalsearch.Text = "Contact Number" Then
                For Each account As ListViewItem In lviaccountledger.Items
                    If Not account.SubItems(3).Text.ToLower.Contains(txtalsearch.Text.ToLower) Then
                        account.Remove()
                    End If
                Next
            End If
        Else
            displayaccountledger()
        End If

        computeaccountledgergrandtotal()

    End Sub

    Private Sub txtalsearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtalsearch.KeyDown

        If e.KeyCode = Keys.Enter Then
            btnalsearch.PerformClick()
        End If

    End Sub

    Private Sub txtalsearch_TextChanged(sender As Object, e As EventArgs) Handles txtalsearch.TextChanged

        If txtalsearch.Text = "" Then
            displayaccountledger()
        End If

    End Sub

    Private Sub computeaccountledgergrandtotal()

        Dim totalsales, totalpayment, balance As Decimal
        For Each account As ListViewItem In lviaccountledger.Items
            totalsales += account.SubItems(6).Text
            totalpayment += account.SubItems(7).Text
            balance += account.SubItems(8).Text
        Next
        lblaltotalsales.Text = FormatNumber(totalsales)
        lblaltotalpayments.Text = FormatNumber(totalpayment)
        lblalbalance.Text = FormatNumber(balance)

    End Sub

    Private Sub btnalrefresh_Click(sender As Object, e As EventArgs) Handles btnalrefresh.Click

        txtalsearch.Text = ""
        displayaccountledger()
        lviaccountledgercolumns()
        cleartextboxesinaccountledger()

    End Sub

    Private Sub btnalnew_Click(sender As Object, e As EventArgs) Handles btnalnew.Click

        If btnalnew.Text = "New" Then
            btnalnew.Text = "Add"
            txtalbusinessname.ReadOnly = False
            txtalregisteredowner.ReadOnly = False
            txtaladdress.ReadOnly = False
            txtalcontactnumber.ReadOnly = False
            cboallocalcode.Enabled = True
            txtalterm.ReadOnly = False
            txtalremarks.ReadOnly = False
            txtaldueaccount.ReadOnly = False
            btnaledit.Enabled = False
            btnaldelete.Enabled = False
            cleartextboxesinaccountledger()
            txtalbusinessname.Focus()
            lviaccountledger.Enabled = False
        ElseIf btnalnew.Text = "Add" Then
            If txtalbusinessname.Text <> "" Then

                openconnection()
                alaccountidgenerator()

                cmd = New MySqlCommand("INSERT INTO `tbl_account_ledger`(`account_id`,`business_name`,`registered_owner`,`address`,`contact_number`,`local_code`,`term`,`remarks`,`due_account_to_date`) VALUES (@id,@businessname,@registeredowner,@address,@contactnumber,@localcode,@term,@remarks,@dueaccount)", con)
                cmd.Parameters.AddWithValue("@id", alaccountfinalizedid)
                cmd.Parameters.AddWithValue("@businessname", txtalbusinessname.Text)
                cmd.Parameters.AddWithValue("@registeredowner", txtalregisteredowner.Text)
                cmd.Parameters.AddWithValue("@address", txtaladdress.Text)
                cmd.Parameters.AddWithValue("@contactnumber", txtalcontactnumber.Text)
                cmd.Parameters.AddWithValue("@localcode", cboallocalcode.Text)
                cmd.Parameters.AddWithValue("@term", txtalterm.Text)
                cmd.Parameters.AddWithValue("@remarks", txtalremarks.Text)
                cmd.Parameters.AddWithValue("@dueaccount", txtaldueaccount.Text)
                cmd.ExecuteNonQuery()

                con.Close()
                loadcbosalesandcollectionentrycustomer()
                loadcboaccountledgerlocalcode()
                cleartextboxesinaccountledger()
                displayaccountledger()
                MessageBox.Show("Data has been added successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                confirm = MessageBox.Show("Do you want to add again?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
                If confirm = vbYes Then
                    txtalbusinessname.Focus()
                Else
                    btnalcancel.PerformClick()
                End If
            Else
                MessageBox.Show("Business name cannot be empty!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If

    End Sub

    Private Sub btnaledit_Click(sender As Object, e As EventArgs) Handles btnaledit.Click

        If accounttype = "admin" Then
            If lviaccountledger.SelectedItems.Count > 0 Then
                If btnaledit.Text = "Edit" Then
                    btnaledit.Text = "Update"
                    txtalbusinessname.ReadOnly = False
                    txtalregisteredowner.ReadOnly = False
                    txtaladdress.ReadOnly = False
                    txtalcontactnumber.ReadOnly = False
                    cboallocalcode.Enabled = True
                    txtalterm.ReadOnly = False
                    txtalremarks.ReadOnly = False
                    txtaldueaccount.ReadOnly = False
                    lviaccountledger.Enabled = False
                ElseIf btnaledit.Text = "Update" Then

                    openconnection()

                    cmd = New MySqlCommand("UPDATE `tbl_account_ledger` SET `business_name`= @businessname ,`registered_owner`= @registeredowner ,`address`= @address , `contact_number`= @contactnumber ,`local_code`= @localcode , `term`= @term , `remarks`= @remarks , `due_account_to_date`= @dueaccount where account_id=@id", con)
                    cmd.Parameters.AddWithValue("@id", txtalid.Text)
                    cmd.Parameters.AddWithValue("@businessname", txtalbusinessname.Text)
                    cmd.Parameters.AddWithValue("@registeredowner", txtalregisteredowner.Text)
                    cmd.Parameters.AddWithValue("@address", txtaladdress.Text)
                    cmd.Parameters.AddWithValue("@contactnumber", txtalcontactnumber.Text)
                    cmd.Parameters.AddWithValue("@localcode", cboallocalcode.Text)
                    cmd.Parameters.AddWithValue("@term", txtalterm.Text)
                    cmd.Parameters.AddWithValue("@remarks", txtalremarks.Text)
                    cmd.Parameters.AddWithValue("@dueaccount", txtaldueaccount.Text)
                    cmd.ExecuteNonQuery()

                    reader.Close()
                    con.Close()

                    displayaccountledger()
                    loadcboaccountledgerlocalcode()

                    btnaledit.Text = "Edit"
                    txtalbusinessname.ReadOnly = True
                    txtalregisteredowner.ReadOnly = True
                    txtaladdress.ReadOnly = True
                    txtalcontactnumber.ReadOnly = True
                    cboallocalcode.Enabled = False
                    txtalterm.ReadOnly = True
                    txtalremarks.ReadOnly = True
                    txtaldueaccount.ReadOnly = True
                    lvisalesandexpenses.Enabled = True
                    lviaccountledger.Enabled = True
                    loadcbosalesandcollectionentrycustomer()
                    MessageBox.Show("Updated successfully.", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Please select an item to edit.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("You do not have a permission to edit.", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub btnaldelete_Click(sender As Object, e As EventArgs) Handles btnaldelete.Click

        If accounttype = "admin" Then
            If lviaccountledger.SelectedItems.Count > 0 Then
                confirm = MessageBox.Show("Are you sure?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If confirm = vbYes Then
                    openconnection()
                    For Each account As ListViewItem In lviaccountledger.Items
                        If lviaccountledger.SelectedItems.Count > 0 Then
                            cmddelete = "DELETE FROM `tbl_account_ledger` where account_id='" & lviaccountledger.SelectedItems.Item(0).SubItems(11).Text & "'"
                            sqlda = New MySqlDataAdapter(cmddelete, con)
                            ds = New DataSet()
                            sqlda.Fill(ds)
                            con.Close()
                            cleartextboxesinaccountledger()
                            lviaccountledger.SelectedItems.Item(0).Remove()
                        End If
                    Next
                    computeaccountledgergrandtotal()
                    loadcbosalesandcollectionentrycustomer()
                    loadcboaccountledgerlocalcode()
                    btnalcancel.PerformClick()
                    con.Close()
                    MessageBox.Show("Deleted successfully.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Please select an item to delete.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("You do not have a permission to delete.", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub lviaccountledger_Click(sender As Object, e As EventArgs) Handles lviaccountledger.Click

        Try
            If lviaccountledger.SelectedItems.Count < 2 Then
                txtalid.Text = lviaccountledger.SelectedItems.Item(0).SubItems(11).Text
                txtalbusinessname.Text = lviaccountledger.SelectedItems.Item(0).SubItems(0).Text
                txtalregisteredowner.Text = lviaccountledger.SelectedItems.Item(0).SubItems(1).Text
                txtaladdress.Text = lviaccountledger.SelectedItems.Item(0).SubItems(2).Text
                txtalcontactnumber.Text = lviaccountledger.SelectedItems.Item(0).SubItems(3).Text
                cboallocalcode.Text = lviaccountledger.SelectedItems.Item(0).SubItems(4).Text
                txtalterm.Text = lviaccountledger.SelectedItems.Item(0).SubItems(5).Text
                txtaltotalsales.Text = lviaccountledger.SelectedItems.Item(0).SubItems(6).Text
                txtaltotalpayments.Text = lviaccountledger.SelectedItems.Item(0).SubItems(7).Text
                txtalbalance.Text = lviaccountledger.SelectedItems.Item(0).SubItems(8).Text
                txtalremarks.Text = lviaccountledger.SelectedItems.Item(0).SubItems(9).Text
                txtaldueaccount.Text = lviaccountledger.SelectedItems.Item(0).SubItems(10).Text
            Else
                cleartextboxesinaccountledger()
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cleartextboxesinaccountledger()

        txtalid.Text = ""
        txtalbusinessname.Text = ""
        txtalregisteredowner.Text = ""
        txtaladdress.Text = ""
        txtalcontactnumber.Text = ""
        cboallocalcode.Text = ""
        txtalterm.Text = ""
        txtaltotalsales.Text = ""
        txtaltotalpayments.Text = ""
        txtalbalance.Text = ""
        txtalremarks.Text = ""
        txtaldueaccount.Text = ""

    End Sub

    Private Sub btnalcancel_Click(sender As Object, e As EventArgs) Handles btnalcancel.Click

        btnaledit.Enabled = True
        btnaldelete.Enabled = True
        txtalbusinessname.ReadOnly = True
        txtalregisteredowner.ReadOnly = True
        txtaladdress.ReadOnly = True
        txtalcontactnumber.ReadOnly = True
        cboallocalcode.Enabled = False
        txtalterm.ReadOnly = True
        txtalremarks.ReadOnly = True
        txtaldueaccount.ReadOnly = True
        cleartextboxesinaccountledger()
        btnalnew.Text = "New"
        btnaledit.Text = "Edit"
        lviaccountledger.Enabled = True

    End Sub

    Private Sub btnslexpandshrink_Click(sender As Object, e As EventArgs) Handles btnslexpandshrink.Click

        lvisupplierlist.Items.Clear()
        displaysupplierlist()
        If btnslexpandshrink.Text = "<" Then
            btnslexpandshrink.Text = ">"
            lvisupplierlistcolumns()
            lvisupplierlist.Location = New System.Drawing.Point(3, 39)
            lvisupplierlist.Size = New System.Drawing.Size(1349, 570)
        ElseIf btnslexpandshrink.Text = ">" Then
            btnslexpandshrink.Text = "<"
            lvisupplierlistcolumns()
            lvisupplierlist.Location = New System.Drawing.Point(358, 39)
            lvisupplierlist.Size = New System.Drawing.Size(994, 570)
        End If

    End Sub

    Private Sub cbxslgridlines_CheckedChanged(sender As Object, e As EventArgs) Handles cbxslgridlines.CheckedChanged

        If cbxslgridlines.Checked = True Then
            lvisupplierlist.GridLines = True
        Else
            lvisupplierlist.GridLines = False
        End If

    End Sub

    Private Sub cboslsearch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboslsearch.SelectedIndexChanged

        txtslsearch.Text = ""

    End Sub

    Private Sub btnslsearch_Click(sender As Object, e As EventArgs) Handles btnslsearch.Click

        If txtslsearch.Text <> "" Then
            displaysupplierlist()
            If cboslsearch.Text = "Suppliers Name" Then
                For Each supplier As ListViewItem In lvisupplierlist.Items
                    If Not supplier.SubItems(0).Text.ToLower.Contains(txtslsearch.Text.ToLower) Then
                        supplier.Remove()
                    End If
                Next
            ElseIf cboslsearch.Text = "Contact Person" Then
                For Each supplier As ListViewItem In lvisupplierlist.Items
                    If Not supplier.SubItems(1).Text.ToLower.Contains(txtslsearch.Text.ToLower) Then
                        supplier.Remove()
                    End If
                Next
            ElseIf cboslsearch.Text = "Address" Then
                For Each supplier As ListViewItem In lvisupplierlist.Items
                    If Not supplier.SubItems(2).Text.ToLower.Contains(txtslsearch.Text.ToLower) Then
                        supplier.Remove()
                    End If
                Next
            ElseIf cboslsearch.Text = "Contact Number" Then
                For Each supplier As ListViewItem In lvisupplierlist.Items
                    If Not supplier.SubItems(3).Text.ToLower.Contains(txtslsearch.Text.ToLower) Then
                        supplier.Remove()
                    End If
                Next
            ElseIf cboslsearch.Text = "Email Address" Then
                For Each supplier As ListViewItem In lvisupplierlist.Items
                    If Not supplier.SubItems(4).Text.ToLower.Contains(txtslsearch.Text.ToLower) Then
                        supplier.Remove()
                    End If
                Next
            End If
        Else
            displaysupplierlist()
        End If

    End Sub

    Private Sub txtslsearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtslsearch.KeyDown

        If e.KeyCode = Keys.Enter Then
            btnslsearch.PerformClick()
        End If

    End Sub

    Private Sub txtslseach_TextChanged(sender As Object, e As EventArgs) Handles txtslsearch.TextChanged

        If txtslsearch.Text = "" Then
            displaysupplierlist()
        End If

    End Sub

    Private Sub btnslrefresh_Click(sender As Object, e As EventArgs) Handles btnslrefresh.Click

        txtslsearch.Text = ""
        displaysupplierlist()
        lvisupplierlistcolumns()
        cleartextboxesinsupplierlist()

    End Sub

    Private Sub lvisupplierlist_Click(sender As Object, e As EventArgs) Handles lvisupplierlist.Click

        Try
            If lvisupplierlist.SelectedItems.Count < 2 Then
                txtslsuppliersname.Text = lvisupplierlist.SelectedItems.Item(0).SubItems(0).Text
                txtslcontactperson.Text = lvisupplierlist.SelectedItems.Item(0).SubItems(1).Text
                txtsladdress.Text = lvisupplierlist.SelectedItems.Item(0).SubItems(2).Text
                txtslcontactnumnber.Text = lvisupplierlist.SelectedItems.Item(0).SubItems(3).Text
                txtslemail.Text = lvisupplierlist.SelectedItems.Item(0).SubItems(4).Text
                txtslterm.Text = lvisupplierlist.SelectedItems.Item(0).SubItems(5).Text
                txtsltinnumber.Text = lvisupplierlist.SelectedItems.Item(0).SubItems(6).Text
                txtslid.Text = lvisupplierlist.SelectedItems.Item(0).SubItems(7).Text
            Else
                cleartextboxesinsupplierlist()
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cleartextboxesinsupplierlist()

        txtslid.Text = ""
        txtslsuppliersname.Text = ""
        txtslcontactperson.Text = ""
        txtsladdress.Text = ""
        txtslcontactnumnber.Text = ""
        txtslemail.Text = ""
        txtslterm.Text = ""
        txtsltinnumber.Text = ""

    End Sub

    Private Sub btnslnew_Click(sender As Object, e As EventArgs) Handles btnslnew.Click

        If btnslnew.Text = "New" Then
            btnslnew.Text = "Add"
            txtslsuppliersname.ReadOnly = False
            txtslcontactperson.ReadOnly = False
            txtsladdress.ReadOnly = False
            txtslcontactnumnber.ReadOnly = False
            txtslemail.ReadOnly = False
            txtslterm.ReadOnly = False
            txtsltinnumber.ReadOnly = False
            btnsledit.Enabled = False
            btnsldelete.Enabled = False
            txtslsuppliersname.Focus()
            cleartextboxesinsupplierlist()
            lvisupplierlist.Enabled = False
        ElseIf btnslnew.Text = "Add" Then

            openconnection()
            supplieridgenerator()

            cmd = New MySqlCommand("INSERT INTO `tbl_supplier_list`(`supplier_id`,`supplier_name`,`term`,`tin_number`,`address`,`contact_person`,`contact_number`,`email_address`) VALUES (@supplierid,@suppliername,@term,@tinnumber,@address,@contactperson,@contactnumber,@emailaddress)", con)
            cmd.Parameters.AddWithValue("@supplierid", supplieridfinalizedid)
            cmd.Parameters.AddWithValue("@suppliername", txtslsuppliersname.Text)
            cmd.Parameters.AddWithValue("@term", txtslterm.Text)
            cmd.Parameters.AddWithValue("@tinnumber", txtsltinnumber.Text)
            cmd.Parameters.AddWithValue("@address", txtsladdress.Text)
            cmd.Parameters.AddWithValue("@contactperson", txtslcontactperson.Text)
            cmd.Parameters.AddWithValue("@contactnumber", txtslcontactnumnber.Text)
            cmd.Parameters.AddWithValue("@emailaddress", txtslemail.Text)
            cmd.ExecuteNonQuery()

            con.Close()
            cleartextboxesinsupplierlist()
            displaysupplierlist()
            'btnslcancel.PerformClick()
            MessageBox.Show("Data has been added successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            confirm = MessageBox.Show("Do you want to add again?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
            If confirm = vbYes Then
                txtslsuppliersname.Focus()
            Else
                btnslcancel.PerformClick()
            End If
        End If

    End Sub

    Private Sub btnsledit_Click(sender As Object, e As EventArgs) Handles btnsledit.Click

        If accounttype = "admin" Then
            If lvisupplierlist.SelectedItems.Count > 0 Then
                If btnsledit.Text = "Edit" Then
                    btnsledit.Text = "Update"
                    txtslsuppliersname.ReadOnly = False
                    txtslcontactperson.ReadOnly = False
                    txtsladdress.ReadOnly = False
                    txtslcontactnumnber.ReadOnly = False
                    txtslemail.ReadOnly = False
                    txtslterm.ReadOnly = False
                    txtsltinnumber.ReadOnly = False
                    lvisalesandexpenses.Enabled = False
                    lvisupplierlist.Enabled = False
                ElseIf btnsledit.Text = "Update" Then

                    openconnection()

                    cmd = New MySqlCommand("UPDATE `tbl_supplier_list` SET `supplier_name`= @suppliername ,`term`= @term ,`tin_number`= @tinnumber , `address`= @address ,`contact_person`= @contactperson , `contact_number`= @contactnumber , `email_address`= @emailaddress where supplier_id=@supplierid", con)
                    cmd.Parameters.AddWithValue("@supplierid", txtslid.Text)
                    cmd.Parameters.AddWithValue("@suppliername", txtslsuppliersname.Text)
                    cmd.Parameters.AddWithValue("@term", txtslterm.Text)
                    cmd.Parameters.AddWithValue("@tinnumber", txtsltinnumber.Text)
                    cmd.Parameters.AddWithValue("@address", txtsladdress.Text)
                    cmd.Parameters.AddWithValue("@contactperson", txtslcontactperson.Text)
                    cmd.Parameters.AddWithValue("@contactnumber", txtslcontactnumnber.Text)
                    cmd.Parameters.AddWithValue("@emailaddress", txtslemail.Text)
                    cmd.ExecuteNonQuery()
                    reader.Close()
                    con.Close()

                    displaysupplierlist()
                    btnsledit.Text = "Edit"
                    txtslsuppliersname.ReadOnly = True
                    txtslcontactperson.ReadOnly = True
                    txtsladdress.ReadOnly = True
                    txtslcontactnumnber.ReadOnly = True
                    txtslemail.ReadOnly = True
                    txtslterm.ReadOnly = True
                    txtsltinnumber.ReadOnly = True
                    lvisupplierlist.Enabled = True
                    MessageBox.Show("Updated successfully.", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Please select an item to edit.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("You do not have a permission to edit.", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub btnsldelete_Click(sender As Object, e As EventArgs) Handles btnsldelete.Click

        If accounttype = "admin" Then
            If lvisupplierlist.SelectedItems.Count > 0 Then
                confirm = MessageBox.Show("Are you sure?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If confirm = vbYes Then
                    openconnection()
                    For Each account As ListViewItem In lvisupplierlist.Items
                        If lvisupplierlist.SelectedItems.Count > 0 Then
                            cmddelete = "DELETE FROM `tbl_supplier_list` where supplier_id='" & lvisupplierlist.SelectedItems.Item(0).SubItems(7).Text & "'"
                            sqlda = New MySqlDataAdapter(cmddelete, con)
                            ds = New DataSet()
                            sqlda.Fill(ds)
                            con.Close()
                            lvisupplierlist.SelectedItems.Item(0).Remove()
                        End If
                    Next
                    btnslcancel.PerformClick()
                    MessageBox.Show("Deleted successfully.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Please select an item to delete.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("You do not have a permission to delete.", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub btnslcancel_Click(sender As Object, e As EventArgs) Handles btnslcancel.Click

        cleartextboxesinsupplierlist()

        txtslsuppliersname.ReadOnly = True
        txtslcontactperson.ReadOnly = True
        txtsladdress.ReadOnly = True
        txtslcontactnumnber.ReadOnly = True
        txtslemail.ReadOnly = True
        txtslterm.ReadOnly = True
        txtsltinnumber.ReadOnly = True
        lvisupplierlist.Enabled = True
        btnsledit.Enabled = True
        btnsldelete.Enabled = True
        btnslnew.Text = "New"
        btnsledit.Text = "Edit"

    End Sub

    Private Sub btnsaeexpandshrink_Click(sender As Object, e As EventArgs) Handles btnsaeexpandshrink.Click

        lvisalesandexpenses.Items.Clear()
        If btnsaeexpandshrink.Text = "<" Then
            btnsaeexpandshrink.Text = ">"
            lvisalesandexpensescolumns()
            lvisalesandexpenses.Location = New System.Drawing.Point(3, 39)
            lvisalesandexpenses.Size = New System.Drawing.Size(1349, 514)
        ElseIf btnsaeexpandshrink.Text = ">" Then
            btnsaeexpandshrink.Text = "<"
            lvisalesandexpensescolumns()
            lvisalesandexpenses.Location = New System.Drawing.Point(358, 39)
            lvisalesandexpenses.Size = New System.Drawing.Size(994, 514)
        End If
        displaysalesandexpenses()

    End Sub

    Private Sub cbxsaegridlines_CheckedChanged(sender As Object, e As EventArgs) Handles cbxsaegridlines.CheckedChanged

        If cbxsaegridlines.Checked = True Then
            lvisalesandexpenses.GridLines = True
        Else
            lvisalesandexpenses.GridLines = False
        End If

    End Sub

    Private Sub cbosaesearch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbosaesearch.SelectedIndexChanged

        txtsaesearch.Text = ""

    End Sub

    Private Sub btnsaesearch_Click(sender As Object, e As EventArgs) Handles btnsaesearch.Click

        If txtsaesearch.Text <> "" Then
            displaysalesandexpenses()
            If cbosaesearch.Text = "Date" Then
                For Each salesandexpenses As ListViewItem In lvisalesandexpenses.Items
                    If Not salesandexpenses.SubItems(0).Text.ToLower.Contains(txtsaesearch.Text.ToLower) Then
                        salesandexpenses.Remove()
                    End If
                Next
            ElseIf cbosaesearch.Text = "Particular" Then
                For Each salesandexpenses As ListViewItem In lvisalesandexpenses.Items
                    If Not salesandexpenses.SubItems(1).Text.ToLower.Contains(txtsaesearch.Text.ToLower) Then
                        salesandexpenses.Remove()
                    End If
                Next
            End If
        Else
            displaysalesandexpenses()
        End If

        computesalesandexpensesgrandtotal()

    End Sub

    Private Sub txtsaesearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsaesearch.KeyDown

        If e.KeyCode = Keys.Enter Then
            btnsaesearch.PerformClick()
        End If

    End Sub

    Private Sub txtsaesearch_TextChanged(sender As Object, e As EventArgs) Handles txtsaesearch.TextChanged

        If txtsaesearch.Text = "" Then
            displaysalesandexpenses()
        End If

    End Sub

    Private Sub computesalesandexpensesgrandtotal()

        Dim cashpayment, checkpayment, totalsales, totalexpenses, netsales, possiblegincomming As Decimal
        For Each salesandexpenses As ListViewItem In lvisalesandexpenses.Items
            cashpayment += salesandexpenses.SubItems(3).Text
            checkpayment += salesandexpenses.SubItems(4).Text
            totalsales += salesandexpenses.SubItems(5).Text
            totalexpenses += salesandexpenses.SubItems(6).Text
            netsales += salesandexpenses.SubItems(7).Text
            possiblegincomming += salesandexpenses.SubItems(9).Text
        Next
        lblsaecashpayment.Text = FormatNumber(cashpayment)
        lblsaecheckpayment.Text = FormatNumber(checkpayment)
        lblsaetotalsales.Text = FormatNumber(totalsales)
        lblsaetotalexpenses.Text = FormatNumber(totalexpenses)
        lblsaenetsales.Text = FormatNumber(netsales)
        lblsaepossiblegincoming.Text = FormatNumber(possiblegincomming)

    End Sub

    Private Sub btnsaerefresh_Click(sender As Object, e As EventArgs) Handles btnsaerefresh.Click

        txtsaesearch.Text = ""
        displaysalesandexpenses()
        lvisalesandexpensescolumns()
        cleartextboxesinsalesandexpenses()

    End Sub

    Private Sub txtsaecashpayment_LostFocus(sender As Object, e As EventArgs) Handles txtsaecashpayment.LostFocus

        If txtsaecashpayment.Text <> "" Then
            Dim cashpayment As Decimal = txtsaecashpayment.Text
            If cashpayment > 999 Then
                txtsaecashpayment.Text = Format((cashpayment), "0,00.00")
            ElseIf cashpayment < 1000 Then
                txtsaecashpayment.Text = Format((cashpayment), "0.00")
            End If
        End If

    End Sub

    Private Sub txtsaecashpayment_TextChanged(sender As Object, e As EventArgs) Handles txtsaecashpayment.TextChanged

        Try
            Dim cashpayment As Decimal
            Dim checkpayment As Decimal
            Dim totalsales As Decimal
            If txtsaecashpayment.Text <> "" And txtsaecheckpayment.Text <> "" Then
                cashpayment = txtsaecashpayment.Text
                checkpayment = txtsaecheckpayment.Text
                totalsales = cashpayment + checkpayment
                If totalsales > 999 Then
                    txtsaetotalsales.Text = Format((totalsales), "0,00.00")
                    txtsaenetsales.Text = Format((totalsales), "0,00.00")
                ElseIf totalsales < 1000 Then
                    txtsaetotalsales.Text = Format((totalsales), "0.00")
                    txtsaenetsales.Text = Format((totalsales), "0.00")
                End If
            ElseIf txtsaecashpayment.Text = "" And txtsaecheckpayment.Text = "" Then
                txtsaetotalsales.Text = ""
                txtsaenetsales.Text = ""
            ElseIf txtsaecashpayment.Text = "" And txtsaecheckpayment.Text <> "" Then
                txtsaetotalsales.Text = txtsaecheckpayment.Text
                txtsaenetsales.Text = txtsaecheckpayment.Text
            ElseIf txtsaecheckpayment.Text = "" Then
                cashpayment = txtsaecashpayment.Text
                txtsaetotalsales.Text = txtsaecashpayment.Text
                txtsaenetsales.Text = txtsaecashpayment.Text
            End If
        Catch ex As Exception
            txtsaecashpayment.Text = ""
            MessageBox.Show("Cash payment is invalid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        gettotalexpenses()
        getpossiblegincoming()

    End Sub

    Private Sub txtsaecheckpayment_LostFocus(sender As Object, e As EventArgs) Handles txtsaecheckpayment.LostFocus

        If txtsaecheckpayment.Text <> "" Then
            Dim checkpayment As Decimal = txtsaecheckpayment.Text
            If checkpayment > 999 Then
                txtsaecheckpayment.Text = Format((checkpayment), "0,00.00")
            ElseIf checkpayment < 1000 Then
                txtsaecheckpayment.Text = Format((checkpayment), "0.00")
            End If
        End If

    End Sub

    Private Sub txtsaecheckpayment_TextChanged(sender As Object, e As EventArgs) Handles txtsaecheckpayment.TextChanged

        Try
            Dim cashpayment As Decimal
            Dim checkpayment As Decimal
            Dim totalsales As Decimal
            If txtsaecheckpayment.Text <> "" And txtsaecashpayment.Text <> "" Then
                checkpayment = txtsaecheckpayment.Text
                cashpayment = txtsaecashpayment.Text
                totalsales = cashpayment + checkpayment
                If totalsales > 999 Then
                    txtsaetotalsales.Text = Format((totalsales), "0,00.00")
                    txtsaenetsales.Text = Format((totalsales), "0,00.00")
                ElseIf totalsales < 1000 Then
                    txtsaetotalsales.Text = Format((totalsales), "0.00")
                    txtsaenetsales.Text = Format((totalsales), "0.00")
                End If
            ElseIf txtsaecashpayment.Text = "" And txtsaecheckpayment.Text = "" Then
                txtsaetotalsales.Text = ""
                txtsaenetsales.Text = ""
            ElseIf txtsaecheckpayment.Text = "" And txtsaecashpayment.Text <> "" Then
                txtsaetotalsales.Text = txtsaecashpayment.Text
                txtsaenetsales.Text = txtsaecashpayment.Text
            ElseIf txtsaecashpayment.Text = "" Then
                checkpayment = txtsaecheckpayment.Text
                txtsaetotalsales.Text = txtsaecheckpayment.Text
                txtsaenetsales.Text = txtsaecheckpayment.Text
            End If
        Catch ex As Exception
            txtsaecheckpayment.Text = ""
            MessageBox.Show("Check payment is invalid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        gettotalexpenses()
        getpossiblegincoming()

    End Sub

    Private Sub txtsaetotalexpenses_LostFocus(sender As Object, e As EventArgs) Handles txtsaetotalexpenses.LostFocus

        If txtsaetotalexpenses.Text <> "" Then
            Dim totalexpenses As Decimal = txtsaetotalexpenses.Text
            If totalexpenses > 999 Then
                txtsaetotalexpenses.Text = Format((totalexpenses), "0,00.00")
            ElseIf totalexpenses < 1000 Then
                txtsaetotalexpenses.Text = Format((totalexpenses), "0.00")
            End If
        End If

    End Sub

    Private Sub gettotalexpenses()

        Try
            Dim totalsales As Decimal
            Dim totalexpenses As Decimal
            Dim netsales As Decimal
            If txtsaetotalexpenses.Text <> "" Then
                totalexpenses = txtsaetotalexpenses.Text
                If txtsaetotalsales.Text <> "" Then
                    totalsales = txtsaetotalsales.Text
                Else
                    txtsaenetsales.Text = ""
                    Exit Sub
                End If
                netsales = totalsales - totalexpenses
                If netsales > 999 Then
                    txtsaenetsales.Text = Format((netsales), "0,00.00")
                ElseIf netsales < 1000 Then
                    txtsaenetsales.Text = Format((netsales), "0.00")
                End If
            ElseIf txtsaetotalexpenses.Text = "" Then
                txtsaenetsales.Text = txtsaetotalsales.Text
            End If
        Catch ex As Exception
            txtsaetotalexpenses.Text = ""
            MessageBox.Show("Total expenses is invalid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

    End Sub

    Private Sub txtsaetotalexpenses_TextChanged(sender As Object, e As EventArgs) Handles txtsaetotalexpenses.TextChanged

        gettotalexpenses()
        getpossiblegincoming()

    End Sub

    Private Sub txtsaegrosspercent_TextChanged(sender As Object, e As EventArgs) Handles txtsaegrosspercent.TextChanged

        Try
            If txtsaegrosspercent.Text <> "" Then
                Dim grosspercent As Decimal = txtsaegrosspercent.Text
                getpossiblegincoming()
            Else
                txtsaepossiblegincoming.Text = ""
            End If
        Catch ex As Exception
            txtsaegrosspercent.Text = ""
            MessageBox.Show("Gross percent is invalid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

    End Sub

    Private Sub getpossiblegincoming()

        'Try
        If txtsaenetsales.Text <> "" Then
            If txtsaegrosspercent.Text <> "" Then
                Dim grosspercent As String
                If txtsaegrosspercent.Text < 10 Then
                    grosspercent = ".0" & txtsaegrosspercent.Text
                ElseIf txtsaegrosspercent.Text > 9 Then
                    grosspercent = "." & txtsaegrosspercent.Text
                End If
                Dim netsales As Decimal = txtsaenetsales.Text
                Dim possiblegincoming As Decimal = netsales * grosspercent
                txtsaepossiblegincoming.Text = FormatNumber(possiblegincoming)
            End If
        Else
            txtsaepossiblegincoming.Text = ""
        End If
        'Catch ex As Exception
        '    txtsaepossiblegincoming.Text = ""
        '    MessageBox.Show("Possbile G-Incoming is invalid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try

    End Sub

    'Private Sub txtsaepossiblegincoming_LostFocus(sender As Object, e As EventArgs) Handles txtsaepossiblegincoming.LostFocus

    '    If txtsaepossiblegincoming.Text <> "" Then
    '        If possiblegincoming > 999 Then
    '            txtsaepossiblegincoming.Text = Format((possiblegincoming), "0,00.00")
    '        ElseIf possiblegincoming < 1000 Then
    '            txtsaepossiblegincoming.Text = Format((possiblegincoming), "0.00")
    '        End If
    '    End If

    'End Sub

    'Private Sub txtsaepossiblegincoming_TextChanged(sender As Object, e As EventArgs) Handles txtsaepossiblegincoming.TextChanged

    '    Try
    '        If txtsaepossiblegincoming.Text <> "" Then
    '            possiblegincoming = txtsaepossiblegincoming.Text
    '        End If
    '    Catch ex As Exception
    '        txtsaepossiblegincoming.Text = ""
    '        MessageBox.Show("Possible G-Incomming is invalid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        Exit Sub
    '    End Try

    'End Sub

    Private Sub lvisalesandexpenses_Click(sender As Object, e As EventArgs) Handles lvisalesandexpenses.Click

        Try
            If lvisalesandexpenses.SelectedItems.Count < 2 Then
                dtpsaedate.Text = lvisalesandexpenses.SelectedItems.Item(0).SubItems(0).Text
                txtsaeparticular.Text = lvisalesandexpenses.SelectedItems.Item(0).SubItems(1).Text
                cbosaecodingagent.Text = lvisalesandexpenses.SelectedItems.Item(0).SubItems(2).Text
                txtsaecashpayment.Text = lvisalesandexpenses.SelectedItems.Item(0).SubItems(3).Text
                txtsaecheckpayment.Text = lvisalesandexpenses.SelectedItems.Item(0).SubItems(4).Text
                txtsaetotalsales.Text = lvisalesandexpenses.SelectedItems.Item(0).SubItems(5).Text
                txtsaetotalexpenses.Text = lvisalesandexpenses.SelectedItems.Item(0).SubItems(6).Text
                txtsaenetsales.Text = lvisalesandexpenses.SelectedItems.Item(0).SubItems(7).Text
                txtsaegrosspercent.Text = lvisalesandexpenses.SelectedItems.Item(0).SubItems(8).Text.Replace("%", "")
                txtsaepossiblegincoming.Text = lvisalesandexpenses.SelectedItems.Item(0).SubItems(9).Text
                txtsaeid.Text = lvisalesandexpenses.SelectedItems.Item(0).SubItems(10).Text
            Else
                cleartextboxesinsalesandexpenses()
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cleartextboxesinsalesandexpenses()

        txtsaeid.Text = ""
        dtpsaedate.Value = Now
        txtsaeparticular.Text = ""
        cbosaecodingagent.Text = ""
        txtsaecashpayment.Text = ""
        txtsaecheckpayment.Text = ""
        txtsaetotalsales.Text = ""
        txtsaetotalexpenses.Text = ""
        txtsaenetsales.Text = ""
        txtsaegrosspercent.Text = ""
        txtsaepossiblegincoming.Text = ""

    End Sub

    Private Sub btnsaenew_Click(sender As Object, e As EventArgs) Handles btnsaenew.Click

        If btnsaenew.Text = "New" Then
            btnsaenew.Text = "Add"
            dtpsaedate.Enabled = True
            txtsaeparticular.ReadOnly = False
            cbosaecodingagent.Enabled = True
            txtsaecashpayment.ReadOnly = False
            txtsaecheckpayment.ReadOnly = False
            txtsaetotalexpenses.ReadOnly = False
            txtsaegrosspercent.ReadOnly = False
            btnsaeedit.Enabled = False
            btnsaedelete.Enabled = False
            cleartextboxesinsalesandexpenses()
            lvisalesandexpenses.Enabled = False
            dtpsaedate.Focus()
        ElseIf btnsaenew.Text = "Add" Then

            openconnection()
            salesandexpensesidgenerator()

            Dim cashpayment2, checkpayment2, totalsales2, totalexpenses2, netsales2, possiblegcomming2 As Decimal
            If txtsaecashpayment.Text <> "" Then
                cashpayment2 = txtsaecashpayment.Text
            End If
            If txtsaecheckpayment.Text <> "" Then
                checkpayment2 = txtsaecheckpayment.Text
            End If
            If txtsaetotalsales.Text <> "" Then
                totalsales2 = txtsaetotalsales.Text
            End If
            If txtsaetotalexpenses.Text <> "" Then
                totalexpenses2 = txtsaetotalexpenses.Text
            End If
            If txtsaenetsales.Text <> "" Then
                netsales2 = txtsaenetsales.Text
            End If
            If txtsaepossiblegincoming.Text <> "" Then
                possiblegcomming2 = txtsaepossiblegincoming.Text
            End If
            cmd = New MySqlCommand("INSERT INTO `tbl_sales_and_expenses`(`sales_and_expenses_id`,`date`,`particular`,`cash_payment`,`check_payment`,`total_sales`,`total_expenses`,`net_sales`,`coding_agent`,`gross_percent`,`possible_g-incomming`) VALUES (@salesandexpensesid,@date,@particular,@cashpayment,@checkpayment,@totalsales,@totalexpenses,@netsales,@codingagent,@grosspercent,@possiblegincomming)", con)
            cmd.Parameters.AddWithValue("@salesandexpensesid", salesandexpensesidfinalizedid)
            cmd.Parameters.AddWithValue("@date", dtpsaedate.Text)
            cmd.Parameters.AddWithValue("@particular", txtsaeparticular.Text)
            cmd.Parameters.AddWithValue("@cashpayment", cashpayment2)
            cmd.Parameters.AddWithValue("@checkpayment", checkpayment2)
            cmd.Parameters.AddWithValue("@totalsales", totalsales2)
            cmd.Parameters.AddWithValue("@totalexpenses", totalexpenses2)
            cmd.Parameters.AddWithValue("@netsales", netsales2)
            cmd.Parameters.AddWithValue("@codingagent", cbosaecodingagent.Text)
            cmd.Parameters.AddWithValue("@grosspercent", txtsaegrosspercent.Text)
            cmd.Parameters.AddWithValue("@possiblegincomming", possiblegcomming2)
            cmd.ExecuteNonQuery()

            con.Close()
            cleartextboxesinsalesandexpenses()
            displaysalesandexpenses()
            loadcbosalesandexpensescodingagent()
            'btnsaecancel.PerformClick()
            MessageBox.Show("Data has been added successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            confirm = MessageBox.Show("Do you want to add again?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
            If confirm = vbYes Then
                dtpsaedate.Focus()
            Else
                btnsaecancel.PerformClick()
            End If
        End If

    End Sub

    Private Sub btnsaeedit_Click(sender As Object, e As EventArgs) Handles btnsaeedit.Click

        If accounttype = "admin" Then
            If lvisalesandexpenses.SelectedItems.Count > 0 Then
                If btnsaeedit.Text = "Edit" Then
                    btnsaeedit.Text = "Update"
                    dtpsaedate.Enabled = True
                    txtsaeparticular.ReadOnly = False
                    cbosaecodingagent.Enabled = True
                    txtsaecashpayment.ReadOnly = False
                    txtsaecheckpayment.ReadOnly = False
                    txtsaetotalexpenses.ReadOnly = False
                    txtsaegrosspercent.ReadOnly = False
                    lvisalesandexpenses.Enabled = False
                ElseIf btnsaeedit.Text = "Update" Then

                    openconnection()

                    Dim cashpayment2, checkpayment2, totalsales2, totalexpenses2, netsales2, possiblegcomming2 As Decimal
                    If txtsaecashpayment.Text <> "" Then
                        cashpayment2 = txtsaecashpayment.Text
                    End If
                    If txtsaecheckpayment.Text <> "" Then
                        checkpayment2 = txtsaecheckpayment.Text
                    End If
                    If txtsaetotalsales.Text <> "" Then
                        totalsales2 = txtsaetotalsales.Text
                    End If
                    If txtsaetotalexpenses.Text <> "" Then
                        totalexpenses2 = txtsaetotalexpenses.Text
                    End If
                    If txtsaenetsales.Text <> "" Then
                        netsales2 = txtsaenetsales.Text
                    End If
                    If txtsaepossiblegincoming.Text <> "" Then
                        possiblegcomming2 = txtsaepossiblegincoming.Text
                    End If
                    cmd = New MySqlCommand("UPDATE `tbl_sales_and_expenses` SET `date`= @date ,`particular`= @particular ,`cash_payment`= @cashpayment , `check_payment`= @checkpayment ,`total_sales`= @totalsales , `total_expenses`= @totalexpenses , `net_sales`= @netsales , `coding_agent`= @codingagent , `gross_percent`= @grosspercent , `possible_g-incomming`= @possiblegincomming where sales_and_expenses_id=@salesandexpensesid", con)
                    cmd.Parameters.AddWithValue("@salesandexpensesid", txtsaeid.Text)
                    cmd.Parameters.AddWithValue("@date", dtpsaedate.Text)
                    cmd.Parameters.AddWithValue("@particular", txtsaeparticular.Text)
                    cmd.Parameters.AddWithValue("@cashpayment", cashpayment2)
                    cmd.Parameters.AddWithValue("@checkpayment", checkpayment2)
                    cmd.Parameters.AddWithValue("@totalsales", totalsales2)
                    cmd.Parameters.AddWithValue("@totalexpenses", totalexpenses2)
                    cmd.Parameters.AddWithValue("@netsales", netsales2)
                    cmd.Parameters.AddWithValue("@codingagent", cbosaecodingagent.Text)
                    cmd.Parameters.AddWithValue("@grosspercent", txtsaegrosspercent.Text)
                    cmd.Parameters.AddWithValue("@possiblegincomming", possiblegcomming2)
                    cmd.ExecuteNonQuery()

                    reader.Close()
                    con.Close()
                    loadcbosalesandexpensescodingagent()
                    displaysalesandexpenses()

                    btnsaeedit.Text = "Edit"
                    dtpsaedate.Enabled = False
                    txtsaeparticular.ReadOnly = True
                    cbosaecodingagent.Enabled = False
                    txtsaecashpayment.ReadOnly = True
                    txtsaecheckpayment.ReadOnly = True
                    txtsaetotalexpenses.ReadOnly = True
                    txtsaegrosspercent.ReadOnly = True
                    lvisalesandexpenses.Enabled = True
                    MessageBox.Show("Updated successfully.", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Please select an item to edit.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("You do not have a permission to edit.", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub btnsaedelete_Click(sender As Object, e As EventArgs) Handles btnsaedelete.Click

        If accounttype = "admin" Then
            If lvisalesandexpenses.SelectedItems.Count > 0 Then
                confirm = MessageBox.Show("Are you sure?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If confirm = vbYes Then
                    openconnection()
                    For Each salesandexpenses As ListViewItem In lvisalesandexpenses.Items
                        If lvisalesandexpenses.SelectedItems.Count > 0 Then
                            cmddelete = "DELETE FROM `tbl_sales_and_expenses` where sales_and_expenses_id='" & lvisalesandexpenses.SelectedItems.Item(0).SubItems(9).Text & "'"
                            sqlda = New MySqlDataAdapter(cmddelete, con)
                            ds = New DataSet()
                            sqlda.Fill(ds)
                            con.Close()
                            lvisalesandexpenses.SelectedItems.Item(0).Remove()
                        End If
                    Next
                    computesalesandexpensesgrandtotal()
                    btnsaecancel.PerformClick()
                    loadcbosalesandexpensescodingagent()
                    MessageBox.Show("Deleted successfully.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Please select an item to delete.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("You do not have a permission to delete.", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub btnsaecancel_Click(sender As Object, e As EventArgs) Handles btnsaecancel.Click

        cleartextboxesinsalesandexpenses()
        dtpsaedate.Enabled = False
        txtsaeparticular.ReadOnly = True
        cbosaecodingagent.Enabled = False
        txtsaecashpayment.ReadOnly = True
        txtsaecheckpayment.ReadOnly = True
        txtsaetotalexpenses.ReadOnly = True
        txtsaegrosspercent.ReadOnly = True
        btnsaeedit.Enabled = False
        btnsaedelete.Enabled = False
        lvisalesandexpenses.Enabled = True
        btnsaeedit.Enabled = True
        btnsaedelete.Enabled = True
        btnsaenew.Text = "New"
        btnsaeedit.Text = "Edit"

    End Sub

    Private Sub btnpoexpandshrink_Click(sender As Object, e As EventArgs) Handles btnpoexpandshrink.Click

        'lvipurchaseorder.Items.Clear()
        'displaypruchaseorder()
        'If btnpoexpandshrink.Text = "<" Then
        '    btnpoexpandshrink.Text = ">"
        '    lvipurchaseordercolumns()
        '    lvipurchaseorder.Location = New System.Drawing.Point(3, 39)
        '    lvipurchaseorder.Size = New System.Drawing.Size(1349, 514)
        'ElseIf btnpoexpandshrink.Text = ">" Then
        '    btnpoexpandshrink.Text = "<"
        '    lvipurchaseordercolumns()
        '    lvipurchaseorder.Location = New System.Drawing.Point(358, 39)
        '    lvipurchaseorder.Size = New System.Drawing.Size(994, 514)
        'End If

    End Sub

    Private Sub cboview_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboview.SelectedIndexChanged

    End Sub

    Private Sub cbxpogridlines_CheckedChanged(sender As Object, e As EventArgs) Handles cbxpogridlines.CheckedChanged

        If cbxpogridlines.Checked = True Then
            lvipurchaseorder.GridLines = True
        Else
            lvipurchaseorder.GridLines = False
        End If

    End Sub

    Private Sub cboposearch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboposearch.SelectedIndexChanged

        txtposearch.Text = ""

    End Sub

    Private Sub btnmmsearch_Click(sender As Object, e As EventArgs) Handles btnposearch.Click

        If txtposearch.Text <> "" Then
            displaypruchaseorder()
            If cboposearch.Text = "DR" Then
                For Each purchaseorder As ListViewItem In lvipurchaseorder.Items
                    If Not purchaseorder.SubItems(0).Text.ToLower.Contains(txtposearch.Text.ToLower) Then
                        purchaseorder.Remove()
                    End If
                Next
            ElseIf cboposearch.Text = "Suppliers Name" Then
                For Each purchaseorder As ListViewItem In lvipurchaseorder.Items
                    If Not purchaseorder.SubItems(1).Text.ToLower.Contains(txtposearch.Text.ToLower) Then
                        purchaseorder.Remove()
                    End If
                Next
            ElseIf cboposearch.Text = "Receipt Delivery Date" Then
                For Each purchaseorder As ListViewItem In lvipurchaseorder.Items
                    If Not purchaseorder.SubItems(2).Text.ToLower.Contains(txtposearch.Text.ToLower) Then
                        purchaseorder.Remove()
                    End If
                Next
            ElseIf cboposearch.Text = "Receipt Arrival Date" Then
                For Each purchaseorder As ListViewItem In lvipurchaseorder.Items
                    If Not purchaseorder.SubItems(3).Text.ToLower.Contains(txtposearch.Text.ToLower) Then
                        purchaseorder.Remove()
                    End If
                Next
            ElseIf cboposearch.Text = "Description" Then
                For Each purchaseorder As ListViewItem In lvipurchaseorder.Items
                    If Not purchaseorder.SubItems(4).Text.ToLower.Contains(txtposearch.Text.ToLower) Then
                        purchaseorder.Remove()
                    End If
                Next
            ElseIf cboposearch.Text = "Brand" Then
                For Each purchaseorder As ListViewItem In lvipurchaseorder.Items
                    If Not purchaseorder.SubItems(5).Text.ToLower.Contains(txtposearch.Text.ToLower) Then
                        purchaseorder.Remove()
                    End If
                Next
            ElseIf cboposearch.Text = "Model / Code" Then
                For Each purchaseorder As ListViewItem In lvipurchaseorder.Items
                    If Not purchaseorder.SubItems(6).Text.ToLower.Contains(txtposearch.Text.ToLower) Then
                        purchaseorder.Remove()
                    End If
                Next
            End If
        Else
            displaypruchaseorder()
        End If

    End Sub

    Private Sub txtposearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtposearch.KeyDown

        If e.KeyCode = Keys.Enter Then
            btnposearch.PerformClick()
        End If

    End Sub

    Private Sub txtposearch_TextChanged(sender As Object, e As EventArgs) Handles txtposearch.TextChanged

        If txtposearch.Text = "" Then
            displaypruchaseorder()
        End If

    End Sub

    Private Sub btnporefresh_Click(sender As Object, e As EventArgs) Handles btnporefresh.Click

        currentdate = System.DateTime.Now.ToString("dd-MMM-yy")
        txtposearch.Text = ""
        displaypruchaseorder()

    End Sub

    Private Sub lvipurchaseorder_DoubleClick(sender As Object, e As EventArgs) Handles lvipurchaseorder.DoubleClick

        Try
            pomode = "viewmode"
            frmpurchaseitem.txtpodrno.Text = lvipurchaseorder.SelectedItems.Item(0).SubItems(0).Text
            frmpurchaseitem.cboposuppliersname.Text = lvipurchaseorder.SelectedItems.Item(0).SubItems(1).Text
            frmpurchaseitem.dtpporeceiptdelivery.Value = lvipurchaseorder.SelectedItems.Item(0).SubItems(2).Text
            frmpurchaseitem.dtppoarrivaldate.Value = lvipurchaseorder.SelectedItems.Item(0).SubItems(3).Text
            frmpurchaseitem.txtpodescription.Text = lvipurchaseorder.SelectedItems.Item(0).SubItems(4).Text
            frmpurchaseitem.cbopobrand.Text = lvipurchaseorder.SelectedItems.Item(0).SubItems(5).Text
            frmpurchaseitem.cbopomodel.Text = lvipurchaseorder.SelectedItems.Item(0).SubItems(6).Text
            frmpurchaseitem.txtpoquantity.Text = lvipurchaseorder.SelectedItems.Item(0).SubItems(7).Text
            frmpurchaseitem.cbopounit.Text = lvipurchaseorder.SelectedItems.Item(0).SubItems(8).Text
            frmpurchaseitem.txtpounitcost.Text = lvipurchaseorder.SelectedItems.Item(0).SubItems(9).Text
            frmpurchaseitem.txtpodiscount.Text = lvipurchaseorder.SelectedItems.Item(0).SubItems(10).Text.Replace("%", "")
            frmpurchaseitem.txtponetcost.Text = lvipurchaseorder.SelectedItems.Item(0).SubItems(11).Text
            frmpurchaseitem.txtpototalamount.Text = lvipurchaseorder.SelectedItems.Item(0).SubItems(12).Text
            frmpurchaseitem.txtpomargin.Text = lvipurchaseorder.SelectedItems.Item(0).SubItems(13).Text.Replace("%", "")
            frmpurchaseitem.txtposuggestedprice.Text = lvipurchaseorder.SelectedItems.Item(0).SubItems(14).Text
            frmpurchaseitem.txtpocanvassprice.Text = lvipurchaseorder.SelectedItems.Item(0).SubItems(15).Text
            frmpurchaseitem.txtpoterm.Text = lvipurchaseorder.SelectedItems.Item(0).SubItems(16).Text
            frmpurchaseitem.txtposellingarea.Text = lvipurchaseorder.SelectedItems.Item(0).SubItems(17).Text
            frmpurchaseitem.txtpobodega.Text = lvipurchaseorder.SelectedItems.Item(0).SubItems(18).Text
            frmpurchaseitem.txtposoldout.Text = lvipurchaseorder.SelectedItems.Item(0).SubItems(19).Text
            frmpurchaseitem.txtpoavailable.Text = lvipurchaseorder.SelectedItems.Item(0).SubItems(20).Text
            frmpurchaseitem.txtpordd.Text = lvipurchaseorder.SelectedItems.Item(0).SubItems(21).Text
            frmpurchaseitem.txtpoproductid.Text = lvipurchaseorder.SelectedItems.Item(0).SubItems(22).Text
            frmpurchaseitem.ShowInTaskbar = False
            frmpurchaseitem.ShowDialog()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnponew_Click(sender As Object, e As EventArgs) Handles btnponew.Click

        pomode = "addmode"
        frmpurchaseitems.ShowInTaskbar = False
        frmpurchaseitems.ShowDialog()
        'If btnponew.Text = "New" Then
        '    btnponew.Text = "Add"
        '    txtpodrno.ReadOnly = False
        '    cboposuppliersname.Enabled = True
        '    dtpporeceiptdelivery.Enabled = True
        '    dtppoarrivaldate.Enabled = True
        '    txtpodescription.ReadOnly = False
        '    cbopobrand.Enabled = True
        '    cbopomodel.Enabled = True
        '    txtpoquantity.ReadOnly = False
        '    cbopounit.Enabled = True
        '    txtponetcost.ReadOnly = False
        '    txtpomargin.ReadOnly = False
        '    txtposuggestedprice.ReadOnly = False
        '    txtpocanvassprice.ReadOnly = False
        '    lvipurchaseorder.Enabled = False
        '    txtpodrno.Text = ""
        '    cboposuppliersname.Text = ""
        '    dtpporeceiptdelivery.Value = Now
        '    dtppoarrivaldate.Value = Now
        '    btnpoedit.Enabled = False
        '    btnpodelete.Enabled = False
        '    cleartextboxesinpurchaseorder()
        '    txtpodrno.Focus()
        'ElseIf btnponew.Text = "Add" Then

        '    openconnection()
        '    purchaseitemproductidgenerator()

        '    cmd.CommandText = "Select official_receipt from tbl_purchase_order where official_receipt = '" & txtpodrno.Text & "'"
        '    reader = cmd.ExecuteReader
        '    If reader.HasRows Then
        '        reader.Close()
        '        cmd = New MySqlCommand("UPDATE `tbl_purchase_order` SET `date_of_del_receipt`= '" & dtpporeceiptdelivery.Text & "' , `arrival_date`= '" & dtppoarrivaldate.Text & "' , `supplier`= '" & cboposuppliersname.Text & "' where official_receipt='" & txtpodrno.Text & "'", con)
        '        cmd.ExecuteNonQuery()
        '    Else
        '        reader.Close()
        '        cmd = New MySqlCommand("INSERT INTO `tbl_purchase_order`(`official_receipt`,`date_of_del_receipt`,`arrival_date`,`supplier`) VALUES ('" & txtpodrno.Text & "','" & dtpporeceiptdelivery.Text & "','" & dtppoarrivaldate.Text & "','" & cboposuppliersname.Text & "')", con)
        '        cmd.ExecuteNonQuery()
        '    End If

        '    Dim netcost, totalamount, margin, suggestedprice, canvassprice As Decimal
        '    If txtponetcost.Text <> "" Then
        '        netcost = txtponetcost.Text
        '    End If
        '    If txtpototalamount.Text <> "" Then
        '        totalamount = txtpototalamount.Text
        '    End If
        '    If txtpomargin.Text <> "" Then
        '        margin = txtpomargin.Text
        '    End If
        '    If txtposuggestedprice.Text <> "" Then
        '        suggestedprice = txtposuggestedprice.Text
        '    End If
        '    If txtpocanvassprice.Text <> "" Then
        '        canvassprice = txtpocanvassprice.Text
        '    End If

        '    cmd = New MySqlCommand("INSERT INTO `tbl_purchase_order_items`(`official_receipt`,`product_id`,`description`,`brand`,`model`,`quantity`,`unit`,`net_cost`,`total_amount`,`margin`,`suggested_price`,`canvass_price`) VALUES ('" & txtpodrno.Text & "','" & purchaseoderfinalizeproductid & "','" & txtpodescription.Text & "','" & cbopobrand.Text & "','" & cbopomodel.Text & "','" & txtpoquantity.Text & "','" & cbopounit.Text & "','" & netcost & "','" & totalamount & "','" & margin & "','" & suggestedprice & "','" & canvassprice & "')", con)
        '    cmd.ExecuteNonQuery()

        '    con.Close()
        '    cleartextboxesinpurchaseorder()
        '    displaypruchaseorder()
        '    loadcbopurchaseorderbrand()
        '    loadcbopurchaseordermodel()
        '    loadcbopurchaseorderunit()
        '    'btnslcancel.PerformClick()
        '    MessageBox.Show("Data has been added successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        '    txtpodescription.Focus()
        'End If

    End Sub

    Private Sub btnpoedit_Click(sender As Object, e As EventArgs) Handles btnpoedit.Click

        If accounttype = "admin" Then
            If lvipurchaseorder.SelectedItems.Count > 0 Then
                pomode = "editmode"
                frmpurchaseitem.txtpodrno.Text = lvipurchaseorder.SelectedItems.Item(0).SubItems(0).Text
                frmpurchaseitem.cboposuppliersname.Text = lvipurchaseorder.SelectedItems.Item(0).SubItems(1).Text
                frmpurchaseitem.dtpporeceiptdelivery.Value = lvipurchaseorder.SelectedItems.Item(0).SubItems(2).Text
                frmpurchaseitem.dtppoarrivaldate.Value = lvipurchaseorder.SelectedItems.Item(0).SubItems(3).Text
                frmpurchaseitem.txtpodescription.Text = lvipurchaseorder.SelectedItems.Item(0).SubItems(4).Text
                frmpurchaseitem.cbopobrand.Text = lvipurchaseorder.SelectedItems.Item(0).SubItems(5).Text
                frmpurchaseitem.cbopomodel.Text = lvipurchaseorder.SelectedItems.Item(0).SubItems(6).Text
                frmpurchaseitem.txtpoquantity.Text = lvipurchaseorder.SelectedItems.Item(0).SubItems(7).Text
                frmpurchaseitem.cbopounit.Text = lvipurchaseorder.SelectedItems.Item(0).SubItems(8).Text
                frmpurchaseitem.txtpounitcost.Text = lvipurchaseorder.SelectedItems.Item(0).SubItems(9).Text
                frmpurchaseitem.txtpodiscount.Text = lvipurchaseorder.SelectedItems.Item(0).SubItems(10).Text.Replace("%", "")
                frmpurchaseitem.txtponetcost.Text = lvipurchaseorder.SelectedItems.Item(0).SubItems(11).Text
                frmpurchaseitem.txtpototalamount.Text = lvipurchaseorder.SelectedItems.Item(0).SubItems(12).Text
                frmpurchaseitem.txtpomargin.Text = lvipurchaseorder.SelectedItems.Item(0).SubItems(13).Text.Replace("%", "")
                frmpurchaseitem.txtposuggestedprice.Text = lvipurchaseorder.SelectedItems.Item(0).SubItems(14).Text
                frmpurchaseitem.txtpocanvassprice.Text = lvipurchaseorder.SelectedItems.Item(0).SubItems(15).Text
                frmpurchaseitem.txtpoterm.Text = lvipurchaseorder.SelectedItems.Item(0).SubItems(16).Text
                frmpurchaseitem.txtposellingarea.Text = lvipurchaseorder.SelectedItems.Item(0).SubItems(17).Text
                frmpurchaseitem.txtpobodega.Text = lvipurchaseorder.SelectedItems.Item(0).SubItems(18).Text
                frmpurchaseitem.txtposoldout.Text = lvipurchaseorder.SelectedItems.Item(0).SubItems(19).Text
                frmpurchaseitem.txtpoavailable.Text = lvipurchaseorder.SelectedItems.Item(0).SubItems(20).Text
                frmpurchaseitem.txtpordd.Text = lvipurchaseorder.SelectedItems.Item(0).SubItems(21).Text
                frmpurchaseitem.txtpoproductid.Text = lvipurchaseorder.SelectedItems.Item(0).SubItems(22).Text
                frmpurchaseitem.ShowInTaskbar = False
                frmpurchaseitem.ShowDialog()
            Else
                MessageBox.Show("Please select an item to edit.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("You do not have a permission to edit.", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub btnpodelete_Click(sender As Object, e As EventArgs) Handles btnpodelete.Click

        If accounttype = "admin" Then
            If lvipurchaseorder.SelectedItems.Count > 0 Then
                confirm = MessageBox.Show("Are you sure?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If confirm = vbYes Then
                    openconnection()
                    For Each item As ListViewItem In lvipurchaseorder.Items
                        If lvipurchaseorder.SelectedItems.Count > 0 Then
                            cmddelete = "DELETE FROM `tbl_purchase_order` where product_id='" & lvipurchaseorder.SelectedItems.Item(0).SubItems(22).Text & "'"
                            sqlda = New MySqlDataAdapter(cmddelete, con)
                            ds = New DataSet()
                            sqlda.Fill(ds)
                            lvipurchaseorder.SelectedItems.Item(0).Remove()
                        End If
                    Next

                    con.Close()
                    btnpocancel.PerformClick()
                    MessageBox.Show("Deleted successfully.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Please select an item to delete.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("You do not have a permission to delete.", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub btnpocancel_Click(sender As Object, e As EventArgs) Handles btnpocancel.Click

        'txtpodrno.Text = ""
        'cboposuppliersname.Text = ""
        'dtpporeceiptdelivery.Value = Now
        'dtppoarrivaldate.Value = Now
        'btnponew.Text = "New"
        'txtpodrno.ReadOnly = True
        'cboposuppliersname.Enabled = False
        'dtpporeceiptdelivery.Enabled = False
        'dtppoarrivaldate.Enabled = False
        'dtpporeceiptdelivery.Value = Now
        'dtppoarrivaldate.Value = Now
        'txtpodescription.ReadOnly = True
        'cbopobrand.Enabled = False
        'cbopomodel.Enabled = False
        'txtpoquantity.ReadOnly = True
        'cbopounit.Enabled = False
        'txtponetcost.ReadOnly = True
        'txtpomargin.ReadOnly = True
        'txtposuggestedprice.ReadOnly = True
        'txtpocanvassprice.ReadOnly = True
        'btnpoedit.Enabled = True
        'btnpodelete.Enabled = True
        'btnpoedit.Text = "Edit"
        'cleartextboxesinpurchaseorder()
        'lvipurchaseorder.Enabled = True

    End Sub

    Private Sub btnsceexpandshrink_Click(sender As Object, e As EventArgs) Handles btnsceexpandshrink.Click

        lvisalesandcollectionentry.Items.Clear()
        displaysalesanccollectionentry()
        If btnsceexpandshrink.Text = "<" Then
            btnsceexpandshrink.Text = ">"
            lvisalesandcollectionentrycolumns()
            lvisalesandcollectionentry.Location = New System.Drawing.Point(3, 39)
            lvisalesandcollectionentry.Size = New System.Drawing.Size(1349, 514)
        ElseIf btnsceexpandshrink.Text = ">" Then
            btnsceexpandshrink.Text = "<"
            lvisalesandcollectionentrycolumns()
            lvisalesandcollectionentry.Location = New System.Drawing.Point(358, 39)
            lvisalesandcollectionentry.Size = New System.Drawing.Size(994, 514)
        End If

    End Sub

    Private Sub cbxscegridlines_CheckedChanged(sender As Object, e As EventArgs) Handles cbxscegridlines.CheckedChanged

        If cbxscegridlines.Checked = True Then
            lvisalesandcollectionentry.GridLines = True
        Else
            lvisalesandcollectionentry.GridLines = False
        End If

    End Sub

    Private Sub cboscesearch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboscesearch.SelectedIndexChanged

        txtscesearch.Text = ""

    End Sub

    Private Sub btnscesearch_Click(sender As Object, e As EventArgs) Handles btnscesearch.Click

        If txtscesearch.Text <> "" Then
            displaysalesanccollectionentry()
            If cboscesearch.Text = "Transaction No." Then
                For Each salesandcollectionentry As ListViewItem In lvisalesandcollectionentry.Items
                    If Not salesandcollectionentry.SubItems(1).Text.ToLower.Contains(txtscesearch.Text.ToLower) Then
                        salesandcollectionentry.Remove()
                    End If
                Next
            ElseIf cboscesearch.Text = "Customer" Then
                For Each salesandcollectionentry As ListViewItem In lvisalesandcollectionentry.Items
                    If Not salesandcollectionentry.SubItems(2).Text.ToLower.Contains(txtscesearch.Text.ToLower) Then
                        salesandcollectionentry.Remove()
                    End If
                Next
            ElseIf cboscesearch.Text = "Sales Date" Then
                For Each salesandcollectionentry As ListViewItem In lvisalesandcollectionentry.Items
                    If Not salesandcollectionentry.SubItems(3).Text.ToLower.Contains(txtscesearch.Text.ToLower) Then
                        salesandcollectionentry.Remove()
                    End If
                Next
            ElseIf cboscesearch.Text = "Period" Then
                For Each salesandcollectionentry As ListViewItem In lvisalesandcollectionentry.Items
                    If Not salesandcollectionentry.SubItems(4).Text.ToLower.Contains(txtscesearch.Text.ToLower) Then
                        salesandcollectionentry.Remove()
                    End If
                Next
            End If
        Else
            displaysalesanccollectionentry()
        End If

        computesalesandcollectionentrygrandtotal()

    End Sub

    Private Sub txtscesearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtscesearch.KeyDown

        If e.KeyCode = Keys.Enter Then
            btnscesearch.PerformClick()
        End If

    End Sub

    Private Sub txtscesearch_TextChanged(sender As Object, e As EventArgs) Handles txtscesearch.TextChanged

        If txtscesearch.Text = "" Then
            displaysalesanccollectionentry()
        End If

    End Sub

    Private Sub computesalesandcollectionentrygrandtotal()

        Dim chargeaccount, settlementpayment As Decimal
        For Each salesandcollectionentry As ListViewItem In lvisalesandcollectionentry.Items
            chargeaccount += salesandcollectionentry.SubItems(5).Text
            settlementpayment += salesandcollectionentry.SubItems(6).Text
        Next
        lblscechargeaccount.Text = FormatNumber(chargeaccount)
        lblscesettlementorpayment.Text = FormatNumber(settlementpayment)

    End Sub

    Private Sub btnscerefresh_Click(sender As Object, e As EventArgs) Handles btnscerefresh.Click

        txtscesearch.Text = ""
        currentdate = System.DateTime.Now.ToString("dd-MMM-yy")
        displaysalesanccollectionentry()
        lvisalesandexpensescolumns()
        cleartextboxesinsalesandcollectionentry()

    End Sub

    Private Sub loadbalance()

        reader.Close()
        If cboscecustomer.Text <> "" Then
            openconnection()
            definedcustomercounter += 1
            cmd.CommandText = "Select * from tbl_account_ledger where business_name =@customer" & definedcustomercounter & ""
            cmd.Parameters.AddWithValue("@customer" & definedcustomercounter, cboscecustomer.Text)
            reader = cmd.ExecuteReader
            If reader.HasRows Then
                reader.Read()
                txtscebalance.Text = FormatNumber(reader("balance").ToString)
                txtscechargeaccount.ReadOnly = False
                txtscesettlementorpayment.ReadOnly = False
            Else
                txtscechargeaccount.Text = ""
                txtscesettlementorpayment.Text = ""
                txtscebalance.Text = ""
                txtscechargeaccount.ReadOnly = True
                txtscesettlementorpayment.ReadOnly = True
            End If
        Else
            txtscebalance.Text = ""
        End If
        reader.Close()
        con.Close()

    End Sub

    Private Sub cboscecustomer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboscecustomer.SelectedIndexChanged

        loadbalance()
        txtscechargeaccount.Text = ""
        txtscesettlementorpayment.Text = ""

    End Sub

    Private Sub dtpscesalesdate_ValueChanged(sender As Object, e As EventArgs) Handles dtpscesalesdate.ValueChanged

        dtpsceperiod.Value = dtpscesalesdate.Value
        dtpscesalesdate2.Value = dtpscesalesdate.Value

        getagingindays()

    End Sub

    Private Sub getagingindays()

        Dim date1 As Date
        Dim date2 As Date
        Dim difference As TimeSpan
        date1 = Convert.ToDateTime(dtpscesalesdate.Value)
        date2 = Convert.ToDateTime(dtpscecurrentdate.Value)
        difference = date2.Subtract(date1)
        Dim totaldays As Integer = FormatNumber(difference.TotalDays, 0) + 1
        If totaldays = 1 Then
            txtsceagingindays.Text = totaldays
        ElseIf totaldays > 1 Then
            txtsceagingindays.Text = totaldays
        ElseIf totaldays < 1 Then
            txtsceagingindays.Text = "0"
        End If

    End Sub

    Private Sub txtscechargeaccount_LostFocus(sender As Object, e As EventArgs) Handles txtscechargeaccount.LostFocus

        If txtscechargeaccount.Text <> "" Then
            Dim chargeaccount As Decimal = txtscechargeaccount.Text
            txtscechargeaccount.Text = FormatNumber(chargeaccount)
            scebalancetominus1 = txtscebalance.Text
        End If

    End Sub

    Private Sub getbalancebychargeaccount()

        If cboscecustomer.Text <> "" And txtscebalance.Text <> "" Then
            Try
                If txtscechargeaccount.Text <> "" Then
                    scebalancetominus2 = txtscebalance.Text
                    Dim chargeaccount As Decimal = txtscechargeaccount.Text
                    If txtscesettlementorpayment.Text <> "" Then
                        Dim settlementorpayment As Decimal = txtscesettlementorpayment.Text
                        loadbalance()
                        Dim balance As Decimal = txtscebalance.Text
                        txtscebalance.Text = FormatNumber((chargeaccount + balance) - settlementorpayment)
                    Else
                        loadbalance()
                        Dim balance As Decimal = txtscebalance.Text
                        txtscebalance.Text = FormatNumber(balance + chargeaccount)
                    End If
                Else
                    If txtscesettlementorpayment.Text <> "" Then
                        Dim settlementorpayment As Decimal = txtscesettlementorpayment.Text
                        loadbalance()
                        Dim balance As Decimal = txtscebalance.Text
                        txtscebalance.Text = FormatNumber(balance - settlementorpayment)
                    Else
                        loadbalance()
                    End If
                End If
            Catch ex As Exception
                txtscechargeaccount.Text = ""
                MessageBox.Show("Charge account is invalid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        ElseIf cboscecustomer.Text <> "" And txtscebalance.Text = "" Then
            MessageBox.Show("Customer name cannot be found in the database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub txtscechargeaccount_TextChanged(sender As Object, e As EventArgs) Handles txtscechargeaccount.TextChanged

        getbalancebychargeaccount()

    End Sub

    Private Sub getbalancebysettlementorpayment()

        scebalancetominus2 = txtscebalance.Text
        If cboscecustomer.Text <> "" And txtscebalance.Text <> "" Then
            Try
                If txtscesettlementorpayment.Text <> "" Then
                    scebalancetominus1 = txtscebalance.Text
                    Dim settlementorpayment As Decimal = txtscesettlementorpayment.Text
                    If txtscechargeaccount.Text <> "" Then
                        Dim chargeaccount As Decimal = txtscechargeaccount.Text
                        loadbalance()
                        Dim balance As Decimal = txtscebalance.Text
                        txtscebalance.Text = FormatNumber((chargeaccount + balance) - settlementorpayment)
                    Else
                        loadbalance()
                        Dim balance As Decimal = txtscebalance.Text
                        txtscebalance.Text = FormatNumber(balance - settlementorpayment)
                    End If
                Else
                    If txtscechargeaccount.Text <> "" Then
                        Dim chargeaccount As Decimal = txtscechargeaccount.Text
                        loadbalance()
                        Dim balance As Decimal = txtscebalance.Text
                        txtscebalance.Text = FormatNumber(balance + chargeaccount)
                    Else
                        loadbalance()
                    End If
                End If
            Catch ex As Exception
                txtscesettlementorpayment.Text = ""
                MessageBox.Show("Settlement / Payment is invalid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        ElseIf cboscecustomer.Text <> "" And txtscebalance.Text = "" Then
            MessageBox.Show("Customer name cannot be found in the database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub txtscesettlementorpayment_LostFocus(sender As Object, e As EventArgs) Handles txtscesettlementorpayment.LostFocus

        If txtscesettlementorpayment.Text <> "" Then
            Dim settlementorpayment As Decimal = txtscesettlementorpayment.Text
            txtscesettlementorpayment.Text = FormatNumber(settlementorpayment)
            scebalancetominus2 = txtscebalance.Text
        End If

    End Sub

    Private Sub txtscesettlementorpayment_TextChanged(sender As Object, e As EventArgs) Handles txtscesettlementorpayment.TextChanged

        getbalancebysettlementorpayment()

    End Sub

    Private Sub lvisalesandcollectionentry_Click(sender As Object, e As EventArgs) Handles lvisalesandcollectionentry.Click

        Try
            If lvisalesandcollectionentry.SelectedItems.Count < 2 Then
                txtscetransactionnumber.Text = lvisalesandcollectionentry.SelectedItems.Item(0).SubItems(1).Text
                txtscetransactionnumber2.Text = lvisalesandcollectionentry.SelectedItems.Item(0).SubItems(1).Text
                cboscecustomer.Text = lvisalesandcollectionentry.SelectedItems.Item(0).SubItems(2).Text
                dtpscesalesdate.Value = lvisalesandcollectionentry.SelectedItems.Item(0).SubItems(3).Text
                dtpsceperiod.Value = lvisalesandcollectionentry.SelectedItems.Item(0).SubItems(4).Text
                txtscechargeaccount.Text = lvisalesandcollectionentry.SelectedItems.Item(0).SubItems(5).Text
                txtscesettlementorpayment.Text = lvisalesandcollectionentry.SelectedItems.Item(0).SubItems(6).Text
                txtscebalance.Text = lvisalesandcollectionentry.SelectedItems.Item(0).SubItems(7).Text
                txtsceagingindays.Text = lvisalesandcollectionentry.SelectedItems.Item(0).SubItems(8).Text
            Else
                cleartextboxesinsalesandcollectionentry()
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cleartextboxesinsalesandcollectionentry()

        txtscetransactionnumber.Text = ""
        cboscecustomer.Items.Clear()
        cboscecustomer.Text = ""
        loadcbosalesandcollectionentrycustomer()
        dtpscesalesdate.Value = Now
        dtpsceperiod.Value = Now
        txtscechargeaccount.Text = ""
        txtscesettlementorpayment.Text = ""
        txtscebalance.Text = ""
        txtsceagingindays.Text = ""

    End Sub

    Private Sub btnscenew_Click(sender As Object, e As EventArgs) Handles btnscenew.Click

        If btnscenew.Text = "New" Then
            btnscenew.Text = "Add"
            txtscetransactionnumber.ReadOnly = False
            cboscecustomer.Enabled = True
            dtpscesalesdate.Enabled = True
            lvisalesandcollectionentry.Enabled = False
            btnsceedit.Enabled = False
            btnscedelete.Enabled = False
            cleartextboxesinsalesandcollectionentry()
            getagingindays()
            txtscetransactionnumber.Focus()
        ElseIf btnscenew.Text = "Add" Then

            If cboscecustomer.Text <> "" Then
                openconnection()
                'MsgBox("definecustomer: " & definecustomer)
                definedcustomercounter += 1
                'MsgBox("definecustomercounter: " & definecustomercounter)
                cmd.CommandText = "Select business_name from tbl_account_ledger where business_name = @customer" & definedcustomercounter & ""
                cmd.Parameters.AddWithValue("@customer" & definedcustomercounter & "", cboscecustomer.Text)
                reader = cmd.ExecuteReader
                If reader.HasRows Then
                    reader.Close()
                    cmd.CommandText = "Select transaction_no from tbl_sales_and_collection_entry where transaction_no = '" & txtscetransactionnumber.Text.Replace("'", "") & "'"
                    reader = cmd.ExecuteReader
                    If reader.HasRows Then
                        reader.Close()
                        MessageBox.Show("Transaction Number is already used.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    Else
                        reader.Close()
                        Dim chargeaccount, settlementorpayment, balance As Decimal
                        If txtscechargeaccount.Text <> "" Then
                            chargeaccount = txtscechargeaccount.Text
                        End If
                        If txtscesettlementorpayment.Text <> "" Then
                            settlementorpayment = txtscesettlementorpayment.Text
                        End If
                        If txtscebalance.Text <> "" Then
                            balance = txtscebalance.Text
                        End If
                        cmd = New MySqlCommand("INSERT INTO `tbl_sales_and_collection_entry`(`sales_date_code`,`transaction_no`,`customer`,`sales_date`,`period`,`charge_account`,`settlemen/payment`,`balance`,`aging_in_days`) VALUES (@salesdatecode,@transactionnumber,@customer,@salesdate,@period,@chargeaccount,@settlementpayment,@balance,@agingindays)", con)
                        cmd.Parameters.AddWithValue("@salesdatecode", dtpscesalesdate2.Text)
                        cmd.Parameters.AddWithValue("@transactionnumber", txtscetransactionnumber.Text.Replace("'", ""))
                        cmd.Parameters.AddWithValue("@customer", cboscecustomer.Text)
                        cmd.Parameters.AddWithValue("@salesdate", dtpscesalesdate.Text)
                        cmd.Parameters.AddWithValue("@period", dtpsceperiod.Text)
                        cmd.Parameters.AddWithValue("@chargeaccount", chargeaccount)
                        cmd.Parameters.AddWithValue("@settlementpayment", settlementorpayment)
                        cmd.Parameters.AddWithValue("@balance", balance)
                        cmd.Parameters.AddWithValue("@agingindays", txtsceagingindays.Text)
                        cmd.ExecuteNonQuery()

                        reader.Close()
                        con.Close()
                        displaysalesanccollectionentry()
                        addsalespaymentbalance()
                        addtomonthlymonitoring()
                        cleartextboxesinsalesandcollectionentry()
                        displayaccountledger()
                        displaymonthlymonitoring()
                        cleartextboxesinaccountledger()
                        getagingindays()
                        MessageBox.Show("Data has been added successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        confirm = MessageBox.Show("Do you want to add again?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
                        If confirm = vbYes Then
                            txtscetransactionnumber.Focus()
                        Else
                            btnscecancel.PerformClick()
                        End If
                    End If
                Else
                    reader.Close()
                    MessageBox.Show("Customer name cannot be found in the database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Please select a customer first.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If

    End Sub

    Private Sub addsalespaymentbalance()

        Dim totalsales As Decimal
        Dim payment As Decimal
        If txtscechargeaccount.Text <> "" Then
            totalsales = txtscechargeaccount.Text
        End If
        If txtscesettlementorpayment.Text <> "" Then
            payment = txtscesettlementorpayment.Text
        End If
        Dim currenttotalsales, currentpayment, currentbalance As Decimal

        openconnection()
        cmd.CommandText = "Select * from tbl_account_ledger where business_name = @customera"
        cmd.Parameters.AddWithValue("@customera", cboscecustomer.Text)
        reader = cmd.ExecuteReader
        If reader.HasRows Then
            reader.Read()
            currenttotalsales = reader("total_sales").ToString
            currentpayment = reader("total_payments").ToString
            currentbalance = reader("balance").ToString
        End If
        reader.Close()
        Dim newtotalsales, newpayment, newbalance As Decimal
        newtotalsales = currenttotalsales + totalsales
        newpayment = currentpayment + payment
        newbalance = newtotalsales - newpayment
        'MsgBox("newtotalsales: " & newtotalsales & " and newpayment: " & newpayment & " and newbalance: " & newbalance)
        cmd = New MySqlCommand("UPDATE `tbl_account_ledger` SET `total_sales`= @newtotalsales ,`total_payments`= @newpayment ,`balance`= @newbalance where business_name=@customerb", con)
        cmd.Parameters.AddWithValue("@newtotalsales", newtotalsales)
        cmd.Parameters.AddWithValue("@newpayment", newpayment)
        cmd.Parameters.AddWithValue("@newbalance", newbalance)
        cmd.Parameters.AddWithValue("@customerb", cboscecustomer.Text)
        cmd.ExecuteNonQuery()

        reader.Close()
        con.Close()

    End Sub

    Private Sub addtomonthlymonitoring()

        openconnection()
        Dim chargeaccount, payment, balance As Decimal
        Dim percentratio As String
        If txtscechargeaccount.Text <> "" Then
            chargeaccount = txtscechargeaccount.Text
        End If
        If txtscesettlementorpayment.Text <> "" Then
            payment = txtscesettlementorpayment.Text
        End If
        balance = chargeaccount - payment
        If chargeaccount <> 0 Then
            percentratio = FormatPercent(balance / chargeaccount)
        End If

        cmd.CommandText = "Select * from tbl_monthly_monitoring where month = '" & dtpsceperiod.Text & "'"
        reader = cmd.ExecuteReader
        If reader.HasRows Then
            'MsgBox("naa na ang month")
            reader.Read()
            Dim currentchargeaccount, currentpayment, currentbalance As Decimal
            currentchargeaccount = reader("charge_account").ToString
            currentpayment = reader("payment").ToString
            currentbalance = reader("balance").ToString

            Dim newchargeaccount, newpayment, newbalance As Decimal
            Dim newpercentratio As String
            newchargeaccount = currentchargeaccount + chargeaccount
            newpayment = currentpayment + payment
            newbalance = newchargeaccount - newpayment
            If newchargeaccount <> 0 Then
                newpercentratio = FormatPercent(newbalance / newchargeaccount)
            End If
            reader.Close()
            cmd = New MySqlCommand("UPDATE `tbl_monthly_monitoring` SET `charge_account`= '" & newchargeaccount & "' ,`payment`= '" & newpayment & "' ,`percent_ratio`= '" & newpercentratio & "' ,`balance`= '" & newbalance & "' where month='" & dtpsceperiod.Text & "'", con)
            cmd.ExecuteNonQuery()
        Else
            'MsgBox("wla pa ang month")
            reader.Close()
            cmd = New MySqlCommand("INSERT INTO `tbl_monthly_monitoring`(`month`,`charge_account`,`payment`,`percent_ratio`,`balance`) VALUES ('" & dtpsceperiod.Text & "','" & chargeaccount & "','" & payment & "','" & percentratio & "','" & balance & "')", con)
            cmd.ExecuteNonQuery()
        End If

        reader.Close()
        con.Close()

    End Sub

    Private Sub btnsceedit_Click(sender As Object, e As EventArgs) Handles btnsceedit.Click

        If accounttype = "admin" Then
            If lvisalesandcollectionentry.SelectedItems.Count > 0 Then
                If btnsceedit.Text = "Edit" Then
                    btnsceedit.Text = "Update"
                    txtscetransactionnumber.ReadOnly = False
                    cboscecustomer.Enabled = True
                    dtpscesalesdate.Enabled = True
                    lvisalesandcollectionentry.Enabled = False
                    scecustomername = cboscecustomer.Text
                    scemonth = dtpsceperiod.Text
                    If txtscechargeaccount.Text <> "" Then
                        scetotalsalestodelete = txtscechargeaccount.Text
                    End If
                    If txtscesettlementorpayment.Text <> "" Then
                        scepaymenttodelete = txtscesettlementorpayment.Text
                    End If
                    txtscetransactionnumber.Focus()
                ElseIf btnsceedit.Text = "Update" Then
                    If cboscecustomer.Text <> "" Then
                        openconnection()
                        'MsgBox("definecustomer: " & definecustomer)
                        definedcustomercounter += 1
                        'MsgBox("definecustomercounter: " & definecustomercounter)
                        cmd.CommandText = "Select business_name from tbl_account_ledger where business_name = @customer" & definedcustomercounter & ""
                        cmd.Parameters.AddWithValue("@customer" & definedcustomercounter & "", cboscecustomer.Text)
                        reader = cmd.ExecuteReader
                        If reader.HasRows Then
                            reader.Close()
                            Dim newtotalsales, newpayment, balance As Decimal
                            If txtscechargeaccount.Text <> "" Then
                                newtotalsales = txtscechargeaccount.Text
                            End If
                            If txtscesettlementorpayment.Text <> "" Then
                                newpayment = txtscesettlementorpayment.Text
                            End If
                            If txtscebalance.Text <> "" Then
                                balance = txtscebalance.Text
                            End If
                            If txtscetransactionnumber.Text.Replace("'", "") = txtscetransactionnumber2.Text Then
                                reader.Close()
                                cmd = New MySqlCommand("UPDATE `tbl_sales_and_collection_entry` SET `sales_date_code`= @salesdatecode ,`customer`= @customer ,`period`= @period ,`sales_date`= @salesdate ,`charge_account`= @chargeaccount ,`settlemen/payment`= @settlementpayment ,`balance`= @balance ,`aging_in_days`= @agingindays where transaction_no=@transactionnumber", con)
                                cmd.Parameters.AddWithValue("@salesdatecode", dtpscesalesdate2.Text)
                                cmd.Parameters.AddWithValue("@transactionnumber", txtscetransactionnumber.Text.Replace("'", ""))
                                cmd.Parameters.AddWithValue("@customer", cboscecustomer.Text)
                                cmd.Parameters.AddWithValue("@salesdate", dtpscesalesdate.Text)
                                cmd.Parameters.AddWithValue("@chargeaccount", newtotalsales)
                                cmd.Parameters.AddWithValue("@settlementpayment", newpayment)
                                cmd.Parameters.AddWithValue("@balance", balance)
                                cmd.Parameters.AddWithValue("@period", dtpsceperiod.Text)
                                cmd.Parameters.AddWithValue("@agingindays", txtsceagingindays.Text)
                                cmd.ExecuteNonQuery()
                            Else
                                cmd.CommandText = "Select transaction_no from tbl_sales_and_collection_entry where transaction_no = '" & txtscetransactionnumber.Text.Replace("'", "") & "'"
                                reader = cmd.ExecuteReader
                                If reader.HasRows Then
                                    reader.Close()
                                    MessageBox.Show("Transaction Number is already used.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    Exit Sub
                                Else
                                    reader.Close()
                                    cmd = New MySqlCommand("UPDATE `tbl_sales_and_collection_entry` SET `transaction_no`= @transactionnumber ,`sales_date_code`= @salesdatecode ,`customer`= @customer ,`period`= @period ,`sales_date`= @salesdate ,`charge_account`= @chargeaccount ,`settlemen/payment`= @settlementpayment ,`balance`= @balance ,`aging_in_days`= @agingindays where transaction_no=@transactionnumber2", con)
                                    cmd.Parameters.AddWithValue("@salesdatecode", dtpscesalesdate2.Text)
                                    cmd.Parameters.AddWithValue("@transactionnumber", txtscetransactionnumber.Text.Replace("'", ""))
                                    cmd.Parameters.AddWithValue("@transactionnumber2", txtscetransactionnumber2.Text.Replace("'", ""))
                                    cmd.Parameters.AddWithValue("@customer", cboscecustomer.Text)
                                    cmd.Parameters.AddWithValue("@salesdate", dtpscesalesdate.Text)
                                    cmd.Parameters.AddWithValue("@chargeaccount", newtotalsales)
                                    cmd.Parameters.AddWithValue("@settlementpayment", newpayment)
                                    cmd.Parameters.AddWithValue("@balance", balance)
                                    cmd.Parameters.AddWithValue("@period", dtpsceperiod.Text)
                                    cmd.Parameters.AddWithValue("@agingindays", txtsceagingindays.Text)
                                    cmd.ExecuteNonQuery()
                                End If
                            End If
                            txtscetransactionnumber.ReadOnly = True
                            cboscecustomer.Enabled = False
                            dtpscesalesdate.Enabled = False
                            txtscechargeaccount.ReadOnly = True
                            txtscesettlementorpayment.ReadOnly = True
                            lvisalesandcollectionentry.Enabled = True
                            updatesalespaymentbalance()
                            updatetomonthlymonitoring()
                            reader.Close()
                            con.Close()
                            displaysalesanccollectionentry()
                            displayaccountledger()
                            displaymonthlymonitoring()
                            btnsceedit.Text = "Edit"
                            txtscetransactionnumber.Text = txtscetransactionnumber.Text.Replace("'", "")
                            MessageBox.Show("Updated successfully.", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            reader.Close()
                            MessageBox.Show("Customer name cannot be found in the database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    Else
                        MessageBox.Show("Please select a customer first.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            Else
                MessageBox.Show("Please select an item to edit.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("You do not have a permission to edit.", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub updatesalespaymentbalance()

        Dim totalsales As Decimal
        Dim payment As Decimal
        If txtscechargeaccount.Text <> "" Then
            totalsales = txtscechargeaccount.Text
        End If
        If txtscesettlementorpayment.Text <> "" Then
            payment = txtscesettlementorpayment.Text
        End If

        openconnection()
        cmd.CommandText = "Select * from tbl_account_ledger where business_name = @updatecustomera"
        cmd.Parameters.AddWithValue("@updatecustomera", scecustomername)
        reader = cmd.ExecuteReader
        If reader.HasRows Then
            reader.Read()
            Dim currenttotalsales, currentpayment, currentbalance As Decimal
            currenttotalsales = reader("total_sales").ToString
            currentpayment = reader("total_payments").ToString
            currentbalance = reader("balance").ToString

            reader.Close()
            Dim newtotalsales, newpayment, newbalance As Decimal
            'MsgBox("currenttotalsales: " & currenttotalsales & " - scetotalsalestodelete: " & scetotalsalestodelete & " and currentpayment: " & currentpayment & " - scepaymenttodelete: " & scepaymenttodelete)
            newtotalsales = currenttotalsales - scetotalsalestodelete
            newpayment = currentpayment - scepaymenttodelete
            newbalance = newtotalsales - newpayment
            'MsgBox("newtotalsales: " & newtotalsales & ", newpayment: " & newpayment & ", newbalance: " & newbalance)
            cmd = New MySqlCommand("UPDATE `tbl_account_ledger` SET `total_sales`= @newtotalsales ,`total_payments`= @newpayment ,`balance`= @newbalance where business_name=@updatecustomerb", con)
            cmd.Parameters.AddWithValue("@newtotalsales", newtotalsales)
            cmd.Parameters.AddWithValue("@newpayment", newpayment)
            cmd.Parameters.AddWithValue("@newbalance", newbalance)
            cmd.Parameters.AddWithValue("@updatecustomerb", scecustomername)
            cmd.ExecuteNonQuery()
            reader.Close()

            cmd.CommandText = "Select * from tbl_account_ledger where business_name = @updatecustomerc"
            cmd.Parameters.AddWithValue("@updatecustomerc", scecustomername)
            reader = cmd.ExecuteReader
            If reader.HasRows Then
                reader.Read()
                Dim currenttotalsales2, currentpayment2, currentbalance2 As Decimal
                currenttotalsales2 = reader("total_sales").ToString
                currentpayment2 = reader("total_payments").ToString
                currentbalance2 = reader("balance").ToString

                Dim newtotalsales2, newpayment2, newbalance2 As Decimal
                'MsgBox("newtotalsales: " & newtotalsales & " + totalsales: " & totalsales & " and newpayment: " & newpayment & " + payment: " & payment)
                newtotalsales2 = currenttotalsales2 + totalsales
                newpayment2 = currentpayment2 + payment
                newbalance2 = newtotalsales2 - newpayment2
                'MsgBox("newtotalsales2: " & newtotalsales2 & ", newpayment2: " & newpayment2 & ", newbalance2: " & newbalance2)

                reader.Close()
                cmd = New MySqlCommand("UPDATE `tbl_account_ledger` SET `total_sales`= @newtotalsales2 ,`total_payments`= @newpayment2 ,`balance`= @newbalance2 where business_name=@updatecustomerd", con)
                cmd.Parameters.AddWithValue("@newtotalsales2", newtotalsales2)
                cmd.Parameters.AddWithValue("@newpayment2", newpayment2)
                cmd.Parameters.AddWithValue("@newbalance2", newbalance2)
                cmd.Parameters.AddWithValue("@updatecustomerd", scecustomername)
                cmd.ExecuteNonQuery()
                reader.Close()
            End If
        End If
        con.Close()

    End Sub

    Private Sub updatetomonthlymonitoring()
        'MsgBox("updating nata sa monthly monitoring")
        openconnection()
        Dim chargeaccount, payment, balance As Decimal
        Dim percentratio As String
        If txtscechargeaccount.Text <> "" Then
            chargeaccount = txtscechargeaccount.Text
        End If
        If txtscesettlementorpayment.Text <> "" Then
            payment = txtscesettlementorpayment.Text
        End If
        balance = chargeaccount - payment
        If chargeaccount <> 0 Then
            percentratio = FormatPercent(balance / chargeaccount)
        End If

        cmd.CommandText = "Select * from tbl_monthly_monitoring where month = '" & scemonth & "'"
        reader = cmd.ExecuteReader
        If reader.HasRows Then
            'MsgBox("naa na ang month")
            reader.Read()
            Dim currentchargeaccount, currentpayment As Decimal
            currentchargeaccount = reader("charge_account").ToString
            currentpayment = reader("payment").ToString

            Dim newchargeaccount, newpayment, newbalance As Decimal
            Dim newpercentratio As String
            newchargeaccount = currentchargeaccount - scetotalsalestodelete
            newpayment = currentpayment - scepaymenttodelete
            newbalance = newchargeaccount - newpayment
            If newchargeaccount > 0 Then
                newpercentratio = FormatPercent(newbalance / newchargeaccount)
            End If
            'MsgBox("newchargeaccount: " & newchargeaccount & " and newpayment: " & newpayment & " FOR OLD RECORD OF MM")
            reader.Close()
            If newchargeaccount > 0 Or newpayment > 0 Then
                cmd = New MySqlCommand("UPDATE `tbl_monthly_monitoring` SET `charge_account`= '" & newchargeaccount & "' ,`payment`= '" & newpayment & "' ,`percent_ratio`= '" & newpercentratio & "' ,`balance`= '" & newbalance & "' where month='" & scemonth & "'", con)
                cmd.ExecuteNonQuery()
            ElseIf newchargeaccount = 0 And newpayment = 0 Then
                cmddelete = "DELETE FROM `tbl_monthly_monitoring` where month='" & scemonth & "'"
                sqlda = New MySqlDataAdapter(cmddelete, con)
                ds = New DataSet()
                sqlda.Fill(ds)
            End If
            cmd.CommandText = "Select * from tbl_monthly_monitoring where month = '" & dtpsceperiod.Text & "'"
            reader = cmd.ExecuteReader
            If reader.HasRows Then
                reader.Read()
                'MsgBox("last function: mag update")
                Dim currentchargeaccount2, currentpayment2 As Decimal
                currentchargeaccount2 = reader("charge_account").ToString
                currentpayment2 = reader("payment").ToString

                Dim newchargeaccount2, newpayment2, newbalance2 As Decimal
                Dim newpercentratio2 As String
                newchargeaccount2 = currentchargeaccount2 + chargeaccount
                newpayment2 = currentpayment2 + payment
                newbalance2 = newchargeaccount2 - newpayment2
                If newchargeaccount2 > 0 Then
                    newpercentratio2 = FormatPercent(newbalance2 / newchargeaccount2)
                End If
                'MsgBox("newchargeaccount2: " & newchargeaccount2 & " and newpayment2: " & newpayment2 & " and newbalance2: " & newbalance2 & " and newpercentratio2: " & newpercentratio2 & " FOR THE MONTH OF " & dtpsceperiod.Text)
                reader.Close()
                cmd = New MySqlCommand("UPDATE `tbl_monthly_monitoring` SET `charge_account`= '" & newchargeaccount2 & "' ,`payment`= '" & newpayment2 & "' ,`percent_ratio`= '" & newpercentratio2 & "' ,`balance`= '" & newbalance2 & "' where month='" & dtpsceperiod.Text & "'", con)
                cmd.ExecuteNonQuery()
            Else
                reader.Close()
                'MsgBox("last function: mag add")
                cmd = New MySqlCommand("INSERT INTO `tbl_monthly_monitoring`(`month`,`charge_account`,`payment`,`percent_ratio`,`balance`) VALUES ('" & dtpsceperiod.Text & "','" & chargeaccount & "','" & payment & "','" & percentratio & "','" & balance & "')", con)
                cmd.ExecuteNonQuery()
            End If
        Else
            'MsgBox("wala ang month")
        End If

        reader.Close()
        con.Close()

    End Sub

    Private Sub btnscedelete_Click(sender As Object, e As EventArgs) Handles btnscedelete.Click

        If accounttype = "admin" Then
            If lvisalesandcollectionentry.SelectedItems.Count > 0 Then
                confirm = MessageBox.Show("Are you sure?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If confirm = vbYes Then
                    openconnection()
                    For Each salesandcollectionentry As ListViewItem In lvisalesandcollectionentry.Items
                        If lvisalesandcollectionentry.SelectedItems.Count > 0 Then
                            cmddelete = "DELETE FROM `tbl_sales_and_collection_entry` where transaction_no='" & lvisalesandcollectionentry.SelectedItems.Item(0).SubItems(1).Text & "'"
                            sqlda = New MySqlDataAdapter(cmddelete, con)
                            ds = New DataSet()
                            sqlda.Fill(ds)
                            con.Close()
                            deletesalespaymentbalance()
                            deletetomonhtlymonitoring()
                            lvisalesandcollectionentry.SelectedItems.Item(0).Remove()
                        End If
                    Next
                    computesalesandcollectionentrygrandtotal()
                    displayaccountledger()
                    displaymonthlymonitoring()
                    cleartextboxesinaccountledger()
                    btnscecancel.PerformClick()
                    MessageBox.Show("Deleted successfully.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Please select an item to delete.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("You do not have a permission to delete.", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub deletesalespaymentbalance()

        'MsgBox("deleting nata")
        Dim totalsales As Decimal = lvisalesandcollectionentry.SelectedItems.Item(0).SubItems(5).Text
        Dim payment As Decimal = lvisalesandcollectionentry.SelectedItems.Item(0).SubItems(6).Text
        Dim currenttotalsales, currentpayment, currentbalance As Decimal
        'MsgBox("totalsales: " & totalsales & " and " & "payment: " & payment)
        openconnection()
        cmd.CommandText = "Select * from tbl_account_ledger where business_name = @customera"
        cmd.Parameters.AddWithValue("@customera", lvisalesandcollectionentry.SelectedItems.Item(0).SubItems(2).Text)
        reader = cmd.ExecuteReader
        If reader.HasRows Then
            reader.Read()
            currenttotalsales = reader("total_sales").ToString
            currentpayment = reader("total_payments").ToString
            currentbalance = reader("balance").ToString
        End If
        reader.Close()
        Dim newtotalsales, newpayment, newbalance As Decimal
        newtotalsales = currenttotalsales - lvisalesandcollectionentry.SelectedItems.Item(0).SubItems(5).Text
        newpayment = currentpayment - lvisalesandcollectionentry.SelectedItems.Item(0).SubItems(6).Text
        newbalance = newtotalsales - newpayment
        'MsgBox("newtotalsales: " & newtotalsales & " and " & "newpayment: " & newpayment & " and " & "newbalance: " & newbalance)
        cmd = New MySqlCommand("UPDATE `tbl_account_ledger` SET `total_sales`= '" & newtotalsales & "' ,`total_payments`= '" & newpayment & "' ,`balance`= '" & newbalance & "' where business_name=@customerb", con)
        cmd.Parameters.AddWithValue("@customerb", lvisalesandcollectionentry.SelectedItems.Item(0).SubItems(2).Text)
        cmd.ExecuteNonQuery()
        reader.Close()

    End Sub

    Private Sub deletetomonhtlymonitoring()

        'MsgBox("deleting nata sa monhtly monitoring")
        Dim totalsales As Decimal = lvisalesandcollectionentry.SelectedItems.Item(0).SubItems(5).Text
        Dim payment As Decimal = lvisalesandcollectionentry.SelectedItems.Item(0).SubItems(6).Text
        Dim currentchargeaccount, currentpayment As Decimal
        'MsgBox("totalsales: " & totalsales & " and " & "payment: " & payment)
        openconnection()
        cmd.CommandText = "Select * from tbl_monthly_monitoring where month = '" & lvisalesandcollectionentry.SelectedItems.Item(0).SubItems(4).Text & "'"
        reader = cmd.ExecuteReader
        If reader.HasRows Then
            reader.Read()
            currentchargeaccount = reader("charge_account").ToString
            currentpayment = reader("payment").ToString
        End If
        reader.Close()
        Dim newcharge_account, newpayment, newbalance As Decimal
        Dim newpercentratio As String
        newcharge_account = currentchargeaccount - lvisalesandcollectionentry.SelectedItems.Item(0).SubItems(5).Text
        newpayment = currentpayment - lvisalesandcollectionentry.SelectedItems.Item(0).SubItems(6).Text
        newbalance = newcharge_account - newpayment
        If newcharge_account <> 0 Then
            newpercentratio = FormatPercent(newbalance / newcharge_account)
        End If
        'MsgBox("newcharge_account: " & newcharge_account & " and " & "newpayment: " & newpayment & " and " & "newbalance: " & newbalance & " and newpercentratio: " & newpercentratio & " FOR THE MONTH OF " & lvisalesandcollectionentry.SelectedItems.Item(0).SubItems(4).Text)
        'MsgBox("newcharge_account: " & newcharge_account & " and " & "newpayment: " & newpayment & " FOR THE MONTH OF " & lvisalesandcollectionentry.SelectedItems.Item(0).SubItems(4).Text)
        If newcharge_account > 0 Or newpayment > 0 Then
            'MsgBox("update ra kay wala pay zero")
            cmd = New MySqlCommand("UPDATE `tbl_monthly_monitoring` SET `charge_account`= '" & newcharge_account & "' ,`payment`= '" & newpayment & "' ,`percent_ratio`= '" & newpercentratio & "' ,`balance`= '" & newbalance & "' where month='" & lvisalesandcollectionentry.SelectedItems.Item(0).SubItems(4).Text & "'", con)
            cmd.ExecuteNonQuery()
        ElseIf newcharge_account = 0 And newpayment = 0 Then
            'MsgBox("deleton na kay zero na")
            cmddelete = "DELETE FROM `tbl_monthly_monitoring` where month='" & lvisalesandcollectionentry.SelectedItems.Item(0).SubItems(4).Text & "'"
            sqlda = New MySqlDataAdapter(cmddelete, con)
            ds = New DataSet()
            sqlda.Fill(ds)
        End If
        reader.Close()

    End Sub

    Private Sub btnscecancel_Click(sender As Object, e As EventArgs) Handles btnscecancel.Click

        cleartextboxesinsalesandcollectionentry()
        txtscetransactionnumber.ReadOnly = True
        cboscecustomer.Enabled = False
        dtpscesalesdate.Enabled = False
        txtscechargeaccount.ReadOnly = True
        txtscesettlementorpayment.ReadOnly = True
        txtsceagingindays.ReadOnly = True
        lvisalesandcollectionentry.Enabled = True
        btnscenew.Text = "New"
        btnsceedit.Text = "Edit"
        btnsceedit.Enabled = True
        btnscedelete.Enabled = True

    End Sub

    Private Sub cbxmmgridlines_CheckedChanged(sender As Object, e As EventArgs) Handles cbxmmgridlines.CheckedChanged

        If cbxmmgridlines.Checked = True Then
            lvimonthlymonitoring.GridLines = True
        Else
            lvimonthlymonitoring.GridLines = False
        End If

    End Sub

    Private Sub cbommsearch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbommsearch.SelectedIndexChanged

        txtmmsearch.Text = ""

    End Sub

    Private Sub txtmmsearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtmmsearch.KeyDown

        If e.KeyCode = Keys.Enter Then
            btnmmsearch.PerformClick()
        End If

    End Sub

    Private Sub txtmmsearch_TextChanged(sender As Object, e As EventArgs) Handles txtmmsearch.TextChanged

        If txtmmsearch.Text = "" Then
            displaymonthlymonitoring()
        End If

    End Sub

    Private Sub btnmmsearch_Click_1(sender As Object, e As EventArgs) Handles btnmmsearch.Click

        If txtmmsearch.Text <> "" Then
            displaymonthlymonitoring()
            If cbommsearch.Text = "Month" Then
                For Each monthlymonitoring As ListViewItem In lvimonthlymonitoring.Items
                    If Not monthlymonitoring.SubItems(1).Text.ToLower.Contains(txtmmsearch.Text.ToLower) Then
                        monthlymonitoring.Remove()
                    End If
                Next
            End If
        Else
            displaymonthlymonitoring()
        End If

        computemonthlymonitoringgrandtotal()

    End Sub

    Private Sub computemonthlymonitoringgrandtotal()

        Dim chargeaccount, payment, balance As Decimal
        Dim percentratio As String

        For Each monhtlymonitoring As ListViewItem In lvimonthlymonitoring.Items
            chargeaccount += monhtlymonitoring.SubItems(2).Text
            payment += monhtlymonitoring.SubItems(3).Text
        Next

        lblmmchargeaccount.Text = FormatNumber(chargeaccount)
        lblmmpayment.Text = FormatNumber(payment)
        balance = chargeaccount - payment
        If chargeaccount > 0 Then
            percentratio = balance / chargeaccount
        End If
        lblmmpercentratio.Text = FormatPercent(percentratio)
        lblmmbalance.Text = FormatNumber(balance)

    End Sub

    Private Sub btnmmrefresh_Click(sender As Object, e As EventArgs) Handles btnmmrefresh.Click

        txtmmsearch.Text = ""
        displaymonthlymonitoring()

    End Sub

    Private Sub btnstaffregistration_Click(sender As Object, e As EventArgs) Handles btnstaffregistration.Click

        setaccounttype = "staff"
        frmadminregistration.ShowInTaskbar = False
        frmadminregistration.ShowDialog()

    End Sub

End Class

