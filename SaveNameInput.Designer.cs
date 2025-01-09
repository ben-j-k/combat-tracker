namespace CombatTracker
{
    partial class SaveNameInput
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
            label4 = new Label();
            label1 = new Label();
            txtSaveNameInput = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Poor Richard", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkGreen;
            label4.Location = new Point(142, 40);
            label4.Name = "label4";
            label4.Size = new Size(116, 24);
            label4.TabIndex = 22;
            label4.Text = "NEW SAVE";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Perpetua Titling MT", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(42, 80);
            label1.Name = "label1";
            label1.Size = new Size(125, 15);
            label1.TabIndex = 23;
            label1.Text = "Name your save:";
            label1.Click += label1_Click;
            // 
            // txtSaveNameInput
            // 
            txtSaveNameInput.AcceptsTab = true;
            txtSaveNameInput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSaveNameInput.BackColor = Color.White;
            txtSaveNameInput.BorderStyle = BorderStyle.None;
            txtSaveNameInput.Font = new Font("Century Gothic", 12F);
            txtSaveNameInput.Location = new Point(42, 100);
            txtSaveNameInput.Name = "txtSaveNameInput";
            txtSaveNameInput.Size = new Size(318, 20);
            txtSaveNameInput.TabIndex = 24;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom;
            btnSave.BackColor = Color.DarkGreen;
            btnSave.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.FloralWhite;
            btnSave.Location = new Point(267, 138);
            btnSave.MinimumSize = new Size(93, 36);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(93, 36);
            btnSave.TabIndex = 25;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom;
            btnCancel.BackColor = Color.DarkGreen;
            btnCancel.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.FloralWhite;
            btnCancel.Location = new Point(41, 138);
            btnCancel.MinimumSize = new Size(93, 36);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(93, 36);
            btnCancel.TabIndex = 26;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // SaveNameInput
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(401, 198);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtSaveNameInput);
            Controls.Add(label1);
            Controls.Add(label4);
            MinimumSize = new Size(417, 237);
            Name = "SaveNameInput";
            StartPosition = FormStartPosition.CenterParent;
            Text = "SaveNameInput";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label1;
        private TextBox txtSaveNameInput;
        private Button btnSave;
        private Button btnCancel;
    }
}