<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuUtamaMaster
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistoriTransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarangToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchingFilteringToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BarangToolStripMenuItem, Me.TransaksiToolStripMenuItem, Me.HistoriTransaksiToolStripMenuItem, Me.BarangToolStripMenuItem1, Me.SearchingFilteringToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(638, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BarangToolStripMenuItem
        '
        Me.BarangToolStripMenuItem.Name = "BarangToolStripMenuItem"
        Me.BarangToolStripMenuItem.Size = New System.Drawing.Size(103, 20)
        Me.BarangToolStripMenuItem.Text = "Mastering Akun"
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.TransaksiToolStripMenuItem.Text = "Transaksi"
        '
        'HistoriTransaksiToolStripMenuItem
        '
        Me.HistoriTransaksiToolStripMenuItem.Name = "HistoriTransaksiToolStripMenuItem"
        Me.HistoriTransaksiToolStripMenuItem.Size = New System.Drawing.Size(104, 20)
        Me.HistoriTransaksiToolStripMenuItem.Text = "Histori Transaksi"
        '
        'BarangToolStripMenuItem1
        '
        Me.BarangToolStripMenuItem1.Name = "BarangToolStripMenuItem1"
        Me.BarangToolStripMenuItem1.Size = New System.Drawing.Size(53, 20)
        Me.BarangToolStripMenuItem1.Text = "Kamar"
        '
        'SearchingFilteringToolStripMenuItem
        '
        Me.SearchingFilteringToolStripMenuItem.Name = "SearchingFilteringToolStripMenuItem"
        Me.SearchingFilteringToolStripMenuItem.Size = New System.Drawing.Size(117, 20)
        Me.SearchingFilteringToolStripMenuItem.Text = "Searching Filtering"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Impact", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(184, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(283, 80)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Welcome"
        '
        'MenuUtamaMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(638, 291)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MenuUtamaMaster"
        Me.Text = "Omah Hotel"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BarangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HistoriTransaksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents TransaksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BarangToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SearchingFilteringToolStripMenuItem As ToolStripMenuItem
End Class
