﻿Imports MySql.Data.MySqlClient

Public Class frmlogin

    Private Sub frmlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        currentdate = System.DateTime.Now.ToString("dd-MMM-yy")
        Try
            openconnection()
            cmd = New MySqlCommand("SELECT COUNT(username) as idcount from tbl_admin", con)
            reader = cmd.ExecuteReader
            While (reader.Read())
                If reader("idcount") = 0 Then
                    MessageBox.Show("No account existed yet, want to create?", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    setaccounttype = "admin"
                    frmadminregistration.Show()
                    Me.Close()
                End If
            End While
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Cannot connect to the database!", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            frmdatabaseconnector.Show()
            Me.Close()
        End Try

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

            cmd.CommandText = "Select * from tbl_admin where username = '" & txtusername.Text & "' and password = '" & encryptedpassword & "'"
            reader = cmd.ExecuteReader
            If reader.HasRows Then
                reader.Read()

                id = reader("id").ToString
                username = reader("username").ToString
                password = reader("password").ToString
                accounttype = reader("account_type").ToString

                reader.Close()
                frmmain.Show()
                con.Close()
                Me.Close()
            Else
                MessageBox.Show("Account doesn't exist!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                reader.Close()
                txtusername.Text = ""
                txtpassword.Text = ""
                txtusername.Focus()
            End If
        End If

    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click

        Me.Close()

    End Sub

    Private Sub txtpassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpassword.KeyDown

        If e.KeyCode = Keys.Enter Then
            btnok.PerformClick()
        End If

    End Sub
End Class