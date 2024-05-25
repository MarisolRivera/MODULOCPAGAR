Imports Oracle.ManagedDataAccess.Client

Public Class CONSULTAR
    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnTransmitir.Click
        Using conn As New OracleConnection(My.Settings.conexion)
            Try
                conn.Open()

                ' Consulta y comando para insertar datos en la tabla Acreedores
                Dim consultaAcreedores As String = "INSERT INTO Acreedores (ID, Nombre, Direccion, Correo, Telefono) VALUES (:id, :nombre, :direccion, :correo, :telefono)"
                Dim commandAcreedores As New OracleCommand(consultaAcreedores, conn)
                commandAcreedores.Parameters.Add(":id", OracleDbType.Int32).Value = TextBox5.Text
                commandAcreedores.Parameters.Add(":nombre", OracleDbType.Varchar2).Value = txtNombre.Text
                commandAcreedores.Parameters.Add(":direccion", OracleDbType.Varchar2).Value = txtDireccion.Text
                commandAcreedores.Parameters.Add(":correo", OracleDbType.Varchar2).Value = txtcorreo.Text
                commandAcreedores.Parameters.Add(":telefono", OracleDbType.Varchar2).Value = txtTelefono.Text

                If commandAcreedores.ExecuteNonQuery() > 0 Then
                    ' Consulta y comando para insertar datos en la tabla CPagar
                    Dim consultaCPagar As String = "INSERT INTO CPagar (ID, NoFactura, Fecha, TotalDeuda, Descripcion) VALUES (:id, :noFactura, :fecha, :totalDeuda, :descripcion)"
                    Dim commandCPagar As New OracleCommand(consultaCPagar, conn)
                    commandCPagar.Parameters.Add(":id", OracleDbType.Int32).Value = TxtIDdos.Text
                    commandCPagar.Parameters.Add(":noFactura", OracleDbType.Varchar2).Value = txtNoFactura.Text
                    commandCPagar.Parameters.Add(":fecha", OracleDbType.Date).Value = Convert.ToDateTime(txtFecha.Text)
                    commandCPagar.Parameters.Add(":totalDeuda", OracleDbType.Decimal).Value = Convert.ToDecimal(txtTotalDeuda.Text)
                    commandCPagar.Parameters.Add(":descripcion", OracleDbType.Varchar2).Value = txtDescripcion.Text
                    MessageBox.Show("ESTAS SEGURO QUE DESEA AGREGAR ESTA CUENTA.")

                    If commandCPagar.ExecuteNonQuery() > 0 Then
                        MessageBox.Show("Datos guardados correctamente.")
                        btnTransmitir.Enabled = False
                        '   txtConsecutivo.Enabled = False
                        '  txtApertura.Enabled = False
                        txtNombre.Enabled = False
                    Else
                        MessageBox.Show("Error al guardar los datos en la tabla CPagar.")
                    End If
                Else
                    MessageBox.Show("Error al guardar los datos en la tabla Acreedores.")
                End If
            Catch ex As Exception
                MessageBox.Show("Error al conectar a la base de datos: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles txtTotalDeuda.TextChanged
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

        TextBox5.Clear()
        txtNombre.Clear()
        txtDireccion.Clear()
        txtcorreo.Clear()
        txtTelefono.Clear()
        TxtIDdos.Clear()
        txtNoFactura.Clear()
        txtFecha.Clear()
        txtTotalDeuda.Clear()
        txtDescripcion.Clear()


    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Ingresar solo datos numericos")
        End If
    End Sub

    Private Sub TxtIDdos_TextChanged(sender As Object, e As EventArgs) Handles TxtIDdos.TextChanged

    End Sub

    Private Sub TxtIDdos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtIDdos.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Ingresar solo datos numericos")
        End If
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
