Imports System.Text

Public Class VirtualMachine

    Private mem(256) As Integer
    Private wrkAx As Integer
    Private wrkBx As Integer
    Private wrkCx As Integer
    Private wrkSp As Integer
    Private wrkBp As Integer
    Private wrkIp As Integer
    Private wrkRi As Byte
    Private objMemoria As New Memoria

    Private wrkTeclado As String
    Private wrkSaida As String
    Private wrkPassoPasso As Boolean = False
    Private wrkCont As Integer

    Private wrkSimulaInt3 As Boolean
    Private wrkACada As Integer
    Private wrkIpMaiorQue As Integer
    Private wrkContadorInt3 As Integer

    Public Property SimulaInt3() As Boolean
        Get
            Return wrkSimulaInt3
        End Get
        Set(ByVal value As Boolean)
            wrkSimulaInt3 = value
        End Set
    End Property

    Public Property ACada() As Integer
        Get
            Return wrkACada
        End Get
        Set(ByVal value As Integer)
            wrkACada = value
        End Set
    End Property

    Public Property IpMaiorQue() As Integer
        Get
            Return wrkIpMaiorQue
        End Get
        Set(ByVal value As Integer)
            wrkIpMaiorQue = value
        End Set
    End Property

    Public Property PassoAPasso() As Boolean
        Get
            Return wrkPassoPasso
        End Get
        Set(ByVal value As Boolean)
            wrkPassoPasso = value
        End Set
    End Property

    Public Property TecladoIn() As String
        Get
            Return wrkTeclado
        End Get
        Set(ByVal value As String)
            wrkTeclado = value
        End Set
    End Property

    Public Property ax() As Integer
        Get
            Return wrkAx
        End Get
        Set(ByVal value As Integer)
            wrkAx = value
        End Set
    End Property

    Public Property bx() As Integer
        Get
            Return wrkBx
        End Get
        Set(ByVal value As Integer)
            wrkBx = value
        End Set
    End Property

    Public Property cx() As Integer
        Get
            Return wrkCx
        End Get
        Set(ByVal value As Integer)
            wrkCx = value
        End Set
    End Property

    Public Property sp() As Integer
        Get
            Return wrkSp
        End Get
        Set(ByVal value As Integer)
            wrkSp = value
        End Set
    End Property

    Public Property bp() As Integer
        Get
            Return wrkBp
        End Get
        Set(ByVal value As Integer)
            wrkBp = value
        End Set
    End Property

    Public Property ip() As Integer
        Get
            Return wrkIp
        End Get
        Set(ByVal value As Integer)
            wrkIp = value
        End Set
    End Property

    Public Property ri() As Byte
        Get
            Return wrkRi
        End Get
        Set(ByVal value As Byte)
            wrkRi = value
        End Set
    End Property

    Public Property Saida() As String
        Get
            Return wrkSaida
        End Get
        Set(ByVal value As String)
            wrkSaida = value
        End Set
    End Property

    Public Sub New()
        Me.IniciaMemoria()
        objMemoria = New Memoria
    End Sub

    Private Sub IniciaMemoria()
        Dim wrkInd As Integer
        For wrkInd = 0 To 255
            mem(wrkInd) = 0
        Next
        wrkCont = 0
        wrkContadorInt3 = 0
    End Sub

    'Public Function ListaMemoria() As DataTable
    '    Dim objMemoria As New Memoria
    '    Return objMemoria.ObtemLista(mem)
    'End Function
    Public Function ListaMemoriaVazia() As List(Of Memoria)
        Return objMemoria.ObtemLista(mem, True)
    End Function

    Public Function ListaMemoria() As List(Of Memoria)
        Return objMemoria.ObtemLista(mem, False)
    End Function

    'Carrega as instruções para a memória
    Public Sub CarregaMemoria(ByVal pListaInstrucao As List(Of Instructions))
        Dim wrkInd As Integer = 0
        Dim objInstrucao As Instructions = Nothing

        For Each objInstrucao In pListaInstrucao
            'Adiciona na memória
            mem(wrkInd) = objInstrucao.Codigo

            'Verifica se tem ValorX
            If objInstrucao.ValorX >= 0 Then
                'Incremeta contador
                wrkInd = wrkInd + 1

                'Adiciona valor
                mem(wrkInd) = objInstrucao.ValorX
            End If

            'Incremeta contador
            wrkInd = wrkInd + 1
        Next

        For wrkInd = wrkInd To 255
            mem(wrkInd) = -1
        Next

    End Sub


    Public Sub ExecutaInstrucoes()
        Dim wrkRepeater As Boolean = True
        Me.Saida = String.Empty

        While wrkRepeater

            'Verifica se é para simular 
            Dim wrkPegaIntrucaoReal As Boolean = True
            If Me.SimulaInt3 Then
                If Me.ip > Me.IpMaiorQue Then
                    If wrkContadorInt3 = 0 Then
                        wrkPegaIntrucaoReal = True
                    Else
                        Dim wrkResto As Integer
                        Math.DivRem(wrkContadorInt3, Me.ACada, wrkResto)
                        If wrkResto = 0 Then
                            'If wrkContadorInt3 \ Me.ACada = 0 Then
                            wrkPegaIntrucaoReal = False
                        End If
                    End If

                    'Incrementa contador especifico
                    wrkContadorInt3 = wrkContadorInt3 + 1
                End If
            End If

            If Not wrkPegaIntrucaoReal Then
                mem(sp) = ax
                sp = sp - 1

                mem(sp) = bx
                sp = sp - 1

                mem(sp) = cx
                sp = sp - 1

                mem(sp) = bp
                sp = sp - 1

                ip = mem(3)
            Else
                ri = mem(ip)

                Select Case ri
                    Case 0
                        ax = 0
                    Case 1
                        ax = bx
                    Case 2
                        ax = cx
                    Case 3
                        bx = ax
                    Case 4
                        cx = ax
                    Case 5
                        ax = mem(mem(ip + 1))
                        ip = ip + 1
                    Case 6
                        ax = mem(bx + ip)
                    Case 7
                        ax = mem(bp - ip)
                    Case 8
                        'ax = mem(bp + ip)
                        ax = mem(bp + mem(ip + 1))
                        ip = ip + 1
                    Case 9
                        'mem(ip + 1) = ax
                        mem(mem(ip + 1)) = ax
                        ip = ip + 1
                    Case 10
                        mem(bx + ax) = ax
                    Case 11
                        bp = sp
                    Case 12
                        sp = bp
                    Case 13
                        ax = ax + bx
                    Case 14
                        ax = ax + cx
                    Case 15
                        bx = bx + cx
                    Case 16
                        ax = ax - bx
                    Case 17
                        ax = ax - cx
                    Case 18
                        bx = bx - cx
                    Case 19
                        ax = ax + 1
                    Case 20
                        bx = bx + 1
                    Case 21
                        cx = cx + 1
                    Case 22
                        ax = ax - 1
                    Case 23
                        bx = bx - 1
                    Case 24
                        cx = cx - 1
                    Case 25
                        If ax = 0 Then
                            ip = mem(ip + 1)
                            ip = ip - 1
                        Else
                            ip = ip + 1
                        End If
                    Case 26
                        ip = mem(ip + 1)
                        ip = ip - 1
                    Case 27
                        mem(sp) = ip + 2
                        sp = sp - 1
                        ip = mem(ip + 1)
                        ip = ip - 1
                    Case 28
                        sp = sp + 1
                        ip = mem(sp)
                        ip = ip - 1
                    Case 29 'Tecla digitada
                        ax = CInt(TecladoIn)
                    Case 30 'imprimir na tela a saida
                        Me.Saida = Me.Saida & " - " & ax
                    Case 31
                        mem(sp) = ax
                        sp = sp - 1
                    Case 32
                        mem(sp) = bx
                        sp = sp - 1
                    Case 33
                        mem(sp) = cx
                        sp = sp - 1
                    Case 34
                        mem(sp) = bp
                        sp = sp - 1
                    Case 35
                        sp = sp + 1
                        bp = mem(sp)
                    Case 36
                        sp = sp + 1
                        cx = mem(sp)
                    Case 37
                        sp = sp + 1
                        bx = mem(sp)
                    Case 38
                        sp = sp + 1
                        ax = mem(sp)
                    Case 39
                        'Faz nada
                    Case 40
                        'Para processador!
                        wrkRepeater = False
                    Case 41
                        sp = sp - 1
                    Case 42
                        mem(bp - mem(ip + 1)) = ax
                        ip = ip + 1
                    Case 43
                        mem(bp + mem(ip + 1)) = ax
                        ip = ip + 1
                    Case 44
                        sp = ax
                    Case 45
                        ax = mem(ip + 1)
                        ip = ip + 1
                    Case 46
                        If ax = bx Then
                            ip = mem(ip + 1)
                            ip = ip - 1
                        Else
                            ip = ip + 1
                        End If
                    Case 47 'move ax,sp
                        ax = sp
                    Case 48 'move ax,bp
                        ax = bp
                    Case 49 'move bp,ax
                        bp = ax
                    Case 50 'iret
                        sp = sp + 1
                        bp = mem(sp)

                        sp = sp + 1
                        cx = mem(sp)

                        sp = sp + 1
                        bx = mem(sp)

                        sp = sp + 1
                        ax = mem(sp)

                        'Ret
                        sp = sp + 1
                        ip = mem(sp)
                        ip = ip - 1
                    Case 51 'int
                        mem(sp) = ax
                        sp = sp - 1

                        mem(sp) = bx
                        sp = sp - 1

                        mem(sp) = cx
                        sp = sp - 1

                        mem(sp) = bp
                        sp = sp - 1

                        ip = mem(mem(ip + 1))
                        ip = ip - 1

                    Case Else
                        Me.Saida = "Este programa executou um instrução ilegal e será fechado. Tentando: " & ri
                        Exit While

                End Select
            End If

            'Incrementa IP
            ip = ip + 1

            'Verifica se é passo a passo
            If PassoAPasso Then
                wrkCont = wrkCont + 1
                Dim wrkDetalhes As New StringBuilder
                wrkDetalhes.Append("Executado instrução '" & ri & "'" & Environment.NewLine)
                wrkDetalhes.Append("ip: " & ip & Environment.NewLine)
                wrkDetalhes.Append("ax: " & ax & Environment.NewLine)
                wrkDetalhes.Append("bx: " & bx & Environment.NewLine)
                wrkDetalhes.Append("cx: " & cx & Environment.NewLine)
                wrkDetalhes.Append("bp: " & bp & Environment.NewLine)
                wrkDetalhes.Append("sp: " & sp & Environment.NewLine)
                wrkDetalhes.Append("out: " & Saida & Environment.NewLine)
                wrkDetalhes.Append("Count: " & wrkCont & Environment.NewLine)
                MsgBox(wrkDetalhes.ToString, MsgBoxStyle.Information, "Passo a Passo - Clique para continuar....")
            End If

        End While
    End Sub


End Class
