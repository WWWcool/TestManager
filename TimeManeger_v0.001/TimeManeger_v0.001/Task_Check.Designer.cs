namespace TimeManeger_v0._001
{
    partial class Task_Check
    {
        /// <summary> 
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Обязательный метод для поддержки конструктора - не изменяйте 
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Task_Checkbox = new System.Windows.Forms.CheckBox();
            this.Task_label = new System.Windows.Forms.Label();
            this.Task_Priority = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Task_Checkbox
            // 
            this.Task_Checkbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Task_Checkbox.AutoSize = true;
            this.Task_Checkbox.Location = new System.Drawing.Point(10, 10);
            this.Task_Checkbox.Margin = new System.Windows.Forms.Padding(4);
            this.Task_Checkbox.Name = "Task_Checkbox";
            this.Task_Checkbox.Size = new System.Drawing.Size(15, 14);
            this.Task_Checkbox.TabIndex = 0;
            this.Task_Checkbox.UseVisualStyleBackColor = true;
            this.Task_Checkbox.CheckedChanged += new System.EventHandler(this.Task_Check_CheckedChanged);
            // 
            // Task_label
            // 
            this.Task_label.AutoSize = true;
            this.Task_label.Location = new System.Drawing.Point(35, 7);
            this.Task_label.MaximumSize = new System.Drawing.Size(540, 20);
            this.Task_label.Name = "Task_label";
            this.Task_label.Size = new System.Drawing.Size(12, 17);
            this.Task_label.TabIndex = 1;
            this.Task_label.Text = " ";
            // 
            // Task_Priority
            // 
            this.Task_Priority.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Task_Priority.FormattingEnabled = true;
            this.Task_Priority.ItemHeight = 16;
            this.Task_Priority.Items.AddRange(new object[] {
            "Выкл.",
            "Высокий",
            "Средний",
            "Низкий"});
            this.Task_Priority.Location = new System.Drawing.Point(416, 7);
            this.Task_Priority.Name = "Task_Priority";
            this.Task_Priority.Size = new System.Drawing.Size(100, 18);
            this.Task_Priority.TabIndex = 2;
            this.Task_Priority.SelectedIndexChanged += new System.EventHandler(this.Task_Priority_SelectedIndexChanged);
            // 
            // Task_Check
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Task_Priority);
            this.Controls.Add(this.Task_label);
            this.Controls.Add(this.Task_Checkbox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Task_Check";
            this.Size = new System.Drawing.Size(531, 35);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Task_Checkbox;
        private System.Windows.Forms.Label Task_label;
        private System.Windows.Forms.ListBox Task_Priority;

        private string Start_Date, End_Date, To_Date;

        private int Priority;

        public int Rating;

        public bool Get_Checked()
        {
            return Task_Checkbox.Checked;
        }
    }
}
