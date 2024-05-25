Imports Oracle.ManagedDataAccess.Client

Public Class TRANSACCIONES
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        textBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using conn As New OracleConnection(My.Settings.conexion)
            Try
                conn.Open()

                ' Consulta y comando para insertar datos en la tabla Acreedores
                Dim consultaLTB_TRANSACCIONESCONTABLESUNO As String = "INSERT INTO LTB_TRANSACCIONESCONTABLESUNO (ID, fecha, no_cuenta_debito, nombre, no_cuenta_acreditar, nombre_acreedor, moneda, descripcion, No_transaccion) VALUES (:id, :fecha, :no_cuenta_debito, :nombre, :no_cuenta_acreditar, :nombre_acreedor, :moneda, :descripcion, :no_transaccion)"
                Dim LTB_TRANSACCIONESCONTABLESUNO As New OracleCommand(consultaLTB_TRANSACCIONESCONTABLESUNO, conn)
                LTB_TRANSACCIONESCONTABLESUNO.Parameters.Add(":id", OracleDbType.Int32).Value = TextBox1.Text
                LTB_TRANSACCIONESCONTABLESUNO.Parameters.Add(":fecha", OracleDbType.Varchar2).Value = TextBox2.Text
                LTB_TRANSACCIONESCONTABLESUNO.Parameters.Add(":no_cuenta_debito", OracleDbType.Varchar2).Value = TextBox3.Text
                LTB_TRANSACCIONESCONTABLESUNO.Parameters.Add(":nombre", OracleDbType.Varchar2).Value = TextBox4.Text
                LTB_TRANSACCIONESCONTABLESUNO.Parameters.Add(":no_cuenta_acreditar", OracleDbType.Varchar2).Value = textBox5.Text
                LTB_TRANSACCIONESCONTABLESUNO.Parameters.Add(":nombre_acreedor", OracleDbType.Varchar2).Value = TextBox6.Text
                LTB_TRANSACCIONESCONTABLESUNO.Parameters.Add(":moneda", OracleDbType.Varchar2).Value = TextBox7.Text
                LTB_TRANSACCIONESCONTABLESUNO.Parameters.Add(":descripcion", OracleDbType.Varchar2).Value = TextBox8.Text
                LTB_TRANSACCIONESCONTABLESUNO.Parameters.Add(":No_transaccion", OracleDbType.Varchar2).Value = TextBox9.Text

                If LTB_TRANSACCIONESCONTABLESUNO.ExecuteNonQuery() > 0 Then
                    MessageBox.Show("Registro agregado exitosamente en ambas tablas.")
                Else
                    MessageBox.Show("Error al agregar el registro en la tabla LTB_TRANSACCIONESCONTABLESUNO.")
                End If


            Catch ex As Exception
                MessageBox.Show("Error al conectar a la base de datos: " & ex.Message)
            End Try
        End Using
    End Sub
End Class