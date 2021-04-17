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
        public static Vector3 LightPosition = new Vector3(1.0f, 5.0f, 0.0f);
        public static Vector3 LightDirection = new Vector3(0, 0f, 0.0f);
        public static Vector3 ViewPosition = new Vector3(20, 5, 0);
        public static Vector3 ViewDirection = new Vector3(0, 0, 0);
        public static Vector3 ViewUpwards = new Vector3(0, 1, 0);
        public static Vector3 WireframeColor = new Vector3(1, 1, 1);
        public static Vector3 SkyColor = new Vector3(0.529f, 0.808f, 0.922f);
        public static Vector3 LightColor = SkyColor;
        public static Vector2i WindowSize;
        public static float LightPower = 100.0f;
        public static float FOV = 45.0f;
        public static float RotateVelocityX = 0;
        public static float RotateVelocityY = 0;
        public static float rotatesz = 0;
        public static bool Wireframe = false;
        public static bool Solids = true;

        public static void SetScene(Vector2i Size)
        {
            // perspective
            // ortho
            // ProjectionMatrix = Matrix4.CreateOrthographic(15,15,0.1f,100.0f); 
            WindowSize = Size;

            Leonando.Objects(ref scene);
            Nicholas.Objects(ref scene);
            Jeremy.Objects(ref scene);
            scene.translateZ(-8f);
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
            ProjectionMatrix = Matrix4.CreatePerspectiveFieldOfView(FOV.Rad(), (float)WindowSize.X / (float)WindowSize.Y, 0.1f, 100.0f);
            ViewMatrix = Matrix4.LookAt(ViewPosition, ViewDirection, ViewUpwards);
            scene.render(ProjectionMatrix, ViewMatrix, LightPosition, LightDirection, LightColor, LightPower, ViewPosition, WireframeColor, Solids, Wireframe);
        }

        public static void Movement(FrameEventArgs e, Window w)
        {

            float speed = 10;
            float reducespeed = 7.5f;
            float rotatesens = 0.5f;

            if (w.KeyboardState.IsKeyDown(Keys.W))
            {
                ViewPosition -= new Vector3(1, 0, 0) * speed * (float)e.Time;
                ViewDirection -= new Vector3(1, 0, 0) * speed * (float)e.Time;
            }

            if (w.KeyboardState.IsKeyDown(Keys.S))
            {
                ViewPosition += new Vector3(1, 0, 0) * speed * (float)e.Time;
                ViewDirection += new Vector3(1, 0, 0) * speed * (float)e.Time;
            }

            if (w.KeyboardState.IsKeyDown(Keys.A))
            {
                ViewPosition += new Vector3(0, 0, 1) * speed * (float)e.Time;
                ViewDirection += new Vector3(0, 0, 1) * speed * (float)e.Time;
            }

            if (w.KeyboardState.IsKeyDown(Keys.D))
            {
                ViewPosition -= new Vector3(0, 0, 1) * speed * (float)e.Time;
                ViewDirection -= new Vector3(0, 0, 1) * speed * (float)e.Time;
            }

            if (w.KeyboardState.IsKeyDown(Keys.Space))
            {
                ViewPosition += new Vector3(0, 1, 0) * speed * (float)e.Time;
                ViewDirection += new Vector3(0, 1, 0) * speed * (float)e.Time;
            }

            if (w.KeyboardState.IsKeyDown(Keys.LeftShift))
            {
                ViewPosition -= new Vector3(0, 1, 0) * speed * (float)e.Time;
                ViewDirection -= new Vector3(0, 1, 0) * speed * (float)e.Time;
            }

            if (w.KeyboardState.IsKeyDown(Keys.R))
            {
                scene.setTranslate(0,0,0);
                scene.setRotation(0,0,0);
                scene.translateZ(-8f);

                ViewPosition = new Vector3(20, 5, 0);
                ViewDirection = new Vector3(0, 0, 0);

                FOV = 45f;
            }

            float deltaX = w.MouseState.Position.X - w.MouseState.PreviousPosition.X;
            float deltaY = w.MouseState.Position.Y - w.MouseState.PreviousPosition.Y;
            if (w.MouseState.IsButtonDown(MouseButton.Button3))
            {

                RotateVelocityX = deltaX * (float)rotatesens;
                RotateVelocityY = deltaY * (float)rotatesens;
            }
            else if (w.MouseState.IsButtonDown(MouseButton.Button2))
            {
                RotateVelocityY = deltaY * (float)rotatesens;

            }
            else if (w.MouseState.IsButtonDown(MouseButton.Button1))
            {
                RotateVelocityX = deltaX * (float)rotatesens;
            }
            RotateVelocityX -= (RotateVelocityX - 0) * reducespeed * (float)e.Time;
            RotateVelocityY -= (RotateVelocityY - 0) * reducespeed * (float)e.Time;
            scene.rotateZ(RotateVelocityX);
            scene.rotateY(RotateVelocityY);
        }

        public static void Zoom(MouseWheelEventArgs e)
        {
            FOV -= e.Offset.Y * 2;

            if (FOV <= 1.0f)
            {
                FOV = 1.0f;
            }
            else if (FOV >= 179.0f)
            {
                FOV = 179.0f;
            }
        }


        public static void RefreshAspect(Vector2i Size)
        {
            WindowSize = Size;
        }


    }

}

