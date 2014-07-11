using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TimeManeger_v0._001
{
    public partial class f_Main : Form
    {
        f_Options f = new f_Options();
        System.Collections.ArrayList TaskList = new System.Collections.ArrayList();

        public f_Main()
        {
            InitializeComponent();

            cmb_TaskMenu.Items.Add(" Продублировать задачу "); // сделать так чтобы эти строчки нельзя было выбрать
            cmb_TaskMenu.Items.Add(" Перенести задачу ");
            cmb_TaskMenu.Items.Add(" Удалить задачу ");
            
        }

        private void btn_Options_Click(object sender, EventArgs e)
        {
           
            //f.Location = new Point(0, 0);
            f.ShowDialog();
        }

        private void text_NewTask_MouseClick(object sender, MouseEventArgs e)
        {
            TextBox tmp = new TextBox();
            tmp = (TextBox)sender;
            if (tmp.Text == "<<  Добавить новую задачу  >>") text_NewTask.Text = string.Empty;
        }

        private void f_Main_KeyPress(object sender, KeyPressEventArgs e)
        {
            int i = 0;
            
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (text_NewTask.Text == string.Empty) return;
                foreach (Task_Check k in pnl_Task.Controls.OfType<Task_Check>()) i++;
                Task_Check Task_check = new Task_Check();
                Task_check.Set_text(text_NewTask.Text);
                Task_check.Location = new Point(25, 10 + i * 35);
                TaskList.Add(Task_check);
                pnl_Task.Controls.Add(Task_check);
                text_NewTask.Text = "<<  Добавить новую задачу  >>";
                pnl_Task.Focus();
            }
        }

        private void text_NewTask_TextChanged(object sender, EventArgs e)
        {
           // if (text_NewTask.Text == "<<  Добавить новую задачу  >>") text_NewTask.Text = string.Empty;
        }

        private void text_NewTask_Leave(object sender, EventArgs e)
        {
            text_NewTask.Text = "<<  Добавить новую задачу  >>";
        }

        private void cmb_TaskMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmb_TaskMenu.SelectedIndex)
            {
                case 0: // Продублировать
                    break;
                case 1: // Перенести
                    break;
                case 2: // Удалить
                    foreach (Task_Check k in TaskList)
                    {
                         if (k.Get_Checked()) pnl_Task.Controls.Remove(k);
                        // подвинуть к+1 на 1 вверх переделать список чтобы удаленные норм выводились
                    }
                    break;
            }
            pnl_Task.Focus();
        }
        void pnl_Task_Sort(System.Collections.ArrayList ArrayList)
        {
            foreach(Task_Check k in TaskList)
            {
                /* есть список параметров, сортировать будем по максимальному значению суммы параметров,
                 * сортировка по убыванию максимального значения  
                 * копируем лист элементов
                 * Подсчитываем сумму по текущему элементу
                 * ищем максимальный в листе
                 * исключаем найденный максимум - добавляем его на первую позицию при выводе на экран
                 * повторяем поиск до тех пор пока в скопированном листе не останется элементов
                 * 
                */
            }
        }

        private void ExitButton_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }


    }
}
