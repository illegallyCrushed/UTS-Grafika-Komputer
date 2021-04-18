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
        public static readonly int SHADOW_RESOLUTION = 1024;

        public Window(GameWindowSettings gameWindowSettings, NativeWindowSettings nativeWindowSettings) : base(gameWindowSettings, nativeWindowSettings)
        {
            Console.WriteLine("Shaun the Sheep made by:");
            Console.WriteLine("Leonando L - C14190010");
            Console.WriteLine("Nicholas S - C14190034");
            Console.WriteLine("Jeremy H - C14190215");
            Console.WriteLine("\nControls:");
            Console.WriteLine("WASD - MOVE");
            Console.WriteLine("SPACE - UP");
            Console.WriteLine("SHIFT - DOWN");
            Console.WriteLine("LEFT MOUSE - HORIZONTAL SPIN");
            Console.WriteLine("RIGHT MOUSE - VERTICAL SPIN");
            Console.WriteLine("MIDDLE MOUSE - FREE SPIN");
            Console.WriteLine("R - RESET CAMERA");
        }

        protected override void OnLoad()
        {
            GL.ClearColor(Scene.SkyColor.X, Scene.SkyColor.Y, Scene.SkyColor.Z, 1.0f);
            GL.Enable(EnableCap.Multisample);
            GL.Enable(EnableCap.Blend);
            GL.BlendFunc(BlendingFactor.SrcAlpha, BlendingFactor.OneMinusSrcAlpha);
            GL.Hint(HintTarget.MultisampleFilterHintNv, HintMode.Nicest);
            GL.Enable(EnableCap.DepthTest);
            GL.DepthFunc(DepthFunction.Less);

            Scene.SetScene(Size);

            base.OnLoad();
        }

        protected override void OnRenderFrame(FrameEventArgs args)
        {
            Scene.AnimateScene();
            Scene.RenderScene();

            SwapBuffers();
            base.OnRenderFrame(args);
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            Animator.Tick(e);
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

