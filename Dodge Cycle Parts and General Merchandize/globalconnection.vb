Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text

Module globalconnection

    Public con As New MySqlConnection
    Public cmd As New MySqlCommand
    Public reader As MySqlDataReader
    Public sqlda As New MySqlDataAdapter
    Public ds As New DataSet

    Public pomode As String
    Public currentdate As String
    Public converteddate As String
    Public convertedmonth As String

    Public confirm, cmddelete As String
    Public setaccounttype As String
    Public id, username, password, accounttype As String

    Public Sub openconnection()

        If con.State = ConnectionState.Closed Then
            con.ConnectionString = "Server = " & My.Settings.serversettings & "; User ID = " & My.Settings.usersettings & "; Password = " & My.Settings.passwordsettings & "; Database = " & My.Settings.databasesettings & ";"
            con.Open()
            cmd.Connection = con
        End If

    End Sub

    'Private Sub updatesceagingindays()

    '    openconnection()

    '    cmd = New MySqlCommand("select * from tbl_sales_and_collection_entry", con)
    '    reader = cmd.ExecuteReader
    '    While (reader.Read())


    '        Dim date1 As Date
    '        Dim date2 As Date
    '        Dim difference As TimeSpan
    '        date1 = Convert.ToDateTime(reader("sales_date").ToString)
    '        currentdate = System.DateTime.Now.ToString("dd-MMM-yy")
    '        date2 = Convert.ToDateTime(currentdate)
    '        difference = date2.Subtract(date1)
    '        Dim totaldays As Integer = FormatNumber(difference.TotalDays, 0) + 1
    '    End While
    '    reader.Close()
    '    con.Close()

    'End Sub

    Public Sub displaydodgesales()

        Dim salesvatinclusive, lessvat, netvat, totalamountdue As Decimal
        openconnection()
        frmmain.lvidodgesales.Items.Clear()
        cmd = New MySqlCommand("select * from tbl_bir_sales", con)
        reader = cmd.ExecuteReader
        While (reader.Read())
            Dim ds As New ListViewItem(reader("or_number").ToString())
            ds.SubItems.Add(reader("date").ToString())
            ds.SubItems.Add(reader("m_code").ToString())
            ds.SubItems.Add(reader("customer_name").ToString())
            ds.SubItems.Add(reader("description").ToString())
            ds.SubItems.Add(FormatNumber(reader("sales_vat_inclusive").ToString()))
            salesvatinclusive += reader("sales_vat_inclusive").ToString()
            ds.SubItems.Add(FormatNumber(reader("less_vat").ToString()))
            lessvat += reader("less_vat").ToString()
            ds.SubItems.Add(FormatNumber(reader("net_vat").ToString()))
            netvat += reader("net_vat").ToString()
            ds.SubItems.Add(reader("discount").ToString() & "%")
            ds.SubItems.Add(FormatNumber(reader("amount_due").ToString()))
            ds.SubItems.Add(FormatNumber(reader("addvat").ToString()))
            ds.SubItems.Add(FormatNumber(reader("total_amount_due").ToString()))
            totalamountdue += reader("total_amount_due").ToString()
            frmmain.lvidodgesales.Items.Add(ds)
        End While
        reader.Close()
        con.Close()

        frmmain.lbldssalesvat.Text = FormatNumber(salesvatinclusive)
        frmmain.lbldslessvat.Text = FormatNumber(lessvat)
        frmmain.lbldsnetvat.Text = FormatNumber(netvat)
        frmmain.lbldstotalamountdue.Text = FormatNumber(totalamountdue)

    End Sub

    Public Sub displaysalesanccollectionentry()

        Dim chargeaccount, settlementpayment As Decimal

        openconnection()
        frmmain.lvisalesandcollectionentry.Items.Clear()
        cmd = New MySqlCommand("select * from tbl_sales_and_collection_entry", con)
        reader = cmd.ExecuteReader
        While (reader.Read())
            converteddate = reader("sales_date_code").ToString()
            salesanccollectionentrydatesorter()
            Dim sce As New ListViewItem(converteddate)
            sce.SubItems.Add(reader("transaction_no").ToString())
            sce.SubItems.Add(reader("customer").ToString())
            sce.SubItems.Add(reader("sales_date").ToString())
            sce.SubItems.Add(reader("period").ToString())
            sce.SubItems.Add(FormatNumber(reader("charge_account").ToString()))
            sce.SubItems.Add(FormatNumber(reader("settlemen/payment").ToString()))

            Dim date1 As Date
            Dim date2 As Date
            Dim difference As TimeSpan
            date1 = Convert.ToDateTime(reader("sales_date").ToString)
            date2 = Convert.ToDateTime(currentdate)
            difference = date2.Subtract(date1)
            Dim totaldays As Integer = FormatNumber(difference.TotalDays, 0) + 1
            sce.SubItems.Add(FormatNumber(reader("balance").ToString()))
            sce.SubItems.Add(totaldays)

            frmmain.lvisalesandcollectionentry.Items.Add(sce)
            chargeaccount += reader("charge_account").ToString()
            settlementpayment += reader("settlemen/payment").ToString()
        End While
        reader.Close()
        con.Close()

        frmmain.lblscechargeaccount.Text = FormatNumber(chargeaccount)
        frmmain.lblscesettlementorpayment.Text = FormatNumber(settlementpayment)

    End Sub

    Private Sub salesanccollectionentrydatesorter()



    End Sub

    Public Sub displayaccountledger()

        openconnection()
        frmmain.lviaccountledger.Items.Clear()
        Dim altotalsales As Decimal
        Dim altotalpayments As Decimal
        Dim albalance As Decimal
        cmd = New MySqlCommand("select * from tbl_account_ledger", con)
        reader = cmd.ExecuteReader
        While (reader.Read())
            Dim al As New ListViewItem(reader("business_name").ToString())
            al.SubItems.Add(reader("registered_owner").ToString())
            al.SubItems.Add(reader("address").ToString())
            al.SubItems.Add(reader("contact_number").ToString())
            al.SubItems.Add(reader("local_code").ToString())
            al.SubItems.Add(reader("term").ToString())
            Dim totalsales As Decimal = reader("total_sales").ToString()
            If totalsales > 999 Then
                al.SubItems.Add(Format((totalsales), "0,00.00"))
            ElseIf totalsales < 1000 Then
                al.SubItems.Add(Format((totalsales), "0.00"))
            End If
            altotalsales += reader("total_sales").ToString()
            Dim totalpayments As Decimal = reader("total_payments").ToString()
            If totalpayments > 999 Then
                al.SubItems.Add(Format((totalpayments), "0,00.00"))
            ElseIf totalpayments < 1000 Then
                al.SubItems.Add(Format((totalpayments), "0.00"))
            End If
            altotalpayments += reader("total_payments").ToString()
            Dim balance As Decimal = reader("balance").ToString()
            If balance > 999 Then
                al.SubItems.Add(Format((balance), "0,00.00"))
            ElseIf balance < 1000 Then
                al.SubItems.Add(Format((balance), "0.00"))
            End If
            albalance += reader("balance").ToString()
            al.SubItems.Add(reader("remarks").ToString())
            al.SubItems.Add(reader("due_account_to_date").ToString())
            al.SubItems.Add(reader("account_id").ToString())
            frmmain.lviaccountledger.Items.Add(al)
        End While
        reader.Close()
        con.Close()

        If altotalsales > 999 Then
            frmmain.lblaltotalsales.Text = Format((altotalsales), "0,00.00")
        ElseIf altotalsales < 1000 Then
            frmmain.lblaltotalsales.Text = Format((altotalsales), "0.00")
        End If
        If altotalpayments > 999 Then
            frmmain.lblaltotalpayments.Text = Format((altotalpayments), "0,00.00")
        ElseIf altotalpayments < 1000 Then
            frmmain.lblaltotalpayments.Text = Format((altotalpayments), "0.00")
        End If
        If albalance > 999 Then
            frmmain.lblalbalance.Text = Format((albalance), "0,00.00")
        ElseIf albalance < 1000 Then
            frmmain.lblalbalance.Text = Format((albalance), "0.00")
        End If

    End Sub

    Public Sub displaysupplierlist()

        openconnection()
        frmmain.lvisupplierlist.Items.Clear()
        cmd = New MySqlCommand("select * from tbl_supplier_list", con)
        reader = cmd.ExecuteReader
        While (reader.Read())
            Dim sl As New ListViewItem(reader("supplier_name").ToString())
            sl.SubItems.Add(reader("contact_person").ToString())
            sl.SubItems.Add(reader("address").ToString())
            sl.SubItems.Add(reader("contact_number").ToString())
            sl.SubItems.Add(reader("email_address").ToString())
            sl.SubItems.Add(reader("term").ToString())
            sl.SubItems.Add(reader("tin_number").ToString())
            sl.SubItems.Add(reader("supplier_id").ToString())
            frmmain.lvisupplierlist.Items.Add(sl)
        End While
        reader.Close()
        con.Close()

    End Sub

    Public Sub displaypruchaseorder()

        openconnection()
        frmmain.lvipurchaseorder.Items.Clear()
        cmd = New MySqlCommand("select * from tbl_purchase_order ", con)
        reader = cmd.ExecuteReader
        While (reader.Read())
            Dim po As New ListViewItem(reader("dr").ToString())
            po.SubItems.Add(reader("supplier").ToString())
            po.SubItems.Add(reader("receipt_delivery_date").ToString())
            po.SubItems.Add(reader("arrival_date").ToString())
            po.SubItems.Add(reader("description").ToString())
            po.SubItems.Add(reader("brand").ToString())
            po.SubItems.Add(reader("model").ToString())
            po.SubItems.Add(reader("quantity").ToString())
            po.SubItems.Add(reader("unit").ToString())
            po.SubItems.Add(FormatNumber(reader("unit_cost").ToString()))
            po.SubItems.Add(reader("discount").ToString())
            po.SubItems.Add(FormatNumber(reader("net_cost").ToString()))
            po.SubItems.Add(FormatNumber(reader("total_amount").ToString()))
            po.SubItems.Add(reader("margin").ToString())
            po.SubItems.Add(FormatNumber(reader("suggested_price").ToString()))
            po.SubItems.Add(FormatNumber(reader("canvass_price").ToString()))

            Dim date1 As Date
            Dim date2 As Date
            Dim difference As TimeSpan
            date1 = Convert.ToDateTime(reader("arrival_date").ToString())
            date2 = Convert.ToDateTime(currentdate)
            difference = date2.Subtract(date1)
            Dim totaldays As Decimal = FormatNumber(difference.TotalDays / 30)
            po.SubItems.Add(totaldays)

            po.SubItems.Add(reader("selling_area").ToString())
            po.SubItems.Add(reader("bodega").ToString())
            po.SubItems.Add(reader("sold_out").ToString())
            po.SubItems.Add(reader("available").ToString())
            po.SubItems.Add(reader("remark_days_def").ToString())
            po.SubItems.Add(reader("product_id").ToString())
            frmmain.lvipurchaseorder.Items.Add(po)
        End While
        reader.Close()
        con.Close()

    End Sub

    Public Sub displaysalesandexpenses()

        Dim cashpayment, checkpayment, totalsales, totalexpenses, netsales, possiblegincomming As Decimal
        openconnection()
        frmmain.lvisalesandexpenses.Items.Clear()
        cmd = New MySqlCommand("select * from tbl_sales_and_expenses", con)
        reader = cmd.ExecuteReader
        While (reader.Read())
            Dim sae As New ListViewItem(reader("date").ToString())
            sae.SubItems.Add(reader("particular").ToString())
            sae.SubItems.Add(reader("coding_agent").ToString())
            sae.SubItems.Add(FormatNumber(reader("cash_payment").ToString()))
            sae.SubItems.Add(FormatNumber(reader("check_payment").ToString()))
            sae.SubItems.Add(FormatNumber(reader("total_sales").ToString()))
            sae.SubItems.Add(FormatNumber(reader("total_expenses").ToString()))
            sae.SubItems.Add(FormatNumber(reader("net_sales").ToString()))
            sae.SubItems.Add(reader("gross_percent").ToString() & "%")
            sae.SubItems.Add(FormatNumber(reader("possible_g-incomming").ToString()))
            sae.SubItems.Add(reader("sales_and_expenses_id").ToString())
            cashpayment += reader("cash_payment").ToString()
            checkpayment += reader("check_payment").ToString()
            totalsales += reader("total_sales").ToString()
            totalexpenses += reader("total_expenses").ToString()
            netsales += reader("net_sales").ToString()
            possiblegincomming += reader("possible_g-incomming").ToString()
            frmmain.lvisalesandexpenses.Items.Add(sae)
        End While
        reader.Close()
        con.Close()

        frmmain.lblsaecashpayment.Text = FormatNumber(cashpayment)
        frmmain.lblsaecheckpayment.Text = FormatNumber(checkpayment)
        frmmain.lblsaetotalsales.Text = FormatNumber(totalsales)
        frmmain.lblsaetotalexpenses.Text = FormatNumber(totalexpenses)
        frmmain.lblsaenetsales.Text = FormatNumber(netsales)
        frmmain.lblsaepossiblegincoming.Text = FormatNumber(possiblegincomming)

    End Sub

    Public Sub displaymonthlymonitoring()

        Dim chargeaccount, payment, balance As Decimal
        Dim percentratio As String

        openconnection()
        frmmain.lvimonthlymonitoring.Items.Clear()
        cmd = New MySqlCommand("select * from tbl_monthly_monitoring", con)
        reader = cmd.ExecuteReader
        While (reader.Read())
            convertedmonth = reader("month").ToString()
            monthlymonitoringmonthsorter()
            Dim mm As New ListViewItem(convertedmonth)
            mm.SubItems.Add(reader("month").ToString())
            mm.SubItems.Add(FormatNumber(reader("charge_account").ToString()))
            mm.SubItems.Add(FormatNumber(reader("payment").ToString()))
            mm.SubItems.Add(reader("percent_ratio").ToString())
            If reader("balance").ToString().Contains("-") Then
                Dim formatingbalance As String = FormatNumber((reader("balance").ToString()))
                mm.SubItems.Add(formatingbalance.Replace("-", "(") & ")")
            Else
                mm.SubItems.Add(FormatNumber((reader("balance").ToString())))
            End If
            frmmain.lvimonthlymonitoring.Items.Add(mm)

            chargeaccount += reader("charge_account").ToString()
            payment += reader("payment").ToString()
        End While
        reader.Close()
        con.Close()

        frmmain.lblmmchargeaccount.Text = FormatNumber(chargeaccount)
        frmmain.lblmmpayment.Text = FormatNumber(payment)
        balance = chargeaccount - payment
        If chargeaccount > 0 Then
            percentratio = balance / chargeaccount
        End If
        frmmain.lblmmpercentratio.Text = FormatPercent(percentratio)
        frmmain.lblmmbalance.Text = FormatNumber(balance)

    End Sub

    Private Sub monthlymonitoringmonthsorter()

        If convertedmonth.Contains("Jan") Then
            convertedmonth = convertedmonth.Replace("Jan ", "")
            monthlymonitoringmonthconvertor()
            convertedmonth = convertedmonth & "a"
        ElseIf convertedmonth.Contains("Feb") Then
            convertedmonth = convertedmonth.Replace("Feb ", "")
            monthlymonitoringmonthconvertor()
            convertedmonth = convertedmonth & "b"
        ElseIf convertedmonth.Contains("Mar") Then
            convertedmonth = convertedmonth.Replace("Mar ", "")
            monthlymonitoringmonthconvertor()
            convertedmonth = convertedmonth & "c"
        ElseIf convertedmonth.Contains("Apr") Then
            convertedmonth = convertedmonth.Replace("Apr ", "")
            monthlymonitoringmonthconvertor()
            convertedmonth = convertedmonth & "d"
        ElseIf convertedmonth.Contains("May") Then
            convertedmonth = convertedmonth.Replace("May ", "")
            monthlymonitoringmonthconvertor()
            convertedmonth = convertedmonth & "e"
        ElseIf convertedmonth.Contains("Jun") Then
            convertedmonth = convertedmonth.Replace("Jun ", "")
            monthlymonitoringmonthconvertor()
            convertedmonth = convertedmonth & "f"
        ElseIf convertedmonth.Contains("Jul") Then
            convertedmonth = convertedmonth.Replace("Jul ", "")
            monthlymonitoringmonthconvertor()
            convertedmonth = convertedmonth & "g"
        ElseIf convertedmonth.Contains("Aug") Then
            convertedmonth = convertedmonth.Replace("Aug ", "")
            monthlymonitoringmonthconvertor()
            convertedmonth = convertedmonth & "h"
        ElseIf convertedmonth.Contains("Sep") Then
            convertedmonth = convertedmonth.Replace("Sep", "")
            monthlymonitoringmonthconvertor()
            convertedmonth = convertedmonth & "i"
        ElseIf convertedmonth.Contains("Oct") Then
            convertedmonth = convertedmonth.Replace("Oct ", "")
            monthlymonitoringmonthconvertor()
            convertedmonth = convertedmonth & "j"
        ElseIf convertedmonth.Contains("Nov") Then
            convertedmonth = convertedmonth.Replace("Nov ", "")
            monthlymonitoringmonthconvertor()
            convertedmonth = convertedmonth & "k"
        ElseIf convertedmonth.Contains("Dec") Then
            convertedmonth = convertedmonth.Replace("Dec ", "")
            monthlymonitoringmonthconvertor()
            convertedmonth = convertedmonth & "l"
        End If

    End Sub

    Private Sub monthlymonitoringmonthconvertor()

        convertedmonth = convertedmonth.Replace("0", "a")
        convertedmonth = convertedmonth.Replace("1", "b")
        convertedmonth = convertedmonth.Replace("2", "c")
        convertedmonth = convertedmonth.Replace("3", "d")
        convertedmonth = convertedmonth.Replace("4", "e")
        convertedmonth = convertedmonth.Replace("5", "f")
        convertedmonth = convertedmonth.Replace("6", "g")
        convertedmonth = convertedmonth.Replace("7", "h")
        convertedmonth = convertedmonth.Replace("8", "i")
        convertedmonth = convertedmonth.Replace("9", "j")

    End Sub

    Public Class encryptanddecrypt

        Dim DES As New TripleDESCryptoServiceProvider
        Dim MDS As New MD5CryptoServiceProvider

        Function MDShash(value As String) As Byte()

            Return MDS.ComputeHash(ASCIIEncoding.ASCII.GetBytes(value))

        End Function

        Function encrypt(stringinput As String, key As String) As String

            DES.Key = MDShash(key)
            DES.Mode = CipherMode.ECB

            Dim buffer As Byte() = ASCIIEncoding.ASCII.GetBytes(stringinput)

            Return Convert.ToBase64String(DES.CreateEncryptor().TransformFinalBlock(buffer, 0, buffer.Length))

        End Function

        Function decrypt(encryptedstring As String, key As String) As String

            DES.Key = MDShash(key)
            DES.Mode = CipherMode.ECB
            Dim buffer As Byte() = Convert.FromBase64String(encryptedstring)

            Return ASCIIEncoding.ASCII.GetString(DES.CreateDecryptor().TransformFinalBlock(buffer, 0, buffer.Length))

        End Function

    End Class

End Module

