using System;
using System.Collections.Generic;
using System.Text;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;
using OpenTK.Graphics.OpenGL4;
using LearnOpenTK.Common;
using OpenTK.Windowing.GraphicsLibraryFramework;
using OpenTK.Mathematics;
using System.Linq;

namespace UTS
{
    class Scene
    {

        // Global Variables;
        public static Object scene = new Object("scene");
        public static Matrix4 ProjectionMatrix;
        public static Matrix4 ViewMatrix;
        public static Vector3 LightPosition = new Vector3(4.0f, 3.0f, 0.0f);
        public static Vector3 ViewPosition = new Vector3(25, 15, 0);
        public static Vector3 WireframeColor = new Vector3(1,1,1);
        public static Vector3 SkyColor = new Vector3(0.529f, 0.808f, 0.922f);
        public static Vector3 LightColor = SkyColor;
        // top (x+) -> use ortho
        // public static Vector3 ViewPosition = new Vector3(0.001, 15, 0); 
        // front (x+) -> use ortho
        // public static Vector3 ViewPosition = new Vector3(15, 0.001f, 0); 

        public static float LightPower = 100.0f;

        public static bool Wireframe = true;

        public static bool Solids = true;

        public static void SetScene(Vector2i Size)
        {
            ViewMatrix = Matrix4.LookAt(Scene.ViewPosition, new Vector3(0, 0, 0), new Vector3(0, 1, 0));
            // perspective
            ProjectionMatrix = Matrix4.CreatePerspectiveFieldOfView((45f).Rad(), (float)Size.X / (float)Size.Y, 0.1f, 100.0f);
            // ortho
            // ProjectionMatrix = Matrix4.CreateOrthographic(15,15,0.1f,100.0f); 

            //Leonando.Objects(ref scene);
            //Nicholas.Objects(ref scene);
            //Jeremy.Objects(ref scene);

            scene.addChild(new Object("Ball"));
            scene.createBall(0.5f);
            scene.scale(7.0f);

            scene.init();
        }

        public static void AnimateScene()
        {
            Leonando.Animations(ref scene);
            Nicholas.Animations(ref scene);
            Jeremy.Animations(ref scene);
        }
        public static void RenderScene()
        {
            scene.render(ProjectionMatrix, ViewMatrix, LightPosition, LightColor, LightPower, ViewPosition, WireframeColor, Solids, Wireframe);
        }

    }

}

