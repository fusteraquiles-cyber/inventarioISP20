namespace Desktop.Views
{
    partial class MenuPrincipalView
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
            Botoncitochiquititito = new FontAwesome.Sharp.IconButton();
            menuStrip1 = new MenuStrip();
            iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            SubmenuArticulos = new FontAwesome.Sharp.IconMenuItem();
            SubmenuCategorias = new FontAwesome.Sharp.IconMenuItem();
            SubMenuSalirdelsistema = new FontAwesome.Sharp.IconMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // Botoncitochiquititito
            // 
            Botoncitochiquititito.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Botoncitochiquititito.BackColor = SystemColors.ActiveCaption;
            Botoncitochiquititito.Cursor = Cursors.No;
            Botoncitochiquititito.Flip = FontAwesome.Sharp.FlipOrientation.Vertical;
            Botoncitochiquititito.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline | FontStyle.Strikeout, GraphicsUnit.Point, 161);
            Botoncitochiquititito.ForeColor = SystemColors.Highlight;
            Botoncitochiquititito.IconChar = FontAwesome.Sharp.IconChar.NfcDirectional;
            Botoncitochiquititito.IconColor = Color.Black;
            Botoncitochiquititito.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Botoncitochiquititito.ImageAlign = ContentAlignment.TopCenter;
            Botoncitochiquititito.Location = new Point(147, 156);
            Botoncitochiquititito.Name = "Botoncitochiquititito";
            Botoncitochiquititito.Size = new Size(232, 137);
            Botoncitochiquititito.TabIndex = 0;
            Botoncitochiquititito.Text = "hola";
            Botoncitochiquititito.TextImageRelation = TextImageRelation.ImageAboveText;
            Botoncitochiquititito.UseVisualStyleBackColor = false;
            Botoncitochiquititito.Click += Botoncitochiquititito_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { iconMenuItem1, SubMenuSalirdelsistema });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // iconMenuItem1
            // 
            iconMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { SubmenuArticulos, SubmenuCategorias });
            iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.Bicycle;
            iconMenuItem1.IconColor = Color.Black;
            iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem1.Name = "iconMenuItem1";
            iconMenuItem1.Size = new Size(100, 24);
            iconMenuItem1.Text = "Principal";
            // 
            // SubmenuArticulos
            // 
            SubmenuArticulos.IconChar = FontAwesome.Sharp.IconChar.Tools;
            SubmenuArticulos.IconColor = Color.Black;
            SubmenuArticulos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SubmenuArticulos.Name = "SubmenuArticulos";
            SubmenuArticulos.Size = new Size(224, 26);
            SubmenuArticulos.Text = "Articulos";
            SubmenuArticulos.Click += SubmenuArticulos_Click;
            // 
            // SubmenuCategorias
            // 
            SubmenuCategorias.IconChar = FontAwesome.Sharp.IconChar.NetworkWired;
            SubmenuCategorias.IconColor = Color.Black;
            SubmenuCategorias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SubmenuCategorias.Name = "SubmenuCategorias";
            SubmenuCategorias.Size = new Size(224, 26);
            SubmenuCategorias.Text = "Categorias";
            SubmenuCategorias.Click += SubmenuCategorias_Click;
            // 
            // SubMenuSalirdelsistema
            // 
            SubMenuSalirdelsistema.IconChar = FontAwesome.Sharp.IconChar.DoorClosed;
            SubMenuSalirdelsistema.IconColor = Color.Black;
            SubMenuSalirdelsistema.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SubMenuSalirdelsistema.Name = "SubMenuSalirdelsistema";
            SubMenuSalirdelsistema.Size = new Size(72, 24);
            SubMenuSalirdelsistema.Text = "Salir";
            // 
            // MenuPrincipalView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Botoncitochiquititito);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "MenuPrincipalView";
            Text = "Sistema de inventario ISP20 - 2do año TSDS";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton Botoncitochiquititito;
        private MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private FontAwesome.Sharp.IconMenuItem SubmenuArticulos;
        private FontAwesome.Sharp.IconMenuItem SubmenuCategorias;
        private FontAwesome.Sharp.IconMenuItem SubMenuSalirdelsistema;
    }
}
