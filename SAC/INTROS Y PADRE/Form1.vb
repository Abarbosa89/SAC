﻿Imports System.Data.SqlClient
Imports System.Data
Public Class Intro

    Private Sub Intro_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        End
    End Sub

    Private Sub Intro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try  'TODO: This line of code loads data into the 'SACDataSet.USUARIOSACTIVOS' table. You can move, or remove it, as needed.
            Me.USUARIOSACTIVOSTableAdapter.Fill(Me.SACDataSet.USUARIOSACTIVOS)

            'FileCopy("\\192.168.1.66\Buffer\SACBuffer.mdb", "C:\Buffer\SACBuffer.mdb")

            'Conexiones de Base de Datos
            ConectaBD()
            ConectaBDBuffer()
            '--------------------------


            'IdRangoLabel1.Hide()
            'PassLabel1.Hide()
            'PassperdiCheckBox.Hide()
            'NomcomLabel1.Hide()
            'UsuarioLabel1.Hide()
            'IdusLabel1.Hide()


            Me.Text = ": : : : SAC Versión  " & My.Application.Info.Version.ToString & " : : : :"
        Catch
            con.Close()
        End Try

    End Sub


    Private Sub CBOUSUARIO_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBOUSUARIO.SelectedIndexChanged
        Try
            Me.SELECCIONARUSUARIOTableAdapter.Fill(Me.SACDataSet.SELECCIONARUSUARIO, CBOUSUARIO.Text)
            If PassperdiCheckBox.Checked = True Then
                INPUTBOXX.Show()

            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub CMDENTRAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDENTRAR.Click
        If CBOUSUARIO.Text = UsuarioLabel1.Text And TXTPASS.Text = PassLabel1.Text Then
            Dim com As SqlCommand = con.CreateCommand()
            con.Open()
            com = New SqlCommand("INSERTARFECHASERVIDOR", con)
            com.CommandType = CommandType.StoredProcedure
            com.ExecuteNonQuery()
            con.Close()
            MsgBox("BIENVENIDO " & NomcomLabel1.Text, MsgBoxStyle.OkOnly, "BIENVENIDO")
            Me.Hide()
            PADRE.Show()
        Else
            MsgBox("Contraseña o Usuario incorrectos", MsgBoxStyle.Exclamation, "ERROR")
            TXTPASS.Text = ""
            TXTPASS.Focus()
        End If
    End Sub

    Private Sub CMDSALIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDSALIR.Click
        End
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Readme.ShowDialog()
    End Sub
End Class
