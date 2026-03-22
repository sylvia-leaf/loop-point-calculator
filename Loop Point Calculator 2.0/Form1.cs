using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Devices;
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
using System.Security.Policy;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Loop_Point_Calculator_2._0
{
    public partial class Form1 : Form
    {
        protected Decimal repeatLength = 0;
        protected Decimal crossfadeStart = 0;
        protected Decimal crossfadeEnd = 0;
        protected Decimal loopStart = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_license_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Copyright 2021, 2024, 2026 Sylvia Leaf (sylvia-leaf)\n " +
                "This program is free software: you can redistribute it and / or modify it under the terms of the " +
                "GNU General Public License as published by the Free Software Foundation, either version 3 of the " +
                "License, or (at your option) any later version.\n " +
                "This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without " +
                "even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU " +
                "General Public License for more details.");
        }

        private void button_help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. Please select the repeat region (for instance: 10000 - 99999), and then you can use " +
                "the 'repeat' function on your audio editor. Repeat only once. \n" +
                "2. The crossfade region will be [repeat end] - [crossfade length] + 1 to [repeat end] + [crossfade " +
                "length] + 1 (for instance: 80000 - 120000). Make sure that the calculated values are not out of " +
                "bounds!\n" +
                "3. Save the crossfade region.\n" +
                "4. Crossfade the samples. (This feature might only work for individually selected tracks, " +
                "depending on the audio editor used.)\n" +
                "5. Load the region to other tracks, then repeat step 4.\n" +
                "6. The new loop region is 30000 - 99999 ([repeat end] + [crossfade length] to [Repeat end].");
        }

        private void numericUpDown_repStart_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown_repStart.Value = Math.Min(numericUpDown_repStart.Value, numericUpDown_repEnd.Value);
            updateRepeatLength();
            updateLoopStart();
        }

        private void numericUpDown_repEnd_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown_repEnd.Value = Math.Max(numericUpDown_repStart.Value, numericUpDown_repEnd.Value);
            updateRepeatLength();
        }

        private void numericUpDown_xfLength_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown_xfLength.Value = Math.Min(numericUpDown_xfLength.Value, repeatLength);
            updateCrossfadeLength();
            updateLoopStart();
        }

        protected void updateRepeatLength()
        {
            repeatLength = numericUpDown_repEnd.Value - numericUpDown_repStart.Value;
            textBox_repLength.Text = sampleDisplayPluraliser(repeatLength);
            textBox_loopEnd.Text = sampleDisplayPluraliser(numericUpDown_repEnd.Value);
        }
        protected void updateLoopStart()
        {
            loopStart = numericUpDown_repStart.Value + numericUpDown_xfLength.Value;
            textBox_loopStart.Text = sampleDisplayPluraliser(loopStart);
        }
        protected void updateCrossfadeLength()
        {
            crossfadeStart = numericUpDown_repEnd.Value + 1 - numericUpDown_xfLength.Value;
            crossfadeEnd = numericUpDown_repEnd.Value + 1 + numericUpDown_xfLength.Value;
            textBox_xfStart.Text = sampleDisplayPluraliser(crossfadeStart);
            textBox_xfEnd.Text = sampleDisplayPluraliser(crossfadeEnd);
        }
        protected string sampleDisplayPluraliser(Decimal inputValue)
        {
            if (inputValue == 1)
            {
                return $"{inputValue + " Sample"}";
            } else
            {
                return $"{inputValue + " Samples"}";
            }
        }
    }
}
