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
            this.pnl_Task = new System.Windows.Forms.Panel();
            this.btn_Analis = new System.Windows.Forms.Button();
            this.btn_Celender = new System.Windows.Forms.Button();
            this.btn_FinanceForm = new System.Windows.Forms.Button();
            this.btn_Relax = new System.Windows.Forms.Button();
            this.err_TimeManager = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_Options = new System.Windows.Forms.Button();
            this.pnl_Time_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err_TimeManager)).BeginInit();
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
            this.pnl_Time_top.Controls.Add(this.cmb_TaskMenu);
            this.pnl_Time_top.Controls.Add(this.text_NewTask);
            resources.ApplyResources(this.pnl_Time_top, "pnl_Time_top");
            this.pnl_Time_top.Name = "pnl_Time_top";
            // 
            // cmb_TaskMenu
            // 
            this.cmb_TaskMenu.FormattingEnabled = true;
            resources.ApplyResources(this.cmb_TaskMenu, "cmb_TaskMenu");
            this.cmb_TaskMenu.Name = "cmb_TaskMenu";
            this.cmb_TaskMenu.SelectedIndexChanged += new System.EventHandler(this.cmb_TaskMenu_SelectedIndexChanged);
            // 
            // pnl_Task
            // 
            this.pnl_Task.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.pnl_Task, "pnl_Task");
            this.pnl_Task.Name = "pnl_Task";
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
            // btn_FinanceForm
            // 
            resources.ApplyResources(this.btn_FinanceForm, "btn_FinanceForm");
            this.btn_FinanceForm.Name = "btn_FinanceForm";
            this.btn_FinanceForm.UseVisualStyleBackColor = true;
            // 
            // btn_Relax
            // 
            resources.ApplyResources(this.btn_Relax, "btn_Relax");
            this.btn_Relax.Name = "btn_Relax";
            this.btn_Relax.UseVisualStyleBackColor = true;
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
            // f_Main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Options);
            this.Controls.Add(this.btn_Relax);
            this.Controls.Add(this.btn_FinanceForm);
            this.Controls.Add(this.btn_Celender);
            this.Controls.Add(this.btn_Analis);
            this.Controls.Add(this.pnl_Task);
            this.Controls.Add(this.pnl_Time_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "f_Main";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.f_Main_KeyPress);
            this.pnl_Time_top.ResumeLayout(false);
            this.pnl_Time_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err_TimeManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox text_NewTask;
        private System.Windows.Forms.Panel pnl_Time_top;
        private System.Windows.Forms.Panel pnl_Task;
        private System.Windows.Forms.Button btn_Analis;
        private System.Windows.Forms.Button btn_Celender;
        private System.Windows.Forms.Button btn_FinanceForm;
        private System.Windows.Forms.Button btn_Relax;
        private System.Windows.Forms.ErrorProvider err_TimeManager;
        private System.Windows.Forms.Button btn_Options;
        private System.Windows.Forms.ComboBox cmb_TaskMenu;
    }
}

