Imports System.IO

Public Class Form1
    Dim adjectives As New List(Of String)
    Dim nouns As New List(Of String)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For Each l As String In File.ReadAllLines("adj.txt")
            adjectives.Add(l)
        Next
        For Each l As String In File.ReadAllLines("noun.txt")
            nouns.Add(l)
        Next

        Dim rand As New Random()
        Dim adj As String = adjectives(rand.Next(0, adjectives.Count))
        Dim nn As String = nouns(rand.Next(0, nouns.Count))
        MessageBox.Show(adj & " " & nn)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For Each l As String In File.ReadAllLines("adj.txt")
            adjectives.Add(l)
        Next
        For Each l As String In File.ReadAllLines("noun.txt")
            nouns.Add(l)
        Next

        Dim rand As New Random()
        Dim adj As String = adjectives(rand.Next(0, adjectives.Count))
        Dim adj2 As String = adjectives(rand.Next(0, adjectives.Count))
        Dim nn As String = nouns(rand.Next(0, nouns.Count))
        MessageBox.Show(adj & ", " & adj2 & " " & nn)
    End Sub
End Class
