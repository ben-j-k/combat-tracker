namespace CombatTracker
{
    partial class AddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddForm));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNameInput = new TextBox();
            label4 = new Label();
            lblAddConfirm = new Label();
            lbCombatants = new ListBox();
            label5 = new Label();
            label6 = new Label();
            numInitInput = new NumericUpDown();
            numMaxHP = new NumericUpDown();
            numCurrentHP = new NumericUpDown();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            btnConfirm = new Button();
            btnAddBack = new Button();
            btnAddSave = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)numInitInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMaxHP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCurrentHP).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 93);
            label1.Name = "label1";
            label1.Size = new Size(47, 17);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F);
            label2.Location = new Point(27, 178);
            label2.Name = "label2";
            label2.Size = new Size(73, 17);
            label2.TabIndex = 1;
            label2.Text = "Current HP:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9F);
            label3.Location = new Point(27, 237);
            label3.Name = "label3";
            label3.Size = new Size(64, 17);
            label3.TabIndex = 2;
            label3.Text = "Initiative:";
            // 
            // txtNameInput
            // 
            txtNameInput.AcceptsTab = true;
            txtNameInput.BackColor = Color.White;
            txtNameInput.BorderStyle = BorderStyle.None;
            txtNameInput.Font = new Font("Century Gothic", 12F);
            txtNameInput.Location = new Point(27, 111);
            txtNameInput.Name = "txtNameInput";
            txtNameInput.Size = new Size(220, 20);
            txtNameInput.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poor Richard", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(134, 25);
            label4.Name = "label4";
            label4.Size = new Size(279, 28);
            label4.TabIndex = 6;
            label4.Text = "MANAGE COMBATANTS";
            label4.Click += label4_Click;
            // 
            // lblAddConfirm
            // 
            lblAddConfirm.AutoSize = true;
            lblAddConfirm.Font = new Font("Perpetua Titling MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddConfirm.Location = new Point(27, 281);
            lblAddConfirm.Name = "lblAddConfirm";
            lblAddConfirm.Size = new Size(0, 15);
            lblAddConfirm.TabIndex = 9;
            // 
            // lbCombatants
            // 
            lbCombatants.BackColor = Color.FloralWhite;
            lbCombatants.BorderStyle = BorderStyle.None;
            lbCombatants.Font = new Font("Perpetua Titling MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbCombatants.FormattingEnabled = true;
            lbCombatants.ItemHeight = 19;
            lbCombatants.Location = new Point(8, 21);
            lbCombatants.Name = "lbCombatants";
            lbCombatants.Size = new Size(234, 209);
            lbCombatants.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9F);
            label5.Location = new Point(27, 193);
            label5.Name = "label5";
            label5.Size = new Size(220, 17);
            label5.TabIndex = 13;
            label5.Text = "(Leave blank if the same as max HP)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(28, 137);
            label6.Name = "label6";
            label6.Size = new Size(86, 17);
            label6.TabIndex = 15;
            label6.Text = "Maximum HP:";
            // 
            // numInitInput
            // 
            numInitInput.BackColor = Color.White;
            numInitInput.BorderStyle = BorderStyle.None;
            numInitInput.Font = new Font("Century Gothic", 12F);
            numInitInput.Location = new Point(28, 255);
            numInitInput.Name = "numInitInput";
            numInitInput.Size = new Size(219, 23);
            numInitInput.TabIndex = 4;
            // 
            // numMaxHP
            // 
            numMaxHP.BackColor = Color.White;
            numMaxHP.BorderStyle = BorderStyle.None;
            numMaxHP.Font = new Font("Century Gothic", 12F);
            numMaxHP.Location = new Point(28, 155);
            numMaxHP.Name = "numMaxHP";
            numMaxHP.Size = new Size(219, 23);
            numMaxHP.TabIndex = 2;
            // 
            // numCurrentHP
            // 
            numCurrentHP.BackColor = Color.White;
            numCurrentHP.BorderStyle = BorderStyle.None;
            numCurrentHP.Font = new Font("Century Gothic", 12F);
            numCurrentHP.Location = new Point(28, 211);
            numCurrentHP.Name = "numCurrentHP";
            numCurrentHP.Size = new Size(219, 23);
            numCurrentHP.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Font = new Font("Perpetua Titling MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 70);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(248, 243);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "New";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lbCombatants);
            groupBox2.Font = new Font("Perpetua Titling MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(266, 70);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(248, 243);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            groupBox2.Text = "Existing";
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.DarkGreen;
            btnConfirm.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConfirm.ForeColor = Color.FloralWhite;
            btnConfirm.Location = new Point(385, 319);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(129, 36);
            btnConfirm.TabIndex = 6;
            btnConfirm.Text = "Confirm All";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnAddBack
            // 
            btnAddBack.BackColor = Color.DarkGreen;
            btnAddBack.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            btnAddBack.FlatStyle = FlatStyle.Flat;
            btnAddBack.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddBack.ForeColor = Color.FloralWhite;
            btnAddBack.Location = new Point(12, 319);
            btnAddBack.Name = "btnAddBack";
            btnAddBack.Size = new Size(129, 36);
            btnAddBack.TabIndex = 22;
            btnAddBack.Text = "Back";
            btnAddBack.UseVisualStyleBackColor = false;
            btnAddBack.Click += btnAddBack_Click;
            // 
            // btnAddSave
            // 
            btnAddSave.BackColor = Color.DarkGreen;
            btnAddSave.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            btnAddSave.FlatStyle = FlatStyle.Flat;
            btnAddSave.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddSave.ForeColor = Color.FloralWhite;
            btnAddSave.Location = new Point(183, 319);
            btnAddSave.Name = "btnAddSave";
            btnAddSave.Size = new Size(77, 36);
            btnAddSave.TabIndex = 5;
            btnAddSave.Text = "Add";
            btnAddSave.UseVisualStyleBackColor = false;
            btnAddSave.Click += btnAddSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DarkGreen;
            btnDelete.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.FloralWhite;
            btnDelete.Location = new Point(266, 319);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(77, 36);
            btnDelete.TabIndex = 24;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(525, 366);
            Controls.Add(btnDelete);
            Controls.Add(btnAddSave);
            Controls.Add(btnAddBack);
            Controls.Add(btnConfirm);
            Controls.Add(numCurrentHP);
            Controls.Add(numMaxHP);
            Controls.Add(numInitInput);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(lblAddConfirm);
            Controls.Add(label4);
            Controls.Add(txtNameInput);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Combatants";
            ((System.ComponentModel.ISupportInitialize)numInitInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMaxHP).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCurrentHP).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNameInput;
        private Label label4;
        private Button btnAddSave;
        private Button btnAddBack;
        private Label lblAddConfirm;
        private ListBox lbCombatants;
        private Label label5;
        private Label label6;
        private NumericUpDown numInitInput;
        private NumericUpDown numMaxHP;
        private NumericUpDown numCurrentHP;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnConfirm;
        private Button button1;
        private Button button2;
        private Button btnDelete;
    }
}