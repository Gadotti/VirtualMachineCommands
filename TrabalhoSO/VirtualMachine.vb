Module VirtualMachine

    Sub Main()

        Dim mem(1024) As Byte
        Dim ax As Integer
        Dim bx As Integer
        Dim cx As Integer
        Dim sp As Integer
        Dim bp As Integer
        Dim ip As Integer
        Dim ri As Byte
        Dim wrkRepeater As Boolean = True

        While wrkRepeater
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
                    ax = mem(ip + 1) 'VALIDAR
                Case 6
                    ax = mem(bx + ip)
                Case 7
                    ax = mem(bp - ip)
                Case 8
                    ax = mem(bp + ip)
                Case 9
                    mem(ip + 1) = ax 'VALIDAR
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
                Case 25 'VALIDAR
                    If ax = 0 Then
                        ip = pValor
                    End If
                Case 26 'VALIDAR
                    ip = pValor
                Case 27 'VALIDAR
                    mem(sp) = ip + 1
                    sp = sp - 1
                    ip = pValor
                Case 28
                    sp = sp + 1
                    ip = mem(sp)
                Case 29


            End Select
        End While


    End Sub

End Module
