Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Computer.Network.DownloadFile("http://puu.sh/o8Jhh/80742a15b5.py", "C:\Users\Jonathan\Documents\MSMGUI\install.py")
        MsgBox("Download Complete")
        Process1.Start()
        Timer1.Start()
        MsgBox("Install complete")
        Form2.Show()









    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("Good Bye", MsgBoxStyle.DefaultButton1)
        End

    End Sub
End Class
