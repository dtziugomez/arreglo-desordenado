Module Module1

    Sub Main()
        Dim op As Integer
        Dim conta As Integer = -1
        Dim array(2) As Integer  'ARREGLO DE 3 ELEMENTOS  0-2
        Do
            Console.WriteLine("1-Insertar")
            Console.WriteLine("2-eliminar")
            Console.WriteLine("3-actualizar")
            Console.WriteLine("4-buscar")
            Console.WriteLine("5-ver arreglo")
            Console.WriteLine("6-salir")
            Console.Write("elija una opcion :")
            op = Integer.Parse(Console.ReadLine())
            Select Case op
                Case 1  'insertar elemento
                    If conta = 2 Then
                        Console.WriteLine("**el arreglo esta lleno**")
                    Else
                        Console.Write("deposite un numero:")
                        conta = conta + 1
                        array(conta) = Integer.Parse(Console.ReadLine())

                    End If
                Case 2 'ëliminar
                    If (conta = -1) Then
                        Console.WriteLine("**EL ARREGLO ESTA VACIO**")
                    Else
                        Console.Write("valor a eliminar:")
                        Dim val As Integer
                        val = Integer.Parse(Console.ReadLine())
                        Dim i As Integer = 0
                        While i < 3 AndAlso val <> array(i)
                            i = i + 1
                        End While
                        If i = 3 Then
                            Console.WriteLine("**No se encontro el valor buscado**")
                        Else
                            Dim k As Integer = i
                            While k < conta
                                array(k) = array(k + 1)
                                array(k + 1) = 0
                                k = k + 1
                            End While
                            If k = conta Then
                                array(k) = 0  'elimina el ultimo elemento
                            End If
                        End If
                        conta = conta - 1
                    End If
                Case 3  'actualizar
                    Console.Write("Valor a modificar:")
                    Dim val As Integer
                    val = Integer.Parse(Console.ReadLine())
                    Dim i As Integer = 0
                    While i < 3 AndAlso val <> array(i)
                        i = i + 1
                    End While
                    If i = 3 Then
                        Console.WriteLine("**No se encontro el numero que se va a modificar**")
                    Else
                        Console.Write("Nuevo valor:")
                        Dim modificacion As Integer
                        modificacion = Integer.Parse(Console.ReadLine())
                        array(i) = modificacion
                    End If
                Case 4
                    Console.Write("valor:")
                    Dim val As Integer = 0
                    val = Integer.Parse(Console.ReadLine())
                    Dim i As Integer = 0
                    While i < 2
                        If array(i) = val Then
                            Console.WriteLine("el valor si existe")
                        End If
                        i += 1
                    End While
                    If i = 2 Then
                        Console.WriteLine("***El valor no existe***")
                    End If
                Case 5
                    Dim i As Integer = 0
                    While i <= 2
                        Console.Write(array(i) & " ")
                        i += 1
                    End While
                    Console.WriteLine("")
            End Select
        Loop While op <> 6
        Console.ReadKey()
        
    End Sub

End Module
