namespace BlitzMemoryNotes
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.sourceRichTextBox = new System.Windows.Forms.RichTextBox();
            this.targetRTB_2L = new System.Windows.Forms.RichTextBox();
            this.validationRTB_2L = new System.Windows.Forms.RichTextBox();
            this.targetRTB_1L = new System.Windows.Forms.RichTextBox();
            this.validationRTB_1L = new System.Windows.Forms.RichTextBox();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.FAButton_Borrar_1L = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.FAButton_Borrar_2L = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.FAButton_Borrar_Base = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.Switch_NM = new MaterialSkin.Controls.MaterialSwitch();
            this.progressBarL1 = new MaterialSkin.Controls.MaterialProgressBar();
            this.progressBarL2 = new MaterialSkin.Controls.MaterialProgressBar();
            this.tabPage2 = new System.Windows.Forms.TabPage();
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
            this.tabPage1.Controls.Add(this.materialLabel1);
            this.tabPage1.Controls.Add(this.materialButton1);
            this.tabPage1.Controls.Add(this.FAButton_Borrar_1L);
            this.tabPage1.Controls.Add(this.FAButton_Borrar_2L);
            this.tabPage1.Controls.Add(this.FAButton_Borrar_Base);
            this.tabPage1.Controls.Add(this.Switch_NM);
            this.tabPage1.Controls.Add(this.progressBarL1);
            this.tabPage1.Controls.Add(this.progressBarL2);
            this.tabPage1.Controls.Add(this.validationRTB_1L);
            this.tabPage1.Controls.Add(this.targetRTB_1L);
            this.tabPage1.Controls.Add(this.validationRTB_2L);
            this.tabPage1.Controls.Add(this.targetRTB_2L);
            this.tabPage1.Controls.Add(this.sourceRichTextBox);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1214, 784);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(3, 82);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(107, 19);
            this.materialLabel1.TabIndex = 14;
            this.materialLabel1.Text = "materialLabel1";
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(248, 15);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(158, 36);
            this.materialButton1.TabIndex = 13;
            this.materialButton1.Text = "materialButton1";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = true;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // FAButton_Borrar_1L
            // 
            this.FAButton_Borrar_1L.Depth = 0;
            this.FAButton_Borrar_1L.Icon = ((System.Drawing.Image)(resources.GetObject("FAButton_Borrar_1L.Icon")));
            this.FAButton_Borrar_1L.Location = new System.Drawing.Point(202, 551);
            this.FAButton_Borrar_1L.Mini = true;
            this.FAButton_Borrar_1L.MouseState = MaterialSkin.MouseState.HOVER;
            this.FAButton_Borrar_1L.Name = "FAButton_Borrar_1L";
            this.FAButton_Borrar_1L.Size = new System.Drawing.Size(40, 40);
            this.FAButton_Borrar_1L.TabIndex = 12;
            this.FAButton_Borrar_1L.Text = "materialFloatingActionButton3";
            this.FAButton_Borrar_1L.UseVisualStyleBackColor = true;
            this.FAButton_Borrar_1L.Click += new System.EventHandler(this.FAButton_Borrar_1L_Click);
            // 
            // FAButton_Borrar_2L
            // 
            this.FAButton_Borrar_2L.Depth = 0;
            this.FAButton_Borrar_2L.Icon = ((System.Drawing.Image)(resources.GetObject("FAButton_Borrar_2L.Icon")));
            this.FAButton_Borrar_2L.Location = new System.Drawing.Point(202, 316);
            this.FAButton_Borrar_2L.Mini = true;
            this.FAButton_Borrar_2L.MouseState = MaterialSkin.MouseState.HOVER;
            this.FAButton_Borrar_2L.Name = "FAButton_Borrar_2L";
            this.FAButton_Borrar_2L.Size = new System.Drawing.Size(40, 40);
            this.FAButton_Borrar_2L.TabIndex = 11;
            this.FAButton_Borrar_2L.Text = "materialFloatingActionButton2";
            this.FAButton_Borrar_2L.UseVisualStyleBackColor = true;
            this.FAButton_Borrar_2L.Click += new System.EventHandler(this.FAButton_Borrar_2L_Click);
            // 
            // FAButton_Borrar_Base
            // 
            this.FAButton_Borrar_Base.Depth = 0;
            this.FAButton_Borrar_Base.Icon = ((System.Drawing.Image)(resources.GetObject("FAButton_Borrar_Base.Icon")));
            this.FAButton_Borrar_Base.Location = new System.Drawing.Point(202, 79);
            this.FAButton_Borrar_Base.Mini = true;
            this.FAButton_Borrar_Base.MouseState = MaterialSkin.MouseState.HOVER;
            this.FAButton_Borrar_Base.Name = "FAButton_Borrar_Base";
            this.FAButton_Borrar_Base.Size = new System.Drawing.Size(40, 40);
            this.FAButton_Borrar_Base.TabIndex = 10;
            this.FAButton_Borrar_Base.Text = "materialFloatingActionButton1";
            this.FAButton_Borrar_Base.UseVisualStyleBackColor = true;
            this.FAButton_Borrar_Base.Click += new System.EventHandler(this.FAButton_Borrar_Base_Click);
            // 
            // Switch_NM
            // 
            this.Switch_NM.AutoSize = true;
            this.Switch_NM.Depth = 0;
            this.Switch_NM.Location = new System.Drawing.Point(1035, 16);
            this.Switch_NM.Margin = new System.Windows.Forms.Padding(0);
            this.Switch_NM.MouseLocation = new System.Drawing.Point(-1, -1);
            this.Switch_NM.MouseState = MaterialSkin.MouseState.HOVER;
            this.Switch_NM.Name = "Switch_NM";
            this.Switch_NM.Ripple = true;
            this.Switch_NM.Size = new System.Drawing.Size(168, 37);
            this.Switch_NM.TabIndex = 9;
            this.Switch_NM.Text = "Modo Nocturno";
            this.Switch_NM.UseVisualStyleBackColor = true;
            this.Switch_NM.CheckedChanged += new System.EventHandler(this.Switch_NM_CheckedChanged);
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
            // FormPrincipal
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
            this.Name = "FormPrincipal";
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
        private MaterialSkin.Controls.MaterialSwitch Switch_NM;
        private MaterialSkin.Controls.MaterialFloatingActionButton FAButton_Borrar_1L;
        private MaterialSkin.Controls.MaterialFloatingActionButton FAButton_Borrar_2L;
        private MaterialSkin.Controls.MaterialFloatingActionButton FAButton_Borrar_Base;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}

