namespace ProgIIIClass2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btn_AFP = new Button();
            btn_ARS = new Button();
            btn_ISR = new Button();
            btn_TOTALDESCUENTO = new Button();
            btn_SUELDONETO = new Button();
            label1 = new Label();
            txtBox_SueldoBruto = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // btn_AFP
            // 
            btn_AFP.Location = new Point(154, 308);
            btn_AFP.Name = "btn_AFP";
            btn_AFP.Size = new Size(75, 23);
            btn_AFP.TabIndex = 1;
            btn_AFP.Text = "AFP";
            btn_AFP.UseVisualStyleBackColor = true;
            btn_AFP.Click += btn_AFP_Click;
            // 
            // btn_ARS
            // 
            btn_ARS.Location = new Point(235, 308);
            btn_ARS.Name = "btn_ARS";
            btn_ARS.Size = new Size(75, 23);
            btn_ARS.TabIndex = 2;
            btn_ARS.Text = "ARS";
            btn_ARS.UseVisualStyleBackColor = true;
            btn_ARS.Click += btn_ARS_Click;
            // 
            // btn_ISR
            // 
            btn_ISR.Location = new Point(316, 308);
            btn_ISR.Name = "btn_ISR";
            btn_ISR.Size = new Size(75, 23);
            btn_ISR.TabIndex = 3;
            btn_ISR.Text = "ISR";
            btn_ISR.UseVisualStyleBackColor = true;
            btn_ISR.Click += btn_ISR_Click;
            // 
            // btn_TOTALDESCUENTO
            // 
            btn_TOTALDESCUENTO.Location = new Point(397, 308);
            btn_TOTALDESCUENTO.Name = "btn_TOTALDESCUENTO";
            btn_TOTALDESCUENTO.Size = new Size(131, 23);
            btn_TOTALDESCUENTO.TabIndex = 4;
            btn_TOTALDESCUENTO.Text = "TOTAL DESCUENTO";
            btn_TOTALDESCUENTO.UseVisualStyleBackColor = true;
            btn_TOTALDESCUENTO.Click += btn_TOTALDESCUENTO_Click;
            // 
            // btn_SUELDONETO
            // 
            btn_SUELDONETO.Location = new Point(534, 308);
            btn_SUELDONETO.Name = "btn_SUELDONETO";
            btn_SUELDONETO.Size = new Size(103, 23);
            btn_SUELDONETO.TabIndex = 5;
            btn_SUELDONETO.Text = "SUELDO NETO";
            btn_SUELDONETO.UseVisualStyleBackColor = true;
            btn_SUELDONETO.Click += btn_SUELDONETO_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(279, 167);
            label1.Name = "label1";
            label1.Size = new Size(100, 21);
            label1.TabIndex = 6;
            label1.Text = "Sueldo Bruto";
            // 
            // txtBox_SueldoBruto
            // 
            txtBox_SueldoBruto.BackColor = Color.FromArgb(128, 255, 128);
            txtBox_SueldoBruto.BorderStyle = BorderStyle.None;
            txtBox_SueldoBruto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBox_SueldoBruto.Location = new Point(385, 167);
            txtBox_SueldoBruto.Multiline = true;
            txtBox_SueldoBruto.Name = "txtBox_SueldoBruto";
            txtBox_SueldoBruto.PlaceholderText = "Ejemplo: 45000";
            txtBox_SueldoBruto.Size = new Size(163, 21);
            txtBox_SueldoBruto.TabIndex = 7;
            txtBox_SueldoBruto.KeyPress += txtBox_SueldoBruto_KeyPress;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 255, 128);
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(592, 71);
            button1.Name = "button1";
            button1.Size = new Size(55, 56);
            button1.TabIndex = 8;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(txtBox_SueldoBruto);
            Controls.Add(label1);
            Controls.Add(btn_SUELDONETO);
            Controls.Add(btn_TOTALDESCUENTO);
            Controls.Add(btn_ISR);
            Controls.Add(btn_ARS);
            Controls.Add(btn_AFP);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Opacity = 0.95D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Control de Nomina";
            TransparencyKey = Color.White;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_AFP;
        private Button btn_ARS;
        private Button btn_ISR;
        private Button btn_TOTALDESCUENTO;
        private Button btn_SUELDONETO;
        private Label label1;
        private TextBox txtBox_SueldoBruto;
        private Button button1;
    }
}
