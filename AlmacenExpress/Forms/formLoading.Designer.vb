<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formLoading
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
        Me.lblCreatorsTitle = New System.Windows.Forms.Label()
        Me.lblCreators = New System.Windows.Forms.Label()
        Me.pcCuatrovientosLogo = New System.Windows.Forms.PictureBox()
        Me.pcLogo = New System.Windows.Forms.PictureBox()
        CType(Me.pcCuatrovientosLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCreatorsTitle
        '
        Me.lblCreatorsTitle.AutoSize = True
        Me.lblCreatorsTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreatorsTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.lblCreatorsTitle.Location = New System.Drawing.Point(11, 422)
        Me.lblCreatorsTitle.Name = "lblCreatorsTitle"
        Me.lblCreatorsTitle.Size = New System.Drawing.Size(107, 25)
        Me.lblCreatorsTitle.TabIndex = 4
        Me.lblCreatorsTitle.Text = "Creado por"
        '
        'lblCreators
        '
        Me.lblCreators.AutoSize = True
        Me.lblCreators.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreators.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.lblCreators.Location = New System.Drawing.Point(12, 447)
        Me.lblCreators.Name = "lblCreators"
        Me.lblCreators.Size = New System.Drawing.Size(206, 42)
        Me.lblCreators.TabIndex = 5
        Me.lblCreators.Text = "Mikel López, Javier Galera" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Julen Palacios y Ion Pellejero"
        '
        'pcCuatrovientosLogo
        '
        Me.pcCuatrovientosLogo.Image = Global.AlmacenExpress.My.Resources.Resources.CuatrovientosLogo
        Me.pcCuatrovientosLogo.Location = New System.Drawing.Point(256, 433)
        Me.pcCuatrovientosLogo.Name = "pcCuatrovientosLogo"
        Me.pcCuatrovientosLogo.Size = New System.Drawing.Size(146, 68)
        Me.pcCuatrovientosLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcCuatrovientosLogo.TabIndex = 0
        Me.pcCuatrovientosLogo.TabStop = False
        '
        'pcLogo
        '
        Me.pcLogo.Image = Global.AlmacenExpress.My.Resources.Resources.AlmacenExpress
        Me.pcLogo.Location = New System.Drawing.Point(62, 12)
        Me.pcLogo.Name = "pcLogo"
        Me.pcLogo.Size = New System.Drawing.Size(287, 150)
        Me.pcLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcLogo.TabIndex = 3
        Me.pcLogo.TabStop = False
        '
        'formLoading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(414, 513)
        Me.Controls.Add(Me.lblCreators)
        Me.Controls.Add(Me.lblCreatorsTitle)
        Me.Controls.Add(Me.pcCuatrovientosLogo)
        Me.Controls.Add(Me.pcLogo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formLoading"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.pcCuatrovientosLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pcLogo As PictureBox
    Friend WithEvents pcCuatrovientosLogo As PictureBox
    Friend WithEvents lblCreatorsTitle As Label
    Friend WithEvents lblCreators As Label
End Class
