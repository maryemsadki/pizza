<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lstTaille = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rdProp1 = New System.Windows.Forms.RadioButton()
        Me.rdProp2 = New System.Windows.Forms.RadioButton()
        Me.rdProp3 = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ChkProp1 = New System.Windows.Forms.CheckBox()
        Me.ChkProp2 = New System.Windows.Forms.CheckBox()
        Me.ChkProp3 = New System.Windows.Forms.CheckBox()
        Me.ChkProp4 = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_cl = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'lstTaille
        '
        Me.lstTaille.FormattingEnabled = True
        Me.lstTaille.Items.AddRange(New Object() {"petite", "moyenne ", "grande"})
        Me.lstTaille.Location = New System.Drawing.Point(278, 81)
        Me.lstTaille.Name = "lstTaille"
        Me.lstTaille.Size = New System.Drawing.Size(121, 24)
        Me.lstTaille.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(161, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "taille de pizza:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(127, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "type de croute :"
        '
        'rdProp1
        '
        Me.rdProp1.AutoSize = True
        Me.rdProp1.Location = New System.Drawing.Point(278, 145)
        Me.rdProp1.Name = "rdProp1"
        Me.rdProp1.Size = New System.Drawing.Size(92, 20)
        Me.rdProp1.TabIndex = 3
        Me.rdProp1.TabStop = True
        Me.rdProp1.Text = "croute fine "
        Me.rdProp1.UseVisualStyleBackColor = True
        '
        'rdProp2
        '
        Me.rdProp2.AutoSize = True
        Me.rdProp2.Location = New System.Drawing.Point(442, 148)
        Me.rdProp2.Name = "rdProp2"
        Me.rdProp2.Size = New System.Drawing.Size(126, 20)
        Me.rdProp2.TabIndex = 4
        Me.rdProp2.TabStop = True
        Me.rdProp2.Text = "croute classique"
        Me.rdProp2.UseVisualStyleBackColor = True
        '
        'rdProp3
        '
        Me.rdProp3.AutoSize = True
        Me.rdProp3.Location = New System.Drawing.Point(633, 148)
        Me.rdProp3.Name = "rdProp3"
        Me.rdProp3.Size = New System.Drawing.Size(117, 20)
        Me.rdProp3.TabIndex = 5
        Me.rdProp3.TabStop = True
        Me.rdProp3.Text = "croute épaisse"
        Me.rdProp3.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 213)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(200, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "les ingrédients supplementaires:"
        '
        'ChkProp1
        '
        Me.ChkProp1.AutoSize = True
        Me.ChkProp1.Location = New System.Drawing.Point(262, 209)
        Me.ChkProp1.Name = "ChkProp1"
        Me.ChkProp1.Size = New System.Drawing.Size(102, 21)
        Me.ChkProp1.TabIndex = 7
        Me.ChkProp1.Text = "champinions"
        Me.ChkProp1.UseCompatibleTextRendering = True
        Me.ChkProp1.UseVisualStyleBackColor = True
        '
        'ChkProp2
        '
        Me.ChkProp2.AutoSize = True
        Me.ChkProp2.Location = New System.Drawing.Point(442, 208)
        Me.ChkProp2.Name = "ChkProp2"
        Me.ChkProp2.Size = New System.Drawing.Size(61, 21)
        Me.ChkProp2.TabIndex = 8
        Me.ChkProp2.Text = "olives"
        Me.ChkProp2.UseCompatibleTextRendering = True
        Me.ChkProp2.UseVisualStyleBackColor = True
        '
        'ChkProp3
        '
        Me.ChkProp3.AutoSize = True
        Me.ChkProp3.Location = New System.Drawing.Point(262, 278)
        Me.ChkProp3.Name = "ChkProp3"
        Me.ChkProp3.Size = New System.Drawing.Size(78, 21)
        Me.ChkProp3.TabIndex = 9
        Me.ChkProp3.Text = "poivrons"
        Me.ChkProp3.UseCompatibleTextRendering = True
        Me.ChkProp3.UseVisualStyleBackColor = True
        '
        'ChkProp4
        '
        Me.ChkProp4.AutoSize = True
        Me.ChkProp4.Location = New System.Drawing.Point(442, 278)
        Me.ChkProp4.Name = "ChkProp4"
        Me.ChkProp4.Size = New System.Drawing.Size(182, 21)
        Me.ChkProp4.TabIndex = 10
        Me.ChkProp4.Text = "frommage suplémentaires"
        Me.ChkProp4.UseCompatibleTextRendering = True
        Me.ChkProp4.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(75, 352)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 16)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "le récapultatif:"
        '
        'btn_cl
        '
        Me.btn_cl.Location = New System.Drawing.Point(262, 352)
        Me.btn_cl.Name = "btn_cl"
        Me.btn_cl.Size = New System.Drawing.Size(75, 23)
        Me.btn_cl.TabIndex = 14
        Me.btn_cl.Text = "afficher"
        Me.btn_cl.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(418, 321)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(252, 96)
        Me.RichTextBox1.TabIndex = 15
        Me.RichTextBox1.Text = ""
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RosyBrown
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.btn_cl)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ChkProp4)
        Me.Controls.Add(Me.ChkProp3)
        Me.Controls.Add(Me.ChkProp2)
        Me.Controls.Add(Me.ChkProp1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.rdProp3)
        Me.Controls.Add(Me.rdProp2)
        Me.Controls.Add(Me.rdProp1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstTaille)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstTaille As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents rdProp1 As RadioButton
    Friend WithEvents rdProp2 As RadioButton
    Friend WithEvents rdProp3 As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents ChkProp1 As CheckBox
    Friend WithEvents ChkProp2 As CheckBox
    Friend WithEvents ChkProp3 As CheckBox
    Friend WithEvents ChkProp4 As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_cl As Button
    Friend WithEvents RichTextBox1 As RichTextBox
End Class
