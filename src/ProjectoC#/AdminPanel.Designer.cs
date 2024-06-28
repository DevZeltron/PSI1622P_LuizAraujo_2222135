namespace ProjectoC_
{
    partial class AdminPanel
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            panel1 = new Panel();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            label1 = new Label();
            btnHam = new PictureBox();
            sidebar = new FlowLayoutPanel();
            menuContainer = new Panel();
            menu = new Button();
            submenu2 = new Button();
            submenu1 = new Button();
            editbtn = new Button();
            adcbtn = new Button();
            removebtn = new Button();
            menuTransition = new System.Windows.Forms.Timer(components);
            sidebarTransition = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnHam).BeginInit();
            sidebar.SuspendLayout();
            menuContainer.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(nightControlBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnHam);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1177, 35);
            panel1.TabIndex = 0;
            // 
            // nightControlBox1
            // 
            nightControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nightControlBox1.BackColor = Color.Transparent;
            nightControlBox1.CloseHoverColor = Color.FromArgb(199, 80, 80);
            nightControlBox1.CloseHoverForeColor = Color.White;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.DisableMinimizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.EnableCloseColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMaximizeButton = true;
            nightControlBox1.EnableMaximizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.Location = new Point(1038, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 3;
            nightControlBox1.Click += nightControlBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(80, 5);
            label1.Name = "label1";
            label1.Size = new Size(265, 25);
            label1.TabIndex = 2;
            label1.Text = "ADMIN PANEL | BEM VINDO";
            // 
            // btnHam
            // 
            btnHam.Image = (Image)resources.GetObject("btnHam.Image");
            btnHam.Location = new Point(0, 0);
            btnHam.Name = "btnHam";
            btnHam.Size = new Size(74, 37);
            btnHam.SizeMode = PictureBoxSizeMode.Zoom;
            btnHam.TabIndex = 1;
            btnHam.TabStop = false;
            btnHam.Click += btnHam_Click;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(23, 24, 30);
            sidebar.Controls.Add(menuContainer);
            sidebar.Controls.Add(editbtn);
            sidebar.Controls.Add(adcbtn);
            sidebar.Controls.Add(removebtn);
            sidebar.Dock = DockStyle.Left;
            sidebar.FlowDirection = FlowDirection.TopDown;
            sidebar.Location = new Point(0, 35);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(226, 555);
            sidebar.TabIndex = 1;
            sidebar.Paint += flowLayoutPanel1_Paint;
            // 
            // menuContainer
            // 
            menuContainer.BackColor = Color.FromArgb(23, 24, 30);
            menuContainer.Controls.Add(menu);
            menuContainer.Controls.Add(submenu2);
            menuContainer.Controls.Add(submenu1);
            menuContainer.Location = new Point(3, 0);
            menuContainer.Margin = new Padding(3, 0, 3, 3);
            menuContainer.Name = "menuContainer";
            menuContainer.Size = new Size(239, 46);
            menuContainer.TabIndex = 3;
            menuContainer.Paint += menuContainer_Paint;
            // 
            // menu
            // 
            menu.BackColor = Color.FromArgb(23, 24, 30);
            menu.BackgroundImageLayout = ImageLayout.None;
            menu.FlatStyle = FlatStyle.Popup;
            menu.ForeColor = Color.White;
            menu.Image = (Image)resources.GetObject("menu.Image");
            menu.ImageAlign = ContentAlignment.MiddleLeft;
            menu.Location = new Point(0, -3);
            menu.Name = "menu";
            menu.Padding = new Padding(28, 0, 0, 0);
            menu.Size = new Size(205, 48);
            menu.TabIndex = 4;
            menu.Text = "                  Menu";
            menu.TextAlign = ContentAlignment.MiddleLeft;
            menu.UseVisualStyleBackColor = false;
            menu.Click += menu_Click_1;
            // 
            // submenu2
            // 
            submenu2.BackColor = Color.FromArgb(23, 24, 30);
            submenu2.BackgroundImageLayout = ImageLayout.Zoom;
            submenu2.FlatStyle = FlatStyle.Popup;
            submenu2.ForeColor = Color.White;
            submenu2.Image = (Image)resources.GetObject("submenu2.Image");
            submenu2.ImageAlign = ContentAlignment.MiddleLeft;
            submenu2.Location = new Point(0, 91);
            submenu2.Name = "submenu2";
            submenu2.Padding = new Padding(28, 0, 0, 0);
            submenu2.Size = new Size(204, 48);
            submenu2.TabIndex = 5;
            submenu2.Text = "             Política de Privacidade";
            submenu2.TextAlign = ContentAlignment.MiddleLeft;
            submenu2.UseVisualStyleBackColor = false;
            submenu2.Click += submenu2_Click;
            // 
            // submenu1
            // 
            submenu1.BackColor = Color.FromArgb(23, 24, 30);
            submenu1.BackgroundImageLayout = ImageLayout.Zoom;
            submenu1.FlatStyle = FlatStyle.Popup;
            submenu1.ForeColor = Color.White;
            submenu1.Image = (Image)resources.GetObject("submenu1.Image");
            submenu1.ImageAlign = ContentAlignment.MiddleLeft;
            submenu1.Location = new Point(0, 44);
            submenu1.Name = "submenu1";
            submenu1.Padding = new Padding(28, 0, 0, 0);
            submenu1.Size = new Size(204, 37);
            submenu1.TabIndex = 2;
            submenu1.Text = "                 Sobre";
            submenu1.TextAlign = ContentAlignment.MiddleLeft;
            submenu1.UseVisualStyleBackColor = false;
            submenu1.Click += submenu1_Click;
            // 
            // editbtn
            // 
            editbtn.BackColor = Color.FromArgb(23, 24, 30);
            editbtn.BackgroundImageLayout = ImageLayout.Zoom;
            editbtn.FlatStyle = FlatStyle.Popup;
            editbtn.ForeColor = Color.White;
            editbtn.Image = (Image)resources.GetObject("editbtn.Image");
            editbtn.ImageAlign = ContentAlignment.MiddleLeft;
            editbtn.Location = new Point(3, 52);
            editbtn.Name = "editbtn";
            editbtn.Padding = new Padding(28, 0, 0, 0);
            editbtn.Size = new Size(205, 45);
            editbtn.TabIndex = 8;
            editbtn.Text = "                  Editar";
            editbtn.TextAlign = ContentAlignment.MiddleLeft;
            editbtn.UseVisualStyleBackColor = false;
            editbtn.Click += editar_Click;
            // 
            // adcbtn
            // 
            adcbtn.BackColor = Color.FromArgb(23, 24, 30);
            adcbtn.BackgroundImageLayout = ImageLayout.Zoom;
            adcbtn.FlatStyle = FlatStyle.Popup;
            adcbtn.ForeColor = Color.White;
            adcbtn.Image = (Image)resources.GetObject("adcbtn.Image");
            adcbtn.ImageAlign = ContentAlignment.MiddleLeft;
            adcbtn.Location = new Point(3, 103);
            adcbtn.Name = "adcbtn";
            adcbtn.Padding = new Padding(28, 0, 0, 0);
            adcbtn.Size = new Size(205, 45);
            adcbtn.TabIndex = 7;
            adcbtn.Text = "                Adicionar";
            adcbtn.TextAlign = ContentAlignment.MiddleLeft;
            adcbtn.UseVisualStyleBackColor = false;
            adcbtn.Click += adcbtn_Click;
            // 
            // removebtn
            // 
            removebtn.BackColor = Color.FromArgb(23, 24, 30);
            removebtn.BackgroundImageLayout = ImageLayout.Zoom;
            removebtn.FlatStyle = FlatStyle.Popup;
            removebtn.ForeColor = Color.White;
            removebtn.Image = (Image)resources.GetObject("removebtn.Image");
            removebtn.ImageAlign = ContentAlignment.MiddleLeft;
            removebtn.Location = new Point(3, 154);
            removebtn.Name = "removebtn";
            removebtn.Padding = new Padding(28, 0, 0, 0);
            removebtn.Size = new Size(205, 45);
            removebtn.TabIndex = 6;
            removebtn.Text = "                Remover";
            removebtn.TextAlign = ContentAlignment.MiddleLeft;
            removebtn.UseVisualStyleBackColor = false;
            removebtn.Click += removebtn_Click;
            // 
            // menuTransition
            // 
            menuTransition.Interval = 10;
            menuTransition.Tick += menuTransition_Tick;
            // 
            // sidebarTransition
            // 
            sidebarTransition.Interval = 10;
            sidebarTransition.Tick += sidebarTransition_Tick;
            // 
            // AdminPanel
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1177, 590);
            Controls.Add(sidebar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Name = "AdminPanel";
            Text = "\\";
            Load += AdminPanel_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnHam).EndInit();
            sidebar.ResumeLayout(false);
            menuContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox btnHam;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private Label label1;
        private FlowLayoutPanel sidebar;
        private Button submenu1;
        private Panel menuContainer;
        private Button menu;
        private Button submenu2;
        private System.Windows.Forms.Timer menuTransition;
        private Button removebtn;
        private Button adcbtn;
        private Button editbtn;
        private System.Windows.Forms.Timer sidebarTransition;
    }
}