using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TimeManeger_v0._001
{
    class Task_Check : System.Windows.Forms.CheckBox
    {
        //public float Priority;
        //public int Time_Start, Time_End, Time_Finished;
        //public string Notes;
       // public string Text;
        private System.Windows.Forms.CheckBox Task_Checkbox = new System.Windows.Forms.CheckBox();
        private System.Windows.Forms.Label Task_Label = new System.Windows.Forms.Label();
        /*
         ****************Поля из МИЛКИ********************
        ----Выполнить к: не указано
        Повтор: нет
        ----Продолжительность: нет
        Теги: нет
        Место: нет
        URL: нет
        Отложено: ни разу
        Открыто для: никого
        ----Заметки: 0
         * ***********************************************
         */
        public Task_Check(int x, int y, int width, int height)
        {
            System.Windows.Forms.CheckBox tmp_Check = new System.Windows.Forms.CheckBox();
            System.Windows.Forms.Label tmp_Label = new System.Windows.Forms.Label();
            tmp_Check.Location = new System.Drawing.Point(x, y);
            tmp_Label.Location = new System.Drawing.Point(x, y);
            tmp_Check.Size = new System.Drawing.Size(width, height);
            tmp_Label.Size = new System.Drawing.Size(width, height);
            tmp_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            tmp_Check.CheckedChanged += new EventHandler(Label_back_Change);
            Task_Checkbox = tmp_Check;
            Task_Label = tmp_Label; 
        }

        private void Label_back_Change(object sender, EventArgs e)
        {
            System.Windows.Forms.CheckBox tmp_Check = new System.Windows.Forms.CheckBox();
            tmp_Check = (System.Windows.Forms.CheckBox)sender;
            if (tmp_Check.Checked)
            {
                Task_Label.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            }
            else
            {
                Task_Label.BackColor = System.Drawing.Color.White;
            }
        }

        public void Set_text(string Text)
        {
            Task_Label.Text = Text;
        }
    }
}
