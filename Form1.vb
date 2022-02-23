Imports System.Data.SqlClient
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MasterDataSet.Database' table. You can move, or remove it, as needed.
        Me.DatabaseTableAdapter.Fill(Me.MasterDataSet.Database)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim connetionString As String
        Dim cnn As SqlConnection
        connetionString = "Data Source=localhost;Initial Catalog=master;Integrated Security=True"
        cnn = New SqlConnection(connetionString)
        cnn.Open()
        Dim Command As SqlCommand
        Dim datareader As SqlDataReader
        Dim Sql, Output As String
        Output = ""

        Sql = "Select * from [master].[dbo].[Database]"
        Command = New SqlCommand(Sql, cnn)
        datareader = Command.ExecuteReader()

        While datareader.Read()

            Output = Output + datareader.GetValue(0) + "-" + datareader.GetValue(1) + "\n"
        End While

        MessageBox.Show(Output)
        datareader.Close()
        Command.Dispose()

        cnn.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Dim intData(30)   ' an array of 31 elements
        Dim strData(20) As String   ' an array of 21 strings
        Dim twoDarray(10, 20) As Integer    'a two dimensional array of integers
        Dim ranges(10, 100)  'a two dimensional array

        Dim intData() As Integer = {12, 16, 20, 24, 28, 32}


        Dim names() As String = {"Karthik", "Sandhya",
        "Shivangi", "Ashwitha", "Somnath"}
        Dim miscData() As Object = {"Hello World", 12D, 16UI, "A"c}

    End Sub
End Class
