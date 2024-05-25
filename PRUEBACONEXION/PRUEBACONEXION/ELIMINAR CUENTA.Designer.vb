<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ELIMINAR_CUENTA
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.eliminar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIdUsuario = New System.Windows.Forms.TextBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.TextBox5)
        Me.Panel1.Controls.Add(Me.TextBox4)
        Me.Panel1.Controls.Add(Me.TextBox3)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.eliminar)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtIdUsuario)
        Me.Panel1.Location = New System.Drawing.Point(0, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(469, 313)
        Me.Panel1.TabIndex = 0
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(134, 81)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(287, 33)
        Me.TextBox5.TabIndex = 11
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(140, 187)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(281, 33)
        Me.TextBox4.TabIndex = 10
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(134, 134)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(287, 33)
        Me.TextBox3.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(39, 143)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 16)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "FECHA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(39, 204)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "NO. FACTURA"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Goudy Old Style", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(254, 239)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(167, 47)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "CANCELAR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'eliminar
        '
        Me.eliminar.Font = New System.Drawing.Font("Goudy Old Style", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eliminar.Location = New System.Drawing.Point(65, 239)
        Me.eliminar.Name = "eliminar"
        Me.eliminar.Size = New System.Drawing.Size(166, 47)
        Me.eliminar.TabIndex = 1
        Me.eliminar.Text = "ELIMINAR"
        Me.eliminar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(39, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ACREEDOR"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(39, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID"
        '
        'txtIdUsuario
        '
        Me.txtIdUsuario.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdUsuario.Location = New System.Drawing.Point(76, 25)
        Me.txtIdUsuario.Name = "txtIdUsuario"
        Me.txtIdUsuario.Size = New System.Drawing.Size(345, 33)
        Me.txtIdUsuario.TabIndex = 0
        '
        'ELIMINAR_CUENTA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 309)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ELIMINAR_CUENTA"
        Me.Text = "ELIMINAR_CUENTA"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtIdUsuario As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents eliminar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
End Class
