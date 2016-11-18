Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MainLabel.Text = vbNullString
        ScoreLabel.Text = SuperpositionNumberList(GetNumberList(GetPinyinString(FirstNameBox.Text), GetPinyinString(SecondNameBox.Text)))
    End Sub

    ''' <summary>
    ''' 获取字符串的拼音首字母串
    ''' </summary>
    ''' <param name="InsString"></param>
    ''' <returns></returns>
    Private Function GetPinyinString(ByVal InsString As String) As String
        Dim Result As String = vbNullString
        For Index As Integer = 0 To InsString.Length - 1
            Result &= GetPinyin(InsString.Chars(Index))
        Next
        Debug.Print("转换拼音：{0} -- {1}", InsString, Result)
        Return Result
    End Function

    ''' <summary>
    ''' 获取单个字符的汉语拼音首字母
    ''' </summary>
    ''' <param name="InsChar">单个字符</param>
    ''' <returns>汉语拼音首字母</returns>
    Private Function GetPinyin(ByVal InsChar As Char) As Char
        If (Asc(InsChar) >= 65 AndAlso Asc(InsChar) <= 90) OrElse (Asc(InsChar) >= 97 And Asc(InsChar) <= 122) Then Return InsChar
        Dim GBCode As Integer
        Try
            GBCode = CInt(Format((Asc(InsChar) + 65536) \ 256 - 160, "00") & Format((Asc(InsChar) + 65536) Mod 256 - 160, "00"))
        Catch ex As Exception
            Return Strings.Left(InputBox("请输入 """ & InsChar & """ 的拼音首字母：", "遇到未识别字符！"), 1).ToUpper
        End Try
        If GBCode >= 1601 And GBCode < 1637 Then
            Return "A"
        ElseIf GBCode >= 1637 And GBCode < 1833 Then
            Return "B"
        ElseIf GBCode >= 1833 And GBCode < 2078 Then
            Return "C"
        ElseIf GBCode >= 2078 And GBCode < 2274 Then
            Return "D"
        ElseIf GBCode >= 2274 And GBCode < 2302 Then
            Return "E"
        ElseIf GBCode >= 2302 And GBCode < 2433 Then
            Return "F"
        ElseIf GBCode >= 2433 And GBCode < 2594 Then
            Return "G"
        ElseIf GBCode >= 2594 And GBCode < 2787 Then
            Return "H"
        ElseIf GBCode >= 2787 And GBCode < 3106 Then
            Return "J"
        ElseIf GBCode >= 2787 And GBCode < 3106 Then
            Return "J"
        ElseIf GBCode >= 3106 And GBCode < 3212 Then
            Return "K"
        ElseIf GBCode >= 3212 And GBCode < 3472 Then
            Return "L"
        ElseIf GBCode >= 3472 And GBCode < 3635 Then
            Return "M"
        ElseIf GBCode >= 3635 And GBCode < 3722 Then
            Return "N"
        ElseIf GBCode >= 3722 And GBCode < 3730 Then
            Return "O"
        ElseIf GBCode >= 3730 And GBCode < 3858 Then
            Return "P"
        ElseIf GBCode >= 3858 And GBCode < 4027 Then
            Return "Q"
        ElseIf GBCode >= 4027 And GBCode < 4086 Then
            Return "R"
        ElseIf GBCode >= 4086 And GBCode < 4390 Then
            Return "S"
        ElseIf GBCode >= 4390 And GBCode < 4558 Then
            Return "T"
        ElseIf GBCode >= 4558 And GBCode < 4684 Then
            Return "W"
        ElseIf GBCode >= 4684 And GBCode < 4925 Then
            Return "X"
        ElseIf GBCode >= 4925 And GBCode < 5249 Then
            Return "Y"
        ElseIf GBCode >= 5249 And GBCode <= 5589 Then
            Return "Z"
        Else 'Return InsChar
            Return Strings.Left(InputBox("请输入 """ & InsChar & """ 的拼音首字母：", "遇到未识别字符！"), 1).ToUpper
        End If
    End Function

    ''' <summary>
    ''' 根据两个名字首字母拼音获取初始数列
    ''' </summary>
    ''' <param name="FirstName">第一个名字首字母字符串</param>
    ''' <param name="SecondName">第二个名字首字母字符串</param>
    ''' <returns>初始数列</returns>
    Private Function GetNumberList(ByVal FirstName As String, ByVal SecondName As String) As String
        Dim Result As String = vbNullString
        Dim NameString As String = FirstName.ToUpper & SecondName.ToUpper
        For Index As Integer = 0 To NameString.Length - 1
            Result &= Asc(NameString.Chars(Index)) + 10
        Next
        Debug.Print("获取数列：{0},{1} -- {2}", FirstName， SecondName, Result)
        Return Result
    End Function

    ''' <summary>
    ''' 递归叠加数列里两两相邻的数字
    ''' </summary>
    ''' <param name="NumberList"></param>
    ''' <returns></returns>
    Private Function SuperpositionNumberList(NumberList As String) As String
        Dim Result As String = "521" '任意一个大于100的数字
        Dim SpaceCount As Byte = 1
        MainLabel.Text &= "  + " & NumberList & vbCrLf
        Do Until Int(Result) <= 100
            Result = vbNullString
            For Index As Integer = 1 To NumberList.Length - 1
                Result &= (Int(Strings.Mid(NumberList, Index, 1)) + Int(Strings.Mid(NumberList, Index + 1, 1))) Mod 10
            Next
            NumberList = Result
            MainLabel.Text &= "  + " & Strings.Space(SpaceCount) & Result & vbCrLf
            SpaceCount += 1
        Loop
        Do While Result.StartsWith("0") And Result.Length > 1
            Debug.Print(Result)
            Result = Strings.Mid(Result, 2)
            MainLabel.Text &= "  + " & Strings.Space(SpaceCount) & Result & vbCrLf
            SpaceCount += 1
        Loop

        MainLabel.Text &= "  " & Strings.Space(SpaceCount + Result.Length + 2).Replace(" ", "-") & vbCrLf
        MainLabel.Text &= Strings.Space(SpaceCount - 3) & "得分：" & Result
        Return Result
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim TempData As String = FirstNameBox.Text
        FirstNameBox.Text = SecondNameBox.Text
        SecondNameBox.Text = TempData
    End Sub
End Class
