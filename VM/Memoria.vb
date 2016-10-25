Public Class Memoria

    Public wrkValor As Byte
    Public wrkIndice As Byte
    Public wrkNome As String

    Public Property Valor() As Byte
        Get
            Return wrkValor
        End Get
        Set(ByVal value As Byte)
            wrkValor = value
        End Set
    End Property

    Public Property Indice() As Byte
        Get
            Return wrkIndice
        End Get
        Set(ByVal value As Byte)
            wrkIndice = value
        End Set
    End Property

    Public Property Nome() As String
        Get
            Return wrkNome
        End Get
        Set(ByVal value As String)
            wrkNome = value
        End Set
    End Property

    Public Function ObtemLista(ByVal mem() As Integer, ByVal pFgInstrucaoVazia As Boolean) As List(Of Memoria)
        Dim wrkInd As Integer
        Dim wrkRetorno As New List(Of Memoria)
        Dim objInstrucao As New Instructions

        For wrkInd = 0 To 255
            'Adiciona os campos
            Dim wrkItem As New Memoria

            wrkItem.Indice = wrkInd

            If Not mem(wrkInd) = -1 Then
                wrkItem.Valor = mem(wrkInd)
                If pFgInstrucaoVazia Then
                    wrkItem.Nome = String.Empty
                Else
                    'Obtem descrição a instrução
                    objInstrucao.Codigo = wrkItem.Valor
                    wrkItem.Nome = objInstrucao.Nome
                End If

                'Verifica se a instrução tem parametro
                If InstrucaoComParametro(wrkItem.Valor) AndAlso wrkInd <> 255 Then
                    'Adiciona o item na lista
                    wrkRetorno.Add(wrkItem)

                    'Adiciona os campos
                    wrkItem = New Memoria
                    wrkInd = wrkInd + 1
                    wrkItem.Indice = wrkInd
                    wrkItem.Valor = mem(wrkInd)
                    wrkItem.Nome = wrkItem.Valor.ToString
                End If

            Else
                wrkItem.Valor = Nothing
                wrkItem.Nome = String.Empty
            End If


            'Adiciona o item na lista
            wrkRetorno.Add(wrkItem)

        Next

        Return wrkRetorno

    End Function

    Public Shared Function InstrucaoComParametro(ByVal pValor As Integer)
        'Verifica as instruções que tem parametros
        Dim wrkRetorno As Boolean = False

        Select Case pValor
            Case 5, 6, 7, 8, 9, 10, 42, 43, 25, 26, 45, 27, 46, 51
                wrkRetorno = True
            Case Else
                wrkRetorno = False
        End Select

        Return wrkRetorno
    End Function

End Class
