Public Class Form4
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        My.Computer.Network.DownloadFile("http://tcpr.ca/files/spigot/spigot-1.8-R0.1-SNAPSHOT-latest.jar", "C:\Users\Jonathan\Documents\MSMGUI\Server\LaunchSpigotServer.jar")
        MsgBox("Download Complete")
        Process1.Start()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Computer.Network.DownloadFile("http://tcpr.ca/files/spigot/spigot-latest.jar", "C:\Users\Jonathan\Documents\MSMGUI\Server\LaunchSpigotServer.jar")
        MsgBox("Download Complete")
        Process1.Start()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        My.Computer.Network.DownloadFile("http://tcpr.ca/files/spigot/spigot-1.9-R0.1-SNAPSHOT-latest.jar", "C:\Users\Jonathan\Documents\MSMGUI\Server\LaunchSpigotServer.jar")
        MsgBox("Download Complete")
        Process1.Start()




    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        My.Computer.Network.DownloadFile("http://tcpr.ca/files/spigot/spigot-1.7.10-SNAPSHOT-b1657.jar
", "C:\Users\Jonathan\Documents\MSMGUI\Server\LaunchSpigotServer.jar")
        MsgBox("Download Complete")
        Process1.Start()
    End Sub
End Class
