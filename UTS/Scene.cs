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

        public static Shader Shader_Color;
        public static Shader Shader_Wireframe;
        public static Shader Shader_Depth;
        public static Object scene = new Object("scene");
        public static Matrix4 ProjectionMatrix;
        public static Matrix4 ViewMatrix;
        public static Matrix4 LightMatrix;
        public static Matrix4 LightProjectionMatrix;
        public static Matrix4 LightSpaceMatrix;
        public static Vector3 LightPosition = new Vector3(15,15, 0.0f);
        public static Vector3 LightTo = new Vector3(0,0,0);
        public static Vector3 LightUpwards = new Vector3(0,1,0);
        public static Vector3 ViewPosition = new Vector3(20, 3, 0);
        public static Vector3 ViewTo = new Vector3(0, 0, 0);
        public static Vector3 ViewUpwards = new Vector3(0, 1, 0);
        public static Vector3 WireframeColor = new Vector3(1, 1, 1);
        public static Vector3 SkyColor = new Vector3(0.529f, 0.808f, 0.922f);
        public static Vector3 LightColor = new Vector3(0.8f,0.8f,0.8f);
        public static Vector2i WindowSize;
        public static float LightPower = 100.0f;
        public static float FOV = 45.0f;
        public static float RotateVelocityX = 0;
        public static float RotateVelocityY = 0;
        public static bool Wireframe = false;
        public static bool Solids = true;
        public static int LightMode = 2;

        public static int depthMapFBO;
        public static int depthMap;

        public static void SetScene(Vector2i Size)
        {
            if (Window.ENABLE_SHADOW)
            {
                depthMapFBO = GL.GenFramebuffer();
                depthMap = GL.GenTexture();
                GL.BindTexture(TextureTarget.Texture2D, depthMap);
                GL.TexImage2D(TextureTarget.Texture2D, 0, PixelInternalFormat.DepthComponent, Window.SHADOW_RESOLUTION, Window.SHADOW_RESOLUTION, 0, PixelFormat.DepthComponent, PixelType.Float, IntPtr.Zero);
                GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, (float)TextureMinFilter.Nearest);
                GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMagFilter, (float)TextureMagFilter.Nearest);
                GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureWrapS, (float)TextureWrapMode.ClampToBorder);
                GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureWrapT, (float)TextureWrapMode.ClampToBorder);
                GL.TexParameterI(TextureTarget.Texture2D, TextureParameterName.TextureBorderColor, new int[] { 1, 1, 1, 1 });
                GL.BindFramebuffer(FramebufferTarget.Framebuffer, depthMapFBO);
                GL.FramebufferTexture2D(FramebufferTarget.Framebuffer, FramebufferAttachment.DepthAttachment, TextureTarget.Texture2D, depthMap, 0);
                GL.DrawBuffer(DrawBufferMode.None);
                GL.ReadBuffer(ReadBufferMode.None);
                GL.BindFramebuffer(FramebufferTarget.Framebuffer, 0);
            }

            WindowSize = Size;

            Shader_Color = new Shader("../../../Shaders/shader.vert", "../../../Shaders/shader.frag");
            Shader_Wireframe = new Shader("../../../Shaders/shader_line.vert", "../../../Shaders/shader_line.frag");
            Shader_Depth = new Shader("../../../Shaders/shader_depth.vert", "../../../Shaders/shader_depth.frag");

            LightProjectionMatrix = Matrix4.CreateOrthographic(20,20, 0.1f, 100f);
            LightMatrix = Matrix4.LookAt(LightPosition, LightTo, LightUpwards);
            LightSpaceMatrix = LightMatrix * LightProjectionMatrix;

            Leonando.Objects(ref scene);
            Jeremy.Objects(ref scene);
            Nicholas.Objects(ref scene);
            scene.translateZ(-8.5f);
            scene.rotateZ(45f);
            scene.init();
        }

        public static void AnimateScene()
        {
            Leonando.Animations(ref scene);
            Jeremy.Animations(ref scene);
            Nicholas.Animations(ref scene);
        }
        public static void RenderScene()
        {
            ProjectionMatrix = Matrix4.CreatePerspectiveFieldOfView(FOV.Rad(), (float)WindowSize.X / (float)WindowSize.Y, 0.1f, 100.0f);

            ViewMatrix = Matrix4.LookAt(ViewPosition, ViewTo, ViewUpwards);
            if (Window.ENABLE_SHADOW)
            {
                // get depth, 1st pass
                GL.Viewport(0, 0, Window.SHADOW_RESOLUTION, Window.SHADOW_RESOLUTION);
                GL.BindFramebuffer(FramebufferTarget.Framebuffer, depthMapFBO);
                GL.Clear(ClearBufferMask.DepthBufferBit);
                scene.renderDepth();
                GL.BindFramebuffer(FramebufferTarget.Framebuffer, 0);
                GL.Viewport(0, 0, WindowSize.X, WindowSize.Y);
                GL.BindTexture(TextureTarget.Texture2D, depthMap);
            }

            // render color, 2nd pass
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            scene.render();
        }

        public static void Movement(FrameEventArgs e, Window w)
        {

            float speed = 5;
            float reducespeed = 7.5f;
            float rotatesens = 0.5f;

            if (w.KeyboardState.IsKeyDown(Keys.W))
            {
                ViewPosition -= new Vector3(1, 0, 0) * speed * (float)e.Time;
                ViewTo -= new Vector3(1, 0, 0) * speed * (float)e.Time;
            }

            if (w.KeyboardState.IsKeyDown(Keys.S))
            {
                ViewPosition += new Vector3(1, 0, 0) * speed * (float)e.Time;
                ViewTo += new Vector3(1, 0, 0) * speed * (float)e.Time;
            }

            if (w.KeyboardState.IsKeyDown(Keys.A))
            {
                ViewPosition += new Vector3(0, 0, 1) * speed * (float)e.Time;
                ViewTo += new Vector3(0, 0, 1) * speed * (float)e.Time;
            }

            if (w.KeyboardState.IsKeyDown(Keys.D))
            {
                ViewPosition -= new Vector3(0, 0, 1) * speed * (float)e.Time;
                ViewTo -= new Vector3(0, 0, 1) * speed * (float)e.Time;
            }

            if (w.KeyboardState.IsKeyDown(Keys.Space))
            {
                ViewPosition += new Vector3(0, 1, 0) * speed * (float)e.Time;
                ViewTo += new Vector3(0, 1, 0) * speed * (float)e.Time;
            }

            if (w.KeyboardState.IsKeyDown(Keys.LeftShift))
            {
                ViewPosition -= new Vector3(0, 1, 0) * speed * (float)e.Time;
                ViewTo -= new Vector3(0, 1, 0) * speed * (float)e.Time;
            }

            if (w.KeyboardState.IsKeyDown(Keys.R))
            {
                scene.setTranslate(0,0,0);
                scene.setRotation(0,0,0);
                scene.translateZ(-8.5f);
                scene.rotateZ(45f);

                ViewPosition = new Vector3(20, 3, 0);
                ViewTo = new Vector3(0, 0, 0);

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

            if (w.KeyboardState.IsKeyReleased(Keys.F11)) {
                if (!Window.Fullscreen)
                {
                    w.WindowBorder = WindowBorder.Hidden;
                    w.WindowState = WindowState.Fullscreen;
                    GL.Viewport(0, 0, w.Size.X, w.Size.Y);
                    Scene.RefreshAspect(w.Size);
                }
                else {

                    w.WindowBorder = WindowBorder.Resizable;
                    w.WindowState = WindowState.Normal;
                    GL.Viewport(0, 0, w.Size.X, w.Size.Y);
                    Scene.RefreshAspect(w.Size);
                }
                Window.Fullscreen = !Window.Fullscreen;
            }

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

