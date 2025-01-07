namespace CombatTracker
{
    partial class Effects
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Effects));
            label1 = new Label();
            label2 = new Label();
            lbFalseConditions = new ListBox();
            lbTrueConditions = new ListBox();
            label3 = new Label();
            txtName = new TextBox();
            btnRemove = new Button();
            btnAdd = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9.75F);
            label1.Location = new Point(81, 67);
            label1.Name = "label1";
            label1.Size = new Size(90, 17);
            label1.TabIndex = 3;
            label1.Text = "Combatant:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9.75F);
            label2.Location = new Point(80, 265);
            label2.Name = "label2";
            label2.Size = new Size(138, 17);
            label2.TabIndex = 4;
            label2.Text = "Inactive Conditions:";
            // 
            // lbFalseConditions
            // 
            lbFalseConditions.BackColor = Color.White;
            lbFalseConditions.BorderStyle = BorderStyle.None;
            lbFalseConditions.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbFalseConditions.FormattingEnabled = true;
            lbFalseConditions.ItemHeight = 17;
            lbFalseConditions.Location = new Point(80, 283);
            lbFalseConditions.Name = "lbFalseConditions";
            lbFalseConditions.Size = new Size(120, 102);
            lbFalseConditions.TabIndex = 6;
            // 
            // lbTrueConditions
            // 
            lbTrueConditions.BackColor = Color.White;
            lbTrueConditions.BorderStyle = BorderStyle.None;
            lbTrueConditions.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTrueConditions.FormattingEnabled = true;
            lbTrueConditions.ItemHeight = 17;
            lbTrueConditions.Location = new Point(80, 129);
            lbTrueConditions.Name = "lbTrueConditions";
            lbTrueConditions.Size = new Size(120, 102);
            lbTrueConditions.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F);
            label3.Location = new Point(81, 111);
            label3.Name = "label3";
            label3.Size = new Size(127, 17);
            label3.TabIndex = 9;
            label3.Text = "Active Conditions:";
            // 
            // txtName
            // 
            txtName.BackColor = Color.FloralWhite;
            txtName.BorderStyle = BorderStyle.None;
            txtName.Font = new Font("Perpetua Titling MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(39, 87);
            txtName.Name = "txtName";
            txtName.Size = new Size(205, 19);
            txtName.TabIndex = 11;
            txtName.TextAlign = HorizontalAlignment.Center;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.DarkGreen;
            btnRemove.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRemove.ForeColor = Color.FloralWhite;
            btnRemove.Location = new Point(80, 233);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(121, 25);
            btnRemove.TabIndex = 18;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.DarkGreen;
            btnAdd.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.FloralWhite;
            btnAdd.Location = new Point(79, 387);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(121, 25);
            btnAdd.TabIndex = 19;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnApply_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poor Richard", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(58, 21);
            label4.Name = "label4";
            label4.Size = new Size(170, 24);
            label4.TabIndex = 20;
            label4.Text = "STATUS EFFECTS";
            // 
            // Effects
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(286, 434);
            Controls.Add(label4);
            Controls.Add(btnAdd);
            Controls.Add(btnRemove);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(lbTrueConditions);
            Controls.Add(lbFalseConditions);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Effects";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Effects";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private ListBox lbFalseConditions;
        private ListBox lbTrueConditions;
        private Label label3;
        private TextBox txtName;
        private Button btnRemove;
        private Button btnAdd;
        private Label label4;
    }
}