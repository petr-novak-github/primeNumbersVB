Module Module1
    Sub Main()
        'c18) Program vypíše všechna prvočísla do čísla 1000. 
        'Prvočísla jsou čísla dělitelná jen jedničkou a sama sebou. (použij modulo)
        'muj postup: rozdelil jsem problem na dva, nejdrive 1) jak zjistim ze je zadane cislo prvocilo 2) provedu to 1000x

        Dim cisloX As Integer
        Dim deleni(1000) As Integer
        Dim i As Integer
        Dim j As Integer
        Dim prvocislaStr As String
        Dim pocitadlo As Integer
        Dim anoNe As Boolean

        prvocislaStr = ""
        For cisloX = 1 To 1000
            For i = 2 To cisloX - 1
                deleni(i) = cisloX Mod i
            Next
            pocitadlo = 0
            For i = 2 To cisloX - 1
                If deleni(i) = 0 Then
                    pocitadlo = pocitadlo + 1
                End If
            Next
            If pocitadlo = 0 Then
                prvocislaStr = prvocislaStr + Str(cisloX) + Chr(10)
                anoNe = True
            End If
        Next
        MsgBox("Prvocisla jsou  " + Chr(10) + prvocislaStr)
    End Sub

End Module
