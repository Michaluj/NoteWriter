
namespace toDoListRemaster
{
    partial class toDoList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(toDoList));
            this.pMenu = new System.Windows.Forms.Panel();
            this.bNotesTextColor = new System.Windows.Forms.Button();
            this.bNotesColor = new System.Windows.Forms.Button();
            this.bScale = new System.Windows.Forms.Button();
            this.bSettings = new System.Windows.Forms.Button();
            this.bExport = new System.Windows.Forms.Button();
            this.bNewNote = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.bLoad = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.lbNotes = new System.Windows.Forms.ListBox();
            this.lTime = new System.Windows.Forms.Label();
            this.tClock = new System.Windows.Forms.Timer(this.components);
            this.cm = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.barvaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barvaPlátnaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pMenu.SuspendLayout();
            this.cm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pMenu
            // 
            this.pMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pMenu.Controls.Add(this.bNotesTextColor);
            this.pMenu.Controls.Add(this.bNotesColor);
            this.pMenu.Controls.Add(this.bScale);
            this.pMenu.Controls.Add(this.bSettings);
            this.pMenu.Controls.Add(this.bExport);
            this.pMenu.Controls.Add(this.bNewNote);
            this.pMenu.Controls.Add(this.bDelete);
            this.pMenu.Controls.Add(this.bLoad);
            this.pMenu.Controls.Add(this.bSave);
            this.pMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pMenu.ForeColor = System.Drawing.Color.White;
            this.pMenu.Location = new System.Drawing.Point(0, 0);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(200, 720);
            this.pMenu.TabIndex = 0;
            // 
            // bNotesTextColor
            // 
            this.bNotesTextColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bNotesTextColor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bNotesTextColor.FlatAppearance.BorderSize = 0;
            this.bNotesTextColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNotesTextColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bNotesTextColor.ForeColor = System.Drawing.Color.White;
            this.bNotesTextColor.Location = new System.Drawing.Point(0, 499);
            this.bNotesTextColor.Name = "bNotesTextColor";
            this.bNotesTextColor.Size = new System.Drawing.Size(200, 47);
            this.bNotesTextColor.TabIndex = 6;
            this.bNotesTextColor.Text = "Barva pozn.";
            this.bNotesTextColor.UseVisualStyleBackColor = false;
            this.bNotesTextColor.Click += new System.EventHandler(this.bNotesTextColor_Click);
            // 
            // bNotesColor
            // 
            this.bNotesColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bNotesColor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bNotesColor.FlatAppearance.BorderSize = 0;
            this.bNotesColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNotesColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bNotesColor.ForeColor = System.Drawing.Color.White;
            this.bNotesColor.Location = new System.Drawing.Point(0, 546);
            this.bNotesColor.Name = "bNotesColor";
            this.bNotesColor.Size = new System.Drawing.Size(200, 47);
            this.bNotesColor.TabIndex = 5;
            this.bNotesColor.Text = "Barva plátna";
            this.bNotesColor.UseVisualStyleBackColor = false;
            this.bNotesColor.Click += new System.EventHandler(this.bNotesColor_Click);
            // 
            // bScale
            // 
            this.bScale.BackColor = System.Drawing.Color.Red;
            this.bScale.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bScale.FlatAppearance.BorderSize = 0;
            this.bScale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bScale.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bScale.ForeColor = System.Drawing.Color.White;
            this.bScale.Location = new System.Drawing.Point(0, 593);
            this.bScale.Name = "bScale";
            this.bScale.Size = new System.Drawing.Size(200, 47);
            this.bScale.TabIndex = 4;
            this.bScale.Text = "Škálování";
            this.bScale.UseVisualStyleBackColor = false;
            this.bScale.Click += new System.EventHandler(this.bScale_Click);
            // 
            // bSettings
            // 
            this.bSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bSettings.FlatAppearance.BorderSize = 0;
            this.bSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bSettings.ForeColor = System.Drawing.Color.White;
            this.bSettings.Location = new System.Drawing.Point(0, 640);
            this.bSettings.Name = "bSettings";
            this.bSettings.Size = new System.Drawing.Size(200, 80);
            this.bSettings.TabIndex = 3;
            this.bSettings.Text = "Nastavení";
            this.bSettings.UseVisualStyleBackColor = false;
            this.bSettings.Click += new System.EventHandler(this.bSettings_Click);
            // 
            // bExport
            // 
            this.bExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bExport.Dock = System.Windows.Forms.DockStyle.Top;
            this.bExport.FlatAppearance.BorderSize = 0;
            this.bExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bExport.ForeColor = System.Drawing.Color.White;
            this.bExport.Location = new System.Drawing.Point(0, 320);
            this.bExport.Name = "bExport";
            this.bExport.Size = new System.Drawing.Size(200, 80);
            this.bExport.TabIndex = 2;
            this.bExport.Text = "Export";
            this.bExport.UseVisualStyleBackColor = false;
            this.bExport.Click += new System.EventHandler(this.bExport_Click);
            // 
            // bNewNote
            // 
            this.bNewNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bNewNote.Dock = System.Windows.Forms.DockStyle.Top;
            this.bNewNote.FlatAppearance.BorderSize = 0;
            this.bNewNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNewNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bNewNote.ForeColor = System.Drawing.Color.White;
            this.bNewNote.Location = new System.Drawing.Point(0, 240);
            this.bNewNote.Name = "bNewNote";
            this.bNewNote.Size = new System.Drawing.Size(200, 80);
            this.bNewNote.TabIndex = 1;
            this.bNewNote.Text = "Nový";
            this.bNewNote.UseVisualStyleBackColor = false;
            this.bNewNote.Click += new System.EventHandler(this.bNewNote_Click);
            // 
            // bDelete
            // 
            this.bDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.bDelete.FlatAppearance.BorderSize = 0;
            this.bDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bDelete.ForeColor = System.Drawing.Color.White;
            this.bDelete.Location = new System.Drawing.Point(0, 160);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(200, 80);
            this.bDelete.TabIndex = 0;
            this.bDelete.Text = "Smazat";
            this.bDelete.UseVisualStyleBackColor = false;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bLoad
            // 
            this.bLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bLoad.Dock = System.Windows.Forms.DockStyle.Top;
            this.bLoad.FlatAppearance.BorderSize = 0;
            this.bLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bLoad.ForeColor = System.Drawing.Color.White;
            this.bLoad.Location = new System.Drawing.Point(0, 80);
            this.bLoad.Name = "bLoad";
            this.bLoad.Size = new System.Drawing.Size(200, 80);
            this.bLoad.TabIndex = 0;
            this.bLoad.Text = "Upravit";
            this.bLoad.UseVisualStyleBackColor = false;
            this.bLoad.Click += new System.EventHandler(this.bLoad_Click);
            // 
            // bSave
            // 
            this.bSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bSave.Dock = System.Windows.Forms.DockStyle.Top;
            this.bSave.FlatAppearance.BorderSize = 0;
            this.bSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bSave.ForeColor = System.Drawing.Color.White;
            this.bSave.Location = new System.Drawing.Point(0, 0);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(200, 80);
            this.bSave.TabIndex = 0;
            this.bSave.Text = "Uložit";
            this.bSave.UseVisualStyleBackColor = false;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // lbNotes
            // 
            this.lbNotes.BackColor = System.Drawing.Color.White;
            this.lbNotes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbNotes.ForeColor = System.Drawing.Color.Black;
            this.lbNotes.FormattingEnabled = true;
            this.lbNotes.HorizontalScrollbar = true;
            this.lbNotes.ItemHeight = 25;
            this.lbNotes.Location = new System.Drawing.Point(200, 66);
            this.lbNotes.Name = "lbNotes";
            this.lbNotes.Size = new System.Drawing.Size(903, 654);
            this.lbNotes.TabIndex = 1;
            this.lbNotes.DoubleClick += new System.EventHandler(this.lbNotes_DoubleClick);
            // 
            // lTime
            // 
            this.lTime.AutoSize = true;
            this.lTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.lTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lTime.Location = new System.Drawing.Point(200, 0);
            this.lTime.Name = "lTime";
            this.lTime.Size = new System.Drawing.Size(452, 25);
            this.lTime.TabIndex = 2;
            this.lTime.Text = "Pokud vidíš tento text, tak se rozbily hodiny. :(";
            // 
            // tClock
            // 
            this.tClock.Enabled = true;
            this.tClock.Tick += new System.EventHandler(this.toDoList_Load);
            // 
            // cm
            // 
            this.cm.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barvaToolStripMenuItem,
            this.barvaPlátnaToolStripMenuItem});
            this.cm.Name = "cm";
            this.cm.Size = new System.Drawing.Size(162, 48);
            // 
            // barvaToolStripMenuItem
            // 
            this.barvaToolStripMenuItem.Name = "barvaToolStripMenuItem";
            this.barvaToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.barvaToolStripMenuItem.Text = "Barva poznámky";
            this.barvaToolStripMenuItem.Click += new System.EventHandler(this.barvaToolStripMenuItem_Click);
            // 
            // barvaPlátnaToolStripMenuItem
            // 
            this.barvaPlátnaToolStripMenuItem.Name = "barvaPlátnaToolStripMenuItem";
            this.barvaPlátnaToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.barvaPlátnaToolStripMenuItem.Text = "Barva plátna";
            this.barvaPlátnaToolStripMenuItem.Click += new System.EventHandler(this.barvaPlátnaToolStripMenuItem_Click);
            // 
            // toDoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 720);
            this.Controls.Add(this.lTime);
            this.Controls.Add(this.lbNotes);
            this.Controls.Add(this.pMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "toDoList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NoteWriter";
            this.Load += new System.EventHandler(this.toDoList_Load);
            this.pMenu.ResumeLayout(false);
            this.cm.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pMenu;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bLoad;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bNewNote;
        private System.Windows.Forms.ListBox lbNotes;
        private System.Windows.Forms.Label lTime;
        private System.Windows.Forms.Timer tClock;
        private System.Windows.Forms.Button bExport;
        private System.Windows.Forms.Button bScale;
        private System.Windows.Forms.Button bSettings;
        private System.Windows.Forms.Button bNotesColor;
        private System.Windows.Forms.Button bNotesTextColor;
        private System.Windows.Forms.ContextMenuStrip cm;
        private System.Windows.Forms.ToolStripMenuItem barvaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barvaPlátnaToolStripMenuItem;
    }
}

