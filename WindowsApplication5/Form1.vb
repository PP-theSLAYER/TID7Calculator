Imports System
Imports System.Globalization
Imports System.IO
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.ComponentModel

Imports System.Threading

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public worker(4) As BackgroundWorker

    Private Sub StartAllThreads()

        For i = 0 To 3
            worker(i) = New BackgroundWorker
            worker(i).WorkerSupportsCancellation = True

            worker(i).RunWorkerAsync(i)
            AddHandler worker(i).DoWork, AddressOf BackgroundWorker1_DoWork
        Next


    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ProgBar.Minimum = 0
        ProgBar.Maximum = 65535
        ProgBar.Style = ProgressBarStyle.Continuous
        ProgBar.Value = 0

        Button5.Enabled = False
        Button6.Enabled = True
        Call New Action(AddressOf StartAllThreads).BeginInvoke(Nothing, Nothing)
    End Sub

    Public Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        BackgroundWorker1.WorkerSupportsCancellation = True

        Dim p_threadid As Integer = CInt(e.Argument) + 1
        Dim intendedvalue As Integer = Find_G7TID.Text
        Dim final As Integer = 0
        Dim finalstring As String = ""
        Dim i_TID As Integer = 0
        Dim i_SID As Integer = 0

        Dim finallength As Integer = 0

        i_TID = (65536 / 4) * (p_threadid - 1)
        While i_TID < ((65535 / 4) * p_threadid) - 1
            i_SID = 0
            While i_SID < 65535

                If BackgroundWorker1.CancellationPending Then
                    e.Cancel = True
                    Invoke(Sub()
                               Button5.Enabled = True
                               Button6.Enabled = False
                               'BackgroundWorker1.Dispose()
                               'worker(p_threadid - 1).Dispose()
                           End Sub)
                    Exit Sub
                End If


                final = i_TID + (i_SID * 65536)
                finallength = final.ToString.Length

                If finallength > 8 Then
                    final = final.ToString().Substring(finallength - 8, 8)
                    finallength = final.ToString.Length
                End If

                Dim truth As Integer = 0
                If final >= 0 Then
                    If finallength < 6 Then
                        If final = intendedvalue Then

                            Invoke(Sub()
                                       datagrid2.Rows.Add()
                                       datagrid2.Rows(datagrid2.RowCount - 2).Cells(0).Value = i_TID
                                       datagrid2.Rows(datagrid2.RowCount - 2).Cells(1).Value = i_SID
                                       datagrid2.Rows(datagrid2.RowCount - 2).Cells(2).Value = final
                                       datagrid2.Rows(datagrid2.RowCount - 2).Cells(3).Value = intendedvalue
                                       datagrid2.Refresh()
                                       datagrid2.FirstDisplayedScrollingRowIndex = datagrid2.RowCount - 1
                                   End Sub)
                        End If
                    Else
                        If Val(final.ToString().Substring(finallength - 6, 6)) = intendedvalue Then
                            Invoke(Sub()
                                       datagrid2.Rows.Add()
                                       datagrid2.Rows(datagrid2.RowCount - 2).Cells(0).Value = i_TID
                                       datagrid2.Rows(datagrid2.RowCount - 2).Cells(1).Value = i_SID
                                       datagrid2.Rows(datagrid2.RowCount - 2).Cells(2).Value = final
                                       datagrid2.Rows(datagrid2.RowCount - 2).Cells(3).Value = intendedvalue
                                       datagrid2.Refresh()
                                       datagrid2.FirstDisplayedScrollingRowIndex = datagrid2.RowCount - 1
                                   End Sub)
                        End If
                    End If
                End If

                i_SID = i_SID + 1
            End While
            Invoke(Sub()
                       ProgBar.Increment(1)
                   End Sub)
            i_TID = i_TID + 1
        End While
        If ProgBar.Value >= 65535 Then
            Invoke(Sub()
                       Button5.Enabled = True
                       BackgroundWorker1.Dispose()
                   End Sub)
        End If


    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        For i = 0 To 3
            ' If worker(i).IsBusy Then
            worker(i).CancelAsync()
            BackgroundWorker1.CancelAsync()
            worker(i).Dispose()
            BackgroundWorker1.Dispose()

            'End If
        Next
    End Sub
End Class
