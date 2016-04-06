Public Class Form3
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Computer.Network.DownloadFile("https://s3.amazonaws.com/Minecraft.Download/versions/" + TextBox1.Text + "/minecraft_server." + TextBox1.Text + ".jar", "C:\Users\Jonathan\Documents\MSMGUI\Server\LaunchServer.jar")
        MsgBox("Sucess !")
        Process1.Start()

    End Sub
End Class