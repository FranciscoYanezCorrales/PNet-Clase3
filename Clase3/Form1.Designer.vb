<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Button1 = New Button()
        txtcarga = New TextBox()
        lblestado = New Label()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(82, 51)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 0
        Button1.Text = "Cargar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' txtcarga
        ' 
        txtcarga.Location = New Point(12, 94)
        txtcarga.Name = "txtcarga"
        txtcarga.Size = New Size(233, 23)
        txtcarga.TabIndex = 1
        ' 
        ' lblestado
        ' 
        lblestado.AutoSize = True
        lblestado.Location = New Point(51, 21)
        lblestado.Name = "lblestado"
        lblestado.Size = New Size(0, 15)
        lblestado.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(254, 133)
        Controls.Add(lblestado)
        Controls.Add(txtcarga)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "Cargar Archivo TXT"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents txtcarga As TextBox
    Friend WithEvents lblestado As Label

End Class
