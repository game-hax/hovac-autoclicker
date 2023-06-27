using autoclicker.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autoclicker.Tabs
{
    public partial class Settings : UserControl
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Update()
        {
            SelectColour.ForeColor = UI.colour;
            SelectColour.Image = UI.recolour(Resources.palette);
            SelectColour.Text = $" Selected: {UI.colour.Name}";
            Credit.ForeColor = UI.colour;
            Credit.LinkColor = UI.colour;
            Credit.ActiveLinkColor = UI.colour;
            Credit.VisitedLinkColor = UI.colour;
        }

        private void SelectColour_Click(object sender, EventArgs e)
        {
            if (ColourSelector.ShowDialog() == DialogResult.OK) {
                UI.colour = ColourSelector.Color;
                Update();
            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            Update();
        }
    }
}
