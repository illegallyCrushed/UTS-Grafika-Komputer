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

    public static class ExtensionMethods
    {
        public static float Rad(this float degree)
        {
            return (float)((degree * Math.PI) / 180);
        }

    }

    class Window : GameWindow
    {
        public static readonly int ROUND_OBJECT_DETAIL_LEVEL = 50;
        public static readonly int MULTISAMPLING_LEVEL = 8;

        public Window(GameWindowSettings gameWindowSettings, NativeWindowSettings nativeWindowSettings) : base(gameWindowSettings, nativeWindowSettings)
        {
        }

        protected override void OnLoad()
        {
            GL.ClearColor(Scene.SkyColor.X, Scene.SkyColor.Y, Scene.SkyColor.Z, 1.0f);
            GL.Enable(EnableCap.Multisample);
            GL.Hint(HintTarget.MultisampleFilterHintNv, HintMode.Nicest);
            GL.Enable(EnableCap.DepthTest);
            GL.DepthFunc(DepthFunction.Less);

            Scene.SetScene(Size);

            base.OnLoad();
        }

        protected override void OnRenderFrame(FrameEventArgs args)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            Scene.AnimateScene();
            Scene.RenderScene();

            SwapBuffers();
            base.OnRenderFrame(args);
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            Scene.Movement(e, this);
        }

        protected override void OnMouseWheel(MouseWheelEventArgs e)
        {
            Scene.Zoom(e);
        }

        protected override void OnResize(ResizeEventArgs e)
        {
            GL.Viewport(0, 0, Size.X, Size.Y);
            Scene.RefreshAspect(Size);
            base.OnResize(e);
        }
    }
}

