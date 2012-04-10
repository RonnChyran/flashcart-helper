﻿'=====================================
'This class allows for pre-main menu code
'e.g, an update routine
'=====================================

#Region "LICENSE"
'  This file is part of FlashcartHelper.
'
'  FlashcartHelper is free software: you can redistribute it and/or modify
'  it under the terms of the GNU General Public License as published by
'  the Free Software Foundation, either version 3 of the License, or
'  (at your option) any later version.

'  FlashcartHelper is distributed in the hope that it will be useful,
'  but WITHOUT ANY WARRANTY; without even the implied warranty of
'  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'  GNU General Public License for more details.
'
'  You should have received a copy of the GNU General Public License
'  along with FlashcartHelper.  If not, see <http://www.gnu.org/licenses/>.
#End Region

Public Class Menu1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        UpdateChecker()

        FHMenu.Show()
        Me.Hide()
    End Sub

    Public Sub UpdateChecker()
        Dim CurrentVer As String
        CurrentVer = My.Application.Info.Version.ToString()
        Dim NewVer As String
        If My.Computer.FileSystem.FileExists(Application.StartupPath + "/version.txt") Then
            My.Computer.FileSystem.DeleteFile(Application.StartupPath + "/version.txt")
        End If
        My.Computer.Network.DownloadFile("http://flashcarthelper.punyman.com/ApplicationDependencies/version.txt", Application.StartupPath + "/version.txt")
        NewVer = My.Computer.FileSystem.ReadAllText(Application.StartupPath + "/version.txt")
        If CurrentVer < NewVer Then
            'MsgBox("New Version Availible")
            'If My.Computer.FileSystem.FileExists(Application.StartupPath + "/FlashcartHelper.exe.old") Then
            'My.Computer.FileSystem.DeleteFile(Application.StartupPath + "/FlashcartHelper.exe.old")
            'End If
            'My.Computer.FileSystem.RenameFile(Application.StartupPath + "/FlashcartHelper.exe", "FlashcartHelper.exe.old")
            'My.Computer.Network.DownloadFile("http://BlahBlahBlah.blah.blah/fh/dl", Application.StartupPath + "/FlashcartHelper.exe", "", "", True, 500, False)
        End If

        My.Computer.FileSystem.DeleteFile(Application.StartupPath + "/version.txt")
    End Sub

End Class



