Imports System.Drawing
Imports System.Data.SqlClient
Imports System.Data
Partial Class PDC

    Inherits System.Web.UI.Page
    Public Dag As Integer
    Public Vandaag As Date
    Public Maand As Integer
    Public PMaand As Integer
    Public Jaar As Integer
    Public PJaar As Integer
    Public BirthDay As Date
    Public Age As String
    Public PCheck As Integer

    Public WeekHours As Integer = 24 * 7
    Public NumberOfDays As Long
    Public NumberofHolidays As Long
    Public NumberOfWeeks As Decimal
    Public NumberOfMonths As Decimal
    Public NumberOfYears As Decimal
    Public PensionDate As Date
    Public Count As Integer

    Public Karakter As String
    Public Temp As String

    Public JD1 As Integer
    Public JD2(100) As Integer

    Public FileWriter As System.IO.StreamWriter
    Public FileWriter1 As System.IO.StreamWriter
    Public FileReader As System.IO.StreamReader
    Public FileLineIn As String
    Public FileName As String

    Public InputVeld(50, 4) As String
    Public Teller As Integer
    Public FieldTeller As Integer
    Public OutputLine As String
    Public SearchKey As String

    Public ScreenChoise As Integer
    Public OldScreenChoise As Integer

    Private Sub CmdNext_Click(sender As Object, e As EventArgs) Handles CmdNext.Click
        form1.Visible = False
        form2.Visible = True
        Veld1.Focus()
    End Sub

    Private Sub PDC_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Me.IsPostBack Then
            Veld1.Attributes.Add("autocomplete", "off")
            Veld2.Attributes.Add("autocomplete", "off")
            Veld3.Attributes.Add("autocomplete", "off")

            Veld1.Focus()
            Call OpenPensionTable()
        End If
    End Sub

    Private Sub CmdRefresh_Click(sender As Object, e As EventArgs) Handles CmdRefresh.Click
        Veld1.Text = "" : Veld1.Attributes.Add("autocomplete", "off")
        Veld2.Text = "" : Veld2.Attributes.Add("autocomplete", "off")
        Veld3.Text = "" : Veld3.Attributes.Add("autocomplete", "off")
        Label1.Text = "Leeftijd :"
        Label2.Text = "Pensioen datum :"
        Label3.Text = "Vakantie dagen / uren op basis van uren werkweek : "
        Label5.Visible = False
        Label6.Text = "Dagen : "
        Label7.Text = "Weken : "
        Label8.Text = "Maanden : "
        Label9.Text = "Jaren : "
        Label10.Visible = False
        CB1.Visible = False
        Label4.Visible = False
    End Sub
    Sub OpenPensionTable()
        'Try
        Session("Teller") = 1
            FieldTeller = 1
            Array.Clear(InputVeld, 50, 4)

        Session("InputVeld(1, 1)") = "31-08-1955" : Session("InputVeld(1, 2)") = "66" : Session("InputVeld(1, 3)") = "4" : Session("InputVeld(1, 4)") = "1"
        Session("InputVeld(2, 1)") = "31-05-1956" : Session("InputVeld(2, 2)") = "66" : Session("InputVeld(2, 3)") = "7" : Session("InputVeld(2, 4)") = "1"
        Session("InputVeld(3, 1)") = "28-02-1957" : Session("InputVeld(3 ,2)") = "66" : Session("InputVeld(3, 3)") = "10" : Session("InputVeld(3, 4)") = "1"
        Session("InputVeld(4, 1)") = "31-12-1960" : Session("InputVeld(4, 2)") = "67" : Session("InputVeld(4, 3)") = "0" : Session("InputVeld(4, 4)") = "1"
        Session("InputVeld(5, 1)") = "30-09-1961" : Session("InputVeld(5 ,2)") = "67" : Session("InputVeld(5, 3)") = "3" : Session("InputVeld(5, 4)") = "1"
        Session("InputVeld(6, 1)") = "30-09-1963" : Session("InputVeld(6, 2)") = "67" : Session("InputVeld(6, 3)") = "3" : Session("InputVeld(6, 4)") = "0"
        Session("InputVeld(7, 1)") = "30-06-1967" : Session("InputVeld(7, 2)") = "67" : Session("InputVeld(7, 3)") = "6" : Session("InputVeld(7, 4)") = "0"
        Session("InputVeld(8 ,1)") = "31-03-1970" : Session("InputVeld(8, 2)") = "67" : Session("InputVeld(8, 3)") = "9" : Session("InputVeld(8, 4)") = "0"
        Session("InputVeld(9, 1)") = "31-12-1972" : Session("InputVeld(9, 2)") = "68" : Session("InputVeld(9, 3)") = "0" : Session("InputVeld(9, 4)") = "0"
        Session("InputVeld(10, 1)") = "30-09-1976" : Session("InputVeld(10, 2)") = "68" : Session("InputVeld(10, 3)") = "3" : Session("InputVeld(10, 4)") = "0"
        Session("InputVeld(11, 1)") = "30-06-1979" : Session("InputVeld(11, 2)") = "68" : Session("InputVeld(11, 3)") = "6" : Session("InputVeld(11, 4)") = "0"
        Session("InputVeld(12, 1)") = "31-03-1982" : Session("InputVeld(12, 2)") = "68" : Session("InputVeld(12, 3)") = "9" : Session("InputVeld(12, 4)") = "0"
        Session("InputVeld(13, 1)") = "31-12-1985" : Session("InputVeld(13, 2)") = "69" : Session("InputVeld(13, 3)") = "0" : Session("InputVeld(13, 4)") = "0"
        Session("InputVeld(14, 1)") = "30-09-1989" : Session("InputVeld(14, 2)") = "69" : Session("InputVeld(14, 3)") = "3" : Session("InputVeld(14, 4)") = "0"
        Session("InputVeld(15, 1)") = "30-06-1993" : Session("InputVeld(15, 2)") = "69" : Session("InputVeld(15, 3)") = "6" : Session("InputVeld(15, 4)") = "0"
        Session("InputVeld(16, 1)") = "31-03-1997" : Session("InputVeld(16, 2)") = "69" : Session("InputVeld(16, 3)") = "9" : Session("InputVeld(16, 4)") = "0"
        Session("InputVeld(17, 1)") = "31-12-2000" : Session("InputVeld(17, 2)") = "70" : Session("InputVeld(17, 3)") = "0" : Session("InputVeld(16, 4)") = "0"
        Session("Teller") = 18
        'Catch
        ''Response = MsgBox("Er is een fout opgetreden in de module OpenPensionTable verwerking is gestaakt.", vbOKOnly, "Bereken Pensioen Datum")
        'End
        'End Try
    End Sub
    Private Sub CmdReken_Click(sender As Object, e As EventArgs) Handles CmdReken.Click
        'Try
        If Len(Trim(Veld1.Text)) <> 10 Then
                CmdError.Visible = True
                CmdError.Text = "Er is geen geldige datum ingevoerd, berekening niet mogelijk!"
                Session("ErrCode") = 1
                Veld1.Enabled = False
                Veld2.Enabled = False
                Veld3.Enabled = False
                CmdRefresh.Enabled = False
                CmdReken.Enabled = False
                CmdSet.Enabled = False
                Exit Sub
            End If

            If Len(Trim(Veld2.Text)) = 0 Then
                CmdError.Visible = True
                CmdError.Text = "Er zijn geen uren ingevoerd, berekening niet mogelijk!"
                Session("ErrCode") = 2
                Veld1.Enabled = False
                Veld2.Enabled = False
                Veld3.Enabled = False
                CmdRefresh.Enabled = False
                CmdReken.Enabled = False
                CmdSet.Enabled = False
                Exit Sub
            End If

            'Bereken Leeftijd
            Call CalculateAge()

            Label1.Text = "Leeftijd : " & Trim(Age)

            'Bereken aantal jaren tussen geboortedatum en nu
            Call PTable()

            Label2.Text = "Pensioen datum : " & Trim(PensionDate)

            'Bereken nog te werken dagen
            Call CalculateWeeks()
            Label6.Text = "Dagen : " + Trim(Str(Session("NumberOfDays")))
            Label7.Text = "Weken : " + Trim(Str(Session("NumberOfWeeks")))
            Label8.Text = "Maanden : " + Trim(Str(Session("NumberOfMonths")))
            Label9.Text = "Jaren : " + Trim(Str(Session("NumberOfYears")))
        'Catch
        'Response = MsgBox("Er is een fout opgetreden in de module CmdReken verwerking is gestaakt.", vbOKOnly, "Bereken Pensioen Datum")
        'Exit Sub
        'End Try
    End Sub

    Sub CalculateWeeks()
        'Try
        Dim DateFrom As Date
            Dim DateTo As Date
            Dim RawDays As Decimal

            DateFrom = CDate(Now)
            DateTo = CDate(PensionDate)

            RawDays = DateDiff("d", DateFrom, DateTo)
            Session("NumberOfWeeks") = DateDiff("w", DateFrom, DateTo)
            RawDays = Val(Veld2.Text) / 8
            Session("NumberOfDays") = Session("NumberOfWeeks") * RawDays
            Session("NumberOfYears") = Math.Round(Session("NumberOfWeeks") / 52, 2)
            Session("NumberOfMonths") = Math.Round(Session("NumberOfYears") * 12, 2)

            'Count Holidays
            Session("NumberofHolidays") = ((25 / 40) * Val(Veld2.Text)) * Session("NumberOfYears")
            Session("NumberOfDays") = Session("NumberOfDays") - Session("NumberofHolidays")
            Session("NumberOfDays") = Session("NumberOfDays") - (Val(Veld3.Text))
            Label3.Text = "Vakantie dagen / uren op basis van uren werkweek : " + Trim(Str(Session("NumberofHolidays"))) + "/" + Trim(Str(Session("NumberofHolidays") * 8))
            CB1.Visible = True : CB1.Checked = True : Label4.Visible = True
        'Catch
        'Response = MsgBox("Er is een fout opgetreden in de module CalculateWeeks verwerking is gestaakt.", vbOKOnly, "Bereken Pensioen Datum")
        'End Try
    End Sub
    Sub CalculateAge()
        'Try
        BirthDay = DateTime.Parse(Veld1.Text)
            Vandaag = DateTime.Parse(Now)
            'NumberOfDays = (Vandaag - BirthDay).Days
            Age = (Vandaag - BirthDay).Days / 365

            Temp = ""
            For x = 1 To Len(Age)
                Karakter = Mid(Age, x, 1)
                If Karakter <> "," Then
                    Temp = Temp + Karakter
                Else
                    Exit For
                End If
            Next

            Age = Trim(Temp)
        'Catch
        'Response = MsgBox("Er is een fout opgetreden in de module CalculateAge verwerking is gestaakt.", vbOKOnly, "Bereken Pensioen Datum")
        'End Try
    End Sub
    Sub PTable()
        'Try
        'Maak Juliannumber van geboortedatum
        JD1 = Mid(Veld1.Text, 1, 4) & Mid(Veld1.Text, 6, 2) & Mid(Veld1.Text, 9, 2)

        'Maak juliannumber voor tabelcheck
        Temp = Session("InputVeld(1, 1)")
        JD2(1) = Mid(Trim(Temp), 7, 4) & Mid(Trim(Temp), 1, 2) & Mid(Trim(Temp), 4, 2)
        Temp = Session("InputVeld(2, 1)")
        JD2(2) = Mid(Trim(Temp), 7, 4) & Mid(Trim(Temp), 1, 2) & Mid(Trim(Temp), 4, 2)
        Temp = Session("InputVeld(3, 1)")
        JD2(3) = Mid(Trim(Temp), 7, 4) & Mid(Trim(Temp), 1, 2) & Mid(Trim(Temp), 4, 2)
        Temp = Session("InputVeld(4, 1)")
        JD2(4) = Mid(Trim(Temp), 7, 4) & Mid(Trim(Temp), 1, 2) & Mid(Trim(Temp), 4, 2)
        Temp = Session("InputVeld(5, 1)")
        JD2(5) = Mid(Trim(Temp), 7, 4) & Mid(Trim(Temp), 1, 2) & Mid(Trim(Temp), 4, 2)
        Temp = Session("InputVeld(6, 1)")
        JD2(6) = Mid(Trim(Temp), 7, 4) & Mid(Trim(Temp), 1, 2) & Mid(Trim(Temp), 4, 2)
        Temp = Session("InputVeld(7, 1)")
        JD2(7) = Mid(Trim(Temp), 7, 4) & Mid(Trim(Temp), 1, 2) & Mid(Trim(Temp), 4, 2)
        Temp = Session("InputVeld(8 ,1)")
        JD2(8) = Mid(Trim(Temp), 7, 4) & Mid(Trim(Temp), 1, 2) & Mid(Trim(Temp), 4, 2)
        Temp = Session("InputVeld(9, 1)")
        JD2(9) = Mid(Trim(Temp), 7, 4) & Mid(Trim(Temp), 1, 2) & Mid(Trim(Temp), 4, 2)
        Temp = Session("InputVeld(10, 1)")
        JD2(10) = Mid(Trim(Temp), 7, 4) & Mid(Trim(Temp), 1, 2) & Mid(Trim(Temp), 4, 2)
        Temp = Session("InputVeld(11, 1)")
        JD2(11) = Mid(Trim(Temp), 7, 4) & Mid(Trim(Temp), 1, 2) & Mid(Trim(Temp), 4, 2)
        Temp = Session("InputVeld(12, 1)")
        JD2(12) = Mid(Trim(Temp), 7, 4) & Mid(Trim(Temp), 1, 2) & Mid(Trim(Temp), 4, 2)
        Temp = Session("InputVeld(13, 1)")
        JD2(13) = Mid(Trim(Temp), 7, 4) & Mid(Trim(Temp), 1, 2) & Mid(Trim(Temp), 4, 2)
        Temp = Session("InputVeld(14, 1)")
        JD2(14) = Mid(Trim(Temp), 7, 4) & Mid(Trim(Temp), 1, 2) & Mid(Trim(Temp), 4, 2)
        Temp = Session("InputVeld(15, 1)")
        JD2(15) = Mid(Trim(Temp), 7, 4) & Mid(Trim(Temp), 1, 2) & Mid(Trim(Temp), 4, 2)
        Temp = Session("InputVeld(16, 1)")
        JD2(16) = Mid(Trim(Temp), 7, 4) & Mid(Trim(Temp), 1, 2) & Mid(Trim(Temp), 4, 2)
        Temp = Session("InputVeld(17, 1)")
        JD2(17) = Mid(Trim(Temp), 7, 4) & Mid(Trim(Temp), 1, 2) & Mid(Trim(Temp), 4, 2)


        If JD1 <= JD2(1) Then
            Jaar = Session("InputVeld(1, 2)")
            Maand = Session("InputVeld(1, 3)")
            PCheck = Session("InputVeld(1, 4)")
        ElseIf JD1 <= JD2(2) Then
            Jaar = Session("InputVeld(2, 2)")
            Maand = Session("InputVeld(2, 3)")
            PCheck = Session("InputVeld(2, 4)")
        ElseIf JD1 <= JD2(3) Then
            Jaar = Session("InputVeld(3, 2)")
                Maand = Session("InputVeld(3, 3)")
                PCheck = Session("InputVeld(3, 4)")

            ElseIf JD1 <= JD2(4) Then
                Jaar = Session("InputVeld(4, 2)")
                Maand = Session("InputVeld(4, 3)")
                PCheck = Session("InputVeld(4, 4)")

            ElseIf JD1 <= JD2(5) Then
            Jaar = Session("InputVeld(5 ,2)")
            Maand = Session("InputVeld(5, 3)")
                PCheck = Session("InputVeld(5, 4)")

            ElseIf JD1 <= JD2(6) Then
                Jaar = Session("InputVeld(6, 2)")
                Maand = Session("InputVeld(6, 3)")
                PCheck = Session("InputVeld(6, 4)")
            ElseIf JD1 <= JD2(7) Then
                Jaar = Session("InputVeld(7, 2)")
                Maand = Session("InputVeld(7, 3)")
                PCheck = Session("InputVeld(7, 4)")
            ElseIf JD1 <= JD2(8) Then
                Jaar = Session("InputVeld(8, 2)")
                Maand = Session("InputVeld(8, 3)")
                PCheck = Session("InputVeld(8, 4)")
            ElseIf JD1 <= JD2(9) Then
                Jaar = Session("InputVeld(9, 2)")
                Maand = Session("InputVeld(9, 3)")
                PCheck = Session("InputVeld(9, 4)")
            ElseIf JD1 <= JD2(10) Then
                Jaar = Session("InputVeld(10, 2)")
                Maand = Session("InputVeld(10, 3)")
                PCheck = Session("InputVeld(10, 4)")
            ElseIf JD1 <= JD2(11) Then
                Jaar = Session("InputVeld(11, 2)")
                Maand = Session("InputVeld(11, 3)")
                PCheck = Session("InputVeld(11, 4)")
            ElseIf JD1 <= JD2(12) Then
                Jaar = Session("InputVeld(12, 2)")
                Maand = Session("InputVeld(12, 3)")
                PCheck = Session("InputVeld(12, 4)")
            ElseIf JD1 <= JD2(13) Then
                Jaar = Session("InputVeld(13, 2)")
                Maand = Session("InputVeld(13, 3)")
                PCheck = Session("InputVeld(13, 4)")
            ElseIf JD1 <= JD2(14) Then
                Jaar = Session("InputVeld(14, 2)")
                Maand = Session("InputVeld(14, 3)")
                PCheck = Session("InputVeld(14, 4)")
            ElseIf JD1 <= JD2(15) Then
                Jaar = Session("InputVeld(15, 2)")
                Maand = Session("InputVeld(15, 3)")
                PCheck = Session("InputVeld(15, 4)")
            ElseIf JD1 <= JD2(16) Then
                Jaar = Session("InputVeld(16, 2)")
                Maand = Session("InputVeld(16, 3)")
                PCheck = Session("InputVeld(16, 4)")
            ElseIf JD1 <= JD2(17) Then
                Jaar = Session("InputVeld(17, 2)")
                Maand = Session("InputVeld(17, 3)")
                PCheck = Session("InputVeld(17, 4)")
            End If

            If PCheck = 0 Then
                Label10.ForeColor = Drawing.Color.Red
                Label10.Visible = True
                Label5.ForeColor = Drawing.Color.Red
                Label5.Visible = True : Label5.Text = "Niet definitief."
            ElseIf PCheck = 1 Then
                Label10.ForeColor = Drawing.Color.Green
                Label10.Visible = True
                Label5.ForeColor = Drawing.Color.Green
                Label5.Visible = True : Label5.Text = "Definitief."
            End If

            'Bepaal pensioen datum
            Dag = Mid(Veld1.Text, 9, 2)
            PMaand = Val(Mid(Veld1.Text, 6, 2)) + Maand
            If PMaand > 12 Then
                PMaand = PMaand - 12
                PJaar = Mid(JD1, 1, 4) + Jaar
            Else
                PJaar = Mid(JD1, 1, 4) + Jaar
            End If

            PensionDate = Dag & "-" & PMaand & "-" & PJaar
        'Catch
        'Response = MsgBox("Er is een fout opgetreden in de module PTable verwerking is gestaakt.", vbOKOnly, "Bereken Pensioen Datum")
        'End Try
    End Sub

    Private Sub CB1_CheckedChanged(sender As Object, e As EventArgs) Handles CB1.CheckedChanged
        If CB1.Checked = False Then
            'Verhoog uren en maak label leeg
            Session("NumberOfDays") = Session("NumberOfDays") + Session("NumberofHolidays")
            Label6.Text = "Dagen : " + Trim(Str(Session("NumberOfDays")))
            Label3.Text = "Vakantie dagen / uren op basis van uren werkweek : niet berekend."
        ElseIf CB1.Checked = True Then
            Session("NumberOfDays") = Session("NumberOfDays") - Session("NumberofHolidays")
            Label6.Text = "Dagen : " + Trim(Str(Session("NumberOfDays")))
            Label3.Text = "Vakantie dagen / uren op basis van uren werkweek : " + Trim(Str(Session("NumberofHolidays"))) + "/" + Trim(Str(Session("NumberofHolidays") * 8))
        End If
    End Sub

    Private Sub CmdError_Click(sender As Object, e As EventArgs) Handles CmdError.Click
        CmdError.Visible = False
        If Session("ErrCode") = 1 Then
            Veld1.Focus()
        ElseIf Session("ErrCode") = 2 Then
            Veld2.Focus()
        End If
        Veld1.Enabled = True
        Veld2.Enabled = True
        Veld3.Enabled = True
        CmdRefresh.Enabled = True
        CmdReken.Enabled = True
        CmdSet.Enabled = True
    End Sub

    Private Sub CmdSet_Click(sender As Object, e As EventArgs) Handles CmdSet.Click

        form2.Visible = False
        form3.Visible = True
    End Sub

    Private Sub CmdRetour_Click(sender As Object, e As EventArgs) Handles CmdRetour.Click
        form3.Visible = False
        form2.Visible = True
        Veld1.Focus()
    End Sub
End Class
