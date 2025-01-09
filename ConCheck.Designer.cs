namespace CombatTracker
{
    partial class ConCheck
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConCheck));
            label1 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            label3 = new Label();
            txtDC = new TextBox();
            btnFailed = new Button();
            btnPass = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Poor Richard", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(87, 40);
            label1.Name = "label1";
            label1.Size = new Size(263, 24);
            label1.TabIndex = 0;
            label1.Text = "CONCENTRATION CHECK";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Perpetua Titling MT", 9.75F);
            label2.Location = new Point(87, 80);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 1;
            label2.Text = "Combatant:";
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtName.BackColor = Color.FloralWhite;
            txtName.BorderStyle = BorderStyle.None;
            txtName.Font = new Font("Perpetua Titling MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(87, 101);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(263, 19);
            txtName.TabIndex = 2;
            txtName.TextAlign = HorizontalAlignment.Center;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Perpetua Titling MT", 9.75F);
            label3.Location = new Point(87, 126);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 3;
            label3.Text = "Difficulty:";
            // 
            // txtDC
            // 
            txtDC.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtDC.BackColor = Color.FloralWhite;
            txtDC.BorderStyle = BorderStyle.None;
            txtDC.Font = new Font("Perpetua Titling MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDC.Location = new Point(87, 147);
            txtDC.Name = "txtDC";
            txtDC.ReadOnly = true;
            txtDC.Size = new Size(263, 19);
            txtDC.TabIndex = 4;
            txtDC.TextAlign = HorizontalAlignment.Center;
            // 
            // btnFailed
            // 
            btnFailed.Anchor = AnchorStyles.Bottom;
            btnFailed.BackColor = Color.DarkGreen;
            btnFailed.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            btnFailed.FlatStyle = FlatStyle.Flat;
            btnFailed.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFailed.ForeColor = Color.FloralWhite;
            btnFailed.Location = new Point(87, 179);
            btnFailed.Name = "btnFailed";
            btnFailed.Size = new Size(129, 36);
            btnFailed.TabIndex = 1;
            btnFailed.Text = "Failed";
            btnFailed.UseVisualStyleBackColor = false;
            btnFailed.Click += btnFailed_Click;
            // 
            // btnPass
            // 
            btnPass.Anchor = AnchorStyles.Bottom;
            btnPass.BackColor = Color.DarkGreen;
            btnPass.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            btnPass.FlatStyle = FlatStyle.Flat;
            btnPass.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPass.ForeColor = Color.FloralWhite;
            btnPass.Location = new Point(222, 179);
            btnPass.Name = "btnPass";
            btnPass.Size = new Size(129, 36);
            btnPass.TabIndex = 2;
            btnPass.Text = "Passed";
            btnPass.UseVisualStyleBackColor = false;
            btnPass.Click += btnPass_Click;
            // 
            // ConCheck
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(438, 239);
            Controls.Add(btnPass);
            Controls.Add(btnFailed);
            Controls.Add(txtDC);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(454, 278);
            Name = "ConCheck";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Concentration Check";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtName;
        private Label label3;
        private TextBox txtDC;
        private Button btnPass;
        private Button btnFailed;
    }
}