Imports MySql.Data.MySqlClient

Public Class frmadminregistration

    Dim finalizedaccountid As String

    Public Sub accoutidgenerator()

        openconnection()
        Dim idinitial As String = "PRF"
        Dim counter As Integer = 1
        Dim idnumber As String = "00"
        finalizedaccountid = idinitial & idnumber & counter.ToString
        Dim isidexists As Boolean = True

        cmd.CommandText = "select id from tbl_admin where id = '" & finalizedaccountid & "'"
        reader = cmd.ExecuteReader
        If reader.HasRows = False Then
            reader.Close()
            finalizedaccountid = idinitial & idnumber & counter.ToString
        Else
            Do Until isidexists = False
                reader.Close()
                counter += 1
                If counter > 9 And counter < 100 Then
                    idnumber = "0"
                ElseIf counter > 99 Then
                    idnumber = ""
                End If
                finalizedaccountid = idinitial & idnumber & counter.ToString
                cmd.CommandText = "select id from tbl_admin where id = '" & finalizedaccountid & "'"
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

    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click

        If txtusername.Text = "" And txtpassword.Text <> "" Then
            MessageBox.Show("Username is empty!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtusername.Focus()
        ElseIf txtpassword.Text = "" And txtusername.Text <> "" Then
            MessageBox.Show("Password is empty!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtpassword.Focus()
        ElseIf txtpassword.Text = "" And txtusername.Text = "" Then
            MessageBox.Show("Fields are empty!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtusername.Focus()
        Else
            openconnection()
            Dim converter As New encryptanddecrypt
            Dim encryptedpassword As String = converter.encrypt(txtpassword.Text, "Keys")
            accoutidgenerator()
            If setaccounttype = "admin" Then
                cmd = New MySqlCommand("INSERT INTO `tbl_admin`(`id`,`username`, `password`, `account_type`) VALUES ('" & finalizedaccountid & "','" & txtusername.Text & "','" & encryptedpassword & "','" & "admin" & "')", con)
                cmd.ExecuteNonQuery()
                MessageBox.Show("You have successfully created an Account.", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information)
                con.Close()
                frmlogin.Show()
            ElseIf setaccounttype = "staff" Then
                cmd = New MySqlCommand("INSERT INTO `tbl_admin`(`id`,`username`, `password`, `account_type`) VALUES ('" & finalizedaccountid & "','" & txtusername.Text & "','" & encryptedpassword & "','" & "staff" & "')", con)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Account has been successfully created.", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information)
                con.Close()
            End If


            Me.Close()
        End If

    End Sub

    Private Sub txtpassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpassword.KeyDown

        If e.KeyCode = Keys.Enter Then
            btnok.PerformClick()
        End If

    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click

        Me.Close()

    End Sub
End Class