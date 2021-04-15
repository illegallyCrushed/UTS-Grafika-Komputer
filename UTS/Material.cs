using LearnOpenTK.Common;
using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using OpenTK.Graphics.OpenGL4;
using System.Globalization;
using System.Linq;

namespace UTS
{
    class Material
    {
        public Vector3 diffuse;
        public Vector3 specular;
        public float specularExponent;
        public string name;

        public Material(string matname = "Default")
        {
            name = matname;
            diffuse.X = 1;
            diffuse.Y = 1;
            diffuse.Z = 0;
            specular.X = 1;
            specular.Y = 1;
            specular.Z = 1;
            specularExponent = 32;
        }
    }

}
