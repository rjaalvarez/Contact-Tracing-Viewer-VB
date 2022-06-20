<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class contactTracingViewerVB
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
        Me.showFilesBtn = New System.Windows.Forms.Button()
        Me.filesListBox = New System.Windows.Forms.ListBox()
        Me.contentTextBox = New System.Windows.Forms.RichTextBox()
        Me.exitBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'showFilesBtn
        '
        Me.showFilesBtn.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.showFilesBtn.Location = New System.Drawing.Point(340, 373)
        Me.showFilesBtn.Name = "showFilesBtn"
        Me.showFilesBtn.Size = New System.Drawing.Size(392, 51)
        Me.showFilesBtn.TabIndex = 0
        Me.showFilesBtn.Text = "Show Files"
        Me.showFilesBtn.UseVisualStyleBackColor = True
        '
        'filesListBox
        '
        Me.filesListBox.Font = New System.Drawing.Font("Lucida Fax", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.filesListBox.FormattingEnabled = True
        Me.filesListBox.ItemHeight = 16
        Me.filesListBox.Location = New System.Drawing.Point(12, 12)
        Me.filesListBox.Name = "filesListBox"
        Me.filesListBox.Size = New System.Drawing.Size(322, 468)
        Me.filesListBox.TabIndex = 1
        '
        'contentTextBox
        '
        Me.contentTextBox.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contentTextBox.Location = New System.Drawing.Point(340, 12)
        Me.contentTextBox.Name = "contentTextBox"
        Me.contentTextBox.Size = New System.Drawing.Size(392, 355)
        Me.contentTextBox.TabIndex = 3
        Me.contentTextBox.Text = ""
        '
        'exitBtn
        '
        Me.exitBtn.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitBtn.Location = New System.Drawing.Point(340, 430)
        Me.exitBtn.Name = "exitBtn"
        Me.exitBtn.Size = New System.Drawing.Size(392, 51)
        Me.exitBtn.TabIndex = 4
        Me.exitBtn.Text = "Exit"
        Me.exitBtn.UseVisualStyleBackColor = True
        '
        'contactTracingViewerVB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(744, 513)
        Me.Controls.Add(Me.exitBtn)
        Me.Controls.Add(Me.contentTextBox)
        Me.Controls.Add(Me.filesListBox)
        Me.Controls.Add(Me.showFilesBtn)
        Me.Name = "contactTracingViewerVB"
        Me.Text = "Contact Tracing Viewer VB"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents showFilesBtn As Button
    Friend WithEvents filesListBox As ListBox
    Friend WithEvents contentTextBox As RichTextBox
    Friend WithEvents exitBtn As Button
End Class
