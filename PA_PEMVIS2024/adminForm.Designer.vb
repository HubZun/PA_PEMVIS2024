<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlAside = New System.Windows.Forms.Panel()
        Me.pnlOnBtnLgt = New System.Windows.Forms.Panel()
        Me.pnlOnBtnPrf = New System.Windows.Forms.Panel()
        Me.btnLgt = New System.Windows.Forms.Button()
        Me.btnPrf = New System.Windows.Forms.Button()
        Me.pnlOnBtnStf = New System.Windows.Forms.Panel()
        Me.btnStff = New System.Windows.Forms.Button()
        Me.pnlOnBtnPrd = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnPrd = New System.Windows.Forms.Button()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.pnlProduk = New System.Windows.Forms.Panel()
        Me.dgvProduk = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlStaff = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pnlProfile = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.gambar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlAside.SuspendLayout()
        Me.pnlProduk.SuspendLayout()
        CType(Me.dgvProduk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlStaff.SuspendLayout()
        Me.pnlProfile.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlAside
        '
        Me.pnlAside.BackColor = System.Drawing.Color.Red
        Me.pnlAside.Controls.Add(Me.pnlOnBtnLgt)
        Me.pnlAside.Controls.Add(Me.pnlOnBtnPrf)
        Me.pnlAside.Controls.Add(Me.btnLgt)
        Me.pnlAside.Controls.Add(Me.btnPrf)
        Me.pnlAside.Controls.Add(Me.pnlOnBtnStf)
        Me.pnlAside.Controls.Add(Me.btnStff)
        Me.pnlAside.Controls.Add(Me.pnlOnBtnPrd)
        Me.pnlAside.Controls.Add(Me.Label1)
        Me.pnlAside.Controls.Add(Me.btnPrd)
        Me.pnlAside.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlAside.Location = New System.Drawing.Point(0, 0)
        Me.pnlAside.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlAside.Name = "pnlAside"
        Me.pnlAside.Size = New System.Drawing.Size(188, 567)
        Me.pnlAside.TabIndex = 0
        '
        'pnlOnBtnLgt
        '
        Me.pnlOnBtnLgt.BackColor = System.Drawing.Color.Gold
        Me.pnlOnBtnLgt.Location = New System.Drawing.Point(0, 244)
        Me.pnlOnBtnLgt.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlOnBtnLgt.Name = "pnlOnBtnLgt"
        Me.pnlOnBtnLgt.Size = New System.Drawing.Size(16, 46)
        Me.pnlOnBtnLgt.TabIndex = 5
        '
        'pnlOnBtnPrf
        '
        Me.pnlOnBtnPrf.BackColor = System.Drawing.Color.Gold
        Me.pnlOnBtnPrf.Location = New System.Drawing.Point(0, 191)
        Me.pnlOnBtnPrf.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlOnBtnPrf.Name = "pnlOnBtnPrf"
        Me.pnlOnBtnPrf.Size = New System.Drawing.Size(16, 46)
        Me.pnlOnBtnPrf.TabIndex = 5
        '
        'btnLgt
        '
        Me.btnLgt.FlatAppearance.BorderSize = 0
        Me.btnLgt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLgt.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLgt.ForeColor = System.Drawing.SystemColors.Control
        Me.btnLgt.Location = New System.Drawing.Point(0, 244)
        Me.btnLgt.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLgt.Name = "btnLgt"
        Me.btnLgt.Size = New System.Drawing.Size(188, 46)
        Me.btnLgt.TabIndex = 4
        Me.btnLgt.Text = "Logout"
        Me.btnLgt.UseVisualStyleBackColor = True
        '
        'btnPrf
        '
        Me.btnPrf.FlatAppearance.BorderSize = 0
        Me.btnPrf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrf.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrf.ForeColor = System.Drawing.SystemColors.Control
        Me.btnPrf.Location = New System.Drawing.Point(0, 191)
        Me.btnPrf.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPrf.Name = "btnPrf"
        Me.btnPrf.Size = New System.Drawing.Size(188, 46)
        Me.btnPrf.TabIndex = 4
        Me.btnPrf.Text = "Profile"
        Me.btnPrf.UseVisualStyleBackColor = True
        '
        'pnlOnBtnStf
        '
        Me.pnlOnBtnStf.BackColor = System.Drawing.Color.Gold
        Me.pnlOnBtnStf.Location = New System.Drawing.Point(0, 138)
        Me.pnlOnBtnStf.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlOnBtnStf.Name = "pnlOnBtnStf"
        Me.pnlOnBtnStf.Size = New System.Drawing.Size(16, 46)
        Me.pnlOnBtnStf.TabIndex = 3
        '
        'btnStff
        '
        Me.btnStff.FlatAppearance.BorderSize = 0
        Me.btnStff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStff.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStff.ForeColor = System.Drawing.SystemColors.Control
        Me.btnStff.Location = New System.Drawing.Point(0, 138)
        Me.btnStff.Margin = New System.Windows.Forms.Padding(4)
        Me.btnStff.Name = "btnStff"
        Me.btnStff.Size = New System.Drawing.Size(188, 46)
        Me.btnStff.TabIndex = 2
        Me.btnStff.Text = "Staff"
        Me.btnStff.UseVisualStyleBackColor = True
        '
        'pnlOnBtnPrd
        '
        Me.pnlOnBtnPrd.BackColor = System.Drawing.Color.Gold
        Me.pnlOnBtnPrd.Location = New System.Drawing.Point(0, 85)
        Me.pnlOnBtnPrd.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlOnBtnPrd.Name = "pnlOnBtnPrd"
        Me.pnlOnBtnPrd.Size = New System.Drawing.Size(16, 46)
        Me.pnlOnBtnPrd.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(44, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ADMIN"
        '
        'btnPrd
        '
        Me.btnPrd.FlatAppearance.BorderSize = 0
        Me.btnPrd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrd.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrd.ForeColor = System.Drawing.SystemColors.Control
        Me.btnPrd.Location = New System.Drawing.Point(0, 85)
        Me.btnPrd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPrd.Name = "btnPrd"
        Me.btnPrd.Size = New System.Drawing.Size(188, 46)
        Me.btnPrd.TabIndex = 0
        Me.btnPrd.Text = "product"
        Me.btnPrd.UseVisualStyleBackColor = True
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.Yellow
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(188, 0)
        Me.pnlTop.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(817, 36)
        Me.pnlTop.TabIndex = 1
        '
        'pnlProduk
        '
        Me.pnlProduk.Controls.Add(Me.dgvProduk)
        Me.pnlProduk.Controls.Add(Me.TextBox1)
        Me.pnlProduk.Controls.Add(Me.Button1)
        Me.pnlProduk.Controls.Add(Me.Label2)
        Me.pnlProduk.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlProduk.Location = New System.Drawing.Point(188, 36)
        Me.pnlProduk.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlProduk.Name = "pnlProduk"
        Me.pnlProduk.Size = New System.Drawing.Size(817, 531)
        Me.pnlProduk.TabIndex = 2
        '
        'dgvProduk
        '
        Me.dgvProduk.AllowUserToAddRows = False
        Me.dgvProduk.AllowUserToResizeColumns = False
        Me.dgvProduk.AllowUserToResizeRows = False
        Me.dgvProduk.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProduk.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvProduk.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal
        Me.dgvProduk.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvProduk.ColumnHeadersHeight = 25
        Me.dgvProduk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvProduk.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column5, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.gambar})
        Me.dgvProduk.GridColor = System.Drawing.SystemColors.ButtonFace
        Me.dgvProduk.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dgvProduk.Location = New System.Drawing.Point(24, 102)
        Me.dgvProduk.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvProduk.MultiSelect = False
        Me.dgvProduk.Name = "dgvProduk"
        Me.dgvProduk.ReadOnly = True
        Me.dgvProduk.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgvProduk.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Lime
        Me.dgvProduk.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvProduk.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvProduk.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProduk.Size = New System.Drawing.Size(777, 384)
        Me.dgvProduk.TabIndex = 3
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(595, 54)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(132, 22)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.Text = "search.."
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(56, 52)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 28)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Add Product"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(365, 18)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Product"
        '
        'pnlStaff
        '
        Me.pnlStaff.Controls.Add(Me.Label3)
        Me.pnlStaff.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlStaff.Location = New System.Drawing.Point(188, 36)
        Me.pnlStaff.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlStaff.Name = "pnlStaff"
        Me.pnlStaff.Size = New System.Drawing.Size(817, 531)
        Me.pnlStaff.TabIndex = 3
        Me.pnlStaff.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(379, 49)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 25)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "staff"
        '
        'pnlProfile
        '
        Me.pnlProfile.Controls.Add(Me.Label4)
        Me.pnlProfile.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlProfile.Location = New System.Drawing.Point(188, 36)
        Me.pnlProfile.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlProfile.Name = "pnlProfile"
        Me.pnlProfile.Size = New System.Drawing.Size(817, 531)
        Me.pnlProfile.TabIndex = 4
        Me.pnlProfile.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(365, 49)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 25)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "profile"
        '
        'gambar
        '
        Me.gambar.HeaderText = "gambar"
        Me.gambar.Name = "gambar"
        Me.gambar.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Status"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "kategori"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Harga"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "Nama"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "id"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'adminForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 567)
        Me.Controls.Add(Me.pnlProduk)
        Me.Controls.Add(Me.pnlStaff)
        Me.Controls.Add(Me.pnlProfile)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.pnlAside)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "adminForm"
        Me.Text = "admin"
        Me.pnlAside.ResumeLayout(False)
        Me.pnlAside.PerformLayout()
        Me.pnlProduk.ResumeLayout(False)
        Me.pnlProduk.PerformLayout()
        CType(Me.dgvProduk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlStaff.ResumeLayout(False)
        Me.pnlStaff.PerformLayout()
        Me.pnlProfile.ResumeLayout(False)
        Me.pnlProfile.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlAside As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnPrd As System.Windows.Forms.Button
    Friend WithEvents pnlOnBtnPrd As System.Windows.Forms.Panel
    Friend WithEvents pnlTop As System.Windows.Forms.Panel
    Friend WithEvents pnlOnBtnLgt As System.Windows.Forms.Panel
    Friend WithEvents pnlOnBtnPrf As System.Windows.Forms.Panel
    Friend WithEvents btnLgt As System.Windows.Forms.Button
    Friend WithEvents btnPrf As System.Windows.Forms.Button
    Friend WithEvents pnlOnBtnStf As System.Windows.Forms.Panel
    Friend WithEvents btnStff As System.Windows.Forms.Button
    Friend WithEvents pnlProduk As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pnlStaff As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents pnlProfile As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dgvProduk As System.Windows.Forms.DataGridView
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gambar As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
