namespace BlitzMemoryNotes
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sourceRichTextBox = new System.Windows.Forms.RichTextBox();
            this.targetRTB_2L = new System.Windows.Forms.RichTextBox();
            this.validationRTB_2L = new System.Windows.Forms.RichTextBox();
            this.targetRTB_1L = new System.Windows.Forms.RichTextBox();
            this.validationRTB_1L = new System.Windows.Forms.RichTextBox();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.progressBarL1 = new MaterialSkin.Controls.MaterialProgressBar();
            this.progressBarL2 = new MaterialSkin.Controls.MaterialProgressBar();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialSwitch1 = new MaterialSkin.Controls.MaterialSwitch();
            this.materialFloatingActionButton1 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.materialFloatingActionButton2 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.materialFloatingActionButton3 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sourceRichTextBox
            // 
            this.sourceRichTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sourceRichTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.sourceRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sourceRichTextBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.sourceRichTextBox.Location = new System.Drawing.Point(248, 79);
            this.sourceRichTextBox.Name = "sourceRichTextBox";
            this.sourceRichTextBox.Size = new System.Drawing.Size(960, 220);
            this.sourceRichTextBox.TabIndex = 0;
            this.sourceRichTextBox.Text = "Escribe o pega la informacion que quieres memorizar";
            this.sourceRichTextBox.TextChanged += new System.EventHandler(this.SourceRichTextBox_TextChanged);
            this.sourceRichTextBox.Enter += new System.EventHandler(this.sourceRichTextBox_Enter);
            this.sourceRichTextBox.Leave += new System.EventHandler(this.SourceRichTextBox_Leave);
            // 
            // targetRTB_2L
            // 
            this.targetRTB_2L.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.targetRTB_2L.Location = new System.Drawing.Point(550, 4);
            this.targetRTB_2L.Name = "targetRTB_2L";
            this.targetRTB_2L.Size = new System.Drawing.Size(216, 60);
            this.targetRTB_2L.TabIndex = 1;
            this.targetRTB_2L.Text = "";
            // 
            // validationRTB_2L
            // 
            this.validationRTB_2L.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.validationRTB_2L.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.validationRTB_2L.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validationRTB_2L.Location = new System.Drawing.Point(248, 316);
            this.validationRTB_2L.Name = "validationRTB_2L";
            this.validationRTB_2L.Size = new System.Drawing.Size(960, 220);
            this.validationRTB_2L.TabIndex = 2;
            this.validationRTB_2L.Text = "";
            this.validationRTB_2L.TextChanged += new System.EventHandler(this.ValidationRichTextBox_TextChanged);
            // 
            // targetRTB_1L
            // 
            this.targetRTB_1L.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.targetRTB_1L.Location = new System.Drawing.Point(772, 6);
            this.targetRTB_1L.Name = "targetRTB_1L";
            this.targetRTB_1L.Size = new System.Drawing.Size(216, 58);
            this.targetRTB_1L.TabIndex = 3;
            this.targetRTB_1L.Text = "";
            // 
            // validationRTB_1L
            // 
            this.validationRTB_1L.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.validationRTB_1L.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.validationRTB_1L.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validationRTB_1L.Location = new System.Drawing.Point(248, 551);
            this.validationRTB_1L.Name = "validationRTB_1L";
            this.validationRTB_1L.Size = new System.Drawing.Size(960, 220);
            this.validationRTB_1L.TabIndex = 4;
            this.validationRTB_1L.Text = "";
            this.validationRTB_1L.TextChanged += new System.EventHandler(this.ValidationRTB_L1_TextChanged);
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(9, 67);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1222, 810);
            this.materialTabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.materialFloatingActionButton3);
            this.tabPage1.Controls.Add(this.materialFloatingActionButton2);
            this.tabPage1.Controls.Add(this.materialFloatingActionButton1);
            this.tabPage1.Controls.Add(this.materialSwitch1);
            this.tabPage1.Controls.Add(this.progressBarL1);
            this.tabPage1.Controls.Add(this.progressBarL2);
            this.tabPage1.Controls.Add(this.validationRTB_1L);
            this.tabPage1.Controls.Add(this.targetRTB_1L);
            this.tabPage1.Controls.Add(this.validationRTB_2L);
            this.tabPage1.Controls.Add(this.targetRTB_2L);
            this.tabPage1.Controls.Add(this.sourceRichTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1214, 784);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // progressBarL1
            // 
            this.progressBarL1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progressBarL1.Depth = 0;
            this.progressBarL1.Location = new System.Drawing.Point(248, 540);
            this.progressBarL1.MouseState = MaterialSkin.MouseState.HOVER;
            this.progressBarL1.Name = "progressBarL1";
            this.progressBarL1.Size = new System.Drawing.Size(960, 5);
            this.progressBarL1.TabIndex = 8;
            // 
            // progressBarL2
            // 
            this.progressBarL2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progressBarL2.Depth = 0;
            this.progressBarL2.Location = new System.Drawing.Point(248, 305);
            this.progressBarL2.MouseState = MaterialSkin.MouseState.HOVER;
            this.progressBarL2.Name = "progressBarL2";
            this.progressBarL2.Size = new System.Drawing.Size(960, 5);
            this.progressBarL2.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarL2.TabIndex = 7;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1214, 784);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // materialSwitch1
            // 
            this.materialSwitch1.AutoSize = true;
            this.materialSwitch1.Depth = 0;
            this.materialSwitch1.Location = new System.Drawing.Point(1035, 16);
            this.materialSwitch1.Margin = new System.Windows.Forms.Padding(0);
            this.materialSwitch1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialSwitch1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSwitch1.Name = "materialSwitch1";
            this.materialSwitch1.Ripple = true;
            this.materialSwitch1.Size = new System.Drawing.Size(173, 37);
            this.materialSwitch1.TabIndex = 9;
            this.materialSwitch1.Text = "materialSwitch1";
            this.materialSwitch1.UseVisualStyleBackColor = true;
            // 
            // materialFloatingActionButton1
            // 
            this.materialFloatingActionButton1.Depth = 0;
            this.materialFloatingActionButton1.Icon = null;
            this.materialFloatingActionButton1.Location = new System.Drawing.Point(186, 79);
            this.materialFloatingActionButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFloatingActionButton1.Name = "materialFloatingActionButton1";
            this.materialFloatingActionButton1.Size = new System.Drawing.Size(56, 56);
            this.materialFloatingActionButton1.TabIndex = 10;
            this.materialFloatingActionButton1.Text = "materialFloatingActionButton1";
            this.materialFloatingActionButton1.UseVisualStyleBackColor = true;
            // 
            // materialFloatingActionButton2
            // 
            this.materialFloatingActionButton2.Depth = 0;
            this.materialFloatingActionButton2.Icon = null;
            this.materialFloatingActionButton2.Location = new System.Drawing.Point(186, 316);
            this.materialFloatingActionButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFloatingActionButton2.Name = "materialFloatingActionButton2";
            this.materialFloatingActionButton2.Size = new System.Drawing.Size(56, 56);
            this.materialFloatingActionButton2.TabIndex = 11;
            this.materialFloatingActionButton2.Text = "materialFloatingActionButton2";
            this.materialFloatingActionButton2.UseVisualStyleBackColor = true;
            // 
            // materialFloatingActionButton3
            // 
            this.materialFloatingActionButton3.Depth = 0;
            this.materialFloatingActionButton3.Icon = null;
            this.materialFloatingActionButton3.Location = new System.Drawing.Point(186, 551);
            this.materialFloatingActionButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFloatingActionButton3.Name = "materialFloatingActionButton3";
            this.materialFloatingActionButton3.Size = new System.Drawing.Size(56, 56);
            this.materialFloatingActionButton3.TabIndex = 12;
            this.materialFloatingActionButton3.Text = "materialFloatingActionButton3";
            this.materialFloatingActionButton3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(1237, 870);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerTabControl = this.materialTabControl1;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blitz Memory Notes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox sourceRichTextBox;
        private System.Windows.Forms.RichTextBox targetRTB_2L;
        private System.Windows.Forms.RichTextBox validationRTB_2L;
        private System.Windows.Forms.RichTextBox targetRTB_1L;
        private System.Windows.Forms.RichTextBox validationRTB_1L;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialProgressBar progressBarL1;
        private MaterialSkin.Controls.MaterialProgressBar progressBarL2;
        private MaterialSkin.Controls.MaterialSwitch materialSwitch1;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton3;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton2;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton1;
    }
}

