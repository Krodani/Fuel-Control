namespace gasolina_por_vuelta
{
    partial class fuelControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fuelControl));
            this.labelSession = new System.Windows.Forms.Label();
            this.labelTrack = new System.Windows.Forms.Label();
            this.textBoxSessionH = new System.Windows.Forms.TextBox();
            this.textBoxFuelLap = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.labelLiters = new System.Windows.Forms.Label();
            this.comboBoxTrack = new System.Windows.Forms.ComboBox();
            this.textBoxSessionM = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxCars = new System.Windows.Forms.ComboBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.textBoxTank = new System.Windows.Forms.TextBox();
            this.groupBoxCar = new System.Windows.Forms.GroupBox();
            this.labelFuelLap = new System.Windows.Forms.Label();
            this.labelTank = new System.Windows.Forms.Label();
            this.labelCar = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.groupBoxSession = new System.Windows.Forms.GroupBox();
            this.labelTimeLap = new System.Windows.Forms.Label();
            this.textBoxTimeLap = new System.Windows.Forms.TextBox();
            this.labelError = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxExtra = new System.Windows.Forms.CheckBox();
            this.labelTankFull = new System.Windows.Forms.Label();
            this.labelLaps = new System.Windows.Forms.Label();
            this.comboBoxProfile = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelProfile = new System.Windows.Forms.Label();
            this.toolTipHelper = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxCar.SuspendLayout();
            this.groupBoxSession.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelSession
            // 
            resources.ApplyResources(this.labelSession, "labelSession");
            this.labelSession.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelSession.Name = "labelSession";
            this.labelSession.Tag = "";
            // 
            // labelTrack
            // 
            resources.ApplyResources(this.labelTrack, "labelTrack");
            this.labelTrack.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelTrack.Name = "labelTrack";
            // 
            // textBoxSessionH
            // 
            this.textBoxSessionH.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxSessionH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.textBoxSessionH, "textBoxSessionH");
            this.textBoxSessionH.Name = "textBoxSessionH";
            this.toolTipHelper.SetToolTip(this.textBoxSessionH, resources.GetString("textBoxSessionH.ToolTip"));
            this.textBoxSessionH.TextChanged += new System.EventHandler(this.textBoxSessionH_TextChanged);
            this.textBoxSessionH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSession_KeyPress);
            // 
            // textBoxFuelLap
            // 
            this.textBoxFuelLap.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxFuelLap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.textBoxFuelLap, "textBoxFuelLap");
            this.textBoxFuelLap.Name = "textBoxFuelLap";
            this.toolTipHelper.SetToolTip(this.textBoxFuelLap, resources.GetString("textBoxFuelLap.ToolTip"));
            this.textBoxFuelLap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumeric_KeyPress);
            // 
            // buttonCalculate
            // 
            resources.ApplyResources(this.buttonCalculate, "buttonCalculate");
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // labelLiters
            // 
            resources.ApplyResources(this.labelLiters, "labelLiters");
            this.labelLiters.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelLiters.Name = "labelLiters";
            // 
            // comboBoxTrack
            // 
            this.comboBoxTrack.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxTrack.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBoxTrack.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comboBoxTrack, "comboBoxTrack");
            this.comboBoxTrack.Name = "comboBoxTrack";
            this.toolTipHelper.SetToolTip(this.comboBoxTrack, resources.GetString("comboBoxTrack.ToolTip"));
            this.comboBoxTrack.SelectedIndexChanged += new System.EventHandler(this.comboBoxCarsTrack_SelectedIndexChanged);
            this.comboBoxTrack.SelectedValueChanged += new System.EventHandler(this.comboBoxTrack_SelectedValueChanged);
            // 
            // textBoxSessionM
            // 
            this.textBoxSessionM.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxSessionM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.textBoxSessionM, "textBoxSessionM");
            this.textBoxSessionM.Name = "textBoxSessionM";
            this.toolTipHelper.SetToolTip(this.textBoxSessionM, resources.GetString("textBoxSessionM.ToolTip"));
            this.textBoxSessionM.TextChanged += new System.EventHandler(this.textBoxSessionM_TextChanged);
            this.textBoxSessionM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSession_KeyPress);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Name = "label5";
            // 
            // comboBoxCars
            // 
            this.comboBoxCars.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxCars.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxCars.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxCars.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBoxCars.DropDownWidth = 370;
            resources.ApplyResources(this.comboBoxCars, "comboBoxCars");
            this.comboBoxCars.Name = "comboBoxCars";
            this.toolTipHelper.SetToolTip(this.comboBoxCars, resources.GetString("comboBoxCars.ToolTip"));
            this.comboBoxCars.SelectedIndexChanged += new System.EventHandler(this.comboBoxCarsTrack_SelectedIndexChanged);
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comboBoxCategory, "comboBoxCategory");
            this.comboBoxCategory.Items.AddRange(new object[] {
            resources.GetString("comboBoxCategory.Items"),
            resources.GetString("comboBoxCategory.Items1"),
            resources.GetString("comboBoxCategory.Items2")});
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.toolTipHelper.SetToolTip(this.comboBoxCategory, resources.GetString("comboBoxCategory.ToolTip"));
            this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategory_SelectedIndexChanged);
            // 
            // textBoxTank
            // 
            this.textBoxTank.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxTank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.textBoxTank, "textBoxTank");
            this.textBoxTank.Name = "textBoxTank";
            this.toolTipHelper.SetToolTip(this.textBoxTank, resources.GetString("textBoxTank.ToolTip"));
            this.textBoxTank.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSession_KeyPress);
            // 
            // groupBoxCar
            // 
            this.groupBoxCar.Controls.Add(this.labelFuelLap);
            this.groupBoxCar.Controls.Add(this.textBoxTank);
            this.groupBoxCar.Controls.Add(this.textBoxFuelLap);
            this.groupBoxCar.Controls.Add(this.comboBoxCars);
            this.groupBoxCar.Controls.Add(this.comboBoxCategory);
            this.groupBoxCar.Controls.Add(this.labelTank);
            this.groupBoxCar.Controls.Add(this.labelCar);
            this.groupBoxCar.Controls.Add(this.labelCategory);
            resources.ApplyResources(this.groupBoxCar, "groupBoxCar");
            this.groupBoxCar.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBoxCar.Name = "groupBoxCar";
            this.groupBoxCar.TabStop = false;
            // 
            // labelFuelLap
            // 
            resources.ApplyResources(this.labelFuelLap, "labelFuelLap");
            this.labelFuelLap.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelFuelLap.Name = "labelFuelLap";
            // 
            // labelTank
            // 
            resources.ApplyResources(this.labelTank, "labelTank");
            this.labelTank.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelTank.Name = "labelTank";
            // 
            // labelCar
            // 
            resources.ApplyResources(this.labelCar, "labelCar");
            this.labelCar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelCar.Name = "labelCar";
            // 
            // labelCategory
            // 
            resources.ApplyResources(this.labelCategory, "labelCategory");
            this.labelCategory.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelCategory.Name = "labelCategory";
            // 
            // groupBoxSession
            // 
            this.groupBoxSession.Controls.Add(this.labelTimeLap);
            this.groupBoxSession.Controls.Add(this.labelSession);
            this.groupBoxSession.Controls.Add(this.textBoxTimeLap);
            this.groupBoxSession.Controls.Add(this.label5);
            this.groupBoxSession.Controls.Add(this.labelTrack);
            this.groupBoxSession.Controls.Add(this.textBoxSessionM);
            this.groupBoxSession.Controls.Add(this.comboBoxTrack);
            this.groupBoxSession.Controls.Add(this.textBoxSessionH);
            resources.ApplyResources(this.groupBoxSession, "groupBoxSession");
            this.groupBoxSession.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBoxSession.Name = "groupBoxSession";
            this.groupBoxSession.TabStop = false;
            // 
            // labelTimeLap
            // 
            resources.ApplyResources(this.labelTimeLap, "labelTimeLap");
            this.labelTimeLap.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelTimeLap.Name = "labelTimeLap";
            // 
            // textBoxTimeLap
            // 
            this.textBoxTimeLap.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxTimeLap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.textBoxTimeLap, "textBoxTimeLap");
            this.textBoxTimeLap.Name = "textBoxTimeLap";
            this.toolTipHelper.SetToolTip(this.textBoxTimeLap, resources.GetString("textBoxTimeLap.ToolTip"));
            this.textBoxTimeLap.TextChanged += new System.EventHandler(this.textBoxTimeLap_TextChanged);
            this.textBoxTimeLap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumeric_KeyPress);
            // 
            // labelError
            // 
            resources.ApplyResources(this.labelError, "labelError");
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Name = "labelError";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxExtra);
            this.groupBox1.Controls.Add(this.labelTankFull);
            this.groupBox1.Controls.Add(this.labelLaps);
            this.groupBox1.Controls.Add(this.labelLiters);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // checkBoxExtra
            // 
            resources.ApplyResources(this.checkBoxExtra, "checkBoxExtra");
            this.checkBoxExtra.Checked = true;
            this.checkBoxExtra.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxExtra.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.checkBoxExtra.Name = "checkBoxExtra";
            this.toolTipHelper.SetToolTip(this.checkBoxExtra, resources.GetString("checkBoxExtra.ToolTip"));
            this.checkBoxExtra.UseVisualStyleBackColor = true;
            // 
            // labelTankFull
            // 
            resources.ApplyResources(this.labelTankFull, "labelTankFull");
            this.labelTankFull.ForeColor = System.Drawing.Color.Red;
            this.labelTankFull.Name = "labelTankFull";
            // 
            // labelLaps
            // 
            resources.ApplyResources(this.labelLaps, "labelLaps");
            this.labelLaps.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelLaps.Name = "labelLaps";
            // 
            // comboBoxProfile
            // 
            this.comboBoxProfile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comboBoxProfile, "comboBoxProfile");
            this.comboBoxProfile.FormattingEnabled = true;
            this.comboBoxProfile.Items.AddRange(new object[] {
            resources.GetString("comboBoxProfile.Items"),
            resources.GetString("comboBoxProfile.Items1")});
            this.comboBoxProfile.Name = "comboBoxProfile";
            this.toolTipHelper.SetToolTip(this.comboBoxProfile, resources.GetString("comboBoxProfile.ToolTip"));
            this.comboBoxProfile.SelectedIndexChanged += new System.EventHandler(this.comboBoxProfile_SelectedIndexChanged);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // labelProfile
            // 
            resources.ApplyResources(this.labelProfile, "labelProfile");
            this.labelProfile.ForeColor = System.Drawing.SystemColors.Control;
            this.labelProfile.Name = "labelProfile";
            // 
            // fuelControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(62)))));
            this.Controls.Add(this.labelProfile);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxProfile);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxSession);
            this.Controls.Add(this.groupBoxCar);
            this.MaximizeBox = false;
            this.Name = "fuelControl";
            this.groupBoxCar.ResumeLayout(false);
            this.groupBoxCar.PerformLayout();
            this.groupBoxSession.ResumeLayout(false);
            this.groupBoxSession.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSession;
        private System.Windows.Forms.Label labelTrack;
        private System.Windows.Forms.TextBox textBoxSessionH;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label labelLiters;
        private System.Windows.Forms.ComboBox comboBoxTrack;
        private System.Windows.Forms.TextBox textBoxSessionM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBoxCar;
        private System.Windows.Forms.GroupBox groupBoxSession;
        private System.Windows.Forms.TextBox textBoxTimeLap;
        private System.Windows.Forms.Label labelTimeLap;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelLaps;
        private System.Windows.Forms.ComboBox comboBoxProfile;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelProfile;
        private System.Windows.Forms.Label labelTankFull;
        private System.Windows.Forms.CheckBox checkBoxExtra;
        private System.Windows.Forms.TextBox textBoxFuelLap;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.ComboBox comboBoxCars;
        private System.Windows.Forms.TextBox textBoxTank;
        private System.Windows.Forms.Label labelTank;
        private System.Windows.Forms.Label labelCar;
        private System.Windows.Forms.Label labelFuelLap;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.ToolTip toolTipHelper;
    }
}

