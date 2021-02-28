using SharpGL;
using SharpGL.SceneGraph.Assets;
using SharpGL.SceneGraph.Cameras;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Planets_Lab_1
{
    public partial class Form1 : Form
    {
        SharpGL.SceneGraph.Quadrics.Sphere Earth = new SharpGL.SceneGraph.Quadrics.Sphere();
        SharpGL.SceneGraph.Quadrics.Sphere Moon = new SharpGL.SceneGraph.Quadrics.Sphere();
        SharpGL.SceneGraph.Quadrics.Sphere Sun = new SharpGL.SceneGraph.Quadrics.Sphere();
        Texture texture = new Texture();
     
        public Form1()
        {
            InitializeComponent();

            SharpGL.SceneGraph.Assets.Material SunMaterial = new SharpGL.SceneGraph.Assets.Material();
            SharpGL.SceneGraph.Assets.Material EarthMaterial = new SharpGL.SceneGraph.Assets.Material();
            SharpGL.SceneGraph.Assets.Material MoonMaterial = new SharpGL.SceneGraph.Assets.Material();
            //SharpGL.SceneGraph.Assets.Texture texture = new SharpGL.SceneGraph.Assets.Texture();
            //SharpGL.SceneGraph.Assets.Texture texture1 = new SharpGL.SceneGraph.Assets.Texture();

            // material1.Ambient = Color.FromArgb(100, Color.Red);


            // OpenGLControl openglCtr = new SharpGL.OpenGLControl();
            // texture.Create(openglCtr.OpenGL, "Sun.bmp");

            //// texture1.Create(openglCtr.OpenGL, "Crate.bmp");

            //// material.Texture = texture1;
            // material1.Texture = texture;


            //SharpGL.OpenGL gl = this.sceneControl1.OpenGL;
            //texture.Create(gl, "Crate.bmp");
            //texture.Bind(gl);

            //uint[] textureID = new uint[1];
            //byte[] colors = new byte[256 * 256 * 4];
            //gl.BindTexture(OpenGL.GL_TEXTURE_2D, textureID[0]);
            //gl.TexImage2D(OpenGL.GL_TEXTURE_2D, 0, (int)OpenGL.GL_TEXTURE, 256, 256, 50, OpenGL.GL_TEXTURE, OpenGL.GL_BYTE, colors);

            SunMaterial.Diffuse = Color.Orange;
            EarthMaterial.Diffuse = Color.Cyan;
            MoonMaterial.Diffuse = Color.Silver;
            SunMaterial.Ambient = Color.FromArgb(0, Color.Orange);
            EarthMaterial.Ambient = Color.FromArgb(255, Color.Blue);
            MoonMaterial.Ambient = Color.FromArgb(255, Color.Silver);

            SunMaterial.Texture = texture;

            Sun.Material = SunMaterial;
            Moon.Material = MoonMaterial;
            Earth.Material = EarthMaterial;

            Earth.Radius = 2;
            Moon.Radius = 0.5;
            Sun.Radius = 4;

            sceneControl1.Scene.SceneContainer.AddChild(Earth);
            sceneControl1.Scene.SceneContainer.AddChild(Moon);
            sceneControl1.Scene.SceneContainer.AddChild(Sun);


            sceneControl1.Scene.RenderBoundingVolumes = !sceneControl1.Scene.RenderBoundingVolumes;


 
            //  Create the arcball camera.

        }
        double rotate = 0;
        double i = 0;
        double j = 0;
        private void Tick(object sender, EventArgs e)
        {
            Earth.Transformation.RotateZ = (float)j;
            Moon.Transformation.RotateZ = (float)rotate;

            Earth.Transformation.TranslateX = (float)(10*Math.Cos(i));
            Earth.Transformation.TranslateY = (float)(10*Math.Sin(i));


            Moon.Transformation.TranslateX = (float)(10 * Math.Cos(i)) + (float)(3 * Math.Cos(j));
            Moon.Transformation.TranslateY = (float)(10 * Math.Sin(i)) + (float)(3 * Math.Sin(j));

            j += 0.05;
            i+= 0.001;
            rotate -= 0.05;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //  Destroy the existing texture.
                texture.Destroy(sceneControl1.OpenGL);

                //  Create a new texture.
                texture.Create(sceneControl1.OpenGL, openFileDialog1.FileName);

                //  Redraw.
                sceneControl1.Invalidate();
            }
        }
    }
}
