Public Class Principal

    Dim objVirtualMachine As VirtualMachine
    Dim gListaInstrucoes As New List(Of Instructions)

    Private Sub Principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Instancia objeto da máquina virtual
            objVirtualMachine = New VirtualMachine
            Dim objInstrucoes As New Instructions

            'Carrega dados no grid
            dtgListaMemoria.DataSource = objVirtualMachine.ListaMemoriaVazia
            dtgListaMemoria.AutoGenerateColumns = False

            'Carrega a lista de instruções no combo
            cboInstructions.DataSource = objInstrucoes.ListaInstructions
            dtgInstrucoes.AutoGenerateColumns = False

        Catch wrkErro As Exception
            MsgBox(wrkErro.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Function ValidaEntradas() As Boolean

        If Not IsNumeric(txtIp.Text) Then
            MsgBox("Valor ip deve ser numérico", MsgBoxStyle.Critical, "Validação de campos")
            Return False
        End If
        If Not IsNumeric(txtAx.Text) Then
            MsgBox("Valor ax deve ser numérico", MsgBoxStyle.Critical, "Validação de campos")
            Return False
        End If
        If Not IsNumeric(txtBx.Text) Then
            MsgBox("Valor bx deve ser numérico", MsgBoxStyle.Critical, "Validação de campos")
            Return False
        End If
        If Not IsNumeric(txtCx.Text) Then
            MsgBox("Valor cx deve ser numérico", MsgBoxStyle.Critical, "Validação de campos")
            Return False
        End If
        If Not IsNumeric(txtBp.Text) Then
            MsgBox("Valor bp deve ser numérico", MsgBoxStyle.Critical, "Validação de campos")
            Return False
        End If
        If Not IsNumeric(txtSp.Text) Then
            MsgBox("Valor sp deve ser numérico", MsgBoxStyle.Critical, "Validação de campos")
            Return False
        End If
        If Not IsNumeric(txtIn.Text) Then
            MsgBox("Valor 'Teclado (In)' deve ser numérico", MsgBoxStyle.Critical, "Validação de campos")
            Return False
        End If
        If gListaInstrucoes.Count > 0 Then
            If gListaInstrucoes(gListaInstrucoes.Count - 1).Codigo <> 40 Then
                If MsgBox("A última instrução não é 'halt'. Deseja continuar mesmo assim?", MsgBoxStyle.YesNo, "Validação de campos") = MsgBoxResult.Yes Then
                    Return True
                Else
                    Return False
                End If
            End If
        Else
            MsgBox("Carregue uma lista de instruções primeiramente!", MsgBoxStyle.Critical, "Validação de campos")
            Return False
        End If
        Return True
    End Function

    

    Private Sub btnAdicionaInstrucao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdicionaInstrucao.Click
        'Enfilera a lista de instruções
        Try
            'Verifica se existe item selecionado no combo
            If cboInstructions.SelectedItem IsNot Nothing Then
                If IsNumeric(txtValorX.Text) OrElse txtValorX.Text.Trim = String.Empty Then
                    'Obtem objeto selecionado
                    Dim objItemSelecionado As Instructions = cboInstructions.SelectedItem
                    Dim objInstructions As New Instructions
                    objInstructions.Codigo = objItemSelecionado.Codigo

                    'Coloca o valor de X caso for digitado e se é necessário guarda-lo
                    If Memoria.InstrucaoComParametro(objInstructions.Codigo) Then
                        If Not String.IsNullOrEmpty(txtValorX.Text.Trim) AndAlso IsNumeric(txtValorX.Text.Trim) Then
                            objInstructions.ValorX = Convert.ToInt32(txtValorX.Text.Trim)
                        Else
                            MsgBox("Para esta instrução é necessário informar um valor para X!", MsgBoxStyle.Critical)
                            Return
                        End If
                    End If

                    'Adiciona objeto na colação
                    gListaInstrucoes.Add(objInstructions)

                    'Carrega novamente o grid de lista de instruções            
                    dtgInstrucoes.DataSource = Nothing
                    dtgInstrucoes.DataSource = gListaInstrucoes

                    'Limpa valor de X
                    txtValorX.Text = ""
                Else
                    MsgBox("Valor de X deve ser numérico!", MsgBoxStyle.Critical)
                End If
            End If

        Catch wrkErro As Exception
            MsgBox(wrkErro.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnCarregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCarregar.Click
        Dim objInstrucao As Instructions = Nothing

        Try
            'Instancia objeto da máquina virtual
            objVirtualMachine = New VirtualMachine
            objVirtualMachine.ListaMemoriaVazia()
            dtgListaMemoria.DataSource = Nothing

            'Carrega para memoria
            objVirtualMachine.CarregaMemoria(gListaInstrucoes)

            'Carrega dados no grid
            dtgListaMemoria.DataSource = objVirtualMachine.ListaMemoria

        Catch wrkErro As Exception
            MsgBox(wrkErro.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        Try
            If gListaInstrucoes.Count > 0 Then
                'Retira o ultimo da lista
                gListaInstrucoes.Remove(gListaInstrucoes(gListaInstrucoes.Count - 1))

                'Carrega novamente o grid
                dtgInstrucoes.DataSource = Nothing
                dtgInstrucoes.DataSource = gListaInstrucoes
            End If
        Catch wrkErro As Exception
            MsgBox(wrkErro.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnReiniciar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReiniciar.Click
        Try
            'Instancia objeto da máquina virtual
            objVirtualMachine = New VirtualMachine

            'Carrega dados no grid
            dtgListaMemoria.DataSource = objVirtualMachine.ListaMemoriaVazia

            gListaInstrucoes = New List(Of Instructions)
            dtgInstrucoes.DataSource = Nothing

            txtAx.Text = "0"
            txtBp.Text = "0"
            txtBx.Text = "0"
            txtCx.Text = "0"
            txtIn.Text = "0"
            txtIp.Text = "0"
            txtOut.Text = ""
            txtSp.Text = "0"
            txtValorX.Text = ""

            lblTempoExecucao.Text = ""

        Catch wrkErro As Exception
            MsgBox(wrkErro.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnExecuta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExecuta.Click
        Try
            'Obtem Inicio do programa
            Dim wrkDtInicio As Date = Now
            'Executa Maquina
            ExecutaMaquina()

            'Obtem tempo atual e calcula tempo de execução
            Dim wrkTimeSpan As TimeSpan = Now.Subtract(wrkDtInicio)

            lblTempoExecucao.Text = wrkTimeSpan.ToString

        Catch wrkErro As Exception
            MsgBox(wrkErro.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnPassoAPasso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPassoAPasso.Click
        Try
            ExecutaMaquina(True)
            lblTempoExecucao.Text = ""
        Catch wrkErro As Exception
            MsgBox(wrkErro.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub ExecutaMaquina(Optional ByVal pFgPassoAPasso As Boolean = False)
        If ValidaEntradas() Then
            'Simula botão carrega para garantir
            btnCarregar_Click(Nothing, Nothing)

            'Seta variaveis iniciais
            objVirtualMachine.ip = Convert.ToInt32(txtIp.Text)
            objVirtualMachine.ax = Convert.ToInt32(txtAx.Text)
            objVirtualMachine.bx = Convert.ToInt32(txtBx.Text)
            objVirtualMachine.cx = Convert.ToInt32(txtCx.Text)
            objVirtualMachine.bp = Convert.ToInt32(txtBp.Text)
            objVirtualMachine.sp = Convert.ToInt32(txtSp.Text)
            objVirtualMachine.TecladoIn = txtIn.Text
            objVirtualMachine.PassoAPasso = pFgPassoAPasso

            If txtACada.Text.Trim <> "" AndAlso txtIpMaiorQue.Text.Trim() Then
                objVirtualMachine.SimulaInt3 = True
                objVirtualMachine.ACada = Convert.ToInt32(txtACada.Text)
                objVirtualMachine.IpMaiorQue = Convert.ToInt32(txtIpMaiorQue.Text)
            Else
                objVirtualMachine.SimulaInt3 = False
            End If
            '======================

            'Percorre a memória para executar as instruções.
            objVirtualMachine.ExecutaInstrucoes()
            '==================================

            'Atualiza variáveis
            txtOut.Text = objVirtualMachine.Saida
            txtIp.Text = objVirtualMachine.ip
            txtAx.Text = objVirtualMachine.ax
            txtBx.Text = objVirtualMachine.bx
            txtCx.Text = objVirtualMachine.cx
            txtBp.Text = objVirtualMachine.bp
            txtSp.Text = objVirtualMachine.sp
            '=============

            'Mensage final
            MsgBox("Executado com sucesso!", MsgBoxStyle.OkOnly)
        End If
    End Sub

    Private Sub CarregaExercicio8()

        gListaInstrucoes.Add(New Instructions(39))
        gListaInstrucoes.Add(New Instructions(39))
        gListaInstrucoes.Add(New Instructions(39))
        gListaInstrucoes.Add(New Instructions(39))

        gListaInstrucoes.Add(New Instructions(39))

        gListaInstrucoes.Add(New Instructions(39))
        gListaInstrucoes.Add(New Instructions(39))
        gListaInstrucoes.Add(New Instructions(39))
        gListaInstrucoes.Add(New Instructions(39))
        gListaInstrucoes.Add(New Instructions(39))
        gListaInstrucoes.Add(New Instructions(0))
        gListaInstrucoes.Add(New Instructions(45, 161))
        gListaInstrucoes.Add(New Instructions(9, 0))
        gListaInstrucoes.Add(New Instructions(45, 161))
        gListaInstrucoes.Add(New Instructions(9, 1))
        gListaInstrucoes.Add(New Instructions(45, 161))
        gListaInstrucoes.Add(New Instructions(9, 2))
        gListaInstrucoes.Add(New Instructions(45, 161))
        gListaInstrucoes.Add(New Instructions(9, 3))

        gListaInstrucoes.Add(New Instructions(39))
        gListaInstrucoes.Add(New Instructions(39))

        gListaInstrucoes.Add(New Instructions(45, 240))
        gListaInstrucoes.Add(New Instructions(9, 5))
        gListaInstrucoes.Add(New Instructions(45, 200))
        gListaInstrucoes.Add(New Instructions(9, 6))
        gListaInstrucoes.Add(New Instructions(45, 180))
        gListaInstrucoes.Add(New Instructions(9, 7))
        gListaInstrucoes.Add(New Instructions(45, 160))
        gListaInstrucoes.Add(New Instructions(9, 8))
        gListaInstrucoes.Add(New Instructions(45, 250))
        gListaInstrucoes.Add(New Instructions(9, 4))

        gListaInstrucoes.Add(New Instructions(39))
        gListaInstrucoes.Add(New Instructions(39))

        gListaInstrucoes.Add(New Instructions(5, 5))
        gListaInstrucoes.Add(New Instructions(31))
        gListaInstrucoes.Add(New Instructions(35))
        gListaInstrucoes.Add(New Instructions(12))
        gListaInstrucoes.Add(New Instructions(5, 0))
        gListaInstrucoes.Add(New Instructions(31))
        gListaInstrucoes.Add(New Instructions(0))
        gListaInstrucoes.Add(New Instructions(31))
        gListaInstrucoes.Add(New Instructions(31))
        gListaInstrucoes.Add(New Instructions(32))
        gListaInstrucoes.Add(New Instructions(33))
        gListaInstrucoes.Add(New Instructions(11))
        gListaInstrucoes.Add(New Instructions(34))
        gListaInstrucoes.Add(New Instructions(38))
        gListaInstrucoes.Add(New Instructions(9, 5))
        gListaInstrucoes.Add(New Instructions(39))

        gListaInstrucoes.Add(New Instructions(5, 6))
        gListaInstrucoes.Add(New Instructions(31))
        gListaInstrucoes.Add(New Instructions(35))
        gListaInstrucoes.Add(New Instructions(12))
        gListaInstrucoes.Add(New Instructions(5, 1))
        gListaInstrucoes.Add(New Instructions(31))
        gListaInstrucoes.Add(New Instructions(0))
        gListaInstrucoes.Add(New Instructions(31))
        gListaInstrucoes.Add(New Instructions(31))
        gListaInstrucoes.Add(New Instructions(32))
        gListaInstrucoes.Add(New Instructions(33))
        gListaInstrucoes.Add(New Instructions(11))
        gListaInstrucoes.Add(New Instructions(34))
        gListaInstrucoes.Add(New Instructions(38))
        gListaInstrucoes.Add(New Instructions(9, 6))
        gListaInstrucoes.Add(New Instructions(39))

        gListaInstrucoes.Add(New Instructions(5, 7))
        gListaInstrucoes.Add(New Instructions(31))
        gListaInstrucoes.Add(New Instructions(35))
        gListaInstrucoes.Add(New Instructions(12))
        gListaInstrucoes.Add(New Instructions(5, 2))
        gListaInstrucoes.Add(New Instructions(31))
        gListaInstrucoes.Add(New Instructions(0))
        gListaInstrucoes.Add(New Instructions(31))
        gListaInstrucoes.Add(New Instructions(31))
        gListaInstrucoes.Add(New Instructions(32))
        gListaInstrucoes.Add(New Instructions(33))
        gListaInstrucoes.Add(New Instructions(11))
        gListaInstrucoes.Add(New Instructions(34))
        gListaInstrucoes.Add(New Instructions(38))
        gListaInstrucoes.Add(New Instructions(9, 7))
        gListaInstrucoes.Add(New Instructions(39))

        gListaInstrucoes.Add(New Instructions(5, 8))
        gListaInstrucoes.Add(New Instructions(31))
        gListaInstrucoes.Add(New Instructions(35))
        gListaInstrucoes.Add(New Instructions(12))
        gListaInstrucoes.Add(New Instructions(5, 3))
        gListaInstrucoes.Add(New Instructions(31))
        gListaInstrucoes.Add(New Instructions(0))
        gListaInstrucoes.Add(New Instructions(31))
        gListaInstrucoes.Add(New Instructions(31))
        gListaInstrucoes.Add(New Instructions(32))
        gListaInstrucoes.Add(New Instructions(33))
        gListaInstrucoes.Add(New Instructions(11))
        gListaInstrucoes.Add(New Instructions(34))
        gListaInstrucoes.Add(New Instructions(38))
        gListaInstrucoes.Add(New Instructions(9, 8))
        gListaInstrucoes.Add(New Instructions(39))

        gListaInstrucoes.Add(New Instructions(39))
        gListaInstrucoes.Add(New Instructions(5, 4))
        gListaInstrucoes.Add(New Instructions(31))
        gListaInstrucoes.Add(New Instructions(35))
        gListaInstrucoes.Add(New Instructions(12))
        gListaInstrucoes.Add(New Instructions(39))
        gListaInstrucoes.Add(New Instructions(39))
        gListaInstrucoes.Add(New Instructions(39))

        gListaInstrucoes.Add(New Instructions(0))
        gListaInstrucoes.Add(New Instructions(9, 9))
        gListaInstrucoes.Add(New Instructions(5, 9))
        gListaInstrucoes.Add(New Instructions(3))
        gListaInstrucoes.Add(New Instructions(45, 0))
        gListaInstrucoes.Add(New Instructions(46, 156))
        gListaInstrucoes.Add(New Instructions(45, 1))
        gListaInstrucoes.Add(New Instructions(46, 156))
        gListaInstrucoes.Add(New Instructions(45, 2))
        gListaInstrucoes.Add(New Instructions(46, 156))
        gListaInstrucoes.Add(New Instructions(0))
        gListaInstrucoes.Add(New Instructions(9))
        gListaInstrucoes.Add(New Instructions(9))
        gListaInstrucoes.Add(New Instructions(26, 160))
        gListaInstrucoes.Add(New Instructions(20))
        gListaInstrucoes.Add(New Instructions(1))
        gListaInstrucoes.Add(New Instructions(9, 9))
        gListaInstrucoes.Add(New Instructions(40))
        gListaInstrucoes.Add(New Instructions(26, 161))



    End Sub

    Private Sub btnExercicio8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExercicio8.Click
        CarregaExercicio8()
        dtgInstrucoes.DataSource = Nothing
        dtgInstrucoes.DataSource = gListaInstrucoes
    End Sub

    Private Sub btnPrograma1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrograma1.Click
        'byte a;
        'main
        '   a=0
        '   a=a+1
        '   mostra(a)
        'end;

        gListaInstrucoes.Add(New Instructions(39)) 'Reserva espaço para a memoria
        gListaInstrucoes.Add(New Instructions(0)) 'Inicia ax
        gListaInstrucoes.Add(New Instructions(9, 0)) 'Move ax para espaço da variavel
        gListaInstrucoes.Add(New Instructions(5, 0)) 'Move para o ax o valor da variavel
        gListaInstrucoes.Add(New Instructions(19)) 'Incrementa ax
        gListaInstrucoes.Add(New Instructions(9, 0)) 'Move para para o espaço da variavel o valor de ax
        gListaInstrucoes.Add(New Instructions(5, 0)) 'Move para ax o que esta no espaço da variavel
        gListaInstrucoes.Add(New Instructions(30)) 'Out ax
        gListaInstrucoes.Add(New Instructions(40)) 'halt = termina
        dtgInstrucoes.DataSource = Nothing
        dtgInstrucoes.DataSource = gListaInstrucoes
    End Sub

    Private Sub btnPrograma2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrograma2.Click
        'Apelidos de endereço de memoria sao variavel e procedures

        'byte a;
        'procedure zera(byte a) {
        '   a=0
        'end (ret)
        'main
        '   a=10;
        '   mostra(a);
        '   zera(a) -- call
        '   mostra(a)
        'end

        gListaInstrucoes.Add(New Instructions(39)) 'Reserva espaço para a memoria para a
        gListaInstrucoes.Add(New Instructions(45, 100)) 'Inicia SP
        gListaInstrucoes.Add(New Instructions(44)) 'Move para sp o que esta em ax
        gListaInstrucoes.Add(New Instructions(45, 10)) 'Inicia ax
        gListaInstrucoes.Add(New Instructions(9, 1)) 'Move ax para espaço da variavel
        gListaInstrucoes.Add(New Instructions(5, 1)) 'Move para o ax o valor da variavel
        gListaInstrucoes.Add(New Instructions(30)) 'Out ax
        gListaInstrucoes.Add(New Instructions(27, 15)) 'Call ZERA A
        gListaInstrucoes.Add(New Instructions(30)) 'Out ax
        gListaInstrucoes.Add(New Instructions(40)) 'halt = termina

        'Procedure
        'Zera a
        gListaInstrucoes.Add(New Instructions(0))
        gListaInstrucoes.Add(New Instructions(9, 1)) 'Move ax para espaço da variavel
        gListaInstrucoes.Add(New Instructions(5, 1)) 'Move para o ax o valor da variavel
        gListaInstrucoes.Add(New Instructions(28)) 'Ret

        dtgInstrucoes.DataSource = Nothing
        dtgInstrucoes.DataSource = gListaInstrucoes
    End Sub

    Private Sub btnVersao11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVersao11.Click
        gListaInstrucoes.Add(New Instructions(39))
        gListaInstrucoes.Add(New Instructions(39))
        gListaInstrucoes.Add(New Instructions(39))
        gListaInstrucoes.Add(New Instructions(39))

        gListaInstrucoes.Add(New Instructions(39))

        gListaInstrucoes.Add(New Instructions(39))
        gListaInstrucoes.Add(New Instructions(39))
        gListaInstrucoes.Add(New Instructions(39))
        gListaInstrucoes.Add(New Instructions(39))
        gListaInstrucoes.Add(New Instructions(39))
        gListaInstrucoes.Add(New Instructions(0))
        gListaInstrucoes.Add(New Instructions(45, 154))
        gListaInstrucoes.Add(New Instructions(9, 0))
        gListaInstrucoes.Add(New Instructions(45, 156))
        gListaInstrucoes.Add(New Instructions(9, 1))
        gListaInstrucoes.Add(New Instructions(45, 158))
        gListaInstrucoes.Add(New Instructions(9, 2))
        gListaInstrucoes.Add(New Instructions(45, 103))
        gListaInstrucoes.Add(New Instructions(9, 3))

        gListaInstrucoes.Add(New Instructions(39))
        gListaInstrucoes.Add(New Instructions(39))

        gListaInstrucoes.Add(New Instructions(45, 240))
        gListaInstrucoes.Add(New Instructions(9, 5))
        gListaInstrucoes.Add(New Instructions(45, 220))
        gListaInstrucoes.Add(New Instructions(9, 6))
        gListaInstrucoes.Add(New Instructions(45, 200))
        gListaInstrucoes.Add(New Instructions(9, 7))
        gListaInstrucoes.Add(New Instructions(45, 180))
        gListaInstrucoes.Add(New Instructions(9, 4))

        gListaInstrucoes.Add(New Instructions(44))
        gListaInstrucoes.Add(New Instructions(5, 5))
        gListaInstrucoes.Add(New Instructions(44))
        gListaInstrucoes.Add(New Instructions(11))
        gListaInstrucoes.Add(New Instructions(5, 0))
        gListaInstrucoes.Add(New Instructions(31))
        gListaInstrucoes.Add(New Instructions(0))
        gListaInstrucoes.Add(New Instructions(31))
        gListaInstrucoes.Add(New Instructions(31))
        gListaInstrucoes.Add(New Instructions(32))
        gListaInstrucoes.Add(New Instructions(33))
        gListaInstrucoes.Add(New Instructions(47))
        gListaInstrucoes.Add(New Instructions(9, 5))

        gListaInstrucoes.Add(New Instructions(5, 6))
        gListaInstrucoes.Add(New Instructions(44))
        gListaInstrucoes.Add(New Instructions(11))
        gListaInstrucoes.Add(New Instructions(5, 1))
        gListaInstrucoes.Add(New Instructions(31))
        gListaInstrucoes.Add(New Instructions(0))
        gListaInstrucoes.Add(New Instructions(31))
        gListaInstrucoes.Add(New Instructions(31))
        gListaInstrucoes.Add(New Instructions(32))
        gListaInstrucoes.Add(New Instructions(33))
        gListaInstrucoes.Add(New Instructions(47))
        gListaInstrucoes.Add(New Instructions(9, 6))

        gListaInstrucoes.Add(New Instructions(5, 7))
        gListaInstrucoes.Add(New Instructions(44))
        gListaInstrucoes.Add(New Instructions(11))
        gListaInstrucoes.Add(New Instructions(5, 2))
        gListaInstrucoes.Add(New Instructions(31))
        gListaInstrucoes.Add(New Instructions(0))
        gListaInstrucoes.Add(New Instructions(31))
        gListaInstrucoes.Add(New Instructions(31))
        gListaInstrucoes.Add(New Instructions(32))
        gListaInstrucoes.Add(New Instructions(33))
        gListaInstrucoes.Add(New Instructions(47))
        gListaInstrucoes.Add(New Instructions(9, 7)) 'Aqui

        gListaInstrucoes.Add(New Instructions(5, 4))
        gListaInstrucoes.Add(New Instructions(44))

        gListaInstrucoes.Add(New Instructions(0))
        gListaInstrucoes.Add(New Instructions(9, 9))
        gListaInstrucoes.Add(New Instructions(45, 103))
        gListaInstrucoes.Add(New Instructions(9, 3))
        gListaInstrucoes.Add(New Instructions(51, 3))
        gListaInstrucoes.Add(New Instructions(5, 9))
        gListaInstrucoes.Add(New Instructions(3))
        gListaInstrucoes.Add(New Instructions(45, 0))
        gListaInstrucoes.Add(New Instructions(46, 119))
        gListaInstrucoes.Add(New Instructions(45, 1))
        gListaInstrucoes.Add(New Instructions(46, 119))
        gListaInstrucoes.Add(New Instructions(0))
        gListaInstrucoes.Add(New Instructions(9, 9))
        gListaInstrucoes.Add(New Instructions(26, 123))
        gListaInstrucoes.Add(New Instructions(20))
        gListaInstrucoes.Add(New Instructions(1))
        gListaInstrucoes.Add(New Instructions(9, 9))

        gListaInstrucoes.Add(New Instructions(39))
        gListaInstrucoes.Add(New Instructions(39))
        gListaInstrucoes.Add(New Instructions(39))

        gListaInstrucoes.Add(New Instructions(5, 9))
        gListaInstrucoes.Add(New Instructions(3))

        gListaInstrucoes.Add(New Instructions(45, 0))
        gListaInstrucoes.Add(New Instructions(46, 135))
        gListaInstrucoes.Add(New Instructions(26, 139))
        gListaInstrucoes.Add(New Instructions(5, 5))
        gListaInstrucoes.Add(New Instructions(44))
        gListaInstrucoes.Add(New Instructions(50))
        gListaInstrucoes.Add(New Instructions(45, 1))
        gListaInstrucoes.Add(New Instructions(46, 145))
        gListaInstrucoes.Add(New Instructions(26, 149))
        gListaInstrucoes.Add(New Instructions(5, 6))
        gListaInstrucoes.Add(New Instructions(44))
        gListaInstrucoes.Add(New Instructions(50))

        gListaInstrucoes.Add(New Instructions(5, 7))
        gListaInstrucoes.Add(New Instructions(44))
        gListaInstrucoes.Add(New Instructions(50))

        gListaInstrucoes.Add(New Instructions(39))
        gListaInstrucoes.Add(New Instructions(26, 154))

        gListaInstrucoes.Add(New Instructions(39))
        gListaInstrucoes.Add(New Instructions(26, 156))

        gListaInstrucoes.Add(New Instructions(39))
        gListaInstrucoes.Add(New Instructions(26, 158))
        gListaInstrucoes.Add(New Instructions(39))

        txtIp.Text = "1"
        txtSp.Text = "250"

        dtgInstrucoes.DataSource = Nothing
        dtgInstrucoes.DataSource = gListaInstrucoes

    End Sub
End Class
