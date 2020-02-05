<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.PicMem = New System.Windows.Forms.PictureBox()
        Me.TmrAnimation = New System.Windows.Forms.Timer(Me.components)
        Me.BtnStart = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PicMem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PicMem
        '
        Me.PicMem.Location = New System.Drawing.Point(49, 3)
        Me.PicMem.Name = "PicMem"
        Me.PicMem.Size = New System.Drawing.Size(527, 377)
        Me.PicMem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicMem.TabIndex = 0
        Me.PicMem.TabStop = False
        '
        'TmrAnimation
        '
        Me.TmrAnimation.Interval = 150
        '
        'BtnStart
        '
        Me.BtnStart.Location = New System.Drawing.Point(204, 431)
        Me.BtnStart.Name = "BtnStart"
        Me.BtnStart.Size = New System.Drawing.Size(218, 39)
        Me.BtnStart.TabIndex = 1
        Me.BtnStart.Text = "Start"
        Me.BtnStart.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(196, 383)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(238, 45)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Memory Game"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 520)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnStart)
        Me.Controls.Add(Me.PicMem)
        Me.Name = "Form1"
        Me.Text = "Memory"
        CType(Me.PicMem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PicMem As PictureBox
    Friend WithEvents TmrAnimation As Timer
    Friend WithEvents BtnStart As Button
    Friend WithEvents Label1 As Label
End Class
