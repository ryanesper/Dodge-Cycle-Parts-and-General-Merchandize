Imports MySql.Data.MySqlClient

Public Class frmchangepassword

    Private Sub frmchangepassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtusername.Text = username

    End Sub

    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click

        If txtusername.Text <> "" Then
            If txtcurrentpassword.Text <> "" Then
                Dim converter As New encryptanddecrypt
                Dim decryptedpassword As String = converter.decrypt(password, "Keys")
                If txtcurrentpassword.Text = decryptedpassword Then
                    If txtpassword.Text = txtconfirmpassword.Text Then
                        openconnection()
                        Dim encryptedpassword As String = converter.encrypt(txtconfirmpassword.Text, "Keys")
                        cmd = New MySqlCommand("UPDATE `tbl_admin` SET `username`= @username, `password`=@confirmpassword where id= @id", con)
                        cmd.Parameters.AddWithValue("@username", txtusername.Text)
                        cmd.Parameters.AddWithValue("@confirmpassword", encryptedpassword)
                        cmd.Parameters.AddWithValue("@id", id)
                        cmd.ExecuteNonQuery()

                        reader.Close()
                        con.Close()

                        frmmain.lblme.Text = txtusername.Text
                        username = txtusername.Text
                        password = txtconfirmpassword.Text
                        MessageBox.Show("Changes successfully saved.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtpassword.Text = ""
                        txtconfirmpassword.Text = ""
                        txtcurrentpassword.Text = ""
                        txtusername.Focus()
                    Else
                        MessageBox.Show("Your new password and confirm password does not match!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Else
                    MessageBox.Show("Current password is incorrect!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Current password is empty!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Username is empty!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click

        Me.Close()

    End Sub

    Private Sub txtcurrentpassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcurrentpassword.KeyDown

        If e.KeyCode = Keys.Enter Then
            btnok.PerformClick()
        End If

    End Sub

End Class