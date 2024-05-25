Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Oracle.ManagedDataAccess.Client

Public Class ELIMINAR_CUENTA


    Private Sub eliminar_Click(sender As Object, e As EventArgs) Handles eliminar.Click
        Dim ID As Integer

        ' Verificar si el ID del usuario ingresado es un número válido
        If Integer.TryParse(txtIdUsuario.Text, ID) Then
            Using conn As New OracleConnection(My.Settings.conexion)
                Try
                    conn.Open()

                    ' Verificar si el usuario existe en la base de datos
                    Dim queryExistenciaUsuario As String = $"SELECT COUNT(*) FROM CPAGAR WHERE ID = {ID}"
                    Dim commandExistenciaUsuario As New OracleCommand(queryExistenciaUsuario, conn)
                    Dim countUsuario As Integer = Convert.ToInt32(commandExistenciaUsuario.ExecuteScalar())

                    'consultar ACREEDOR por ID
                    Dim queryCliente2 As String = $"SELECT FECHA FROM CPAGAR WHERE ID = {ID}"
                    Dim commandCliente2 As New OracleCommand(queryCliente2, conn)
                    Dim acreedor As String = Convert.ToString(commandCliente2.ExecuteScalar())
                    If acreedor <> "" Then
                        TextBox3.Text = acreedor
                    Else
                        MessageBox.Show("No se encontró una factura con ese ID.")
                    End If
                    'CONSULTAR ACREEDOR POR ID
                    Dim queryCliente3 As String = $"SELECT NOMBRE FROM ACREEDORES WHERE ID = {ID}"
                    Dim commandCliente3 As New OracleCommand(queryCliente3, conn)
                    Dim fecha As String = Convert.ToString(commandCliente3.ExecuteScalar())
                    If fecha <> "" Then
                        TextBox5.Text = fecha
                    Else
                        MessageBox.Show("No se encontró una factura con ese ID.")
                    End If
                    'CONSULTAR NO FACTURA POR ID
                    Dim queryCliente4 As String = $"SELECT NOFACTURA FROM CPAGAR WHERE ID = {ID}"
                    Dim commandCliente4 As New OracleCommand(queryCliente4, conn)
                    Dim factura As String = Convert.ToString(commandCliente4.ExecuteScalar())
                    If factura <> "" Then
                        TextBox4.Text = factura
                    Else
                        MessageBox.Show("No se encontró una factura con ese ID.")
                    End If

                    If countUsuario > 0 Then
                        ' Preguntar si se debe eliminar el registro
                        If MessageBox.Show("¿Está seguro de eliminar el registro?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                            Dim queryEliminar As String = $"DELETE FROM CPAGAR WHERE ID = {ID}"
                            Dim commandEliminar As New OracleCommand(queryEliminar, conn)
                            commandEliminar.ExecuteNonQuery()

                            MessageBox.Show("Usuario eliminado correctamente.")
                            ' Limpiar los campos después de eliminar
                            txtIdUsuario.Text = ""
                            TextBox3.Text = ""
                            TextBox4.Text = ""
                            TextBox5.Text = ""
                        End If
                    Else
                        ' El usuario no existe en la base de datos
                        MessageBox.Show("El usuario no fue encontrado en la base de datos.")
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error al eliminar el usuario: " & ex.Message)
                End Try
            End Using
        Else
            ' El ID del usuario ingresado no es un número válido
            MessageBox.Show("Por favor, ingrese un ID de usuario válido.")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
