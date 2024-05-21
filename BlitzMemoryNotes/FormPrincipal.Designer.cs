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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.sourceRichTextBox = new System.Windows.Forms.RichTextBox();
            this.targetRTB_2L = new System.Windows.Forms.RichTextBox();
            this.validationRTB_2L = new System.Windows.Forms.RichTextBox();
            this.targetRTB_1L = new System.Windows.Forms.RichTextBox();
            this.validationRTB_1L = new System.Windows.Forms.RichTextBox();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.materialSwitch_tb2 = new MaterialSkin.Controls.MaterialSwitch();
            this.materialSwitch_tb1 = new MaterialSkin.Controls.MaterialSwitch();
            this.materialLabel18 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel19 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel20 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel15 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel17 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel16 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.FAButton_Borrar_1L = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.FAButton_Borrar_2L = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.FAButton_Borrar_Base = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.Switch_NM = new MaterialSkin.Controls.MaterialSwitch();
            this.progressBarL1 = new MaterialSkin.Controls.MaterialProgressBar();
            this.progressBarL2 = new MaterialSkin.Controls.MaterialProgressBar();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
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
            this.sourceRichTextBox.MaxLength = 7000;
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
            this.targetRTB_2L.Location = new System.Drawing.Point(378, 6);
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
            this.targetRTB_1L.Location = new System.Drawing.Point(756, 6);
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
            this.tabPage1.Controls.Add(this.materialSwitch_tb2);
            this.tabPage1.Controls.Add(this.materialSwitch_tb1);
            this.tabPage1.Controls.Add(this.materialLabel18);
            this.tabPage1.Controls.Add(this.materialLabel19);
            this.tabPage1.Controls.Add(this.materialLabel20);
            this.tabPage1.Controls.Add(this.materialLabel15);
            this.tabPage1.Controls.Add(this.materialLabel17);
            this.tabPage1.Controls.Add(this.materialLabel16);
            this.tabPage1.Controls.Add(this.materialLabel14);
            this.tabPage1.Controls.Add(this.materialLabel13);
            this.tabPage1.Controls.Add(this.materialLabel12);
            this.tabPage1.Controls.Add(this.materialLabel4);
            this.tabPage1.Controls.Add(this.materialLabel5);
            this.tabPage1.Controls.Add(this.materialLabel6);
            this.tabPage1.Controls.Add(this.materialLabel11);
            this.tabPage1.Controls.Add(this.materialLabel10);
            this.tabPage1.Controls.Add(this.materialLabel7);
            this.tabPage1.Controls.Add(this.materialLabel8);
            this.tabPage1.Controls.Add(this.materialLabel9);
            this.tabPage1.Controls.Add(this.materialLabel3);
            this.tabPage1.Controls.Add(this.materialLabel2);
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
            // materialSwitch_tb2
            // 
            this.materialSwitch_tb2.AutoSize = true;
            this.materialSwitch_tb2.Depth = 0;
            this.materialSwitch_tb2.Location = new System.Drawing.Point(597, 16);
            this.materialSwitch_tb2.Margin = new System.Windows.Forms.Padding(0);
            this.materialSwitch_tb2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialSwitch_tb2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSwitch_tb2.Name = "materialSwitch_tb2";
            this.materialSwitch_tb2.Ripple = true;
            this.materialSwitch_tb2.Size = new System.Drawing.Size(156, 37);
            this.materialSwitch_tb2.TabIndex = 36;
            this.materialSwitch_tb2.Text = "Ayuda 1 Letra";
            this.materialSwitch_tb2.UseVisualStyleBackColor = true;
            this.materialSwitch_tb2.CheckedChanged += new System.EventHandler(this.materialSwitch_tb2_CheckedChanged);
            // 
            // materialSwitch_tb1
            // 
            this.materialSwitch_tb1.AutoSize = true;
            this.materialSwitch_tb1.Depth = 0;
            this.materialSwitch_tb1.Location = new System.Drawing.Point(202, 16);
            this.materialSwitch_tb1.Margin = new System.Windows.Forms.Padding(0);
            this.materialSwitch_tb1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialSwitch_tb1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSwitch_tb1.Name = "materialSwitch_tb1";
            this.materialSwitch_tb1.Ripple = true;
            this.materialSwitch_tb1.Size = new System.Drawing.Size(164, 37);
            this.materialSwitch_tb1.TabIndex = 35;
            this.materialSwitch_tb1.Text = "Ayuda 2 Letras";
            this.materialSwitch_tb1.UseVisualStyleBackColor = true;
            this.materialSwitch_tb1.CheckedChanged += new System.EventHandler(this.materialSwitch_tb1_CheckedChanged);
            // 
            // materialLabel18
            // 
            this.materialLabel18.AutoSize = true;
            this.materialLabel18.Depth = 0;
            this.materialLabel18.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel18.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel18.HighEmphasis = true;
            this.materialLabel18.Location = new System.Drawing.Point(6, 719);
            this.materialLabel18.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel18.Name = "materialLabel18";
            this.materialLabel18.Size = new System.Drawing.Size(197, 24);
            this.materialLabel18.TabIndex = 34;
            this.materialLabel18.Text = "parentesis necesarios";
            this.materialLabel18.UseAccent = true;
            // 
            // materialLabel19
            // 
            this.materialLabel19.AutoSize = true;
            this.materialLabel19.Depth = 0;
            this.materialLabel19.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel19.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel19.HighEmphasis = true;
            this.materialLabel19.Location = new System.Drawing.Point(6, 697);
            this.materialLabel19.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel19.Name = "materialLabel19";
            this.materialLabel19.Size = new System.Drawing.Size(190, 24);
            this.materialLabel19.TabIndex = 33;
            this.materialLabel19.Text = "signos de puntuacion";
            this.materialLabel19.UseAccent = true;
            // 
            // materialLabel20
            // 
            this.materialLabel20.AutoSize = true;
            this.materialLabel20.Depth = 0;
            this.materialLabel20.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel20.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel20.HighEmphasis = true;
            this.materialLabel20.Location = new System.Drawing.Point(6, 673);
            this.materialLabel20.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel20.Name = "materialLabel20";
            this.materialLabel20.Size = new System.Drawing.Size(167, 24);
            this.materialLabel20.TabIndex = 32;
            this.materialLabel20.Text = "recuerda poner los";
            this.materialLabel20.UseAccent = true;
            // 
            // materialLabel15
            // 
            this.materialLabel15.AutoSize = true;
            this.materialLabel15.Depth = 0;
            this.materialLabel15.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel15.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel15.HighEmphasis = true;
            this.materialLabel15.Location = new System.Drawing.Point(6, 512);
            this.materialLabel15.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel15.Name = "materialLabel15";
            this.materialLabel15.Size = new System.Drawing.Size(197, 24);
            this.materialLabel15.TabIndex = 31;
            this.materialLabel15.Text = "parentesis necesarios";
            this.materialLabel15.UseAccent = true;
            // 
            // materialLabel17
            // 
            this.materialLabel17.AutoSize = true;
            this.materialLabel17.Depth = 0;
            this.materialLabel17.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel17.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel17.HighEmphasis = true;
            this.materialLabel17.Location = new System.Drawing.Point(6, 490);
            this.materialLabel17.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel17.Name = "materialLabel17";
            this.materialLabel17.Size = new System.Drawing.Size(190, 24);
            this.materialLabel17.TabIndex = 30;
            this.materialLabel17.Text = "signos de puntuacion";
            this.materialLabel17.UseAccent = true;
            // 
            // materialLabel16
            // 
            this.materialLabel16.AutoSize = true;
            this.materialLabel16.Depth = 0;
            this.materialLabel16.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel16.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel16.HighEmphasis = true;
            this.materialLabel16.Location = new System.Drawing.Point(6, 466);
            this.materialLabel16.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel16.Name = "materialLabel16";
            this.materialLabel16.Size = new System.Drawing.Size(167, 24);
            this.materialLabel16.TabIndex = 29;
            this.materialLabel16.Text = "recuerda poner los";
            this.materialLabel16.UseAccent = true;
            // 
            // materialLabel14
            // 
            this.materialLabel14.AutoSize = true;
            this.materialLabel14.Depth = 0;
            this.materialLabel14.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel14.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel14.Location = new System.Drawing.Point(6, 490);
            this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel14.Name = "materialLabel14";
            this.materialLabel14.Size = new System.Drawing.Size(190, 24);
            this.materialLabel14.TabIndex = 30;
            this.materialLabel14.Text = "signos de puntuacion";
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel13.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel13.Location = new System.Drawing.Point(6, 466);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(167, 24);
            this.materialLabel13.TabIndex = 29;
            this.materialLabel13.Text = "recuerda poner los";
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel12.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel12.Location = new System.Drawing.Point(6, 442);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(143, 24);
            this.materialLabel12.TabIndex = 28;
            this.materialLabel12.Text = "de cada palabra";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel4.Location = new System.Drawing.Point(6, 418);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(118, 24);
            this.materialLabel4.TabIndex = 27;
            this.materialLabel4.Text = "y ultima letra";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel5.Location = new System.Drawing.Point(6, 394);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(137, 24);
            this.materialLabel5.TabIndex = 26;
            this.materialLabel5.Text = "la primera letra";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel6.Location = new System.Drawing.Point(6, 375);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(207, 24);
            this.materialLabel6.TabIndex = 25;
            this.materialLabel6.Text = "solo tienes que escribir";
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel11.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel11.Location = new System.Drawing.Point(6, 356);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(156, 24);
            this.materialLabel11.TabIndex = 24;
            this.materialLabel11.Text = "En este recuadro ";
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel10.Location = new System.Drawing.Point(6, 649);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(143, 24);
            this.materialLabel10.TabIndex = 23;
            this.materialLabel10.Text = "de cada palabra";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel7.Location = new System.Drawing.Point(6, 625);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(137, 24);
            this.materialLabel7.TabIndex = 22;
            this.materialLabel7.Text = "la primera letra";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel8.Location = new System.Drawing.Point(6, 606);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(207, 24);
            this.materialLabel8.TabIndex = 21;
            this.materialLabel8.Text = "solo tienes que escribir";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel9.Location = new System.Drawing.Point(6, 587);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(156, 24);
            this.materialLabel9.TabIndex = 20;
            this.materialLabel9.Text = "En este recuadro ";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel3.Location = new System.Drawing.Point(6, 167);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(102, 24);
            this.materialLabel3.TabIndex = 16;
            this.materialLabel3.Text = "memorizar ";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel2.Location = new System.Drawing.Point(6, 143);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(177, 24);
            this.materialLabel2.TabIndex = 15;
            this.materialLabel2.Text = "el texto que quieras";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(6, 124);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(221, 24);
            this.materialLabel1.TabIndex = 14;
            this.materialLabel1.Text = "En este recuadro escribe";
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(15, 17);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(113, 36);
            this.materialButton1.TabIndex = 13;
            this.materialButton1.Text = "Mostrar QR";
            this.toolTip1.SetToolTip(this.materialButton1, "Genera un codigo QR que puedes escanear ");
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
            this.toolTip1.SetToolTip(this.FAButton_Borrar_1L, "Presiona para Borrar");
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
            this.toolTip1.SetToolTip(this.FAButton_Borrar_2L, "Presiona para Borrar");
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
            this.toolTip1.SetToolTip(this.FAButton_Borrar_Base, "Presiona para Borrar");
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
        private MaterialSkin.Controls.MaterialProgressBar progressBarL1;
        private MaterialSkin.Controls.MaterialProgressBar progressBarL2;
        private MaterialSkin.Controls.MaterialSwitch Switch_NM;
        private MaterialSkin.Controls.MaterialFloatingActionButton FAButton_Borrar_1L;
        private MaterialSkin.Controls.MaterialFloatingActionButton FAButton_Borrar_2L;
        private MaterialSkin.Controls.MaterialFloatingActionButton FAButton_Borrar_Base;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private System.Windows.Forms.ToolTip toolTip1;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialLabel materialLabel18;
        private MaterialSkin.Controls.MaterialLabel materialLabel19;
        private MaterialSkin.Controls.MaterialLabel materialLabel20;
        private MaterialSkin.Controls.MaterialLabel materialLabel15;
        private MaterialSkin.Controls.MaterialLabel materialLabel17;
        private MaterialSkin.Controls.MaterialLabel materialLabel16;
        private MaterialSkin.Controls.MaterialLabel materialLabel14;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private MaterialSkin.Controls.MaterialSwitch materialSwitch_tb2;
        private MaterialSkin.Controls.MaterialSwitch materialSwitch_tb1;
    }
}

