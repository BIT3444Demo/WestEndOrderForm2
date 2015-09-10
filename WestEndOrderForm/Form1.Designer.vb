<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWestEndOrder
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkTomato = New System.Windows.Forms.CheckBox()
        Me.chkCheese = New System.Windows.Forms.CheckBox()
        Me.radPubBurger = New System.Windows.Forms.RadioButton()
        Me.radHokieClub = New System.Windows.Forms.RadioButton()
        Me.radLobster = New System.Windows.Forms.RadioButton()
        Me.radRibeyeSandwich = New System.Windows.Forms.RadioButton()
        Me.btnOrder = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radSmoothie = New System.Windows.Forms.RadioButton()
        Me.radJuice = New System.Windows.Forms.RadioButton()
        Me.radSoda = New System.Windows.Forms.RadioButton()
        Me.radWater = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chkMozzSticks = New System.Windows.Forms.CheckBox()
        Me.chkFries = New System.Windows.Forms.CheckBox()
        Me.lstOrderReceipt = New System.Windows.Forms.ListBox()
        Me.lstTotal = New System.Windows.Forms.ListBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(13, 13)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(356, 38)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "West End Order Form"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightGray
        Me.GroupBox1.Controls.Add(Me.chkTomato)
        Me.GroupBox1.Controls.Add(Me.chkCheese)
        Me.GroupBox1.Controls.Add(Me.radPubBurger)
        Me.GroupBox1.Controls.Add(Me.radHokieClub)
        Me.GroupBox1.Controls.Add(Me.radLobster)
        Me.GroupBox1.Controls.Add(Me.radRibeyeSandwich)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 79)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(229, 227)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Food"
        '
        'chkTomato
        '
        Me.chkTomato.AutoSize = True
        Me.chkTomato.Location = New System.Drawing.Point(7, 196)
        Me.chkTomato.Name = "chkTomato"
        Me.chkTomato.Size = New System.Drawing.Size(156, 21)
        Me.chkTomato.TabIndex = 5
        Me.chkTomato.Text = "$0.20 - Add Tomato"
        Me.chkTomato.UseVisualStyleBackColor = True
        '
        'chkCheese
        '
        Me.chkCheese.AutoSize = True
        Me.chkCheese.Location = New System.Drawing.Point(7, 168)
        Me.chkCheese.Name = "chkCheese"
        Me.chkCheese.Size = New System.Drawing.Size(156, 21)
        Me.chkCheese.TabIndex = 4
        Me.chkCheese.Text = "$0.50 - Add Cheese"
        Me.chkCheese.UseVisualStyleBackColor = True
        '
        'radPubBurger
        '
        Me.radPubBurger.AutoSize = True
        Me.radPubBurger.Location = New System.Drawing.Point(7, 117)
        Me.radPubBurger.Name = "radPubBurger"
        Me.radPubBurger.Size = New System.Drawing.Size(150, 21)
        Me.radPubBurger.TabIndex = 3
        Me.radPubBurger.TabStop = True
        Me.radPubBurger.Text = "$5.00 - Pub Burger"
        Me.radPubBurger.UseVisualStyleBackColor = True
        '
        'radHokieClub
        '
        Me.radHokieClub.AutoSize = True
        Me.radHokieClub.Location = New System.Drawing.Point(7, 89)
        Me.radHokieClub.Name = "radHokieClub"
        Me.radHokieClub.Size = New System.Drawing.Size(160, 21)
        Me.radHokieClub.TabIndex = 2
        Me.radHokieClub.TabStop = True
        Me.radHokieClub.Text = "$6.50 - HOKIE CLUB"
        Me.radHokieClub.UseVisualStyleBackColor = True
        '
        'radLobster
        '
        Me.radLobster.AutoSize = True
        Me.radLobster.Location = New System.Drawing.Point(7, 61)
        Me.radLobster.Name = "radLobster"
        Me.radLobster.Size = New System.Drawing.Size(145, 21)
        Me.radLobster.TabIndex = 1
        Me.radLobster.TabStop = True
        Me.radLobster.Text = "$22.00 - LoBsTeR"
        Me.radLobster.UseVisualStyleBackColor = True
        '
        'radRibeyeSandwich
        '
        Me.radRibeyeSandwich.AutoSize = True
        Me.radRibeyeSandwich.Location = New System.Drawing.Point(7, 33)
        Me.radRibeyeSandwich.Name = "radRibeyeSandwich"
        Me.radRibeyeSandwich.Size = New System.Drawing.Size(186, 21)
        Me.radRibeyeSandwich.TabIndex = 0
        Me.radRibeyeSandwich.TabStop = True
        Me.radRibeyeSandwich.Text = "$7.50 - Ribeye Sandwich"
        Me.radRibeyeSandwich.UseVisualStyleBackColor = True
        '
        'btnOrder
        '
        Me.btnOrder.Location = New System.Drawing.Point(20, 351)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(134, 41)
        Me.btnOrder.TabIndex = 2
        Me.btnOrder.Text = "&Order"
        Me.btnOrder.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(20, 398)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(134, 41)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(20, 445)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(134, 41)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.LightGray
        Me.GroupBox2.Controls.Add(Me.radSmoothie)
        Me.GroupBox2.Controls.Add(Me.radJuice)
        Me.GroupBox2.Controls.Add(Me.radSoda)
        Me.GroupBox2.Controls.Add(Me.radWater)
        Me.GroupBox2.Location = New System.Drawing.Point(281, 79)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(229, 147)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Drinks"
        '
        'radSmoothie
        '
        Me.radSmoothie.AutoSize = True
        Me.radSmoothie.Location = New System.Drawing.Point(7, 117)
        Me.radSmoothie.Name = "radSmoothie"
        Me.radSmoothie.Size = New System.Drawing.Size(137, 21)
        Me.radSmoothie.TabIndex = 3
        Me.radSmoothie.TabStop = True
        Me.radSmoothie.Text = "$2.50 - Smoothie"
        Me.radSmoothie.UseVisualStyleBackColor = True
        '
        'radJuice
        '
        Me.radJuice.AutoSize = True
        Me.radJuice.Location = New System.Drawing.Point(7, 89)
        Me.radJuice.Name = "radJuice"
        Me.radJuice.Size = New System.Drawing.Size(111, 21)
        Me.radJuice.TabIndex = 2
        Me.radJuice.TabStop = True
        Me.radJuice.Text = "$1.00 - Juice"
        Me.radJuice.UseVisualStyleBackColor = True
        '
        'radSoda
        '
        Me.radSoda.AutoSize = True
        Me.radSoda.Location = New System.Drawing.Point(7, 61)
        Me.radSoda.Name = "radSoda"
        Me.radSoda.Size = New System.Drawing.Size(111, 21)
        Me.radSoda.TabIndex = 1
        Me.radSoda.TabStop = True
        Me.radSoda.Text = "$1.25 - Soda"
        Me.radSoda.UseVisualStyleBackColor = True
        '
        'radWater
        '
        Me.radWater.AutoSize = True
        Me.radWater.Location = New System.Drawing.Point(7, 33)
        Me.radWater.Name = "radWater"
        Me.radWater.Size = New System.Drawing.Size(116, 21)
        Me.radWater.TabIndex = 0
        Me.radWater.TabStop = True
        Me.radWater.Text = "$0.05 - Water"
        Me.radWater.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.LightGray
        Me.GroupBox3.Controls.Add(Me.chkMozzSticks)
        Me.GroupBox3.Controls.Add(Me.chkFries)
        Me.GroupBox3.Location = New System.Drawing.Point(281, 242)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(229, 90)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Sides"
        '
        'chkMozzSticks
        '
        Me.chkMozzSticks.AutoSize = True
        Me.chkMozzSticks.Location = New System.Drawing.Point(7, 61)
        Me.chkMozzSticks.Name = "chkMozzSticks"
        Me.chkMozzSticks.Size = New System.Drawing.Size(188, 21)
        Me.chkMozzSticks.TabIndex = 3
        Me.chkMozzSticks.Text = "$3.00 - Mozzarella Sticks"
        Me.chkMozzSticks.UseVisualStyleBackColor = True
        '
        'chkFries
        '
        Me.chkFries.AutoSize = True
        Me.chkFries.Location = New System.Drawing.Point(7, 33)
        Me.chkFries.Name = "chkFries"
        Me.chkFries.Size = New System.Drawing.Size(158, 21)
        Me.chkFries.TabIndex = 2
        Me.chkFries.Text = "$1.50 - French Fries"
        Me.chkFries.UseVisualStyleBackColor = True
        '
        'lstOrderReceipt
        '
        Me.lstOrderReceipt.FormattingEnabled = True
        Me.lstOrderReceipt.ItemHeight = 16
        Me.lstOrderReceipt.Location = New System.Drawing.Point(281, 348)
        Me.lstOrderReceipt.Name = "lstOrderReceipt"
        Me.lstOrderReceipt.Size = New System.Drawing.Size(229, 116)
        Me.lstOrderReceipt.TabIndex = 7
        '
        'lstTotal
        '
        Me.lstTotal.FormattingEnabled = True
        Me.lstTotal.ItemHeight = 16
        Me.lstTotal.Location = New System.Drawing.Point(281, 471)
        Me.lstTotal.Name = "lstTotal"
        Me.lstTotal.Size = New System.Drawing.Size(229, 52)
        Me.lstTotal.TabIndex = 8
        '
        'frmWestEndOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(593, 542)
        Me.Controls.Add(Me.lstTotal)
        Me.Controls.Add(Me.lstOrderReceipt)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnOrder)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmWestEndOrder"
        Me.Text = "West End Market"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkTomato As System.Windows.Forms.CheckBox
    Friend WithEvents chkCheese As System.Windows.Forms.CheckBox
    Friend WithEvents radPubBurger As System.Windows.Forms.RadioButton
    Friend WithEvents radHokieClub As System.Windows.Forms.RadioButton
    Friend WithEvents radLobster As System.Windows.Forms.RadioButton
    Friend WithEvents radRibeyeSandwich As System.Windows.Forms.RadioButton
    Friend WithEvents btnOrder As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents radSmoothie As System.Windows.Forms.RadioButton
    Friend WithEvents radJuice As System.Windows.Forms.RadioButton
    Friend WithEvents radSoda As System.Windows.Forms.RadioButton
    Friend WithEvents radWater As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents chkMozzSticks As System.Windows.Forms.CheckBox
    Friend WithEvents chkFries As System.Windows.Forms.CheckBox
    Friend WithEvents lstOrderReceipt As System.Windows.Forms.ListBox
    Friend WithEvents lstTotal As System.Windows.Forms.ListBox

End Class
