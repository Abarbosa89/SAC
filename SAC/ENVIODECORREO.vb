Public Class ENVIODECORREO

    Private Sub CMDENVIAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDENVIAR.Click
        If CORREO = 1 Then

            Dim _Message As New System.Net.Mail.MailMessage()
            Dim _SMTP As New System.Net.Mail.SmtpClient

            'CONFIGURACIÓN DEL STMP
            _SMTP.Credentials = New System.Net.NetworkCredential("sacsistema@hotmail.com", "menovargas45")
            _SMTP.Host = "smtp.live.com"
            _SMTP.Port = 587
            _SMTP.EnableSsl = True

            ' CONFIGURACION DEL MENSAJE
            _Message.[To].Add("aza_link@hotmail.com") 'Cuenta de Correo al que se le quiere enviar el e-mail
            _Message.Bcc.Add("dtvargasr@hotmail.com")
            _Message.From = New System.Net.Mail.MailAddress("sacsistema@hotmail.com", "SISTEMA SAC", System.Text.Encoding.UTF8) 'Quien lo envía
            _Message.Subject = Me.txtasunto.Text.ToString 'Sujeto del e-mail
            _Message.SubjectEncoding = System.Text.Encoding.UTF8 'Codificacion
            _Message.Body = Me.txttexto.Text.ToString & " " & "ENVIADO POR " & Intro.UsuarioLabel1.Text 'contenido del mail
            _Message.BodyEncoding = System.Text.Encoding.UTF8
            _Message.Priority = System.Net.Mail.MailPriority.Normal
            _Message.IsBodyHtml = False

            'ENVIO
            Try
                _SMTP.Send(_Message)
                MessageBox.Show("Mensaje enviado correctamene", "Exito!", MessageBoxButtons.OK)
            Catch ex As System.Net.Mail.SmtpException
                MessageBox.Show(ex.ToString, "Error!", MessageBoxButtons.OK)
            End Try

        ElseIf CORREO = 2 Then

            Dim _Message As New System.Net.Mail.MailMessage()
            Dim _SMTP As New System.Net.Mail.SmtpClient

            'CONFIGURACIÓN DEL STMP
            _SMTP.Credentials = New System.Net.NetworkCredential("sacsistema@hotmail.com", "menovargas45")
            _SMTP.Host = "smtp.live.com"
            _SMTP.Port = 587
            _SMTP.EnableSsl = True

            ' CONFIGURACION DEL MENSAJE
            _Message.[To].Add("dtvargasr@hotmail.com") 'Cuenta de Correo al que se le quiere enviar el e-mail
            _Message.Bcc.Add("aza_link@hotmail.com")
            _Message.From = New System.Net.Mail.MailAddress("sacsistema@hotmail.com", "SISTEMA SAC", System.Text.Encoding.UTF8) 'Quien lo envía
            _Message.Subject = Me.txtasunto.Text.ToString  'Sujeto del e-mail
            _Message.SubjectEncoding = System.Text.Encoding.UTF8 'Codificacion
            _Message.Body = Me.txttexto.Text.ToString & " " & "ENVIADO POR " & Intro.UsuarioLabel1.Text  'contenido del mail
            _Message.BodyEncoding = System.Text.Encoding.UTF8
            _Message.Priority = System.Net.Mail.MailPriority.Normal
            _Message.IsBodyHtml = False

            'ENVIO
            Try
                _SMTP.Send(_Message)
                MessageBox.Show("Mensaje enviado correctamene", "Exito!", MessageBoxButtons.OK)
            Catch ex As System.Net.Mail.SmtpException
                MessageBox.Show(ex.ToString, "Error!", MessageBoxButtons.OK)
            End Try



        End If
    End Sub

    Private Sub CMDCERRAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDCERRAR.Click
        My.Forms.SOPORTE.Close()
        Me.Close()
    End Sub
End Class