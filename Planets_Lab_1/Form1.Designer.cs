
namespace Planets_Lab_1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.sceneControl1 = new SharpGL.SceneControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.sceneControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // sceneControl1
            // 
            this.sceneControl1.DrawFPS = true;
            this.sceneControl1.FrameRate = 60;
            this.sceneControl1.Location = new System.Drawing.Point(0, 0);
            this.sceneControl1.Name = "sceneControl1";
            this.sceneControl1.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.sceneControl1.RenderContextType = SharpGL.RenderContextType.FBO;
            this.sceneControl1.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
            this.sceneControl1.Size = new System.Drawing.Size(1004, 598);
            this.sceneControl1.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(464, 604);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 638);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sceneControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.sceneControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SharpGL.SceneControl sceneControl1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

