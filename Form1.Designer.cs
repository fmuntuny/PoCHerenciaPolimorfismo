namespace PoC_Herencia_Polimorfismo
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
            gboxPoliHerencia = new GroupBox();
            lblEjemploPolimorfismoSobreescritura = new Label();
            lblGato = new Label();
            btnGato = new Button();
            lblPerro = new Label();
            btnPerro = new Button();
            gboxPoliSobrecarga = new GroupBox();
            txtGato2 = new TextBox();
            txtPerro2 = new TextBox();
            label1 = new Label();
            lblGato2 = new Label();
            btnGato2 = new Button();
            lblPerro2 = new Label();
            btnPerro2 = new Button();
            label2 = new Label();
            groupBox1 = new GroupBox();
            lblGato3 = new Label();
            lblPerro3 = new Label();
            label3 = new Label();
            btnGato3 = new Button();
            btnPerro3 = new Button();
            gboxPoliHerencia.SuspendLayout();
            gboxPoliSobrecarga.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // gboxPoliHerencia
            // 
            gboxPoliHerencia.Controls.Add(lblEjemploPolimorfismoSobreescritura);
            gboxPoliHerencia.Controls.Add(lblGato);
            gboxPoliHerencia.Controls.Add(btnGato);
            gboxPoliHerencia.Controls.Add(lblPerro);
            gboxPoliHerencia.Controls.Add(btnPerro);
            gboxPoliHerencia.Location = new Point(12, 12);
            gboxPoliHerencia.Name = "gboxPoliHerencia";
            gboxPoliHerencia.Size = new Size(378, 155);
            gboxPoliHerencia.TabIndex = 5;
            gboxPoliHerencia.TabStop = false;
            gboxPoliHerencia.Text = "Polimorfismo de herencia";
            // 
            // lblEjemploPolimorfismoSobreescritura
            // 
            lblEjemploPolimorfismoSobreescritura.Location = new Point(6, 25);
            lblEjemploPolimorfismoSobreescritura.Name = "lblEjemploPolimorfismoSobreescritura";
            lblEjemploPolimorfismoSobreescritura.Size = new Size(368, 52);
            lblEjemploPolimorfismoSobreescritura.TabIndex = 9;
            lblEjemploPolimorfismoSobreescritura.Text = "Perro y Gato heredan de Animal que tiene un método llamado EmitirOnomatopeya(). Perro y Gato sobreescriben este método adaptandolo a sus necesidades.";
            // 
            // lblGato
            // 
            lblGato.Location = new Point(88, 109);
            lblGato.Name = "lblGato";
            lblGato.Size = new Size(271, 23);
            lblGato.TabIndex = 8;
            // 
            // btnGato
            // 
            btnGato.Location = new Point(6, 109);
            btnGato.Name = "btnGato";
            btnGato.Size = new Size(76, 23);
            btnGato.TabIndex = 7;
            btnGato.Text = "Gato";
            btnGato.UseVisualStyleBackColor = true;
            btnGato.Click += btnGato_Click_1;
            // 
            // lblPerro
            // 
            lblPerro.Location = new Point(88, 80);
            lblPerro.Name = "lblPerro";
            lblPerro.Size = new Size(271, 23);
            lblPerro.TabIndex = 6;
            // 
            // btnPerro
            // 
            btnPerro.Location = new Point(7, 80);
            btnPerro.Name = "btnPerro";
            btnPerro.Size = new Size(75, 23);
            btnPerro.TabIndex = 5;
            btnPerro.Text = "Perro";
            btnPerro.UseVisualStyleBackColor = true;
            btnPerro.Click += btnPerro_Click_1;
            // 
            // gboxPoliSobrecarga
            // 
            gboxPoliSobrecarga.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gboxPoliSobrecarga.AutoSize = true;
            gboxPoliSobrecarga.Controls.Add(txtGato2);
            gboxPoliSobrecarga.Controls.Add(txtPerro2);
            gboxPoliSobrecarga.Controls.Add(label1);
            gboxPoliSobrecarga.Controls.Add(lblGato2);
            gboxPoliSobrecarga.Controls.Add(btnGato2);
            gboxPoliSobrecarga.Controls.Add(lblPerro2);
            gboxPoliSobrecarga.Controls.Add(btnPerro2);
            gboxPoliSobrecarga.Location = new Point(396, 12);
            gboxPoliSobrecarga.Name = "gboxPoliSobrecarga";
            gboxPoliSobrecarga.Size = new Size(769, 155);
            gboxPoliSobrecarga.TabIndex = 10;
            gboxPoliSobrecarga.TabStop = false;
            gboxPoliSobrecarga.Text = "Polimorfismo de sobrecarga";
            // 
            // txtGato2
            // 
            txtGato2.Location = new Point(87, 110);
            txtGato2.Name = "txtGato2";
            txtGato2.Size = new Size(114, 23);
            txtGato2.TabIndex = 11;
            // 
            // txtPerro2
            // 
            txtPerro2.Location = new Point(87, 80);
            txtPerro2.Name = "txtPerro2";
            txtPerro2.Size = new Size(114, 23);
            txtPerro2.TabIndex = 10;
            // 
            // label1
            // 
            label1.CausesValidation = false;
            label1.Location = new Point(6, 25);
            label1.Name = "label1";
            label1.Size = new Size(451, 52);
            label1.TabIndex = 9;
            label1.Text = resources.GetString("label1.Text");
            // 
            // lblGato2
            // 
            lblGato2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblGato2.Location = new Point(207, 110);
            lblGato2.Name = "lblGato2";
            lblGato2.Size = new Size(556, 23);
            lblGato2.TabIndex = 8;
            // 
            // btnGato2
            // 
            btnGato2.Location = new Point(6, 109);
            btnGato2.Name = "btnGato2";
            btnGato2.Size = new Size(75, 23);
            btnGato2.TabIndex = 7;
            btnGato2.Text = "Gato";
            btnGato2.UseVisualStyleBackColor = true;
            btnGato2.Click += btnGato2_Click;
            // 
            // lblPerro2
            // 
            lblPerro2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblPerro2.Location = new Point(207, 80);
            lblPerro2.Name = "lblPerro2";
            lblPerro2.Size = new Size(556, 23);
            lblPerro2.TabIndex = 6;
            // 
            // btnPerro2
            // 
            btnPerro2.Location = new Point(6, 80);
            btnPerro2.Name = "btnPerro2";
            btnPerro2.Size = new Size(75, 23);
            btnPerro2.TabIndex = 5;
            btnPerro2.Text = "Perro";
            btnPerro2.UseVisualStyleBackColor = true;
            btnPerro2.Click += button2_Click;
            // 
            // label2
            // 
            label2.Location = new Point(12, 323);
            label2.Name = "label2";
            label2.Size = new Size(996, 195);
            label2.TabIndex = 11;
            label2.Text = resources.GetString("label2.Text");
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblGato3);
            groupBox1.Controls.Add(lblPerro3);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnGato3);
            groupBox1.Controls.Add(btnPerro3);
            groupBox1.Location = new Point(12, 169);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(378, 151);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Polimorfismo por Interfaces";
            // 
            // lblGato3
            // 
            lblGato3.Location = new Point(87, 112);
            lblGato3.Name = "lblGato3";
            lblGato3.Size = new Size(202, 23);
            lblGato3.TabIndex = 14;
            // 
            // lblPerro3
            // 
            lblPerro3.Location = new Point(87, 83);
            lblPerro3.Name = "lblPerro3";
            lblPerro3.Size = new Size(202, 23);
            lblPerro3.TabIndex = 13;
            // 
            // label3
            // 
            label3.Location = new Point(5, 23);
            label3.Name = "label3";
            label3.Size = new Size(368, 57);
            label3.TabIndex = 12;
            label3.Text = "PerroPorInterfaz y GatoPorInterfaz implementan la interfaz IAnimal que tiene un método llamado EmitirOnomatopeya(). Los dos implementan la interfaz pero la adaptan a sus necesidades.";
            // 
            // btnGato3
            // 
            btnGato3.Location = new Point(6, 112);
            btnGato3.Name = "btnGato3";
            btnGato3.Size = new Size(75, 23);
            btnGato3.TabIndex = 11;
            btnGato3.Text = "Gato";
            btnGato3.UseVisualStyleBackColor = true;
            btnGato3.Click += btnGato3_Click;
            // 
            // btnPerro3
            // 
            btnPerro3.Location = new Point(6, 83);
            btnPerro3.Name = "btnPerro3";
            btnPerro3.Size = new Size(75, 23);
            btnPerro3.TabIndex = 10;
            btnPerro3.Text = "Perro";
            btnPerro3.UseVisualStyleBackColor = true;
            btnPerro3.Click += button2_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1174, 527);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(gboxPoliSobrecarga);
            Controls.Add(gboxPoliHerencia);
            Name = "Form1";
            Text = "Form1";
            gboxPoliHerencia.ResumeLayout(false);
            gboxPoliSobrecarga.ResumeLayout(false);
            gboxPoliSobrecarga.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gboxPoliHerencia;
        private Label lblEjemploPolimorfismoSobreescritura;
        private Label lblGato;
        private Button btnGato;
        private Label lblPerro;
        private Button btnPerro;
        private GroupBox gboxPoliSobrecarga;
        private Label label1;
        private Label lblGato2;
        private Button btnGato2;
        private Label lblPerro2;
        private Button btnPerro2;
        private TextBox txtGato2;
        private TextBox txtPerro2;
        private Label label2;
        private GroupBox groupBox1;
        private Label label3;
        private Button btnGato3;
        private Button btnPerro3;
        private Label lblGato3;
        private Label lblPerro3;
    }
}