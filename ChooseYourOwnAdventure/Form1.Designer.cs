namespace ChooseYourOwnAdventure
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.outputLabel = new System.Windows.Forms.Label();
            this.option1Label = new System.Windows.Forms.Label();
            this.option2Label = new System.Windows.Forms.Label();
            this.option3Label = new System.Windows.Forms.Label();
            this.moretexttimer = new System.Windows.Forms.Timer(this.components);
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.option3Button = new System.Windows.Forms.Button();
            this.option2Button = new System.Windows.Forms.Button();
            this.option1Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(12, 0);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(414, 99);
            this.outputLabel.TabIndex = 0;
            this.outputLabel.Text = "outputLabel";
            this.outputLabel.UseCompatibleTextRendering = true;
            // 
            // option1Label
            // 
            this.option1Label.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option1Label.Location = new System.Drawing.Point(52, 351);
            this.option1Label.Name = "option1Label";
            this.option1Label.Size = new System.Drawing.Size(374, 22);
            this.option1Label.TabIndex = 4;
            this.option1Label.Text = "option1Label";
            // 
            // option2Label
            // 
            this.option2Label.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option2Label.Location = new System.Drawing.Point(52, 387);
            this.option2Label.Name = "option2Label";
            this.option2Label.Size = new System.Drawing.Size(374, 22);
            this.option2Label.TabIndex = 5;
            this.option2Label.Text = "option2Label";
            // 
            // option3Label
            // 
            this.option3Label.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option3Label.Location = new System.Drawing.Point(52, 421);
            this.option3Label.Name = "option3Label";
            this.option3Label.Size = new System.Drawing.Size(374, 22);
            this.option3Label.TabIndex = 6;
            this.option3Label.Text = "option3Label";
            // 
            // moretexttimer
            // 
            this.moretexttimer.Interval = 2500;
            this.moretexttimer.Tick += new System.EventHandler(this.moretexttimer_Tick);
            // 
            // imageBox
            // 
            this.imageBox.BackColor = System.Drawing.Color.White;
            this.imageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageBox.Location = new System.Drawing.Point(12, 88);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(414, 256);
            this.imageBox.TabIndex = 8;
            this.imageBox.TabStop = false;
            // 
            // option3Button
            // 
            this.option3Button.BackgroundImage = global::ChooseYourOwnAdventure.Properties.Resources.greenbutton3o;
            this.option3Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.option3Button.FlatAppearance.BorderSize = 0;
            this.option3Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.option3Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.option3Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.option3Button.Location = new System.Drawing.Point(12, 420);
            this.option3Button.Name = "option3Button";
            this.option3Button.Size = new System.Drawing.Size(34, 29);
            this.option3Button.TabIndex = 3;
            this.option3Button.TabStop = false;
            this.option3Button.UseVisualStyleBackColor = true;
            this.option3Button.Click += new System.EventHandler(this.option3Button_Click);
            // 
            // option2Button
            // 
            this.option2Button.BackgroundImage = global::ChooseYourOwnAdventure.Properties.Resources.purplebutton2o;
            this.option2Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.option2Button.FlatAppearance.BorderSize = 0;
            this.option2Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.option2Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.option2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.option2Button.Location = new System.Drawing.Point(12, 386);
            this.option2Button.Name = "option2Button";
            this.option2Button.Size = new System.Drawing.Size(34, 28);
            this.option2Button.TabIndex = 2;
            this.option2Button.TabStop = false;
            this.option2Button.UseVisualStyleBackColor = true;
            this.option2Button.Click += new System.EventHandler(this.option2Button_Click);
            // 
            // option1Button
            // 
            this.option1Button.BackgroundImage = global::ChooseYourOwnAdventure.Properties.Resources.redbutton1o;
            this.option1Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.option1Button.FlatAppearance.BorderSize = 0;
            this.option1Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.option1Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.option1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.option1Button.Location = new System.Drawing.Point(12, 352);
            this.option1Button.Name = "option1Button";
            this.option1Button.Size = new System.Drawing.Size(34, 29);
            this.option1Button.TabIndex = 1;
            this.option1Button.TabStop = false;
            this.option1Button.UseVisualStyleBackColor = true;
            this.option1Button.Click += new System.EventHandler(this.option1Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.GreenYellow;
            this.ClientSize = new System.Drawing.Size(438, 450);
            this.Controls.Add(this.imageBox);
            this.Controls.Add(this.option3Label);
            this.Controls.Add(this.option2Label);
            this.Controls.Add(this.option1Label);
            this.Controls.Add(this.option3Button);
            this.Controls.Add(this.option2Button);
            this.Controls.Add(this.option1Button);
            this.Controls.Add(this.outputLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Choose Your Own Adventure";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button option1Button;
        private System.Windows.Forms.Button option2Button;
        private System.Windows.Forms.Button option3Button;
        private System.Windows.Forms.Label option1Label;
        private System.Windows.Forms.Label option2Label;
        private System.Windows.Forms.Label option3Label;
        private System.Windows.Forms.PictureBox imageBox;
        private System.Windows.Forms.Timer moretexttimer;
    }
}

