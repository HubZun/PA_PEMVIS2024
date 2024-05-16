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
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gambar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pnlStaff = New System.Windows.Forms.Panel()
        Me.txtSearch2 = New System.Windows.Forms.TextBox()
        Me.dgvStaff = New System.Windows.Forms.DataGridView()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnTambahAkun = New System.Windows.Forms.Button()
        Me.pnlProfile = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.pnlAside.SuspendLayout()
        Me.pnlProduk.SuspendLayout()
        CType(Me.dgvProduk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlStaff.SuspendLayout()
        CType(Me.dgvStaff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlProfile.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlAside
        '
        Me.pnlAside.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(72, Byte), Integer))
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
        Me.pnlAside.Name = "pnlAside"
        Me.pnlAside.Size = New System.Drawing.Size(141, 461)
        Me.pnlAside.TabIndex = 0
        '
        'pnlOnBtnLgt
        '
        Me.pnlOnBtnLgt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.pnlOnBtnLgt.Location = New System.Drawing.Point(0, 198)
        Me.pnlOnBtnLgt.Name = "pnlOnBtnLgt"
        Me.pnlOnBtnLgt.Size = New System.Drawing.Size(12, 37)
        Me.pnlOnBtnLgt.TabIndex = 5
        '
        'pnlOnBtnPrf
        '
        Me.pnlOnBtnPrf.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.pnlOnBtnPrf.Location = New System.Drawing.Point(0, 155)
        Me.pnlOnBtnPrf.Name = "pnlOnBtnPrf"
        Me.pnlOnBtnPrf.Size = New System.Drawing.Size(12, 37)
        Me.pnlOnBtnPrf.TabIndex = 5
        '
        'btnLgt
        '
        Me.btnLgt.FlatAppearance.BorderSize = 0
        Me.btnLgt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLgt.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLgt.ForeColor = System.Drawing.SystemColors.Control
        Me.btnLgt.Location = New System.Drawing.Point(0, 198)
        Me.btnLgt.Name = "btnLgt"
        Me.btnLgt.Size = New System.Drawing.Size(141, 37)
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
        Me.btnPrf.Location = New System.Drawing.Point(0, 155)
        Me.btnPrf.Name = "btnPrf"
        Me.btnPrf.Size = New System.Drawing.Size(141, 37)
        Me.btnPrf.TabIndex = 4
        Me.btnPrf.Text = "Profile"
        Me.btnPrf.UseVisualStyleBackColor = True
        '
        'pnlOnBtnStf
        '
        Me.pnlOnBtnStf.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.pnlOnBtnStf.Location = New System.Drawing.Point(0, 112)
        Me.pnlOnBtnStf.Name = "pnlOnBtnStf"
        Me.pnlOnBtnStf.Size = New System.Drawing.Size(12, 37)
        Me.pnlOnBtnStf.TabIndex = 3
        '
        'btnStff
        '
        Me.btnStff.FlatAppearance.BorderSize = 0
        Me.btnStff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStff.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStff.ForeColor = System.Drawing.SystemColors.Control
        Me.btnStff.Location = New System.Drawing.Point(0, 112)
        Me.btnStff.Name = "btnStff"
        Me.btnStff.Size = New System.Drawing.Size(141, 37)
        Me.btnStff.TabIndex = 2
        Me.btnStff.Text = "Staff"
        Me.btnStff.UseVisualStyleBackColor = True
        '
        'pnlOnBtnPrd
        '
        Me.pnlOnBtnPrd.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.pnlOnBtnPrd.Location = New System.Drawing.Point(0, 69)
        Me.pnlOnBtnPrd.Name = "pnlOnBtnPrd"
        Me.pnlOnBtnPrd.Size = New System.Drawing.Size(12, 37)
        Me.pnlOnBtnPrd.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(33, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ADMIN"
        '
        'btnPrd
        '
        Me.btnPrd.FlatAppearance.BorderSize = 0
        Me.btnPrd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrd.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrd.ForeColor = System.Drawing.SystemColors.Control
        Me.btnPrd.Location = New System.Drawing.Point(0, 69)
        Me.btnPrd.Name = "btnPrd"
        Me.btnPrd.Size = New System.Drawing.Size(141, 37)
        Me.btnPrd.TabIndex = 0
        Me.btnPrd.Text = "product"
        Me.btnPrd.UseVisualStyleBackColor = True
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(141, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(613, 29)
        Me.pnlTop.TabIndex = 1
        '
        'pnlProduk
        '
        Me.pnlProduk.Controls.Add(Me.dgvProduk)
        Me.pnlProduk.Controls.Add(Me.txtSearch)
        Me.pnlProduk.Controls.Add(Me.Button1)
        Me.pnlProduk.Controls.Add(Me.Label2)
        Me.pnlProduk.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlProduk.Location = New System.Drawing.Point(141, 29)
        Me.pnlProduk.Name = "pnlProduk"
        Me.pnlProduk.Size = New System.Drawing.Size(613, 432)
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
        Me.dgvProduk.Location = New System.Drawing.Point(18, 83)
        Me.dgvProduk.MultiSelect = False
        Me.dgvProduk.Name = "dgvProduk"
        Me.dgvProduk.ReadOnly = True
        Me.dgvProduk.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgvProduk.RowHeadersVisible = False
        Me.dgvProduk.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.Lime
        Me.dgvProduk.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvProduk.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvProduk.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProduk.Size = New System.Drawing.Size(583, 312)
        Me.dgvProduk.TabIndex = 3
        '
        'Column5
        '
        Me.Column5.HeaderText = "id"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "Nama"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Harga"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "kategori"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Status"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'gambar
        '
        Me.gambar.HeaderText = "gambar"
        Me.gambar.Name = "gambar"
        Me.gambar.ReadOnly = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(446, 44)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(100, 20)
        Me.txtSearch.TabIndex = 2
        Me.txtSearch.Text = "Search..."
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(18, 42)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Add Product"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(274, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Product"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(282, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Staff"
        '
        'pnlStaff
        '
        Me.pnlStaff.Controls.Add(Me.txtSearch2)
        Me.pnlStaff.Controls.Add(Me.dgvStaff)
        Me.pnlStaff.Controls.Add(Me.btnTambahAkun)
        Me.pnlStaff.Controls.Add(Me.Label3)
        Me.pnlStaff.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlStaff.Location = New System.Drawing.Point(141, 29)
        Me.pnlStaff.Name = "pnlStaff"
        Me.pnlStaff.Size = New System.Drawing.Size(613, 432)
        Me.pnlStaff.TabIndex = 3
        Me.pnlStaff.Visible = False
        '
        'txtSearch2
        '
        Me.txtSearch2.Location = New System.Drawing.Point(472, 50)
        Me.txtSearch2.Name = "txtSearch2"
        Me.txtSearch2.Size = New System.Drawing.Size(100, 20)
        Me.txtSearch2.TabIndex = 3
        Me.txtSearch2.Text = "Search....."
        '
        'dgvStaff
        '
        Me.dgvStaff.AllowUserToAddRows = False
        Me.dgvStaff.AllowUserToResizeColumns = False
        Me.dgvStaff.AllowUserToResizeRows = False
        Me.dgvStaff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvStaff.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.dgvStaff.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStaff.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column6, Me.Column7, Me.Column8})
        Me.dgvStaff.Location = New System.Drawing.Point(18, 83)
        Me.dgvStaff.Name = "dgvStaff"
        Me.dgvStaff.RowHeadersVisible = False
        Me.dgvStaff.Size = New System.Drawing.Size(569, 320)
        Me.dgvStaff.TabIndex = 2
        '
        'Column6
        '
        Me.Column6.HeaderText = "Id"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "Nama"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "role"
        Me.Column8.Name = "Column8"
        '
        'btnTambahAkun
        '
        Me.btnTambahAkun.Location = New System.Drawing.Point(18, 48)
        Me.btnTambahAkun.Name = "btnTambahAkun"
        Me.btnTambahAkun.Size = New System.Drawing.Size(99, 23)
        Me.btnTambahAkun.TabIndex = 1
        Me.btnTambahAkun.Text = "Tambah Akun"
        Me.btnTambahAkun.UseVisualStyleBackColor = True
        '
        'pnlProfile
        '
        Me.pnlProfile.Controls.Add(Me.Panel2)
        Me.pnlProfile.Controls.Add(Me.lblUsername)
        Me.pnlProfile.Controls.Add(Me.Panel1)
        Me.pnlProfile.Controls.Add(Me.Label4)
        Me.pnlProfile.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlProfile.Location = New System.Drawing.Point(141, 29)
        Me.pnlProfile.Name = "pnlProfile"
        Me.pnlProfile.Size = New System.Drawing.Size(613, 432)
        Me.pnlProfile.TabIndex = 4
        Me.pnlProfile.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(261, 31)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(117, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Change Password"
        Me.Button2.UseCompatibleTextRendering = True
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(15, 34)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(195, 24)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.Text = "***********"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Password"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(286, 230)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(35, 13)
        Me.lblUsername.TabIndex = 2
        Me.lblUsername.Text = "label7"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.PA_PEMVIS2024.My.Resources.Resources.user_circle_svgrepo_com
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel1.Location = New System.Drawing.Point(225, 63)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(163, 143)
        Me.Panel1.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(277, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Profile"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Location = New System.Drawing.Point(106, 261)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(401, 79)
        Me.Panel2.TabIndex = 5
        '
        'adminForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(754, 461)
        Me.Controls.Add(Me.pnlStaff)
        Me.Controls.Add(Me.pnlProduk)
        Me.Controls.Add(Me.pnlProfile)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.pnlAside)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "adminForm"
        Me.Text = "admin"
        Me.pnlAside.ResumeLayout(False)
        Me.pnlAside.PerformLayout()
        Me.pnlProduk.ResumeLayout(False)
        Me.pnlProduk.PerformLayout()
        CType(Me.dgvProduk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlStaff.ResumeLayout(False)
        Me.pnlStaff.PerformLayout()
        CType(Me.dgvStaff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlProfile.ResumeLayout(False)
        Me.pnlProfile.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
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
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gambar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvStaff As System.Windows.Forms.DataGridView
    Friend WithEvents btnTambahAkun As System.Windows.Forms.Button
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvProduk As System.Windows.Forms.DataGridView
    Friend WithEvents txtSearch2 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
