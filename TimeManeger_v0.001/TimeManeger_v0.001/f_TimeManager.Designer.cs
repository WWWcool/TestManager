namespace TimeManeger_v0._001
{
    partial class f_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_Main));
            this.text_NewTask = new System.Windows.Forms.TextBox();
            this.pnl_Time_top = new System.Windows.Forms.Panel();
            this.cmb_TaskMenu = new System.Windows.Forms.ComboBox();
            this.btn_Analis = new System.Windows.Forms.Button();
            this.btn_Celender = new System.Windows.Forms.Button();
            this.err_TimeManager = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_Options = new System.Windows.Forms.Button();
            this.Main_tab = new System.Windows.Forms.TabControl();
            this.P_Time = new System.Windows.Forms.TabPage();
            this.pnl_Task = new System.Windows.Forms.Panel();
            this.P_Finance = new System.Windows.Forms.TabPage();
            this.P_Relax = new System.Windows.Forms.TabPage();
            this.P_Options = new System.Windows.Forms.TabPage();
            this.lbl_Priority = new System.Windows.Forms.Label();
            this.pnl_Time_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err_TimeManager)).BeginInit();
            this.Main_tab.SuspendLayout();
            this.P_Time.SuspendLayout();
            this.SuspendLayout();
            // 
            // text_NewTask
            // 
            resources.ApplyResources(this.text_NewTask, "text_NewTask");
            this.text_NewTask.Name = "text_NewTask";
            this.text_NewTask.MouseClick += new System.Windows.Forms.MouseEventHandler(this.text_NewTask_MouseClick);
            this.text_NewTask.TextChanged += new System.EventHandler(this.text_NewTask_TextChanged);
            this.text_NewTask.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.f_Main_KeyPress);
            this.text_NewTask.Leave += new System.EventHandler(this.text_NewTask_Leave);
            // 
            // pnl_Time_top
            // 
            this.pnl_Time_top.Controls.Add(this.lbl_Priority);
            this.pnl_Time_top.Controls.Add(this.cmb_TaskMenu);
            this.pnl_Time_top.Controls.Add(this.text_NewTask);
            resources.ApplyResources(this.pnl_Time_top, "pnl_Time_top");
            this.pnl_Time_top.Name = "pnl_Time_top";
            // 
            // cmb_TaskMenu
            // 
            this.cmb_TaskMenu.DropDownWidth = 300;
            this.cmb_TaskMenu.FormattingEnabled = true;
            resources.ApplyResources(this.cmb_TaskMenu, "cmb_TaskMenu");
            this.cmb_TaskMenu.Name = "cmb_TaskMenu";
            this.cmb_TaskMenu.SelectedIndexChanged += new System.EventHandler(this.cmb_TaskMenu_SelectedIndexChanged);
            // 
            // btn_Analis
            // 
            resources.ApplyResources(this.btn_Analis, "btn_Analis");
            this.btn_Analis.Name = "btn_Analis";
            this.btn_Analis.UseVisualStyleBackColor = true;
            // 
            // btn_Celender
            // 
            resources.ApplyResources(this.btn_Celender, "btn_Celender");
            this.btn_Celender.Name = "btn_Celender";
            this.btn_Celender.UseVisualStyleBackColor = true;
            // 
            // err_TimeManager
            // 
            this.err_TimeManager.ContainerControl = this;
            // 
            // btn_Options
            // 
            resources.ApplyResources(this.btn_Options, "btn_Options");
            this.btn_Options.Name = "btn_Options";
            this.btn_Options.UseVisualStyleBackColor = true;
            this.btn_Options.Click += new System.EventHandler(this.btn_Options_Click);
            // 
            // Main_tab
            // 
            resources.ApplyResources(this.Main_tab, "Main_tab");
            this.Main_tab.Controls.Add(this.P_Time);
            this.Main_tab.Controls.Add(this.P_Finance);
            this.Main_tab.Controls.Add(this.P_Relax);
            this.Main_tab.Controls.Add(this.P_Options);
            this.Main_tab.Name = "Main_tab";
            this.Main_tab.SelectedIndex = 0;
            // 
            // P_Time
            // 
            this.P_Time.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(84)))), ((int)(((byte)(51)))));
            this.P_Time.Controls.Add(this.pnl_Time_top);
            this.P_Time.Controls.Add(this.btn_Options);
            this.P_Time.Controls.Add(this.pnl_Task);
            this.P_Time.Controls.Add(this.btn_Analis);
            this.P_Time.Controls.Add(this.btn_Celender);
            resources.ApplyResources(this.P_Time, "P_Time");
            this.P_Time.Name = "P_Time";
            // 
            // pnl_Task
            // 
            this.pnl_Task.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(192)))), ((int)(((byte)(165)))));
            resources.ApplyResources(this.pnl_Task, "pnl_Task");
            this.pnl_Task.Name = "pnl_Task";
            // 
            // P_Finance
            // 
            resources.ApplyResources(this.P_Finance, "P_Finance");
            this.P_Finance.Name = "P_Finance";
            this.P_Finance.UseVisualStyleBackColor = true;
            // 
            // P_Relax
            // 
            resources.ApplyResources(this.P_Relax, "P_Relax");
            this.P_Relax.Name = "P_Relax";
            this.P_Relax.UseVisualStyleBackColor = true;
            // 
            // P_Options
            // 
            resources.ApplyResources(this.P_Options, "P_Options");
            this.P_Options.Name = "P_Options";
            this.P_Options.UseVisualStyleBackColor = true;
            // 
            // lbl_Priority
            // 
            resources.ApplyResources(this.lbl_Priority, "lbl_Priority");
            this.lbl_Priority.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(192)))), ((int)(((byte)(165)))));
            this.lbl_Priority.Name = "lbl_Priority";
            // 
            // f_Main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(97)))), ((int)(((byte)(78)))));
            this.Controls.Add(this.Main_tab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "f_Main";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.f_Main_KeyPress);
            this.pnl_Time_top.ResumeLayout(false);
            this.pnl_Time_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err_TimeManager)).EndInit();
            this.Main_tab.ResumeLayout(false);
            this.P_Time.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox text_NewTask;
        private System.Windows.Forms.Panel pnl_Time_top;
        private System.Windows.Forms.Button btn_Analis;
        private System.Windows.Forms.Button btn_Celender;
        private System.Windows.Forms.ErrorProvider err_TimeManager;
        private System.Windows.Forms.Button btn_Options;
        private System.Windows.Forms.ComboBox cmb_TaskMenu;
        private System.Windows.Forms.TabControl Main_tab;
        private System.Windows.Forms.TabPage P_Time;
        private System.Windows.Forms.Panel pnl_Task;
        private System.Windows.Forms.TabPage P_Finance;
        private System.Windows.Forms.TabPage P_Relax;
        private System.Windows.Forms.TabPage P_Options;
        private System.Windows.Forms.Label lbl_Priority;
    }
}

