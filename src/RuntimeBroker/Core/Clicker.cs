using autoclicker.Core.Hooks;
using autoclicker.Core.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static autoclicker.Core.Hooks.Mouse;

namespace autoclicker.Core
{
    public class Clicker
    {
        public Settings settings = new Settings();

        public Clicker() {
            Scroll.Install();
            Scroll.ScrollEvent += ScrollclickEvent;
            Mouse.Install();
            Mouse.MouseEvent += ClickersEvent;
            new Thread(new ThreadStart(HoldclickEvent)).Start();
            new Thread(new ThreadStart(AutoclickerEvent)).Start();
        }

        private void ScrollclickEvent()
        {
            if (settings.scrollEnabled) {
                Thread thread = new Thread(new ThreadStart(() => Click._Click(false)));
                thread.Start();
            }
        }

        // no debounce
        public bool clicking = false;
        public bool multiclicking = false;
        public bool blockhitting = false;

        // multiclick and blockhit handler
        private void ClickersEvent(MouseButton mouseButton)
        {
            if (!blockhitting && settings.blockhitEnabled && mouseButton == MouseButton.Left) { 
                blockhitting = true;
                new Thread(new ThreadStart(() => Click.Right(false))).Start();
            }
            if (!multiclicking && settings.multiclickEnabled)
            {
                multiclicking = true;
                if (mouseButton == MouseButton.Left && settings.lmbEnabled)
                    for (int i = 2; i <= settings.multiclickMultiplier; i += 1)
                        new Thread(new ThreadStart(() => Click.Left(false))).Start();
                if (mouseButton == MouseButton.Middle && settings.mmbEnabled)
                    for (int i = 2; i <= settings.multiclickMultiplier; i += 1)
                        new Thread(new ThreadStart(() => Click.Middle(false))).Start();
                if (mouseButton == MouseButton.Right && settings.rmbEnabled)
                    for (int i = 2; i <= settings.multiclickMultiplier; i += 1)
                        new Thread(new ThreadStart(() => Click.Right(false))).Start();
            }
        }

        // holdclicker handler
        private void HoldclickEvent()
        {
            for (; ; )
            {
                Thread.Sleep(1);
                if (settings.holdclickerEnabled && !clicking)
                {
                    if (Control.MouseButtons == MouseButtons.Left && settings.lmbEnabled)
                    {
                        clicking = true;
                        Click.Left(true); 
                        clicking = false;
                    }
                    if (Control.MouseButtons == MouseButtons.Middle && settings.mmbEnabled)
                    {
                        clicking = true;
                        Click.Middle(true);
                        clicking = false;
                    }
                    if (Control.MouseButtons == MouseButtons.Right && settings.rmbEnabled)
                    {
                        clicking = true;
                        Click.Right(true);
                        clicking = false;
                    }
                }
            }
        }

        // autoclicker handler
        private void AutoclickerEvent()
        {
            for (; ; )
            {
                if (settings.randomizerEnabled)
                    Click.Wait();
                Thread.Sleep(1);
                if (settings.autoclickerEnabled)
                {
                    new Thread(new ThreadStart(() => Click._Click(false))).Start();
                }
            }
        }
    }
    public class Settings {
        // mouse buttons
        public bool lmbEnabled = false, mmbEnabled = false, rmbEnabled = false;
        // modes
        public bool holdclickerEnabled = false, blockhitEnabled = false, autoclickerEnabled = false, multiclickEnabled = false, scrollEnabled = false;
        public int multiclickMultiplier = 2;
        // randomizer
        public bool randomizerEnabled = false;
        public int minRandomizer = 0, maxRandomizer = 0;
        // click sounds
        public bool clickSoundsEnabled = false;
        public string soundPath = "";
        // other
        public bool oimEnabled = false, breakblocksEnabled = false, dimEnabled = false;
        // slots
        public int currentSlot = 0;
        public bool whitelistedSlotsEnabled = false;
        public bool[] whitelistedSlots = new bool[10];
    }
}
