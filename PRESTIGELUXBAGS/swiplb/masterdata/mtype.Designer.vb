﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mtype
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mtype))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtname = New classlibobjswiplb.txtAlphabet()
        Me.btnrefresh = New classlibobjswiplb.btnRefresh()
        Me.btndelete = New classlibobjswiplb.btnDelete()
        Me.btnsave = New classlibobjswiplb.btnSave()
        Me.btncancel = New classlibobjswiplb.btnCancel()
        Me.txtcode = New classlibobjswiplb.txtAlphabet()
        Me.btnlist = New classlibobjswiplb.btnList()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtnote = New classlibobjswiplb.txtAlphabet()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip6 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip5 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip4 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip3 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeletePhotoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SyncOnlineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExBCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbluseractivity = New System.Windows.Forms.Label()
        Me.ContextMenuStrip6.SuspendLayout()
        Me.ContextMenuStrip5.SuspendLayout()
        Me.ContextMenuStrip4.SuspendLayout()
        Me.ContextMenuStrip3.SuspendLayout()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Code"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name"
        '
        'txtname
        '
        Me.txtname.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.txtname.Location = New System.Drawing.Point(131, 52)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(320, 22)
        Me.txtname.TabIndex = 3
        '
        'btnrefresh
        '
        Me.btnrefresh.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnrefresh.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnrefresh.Image = CType(resources.GetObject("btnrefresh.Image"), System.Drawing.Image)
        Me.btnrefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnrefresh.Location = New System.Drawing.Point(119, 161)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.Size = New System.Drawing.Size(99, 46)
        Me.btnrefresh.TabIndex = 101
        Me.btnrefresh.Text = "Refresh"
        Me.btnrefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnrefresh.UseVisualStyleBackColor = False
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btndelete.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btndelete.Image = CType(resources.GetObject("btndelete.Image"), System.Drawing.Image)
        Me.btndelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btndelete.Location = New System.Drawing.Point(303, 161)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(90, 46)
        Me.btndelete.TabIndex = 103
        Me.btndelete.Text = "Delete"
        Me.btndelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnsave.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnsave.Image = CType(resources.GetObject("btnsave.Image"), System.Drawing.Image)
        Me.btnsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsave.Location = New System.Drawing.Point(17, 161)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(96, 46)
        Me.btnsave.TabIndex = 7
        Me.btnsave.Text = "Save"
        Me.btnsave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btncancel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btncancel.Image = CType(resources.GetObject("btncancel.Image"), System.Drawing.Image)
        Me.btncancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncancel.Location = New System.Drawing.Point(399, 161)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(89, 46)
        Me.btncancel.TabIndex = 105
        Me.btncancel.Text = "Cancel"
        Me.btncancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'txtcode
        '
        Me.txtcode.BackColor = System.Drawing.SystemColors.Window
        Me.txtcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcode.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.txtcode.Location = New System.Drawing.Point(131, 26)
        Me.txtcode.Name = "txtcode"
        Me.txtcode.Size = New System.Drawing.Size(320, 22)
        Me.txtcode.TabIndex = 1
        '
        'btnlist
        '
        Me.btnlist.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnlist.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnlist.Image = CType(resources.GetObject("btnlist.Image"), System.Drawing.Image)
        Me.btnlist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnlist.Location = New System.Drawing.Point(224, 161)
        Me.btnlist.Name = "btnlist"
        Me.btnlist.Size = New System.Drawing.Size(73, 46)
        Me.btnlist.TabIndex = 102
        Me.btnlist.Text = "List"
        Me.btnlist.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnlist.UseVisualStyleBackColor = False
        '
        'txtnote
        '
        Me.txtnote.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.txtnote.Location = New System.Drawing.Point(131, 80)
        Me.txtnote.Multiline = True
        Me.txtnote.Name = "txtnote"
        Me.txtnote.Size = New System.Drawing.Size(320, 46)
        Me.txtnote.TabIndex = 111
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 112
        Me.Label4.Text = "Catatan"
        '
        'ContextMenuStrip6
        '
        Me.ContextMenuStrip6.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem4})
        Me.ContextMenuStrip6.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip6.Size = New System.Drawing.Size(167, 26)
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Image = CType(resources.GetObject("ToolStripMenuItem4.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(166, 22)
        Me.ToolStripMenuItem4.Text = "Lihat Daftar Akun"
        '
        'ContextMenuStrip5
        '
        Me.ContextMenuStrip5.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem3})
        Me.ContextMenuStrip5.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip5.Size = New System.Drawing.Size(143, 26)
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Image = CType(resources.GetObject("ToolStripMenuItem3.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(142, 22)
        Me.ToolStripMenuItem3.Text = "Delete Photo"
        '
        'ContextMenuStrip4
        '
        Me.ContextMenuStrip4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2})
        Me.ContextMenuStrip4.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip4.Size = New System.Drawing.Size(143, 26)
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Image = CType(resources.GetObject("ToolStripMenuItem2.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(142, 22)
        Me.ToolStripMenuItem2.Text = "Delete Photo"
        '
        'ContextMenuStrip3
        '
        Me.ContextMenuStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.ContextMenuStrip3.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip3.Size = New System.Drawing.Size(143, 26)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = CType(resources.GetObject("ToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(142, 22)
        Me.ToolStripMenuItem1.Text = "Delete Photo"
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeletePhotoToolStripMenuItem})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(143, 26)
        '
        'DeletePhotoToolStripMenuItem
        '
        Me.DeletePhotoToolStripMenuItem.Image = CType(resources.GetObject("DeletePhotoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DeletePhotoToolStripMenuItem.Name = "DeletePhotoToolStripMenuItem"
        Me.DeletePhotoToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.DeletePhotoToolStripMenuItem.Text = "Delete Photo"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SyncOnlineToolStripMenuItem, Me.ToolStripSeparator1, Me.ExBCToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(138, 54)
        '
        'SyncOnlineToolStripMenuItem
        '
        Me.SyncOnlineToolStripMenuItem.Image = CType(resources.GetObject("SyncOnlineToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SyncOnlineToolStripMenuItem.Name = "SyncOnlineToolStripMenuItem"
        Me.SyncOnlineToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.SyncOnlineToolStripMenuItem.Text = "Sync Online"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(134, 6)
        '
        'ExBCToolStripMenuItem
        '
        Me.ExBCToolStripMenuItem.Image = CType(resources.GetObject("ExBCToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExBCToolStripMenuItem.Name = "ExBCToolStripMenuItem"
        Me.ExBCToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.ExBCToolStripMenuItem.Text = "Ex BC"
        '
        'lbluseractivity
        '
        Me.lbluseractivity.AutoSize = True
        Me.lbluseractivity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbluseractivity.Location = New System.Drawing.Point(31, 135)
        Me.lbluseractivity.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbluseractivity.Name = "lbluseractivity"
        Me.lbluseractivity.Size = New System.Drawing.Size(94, 15)
        Me.lbluseractivity.TabIndex = 400
        Me.lbluseractivity.Text = "lbluseractivity"
        Me.lbluseractivity.Visible = False
        '
        'mtype
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(514, 228)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtnote)
        Me.Controls.Add(Me.txtcode)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbluseractivity)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btnlist)
        Me.Controls.Add(Me.btnrefresh)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btncancel)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "mtype"
        Me.Text = "Jenis Barang / Type"
        Me.ContextMenuStrip6.ResumeLayout(False)
        Me.ContextMenuStrip5.ResumeLayout(False)
        Me.ContextMenuStrip4.ResumeLayout(False)
        Me.ContextMenuStrip3.ResumeLayout(False)
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtcode As classlibobjswiplb.txtAlphabet
    Friend WithEvents btncancel As classlibobjswiplb.btnCancel
    Friend WithEvents btnsave As classlibobjswiplb.btnSave
    Friend WithEvents btndelete As classlibobjswiplb.btnDelete
    Friend WithEvents btnrefresh As classlibobjswiplb.btnRefresh
    Friend WithEvents txtname As classlibobjswiplb.txtAlphabet
    Friend WithEvents btnlist As classlibobjswiplb.btnList
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents txtnote As classlibobjswiplb.txtAlphabet
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents SyncOnlineToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip2 As ContextMenuStrip
    Friend WithEvents DeletePhotoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip3 As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip4 As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip5 As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ExBCToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip6 As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents lbluseractivity As Label
End Class
