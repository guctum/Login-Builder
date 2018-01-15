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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFirst = New System.Windows.Forms.TextBox()
        Me.txtLast = New System.Windows.Forms.TextBox()
        Me.txtLogin = New System.Windows.Forms.TextBox()
        Me.btnString = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 31)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 77)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Last:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 123)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Login"
        '
        'txtFirst
        '
        Me.txtFirst.Location = New System.Drawing.Point(150, 31)
        Me.txtFirst.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtFirst.Name = "txtFirst"
        Me.txtFirst.Size = New System.Drawing.Size(148, 26)
        Me.txtFirst.TabIndex = 3
        '
        'txtLast
        '
        Me.txtLast.Location = New System.Drawing.Point(150, 77)
        Me.txtLast.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtLast.Name = "txtLast"
        Me.txtLast.Size = New System.Drawing.Size(148, 26)
        Me.txtLast.TabIndex = 4
        '
        'txtLogin
        '
        Me.txtLogin.Location = New System.Drawing.Point(150, 123)
        Me.txtLogin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.ReadOnly = True
        Me.txtLogin.Size = New System.Drawing.Size(148, 26)
        Me.txtLogin.TabIndex = 5
        Me.txtLogin.TabStop = False
        '
        'btnString
        '
        Me.btnString.Location = New System.Drawing.Point(45, 185)
        Me.btnString.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnString.Name = "btnString"
        Me.btnString.Size = New System.Drawing.Size(112, 35)
        Me.btnString.TabIndex = 6
        Me.btnString.Text = "String"
        Me.btnString.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(188, 185)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(112, 35)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AcceptButton = Me.btnString
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(338, 263)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnString)
        Me.Controls.Add(Me.txtLogin)
        Me.Controls.Add(Me.txtLast)
        Me.Controls.Add(Me.txtFirst)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Login Builder"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtFirst As System.Windows.Forms.TextBox
    Friend WithEvents txtLast As System.Windows.Forms.TextBox
    Friend WithEvents txtLogin As System.Windows.Forms.TextBox
    Friend WithEvents btnString As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
