using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace Dierenpark
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int offset = 0;
        private void AddPersoon_Click(object sender, EventArgs e)
        {
            if ((offset / 22) < 1)
            {
                this.Controls.Remove(AddPersoon);
                foreach (Control c in Controls)
                {
                    if (c.GetType() != typeof(DateTimePicker) && c.Name != "NO")
                    {
                        c.Location += new Size(0, 21);
                    }
                }
                offset += 22;
                Point loc = new Point(108, 12 + offset);
                Point loc2 = new Point(50, 15 + offset);
                DateTimePicker dateTimePick = new DateTimePicker();
                dateTimePick.Location = loc;
                Label persoon = new Label();
                persoon.Location = loc2;
                persoon.Name = "NO";
                persoon.Size = new Size(52, 15);
                persoon.Text = "Persoon" + ((offset / 22) + 1).ToString();
                this.Controls.Add(dateTimePick);
                this.Controls.Add(persoon);
                this.Size += new Size(0, 20);
            }
        }
        private Boolean over65()
        {
            int leeftijd = 0;
            foreach (Control c in Controls)
            {
                if (c.GetType() == typeof(DateTimePicker))
                {
                    DateTimePicker persoonDate = (DateTimePicker)c;
                    DateTime zeroTime = new DateTime(1, 1, 1);
                    DateTime now = DateTime.Now;
                    TimeSpan span = now - persoonDate.Value;
                    int years = (zeroTime + span).Year - 1;
                    if (years > leeftijd)
                        leeftijd = years;
                }
            }
            MessageBox.Show(leeftijd.ToString());
            return (leeftijd >= 65);
        }
        private Boolean echtpaar()
        {
            int count = 0;
            foreach (Control c in Controls)
            {
                if (c.GetType() == typeof(DateTimePicker))
                    count++;
            }
            return (count > 1);
        }
        private void Bereken_Click(object sender, EventArgs e)
        {
            int children = 0;
            Decimal geld = 0;
            if (echtpaar())
                geld += 61;
            if (Int32.TryParse(AmountChildren.Text, out children))
            {
                if (children == 1)
                    geld += 71;
                else if (children == 2)
                    geld += 82;
                else if (children > 2)
                    geld += 82 + (children * 11);
            }
            if (echtpaar() && over65())
            {
                geld += 4;
                if (RadioPersoonlijk.Checked)
                    geld += 26;
            }
            else if (RadioPersoonlijk.Checked)
                geld += 30;

            Tarief.Text = "Tarief: " + geld.ToString();
        }

    }
}
