using autoclicker.Core;
using autoclicker.Core.Hooks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autoclicker.Tabs
{
    public partial class Autoclicker : UserControl
    {
        private static Clicker clicker = UI.clicker;

        public Autoclicker()
        {
            InitializeComponent();
            Keyboard.Install();
            Keyboard.KeyUp += this.KeybindEvent;
            Keyboard.KeyUp += this.SlotsEvent;
        }

        private void Minimum_ValueChanged(object sender, EventArgs e)
        {
            MinimumValue.Text = Minimum.Value.ToString();
        }

        private void Maximum_ValueChanged(object sender, EventArgs e)
        {
            MaximumValue.Text = Maximum.Value.ToString();
        }

        private void SelectSound_Click(object sender, EventArgs e)
        {
            if (SoundSelector.ShowDialog() == DialogResult.OK)
            {
                SoundPlayer snd = new SoundPlayer(SoundSelector.FileName);
                SelectSound.Text = $" {SoundSelector.SafeFileName}";
                snd.Play();
            }
        }

        private void UpdateSettings_Tick(object sender, EventArgs e)
        {
            // mouse buttons
            clicker.settings.lmbEnabled = EnableLMB.Checked;
            clicker.settings.mmbEnabled = EnableMMB.Checked;
            clicker.settings.rmbEnabled = EnableRMB.Checked;
            // modes
            clicker.settings.holdclickerEnabled = EnableHoldclick.Checked;
            clicker.settings.blockhitEnabled = EnableBlockhit.Checked;
            clicker.settings.autoclickerEnabled = EnableAutoclicker.Checked;
            clicker.settings.multiclickEnabled = EnableMulticlick.Checked;
            clicker.settings.multiclickMultiplier = MulticlickMultiplier.Value;
            clicker.settings.scrollEnabled = EnableScrollclick.Checked;
            // randomizer
            clicker.settings.randomizerEnabled = EnableRandomizer.Checked;
            clicker.settings.minRandomizer = Minimum.Value;
            clicker.settings.maxRandomizer = Maximum.Value;
            // click sounds
            clicker.settings.clickSoundsEnabled = EnableClicksounds.Checked;
            clicker.settings.soundPath = SoundSelector.FileName;
            // other
            clicker.settings.oimEnabled = EnableOIM.Checked;
            EnableBreakblocks.Enabled = EnableOIM.Checked;
            clicker.settings.breakblocksEnabled = EnableBreakblocks.Checked;
            clicker.settings.dimEnabled = EnableDIM.Checked;
            // slots
            clicker.settings.whitelistedSlotsEnabled = EnableWhitelistedSlots.Checked;
            clicker.settings.whitelistedSlots[1] = !Slot1.Checked;
            clicker.settings.whitelistedSlots[2] = !Slot2.Checked;
            clicker.settings.whitelistedSlots[3] = !Slot3.Checked;
            clicker.settings.whitelistedSlots[4] = !Slot4.Checked;
            clicker.settings.whitelistedSlots[5] = !Slot5.Checked;
            clicker.settings.whitelistedSlots[6] = !Slot6.Checked;
            clicker.settings.whitelistedSlots[7] = !Slot7.Checked;
            clicker.settings.whitelistedSlots[8] = !Slot8.Checked;
            clicker.settings.whitelistedSlots[9] = !Slot9.Checked;
        }

        #region Keybinds
        // its bad but it works ^_^

        private string listener = "";

        private Keyboard.VKeys holdclickKey = Keyboard.VKeys.UNKNOWN_KEY;
        private void HoldclickKeybind_Click(object sender, EventArgs e)
        {
            if (listener == "holdclick")
            {
                holdclickKey = Keyboard.VKeys.UNKNOWN_KEY;
                HoldclickKeybind.Text = "[NONE]";
                listener = "";
            }
            else
            {
                HoldclickKeybind.Text = "Listening...";
                listener = "holdclick";
            }
        }

        private Keyboard.VKeys blockhitKey = Keyboard.VKeys.UNKNOWN_KEY;
        private void BlockhitKeybind_Click(object sender, EventArgs e)
        {
            if (listener == "blockhit")
            {
                blockhitKey = Keyboard.VKeys.UNKNOWN_KEY;
                BlockhitKeybind.Text = "[NONE]";
                listener = "";
            }
            else
            {
                BlockhitKeybind.Text = "Listening...";
                listener = "blockhit";
            }
        }

        private Keyboard.VKeys autoclickerKey = Keyboard.VKeys.F6;
        private void AutoclickerKeybind_Click(object sender, EventArgs e)
        {
            if (listener == "autoclicker")
            {
                autoclickerKey = Keyboard.VKeys.UNKNOWN_KEY;
                AutoclickerKeybind.Text = "[NONE]";
                listener = "";
            }
            else
            {
                AutoclickerKeybind.Text = "Listening...";
                listener = "autoclicker";
            }
        }

        private Keyboard.VKeys multiclickKey = Keyboard.VKeys.UNKNOWN_KEY;
        private void MulticlickKeybind_Click(object sender, EventArgs e)
        {
            if (listener == "multiclick")
            {
                multiclickKey = Keyboard.VKeys.UNKNOWN_KEY;
                MulticlickKeybind.Text = "[NONE]";
                listener = "";
            }
            else
            {
                MulticlickKeybind.Text = "Listening...";
                listener = "multiclick";
            }
        }

        private Keyboard.VKeys scrollclickKey = Keyboard.VKeys.UNKNOWN_KEY;
        private void ScrollclickKeybind_Click(object sender, EventArgs e)
        {
            if (listener == "scrollclick")
            {
                scrollclickKey = Keyboard.VKeys.UNKNOWN_KEY;
                ScrollclickKeybind.Text = "[NONE]";
                listener = "";
            }
            else
            {
                ScrollclickKeybind.Text = "Listening...";
                listener = "scrollclick";
            }
        }

        private void KeybindEvent(Keyboard.VKeys key)
        {
            if (listener != "")
            {
                switch (listener)
                {
                    case "holdclick":
                        HoldclickKeybind.Text = $"[{key.ToString()}]";
                        holdclickKey = key;
                        break;
                    case "blockhit":
                        BlockhitKeybind.Text = $"[{key.ToString()}]";
                        blockhitKey = key;
                        break;
                    case "autoclicker":
                        AutoclickerKeybind.Text = $"[{key.ToString()}]";
                        autoclickerKey = key;
                        break;
                    case "multiclick":
                        MulticlickKeybind.Text = $"[{key.ToString()}]";
                        multiclickKey = key;
                        break;
                    case "scrollclick":
                        ScrollclickKeybind.Text = $"[{key.ToString()}]";
                        scrollclickKey = key;
                        break;
                }
                listener = "";
            }
            else
            {
                if (key == holdclickKey)
                    EnableHoldclick.Checked = !EnableHoldclick.Checked;
                if (key == blockhitKey)
                    EnableBlockhit.Checked = !EnableBlockhit.Checked;
                if (key == autoclickerKey)
                    EnableAutoclicker.Checked = !EnableAutoclicker.Checked;
                if (key == multiclickKey)
                    EnableMulticlick.Checked = !EnableMulticlick.Checked;
                if (key == scrollclickKey)
                    EnableScrollclick.Checked = !EnableScrollclick.Checked;
            }
        }

        #endregion

        private void SlotsEvent(Keyboard.VKeys keys)
        {
            switch (keys)
            {
                case Keyboard.VKeys.KEY_1:
                    currentSlot.Text = "Current slot: 1";
                    clicker.settings.currentSlot = 1;
                    break;
                case Keyboard.VKeys.KEY_2:
                    currentSlot.Text = "Current slot: 2";
                    clicker.settings.currentSlot = 2;
                    break;
                case Keyboard.VKeys.KEY_3:
                    currentSlot.Text = "Current slot: 3";
                    clicker.settings.currentSlot = 3;
                    break;
                case Keyboard.VKeys.KEY_4:
                    currentSlot.Text = "Current slot: 4";
                    clicker.settings.currentSlot = 4;
                    break;
                case Keyboard.VKeys.KEY_5:
                    currentSlot.Text = "Current slot: 5";
                    clicker.settings.currentSlot = 5;
                    break;
                case Keyboard.VKeys.KEY_6:
                    currentSlot.Text = "Current slot: 6";
                    clicker.settings.currentSlot = 6;
                    break;
                case Keyboard.VKeys.KEY_7:
                    currentSlot.Text = "Current slot: 7";
                    clicker.settings.currentSlot = 7;
                    break;
                case Keyboard.VKeys.KEY_8:
                    currentSlot.Text = "Current slot: 8";
                    clicker.settings.currentSlot = 8;
                    break;
                case Keyboard.VKeys.KEY_9:
                    currentSlot.Text = "Current slot: 9";
                    clicker.settings.currentSlot = 9;
                    break;
            }
        }
    }
}
