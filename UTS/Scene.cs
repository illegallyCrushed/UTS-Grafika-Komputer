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
        //public static Vector3 SkyColor = new Vector3(0.529f, 0.808f, 0.922f);
        public static Vector3 SkyColor = new Vector3(0, 0, 0);
        public static Vector3 LightColor = SkyColor;
        public static Vector2i WindowSize;
        public static float LightPower = 100.0f;
        public static float FOV = 45.0f;
        public static float RotateVelocityX = 0;
        public static float RotateVelocityY = 0;
        public static bool Wireframe = true;
        public static bool Solids = false;

        public static void SetScene(Vector2i Size)
        {
            // perspective
            // ortho
            // ProjectionMatrix = Matrix4.CreateOrthographic(15,15,0.1f,100.0f); 
            WindowSize = Size;

            //Leonando.Objects(ref scene);
            //Nicholas.Objects(ref scene);
            //Jeremy.Objects(ref scene);

            scene.addChild(new Object("TestSubject"));
            scene.lastChild().createFreeformTube(new List<Vector2> {
                new Vector2(4.77472f, -4.86339f),
                new Vector2(3.61593f, -4.80020f),
                new Vector2(2.47753f, -4.50222f),
                new Vector2(1.37436f, -4.02618f),
                new Vector2(0.32125f, -3.42876f),
                new Vector2(-0.66694f, -2.76668f),
                new Vector2(-1.00021f, -2.54351f),
                new Vector2(-1.34565f, -2.30289f),
                new Vector2(-1.62266f, -2.04802f),
                new Vector2(-1.75065f, -1.78210f),
                new Vector2(-1.64902f, -1.50833f),
                new Vector2(-0.80169f, -1.16639f),
                new Vector2(0.60964f, -1.06763f),
                new Vector2(2.23028f, -1.07769f),
                new Vector2(3.70550f, -1.06222f),
                new Vector2(4.68060f, -0.88687f),
                new Vector2(5.10377f, -0.41385f),
                new Vector2(5.20917f, 0.30803f),
                new Vector2(5.05597f, 1.12576f),
                new Vector2(4.70331f, 1.88631f),
                new Vector2(4.21037f, 2.43666f),
                new Vector2(2.06916f, 3.30126f),
                new Vector2(-1.01196f, 3.80679f),
                new Vector2(-4.45247f, 4.03739f),
                new Vector2(-7.67185f, 4.07720f),
                new Vector2(-10.08960f, 4.01038f),
            });
            scene.lastChild().scale(-1.34148f, 3.32852f, 1.00000f);
            scene.lastChild().rotateQ(0.58599f, -0.68047f, 0.42019f, 0.13045f);
            scene.lastChild().translate(-2.54775f, -0.82219f, 5.56878f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(1.0f, 1.0f, 0.0f);









            scene.init();
            //scene.translateZ(-7.5f);
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

