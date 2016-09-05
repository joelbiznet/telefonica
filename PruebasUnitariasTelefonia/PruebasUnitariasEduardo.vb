Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Compañia_Telefónica_BUS
Imports Compañia_Telefónica_BEAN

<TestClass()> Public Class UnitTest1

    <TestMethod()> Public Sub guardar()
        Dim client As ClsClientes = New ClsClientes()
        client.dni = "12345678"
        client.nombre = "Pedro"
        client.apellido = "Jimenez"
        client.sexo = "M"

        Dim negocio As ClsCliente_BUS = New ClsCliente_BUS()

        Assert.IsNotNull(negocio.guardar(client))
    End Sub

    <TestMethod()> Public Sub borrar()
        Dim xnom As String
        xnom = "Paco"


        Dim negocio As ClsCliente_BUS = New ClsCliente_BUS()

        Assert.IsNotNull(negocio.borrar(xnom))
    End Sub
    <TestMethod()> Public Sub dameuno()


        Dim client As String
        client = "12345678"


        Dim negocio As ClsCliente_BUS = New ClsCliente_BUS()

        Assert.IsNotNull(negocio.dameUno(client))
    End Sub
End Class