
namespace picGUI
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
            this.components = new System.ComponentModel.Container();
            this.portList = new System.Windows.Forms.ComboBox();
            this.bntConectar = new System.Windows.Forms.Button();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.bxTemperatura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bxEnviar1 = new System.Windows.Forms.TextBox();
            this.btnEnviar1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.puertoSerie = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bcSemi = new System.Windows.Forms.CheckBox();
            this.bcAutomaticoMaster = new System.Windows.Forms.CheckBox();
            this.bcManualMaster = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bcAutomatico0 = new System.Windows.Forms.CheckBox();
            this.bcManual0 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEnviar0 = new System.Windows.Forms.Button();
            this.bxVentilador = new System.Windows.Forms.TextBox();
            this.bxEnviar0 = new System.Windows.Forms.TextBox();
            this.btnOff0 = new System.Windows.Forms.Button();
            this.btnOn0 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.bcAutomatico1 = new System.Windows.Forms.CheckBox();
            this.bxHumedad = new System.Windows.Forms.TextBox();
            this.bcManual1 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btBomba = new System.Windows.Forms.TextBox();
            this.btnOff1 = new System.Windows.Forms.Button();
            this.btnOn1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // portList
            // 
            this.portList.FormattingEnabled = true;
            this.portList.Location = new System.Drawing.Point(6, 21);
            this.portList.Name = "portList";
            this.portList.Size = new System.Drawing.Size(121, 21);
            this.portList.TabIndex = 1;
            // 
            // bntConectar
            // 
            this.bntConectar.Location = new System.Drawing.Point(6, 48);
            this.bntConectar.Name = "bntConectar";
            this.bntConectar.Size = new System.Drawing.Size(75, 23);
            this.bntConectar.TabIndex = 2;
            this.bntConectar.Text = "Conectar";
            this.bntConectar.UseVisualStyleBackColor = true;
            this.bntConectar.Click += new System.EventHandler(this.bntConectar_Click);
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.Location = new System.Drawing.Point(87, 48);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(83, 23);
            this.btnDesconectar.TabIndex = 3;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.UseVisualStyleBackColor = true;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // bxTemperatura
            // 
            this.bxTemperatura.Location = new System.Drawing.Point(85, 25);
            this.bxTemperatura.Multiline = true;
            this.bxTemperatura.Name = "bxTemperatura";
            this.bxTemperatura.ReadOnly = true;
            this.bxTemperatura.Size = new System.Drawing.Size(128, 27);
            this.bxTemperatura.TabIndex = 4;
            this.bxTemperatura.TextChanged += new System.EventHandler(this.bxRecibir_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Temperatura:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bxEnviar1
            // 
            this.bxEnviar1.Location = new System.Drawing.Point(87, 118);
            this.bxEnviar1.Name = "bxEnviar1";
            this.bxEnviar1.Size = new System.Drawing.Size(165, 20);
            this.bxEnviar1.TabIndex = 6;
            // 
            // btnEnviar1
            // 
            this.btnEnviar1.Location = new System.Drawing.Point(6, 115);
            this.btnEnviar1.Name = "btnEnviar1";
            this.btnEnviar1.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar1.TabIndex = 7;
            this.btnEnviar1.Text = "Enviar";
            this.btnEnviar1.UseVisualStyleBackColor = true;
            this.btnEnviar1.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Humedad del suelo";
            // 
            // puertoSerie
            // 
            this.puertoSerie.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.puertoSerie_DataReceived);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDesconectar);
            this.groupBox1.Controls.Add(this.bntConectar);
            this.groupBox1.Controls.Add(this.portList);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 100);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conexion";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bcSemi);
            this.groupBox2.Controls.Add(this.bcAutomaticoMaster);
            this.groupBox2.Controls.Add(this.bcManualMaster);
            this.groupBox2.Location = new System.Drawing.Point(359, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modo";
            // 
            // bcSemi
            // 
            this.bcSemi.AutoSize = true;
            this.bcSemi.Location = new System.Drawing.Point(55, 48);
            this.bcSemi.Name = "bcSemi";
            this.bcSemi.Size = new System.Drawing.Size(79, 17);
            this.bcSemi.TabIndex = 2;
            this.bcSemi.Text = "Modo Semi";
            this.bcSemi.UseVisualStyleBackColor = true;
            this.bcSemi.CheckedChanged += new System.EventHandler(this.bcSemi_CheckedChanged);
            // 
            // bcAutomaticoMaster
            // 
            this.bcAutomaticoMaster.AutoSize = true;
            this.bcAutomaticoMaster.Location = new System.Drawing.Point(55, 71);
            this.bcAutomaticoMaster.Name = "bcAutomaticoMaster";
            this.bcAutomaticoMaster.Size = new System.Drawing.Size(109, 17);
            this.bcAutomaticoMaster.TabIndex = 1;
            this.bcAutomaticoMaster.Text = "Modo Automatico";
            this.bcAutomaticoMaster.UseVisualStyleBackColor = true;
            this.bcAutomaticoMaster.CheckedChanged += new System.EventHandler(this.bcAutomaticoMaster_CheckedChanged);
            // 
            // bcManualMaster
            // 
            this.bcManualMaster.AutoSize = true;
            this.bcManualMaster.Location = new System.Drawing.Point(55, 25);
            this.bcManualMaster.Name = "bcManualMaster";
            this.bcManualMaster.Size = new System.Drawing.Size(90, 17);
            this.bcManualMaster.TabIndex = 0;
            this.bcManualMaster.Text = "Modo manual";
            this.bcManualMaster.UseVisualStyleBackColor = true;
            this.bcManualMaster.CheckedChanged += new System.EventHandler(this.bcManualMaster_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bcAutomatico0);
            this.groupBox3.Controls.Add(this.bcManual0);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.btnEnviar0);
            this.groupBox3.Controls.Add(this.bxVentilador);
            this.groupBox3.Controls.Add(this.bxEnviar0);
            this.groupBox3.Controls.Add(this.btnOff0);
            this.groupBox3.Controls.Add(this.btnOn0);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.bxTemperatura);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(12, 127);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(567, 148);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Medidor de temperatura";
            // 
            // bcAutomatico0
            // 
            this.bcAutomatico0.AutoSize = true;
            this.bcAutomatico0.Location = new System.Drawing.Point(414, 84);
            this.bcAutomatico0.Name = "bcAutomatico0";
            this.bcAutomatico0.Size = new System.Drawing.Size(109, 17);
            this.bcAutomatico0.TabIndex = 14;
            this.bcAutomatico0.Text = "Modo Automatico";
            this.bcAutomatico0.UseVisualStyleBackColor = true;
            this.bcAutomatico0.CheckedChanged += new System.EventHandler(this.bcAutomatico0_CheckedChanged);
            // 
            // bcManual0
            // 
            this.bcManual0.AutoSize = true;
            this.bcManual0.Location = new System.Drawing.Point(414, 61);
            this.bcManual0.Name = "bcManual0";
            this.bcManual0.Size = new System.Drawing.Size(91, 17);
            this.bcManual0.TabIndex = 2;
            this.bcManual0.Text = "Modo Manual";
            this.bcManual0.UseVisualStyleBackColor = true;
            this.bcManual0.CheckedChanged += new System.EventHandler(this.bcManual0_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(411, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Modo";
            // 
            // btnEnviar0
            // 
            this.btnEnviar0.Location = new System.Drawing.Point(6, 106);
            this.btnEnviar0.Name = "btnEnviar0";
            this.btnEnviar0.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar0.TabIndex = 12;
            this.btnEnviar0.Text = "Enviar";
            this.btnEnviar0.UseVisualStyleBackColor = true;
            this.btnEnviar0.Click += new System.EventHandler(this.btnEnviar0_Click);
            // 
            // bxVentilador
            // 
            this.bxVentilador.Location = new System.Drawing.Point(124, 61);
            this.bxVentilador.Multiline = true;
            this.bxVentilador.Name = "bxVentilador";
            this.bxVentilador.ReadOnly = true;
            this.bxVentilador.Size = new System.Drawing.Size(89, 27);
            this.bxVentilador.TabIndex = 11;
            // 
            // bxEnviar0
            // 
            this.bxEnviar0.Location = new System.Drawing.Point(87, 109);
            this.bxEnviar0.Name = "bxEnviar0";
            this.bxEnviar0.Size = new System.Drawing.Size(126, 20);
            this.bxEnviar0.TabIndex = 10;
            // 
            // btnOff0
            // 
            this.btnOff0.Location = new System.Drawing.Point(305, 64);
            this.btnOff0.Name = "btnOff0";
            this.btnOff0.Size = new System.Drawing.Size(75, 23);
            this.btnOff0.TabIndex = 8;
            this.btnOff0.Text = "Off";
            this.btnOff0.UseVisualStyleBackColor = true;
            this.btnOff0.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnOn0
            // 
            this.btnOn0.Location = new System.Drawing.Point(224, 64);
            this.btnOn0.Name = "btnOn0";
            this.btnOn0.Size = new System.Drawing.Size(75, 23);
            this.btnOn0.TabIndex = 7;
            this.btnOn0.Text = "On";
            this.btnOn0.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Estado del ventilador:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.bcAutomatico1);
            this.groupBox4.Controls.Add(this.bxHumedad);
            this.groupBox4.Controls.Add(this.bcManual1);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.btBomba);
            this.groupBox4.Controls.Add(this.btnOff1);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.btnOn1);
            this.groupBox4.Controls.Add(this.bxEnviar1);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.btnEnviar1);
            this.groupBox4.Location = new System.Drawing.Point(12, 300);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(567, 154);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Control de riego";
            // 
            // bcAutomatico1
            // 
            this.bcAutomatico1.AutoSize = true;
            this.bcAutomatico1.Location = new System.Drawing.Point(439, 87);
            this.bcAutomatico1.Name = "bcAutomatico1";
            this.bcAutomatico1.Size = new System.Drawing.Size(109, 17);
            this.bcAutomatico1.TabIndex = 17;
            this.bcAutomatico1.Text = "Modo Automatico";
            this.bcAutomatico1.UseVisualStyleBackColor = true;
            this.bcAutomatico1.CheckedChanged += new System.EventHandler(this.bcAutomatico1_CheckedChanged);
            // 
            // bxHumedad
            // 
            this.bxHumedad.Location = new System.Drawing.Point(124, 28);
            this.bxHumedad.Multiline = true;
            this.bxHumedad.Name = "bxHumedad";
            this.bxHumedad.ReadOnly = true;
            this.bxHumedad.Size = new System.Drawing.Size(128, 27);
            this.bxHumedad.TabIndex = 15;
            // 
            // bcManual1
            // 
            this.bcManual1.AutoSize = true;
            this.bcManual1.Location = new System.Drawing.Point(439, 64);
            this.bcManual1.Name = "bcManual1";
            this.bcManual1.Size = new System.Drawing.Size(91, 17);
            this.bcManual1.TabIndex = 15;
            this.bcManual1.Text = "Modo Manual";
            this.bcManual1.UseVisualStyleBackColor = true;
            this.bcManual1.CheckedChanged += new System.EventHandler(this.bcManual1_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(436, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Modo";
            // 
            // btBomba
            // 
            this.btBomba.Location = new System.Drawing.Point(152, 73);
            this.btBomba.Multiline = true;
            this.btBomba.Name = "btBomba";
            this.btBomba.ReadOnly = true;
            this.btBomba.Size = new System.Drawing.Size(100, 27);
            this.btBomba.TabIndex = 18;
            // 
            // btnOff1
            // 
            this.btnOff1.Location = new System.Drawing.Point(347, 77);
            this.btnOff1.Name = "btnOff1";
            this.btnOff1.Size = new System.Drawing.Size(75, 23);
            this.btnOff1.TabIndex = 17;
            this.btnOff1.Text = "Off";
            this.btnOff1.UseVisualStyleBackColor = true;
            this.btnOff1.Click += new System.EventHandler(this.btnOff1_Click);
            // 
            // btnOn1
            // 
            this.btnOn1.Location = new System.Drawing.Point(266, 77);
            this.btnOn1.Name = "btnOn1";
            this.btnOn1.Size = new System.Drawing.Size(75, 23);
            this.btnOn1.TabIndex = 16;
            this.btnOn1.Text = "On";
            this.btnOn1.UseVisualStyleBackColor = true;
            this.btnOn1.Click += new System.EventHandler(this.btnOn1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Estado de la bomba de agua";
            this.label5.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 463);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox portList;
        private System.Windows.Forms.Button bntConectar;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.TextBox bxTemperatura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bxEnviar1;
        private System.Windows.Forms.Button btnEnviar1;
        private System.Windows.Forms.Label label2;
        private System.IO.Ports.SerialPort puertoSerie;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox bcAutomaticoMaster;
        private System.Windows.Forms.CheckBox bcManualMaster;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox bxVentilador;
        private System.Windows.Forms.TextBox bxEnviar0;
        private System.Windows.Forms.Button btnOff0;
        private System.Windows.Forms.Button btnOn0;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEnviar0;
        private System.Windows.Forms.CheckBox bcAutomatico0;
        private System.Windows.Forms.CheckBox bcManual0;
        private System.Windows.Forms.CheckBox bcAutomatico1;
        private System.Windows.Forms.TextBox bxHumedad;
        private System.Windows.Forms.CheckBox bcManual1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox btBomba;
        private System.Windows.Forms.Button btnOff1;
        private System.Windows.Forms.Button btnOn1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox bcSemi;
    }
}

