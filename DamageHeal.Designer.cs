namespace CombatTracker
{
    partial class DamageHeal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DamageHeal));
            numDmgHeal = new NumericUpDown();
            label1 = new Label();
            txtCombatant = new TextBox();
            btnHeal = new Button();
            btnDamage = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)numDmgHeal).BeginInit();
            SuspendLayout();
            // 
            // numDmgHeal
            // 
            numDmgHeal.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numDmgHeal.BackColor = Color.White;
            numDmgHeal.BorderStyle = BorderStyle.None;
            numDmgHeal.Font = new Font("Perpetua Titling MT", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numDmgHeal.Location = new Point(48, 136);
            numDmgHeal.Name = "numDmgHeal";
            numDmgHeal.Size = new Size(230, 26);
            numDmgHeal.TabIndex = 1;
            numDmgHeal.TextAlign = HorizontalAlignment.Center;
            numDmgHeal.ThousandsSeparator = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Perpetua Titling MT", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(48, 84);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 4;
            label1.Text = "Combatant:";
            // 
            // txtCombatant
            // 
            txtCombatant.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtCombatant.BackColor = Color.FloralWhite;
            txtCombatant.BorderStyle = BorderStyle.None;
            txtCombatant.Font = new Font("Perpetua Titling MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCombatant.Location = new Point(48, 108);
            txtCombatant.Name = "txtCombatant";
            txtCombatant.ReadOnly = true;
            txtCombatant.Size = new Size(230, 19);
            txtCombatant.TabIndex = 5;
            txtCombatant.TextAlign = HorizontalAlignment.Center;
            // 
            // btnHeal
            // 
            btnHeal.Anchor = AnchorStyles.Bottom;
            btnHeal.BackColor = Color.DarkGreen;
            btnHeal.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            btnHeal.FlatStyle = FlatStyle.Flat;
            btnHeal.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHeal.ForeColor = Color.FloralWhite;
            btnHeal.Location = new Point(48, 171);
            btnHeal.MinimumSize = new Size(93, 36);
            btnHeal.Name = "btnHeal";
            btnHeal.Size = new Size(93, 36);
            btnHeal.TabIndex = 17;
            btnHeal.Text = "Heal";
            btnHeal.UseVisualStyleBackColor = false;
            btnHeal.Click += btnHeal_Click;
            // 
            // btnDamage
            // 
            btnDamage.Anchor = AnchorStyles.Bottom;
            btnDamage.BackColor = Color.DarkGreen;
            btnDamage.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            btnDamage.FlatStyle = FlatStyle.Flat;
            btnDamage.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDamage.ForeColor = Color.FloralWhite;
            btnDamage.Location = new Point(185, 171);
            btnDamage.MinimumSize = new Size(93, 36);
            btnDamage.Name = "btnDamage";
            btnDamage.Size = new Size(93, 36);
            btnDamage.TabIndex = 18;
            btnDamage.Text = "Damage";
            btnDamage.UseVisualStyleBackColor = false;
            btnDamage.Click += btnDamage_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poor Richard", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(48, 40);
            label2.Name = "label2";
            label2.Size = new Size(230, 24);
            label2.TabIndex = 19;
            label2.Text = "DAMAGE OR HEALING";
            label2.Click += label2_Click;
            // 
            // DamageHeal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(327, 223);
            Controls.Add(label2);
            Controls.Add(btnDamage);
            Controls.Add(btnHeal);
            Controls.Add(txtCombatant);
            Controls.Add(label1);
            Controls.Add(numDmgHeal);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(343, 262);
            Name = "DamageHeal";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Damage or Healing";
            ((System.ComponentModel.ISupportInitialize)numDmgHeal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numDmgHeal;
        private Label label1;
        private TextBox txtCombatant;
        private Button btnHeal;
        private Button btnDamage;
        private Label label2;
    }
}