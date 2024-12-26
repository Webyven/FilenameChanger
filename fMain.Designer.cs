namespace FilenameChanger
{
	partial class fMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
			this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
			this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
			this.label1 = new System.Windows.Forms.Label();
			this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
			this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
			this.txtDirectory = new Guna.UI2.WinForms.Guna2TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnSelectDirectory = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
			this.lblIncludeSubfolders = new System.Windows.Forms.Label();
			this.cbIncludeSubfolders = new Guna.UI2.WinForms.Guna2CustomCheckBox();
			this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.txtNewCharacters = new Guna.UI2.WinForms.Guna2TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtCharToReplace = new Guna.UI2.WinForms.Guna2TextBox();
			this.btnReplace = new Guna.UI2.WinForms.Guna2Button();
			this.lblTrimEnd = new System.Windows.Forms.Label();
			this.cbTrimEnd = new Guna.UI2.WinForms.Guna2CustomCheckBox();
			this.lblTrimStart = new System.Windows.Forms.Label();
			this.cbTrimStart = new Guna.UI2.WinForms.Guna2CustomCheckBox();
			this.label5 = new System.Windows.Forms.Label();
			this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
			this.pctTitle = new Guna.UI2.WinForms.Guna2PictureBox();
			this.guna2DragControl3 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
			this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
			this.guna2Panel1.SuspendLayout();
			this.guna2Panel2.SuspendLayout();
			this.guna2Panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pctTitle)).BeginInit();
			this.SuspendLayout();
			// 
			// guna2Panel1
			// 
			this.guna2Panel1.BackColor = System.Drawing.Color.Black;
			this.guna2Panel1.Controls.Add(this.guna2ControlBox2);
			this.guna2Panel1.Controls.Add(this.pctTitle);
			this.guna2Panel1.Controls.Add(this.guna2ControlBox1);
			this.guna2Panel1.Controls.Add(this.label1);
			this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
			this.guna2Panel1.Name = "guna2Panel1";
			this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
			this.guna2Panel1.Size = new System.Drawing.Size(350, 30);
			this.guna2Panel1.TabIndex = 0;
			// 
			// guna2ControlBox1
			// 
			this.guna2ControlBox1.Animated = true;
			this.guna2ControlBox1.Dock = System.Windows.Forms.DockStyle.Right;
			this.guna2ControlBox1.FillColor = System.Drawing.Color.Black;
			this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.Maroon;
			this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
			this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
			this.guna2ControlBox1.Location = new System.Drawing.Point(305, 0);
			this.guna2ControlBox1.Name = "guna2ControlBox1";
			this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
			this.guna2ControlBox1.Size = new System.Drawing.Size(45, 30);
			this.guna2ControlBox1.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(35, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(103, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Filename Changer";
			// 
			// guna2DragControl1
			// 
			this.guna2DragControl1.TargetControl = this.guna2Panel1;
			// 
			// guna2DragControl2
			// 
			this.guna2DragControl2.TargetControl = this.label1;
			// 
			// txtDirectory
			// 
			this.txtDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtDirectory.Animated = true;
			this.txtDirectory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.txtDirectory.BorderRadius = 3;
			this.txtDirectory.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtDirectory.DefaultText = "";
			this.txtDirectory.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtDirectory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtDirectory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtDirectory.DisabledState.Parent = this.txtDirectory;
			this.txtDirectory.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtDirectory.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
			this.txtDirectory.FocusedState.BorderColor = System.Drawing.Color.Teal;
			this.txtDirectory.FocusedState.Parent = this.txtDirectory;
			this.txtDirectory.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtDirectory.HoverState.Parent = this.txtDirectory;
			this.txtDirectory.Location = new System.Drawing.Point(34, 39);
			this.txtDirectory.Name = "txtDirectory";
			this.txtDirectory.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
			this.txtDirectory.PasswordChar = '\0';
			this.txtDirectory.PlaceholderText = "";
			this.txtDirectory.ReadOnly = true;
			this.txtDirectory.SelectedText = "";
			this.txtDirectory.ShadowDecoration.Parent = this.txtDirectory;
			this.txtDirectory.Size = new System.Drawing.Size(265, 25);
			this.txtDirectory.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(31, 17);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 15);
			this.label2.TabIndex = 2;
			this.label2.Text = "Directory";
			// 
			// btnSelectDirectory
			// 
			this.btnSelectDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSelectDirectory.Animated = true;
			this.btnSelectDirectory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.btnSelectDirectory.BorderRadius = 3;
			this.btnSelectDirectory.BorderThickness = 1;
			this.btnSelectDirectory.CheckedState.Parent = this.btnSelectDirectory;
			this.btnSelectDirectory.CustomImages.Parent = this.btnSelectDirectory;
			this.btnSelectDirectory.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
			this.btnSelectDirectory.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnSelectDirectory.ForeColor = System.Drawing.Color.White;
			this.btnSelectDirectory.HoverState.Parent = this.btnSelectDirectory;
			this.btnSelectDirectory.Location = new System.Drawing.Point(308, 39);
			this.btnSelectDirectory.Name = "btnSelectDirectory";
			this.btnSelectDirectory.ShadowDecoration.Parent = this.btnSelectDirectory;
			this.btnSelectDirectory.Size = new System.Drawing.Size(28, 25);
			this.btnSelectDirectory.TabIndex = 3;
			this.btnSelectDirectory.Text = "...";
			this.btnSelectDirectory.Click += new System.EventHandler(this.btnSelectDirectory_Click);
			// 
			// guna2Panel2
			// 
			this.guna2Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.guna2Panel2.BorderThickness = 1;
			this.guna2Panel2.Controls.Add(this.lblIncludeSubfolders);
			this.guna2Panel2.Controls.Add(this.cbIncludeSubfolders);
			this.guna2Panel2.Controls.Add(this.btnSelectDirectory);
			this.guna2Panel2.Controls.Add(this.label2);
			this.guna2Panel2.Controls.Add(this.txtDirectory);
			this.guna2Panel2.Location = new System.Drawing.Point(-12, 46);
			this.guna2Panel2.Name = "guna2Panel2";
			this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
			this.guna2Panel2.Size = new System.Drawing.Size(372, 84);
			this.guna2Panel2.TabIndex = 4;
			// 
			// lblIncludeSubfolders
			// 
			this.lblIncludeSubfolders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblIncludeSubfolders.AutoSize = true;
			this.lblIncludeSubfolders.ForeColor = System.Drawing.Color.White;
			this.lblIncludeSubfolders.Location = new System.Drawing.Point(245, 17);
			this.lblIncludeSubfolders.Name = "lblIncludeSubfolders";
			this.lblIncludeSubfolders.Size = new System.Drawing.Size(93, 13);
			this.lblIncludeSubfolders.TabIndex = 5;
			this.lblIncludeSubfolders.Text = "Include subfolders";
			this.lblIncludeSubfolders.Click += new System.EventHandler(this.lblIncludeSubfolders_Click);
			// 
			// cbIncludeSubfolders
			// 
			this.cbIncludeSubfolders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cbIncludeSubfolders.Animated = true;
			this.cbIncludeSubfolders.Checked = true;
			this.cbIncludeSubfolders.CheckedState.BorderColor = System.Drawing.Color.Teal;
			this.cbIncludeSubfolders.CheckedState.BorderRadius = 3;
			this.cbIncludeSubfolders.CheckedState.BorderThickness = 0;
			this.cbIncludeSubfolders.CheckedState.FillColor = System.Drawing.Color.Teal;
			this.cbIncludeSubfolders.CheckedState.Parent = this.cbIncludeSubfolders;
			this.cbIncludeSubfolders.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbIncludeSubfolders.Location = new System.Drawing.Point(225, 16);
			this.cbIncludeSubfolders.Name = "cbIncludeSubfolders";
			this.cbIncludeSubfolders.ShadowDecoration.Parent = this.cbIncludeSubfolders;
			this.cbIncludeSubfolders.Size = new System.Drawing.Size(15, 15);
			this.cbIncludeSubfolders.TabIndex = 4;
			this.cbIncludeSubfolders.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.cbIncludeSubfolders.UncheckedState.BorderRadius = 3;
			this.cbIncludeSubfolders.UncheckedState.BorderThickness = 1;
			this.cbIncludeSubfolders.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
			this.cbIncludeSubfolders.UncheckedState.Parent = this.cbIncludeSubfolders;
			// 
			// guna2Panel3
			// 
			this.guna2Panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.guna2Panel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.guna2Panel3.BorderThickness = 1;
			this.guna2Panel3.Controls.Add(this.label5);
			this.guna2Panel3.Controls.Add(this.cbTrimEnd);
			this.guna2Panel3.Controls.Add(this.label4);
			this.guna2Panel3.Controls.Add(this.lblTrimStart);
			this.guna2Panel3.Controls.Add(this.lblTrimEnd);
			this.guna2Panel3.Controls.Add(this.txtNewCharacters);
			this.guna2Panel3.Controls.Add(this.cbTrimStart);
			this.guna2Panel3.Controls.Add(this.label3);
			this.guna2Panel3.Controls.Add(this.txtCharToReplace);
			this.guna2Panel3.Location = new System.Drawing.Point(-12, 146);
			this.guna2Panel3.Name = "guna2Panel3";
			this.guna2Panel3.ShadowDecoration.Parent = this.guna2Panel3;
			this.guna2Panel3.Size = new System.Drawing.Size(380, 189);
			this.guna2Panel3.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(31, 82);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(118, 15);
			this.label4.TabIndex = 4;
			this.label4.Text = "With the characters...";
			// 
			// txtNewCharacters
			// 
			this.txtNewCharacters.Animated = true;
			this.txtNewCharacters.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.txtNewCharacters.BorderRadius = 3;
			this.txtNewCharacters.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtNewCharacters.DefaultText = "";
			this.txtNewCharacters.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtNewCharacters.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtNewCharacters.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtNewCharacters.DisabledState.Parent = this.txtNewCharacters;
			this.txtNewCharacters.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtNewCharacters.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
			this.txtNewCharacters.FocusedState.BorderColor = System.Drawing.Color.Teal;
			this.txtNewCharacters.FocusedState.Parent = this.txtNewCharacters;
			this.txtNewCharacters.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtNewCharacters.HoverState.Parent = this.txtNewCharacters;
			this.txtNewCharacters.Location = new System.Drawing.Point(34, 105);
			this.txtNewCharacters.Name = "txtNewCharacters";
			this.txtNewCharacters.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
			this.txtNewCharacters.PasswordChar = '\0';
			this.txtNewCharacters.PlaceholderText = "";
			this.txtNewCharacters.SelectedText = "";
			this.txtNewCharacters.ShadowDecoration.Parent = this.txtNewCharacters;
			this.txtNewCharacters.Size = new System.Drawing.Size(302, 25);
			this.txtNewCharacters.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(31, 19);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(134, 15);
			this.label3.TabIndex = 2;
			this.label3.Text = "Replace the characters...";
			// 
			// txtCharToReplace
			// 
			this.txtCharToReplace.Animated = true;
			this.txtCharToReplace.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.txtCharToReplace.BorderRadius = 3;
			this.txtCharToReplace.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtCharToReplace.DefaultText = "";
			this.txtCharToReplace.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtCharToReplace.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtCharToReplace.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtCharToReplace.DisabledState.Parent = this.txtCharToReplace;
			this.txtCharToReplace.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtCharToReplace.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
			this.txtCharToReplace.FocusedState.BorderColor = System.Drawing.Color.Teal;
			this.txtCharToReplace.FocusedState.Parent = this.txtCharToReplace;
			this.txtCharToReplace.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtCharToReplace.HoverState.Parent = this.txtCharToReplace;
			this.txtCharToReplace.Location = new System.Drawing.Point(34, 42);
			this.txtCharToReplace.Name = "txtCharToReplace";
			this.txtCharToReplace.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
			this.txtCharToReplace.PasswordChar = '\0';
			this.txtCharToReplace.PlaceholderText = "";
			this.txtCharToReplace.SelectedText = "";
			this.txtCharToReplace.ShadowDecoration.Parent = this.txtCharToReplace;
			this.txtCharToReplace.Size = new System.Drawing.Size(302, 25);
			this.txtCharToReplace.TabIndex = 1;
			this.txtCharToReplace.TextChanged += new System.EventHandler(this.txtCharToReplace_TextChanged);
			// 
			// btnReplace
			// 
			this.btnReplace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnReplace.Animated = true;
			this.btnReplace.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
			this.btnReplace.BorderRadius = 3;
			this.btnReplace.BorderThickness = 1;
			this.btnReplace.CheckedState.Parent = this.btnReplace;
			this.btnReplace.CustomImages.Parent = this.btnReplace;
			this.btnReplace.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.btnReplace.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnReplace.ForeColor = System.Drawing.Color.White;
			this.btnReplace.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.btnReplace.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
			this.btnReplace.HoverState.Parent = this.btnReplace;
			this.btnReplace.Location = new System.Drawing.Point(-12, 351);
			this.btnReplace.Name = "btnReplace";
			this.btnReplace.ShadowDecoration.Parent = this.btnReplace;
			this.btnReplace.Size = new System.Drawing.Size(372, 35);
			this.btnReplace.TabIndex = 3;
			this.btnReplace.Text = "Replace";
			this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
			// 
			// lblTrimEnd
			// 
			this.lblTrimEnd.AutoSize = true;
			this.lblTrimEnd.ForeColor = System.Drawing.Color.White;
			this.lblTrimEnd.Location = new System.Drawing.Point(287, 153);
			this.lblTrimEnd.Name = "lblTrimEnd";
			this.lblTrimEnd.Size = new System.Drawing.Size(48, 13);
			this.lblTrimEnd.TabIndex = 8;
			this.lblTrimEnd.Text = "Trim end";
			this.lblTrimEnd.Click += new System.EventHandler(this.lblTrimEnd_Click);
			// 
			// cbTrimEnd
			// 
			this.cbTrimEnd.Animated = true;
			this.cbTrimEnd.Checked = true;
			this.cbTrimEnd.CheckedState.BorderColor = System.Drawing.Color.Teal;
			this.cbTrimEnd.CheckedState.BorderRadius = 3;
			this.cbTrimEnd.CheckedState.BorderThickness = 0;
			this.cbTrimEnd.CheckedState.FillColor = System.Drawing.Color.Teal;
			this.cbTrimEnd.CheckedState.Parent = this.cbTrimEnd;
			this.cbTrimEnd.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbTrimEnd.Location = new System.Drawing.Point(268, 152);
			this.cbTrimEnd.Name = "cbTrimEnd";
			this.cbTrimEnd.ShadowDecoration.Parent = this.cbTrimEnd;
			this.cbTrimEnd.Size = new System.Drawing.Size(15, 15);
			this.cbTrimEnd.TabIndex = 7;
			this.cbTrimEnd.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.cbTrimEnd.UncheckedState.BorderRadius = 3;
			this.cbTrimEnd.UncheckedState.BorderThickness = 1;
			this.cbTrimEnd.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
			this.cbTrimEnd.UncheckedState.Parent = this.cbTrimEnd;
			// 
			// lblTrimStart
			// 
			this.lblTrimStart.AutoSize = true;
			this.lblTrimStart.ForeColor = System.Drawing.Color.White;
			this.lblTrimStart.Location = new System.Drawing.Point(184, 153);
			this.lblTrimStart.Name = "lblTrimStart";
			this.lblTrimStart.Size = new System.Drawing.Size(50, 13);
			this.lblTrimStart.TabIndex = 10;
			this.lblTrimStart.Text = "Trim start";
			this.lblTrimStart.Click += new System.EventHandler(this.lblTrimStart_Click);
			// 
			// cbTrimStart
			// 
			this.cbTrimStart.Animated = true;
			this.cbTrimStart.Checked = true;
			this.cbTrimStart.CheckedState.BorderColor = System.Drawing.Color.Teal;
			this.cbTrimStart.CheckedState.BorderRadius = 3;
			this.cbTrimStart.CheckedState.BorderThickness = 0;
			this.cbTrimStart.CheckedState.FillColor = System.Drawing.Color.Teal;
			this.cbTrimStart.CheckedState.Parent = this.cbTrimStart;
			this.cbTrimStart.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbTrimStart.Location = new System.Drawing.Point(165, 152);
			this.cbTrimStart.Name = "cbTrimStart";
			this.cbTrimStart.ShadowDecoration.Parent = this.cbTrimStart;
			this.cbTrimStart.Size = new System.Drawing.Size(15, 15);
			this.cbTrimStart.TabIndex = 9;
			this.cbTrimStart.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.cbTrimStart.UncheckedState.BorderRadius = 3;
			this.cbTrimStart.UncheckedState.BorderThickness = 1;
			this.cbTrimStart.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
			this.cbTrimStart.UncheckedState.Parent = this.cbTrimStart;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(31, 151);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(98, 15);
			this.label5.TabIndex = 11;
			this.label5.Text = "Filename options";
			// 
			// guna2Elipse1
			// 
			this.guna2Elipse1.TargetControl = this;
			// 
			// pctTitle
			// 
			this.pctTitle.Dock = System.Windows.Forms.DockStyle.Left;
			this.pctTitle.Image = ((System.Drawing.Image)(resources.GetObject("pctTitle.Image")));
			this.pctTitle.Location = new System.Drawing.Point(0, 0);
			this.pctTitle.Name = "pctTitle";
			this.pctTitle.ShadowDecoration.Parent = this.pctTitle;
			this.pctTitle.Size = new System.Drawing.Size(35, 30);
			this.pctTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pctTitle.TabIndex = 2;
			this.pctTitle.TabStop = false;
			// 
			// guna2DragControl3
			// 
			this.guna2DragControl3.TargetControl = this.pctTitle;
			// 
			// guna2ControlBox2
			// 
			this.guna2ControlBox2.Animated = true;
			this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
			this.guna2ControlBox2.Dock = System.Windows.Forms.DockStyle.Right;
			this.guna2ControlBox2.FillColor = System.Drawing.Color.Black;
			this.guna2ControlBox2.HoverState.FillColor = System.Drawing.Color.Maroon;
			this.guna2ControlBox2.HoverState.Parent = this.guna2ControlBox2;
			this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
			this.guna2ControlBox2.Location = new System.Drawing.Point(260, 0);
			this.guna2ControlBox2.Name = "guna2ControlBox2";
			this.guna2ControlBox2.ShadowDecoration.Parent = this.guna2ControlBox2;
			this.guna2ControlBox2.Size = new System.Drawing.Size(45, 30);
			this.guna2ControlBox2.TabIndex = 3;
			// 
			// fMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
			this.ClientSize = new System.Drawing.Size(350, 400);
			this.Controls.Add(this.guna2Panel3);
			this.Controls.Add(this.btnReplace);
			this.Controls.Add(this.guna2Panel1);
			this.Controls.Add(this.guna2Panel2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "fMain";
			this.Text = "Filename Changer";
			this.Activated += new System.EventHandler(this.fMain_Validated);
			this.Load += new System.EventHandler(this.fMain_Validated);
			this.Validated += new System.EventHandler(this.fMain_Validated);
			this.guna2Panel1.ResumeLayout(false);
			this.guna2Panel1.PerformLayout();
			this.guna2Panel2.ResumeLayout(false);
			this.guna2Panel2.PerformLayout();
			this.guna2Panel3.ResumeLayout(false);
			this.guna2Panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pctTitle)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
		private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
		private System.Windows.Forms.Label label1;
		private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
		private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
		private Guna.UI2.WinForms.Guna2TextBox txtDirectory;
		private System.Windows.Forms.Label label2;
		private Guna.UI2.WinForms.Guna2Button btnSelectDirectory;
		private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
		private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
		private System.Windows.Forms.Label label3;
		private Guna.UI2.WinForms.Guna2TextBox txtCharToReplace;
		private System.Windows.Forms.Label label4;
		private Guna.UI2.WinForms.Guna2TextBox txtNewCharacters;
		private Guna.UI2.WinForms.Guna2Button btnReplace;
		private System.Windows.Forms.Label lblIncludeSubfolders;
		private Guna.UI2.WinForms.Guna2CustomCheckBox cbIncludeSubfolders;
		private System.Windows.Forms.Label lblTrimEnd;
		private Guna.UI2.WinForms.Guna2CustomCheckBox cbTrimEnd;
		private System.Windows.Forms.Label lblTrimStart;
		private Guna.UI2.WinForms.Guna2CustomCheckBox cbTrimStart;
		private System.Windows.Forms.Label label5;
		private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
		private Guna.UI2.WinForms.Guna2PictureBox pctTitle;
		private Guna.UI2.WinForms.Guna2DragControl guna2DragControl3;
		private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
	}
}

