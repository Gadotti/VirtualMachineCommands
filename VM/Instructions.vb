Public Class Instructions

    Private wrkNome As String
    Private wrkCodigo As Byte
    Private wrkValorX As Integer = -1

    Public Sub New()

    End Sub

    Public Sub New(ByVal pCodigo As Integer, Optional ByVal pValoX As Integer = -1)
        wrkCodigo = pCodigo
        wrkValorX = pValoX
    End Sub


    Public Property Nome() As String
        Get
            Return ObtemNomeInstruction(Me.Codigo)
        End Get
        Set(ByVal value As String)
            wrkNome = value
        End Set
    End Property

    Public Property Codigo() As Byte
        Get
            Return wrkCodigo
        End Get
        Set(ByVal value As Byte)
            wrkCodigo = value
        End Set
    End Property

    Public Property ValorX() As Integer
        Get
            Return wrkValorX
        End Get
        Set(ByVal value As Integer)
            wrkValorX = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return Me.Nome
    End Function

    Public Function ObtemNomeInstruction(ByVal pCodigo As Integer) As String
        Dim wrkNomeInstruction As String = String.Empty

        Select Case pCodigo
            Case 0
                wrkNomeInstruction = "init ax"
            Case 1
                wrkNomeInstruction = "move ax,bx"
            Case 2
                wrkNomeInstruction = "move ax,cx"
            Case 3
                wrkNomeInstruction = "move bx,ax"
            Case 4
                wrkNomeInstruction = "move cx,ax"
            Case 5
                wrkNomeInstruction = "move ax,["
                If ValorX >= 0 Then
                    wrkNomeInstruction = wrkNomeInstruction & Me.ValorX & "]"
                End If
            Case 6
                wrkNomeInstruction = "move ax,[bx+"
                If ValorX >= 0 Then
                    wrkNomeInstruction = wrkNomeInstruction & Me.ValorX & "]"
                End If
            Case 7
                wrkNomeInstruction = "move ax,[bp-"
                If ValorX >= 0 Then
                    wrkNomeInstruction = wrkNomeInstruction & Me.ValorX & "]"
                End If
            Case 8
                wrkNomeInstruction = "move ax,[bp+"
                If ValorX >= 0 Then
                    wrkNomeInstruction = wrkNomeInstruction & Me.ValorX & "]"
                End If
            Case 9
                wrkNomeInstruction = "move ["
                If ValorX >= 0 Then
                    wrkNomeInstruction = wrkNomeInstruction & Me.ValorX & "]"
                End If
            Case 10
                wrkNomeInstruction = "move [bx+"
                If ValorX >= 0 Then
                    wrkNomeInstruction = wrkNomeInstruction & Me.ValorX & "]"
                End If
            Case 11
                wrkNomeInstruction = "move bp,sp"
            Case 12
                wrkNomeInstruction = "move sp,bp"
            Case 13
                wrkNomeInstruction = "add ax,bx"
            Case 14
                wrkNomeInstruction = "add ax,cx"
            Case 15
                wrkNomeInstruction = "add bx,cx"
            Case 16
                wrkNomeInstruction = "sub ax,bx"
            Case 17
                wrkNomeInstruction = "sub ax,cx"
            Case 18
                wrkNomeInstruction = "sub bx,cx"
            Case 19
                wrkNomeInstruction = "inc ax"
            Case 20
                wrkNomeInstruction = "inc bx"
            Case 21
                wrkNomeInstruction = "inc cx"
            Case 22
                wrkNomeInstruction = "dec ax"
            Case 23
                wrkNomeInstruction = "dec bx"
            Case 24
                wrkNomeInstruction = "dec cx"
            Case 25
                wrkNomeInstruction = "test ax 0"
            Case 26
                wrkNomeInstruction = "jump"
            Case 27
                wrkNomeInstruction = "call"
            Case 28
                wrkNomeInstruction = "ret"
            Case 29
                wrkNomeInstruction = "in ax"
            Case 30
                wrkNomeInstruction = "out ax"
            Case 31
                wrkNomeInstruction = "push ax"
            Case 32
                wrkNomeInstruction = "push bx"
            Case 33
                wrkNomeInstruction = "push cx"
            Case 34
                wrkNomeInstruction = "push bp"
            Case 35
                wrkNomeInstruction = "pop bp"
            Case 36
                wrkNomeInstruction = "pop cx"
            Case 37
                wrkNomeInstruction = "pop bx"
            Case 38
                wrkNomeInstruction = "pop ax"
            Case 39
                wrkNomeInstruction = "nop"
            Case 40
                wrkNomeInstruction = "halt"
            Case 41
                wrkNomeInstruction = "dec sp"
            Case 42
                wrkNomeInstruction = "move [bp-"
                If ValorX >= 0 Then
                    wrkNomeInstruction = wrkNomeInstruction & Me.ValorX & "]"
                End If
            Case 43
                wrkNomeInstruction = "move [bp+"
                If ValorX >= 0 Then
                    wrkNomeInstruction = wrkNomeInstruction & Me.ValorX & "]"
                End If
            Case 44
                wrkNomeInstruction = "move sp, ax"
            Case 45
                wrkNomeInstruction = "move ax,{"
                If ValorX >= 0 Then
                    wrkNomeInstruction = wrkNomeInstruction & Me.ValorX & "}"
                End If
            Case 46
                wrkNomeInstruction = "test axEqbx, "
                If ValorX >= 0 Then
                    wrkNomeInstruction = wrkNomeInstruction & Me.ValorX
                End If
            Case 47
                wrkNomeInstruction = "move ax,sp"
            Case 48
                wrkNomeInstruction = "move ax,bp"
            Case 49
                wrkNomeInstruction = "move bp,ax"
            Case 50
                wrkNomeInstruction = "iret"
            Case 51
                wrkNomeInstruction = "int "
                If ValorX >= 0 Then
                    wrkNomeInstruction = wrkNomeInstruction & Me.ValorX
                End If
            Case Else
                wrkNomeInstruction = "Instrução não reconhecida"

        End Select

        Return wrkNomeInstruction

    End Function

    Public Function ListaInstructions() As List(Of Instructions)
        Dim wrkListaInstrucoes As New List(Of Instructions)
        Dim wrkInd As Integer = 0

        For wrkInd = 0 To 46
            Dim wrkItem As New Instructions

            wrkItem.Codigo = wrkInd
            'wrkItem.Nome = ObtemNomeInstruction(wrkInd)
            wrkListaInstrucoes.Add(wrkItem)
        Next

        Return wrkListaInstrucoes

    End Function

End Class
