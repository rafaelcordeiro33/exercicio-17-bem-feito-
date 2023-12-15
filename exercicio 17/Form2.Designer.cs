namespace exercicio_17
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            Registos_list = new ListBox();
            FazerRegistos_txt = new Button();
            Sair_bttn = new Button();
            SuspendLayout();
            // 
            // Registos_list
            // 
            Registos_list.FormattingEnabled = true;
            Registos_list.ItemHeight = 25;
            Registos_list.Location = new Point(83, 50);
            Registos_list.Name = "Registos_list";
            Registos_list.Size = new Size(635, 304);
            Registos_list.TabIndex = 0;
            // 
            // FazerRegistos_txt
            // 
            FazerRegistos_txt.Location = new Point(636, 375);
            FazerRegistos_txt.Name = "FazerRegistos_txt";
            FazerRegistos_txt.Size = new Size(152, 63);
            FazerRegistos_txt.TabIndex = 1;
            FazerRegistos_txt.Text = "Fazer Registos";
            FazerRegistos_txt.UseVisualStyleBackColor = true;
            FazerRegistos_txt.Click += FazerRegistos_txt_Click;
            // 
            // Sair_bttn
            // 
            Sair_bttn.Location = new Point(684, 12);
            Sair_bttn.Name = "Sair_bttn";
            Sair_bttn.Size = new Size(113, 32);
            Sair_bttn.TabIndex = 2;
            Sair_bttn.Text = "Sair";
            Sair_bttn.UseVisualStyleBackColor = true;
            Sair_bttn.Click += Sair_bttn_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(Sair_bttn);
            Controls.Add(FazerRegistos_txt);
            Controls.Add(Registos_list);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private ListBox Registos_list;
        private Button FazerRegistos_txt;
        private Button Sair_bttn;
    }
}