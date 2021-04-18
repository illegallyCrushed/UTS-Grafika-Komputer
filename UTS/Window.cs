﻿using System;
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
        public static readonly int ROUND_OBJECT_DETAIL_LEVEL = 20;
        public static readonly int MULTISAMPLING_LEVEL = 4;
        public static readonly int SHADOW_RESOLUTION = 2048;
        public static bool ENABLE_SHADOW = true;
        public static bool ISFULLSCREEN = false;

        public Window(GameWindowSettings gameWindowSettings, NativeWindowSettings nativeWindowSettings) : base(gameWindowSettings, nativeWindowSettings)
        {
            Console.WriteLine("\"Shaun the Sheep\" made by:");
            Console.WriteLine("Leonando L - C14190010");
            Console.WriteLine("Nicholas S - C14190034");
            Console.WriteLine("Jeremy H - C14190215");
            Console.WriteLine("\nControls:");
            Console.WriteLine("WASD - MOVE CAMERA");
            Console.WriteLine("LSHIFT - MOVE UP CAMERA");
            Console.WriteLine("LCTRL - MOVE DOWN CAMERA");
            Console.WriteLine("MOUSEWHEEL - ZOOM IN/OUT CAMERA");
            Console.WriteLine("R - RESET CAMERA");
            Console.WriteLine("");
            Console.WriteLine("LEFT MOUSE - HORIZONTAL SPIN");
            Console.WriteLine("RIGHT MOUSE - VERTICAL SPIN");
            Console.WriteLine("MIDDLE MOUSE - FREE SPIN");
            Console.WriteLine("");
            Console.WriteLine("ARROW KEYS - MOVE LIGHT");
            Console.WriteLine("RSHIFT - MOVE UP LIGHT");
            Console.WriteLine("RCTRL - MOVE DOWN LIGHT");
            Console.WriteLine("L - RESET LIGHT");
            Console.WriteLine("");
            Console.WriteLine("F1 - SHOW HELP");
            Console.WriteLine("F7 - TOGGLE WIREFRAMES");
            Console.WriteLine("F8 - TOGGLE SOLIDS");
            Console.WriteLine("F9 - TOGGLE LIGHTBALL");
            Console.WriteLine("F10 - TOGGLE SHADOW");
            Console.WriteLine("F11 - TOGGLE FULLSCREEN");
            Console.WriteLine("\nActions:");
        }

        protected override void OnLoad()
        {
            GL.ClearColor(Scene.SkyColor.X, Scene.SkyColor.Y, Scene.SkyColor.Z, 1.0f);
            GL.Enable(EnableCap.Multisample);
            GL.Hint(HintTarget.MultisampleFilterHintNv, HintMode.Nicest);
            GL.Enable(EnableCap.Blend);
            GL.BlendFunc(BlendingFactor.SrcAlpha, BlendingFactor.OneMinusSrcAlpha);
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
            Scene.WindowSize = Size;
            base.OnResize(e);
        }
    }
}

