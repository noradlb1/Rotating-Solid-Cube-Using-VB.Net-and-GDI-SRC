<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.picCodeNtronix = New System.Windows.Forms.PictureBox()
        CType(Me.picCodeNtronix, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picCodeNtronix
        '
        Me.picCodeNtronix.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picCodeNtronix.Image = CType(resources.GetObject("picCodeNtronix.Image"), System.Drawing.Image)
        Me.picCodeNtronix.Location = New System.Drawing.Point(239, 286)
        Me.picCodeNtronix.Name = "picCodeNtronix"
        Me.picCodeNtronix.Size = New System.Drawing.Size(202, 48)
        Me.picCodeNtronix.TabIndex = 1
        Me.picCodeNtronix.TabStop = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 333)
        Me.Controls.Add(Me.picCodeNtronix)
        Me.Name = "Main"
        Me.Text = "Rotating Cube (GDI+)"
        CType(Me.picCodeNtronix, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picCodeNtronix As System.Windows.Forms.PictureBox

End Class
