Imports System.IO
Imports System.Reflection
Imports System.Text
Imports OpenQA.Selenium
Imports OpenQA.Selenium.Chrome
Imports SeleniumUndetectedChromeDriver

Public Class MainForm
    Dim ShouldStop As Boolean = False
    Dim Slimjet = "C:\Program Files\Slimjet\slimjet.exe"
    Private Sub StopBtn_Click(sender As Object, e As EventArgs) Handles StopBtn.Click
        ShouldStop = True
    End Sub
    Dim Alpha As Char() = "abcdefghijklmnopqrstuvwxyz1234567890!@#$%^&*()_+-={}|[]\`~:"";'?><,./".ToArray
    Function Clean(Name As String) As String
        Dim Out = String.Empty
        If String.IsNullOrEmpty(Name) Then Return Out
        For Each N In Name.ToLower()
            If Alpha.Contains(N) Then
                Out &= N
            Else
                Out &= " "
            End If
        Next
        While Out.Contains("  ")
            Out = Out.Replace("  ", " ")
        End While
        Return Out.TrimStart(" ").TrimEnd(" ")
    End Function

    Async Sub StartBtn_Click(sender As Object, e As EventArgs) Handles StartBtn.Click
        setStatus()
        ShouldStop = False
        StartBtn.Visible = False
        Await Task.Run(
            Sub()
                Try
                    Dim Codes = CodeList.Lines.Where(Function(C) Not String.IsNullOrEmpty(C))
                    Dim Options As New ChromeOptions()
                    Options.AddArgument($"--hide-crash-restore-bubble")
                    Options.AddArgument("--incognito")
                    Options.AddArgument("--start-maximized")
                    Options.AddArgument("--blink-settings=imagesEnabled=false")
                    Options.PageLoadStrategy = PageLoadStrategy.Eager
                    Options.BinaryLocation = Slimjet

                    Using Driver = UndetectedChromeDriver.Create(Options, Nothing, Path.GetFullPath("chromedriver.exe"), Slimjet, hideCommandPromptWindow:=True, commandTimeout:=TimeSpan.FromHours(1))
                        Using sw As New StreamWriter("Output.csv", False, Encoding.Unicode)
                            sw.WriteLine(String.Join(vbTab, New String() {"ASIN", "isValid", "Title"}))
                            For index = 0 To Codes.Count - 1
                                If ShouldStop Then Exit For
                                Dim ASIN = Codes.ElementAt(index)
                                Driver.Navigate.GoToUrl($"https://www.amazon.com/dp/{ASIN}")
                                Dim Title = Clean(Driver.Title)
                                setInfo($"[{index + 1}/{ Codes.Count}] {ASIN} {Title}")
                                Dim isValid = Not Title.Contains("not found")
                                sw.WriteLine(String.Join(vbTab, New String() {ASIN, isValid, Title}))
                            Next
                        End Using
                    End Using
                    setInfo("Finished scraping")
                Catch ex As Exception
                    setInfo($"Error:{ex.Message}")
                End Try
            End Sub)
        StartBtn.Visible = True
    End Sub

    Sub setInfo(info)
        InfoLabel.Invoke(Sub() InfoLabel.Text = info)
    End Sub

    Private Sub LinkSlimjet_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkSlimjet.LinkClicked
        Process.Start("https://www.slimjet.com/release/archive/38.0.9.0/sjtsetup_x64.exe")
    End Sub
    Sub setStatus()
        Dim isSlimjetInstalled = File.Exists(Slimjet)
        LinkSlimjet.LinkColor = If(isSlimjetInstalled, Color.Green, Color.Red)
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setStatus()
    End Sub
End Class
