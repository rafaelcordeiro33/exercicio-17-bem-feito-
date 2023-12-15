namespace exercicio_17
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Nome_txt = new TextBox();
            Email_txt = new TextBox();
            Password_txt = new TextBox();
            GuardarRegisto_bttn = new Button();
            VerLista_bttn = new Button();
            Sair_bttn = new Button();
            VerPasse_CheckBox = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(275, 55);
            label1.Name = "label1";
            label1.Size = new Size(65, 25);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(282, 121);
            label2.Name = "label2";
            label2.Size = new Size(58, 25);
            label2.TabIndex = 1;
            label2.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(249, 197);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 2;
            label3.Text = "Password:";
            // 
            // Nome_txt
            // 
            Nome_txt.Location = new Point(346, 52);
            Nome_txt.Name = "Nome_txt";
            Nome_txt.Size = new Size(188, 31);
            Nome_txt.TabIndex = 3;
            // 
            // Email_txt
            // 
            Email_txt.Location = new Point(346, 121);
            Email_txt.Name = "Email_txt";
            Email_txt.Size = new Size(188, 31);
            Email_txt.TabIndex = 4;
            // 
            // Password_txt
            // 
            Password_txt.Location = new Point(346, 197);
            Password_txt.Name = "Password_txt";
            Password_txt.Size = new Size(188, 31);
            Password_txt.TabIndex = 5;
            // 
            // GuardarRegisto_bttn
            // 
            GuardarRegisto_bttn.Location = new Point(282, 290);
            GuardarRegisto_bttn.Name = "GuardarRegisto_bttn";
            GuardarRegisto_bttn.Size = new Size(217, 98);
            GuardarRegisto_bttn.TabIndex = 6;
            GuardarRegisto_bttn.Text = "Guardar Registo";
            GuardarRegisto_bttn.UseVisualStyleBackColor = true;
            GuardarRegisto_bttn.Click += GuardarRegisto_bttn_Click;
            // 
            // VerLista_bttn
            // 
            VerLista_bttn.Location = new Point(681, 366);
            VerLista_bttn.Name = "VerLista_bttn";
            VerLista_bttn.Size = new Size(107, 49);
            VerLista_bttn.TabIndex = 7;
            VerLista_bttn.Text = "Ver Lista";
            VerLista_bttn.UseVisualStyleBackColor = true;
            VerLista_bttn.Click += VerLista_bttn_Click;
            // 
            // Sair_bttn
            // 
            Sair_bttn.Location = new Point(681, 12);
            Sair_bttn.Name = "Sair_bttn";
            Sair_bttn.Size = new Size(107, 49);
            Sair_bttn.TabIndex = 8;
            Sair_bttn.Text = "Sair";
            Sair_bttn.UseVisualStyleBackColor = true;
            Sair_bttn.Click += Sair_bttn_Click;
            // 
            // VerPasse_CheckBox
            // 
            VerPasse_CheckBox.AutoSize = true;
            VerPasse_CheckBox.Location = new Point(548, 201);
            VerPasse_CheckBox.Name = "VerPasse_CheckBox";
            VerPasse_CheckBox.Size = new Size(63, 29);
            VerPasse_CheckBox.TabIndex = 9;
            VerPasse_CheckBox.Text = "Ver";
            VerPasse_CheckBox.UseVisualStyleBackColor = true;
            VerPasse_CheckBox.CheckedChanged += VerPasse_CheckBox_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(VerPasse_CheckBox);
            Controls.Add(Sair_bttn);
            Controls.Add(VerLista_bttn);
            Controls.Add(GuardarRegisto_bttn);
            Controls.Add(Password_txt);
            Controls.Add(Email_txt);
            Controls.Add(Nome_txt);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox Nome_txt;
        private TextBox Email_txt;
        private TextBox Password_txt;
        private Button GuardarRegisto_bttn;
        private Button VerLista_bttn;
        private Button Sair_bttn;
        private CheckBox VerPasse_CheckBox;
    }
}
