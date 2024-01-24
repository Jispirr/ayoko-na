<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GlassGame
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
        ButtonStart = New Button()
        Button1Right = New Button()
        Button1Left = New Button()
        Button2Left = New Button()
        Button3Left = New Button()
        Button4Left = New Button()
        Button5Left = New Button()
        Button2Right = New Button()
        Button3Right = New Button()
        Button4Right = New Button()
        Button5Right = New Button()
        Button6Left = New Button()
        Button6Right = New Button()
        ButtonEnd = New Button()
        SuspendLayout()
        ' 
        ' ButtonStart
        ' 
        ButtonStart.Location = New Point(72, 192)
        ButtonStart.Name = "ButtonStart"
        ButtonStart.Size = New Size(75, 67)
        ButtonStart.TabIndex = 0
        ButtonStart.Text = "Button1"
        ButtonStart.UseVisualStyleBackColor = True
        ' 
        ' Button1Right
        ' 
        Button1Right.Location = New Point(153, 225)
        Button1Right.Name = "Button1Right"
        Button1Right.Size = New Size(75, 67)
        Button1Right.TabIndex = 1
        Button1Right.Text = "Button2"
        Button1Right.UseVisualStyleBackColor = True
        ' 
        ' Button1Left
        ' 
        Button1Left.Location = New Point(153, 152)
        Button1Left.Name = "Button1Left"
        Button1Left.Size = New Size(75, 67)
        Button1Left.TabIndex = 2
        Button1Left.Text = "Button3"
        Button1Left.UseVisualStyleBackColor = True
        ' 
        ' Button2Left
        ' 
        Button2Left.Location = New Point(234, 152)
        Button2Left.Name = "Button2Left"
        Button2Left.Size = New Size(75, 67)
        Button2Left.TabIndex = 3
        Button2Left.Text = "Button4"
        Button2Left.UseVisualStyleBackColor = True
        ' 
        ' Button3Left
        ' 
        Button3Left.Location = New Point(315, 152)
        Button3Left.Name = "Button3Left"
        Button3Left.Size = New Size(75, 67)
        Button3Left.TabIndex = 4
        Button3Left.Text = "Button5"
        Button3Left.UseVisualStyleBackColor = True
        ' 
        ' Button4Left
        ' 
        Button4Left.Location = New Point(396, 152)
        Button4Left.Name = "Button4Left"
        Button4Left.Size = New Size(75, 67)
        Button4Left.TabIndex = 5
        Button4Left.Text = "Button6"
        Button4Left.UseVisualStyleBackColor = True
        ' 
        ' Button5Left
        ' 
        Button5Left.Location = New Point(477, 152)
        Button5Left.Name = "Button5Left"
        Button5Left.Size = New Size(75, 67)
        Button5Left.TabIndex = 6
        Button5Left.Text = "Button7"
        Button5Left.UseVisualStyleBackColor = True
        ' 
        ' Button2Right
        ' 
        Button2Right.Location = New Point(234, 225)
        Button2Right.Name = "Button2Right"
        Button2Right.Size = New Size(75, 67)
        Button2Right.TabIndex = 7
        Button2Right.Text = "Button8"
        Button2Right.UseVisualStyleBackColor = True
        ' 
        ' Button3Right
        ' 
        Button3Right.Location = New Point(315, 225)
        Button3Right.Name = "Button3Right"
        Button3Right.Size = New Size(75, 67)
        Button3Right.TabIndex = 8
        Button3Right.Text = "Button9"
        Button3Right.UseVisualStyleBackColor = True
        ' 
        ' Button4Right
        ' 
        Button4Right.Location = New Point(396, 225)
        Button4Right.Name = "Button4Right"
        Button4Right.Size = New Size(75, 67)
        Button4Right.TabIndex = 9
        Button4Right.Text = "Button10"
        Button4Right.UseVisualStyleBackColor = True
        ' 
        ' Button5Right
        ' 
        Button5Right.Location = New Point(477, 225)
        Button5Right.Name = "Button5Right"
        Button5Right.Size = New Size(75, 67)
        Button5Right.TabIndex = 10
        Button5Right.Text = "Button11"
        Button5Right.UseVisualStyleBackColor = True
        ' 
        ' Button6Left
        ' 
        Button6Left.Location = New Point(558, 152)
        Button6Left.Name = "Button6Left"
        Button6Left.Size = New Size(75, 67)
        Button6Left.TabIndex = 11
        Button6Left.Text = "Button12"
        Button6Left.UseVisualStyleBackColor = True
        ' 
        ' Button6Right
        ' 
        Button6Right.Location = New Point(558, 225)
        Button6Right.Name = "Button6Right"
        Button6Right.Size = New Size(75, 67)
        Button6Right.TabIndex = 12
        Button6Right.Text = "Button2"
        Button6Right.UseVisualStyleBackColor = True
        ' 
        ' ButtonEnd
        ' 
        ButtonEnd.Location = New Point(639, 192)
        ButtonEnd.Name = "ButtonEnd"
        ButtonEnd.Size = New Size(75, 67)
        ButtonEnd.TabIndex = 13
        ButtonEnd.Text = "Button3"
        ButtonEnd.UseVisualStyleBackColor = True
        ' 
        ' GlassGame
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(ButtonEnd)
        Controls.Add(Button6Right)
        Controls.Add(Button6Left)
        Controls.Add(Button5Right)
        Controls.Add(Button4Right)
        Controls.Add(Button3Right)
        Controls.Add(Button2Right)
        Controls.Add(Button5Left)
        Controls.Add(Button4Left)
        Controls.Add(Button3Left)
        Controls.Add(Button2Left)
        Controls.Add(Button1Left)
        Controls.Add(Button1Right)
        Controls.Add(ButtonStart)
        DoubleBuffered = True
        Name = "GlassGame"
        Text = "GlassGame"
        ResumeLayout(False)
    End Sub

    Friend WithEvents ButtonStart As Button
    Friend WithEvents Button1Right As Button
    Friend WithEvents Button1Left As Button
    Friend WithEvents Button2Left As Button
    Friend WithEvents Button3Left As Button
    Friend WithEvents Button4Left As Button
    Friend WithEvents Button5Left As Button
    Friend WithEvents Button2Right As Button
    Friend WithEvents Button3Right As Button
    Friend WithEvents Button4Right As Button
    Friend WithEvents Button5Right As Button
    Friend WithEvents Button6Left As Button
    Friend WithEvents Button6Right As Button
    Friend WithEvents ButtonEnd As Button
End Class
