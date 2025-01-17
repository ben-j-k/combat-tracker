﻿namespace CombatTracker
{
    partial class BaseForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            dataGridViewRounds = new DataGridView();
            combatantBindingSource = new BindingSource(components);
            label1 = new Label();
            txtRoundNum = new TextBox();
            btnStart = new Button();
            btnDemo = new Button();
            btnAddOrDelete = new Button();
            btnPrevious = new Button();
            btnStatus = new Button();
            btnDamageHeal = new Button();
            btnNext = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            btnSaveLoad = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRounds).BeginInit();
            ((System.ComponentModel.ISupportInitialize)combatantBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewRounds
            // 
            dataGridViewRounds.AllowUserToResizeRows = false;
            dataGridViewRounds.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewRounds.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewRounds.BackgroundColor = Color.FloralWhite;
            dataGridViewRounds.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewRounds.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FloralWhite;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.ForestGreen;
            dataGridViewCellStyle1.SelectionForeColor = Color.FloralWhite;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewRounds.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewRounds.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FloralWhite;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.ForestGreen;
            dataGridViewCellStyle2.SelectionForeColor = Color.FloralWhite;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewRounds.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewRounds.GridColor = Color.Coral;
            dataGridViewRounds.Location = new Point(14, 193);
            dataGridViewRounds.Name = "dataGridViewRounds";
            dataGridViewRounds.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewRounds.RowHeadersVisible = false;
            dataGridViewRounds.Size = new Size(832, 240);
            dataGridViewRounds.TabIndex = 0;
            dataGridViewRounds.TabStop = false;
            dataGridViewRounds.CellContentClick += dataGridViewRounds_CellContentClick;
            // 
            // combatantBindingSource
            // 
            combatantBindingSource.DataSource = typeof(Combatant);
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Perpetua Titling MT", 9.75F);
            label1.Location = new Point(708, 172);
            label1.MinimumSize = new Size(119, 15);
            label1.Name = "label1";
            label1.Size = new Size(119, 15);
            label1.TabIndex = 14;
            label1.Text = "Round:";
            label1.Click += label1_Click_1;
            // 
            // txtRoundNum
            // 
            txtRoundNum.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtRoundNum.BackColor = Color.FloralWhite;
            txtRoundNum.BorderStyle = BorderStyle.None;
            txtRoundNum.CharacterCasing = CharacterCasing.Lower;
            txtRoundNum.Font = new Font("Perpetua Titling MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtRoundNum.ForeColor = Color.DarkGreen;
            txtRoundNum.Location = new Point(815, 168);
            txtRoundNum.Name = "txtRoundNum";
            txtRoundNum.ReadOnly = true;
            txtRoundNum.Size = new Size(31, 20);
            txtRoundNum.TabIndex = 0;
            txtRoundNum.TabStop = false;
            txtRoundNum.Text = "0";
            txtRoundNum.TextAlign = HorizontalAlignment.Center;
            // 
            // btnStart
            // 
            btnStart.Anchor = AnchorStyles.Top;
            btnStart.BackColor = Color.DarkGreen;
            btnStart.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStart.ForeColor = Color.FloralWhite;
            btnStart.Location = new Point(312, 129);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(237, 36);
            btnStart.TabIndex = 3;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // btnDemo
            // 
            btnDemo.BackColor = Color.DarkGreen;
            btnDemo.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            btnDemo.FlatStyle = FlatStyle.Flat;
            btnDemo.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDemo.ForeColor = Color.FloralWhite;
            btnDemo.Location = new Point(12, 12);
            btnDemo.Name = "btnDemo";
            btnDemo.Size = new Size(117, 36);
            btnDemo.TabIndex = 0;
            btnDemo.TabStop = false;
            btnDemo.Text = "Demo";
            btnDemo.UseVisualStyleBackColor = false;
            btnDemo.Visible = false;
            btnDemo.Click += btnDemo_Click;
            // 
            // btnAddOrDelete
            // 
            btnAddOrDelete.AutoSize = true;
            btnAddOrDelete.BackColor = Color.DarkGreen;
            btnAddOrDelete.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            btnAddOrDelete.FlatStyle = FlatStyle.Flat;
            btnAddOrDelete.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddOrDelete.ForeColor = Color.FloralWhite;
            btnAddOrDelete.Location = new Point(14, 129);
            btnAddOrDelete.Name = "btnAddOrDelete";
            btnAddOrDelete.Size = new Size(213, 36);
            btnAddOrDelete.TabIndex = 1;
            btnAddOrDelete.Text = "Add/Remove Combatants";
            btnAddOrDelete.UseVisualStyleBackColor = false;
            btnAddOrDelete.Click += btnAddOrDelete_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnPrevious.BackColor = Color.DarkGreen;
            btnPrevious.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            btnPrevious.FlatStyle = FlatStyle.Flat;
            btnPrevious.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPrevious.ForeColor = Color.FloralWhite;
            btnPrevious.Location = new Point(14, 450);
            btnPrevious.MaximumSize = new Size(190, 36);
            btnPrevious.MinimumSize = new Size(150, 36);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(150, 36);
            btnPrevious.TabIndex = 4;
            btnPrevious.Text = "Previous Turn";
            btnPrevious.UseVisualStyleBackColor = false;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnStatus
            // 
            btnStatus.Anchor = AnchorStyles.Bottom;
            btnStatus.BackColor = Color.DarkGreen;
            btnStatus.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            btnStatus.FlatStyle = FlatStyle.Flat;
            btnStatus.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStatus.ForeColor = Color.FloralWhite;
            btnStatus.Location = new Point(235, 450);
            btnStatus.MaximumSize = new Size(190, 36);
            btnStatus.MinimumSize = new Size(150, 36);
            btnStatus.Name = "btnStatus";
            btnStatus.Size = new Size(190, 36);
            btnStatus.TabIndex = 5;
            btnStatus.Text = "Add/Remove Effect";
            btnStatus.UseVisualStyleBackColor = false;
            btnStatus.Click += btnStatus_Click;
            // 
            // btnDamageHeal
            // 
            btnDamageHeal.Anchor = AnchorStyles.Bottom;
            btnDamageHeal.BackColor = Color.DarkGreen;
            btnDamageHeal.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            btnDamageHeal.FlatStyle = FlatStyle.Flat;
            btnDamageHeal.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDamageHeal.ForeColor = Color.FloralWhite;
            btnDamageHeal.Location = new Point(431, 450);
            btnDamageHeal.MaximumSize = new Size(190, 36);
            btnDamageHeal.MinimumSize = new Size(150, 36);
            btnDamageHeal.Name = "btnDamageHeal";
            btnDamageHeal.Size = new Size(190, 36);
            btnDamageHeal.TabIndex = 6;
            btnDamageHeal.Text = "Damage/Heal";
            btnDamageHeal.UseVisualStyleBackColor = false;
            btnDamageHeal.Click += btnDamageHeal_Click;
            // 
            // btnNext
            // 
            btnNext.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNext.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnNext.BackColor = Color.DarkGreen;
            btnNext.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNext.ForeColor = Color.FloralWhite;
            btnNext.Location = new Point(696, 450);
            btnNext.MaximumSize = new Size(190, 36);
            btnNext.MinimumSize = new Size(150, 36);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(150, 36);
            btnNext.TabIndex = 7;
            btnNext.Text = "Next Turn";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Perpetua Titling MT", 9.75F);
            label2.Location = new Point(14, 172);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 22;
            label2.Text = "Combatants:";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.BackgroundImage = Properties.Resources.CombatTrackerTxt;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(88, 40);
            pictureBox1.MaximumSize = new Size(686, 73);
            pictureBox1.MinimumSize = new Size(686, 73);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(686, 73);
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // btnSaveLoad
            // 
            btnSaveLoad.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSaveLoad.BackColor = Color.DarkGreen;
            btnSaveLoad.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            btnSaveLoad.FlatStyle = FlatStyle.Flat;
            btnSaveLoad.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSaveLoad.ForeColor = Color.FloralWhite;
            btnSaveLoad.Location = new Point(696, 129);
            btnSaveLoad.Name = "btnSaveLoad";
            btnSaveLoad.Size = new Size(150, 36);
            btnSaveLoad.TabIndex = 24;
            btnSaveLoad.Text = "Save/Load";
            btnSaveLoad.UseVisualStyleBackColor = false;
            btnSaveLoad.Click += btnSaveLoad_Click;
            // 
            // BaseForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(860, 498);
            Controls.Add(btnSaveLoad);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(btnNext);
            Controls.Add(btnDamageHeal);
            Controls.Add(btnStatus);
            Controls.Add(btnPrevious);
            Controls.Add(btnAddOrDelete);
            Controls.Add(btnDemo);
            Controls.Add(txtRoundNum);
            Controls.Add(label1);
            Controls.Add(dataGridViewRounds);
            Controls.Add(btnStart);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(737, 322);
            Name = "BaseForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Combat Tracker";
            Load += BaseForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewRounds).EndInit();
            ((System.ComponentModel.ISupportInitialize)combatantBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnDamage;
        private DataGridView dataGridViewRounds;
        private BindingSource combatantBindingSource;
        private Label label1;
        private TextBox txtRoundNum;
        private Button btnStart;
        private Button btnDemo;
        private Button btnAddOrDelete;
        private Button btnPrevious;
        private Button btnStatus;
        private Button btnDamageHeal;
        private Button btnNext;
        private Label label2;
        private PictureBox pictureBox1;
        private Button btnSaveLoad;
    }
}
