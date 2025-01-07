namespace CombatTracker
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
            btnRefresh = new Button();
            btnPrevious = new Button();
            btnStatus = new Button();
            btnDamageHeal = new Button();
            btnNext = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRounds).BeginInit();
            ((System.ComponentModel.ISupportInitialize)combatantBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewRounds
            // 
            dataGridViewRounds.AllowUserToResizeRows = false;
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
            dataGridViewRounds.Location = new Point(12, 275);
            dataGridViewRounds.Name = "dataGridViewRounds";
            dataGridViewRounds.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewRounds.RowHeadersVisible = false;
            dataGridViewRounds.Size = new Size(902, 288);
            dataGridViewRounds.TabIndex = 9;
            dataGridViewRounds.CellContentClick += dataGridViewRounds_CellContentClick;
            // 
            // combatantBindingSource
            // 
            combatantBindingSource.DataSource = typeof(Combatant);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Perpetua Titling MT", 9.75F);
            label1.Location = new Point(758, 256);
            label1.Name = "label1";
            label1.Size = new Size(119, 15);
            label1.TabIndex = 14;
            label1.Text = "Round Number:";
            label1.Click += label1_Click_1;
            // 
            // txtRoundNum
            // 
            txtRoundNum.BackColor = Color.FloralWhite;
            txtRoundNum.BorderStyle = BorderStyle.None;
            txtRoundNum.CharacterCasing = CharacterCasing.Lower;
            txtRoundNum.Font = new Font("Perpetua Titling MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtRoundNum.ForeColor = Color.DarkGreen;
            txtRoundNum.Location = new Point(883, 252);
            txtRoundNum.Name = "txtRoundNum";
            txtRoundNum.ReadOnly = true;
            txtRoundNum.Size = new Size(31, 20);
            txtRoundNum.TabIndex = 15;
            txtRoundNum.Text = "0";
            txtRoundNum.TextAlign = HorizontalAlignment.Center;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.DarkGreen;
            btnStart.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStart.ForeColor = Color.FloralWhite;
            btnStart.Location = new Point(784, 210);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(129, 36);
            btnStart.TabIndex = 3;
            btnStart.Text = "Start Combat";
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
            btnDemo.TabIndex = 16;
            btnDemo.Text = "Demo";
            btnDemo.UseVisualStyleBackColor = false;
            btnDemo.Click += btnDemo_Click;
            // 
            // btnAddOrDelete
            // 
            btnAddOrDelete.BackColor = Color.DarkGreen;
            btnAddOrDelete.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            btnAddOrDelete.FlatStyle = FlatStyle.Flat;
            btnAddOrDelete.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddOrDelete.ForeColor = Color.FloralWhite;
            btnAddOrDelete.Location = new Point(11, 210);
            btnAddOrDelete.Name = "btnAddOrDelete";
            btnAddOrDelete.Size = new Size(213, 36);
            btnAddOrDelete.TabIndex = 1;
            btnAddOrDelete.Text = "Add/Remove Combatants";
            btnAddOrDelete.UseVisualStyleBackColor = false;
            btnAddOrDelete.Click += btnAddOrDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.DarkGreen;
            btnRefresh.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.FloralWhite;
            btnRefresh.Location = new Point(224, 210);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(40, 36);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "↻";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.BackColor = Color.DarkGreen;
            btnPrevious.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            btnPrevious.FlatStyle = FlatStyle.Flat;
            btnPrevious.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPrevious.ForeColor = Color.FloralWhite;
            btnPrevious.Location = new Point(12, 579);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(129, 36);
            btnPrevious.TabIndex = 19;
            btnPrevious.Text = "Previous Turn";
            btnPrevious.UseVisualStyleBackColor = false;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnStatus
            // 
            btnStatus.BackColor = Color.DarkGreen;
            btnStatus.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            btnStatus.FlatStyle = FlatStyle.Flat;
            btnStatus.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStatus.ForeColor = Color.FloralWhite;
            btnStatus.Location = new Point(275, 578);
            btnStatus.Name = "btnStatus";
            btnStatus.Size = new Size(190, 36);
            btnStatus.TabIndex = 20;
            btnStatus.Text = "Add/Remove Effect";
            btnStatus.UseVisualStyleBackColor = false;
            btnStatus.Click += btnStatus_Click;
            // 
            // btnDamageHeal
            // 
            btnDamageHeal.BackColor = Color.DarkGreen;
            btnDamageHeal.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            btnDamageHeal.FlatStyle = FlatStyle.Flat;
            btnDamageHeal.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDamageHeal.ForeColor = Color.FloralWhite;
            btnDamageHeal.Location = new Point(465, 578);
            btnDamageHeal.Name = "btnDamageHeal";
            btnDamageHeal.Size = new Size(190, 36);
            btnDamageHeal.TabIndex = 21;
            btnDamageHeal.Text = "Damage/Heal";
            btnDamageHeal.UseVisualStyleBackColor = false;
            btnDamageHeal.Click += btnDamageHeal_Click;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.DarkGreen;
            btnNext.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNext.ForeColor = Color.FloralWhite;
            btnNext.Location = new Point(785, 578);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(129, 36);
            btnNext.TabIndex = 4;
            btnNext.Text = "Next Turn";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Perpetua Titling MT", 9.75F);
            label2.Location = new Point(21, 256);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 22;
            label2.Text = "Combatants:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.CombatTrackerTxt;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(132, 97);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(686, 73);
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // BaseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(925, 626);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(btnNext);
            Controls.Add(btnDamageHeal);
            Controls.Add(btnStatus);
            Controls.Add(btnPrevious);
            Controls.Add(btnRefresh);
            Controls.Add(btnAddOrDelete);
            Controls.Add(btnDemo);
            Controls.Add(txtRoundNum);
            Controls.Add(label1);
            Controls.Add(dataGridViewRounds);
            Controls.Add(btnStart);
            Icon = (Icon)resources.GetObject("$this.Icon");
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
        private Button btnRefresh;
        private Button btnPrevious;
        private Button btnStatus;
        private Button btnDamageHeal;
        private Button btnNext;
        private Label label2;
        private PictureBox pictureBox1;
    }
}
