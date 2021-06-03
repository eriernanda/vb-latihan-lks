<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mastering_Akun
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Update = New System.Windows.Forms.Button()
        Me.Delete = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Create = New System.Windows.Forms.Button()
        Me.Read = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Myanmar Text", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(166, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(256, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(121, 20)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(256, 61)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(121, 20)
        Me.TextBox2.TabIndex = 3
        Me.TextBox2.Text = " "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Myanmar Text", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(166, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 29)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Myanmar Text", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(166, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 29)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "User Type"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"master", "admin"})
        Me.ComboBox1.Location = New System.Drawing.Point(256, 112)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 5
        '
        'Update
        '
        Me.Update.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Update.Location = New System.Drawing.Point(157, 183)
        Me.Update.Name = "Update"
        Me.Update.Size = New System.Drawing.Size(119, 37)
        Me.Update.TabIndex = 7
        Me.Update.Text = "Edit"
        Me.Update.UseVisualStyleBackColor = True
        '
        'Delete
        '
        Me.Delete.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Delete.Location = New System.Drawing.Point(292, 183)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(119, 37)
        Me.Delete.TabIndex = 8
        Me.Delete.Text = "Hapus"
        Me.Delete.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(134, 236)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(317, 118)
        Me.DataGridView1.TabIndex = 9
        '
        'Create
        '
        Me.Create.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Create.Location = New System.Drawing.Point(23, 183)
        Me.Create.Name = "Create"
        Me.Create.Size = New System.Drawing.Size(119, 37)
        Me.Create.TabIndex = 10
        Me.Create.Text = "Tambah"
        Me.Create.UseVisualStyleBackColor = True
        '
        'Read
        '
        Me.Read.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Read.Location = New System.Drawing.Point(426, 183)
        Me.Read.Name = "Read"
        Me.Read.Size = New System.Drawing.Size(119, 37)
        Me.Read.TabIndex = 11
        Me.Read.Text = "Tampil"
        Me.Read.UseVisualStyleBackColor = True
        '
        'Mastering_Akun
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(570, 366)
        Me.Controls.Add(Me.Read)
        Me.Controls.Add(Me.Create)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Delete)
        Me.Controls.Add(Me.Update)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Mastering_Akun"
        Me.Text = "Mastering Akun"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Update As Button
    Friend WithEvents Delete As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Create As Button
    Friend WithEvents Read As Button
End Class
