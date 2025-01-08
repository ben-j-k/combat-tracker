namespace CombatTracker
{
    partial class Save
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
            lbSaves = new ListBox();
            label4 = new Label();
            label2 = new Label();
            btnLoad = new Button();
            btnSave = new Button();
            SuspendLayout();
            // 
            // lbSaves
            // 
            lbSaves.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbSaves.BackColor = Color.White;
            lbSaves.BorderStyle = BorderStyle.None;
            lbSaves.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbSaves.FormattingEnabled = true;
            lbSaves.ItemHeight = 17;
            lbSaves.Location = new Point(64, 105);
            lbSaves.Name = "lbSaves";
            lbSaves.Size = new Size(348, 136);
            lbSaves.TabIndex = 9;
            lbSaves.SelectedIndexChanged += lbSaves_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Poor Richard", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkGreen;
            label4.Location = new Point(135, 26);
            label4.Name = "label4";
            label4.Size = new Size(226, 24);
            label4.TabIndex = 21;
            label4.Text = "LOAD OR SAVE GAME";
            label4.Click += label4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Perpetua Titling MT", 9.75F);
            label2.Location = new Point(64, 87);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 23;
            label2.Text = "Saved Games:";
            label2.Click += label2_Click;
            // 
            // btnLoad
            // 
            btnLoad.Anchor = AnchorStyles.Bottom;
            btnLoad.BackColor = Color.DarkGreen;
            btnLoad.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            btnLoad.FlatStyle = FlatStyle.Flat;
            btnLoad.Font = new Font("Century Gothic", 9.75F);
            btnLoad.ForeColor = Color.FloralWhite;
            btnLoad.Location = new Point(252, 265);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(163, 36);
            btnLoad.TabIndex = 24;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom;
            btnSave.BackColor = Color.DarkGreen;
            btnSave.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Century Gothic", 9.75F);
            btnSave.ForeColor = Color.FloralWhite;
            btnSave.Location = new Point(60, 265);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(163, 36);
            btnSave.TabIndex = 25;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // Save
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(473, 327);
            Controls.Add(btnSave);
            Controls.Add(btnLoad);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(lbSaves);
            MinimumSize = new Size(489, 366);
            Name = "Save";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Save";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbSaves;
        private Label label4;
        private Label label2;
        private Button btnLoad;
        private Button btnSave;
    }
}