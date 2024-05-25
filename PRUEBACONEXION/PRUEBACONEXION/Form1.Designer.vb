<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.button3 = New System.Windows.Forms.Button()
        Me.Apertura_Cuenta = New System.Windows.Forms.Button()
        Me.textBox10 = New System.Windows.Forms.TextBox()
        Me.textBox7 = New System.Windows.Forms.TextBox()
        Me.textBox6 = New System.Windows.Forms.TextBox()
        Me.textBox5 = New System.Windows.Forms.TextBox()
        Me.textBox4 = New System.Windows.Forms.TextBox()
        Me.textBox2 = New System.Windows.Forms.TextBox()
        Me.textiden = New System.Windows.Forms.TextBox()
        Me.label13 = New System.Windows.Forms.Label()
        Me.label10 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.INICIOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CONSULTARCUENTAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ELIMINARCUENTAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TRANSACCIONESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.panel1.Controls.Add(Me.Label12)
        Me.panel1.Controls.Add(Me.Label17)
        Me.panel1.Controls.Add(Me.Label19)
        Me.panel1.Controls.Add(Me.Label20)
        Me.panel1.Controls.Add(Me.button3)
        Me.panel1.Controls.Add(Me.Apertura_Cuenta)
        Me.panel1.Controls.Add(Me.textBox10)
        Me.panel1.Controls.Add(Me.textBox7)
        Me.panel1.Controls.Add(Me.textBox6)
        Me.panel1.Controls.Add(Me.textBox5)
        Me.panel1.Controls.Add(Me.textBox4)
        Me.panel1.Controls.Add(Me.textBox2)
        Me.panel1.Controls.Add(Me.textiden)
        Me.panel1.Controls.Add(Me.label13)
        Me.panel1.Controls.Add(Me.label10)
        Me.panel1.Controls.Add(Me.label6)
        Me.panel1.Controls.Add(Me.MenuStrip1)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(771, 495)
        Me.panel1.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Yi Baiti", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label12.Location = New System.Drawing.Point(12, 349)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(128, 20)
        Me.Label12.TabIndex = 50
        Me.Label12.Text = "DEUDA TOTAL"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Yi Baiti", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label17.Location = New System.Drawing.Point(12, 176)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(102, 20)
        Me.Label17.TabIndex = 48
        Me.Label17.Text = "ACREEDOR"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Yi Baiti", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label19.Location = New System.Drawing.Point(12, 132)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(142, 20)
        Me.Label19.TabIndex = 46
        Me.Label19.Text = "FECHA Y HORA"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label20.Location = New System.Drawing.Point(12, 63)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(33, 21)
        Me.Label20.TabIndex = 45
        Me.Label20.Text = "ID"
        '
        'button3
        '
        Me.button3.Location = New System.Drawing.Point(498, 407)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(156, 61)
        Me.button3.TabIndex = 34
        Me.button3.Text = "CANCELAR"
        Me.button3.UseVisualStyleBackColor = True
        '
        'Apertura_Cuenta
        '
        Me.Apertura_Cuenta.Location = New System.Drawing.Point(249, 407)
        Me.Apertura_Cuenta.Name = "Apertura_Cuenta"
        Me.Apertura_Cuenta.Size = New System.Drawing.Size(156, 61)
        Me.Apertura_Cuenta.TabIndex = 32
        Me.Apertura_Cuenta.Text = "ACEPTAR"
        Me.Apertura_Cuenta.UseVisualStyleBackColor = True
        '
        'textBox10
        '
        Me.textBox10.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox10.Location = New System.Drawing.Point(180, 338)
        Me.textBox10.Name = "textBox10"
        Me.textBox10.Size = New System.Drawing.Size(531, 31)
        Me.textBox10.TabIndex = 22
        '
        'textBox7
        '
        Me.textBox7.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox7.Location = New System.Drawing.Point(180, 286)
        Me.textBox7.Name = "textBox7"
        Me.textBox7.Size = New System.Drawing.Size(531, 31)
        Me.textBox7.TabIndex = 19
        '
        'textBox6
        '
        Me.textBox6.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox6.Location = New System.Drawing.Point(180, 227)
        Me.textBox6.Name = "textBox6"
        Me.textBox6.Size = New System.Drawing.Size(531, 31)
        Me.textBox6.TabIndex = 18
        '
        'textBox5
        '
        Me.textBox5.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox5.Location = New System.Drawing.Point(180, 176)
        Me.textBox5.Name = "textBox5"
        Me.textBox5.Size = New System.Drawing.Size(531, 31)
        Me.textBox5.TabIndex = 17
        '
        'textBox4
        '
        Me.textBox4.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox4.Location = New System.Drawing.Point(180, 129)
        Me.textBox4.Name = "textBox4"
        Me.textBox4.Size = New System.Drawing.Size(531, 31)
        Me.textBox4.TabIndex = 16
        '
        'textBox2
        '
        Me.textBox2.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox2.Location = New System.Drawing.Point(533, 63)
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New System.Drawing.Size(178, 31)
        Me.textBox2.TabIndex = 14
        '
        'textiden
        '
        Me.textiden.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textiden.Location = New System.Drawing.Point(180, 60)
        Me.textiden.Name = "textiden"
        Me.textiden.Size = New System.Drawing.Size(155, 31)
        Me.textiden.TabIndex = 13
        '
        'label13
        '
        Me.label13.AutoSize = True
        Me.label13.Font = New System.Drawing.Font("Microsoft Yi Baiti", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.label13.Location = New System.Drawing.Point(12, 235)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(125, 20)
        Me.label13.TabIndex = 12
        Me.label13.Text = "DESCRIPCION"
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Font = New System.Drawing.Font("Microsoft Yi Baiti", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.label10.Location = New System.Drawing.Point(12, 289)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(86, 20)
        Me.label10.TabIndex = 9
        Me.label10.Text = "ESTADO "
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Microsoft Yi Baiti", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.label6.Location = New System.Drawing.Point(371, 66)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(126, 20)
        Me.label6.TabIndex = 5
        Me.label6.Text = "NO. FACTURA"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.INICIOToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(771, 28)
        Me.MenuStrip1.TabIndex = 51
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'INICIOToolStripMenuItem
        '
        Me.INICIOToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CONSULTARCUENTAToolStripMenuItem, Me.ELIMINARCUENTAToolStripMenuItem, Me.TRANSACCIONESToolStripMenuItem})
        Me.INICIOToolStripMenuItem.Name = "INICIOToolStripMenuItem"
        Me.INICIOToolStripMenuItem.Size = New System.Drawing.Size(66, 24)
        Me.INICIOToolStripMenuItem.Text = "INICIO"
        '
        'CONSULTARCUENTAToolStripMenuItem
        '
        Me.CONSULTARCUENTAToolStripMenuItem.Name = "CONSULTARCUENTAToolStripMenuItem"
        Me.CONSULTARCUENTAToolStripMenuItem.Size = New System.Drawing.Size(217, 26)
        Me.CONSULTARCUENTAToolStripMenuItem.Text = "AGREGAR CUENTA"
        '
        'ELIMINARCUENTAToolStripMenuItem
        '
        Me.ELIMINARCUENTAToolStripMenuItem.Name = "ELIMINARCUENTAToolStripMenuItem"
        Me.ELIMINARCUENTAToolStripMenuItem.Size = New System.Drawing.Size(217, 26)
        Me.ELIMINARCUENTAToolStripMenuItem.Text = "ELIMINAR CUENTA"
        '
        'TRANSACCIONESToolStripMenuItem
        '
        Me.TRANSACCIONESToolStripMenuItem.Name = "TRANSACCIONESToolStripMenuItem"
        Me.TRANSACCIONESToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.TRANSACCIONESToolStripMenuItem.Text = "TRANSACCIONES"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(771, 495)
        Me.Controls.Add(Me.panel1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "VER TRANSACCIONES"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents panel1 As Panel
    Private WithEvents button3 As Button
    Private WithEvents Apertura_Cuenta As Button
    Private WithEvents textBox10 As TextBox
    Private WithEvents textBox7 As TextBox
    Private WithEvents textBox6 As TextBox
    Private WithEvents textBox5 As TextBox
    Private WithEvents textBox4 As TextBox
    Private WithEvents textBox2 As TextBox
    Private WithEvents textiden As TextBox
    Private WithEvents label13 As Label
    Private WithEvents label10 As Label
    Private WithEvents label6 As Label
    Private WithEvents Label17 As Label
    Private WithEvents Label19 As Label
    Private WithEvents Label20 As Label
    Private WithEvents Label12 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents INICIOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CONSULTARCUENTAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ELIMINARCUENTAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TRANSACCIONESToolStripMenuItem As ToolStripMenuItem
End Class
