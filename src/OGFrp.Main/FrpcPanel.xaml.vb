﻿Imports OGFrp.UI

Public Class FrpcPanel

    Dim fctn As FrpcCollections

    Dim Assets As AssetModel

    Dim ServerSelectionWindow As New ServerSelectionWindow

    Public Sub _init_(ByVal token As String, ByVal Assets As AssetModel)
        Me.Grid.Height = 0
        Me.Assets = Assets
        fctn = New FrpcCollections(token)
        fctn.getFrpcConfigCollection()
        Dim fcCtn = fctn.ProxyDisplays()
        For i = 0 To fcCtn.ToArray.Length - 1
            Dim fc = fcCtn(i)
            fc.AutoDisplay()
            fc.HorizontalAlignment = HorizontalAlignment.Center
            fc.VerticalAlignment = VerticalAlignment.Top
            fc.Width = Me.Grid.Width - 40
            fc.Height = 80
            fc.Margin = New Thickness(20, 5 + 85 * i, 20, 0)
            fc.SetViewLogContent(Assets.ViewLog)
            fc.text_Duplicated = Assets.Duplicated
            fc.SetDuplicateNotice(Assets.ClickToDuplicate)
            fc.SetTextForeColor(Brushes.Black)
            Me.Grid.Children.Add(fc)
            Me.Grid.Height += 85
        Next
        Me.Grid.Height += 5
    End Sub

    Public Sub CloseAllFrpc()
        For Each fc As FrpcCover In Me.Grid.Children
            fc.frpc.Kill()
        Next
    End Sub

End Class
