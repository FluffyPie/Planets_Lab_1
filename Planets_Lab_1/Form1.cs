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
            
            SharpGL.SceneGraph.Assets.Texture SunTexture = new SharpGL.SceneGraph.Assets.Texture();
            SharpGL.SceneGraph.Assets.Texture EarthTexture = new SharpGL.SceneGraph.Assets.Texture();
            SharpGL.SceneGraph.Assets.Texture MoonTexture = new SharpGL.SceneGraph.Assets.Texture();

            OpenGLControl openglCtr = new SharpGL.OpenGLControl();
            SunTexture.Create(openglCtr.OpenGL, "Sun.bmp");

            OpenGLControl openglCtr1 = new SharpGL.OpenGLControl();
            MoonTexture.Create(openglCtr1.OpenGL, "Moon.jpg");

            OpenGLControl openglCtr2 = new SharpGL.OpenGLControl();
            EarthTexture.Create(openglCtr2.OpenGL, "Earth.jpg");

            //// texture1.Create(openglCtr.OpenGL, "Crate.bmp");

            //// material.Texture = texture1;
            SunMaterial.Texture = SunTexture;
            Sun.TextureCoords = true;

            EarthMaterial.Texture = EarthTexture;
            Earth.TextureCoords = true;

            MoonMaterial.Texture = MoonTexture;
            Moon.TextureCoords = true;


            //SharpGL.OpenGL gl = this.sceneControl1.OpenGL;
            //texture.Create(gl, "Crate.bmp");
            //texture.Bind(gl);

            //uint[] textureID = new uint[1];
            //byte[] colors = new byte[256 * 256 * 4];
            //gl.BindTexture(OpenGL.GL_TEXTURE_2D, textureID[0]);
            //gl.TexImage2D(OpenGL.GL_TEXTURE_2D, 0, (int)OpenGL.GL_TEXTURE, 256, 256, 50, OpenGL.GL_TEXTURE, OpenGL.GL_BYTE, colors);

            //// SunMaterial.Diffuse = Color.Orange;
            //EarthMaterial.Diffuse = Color.Cyan;
            //MoonMaterial.Diffuse = Color.Silver;
            ////SunMaterial.Ambient = Color.FromArgb(0, Color.Orange);
            //EarthMaterial.Ambient = Color.FromArgb(255, Color.Blue);
            //MoonMaterial.Ambient = Color.FromArgb(255, Color.Silver);

            SunMaterial.Texture = SunTexture;

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


 
    

        }
        double rotate = 0;
        double i = 0;
        double j = 0;
        private void Tick(object sender, EventArgs e)
        {
            Earth.Transformation.RotateZ = (float)j*trackBar1.Value;
            Moon.Transformation.RotateZ = (float)rotate*trackBar1.Value;

            Earth.Transformation.TranslateX = (float)(10*Math.Cos(i * trackBar1.Value));
            Earth.Transformation.TranslateY = (float)(10*Math.Sin(i * trackBar1.Value));


            Moon.Transformation.TranslateX = (float)(10 * Math.Cos(i * trackBar1.Value)) + (float)(3 * Math.Cos(j * trackBar1.Value));
            Moon.Transformation.TranslateY = (float)(10 * Math.Sin(i * trackBar1.Value)) + (float)(3 * Math.Sin(j * trackBar1.Value));

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
