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
        Label1 = New Label()
        txtValor1 = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        txtValor2 = New TextBox()
        txtResultado = New TextBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 102)
        Label1.Name = "Label1"
        Label1.Size = New Size(39, 15)
        Label1.TabIndex = 0
        Label1.Text = "Valor1"
        ' 
        ' txtValor1
        ' 
        txtValor1.Location = New Point(12, 120)
        txtValor1.Name = "txtValor1"
        txtValor1.Size = New Size(82, 23)
        txtValor1.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(109, 123)
        Label2.Name = "Label2"
        Label2.Size = New Size(15, 15)
        Label2.TabIndex = 2
        Label2.Text = "+"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(139, 102)
        Label3.Name = "Label3"
        Label3.Size = New Size(39, 15)
        Label3.TabIndex = 3
        Label3.Text = "Valor2"
        ' 
        ' txtValor2
        ' 
        txtValor2.Location = New Point(139, 120)
        txtValor2.Name = "txtValor2"
        txtValor2.Size = New Size(100, 23)
        txtValor2.TabIndex = 4
        ' 
        ' txtResultado
        ' 
        txtResultado.Location = New Point(321, 120)
        txtResultado.Name = "txtResultado"
        txtResultado.Size = New Size(100, 23)
        txtResultado.TabIndex = 6
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(266, 120)
        Button1.Name = "Button1"
        Button1.Size = New Size(38, 23)
        Button1.TabIndex = 7
        Button1.Text = "="
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1319, 764)
        Controls.Add(Button1)
        Controls.Add(txtResultado)
        Controls.Add(txtValor2)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(txtValor1)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtValor1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtValor2 As TextBox
    Friend WithEvents txtResultado As TextBox
    Friend WithEvents Button1 As Button
End Class
