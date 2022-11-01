
namespace Task1
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.buttonRunAnimationCircle = new System.Windows.Forms.Button();
            this.buttonRunAnimationSquare = new System.Windows.Forms.Button();
            this.buttonRunAnimationRhomb = new System.Windows.Forms.Button();
            this.pictureBoxAnimationRepresentation = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnimationRepresentation)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRunAnimationCircle
            // 
            this.buttonRunAnimationCircle.Location = new System.Drawing.Point(15, 25);
            this.buttonRunAnimationCircle.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRunAnimationCircle.Name = "buttonRunAnimationCircle";
            this.buttonRunAnimationCircle.Size = new System.Drawing.Size(80, 30);
            this.buttonRunAnimationCircle.TabIndex = 1;
            this.buttonRunAnimationCircle.Text = "Circle";
            this.buttonRunAnimationCircle.UseVisualStyleBackColor = true;
            this.buttonRunAnimationCircle.Click += new System.EventHandler(this.buttonRunAnimationCircle_Click);
            // 
            // buttonRunAnimationSquare
            // 
            this.buttonRunAnimationSquare.Location = new System.Drawing.Point(15, 60);
            this.buttonRunAnimationSquare.Name = "buttonRunAnimationSquare";
            this.buttonRunAnimationSquare.Size = new System.Drawing.Size(80, 30);
            this.buttonRunAnimationSquare.TabIndex = 2;
            this.buttonRunAnimationSquare.Text = "Square";
            this.buttonRunAnimationSquare.UseVisualStyleBackColor = true;
            this.buttonRunAnimationSquare.Click += new System.EventHandler(this.buttonRunAnimationSquare_Click);
            // 
            // buttonRunAnimationRhomb
            // 
            this.buttonRunAnimationRhomb.Location = new System.Drawing.Point(15, 95);
            this.buttonRunAnimationRhomb.Name = "buttonRunAnimationRhomb";
            this.buttonRunAnimationRhomb.Size = new System.Drawing.Size(80, 30);
            this.buttonRunAnimationRhomb.TabIndex = 3;
            this.buttonRunAnimationRhomb.Text = "Rhomb";
            this.buttonRunAnimationRhomb.UseVisualStyleBackColor = true;
            this.buttonRunAnimationRhomb.Click += new System.EventHandler(this.buttonRunAnimationRhomb_Click);
            // 
            // pictureBoxAnimationRepresentation
            // 
            this.pictureBoxAnimationRepresentation.BackColor = System.Drawing.Color.White;
            this.pictureBoxAnimationRepresentation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxAnimationRepresentation.Location = new System.Drawing.Point(110, 25);
            this.pictureBoxAnimationRepresentation.Name = "pictureBoxAnimationRepresentation";
            this.pictureBoxAnimationRepresentation.Size = new System.Drawing.Size(300, 100);
            this.pictureBoxAnimationRepresentation.TabIndex = 4;
            this.pictureBoxAnimationRepresentation.TabStop = false;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 151);
            this.Controls.Add(this.pictureBoxAnimationRepresentation);
            this.Controls.Add(this.buttonRunAnimationRhomb);
            this.Controls.Add(this.buttonRunAnimationSquare);
            this.Controls.Add(this.buttonRunAnimationCircle);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laboratory Work 5";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnimationRepresentation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRunAnimationCircle;
        private System.Windows.Forms.Button buttonRunAnimationSquare;
        private System.Windows.Forms.Button buttonRunAnimationRhomb;
        private System.Windows.Forms.PictureBox pictureBoxAnimationRepresentation;
    }
}
