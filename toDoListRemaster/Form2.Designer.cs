
namespace toDoListRemaster
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.bSubmit = new System.Windows.Forms.Button();
            this.tbNoteName = new System.Windows.Forms.TextBox();
            this.rtbNote = new System.Windows.Forms.RichTextBox();
            this.lNoteName = new System.Windows.Forms.Label();
            this.lNote = new System.Windows.Forms.Label();
            this.ttTextBoxes = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // bSubmit
            // 
            this.bSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bSubmit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bSubmit.FlatAppearance.BorderSize = 0;
            this.bSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bSubmit.ForeColor = System.Drawing.Color.White;
            this.bSubmit.Location = new System.Drawing.Point(0, 354);
            this.bSubmit.Name = "bSubmit";
            this.bSubmit.Size = new System.Drawing.Size(800, 96);
            this.bSubmit.TabIndex = 0;
            this.bSubmit.Text = "Přidat";
            this.bSubmit.UseVisualStyleBackColor = false;
            this.bSubmit.Click += new System.EventHandler(this.bSubmit_Click);
            // 
            // tbNoteName
            // 
            this.tbNoteName.BackColor = System.Drawing.Color.White;
            this.tbNoteName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNoteName.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbNoteName.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbNoteName.ForeColor = System.Drawing.Color.Black;
            this.tbNoteName.Location = new System.Drawing.Point(12, 54);
            this.tbNoteName.Name = "tbNoteName";
            this.tbNoteName.Size = new System.Drawing.Size(776, 33);
            this.tbNoteName.TabIndex = 1;
            // 
            // rtbNote
            // 
            this.rtbNote.BackColor = System.Drawing.Color.White;
            this.rtbNote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbNote.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtbNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rtbNote.ForeColor = System.Drawing.Color.Black;
            this.rtbNote.Location = new System.Drawing.Point(12, 158);
            this.rtbNote.Name = "rtbNote";
            this.rtbNote.Size = new System.Drawing.Size(776, 180);
            this.rtbNote.TabIndex = 2;
            this.rtbNote.Text = "";
            // 
            // lNoteName
            // 
            this.lNoteName.AutoSize = true;
            this.lNoteName.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lNoteName.ForeColor = System.Drawing.Color.White;
            this.lNoteName.Location = new System.Drawing.Point(5, 9);
            this.lNoteName.Name = "lNoteName";
            this.lNoteName.Size = new System.Drawing.Size(125, 42);
            this.lNoteName.TabIndex = 3;
            this.lNoteName.Text = "Název";
            // 
            // lNote
            // 
            this.lNote.AutoSize = true;
            this.lNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lNote.ForeColor = System.Drawing.Color.White;
            this.lNote.Location = new System.Drawing.Point(5, 113);
            this.lNote.Name = "lNote";
            this.lNote.Size = new System.Drawing.Size(195, 42);
            this.lNote.TabIndex = 3;
            this.lNote.Text = "Poznámka";
            // 
            // ttTextBoxes
            // 
            this.ttTextBoxes.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttTextBoxes.ToolTipTitle = "Poznámky";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lNote);
            this.Controls.Add(this.lNoteName);
            this.Controls.Add(this.rtbNote);
            this.Controls.Add(this.tbNoteName);
            this.Controls.Add(this.bSubmit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nová poznámka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bSubmit;
        private System.Windows.Forms.TextBox tbNoteName;
        private System.Windows.Forms.RichTextBox rtbNote;
        private System.Windows.Forms.Label lNoteName;
        private System.Windows.Forms.Label lNote;
        private System.Windows.Forms.ToolTip ttTextBoxes;
    }
}