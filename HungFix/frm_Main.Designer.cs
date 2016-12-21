namespace HungFix
{
    partial class frm_Main
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            this.btn_Apply = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Default = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nud_Delay = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Delay)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Apply
            // 
            this.btn_Apply.Location = new System.Drawing.Point(361, 55);
            this.btn_Apply.Name = "btn_Apply";
            this.btn_Apply.Size = new System.Drawing.Size(87, 23);
            this.btn_Apply.TabIndex = 0;
            this.btn_Apply.Text = "Apply";
            this.btn_Apply.UseVisualStyleBackColor = true;
            this.btn_Apply.Click += new System.EventHandler(this.btn_Apply_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(268, 55);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(87, 23);
            this.btn_Cancel.TabIndex = 1;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Default
            // 
            this.btn_Default.Location = new System.Drawing.Point(12, 55);
            this.btn_Default.Name = "btn_Default";
            this.btn_Default.Size = new System.Drawing.Size(87, 23);
            this.btn_Default.TabIndex = 2;
            this.btn_Default.Text = "Default";
            this.btn_Default.UseVisualStyleBackColor = true;
            this.btn_Default.Click += new System.EventHandler(this.btn_Default_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Set \"Timeout Detection and Recovery\" (TDR) delay:";
            // 
            // nud_Delay
            // 
            this.nud_Delay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nud_Delay.Location = new System.Drawing.Point(390, 7);
            this.nud_Delay.Name = "nud_Delay";
            this.nud_Delay.Size = new System.Drawing.Size(58, 26);
            this.nud_Delay.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(386, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "0 = Disabled";
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 83);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nud_Delay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Default);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Apply);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Main";
            this.Text = "HungFix";
            this.Load += new System.EventHandler(this.frm_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_Delay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Apply;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Default;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nud_Delay;
        private System.Windows.Forms.Label label2;
    }
}

