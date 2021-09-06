Public Class Form1
    Public RepeatLength As UInt32
    Public CrossfadeStart As UInt32
    Public CrossfadeEnd As UInt32
    Public LoopStart As UInt32
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Copyright 2021 strixSF2 (@starguardian2004). All Rights Reserved.

Stardream Studios Advanced Loop Point Calculator is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License as published by the Free Software Foundation, either version 3 of the License, or (at your option) any later version.

This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General Public License for more details.")
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("1. Choose the repeat region (Example: 10000 - 99999) and use the 'repeat' function on your audio editor - repeat once.
2. Choose the crossfade region (Repeat End - 'crossfade length' + 1 to Repeat End + 'crossfade length' + 1. 
Example: 80000 - 120000). Make sure that the calculated values are not out of bounds!
3. Save the crossfade region.
4. Do crossfade. (This feature may only work for selected single-track, depending on audio editor)
5. Load the region to other tracks, then repeat step 4.
6. The new loop region is 30000 - 99999 (Repeat Start + 'crossfade length' to Repeat End).")
    End Sub
    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        If NumericUpDown1.Value > NumericUpDown2.Value Then
            NumericUpDown1.Value = NumericUpDown2.Value
        End If
        UpdateRepeatLength()
        UpdateLoopStart()
    End Sub
    Private Sub NumericUpDown2_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown2.ValueChanged
        If NumericUpDown2.Value < NumericUpDown1.Value Then
            NumericUpDown2.Value = NumericUpDown1.Value
        End If
        UpdateRepeatLength()
    End Sub
    Sub UpdateRepeatLength()
        RepeatLength = NumericUpDown2.Value - NumericUpDown1.Value
        TextBox1.Text = Trim(Str(RepeatLength)) + " Sample"
        If Not RepeatLength = 1 Then
            TextBox1.Text += "s"
        End If
        TextBox4.Text = Trim(Str(NumericUpDown2.Value)) + " Sample"
        If Not NumericUpDown2.Value = 1 Then
            TextBox4.Text += "s"
        End If
    End Sub
    Private Sub NumericUpDown3_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown3.ValueChanged
        If NumericUpDown3.Value > RepeatLength Then
            NumericUpDown3.Value = RepeatLength
        End If
        UpdateCrossfadeLength()
        UpdateLoopStart()
    End Sub
    Sub UpdateCrossfadeLength()
        CrossfadeStart = NumericUpDown2.Value + 1 - NumericUpDown3.Value
        CrossfadeEnd = NumericUpDown2.Value + 1 + NumericUpDown3.Value
        TextBox2.Text = Trim(Str(CrossfadeStart)) + " Sample"
        TextBox3.Text = Trim(Str(CrossfadeEnd)) + " Sample"
        If Not CrossfadeStart = 1 Then
            TextBox2.Text += "s"
        End If
        If Not CrossfadeEnd = 1 Then
            TextBox3.Text += "s"
        End If
    End Sub
    Sub UpdateLoopStart()
        LoopStart = NumericUpDown1.Value + NumericUpDown3.Value
        TextBox5.Text = Trim(Str(LoopStart)) + " Sample"
        If Not LoopStart = 1 Then
            TextBox5.Text += "s"
        End If
    End Sub
End Class
