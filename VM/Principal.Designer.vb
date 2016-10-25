<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.btnExecuta = New System.Windows.Forms.Button
        Me.txtBx = New System.Windows.Forms.TextBox
        Me.txtCx = New System.Windows.Forms.TextBox
        Me.txtSp = New System.Windows.Forms.TextBox
        Me.txtBp = New System.Windows.Forms.TextBox
        Me.txtIp = New System.Windows.Forms.TextBox
        Me.txtAx = New System.Windows.Forms.TextBox
        Me.txtOut = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtIn = New System.Windows.Forms.TextBox
        Me.btnAdicionaInstrucao = New System.Windows.Forms.Button
        Me.btnPassoAPasso = New System.Windows.Forms.Button
        Me.dtgListaMemoria = New System.Windows.Forms.DataGridView
        Me.Indice = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Valor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Nome = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.cboInstructions = New System.Windows.Forms.ComboBox
        Me.dtgInstrucoes = New System.Windows.Forms.DataGridView
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtValorX = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.btnCarregar = New System.Windows.Forms.Button
        Me.btnExcluir = New System.Windows.Forms.Button
        Me.btnReiniciar = New System.Windows.Forms.Button
        Me.btnExercicio8 = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnVersao11 = New System.Windows.Forms.Button
        Me.btnPrograma2 = New System.Windows.Forms.Button
        Me.btnPrograma1 = New System.Windows.Forms.Button
        Me.Label12 = New System.Windows.Forms.Label
        Me.lblTempoExecucao = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtACada = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtIpMaiorQue = New System.Windows.Forms.TextBox
        CType(Me.dtgListaMemoria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgInstrucoes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExecuta
        '
        Me.btnExecuta.Location = New System.Drawing.Point(536, 359)
        Me.btnExecuta.Name = "btnExecuta"
        Me.btnExecuta.Size = New System.Drawing.Size(95, 23)
        Me.btnExecuta.TabIndex = 0
        Me.btnExecuta.Text = "Executa"
        Me.btnExecuta.UseVisualStyleBackColor = True
        '
        'txtBx
        '
        Me.txtBx.Location = New System.Drawing.Point(531, 226)
        Me.txtBx.Name = "txtBx"
        Me.txtBx.Size = New System.Drawing.Size(100, 20)
        Me.txtBx.TabIndex = 1
        Me.txtBx.Text = "0"
        '
        'txtCx
        '
        Me.txtCx.Location = New System.Drawing.Point(531, 252)
        Me.txtCx.Name = "txtCx"
        Me.txtCx.Size = New System.Drawing.Size(100, 20)
        Me.txtCx.TabIndex = 2
        Me.txtCx.Text = "0"
        '
        'txtSp
        '
        Me.txtSp.Location = New System.Drawing.Point(531, 304)
        Me.txtSp.Name = "txtSp"
        Me.txtSp.Size = New System.Drawing.Size(100, 20)
        Me.txtSp.TabIndex = 3
        Me.txtSp.Text = "0"
        '
        'txtBp
        '
        Me.txtBp.Location = New System.Drawing.Point(531, 278)
        Me.txtBp.Name = "txtBp"
        Me.txtBp.Size = New System.Drawing.Size(100, 20)
        Me.txtBp.TabIndex = 4
        Me.txtBp.Text = "0"
        '
        'txtIp
        '
        Me.txtIp.Location = New System.Drawing.Point(531, 174)
        Me.txtIp.Name = "txtIp"
        Me.txtIp.Size = New System.Drawing.Size(100, 20)
        Me.txtIp.TabIndex = 5
        Me.txtIp.Text = "0"
        '
        'txtAx
        '
        Me.txtAx.Location = New System.Drawing.Point(531, 200)
        Me.txtAx.Name = "txtAx"
        Me.txtAx.Size = New System.Drawing.Size(100, 20)
        Me.txtAx.TabIndex = 6
        Me.txtAx.Text = "0"
        '
        'txtOut
        '
        Me.txtOut.Location = New System.Drawing.Point(486, 28)
        Me.txtOut.Multiline = True
        Me.txtOut.Name = "txtOut"
        Me.txtOut.Size = New System.Drawing.Size(145, 84)
        Me.txtOut.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(483, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Monitor (out)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(311, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Programa - Instruções"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(483, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Teclado (in)"
        '
        'txtIn
        '
        Me.txtIn.Location = New System.Drawing.Point(486, 131)
        Me.txtIn.Name = "txtIn"
        Me.txtIn.Size = New System.Drawing.Size(145, 20)
        Me.txtIn.TabIndex = 13
        Me.txtIn.Text = "0"
        '
        'btnAdicionaInstrucao
        '
        Me.btnAdicionaInstrucao.Location = New System.Drawing.Point(311, 398)
        Me.btnAdicionaInstrucao.Name = "btnAdicionaInstrucao"
        Me.btnAdicionaInstrucao.Size = New System.Drawing.Size(166, 23)
        Me.btnAdicionaInstrucao.TabIndex = 14
        Me.btnAdicionaInstrucao.Text = "Adiciona Instrução"
        Me.btnAdicionaInstrucao.UseVisualStyleBackColor = True
        '
        'btnPassoAPasso
        '
        Me.btnPassoAPasso.Location = New System.Drawing.Point(536, 388)
        Me.btnPassoAPasso.Name = "btnPassoAPasso"
        Me.btnPassoAPasso.Size = New System.Drawing.Size(95, 23)
        Me.btnPassoAPasso.TabIndex = 15
        Me.btnPassoAPasso.Text = "Passo a Passo"
        Me.btnPassoAPasso.UseVisualStyleBackColor = True
        '
        'dtgListaMemoria
        '
        Me.dtgListaMemoria.AllowUserToAddRows = False
        Me.dtgListaMemoria.AllowUserToDeleteRows = False
        Me.dtgListaMemoria.AllowUserToOrderColumns = True
        Me.dtgListaMemoria.AllowUserToResizeColumns = False
        Me.dtgListaMemoria.AllowUserToResizeRows = False
        Me.dtgListaMemoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgListaMemoria.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Indice, Me.Valor, Me.Nome})
        Me.dtgListaMemoria.Location = New System.Drawing.Point(12, 12)
        Me.dtgListaMemoria.Name = "dtgListaMemoria"
        Me.dtgListaMemoria.ReadOnly = True
        Me.dtgListaMemoria.RowHeadersVisible = False
        Me.dtgListaMemoria.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dtgListaMemoria.Size = New System.Drawing.Size(293, 438)
        Me.dtgListaMemoria.TabIndex = 18
        '
        'Indice
        '
        Me.Indice.DataPropertyName = "Indice"
        DataGridViewCellStyle1.NullValue = "Null"
        Me.Indice.DefaultCellStyle = DataGridViewCellStyle1
        Me.Indice.HeaderText = "Indice"
        Me.Indice.Name = "Indice"
        Me.Indice.ReadOnly = True
        Me.Indice.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Indice.Width = 70
        '
        'Valor
        '
        Me.Valor.DataPropertyName = "Valor"
        Me.Valor.HeaderText = "Valor"
        Me.Valor.Name = "Valor"
        Me.Valor.ReadOnly = True
        Me.Valor.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Valor.Width = 70
        '
        'Nome
        '
        Me.Nome.DataPropertyName = "Nome"
        Me.Nome.HeaderText = "Significado"
        Me.Nome.Name = "Nome"
        Me.Nome.ReadOnly = True
        Me.Nome.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Nome.Width = 130
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(507, 203)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "ax"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(507, 229)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "bx"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(507, 255)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(18, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "cx"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(507, 307)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(18, 13)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "sp"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(506, 281)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(19, 13)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "bp"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(510, 177)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(15, 13)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "ip"
        '
        'cboInstructions
        '
        Me.cboInstructions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboInstructions.Location = New System.Drawing.Point(311, 28)
        Me.cboInstructions.Name = "cboInstructions"
        Me.cboInstructions.Size = New System.Drawing.Size(100, 21)
        Me.cboInstructions.TabIndex = 25
        '
        'dtgInstrucoes
        '
        Me.dtgInstrucoes.AllowUserToAddRows = False
        Me.dtgInstrucoes.AllowUserToDeleteRows = False
        Me.dtgInstrucoes.AllowUserToOrderColumns = True
        Me.dtgInstrucoes.AllowUserToResizeColumns = False
        Me.dtgInstrucoes.AllowUserToResizeRows = False
        Me.dtgInstrucoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgInstrucoes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.DataGridViewTextBoxColumn1})
        Me.dtgInstrucoes.Location = New System.Drawing.Point(311, 55)
        Me.dtgInstrucoes.Name = "dtgInstrucoes"
        Me.dtgInstrucoes.ReadOnly = True
        Me.dtgInstrucoes.RowHeadersVisible = False
        Me.dtgInstrucoes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dtgInstrucoes.Size = New System.Drawing.Size(169, 337)
        Me.dtgInstrucoes.TabIndex = 26
        '
        'Codigo
        '
        Me.Codigo.DataPropertyName = "Codigo"
        Me.Codigo.HeaderText = "Instr."
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        Me.Codigo.Width = 50
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Nome"
        DataGridViewCellStyle2.NullValue = "Null"
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn1.HeaderText = "Fila instr."
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(417, 31)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(17, 13)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "X:"
        '
        'txtValorX
        '
        Me.txtValorX.Location = New System.Drawing.Point(440, 28)
        Me.txtValorX.MaxLength = 2
        Me.txtValorX.Name = "txtValorX"
        Me.txtValorX.Size = New System.Drawing.Size(40, 20)
        Me.txtValorX.TabIndex = 28
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 453)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(129, 13)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Aluno: Eduardo F. Gadotti"
        '
        'btnCarregar
        '
        Me.btnCarregar.Location = New System.Drawing.Point(536, 330)
        Me.btnCarregar.Name = "btnCarregar"
        Me.btnCarregar.Size = New System.Drawing.Size(95, 23)
        Me.btnCarregar.TabIndex = 30
        Me.btnCarregar.Text = "Carregar"
        Me.btnCarregar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Location = New System.Drawing.Point(311, 427)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(166, 23)
        Me.btnExcluir.TabIndex = 31
        Me.btnExcluir.Text = "Retira Último"
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnReiniciar
        '
        Me.btnReiniciar.Location = New System.Drawing.Point(536, 414)
        Me.btnReiniciar.Name = "btnReiniciar"
        Me.btnReiniciar.Size = New System.Drawing.Size(95, 23)
        Me.btnReiniciar.TabIndex = 32
        Me.btnReiniciar.Text = "Reiniciar"
        Me.btnReiniciar.UseVisualStyleBackColor = True
        '
        'btnExercicio8
        '
        Me.btnExercicio8.Location = New System.Drawing.Point(6, 19)
        Me.btnExercicio8.Name = "btnExercicio8"
        Me.btnExercicio8.Size = New System.Drawing.Size(119, 23)
        Me.btnExercicio8.TabIndex = 33
        Me.btnExercicio8.Text = "Exercicio 8"
        Me.btnExercicio8.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnVersao11)
        Me.GroupBox1.Controls.Add(Me.btnPrograma2)
        Me.GroupBox1.Controls.Add(Me.btnPrograma1)
        Me.GroupBox1.Controls.Add(Me.btnExercicio8)
        Me.GroupBox1.Location = New System.Drawing.Point(640, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(132, 380)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Exercícios"
        '
        'btnVersao11
        '
        Me.btnVersao11.Location = New System.Drawing.Point(7, 107)
        Me.btnVersao11.Name = "btnVersao11"
        Me.btnVersao11.Size = New System.Drawing.Size(118, 24)
        Me.btnVersao11.TabIndex = 36
        Me.btnVersao11.Text = "Versão 11"
        Me.btnVersao11.UseVisualStyleBackColor = True
        '
        'btnPrograma2
        '
        Me.btnPrograma2.Location = New System.Drawing.Point(7, 78)
        Me.btnPrograma2.Name = "btnPrograma2"
        Me.btnPrograma2.Size = New System.Drawing.Size(118, 23)
        Me.btnPrograma2.TabIndex = 35
        Me.btnPrograma2.Text = "Programa 2"
        Me.btnPrograma2.UseVisualStyleBackColor = True
        '
        'btnPrograma1
        '
        Me.btnPrograma1.Location = New System.Drawing.Point(6, 48)
        Me.btnPrograma1.Name = "btnPrograma1"
        Me.btnPrograma1.Size = New System.Drawing.Size(119, 23)
        Me.btnPrograma1.TabIndex = 34
        Me.btnPrograma1.Text = "Programa 1"
        Me.btnPrograma1.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(522, 450)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(109, 13)
        Me.Label12.TabIndex = 35
        Me.Label12.Text = "Tempo de Execução:"
        '
        'lblTempoExecucao
        '
        Me.lblTempoExecucao.AutoSize = True
        Me.lblTempoExecucao.Location = New System.Drawing.Point(637, 450)
        Me.lblTempoExecucao.Name = "lblTempoExecucao"
        Me.lblTempoExecucao.Size = New System.Drawing.Size(29, 13)
        Me.lblTempoExecucao.TabIndex = 36
        Me.lblTempoExecucao.Text = "0 ms"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(637, 398)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(60, 13)
        Me.Label13.TabIndex = 37
        Me.Label13.Text = "int3 a cada"
        '
        'txtACada
        '
        Me.txtACada.Location = New System.Drawing.Point(696, 395)
        Me.txtACada.Name = "txtACada"
        Me.txtACada.Size = New System.Drawing.Size(21, 20)
        Me.txtACada.TabIndex = 38
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(720, 398)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(55, 13)
        Me.Label14.TabIndex = 39
        Me.Label14.Text = "instruções"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(643, 419)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(51, 13)
        Me.Label15.TabIndex = 40
        Me.Label15.Text = "após Ip ="
        '
        'txtIpMaiorQue
        '
        Me.txtIpMaiorQue.Location = New System.Drawing.Point(696, 416)
        Me.txtIpMaiorQue.Name = "txtIpMaiorQue"
        Me.txtIpMaiorQue.Size = New System.Drawing.Size(34, 20)
        Me.txtIpMaiorQue.TabIndex = 41
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(783, 472)
        Me.Controls.Add(Me.txtIpMaiorQue)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtACada)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lblTempoExecucao)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnReiniciar)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnCarregar)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtValorX)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.dtgInstrucoes)
        Me.Controls.Add(Me.cboInstructions)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtgListaMemoria)
        Me.Controls.Add(Me.btnPassoAPasso)
        Me.Controls.Add(Me.btnAdicionaInstrucao)
        Me.Controls.Add(Me.txtIn)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtOut)
        Me.Controls.Add(Me.txtAx)
        Me.Controls.Add(Me.txtIp)
        Me.Controls.Add(Me.txtBp)
        Me.Controls.Add(Me.txtSp)
        Me.Controls.Add(Me.txtCx)
        Me.Controls.Add(Me.txtBx)
        Me.Controls.Add(Me.btnExecuta)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Máquina Virtual"
        CType(Me.dtgListaMemoria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgInstrucoes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExecuta As System.Windows.Forms.Button
    Friend WithEvents txtBx As System.Windows.Forms.TextBox
    Friend WithEvents txtCx As System.Windows.Forms.TextBox
    Friend WithEvents txtSp As System.Windows.Forms.TextBox
    Friend WithEvents txtBp As System.Windows.Forms.TextBox
    Friend WithEvents txtIp As System.Windows.Forms.TextBox
    Friend WithEvents txtAx As System.Windows.Forms.TextBox
    Friend WithEvents txtOut As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtIn As System.Windows.Forms.TextBox
    Friend WithEvents btnAdicionaInstrucao As System.Windows.Forms.Button
    Friend WithEvents btnPassoAPasso As System.Windows.Forms.Button
    Friend WithEvents dtgListaMemoria As System.Windows.Forms.DataGridView
    Friend WithEvents Indice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Valor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nome As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cboInstructions As System.Windows.Forms.ComboBox
    Friend WithEvents dtgInstrucoes As System.Windows.Forms.DataGridView
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtValorX As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnCarregar As System.Windows.Forms.Button
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents btnReiniciar As System.Windows.Forms.Button
    Friend WithEvents btnExercicio8 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnPrograma1 As System.Windows.Forms.Button
    Friend WithEvents btnPrograma2 As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblTempoExecucao As System.Windows.Forms.Label
    Friend WithEvents btnVersao11 As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtACada As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtIpMaiorQue As System.Windows.Forms.TextBox


End Class
