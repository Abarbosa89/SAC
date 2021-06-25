Imports System.Data.SqlClient
Imports System.Data

Module CONEXION

    'Public con As New SqlConnection("Data Source=WIN-INAR48T85I3;Initial Catalog=SAC;User ID=sa;Password=MenoVargas45")
    Public conBuffer As OleDb.OleDbConnection
    Public con As New SqlConnection("Data Source=192.168.3.206;Initial Catalog=SAC;User ID=sa;Password=masterkey")
End Module
Module VARIABLES
    Public BANDERAREPORTE2 As Integer = 0
    Public BANDERA As Integer
    Public BANDERARECFOLFAC As Integer
    Public PASSWORD As String
    Public CONFIRMPASS As String
    Public BANDERAPAGO As Integer
    Public BAND As Integer
    Public RECARGO As Integer
    Public CONTADOR As Integer = 0
    Public CONTADOR2 As Integer = 0
    Public BANDERACOBRO As Integer = 0
    Public BANDERABONO1 As Integer = 0
    Public BANDERABONO2 As Integer = 0
    Public BANDERABONO3 As Integer = 0
    Public BANDERABONO4 As Integer = 0
    Public BANDERABONO5 As Integer = 0
    Public BANDERALIQ1 As Integer = 0
    Public BANDERALIQ2 As Integer = 0
    Public BANDERALIQ3 As Integer = 0
    Public BANDERALIQ4 As Integer = 0
    Public BANDERALIQ5 As Integer = 0
    Public BANDERALIQ6 As Integer = 0
    Public BANDERAREPORTE As Integer = 0
    Public BANDTUTOR As Integer = 0
    Public CORREO As Integer = 0
    Public FLASH As Integer = 0
    Public TEXTO As String
    Public IMPRESION As Integer = 0
    Public ImpTicketGLOBAL As String = ""
    Public ImpresoraGLOBAL As String = ""
    Public FechaCIerre As String = ""
    Public FechaActual As String = ""
End Module


