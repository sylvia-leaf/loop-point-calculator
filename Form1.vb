Public Class Form1
    Public RepeatLength As UInt32
    Public CrossfadeStart As UInt32
    Public CrossfadeEnd As UInt32
    Public LoopStart As UInt32
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Copyright 2021, 2024 Sylvia Leaf (sylvia-leaf)

This program is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License as published by the Free Software Foundation, either version 3 of the License, or (at your option) any later version.

This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General Public License for more details.")
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("1. Please select the repeat region (for instance: 10000 - 99999), and then you can use the 'repeat' function on your audio editor. Repeat only once.
2. The crossfade region will be [repeat end] - [crossfade length] + 1 to [repeat end] + [crossfade length] + 1 (for instance: 80000 - 120000). Make sure that the calculated values are not out of bounds!
3. Save the crossfade region.
4. Crossfade the samples. (This feature might only work for individually selected tracks, depending on the audio editor used.)
5. Load the region to other tracks, then repeat step 4.
6. The new loop region is 30000 - 99999 ([repeat end] + [crossfade length] to [Repeat end].")
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
