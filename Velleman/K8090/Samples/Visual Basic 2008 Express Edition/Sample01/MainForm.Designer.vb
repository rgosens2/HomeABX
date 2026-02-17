<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.K8090 = New Velleman.Kits.K8090Board(Me.components)
        Me.btnTest = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'K8090
        '
        Me.K8090.Port = "COM1"
        '
        'btnTest
        '
        Me.btnTest.Location = New System.Drawing.Point(115, 66)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(75, 23)
        Me.btnTest.TabIndex = 0
        Me.btnTest.Text = "Test"
        Me.btnTest.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(315, 167)
        Me.Controls.Add(Me.btnTest)
        Me.Name = "MainForm"
        Me.Text = "K8090 - Sample01"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents K8090 As Velleman.Kits.K8090Board
    Friend WithEvents btnTest As System.Windows.Forms.Button

End Class
