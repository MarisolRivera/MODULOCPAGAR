Imports Oracle.ManagedDataAccess.Client
Imports System.EnterpriseServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Apertura_Cuenta.Click
        Dim ID As String = textiden.Text.Trim()

        If ID <> "" Then
            Using conn As New OracleConnection(My.Settings.conexion)
                Try
                    conn.Open()

                    ' Consultar Descripcion por ID
                    Dim queryCliente As String = $"SELECT DESCRIPCION FROM CPAGAR WHERE ID = {ID}"
                    Dim commandCliente As New OracleCommand(queryCliente, conn)
                    Dim nombreCliente As String = Convert.ToString(commandCliente.ExecuteScalar())
                    'consultar FECHA por ID
                    Dim queryCliente2 As String = $"SELECT FECHA FROM CPAGAR WHERE ID = {ID}"
                    Dim commandCliente2 As New OracleCommand(queryCliente2, conn)
                    Dim acreedor As String = Convert.ToString(commandCliente2.ExecuteScalar())
                    'CONSULTAR ACREEDOR POR ID
                    Dim queryCliente3 As String = $"SELECT NOMBRE FROM ACREEDORES WHERE ID = {ID}"
                    Dim commandCliente3 As New OracleCommand(queryCliente3, conn)
                    Dim fecha As String = Convert.ToString(commandCliente3.ExecuteScalar())
                    'CONSULTAR NO FACTURA POR ID
                    Dim queryCliente4 As String = $"SELECT NOFACTURA FROM CPAGAR WHERE ID = {ID}"
                    Dim commandCliente4 As New OracleCommand(queryCliente4, conn)
                    Dim factura As String = Convert.ToString(commandCliente4.ExecuteScalar())
                    'CONSULTAR DEUDA POR ID
                    Dim queryCliente5 As String = $"SELECT TOTALDEUDA FROM CPAGAR WHERE ID = {ID}"
                    Dim commandCliente5 As New OracleCommand(queryCliente5, conn)
                    Dim totaldeuda As String = Convert.ToString(commandCliente5.ExecuteScalar())
                    Dim estado As String

                    If totaldeuda = "0" Then
                        textBox7.Text = ("CANCELADA")
                    Else
                        textBox7.Text = ("EN PROCESO")
                    End If

                    If nombreCliente <> "" Then
                        textBox6.Text = nombreCliente
                    Else
                        MessageBox.Show("No se encontró una factura con ese ID.")
                    End If
                    If totaldeuda <> "" Then
                        textBox10.Text = totaldeuda
                    Else
                        MessageBox.Show("No se encontró una factura con ese ID.")
                    End If

                    If fecha <> "" Then
                        textBox5.Text = fecha
                    Else
                        MessageBox.Show("No se encontró una fecha con ese ID.")
                    End If

                    If acreedor <> "" Then
                        textBox4.Text = acreedor
                    Else
                        MessageBox.Show("No se encontró un acreedor con ese ID.")
                    End If

                    If factura <> "" Then
                        textBox2.Text = factura
                    Else
                        MessageBox.Show("No se encontró un factura con ese ID.")
                    End If


                Catch ex As Exception
                    MessageBox.Show("Error al buscar la factura: " & ex.Message)
                End Try
            End Using
        Else
            MessageBox.Show("Por favor, ingrese un ID válido.")
        End If
    End Sub





    Private Sub panel1_Paint(sender As Object, e As PaintEventArgs) Handles panel1.Paint

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub pictureBox3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub INICIOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles INICIOToolStripMenuItem.Click

    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        ' Me.Close()

        textiden.Text = ""
        textBox2.Text = ""
        textBox10.Text = ""
        textBox4.Text = ""
        textBox5.Text = ""
        textBox6.Text = ""
        textBox7.Text = ""


    End Sub

    Private Sub label9_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CONSULTARCUENTAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CONSULTARCUENTAToolStripMenuItem.Click
        CONSULTAR.Show()
    End Sub

    Private Sub ELIMINARCUENTAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ELIMINARCUENTAToolStripMenuItem.Click
        ELIMINAR_CUENTA.Show()
    End Sub

    Private Sub textBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textBox2.KeyPress
        ' Suprimir cualquier entrada
        e.Handled = True
        MsgBox("Este campo no permite la entrada de datos.")
    End Sub

    Private Sub textBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textBox4.KeyPress
        ' Suprimir cualquier entrada
        e.Handled = True
        MsgBox("Este campo no permite la entrada de datos.")
    End Sub

    Private Sub textBox7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textBox7.KeyPress
        ' Suprimir cualquier entrada
        e.Handled = True
        MsgBox("Este campo no permite la entrada de datos.")
    End Sub

    Private Sub textBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textBox5.KeyPress
        ' Suprimir cualquier entrada
        e.Handled = True
        MsgBox("Este campo no permite la entrada de datos.")
    End Sub

    Private Sub textBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textBox6.KeyPress
        ' Suprimir cualquier entrada
        e.Handled = True
        MsgBox("Este campo no permite la entrada de datos.")
    End Sub

    Private Sub textBox10_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textBox10.KeyPress
        ' Suprimir cualquier entrada
        e.Handled = True
        MsgBox("Este campo no permite la entrada de datos.")
    End Sub

    Private Sub TRANSACCIONESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TRANSACCIONESToolStripMenuItem.Click
        TRANSACCIONES.Show()
    End Sub
End Class
