using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TimeManeger_v0._001
{
    public partial class Task_Check : UserControl
    {
        public Task_Check()
        {
            InitializeComponent();
        }

        private void Task_Check_CheckedChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.CheckBox tmp_Check = new System.Windows.Forms.CheckBox();
            tmp_Check = (System.Windows.Forms.CheckBox)sender;
            if (tmp_Check.Checked)
            {
                this.BackColor = System.Drawing.Color.FromArgb(70, 156, 109);
            }
            else
            {
                this.BackColor = System.Drawing.Color.FromArgb(142, 192, 165);
            }
        }
        public void Set_text(string Text)
        {
            Task_label.Text = Text;
        }

        private void Task_Priority_SelectedIndexChanged(object sender, EventArgs e)
        {
           ListBox tmp = new ListBox();
            tmp = (ListBox)sender;
            this.Priority = tmp.SelectedIndex;
            ReRating();
        }
        public void ReRating()
        {
            this.Rating = this.Priority;
        }

    }
}
