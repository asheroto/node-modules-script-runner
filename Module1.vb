Imports System.IO
Imports System.Text

Module Module1

    Sub Main()
        Dim A() As String = Environment.GetCommandLineArgs()

        Dim ProgName As String = A(0).ToString.Replace(Chr(34), String.Empty).Replace(".exe", String.Empty)
        ProgName = Mid(ProgName, InStrRev(ProgName, "\") + 1)

        Dim Final As New StringBuilder
        For ArgNum = 1 To A.Count - 1
            Final.Append($"{A(ArgNum)} ")
        Next

        Dim BinFolderPath As String = Path.Combine(Directory.GetCurrentDirectory, "node_modules", ".bin")

        Dim FinalPath As String = String.Empty
        Dim IsPowerShell As Boolean

        If File.Exists(Path.Combine(BinFolderPath, ProgName & ".exe")) Then
            FinalPath = Path.Combine(BinFolderPath, ProgName & ".exe")
        ElseIf File.Exists(Path.Combine(BinFolderPath, ProgName & ".cmd")) Then
            FinalPath = Path.Combine(BinFolderPath, ProgName & ".cmd")
        ElseIf File.Exists(Path.Combine(BinFolderPath, ProgName & ".bat")) Then
            FinalPath = Path.Combine(BinFolderPath, ProgName & ".bat")
        ElseIf File.Exists(Path.Combine(BinFolderPath, ProgName & ".ps1")) Then
            FinalPath = Path.Combine(BinFolderPath, ProgName & ".ps1")
            IsPowerShell = True
        Else
            Console.WriteLine($"No programs under node_modules\.bin with program name {ProgName}")
            End
        End If

        Dim f As New Process
        If IsPowerShell = True Then
            Shell($"powershell.exe -ExecutionPolicy Bypass -File ""{FinalPath}"" -Arguments ""{Final.ToString}""")
        Else
            Shell($"{FinalPath} {Final.ToString}")
        End If

        End
    End Sub

End Module
