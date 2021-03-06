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
    class Object
    {
        // VAO VBO EBO
        private int _vertexBufferObject;
        private int _vertexArrayObject;
        private int _elementBufferObject;
        private int _normalsBufferObject;

        // Vectors
        private List<Vector3> vertices = new List<Vector3>();
        private List<Vector3> normals = new List<Vector3>();

        // Indices
        private List<uint> vertexIndices = new List<uint>();

        // Transformation

        private Matrix4 processed_transform;
        private Matrix4 object_transform;
        private Matrix4 origin_transform;
        private Matrix4 saved_transform;

        public Object parent;

        // Children
        public List<Object> children = new List<Object>();

        // Material
        public Material material;

        // Object's name
        public string name;

        // Constructor
        public Object(string name, bool parent = false)
        {
            material = new Material();
            saved_transform = Matrix4.Identity;
            object_transform = Matrix4.Identity;
            origin_transform = Matrix4.Identity;
            processed_transform = Matrix4.Identity;
            this.name = name;
        }

        //Initialization
        public void init()
        {
            _vertexBufferObject = GL.GenBuffer();
            GL.BindBuffer(BufferTarget.ArrayBuffer, _vertexBufferObject);
            GL.BufferData<Vector3>(BufferTarget.ArrayBuffer,
                vertices.Count * Vector3.SizeInBytes,
                vertices.ToArray(),
                BufferUsageHint.StaticDraw);

            _normalsBufferObject = GL.GenBuffer();
            GL.BindBuffer(BufferTarget.ArrayBuffer, _normalsBufferObject);
            GL.BufferData<Vector3>(BufferTarget.ArrayBuffer,
                normals.Count * Vector3.SizeInBytes,
                normals.ToArray(),
                BufferUsageHint.StaticDraw);

            _vertexArrayObject = GL.GenVertexArray();
            GL.BindVertexArray(_vertexArrayObject);

            GL.BindBuffer(BufferTarget.ArrayBuffer, _vertexBufferObject);
            GL.VertexAttribPointer(0, 3, VertexAttribPointerType.Float, false, 3 * sizeof(float), 0);
            GL.EnableVertexAttribArray(0);

            GL.BindBuffer(BufferTarget.ArrayBuffer, _normalsBufferObject);
            GL.VertexAttribPointer(1, 3, VertexAttribPointerType.Float, false, 3 * sizeof(float), 0);
            GL.EnableVertexAttribArray(1);

            _elementBufferObject = GL.GenBuffer();
            GL.BindBuffer(BufferTarget.ElementArrayBuffer, _elementBufferObject);
            GL.BufferData(BufferTarget.ElementArrayBuffer,
                vertexIndices.Count * sizeof(uint),
                vertexIndices.ToArray(), BufferUsageHint.StaticDraw);

            foreach (var child in children)
            {
                child.init();
            }
        }

        public bool isParent()
        {
            return children.Count > 0;
        }

        public void addChild(Object newobject)
        {
            children.Add(newobject);
            children.Last().parent = this;
        }

        public Object lastChild()
        {
            return children.Last();
        }

        public void applyTransform(Matrix4 transformation, bool parentAction = false)
        {
            processed_transform = Matrix4.Identity;

            if (parentAction)
            {
                if (parent != null)
                    processed_transform = object_transform * origin_transform * parent.processed_transform;
                else
                    processed_transform = object_transform * origin_transform;
            }
            else
            {
                object_transform = object_transform * transformation;
                if (parent != null)
                    processed_transform = object_transform * origin_transform * parent.processed_transform;
                else
                    processed_transform = object_transform * origin_transform;
            }

            foreach (var child in children)
            {
                child.applyTransform(transformation, isParent());
            }
        }

        public void setTransform(Matrix4 transformation, int type = 0, bool parentAction = false)
        {
            processed_transform = Matrix4.Identity;

            if (parentAction)
            {
                if (parent != null)
                    processed_transform = object_transform * origin_transform * parent.processed_transform;
                else
                    processed_transform = object_transform * origin_transform;
            }
            else
            {
                if (type == 0)
                {
                    // set rotation
                    object_transform = object_transform.ClearRotation();
                    object_transform = object_transform * transformation;
                }

                else if (type == 1)
                {
                    //set translation
                    object_transform = object_transform.ClearTranslation();
                    object_transform = object_transform * transformation;
                }

                else
                {
                    //clear scale
                    object_transform = object_transform.ClearScale();
                    object_transform = object_transform * transformation;
                }



                if (parent != null)
                    processed_transform = object_transform * origin_transform * parent.processed_transform;
                else
                    processed_transform = object_transform * origin_transform;
            }

            foreach (var child in children)
            {
                child.setTransform(transformation, type, isParent());
            }
        }

        // adjust ke model blender, y=z, z=-y; translate 1/2x

        public void rotateX(float degree, bool ignoreOrigin = false)
        {
            applyTransform(Matrix4.CreateRotationX(degree.Rad()), ignoreOrigin);
        }

        public void rotateY(float degree, bool ignoreOrigin = false)
        {
            applyTransform(Matrix4.CreateRotationZ(degree.Rad()), ignoreOrigin);
            //applyTransform(Matrix4.CreateRotationY(degree.Rad()), ignoreOrigin);
        }

        public void rotateZ(float degree, bool ignoreOrigin = false)
        {
            applyTransform(Matrix4.CreateRotationY(degree.Rad()), ignoreOrigin);
            //applyTransform(Matrix4.CreateRotationZ(degree.Rad()), ignoreOrigin);
        }

        public void rotateQ(float w, float x, float y, float z, bool ignoreOrigin = false)
        {
            applyTransform(Matrix4.CreateFromQuaternion(new Quaternion(x, z, -y, w)), ignoreOrigin);
            //applyTransform(Matrix4.CreateFromQuaternion(new Quaternion(x, y, z, w)), ignoreOrigin);
        }

        public void translateX(float x, bool ignoreOrigin = false)
        {
            applyTransform(Matrix4.CreateTranslation(new Vector3(x / 2, 0, 0)), ignoreOrigin);
        }

        public void translateY(float y, bool ignoreOrigin = false)
        {
            applyTransform(Matrix4.CreateTranslation(new Vector3(0, 0, -y / 2)), ignoreOrigin);
            //applyTransform(Matrix4.CreateTranslation(new Vector3(0, y, 0)), ignoreOrigin);
        }

        public void translateZ(float z, bool ignoreOrigin = false)
        {
            applyTransform(Matrix4.CreateTranslation(new Vector3(0, z / 2, 0)), ignoreOrigin);
            //applyTransform(Matrix4.CreateTranslation(new Vector3(0, 0, z)), ignoreOrigin);
        }

        public void translate(float x, float y, float z, bool ignoreOrigin = false)
        {
            applyTransform(Matrix4.CreateTranslation(new Vector3(x / 2, z / 2, -y / 2)), ignoreOrigin);
            //applyTransform(Matrix4.CreateTranslation(new Vector3(x, y, z)), ignoreOrigin);
        }

        public void scaleX(float x, bool ignoreOrigin = false)
        {
            applyTransform(Matrix4.CreateScale(new Vector3(x, 1, 1)), ignoreOrigin);
        }

        public void scaleY(float y, bool ignoreOrigin = false)
        {
            applyTransform(Matrix4.CreateScale(new Vector3(1, 1, y)), ignoreOrigin);
            //applyTransform(Matrix4.CreateScale(new Vector3(1, y, 1)), ignoreOrigin);
        }

        public void scaleZ(float z, bool ignoreOrigin = false)
        {
            applyTransform(Matrix4.CreateScale(new Vector3(1, z, 1)), ignoreOrigin);
            //applyTransform(Matrix4.CreateScale(new Vector3(1, 1, z)), ignoreOrigin);
        }

        public void scale(float x, float y, float z, bool ignoreOrigin = false)
        {
            applyTransform(Matrix4.CreateScale(new Vector3(x, z, y)), ignoreOrigin);
            //applyTransform(Matrix4.CreateScale(new Vector3(x, y, z)), ignoreOrigin);
        }

        public void scale(float factor, bool ignoreOrigin = false)
        {
            applyTransform(Matrix4.CreateScale(new Vector3(factor, factor, factor)), ignoreOrigin);
            //applyTransform(Matrix4.CreateScale(new Vector3(factor, factor, factor)), ignoreOrigin);
        }

        public void setRotation(float x, float y, float z, bool ignoreOrigin = false)
        {
            Matrix4 combinedRotation = Matrix4.CreateRotationX(x.Rad()) * Matrix4.CreateRotationY(z.Rad()) * Matrix4.CreateRotationZ(y.Rad());
            setTransform(combinedRotation, 0, ignoreOrigin);
        }

        //public void setRotationQ(float w, float x, float y, float z, bool ignoreOrigin = false)
        //{
        //    Matrix4 combinedRotation = Matrix4.CreateRotationX(x.Rad()) * Matrix4.CreateRotationY(z.Rad()) * Matrix4.CreateRotationZ(y.Rad());
        //    setTransform(Matrix4.CreateFromQuaternion(new Quaternion(x, z, -y, w)), 0, ignoreOrigin);
        //}

        public void setTranslateX(float x, bool ignoreOrigin = false)
        {

            setTransform(Matrix4.CreateTranslation(new Vector3(x / 2, 0, 0)), 1, ignoreOrigin);
        }

        public void setTranslateY(float y, bool ignoreOrigin = false)
        {
            setTransform(Matrix4.CreateTranslation(new Vector3(0, 0, -y / 2)), 1, ignoreOrigin);
        }

        public void setTranslateZ(float z, bool ignoreOrigin = false)
        {
            setTransform(Matrix4.CreateTranslation(new Vector3(0, z / 2, 0)), 1, ignoreOrigin);
        }

        public void setTranslate(float x, float y, float z, bool ignoreOrigin = false)
        {
            setTransform(Matrix4.CreateTranslation(new Vector3(x / 2, z / 2, -y / 2)), 1, ignoreOrigin);
        }

        //public void setScaleX(float x, bool ignoreOrigin = false)
        //{
        //    setTransform(Matrix4.CreateScale(new Vector3(x, scalation.Y, scalation.Z)),2, ignoreOrigin);
        //    scalation = new Vector3(x, scalation.Y, scalation.Z);
        //}

        //public void setScaleY(float y, bool ignoreOrigin = false)
        //{
        //    setTransform(Matrix4.CreateScale(new Vector3(scalation.X, scalation.Z, y)),2, ignoreOrigin);
        //    scalation = new Vector3(scalation.X, y, scalation.Z);
        //}

        //public void setScaleZ(float z, bool ignoreOrigin = false)
        //{
        //    setTransform(Matrix4.CreateScale(new Vector3(scalation.X, z, scalation.Y)),2, ignoreOrigin);
        //    scalation = new Vector3(scalation.X, scalation.Y, z);
        //}

        //public void setScale(float x, float y, float z, bool ignoreOrigin = false)
        //{
        //    setTransform(Matrix4.CreateScale(new Vector3(x, z, y)),2, ignoreOrigin);
        //    scalation = new Vector3(x,y,z);
        //}

        //public void setScale(float factor, bool ignoreOrigin = false)
        //{
        //    setTransform(Matrix4.CreateScale(new Vector3(factor, factor, factor)), 2, ignoreOrigin);
        //    scalation = new Vector3(factor, factor, factor);
        //}

        public void setColor(float r, float g, float b)
        {
            material.diffuse = new Vector3(r, g, b);
        }

        public void centerOrigin()
        {
            Vector3 vect = object_transform.ExtractTranslation();
            origin_transform = Matrix4.CreateTranslation(vect);
            processed_transform = object_transform;
            origin_transform.Invert();
            object_transform = object_transform * origin_transform;
            saved_transform = object_transform;
            origin_transform.Invert();
        }

        public void restoreTransform()
        {

            object_transform = saved_transform;
        }
        public void renderDepth()
        {
            if (vertices.Count > 0)
            {
                Scene.Shader_Depth.Use();

                Scene.Shader_Depth.SetMatrix4("model", processed_transform);
                for (int i = 0; i < 6; ++i)
                    Scene.Shader_Depth.SetMatrix4("shadowMatrices" + i.ToString(), Scene.LightSpaceMatrix[i]);
                Scene.Shader_Depth.SetFloat("far_plane", Scene.LightFarPlane);
                Scene.Shader_Depth.SetVector3("lightPos", Scene.LightPosition);

                GL.BindVertexArray(_vertexArrayObject);
                if (Scene.Solids)
                {
                    GL.DrawElements(PrimitiveType.Triangles, vertexIndices.Count, DrawElementsType.UnsignedInt, 0);
                }
                if (Scene.Wireframe)
                {
                    GL.PolygonMode(MaterialFace.FrontAndBack, PolygonMode.Line);
                    GL.DrawElements(PrimitiveType.Triangles, vertexIndices.Count, DrawElementsType.UnsignedInt, 0);
                    GL.PolygonMode(MaterialFace.FrontAndBack, PolygonMode.Fill);
                }

                GL.BindVertexArray(0);
            }

            foreach (var child in children)
            {
                child.renderDepth();
            }
        }
        public void render()
        {
            if (vertices.Count > 0)
            {

                Scene.Shader_Wireframe.SetMatrix4("mvp_transform", processed_transform * Scene.ViewMatrix * Scene.ProjectionMatrix);
                Scene.Shader_Wireframe.SetVector3("lineColor", Scene.WireframeColor);
                Scene.Shader_Color.SetFloat("far_plane", Scene.LightFarPlane);
                Scene.Shader_Color.SetInt("simple", Scene.LightMode);
                Scene.Shader_Color.SetMatrix4("model", processed_transform);
                Scene.Shader_Color.SetMatrix4("view", Scene.ViewMatrix);
                Scene.Shader_Color.SetMatrix4("projection", Scene.ProjectionMatrix);
                Scene.Shader_Color.SetVector3("material.ambient", material.diffuse * new Vector3(0.9f, 0.9f, 0.9f));
                Scene.Shader_Color.SetVector3("material.diffuse", material.diffuse);
                Scene.Shader_Color.SetVector3("material.specular", material.specular);
                Scene.Shader_Color.SetFloat("material.shininess", (float)material.specularExponent);
                Scene.Shader_Color.SetFloat("alpha", material.alpha);
                Scene.Shader_Color.SetVector3("light.position", Scene.LightPosition);
                Scene.Shader_Color.SetVector3("light.ambient", Scene.LightColor);
                Scene.Shader_Color.SetVector3("light.diffuse", Scene.LightColor);
                Scene.Shader_Color.SetVector3("light.specular", Scene.LightColor);
                Scene.Shader_Color.SetVector3("viewPos", Scene.ViewPosition);
                Scene.Shader_Color.SetInt("shadowenable", Window.ENABLE_SHADOW?1:0);

                GL.BindVertexArray(_vertexArrayObject);

                if (Scene.Solids)
                {
                    Scene.Shader_Color.Use();
                    GL.DrawElements(PrimitiveType.Triangles, vertexIndices.Count, DrawElementsType.UnsignedInt, 0);
                }
                if (Scene.Wireframe)
                {
                    Scene.Shader_Wireframe.Use();
                    GL.PolygonMode(MaterialFace.FrontAndBack, PolygonMode.Line);
                    GL.DrawElements(PrimitiveType.Triangles, vertexIndices.Count, DrawElementsType.UnsignedInt, 0);
                    GL.PolygonMode(MaterialFace.FrontAndBack, PolygonMode.Fill);
                }

                GL.BindVertexArray(0);
            }

            foreach (var child in children)
            {
                child.render();
            }
        }

        public void delete()
        {
            object_transform = Matrix4.Identity;
            processed_transform = Matrix4.Identity;
            origin_transform = Matrix4.Identity;
            vertices = new List<Vector3>();
            normals = new List<Vector3>();
            children = new List<Object>();
            vertexIndices = new List<uint>();
            init();
        }

        public Object findChild(string name)
        {
            foreach (var child in children)
            {
                if (child.name == name)
                    return child;
            }
            return new Object("NullObject");
        }

        public void createCube()
        {
            delete();
            vertices.Add(new Vector3(0.5f, 0.5f, 0.5f));
            vertices.Add(new Vector3(0.5f, 0.5f, -0.5f));
            vertices.Add(new Vector3(0.5f, -0.5f, 0.5f));
            vertices.Add(new Vector3(0.5f, -0.5f, -0.5f));
            vertices.Add(new Vector3(-0.5f, 0.5f, -0.5f));
            vertices.Add(new Vector3(-0.5f, 0.5f, 0.5f));
            vertices.Add(new Vector3(-0.5f, -0.5f, -0.5f));
            vertices.Add(new Vector3(-0.5f, -0.5f, 0.5f));
            vertices.Add(new Vector3(-0.5f, 0.5f, -0.5f));
            vertices.Add(new Vector3(0.5f, 0.5f, -0.5f));
            vertices.Add(new Vector3(-0.5f, 0.5f, 0.5f));
            vertices.Add(new Vector3(0.5f, 0.5f, 0.5f));
            vertices.Add(new Vector3(-0.5f, -0.5f, 0.5f));
            vertices.Add(new Vector3(0.5f, -0.5f, 0.5f));
            vertices.Add(new Vector3(-0.5f, -0.5f, -0.5f));
            vertices.Add(new Vector3(0.5f, -0.5f, -0.5f));
            vertices.Add(new Vector3(-0.5f, 0.5f, 0.5f));
            vertices.Add(new Vector3(0.5f, 0.5f, 0.5f));
            vertices.Add(new Vector3(-0.5f, -0.5f, 0.5f));
            vertices.Add(new Vector3(0.5f, -0.5f, 0.5f));
            vertices.Add(new Vector3(0.5f, 0.5f, -0.5f));
            vertices.Add(new Vector3(-0.5f, 0.5f, -0.5f));
            vertices.Add(new Vector3(0.5f, -0.5f, -0.5f));
            vertices.Add(new Vector3(-0.5f, -0.5f, -0.5f));

            normals.Add(new Vector3(1, 0, 0));
            normals.Add(new Vector3(1, 0, 0));
            normals.Add(new Vector3(1, 0, 0));
            normals.Add(new Vector3(1, 0, 0));
            normals.Add(new Vector3(-1,0,0));
            normals.Add(new Vector3(-1,0,0));
            normals.Add(new Vector3(-1,0,0));
            normals.Add(new Vector3(-1,0,0));
            normals.Add(new Vector3(0,1,0));
            normals.Add(new Vector3(0,1,0));
            normals.Add(new Vector3(0,1,0));
            normals.Add(new Vector3(0,1,0));
            normals.Add(new Vector3(0,-1,0));
            normals.Add(new Vector3(0,-1,0));
            normals.Add(new Vector3(0,-1,0));
            normals.Add(new Vector3(0,-1,0));
            normals.Add(new Vector3(0,0,1));
            normals.Add(new Vector3(0,0,1));
            normals.Add(new Vector3(0,0,1));
            normals.Add(new Vector3(0,0,1));
            normals.Add(new Vector3(0,0,-1));
            normals.Add(new Vector3(0,0,-1));
            normals.Add(new Vector3(0,0,-1));
            normals.Add(new Vector3(0,0,-1));

            vertexIndices = new List<uint>(new uint[] {
                0,2,1,
                2,3,1,
                4,6,5,
                6,7,5,
                8,10,9,
                10,11,9,
                12,14,13,
                14,15,13,
                16,18,17,
                18,19,17,
                20,22,21,
                22,23,21
            });
            init();
        }



        public void createBall(float percent = 1)
        {
            delete();

            int sharpness = Window.ROUND_OBJECT_DETAIL_LEVEL;
            int hCount = sharpness;
            int vCount = sharpness;
            float radius = 0.5f;
            float divide = 1 / percent;
            float PI = (float)Math.PI;
            float hStep = 2 * PI / hCount;
            float vStep = PI / vCount;
            float hAngle, vAngle;

            for (int i = 0; i <= vCount; i++)
            {
                vAngle = PI / 2 - i * vStep;

                for (int j = 0; j <= hCount / divide; j++)
                {
                    hAngle = j * hStep;

                    float x = radius * (float)Math.Cos(vAngle) * (float)Math.Cos(hAngle);
                    float y = radius * (float)Math.Cos(vAngle) * (float)Math.Sin(hAngle);
                    float z = radius * (float)Math.Sin(vAngle);

                    //patch rotation dibawah
                    vertices.Add(new Vector3(x, -z, y));
                    normals.Add(new Vector3(x, -z, y));

                    //vertices.Add(new Vector3(x, y, z));
                    //normals.Add(new Vector3(x, y, z));
                }
            }
            vertices.Add(new Vector3(0, 0, 0));
            normals.Add(new Vector3(0, 1, 0));

            uint k1, k2;
            for (int i = 0; i < vCount; i++)
            {
                k1 = (uint)i * ((uint)(hCount / divide) + 1);
                k2 = (uint)k1 + (uint)(hCount / divide) + 1;

                for (int j = 0; j < hCount / divide; j++, k1++, k2++)
                {
                    if (i != 0)
                    {
                        vertexIndices.Add(k1);
                        vertexIndices.Add(k2);
                        vertexIndices.Add(k1 + 1);
                    }

                    if (i != (vCount - 1))
                    {
                        vertexIndices.Add(k1 + 1);
                        vertexIndices.Add(k2);
                        vertexIndices.Add(k2 + 1);
                    }

                    if (percent < 1.0f)
                    {
                        vertexIndices.Add(k1);
                        vertexIndices.Add((uint)(vertices.Count - 1));
                        vertexIndices.Add(k1 + 1);

                        vertexIndices.Add(k1 + 1);
                        vertexIndices.Add((uint)(vertices.Count - 1));
                        vertexIndices.Add(k2 + 1);
                    }
                }
            }
            init();
            //rotateX(90f);
            centerOrigin();
        }

        public void createCylinder(float percent = 1, float topdia = 1)
        {
            delete();
            float length = 1;
            float botdia = 1;
            int sharpness = Window.ROUND_OBJECT_DETAIL_LEVEL;
            int hCount = sharpness;
            int vCount = 1;
            float divide = 1 / percent;
            float PI = (float)Math.PI;
            float hStep = 2 * PI / hCount;
            float vStep = length / vCount;
            float hAngle, vAngle;

            for (int i = 0; i <= vCount; i++)
            {
                vAngle = i * vStep;

                for (int j = 0; j <= hCount / divide; j++)
                {
                    hAngle = j * hStep;
                    float x = 0;
                    float y = 0;
                    if (i == 0)
                    {
                        x = topdia / 2 * (float)Math.Cos(hAngle);
                        y = topdia / 2 * (float)Math.Sin(hAngle);
                    }
                    else if (i == 1)
                    {
                        x = botdia / 2 * (float)Math.Cos(hAngle);
                        y = botdia / 2 * (float)Math.Sin(hAngle);
                    }

                    float z = vAngle - length / 2;

                    //patch rotation dibawah
                    vertices.Add(new Vector3(x, -z, y));
                    normals.Add(new Vector3(x, -z, y));

                    //vertices.Add(new Vector3(x, y, z));
                    //normals.Add(new Vector3(x, y, z));
                }
            }

            vertices.Add(new Vector3(0, length / 2, 0));
            normals.Add(new Vector3(0, 1, 0));

            vertices.Add(new Vector3(0, -length / 2, 0));
            normals.Add(new Vector3(0, -1, 0));

            //vertices.Add(new Vector3(0, 0, -length / 2));
            //normals.Add(new Vector3(0, 0, -length / 2));

            //vertices.Add(new Vector3(0, 0, length / 2));
            //normals.Add(new Vector3(0, 0, length / 2));

            uint k1, k2;
            for (int i = 0; i < vCount; i++)
            {
                k1 = (uint)i * ((uint)(hCount / divide) + 1);
                k2 = (uint)k1 + (uint)(hCount / divide) + 1;

                for (int j = 0; j < hCount / divide; j++, k1++, k2++)
                {
                    vertexIndices.Add(k1);
                    vertexIndices.Add(k2);
                    vertexIndices.Add(k1 + 1);

                    vertexIndices.Add(k1 + 1);
                    vertexIndices.Add(k2);
                    vertexIndices.Add(k2 + 1);

                    if (i == 0)
                    {
                        vertexIndices.Add(k1);
                        vertexIndices.Add((uint)vertices.Count - 2);
                        vertexIndices.Add(k1 + 1);

                    }

                    vertexIndices.Add(k2);
                    vertexIndices.Add((uint)vertices.Count - 1);
                    vertexIndices.Add(k2 + 1);
                }
            }

            init();
            //rotateX(90f);
            centerOrigin();
        }

        public void createCone(float percent = 1)
        {
            createCylinder(percent, 0);
        }

        //public void createCapsule(float length = 1, float percent = 1)
        //{

        //    delete();

        //    addChild(new Object(name + ".top"));
        //    lastChild().createBall(0.5f);
        //    lastChild().rotateZ(180.0f);
        //    lastChild().translateY(0.5f);
        //    lastChild().centerOrigin();

        //    addChild(new Object(name + ".mid"));
        //    lastChild().createCylinder();
        //    lastChild().scaleZ(0.5f);
        //    lastChild().rotateX(90.0f);
        //    lastChild().centerOrigin();

        //    addChild(new Object(name + ".bot"));
        //    lastChild().createBall(0.5f);
        //    lastChild().rotateZ(0);
        //    lastChild().translateY(-0.5f);
        //    lastChild().centerOrigin();

        //    rotateX(90f);
        //    centerOrigin();
        //}

        public void createTorus(float percent = 1, float tubedia = 1f)
        {
            delete();
            float torusdia = 1f;
            tubedia = 0.25f * tubedia;
            int sharpness = Window.ROUND_OBJECT_DETAIL_LEVEL;
            int hCount = sharpness;
            int vCount = sharpness;
            float divide = 1 / percent;
            float PI = (float)Math.PI;
            float hStep = 2 * PI / hCount;
            float vStep = 2 * PI / vCount;
            float hAngle, vAngle;

            for (int i = 0; i <= vCount; i++)
            {
                vAngle = i * vStep;

                for (int j = 0; j <= hCount / divide; j++)
                {
                    hAngle = j * hStep;
                    float x = 0;
                    float y = 0;

                    x = (torusdia / 2 + tubedia / 2 * (float)Math.Cos(vAngle)) * (float)Math.Cos(hAngle);
                    y = (torusdia / 2 + tubedia / 2 * (float)Math.Cos(vAngle)) * (float)Math.Sin(hAngle);

                    float z = tubedia / 2 * (float)Math.Sin(vAngle);

                    //patch rotation dibawah
                    vertices.Add(new Vector3(x, -z, y));
                    normals.Add(new Vector3(x, -z, y));

                    //vertices.Add(new Vector3(x, y, z));
                    //normals.Add(new Vector3(x, y, z));
                }
            }

            uint k1, k2;
            for (int i = 0; i < vCount; i++)
            {
                k1 = (uint)i * ((uint)(hCount / divide) + 1);
                k2 = (uint)k1 + (uint)(hCount / divide) + 1;
                for (int j = 0; j < hCount / divide; j++, k1++, k2++)
                {
                    vertexIndices.Add(k1);
                    vertexIndices.Add(k2);
                    vertexIndices.Add(k1 + 1);

                    vertexIndices.Add(k1 + 1);
                    vertexIndices.Add(k2);
                    vertexIndices.Add(k2 + 1);
                }
            }

            init();
            //rotateX(90f);
            centerOrigin();
        }

        public void createPlane()
        {

            delete();

            //dua sisi biar normalsnya bagus

            vertices.Add(new Vector3(0.5f,-0.005f, 0.5f));
            vertices.Add(new Vector3(0.5f, -0.005f, -0.5f));
            vertices.Add(new Vector3(-0.5f, -0.005f, 0.5f));
            vertices.Add(new Vector3(-0.5f, -0.005f, -0.5f));

            vertices.Add(new Vector3(0.5f, 0.005f, 0.5f));
            vertices.Add(new Vector3(0.5f, 0.005f, -0.5f));
            vertices.Add(new Vector3(-0.5f, 0.005f, 0.5f));
            vertices.Add(new Vector3(-0.5f, 0.005f, -0.5f));

            normals.Add(new Vector3(0, -1, 0));
            normals.Add(new Vector3(0, -1, 0));
            normals.Add(new Vector3(0, -1, 0));
            normals.Add(new Vector3(0, -1, 0));
            normals.Add(new Vector3(0, 1, 0));
            normals.Add(new Vector3(0, 1, 0)); 
            normals.Add(new Vector3(0, 1, 0));
            normals.Add(new Vector3(0, 1, 0));

            vertexIndices = new List<uint>(new uint[] {
                0, 1, 3,
                0, 3, 2,
                4, 5, 7,
                4, 7, 6
            });
            init();
        }

        public void createTriangle(bool right = false)
        {

            //dua sisi biar normalsnya bagus

            delete();
            if (!right)
            {
                vertices.Add(new Vector3(0.5f,-0.005f, -0.5f));
                vertices.Add(new Vector3(0.5f, -0.005f, 0.5f));
                vertices.Add(new Vector3(-0.5f, -0.005f, 0));

                vertices.Add(new Vector3(0.5f, 0.005f, -0.5f));
                vertices.Add(new Vector3(0.5f, 0.005f, 0.5f));
                vertices.Add(new Vector3(-0.5f, 0.005f, 0));
            }
            else
            {
                vertices.Add(new Vector3(0.5f, -0.005f, -0.5f));
                vertices.Add(new Vector3(0.5f, -0.005f, 0.5f));
                vertices.Add(new Vector3(-0.5f, -0.005f, 0.5f));

                vertices.Add(new Vector3(0.5f, 0.005f, -0.5f));
                vertices.Add(new Vector3(0.5f, 0.005f, 0.5f));
                vertices.Add(new Vector3(-0.5f, 0.005f, 0.5f));
            }

            normals.Add(new Vector3(0, -1, 0));
            normals.Add(new Vector3(0, -1, 0));
            normals.Add(new Vector3(0, -1, 0));

            normals.Add(new Vector3(0, 1, 0));
            normals.Add(new Vector3(0, 1, 0));
            normals.Add(new Vector3(0, 1, 0));


            vertexIndices = new List<uint>(new uint[] {
               0,1,2,
               3,4,5
            });

            init();
        }

        public void createCircle(float percent = 1)
        {

            //dua sisi biar normalsnya bagus

            delete();
            int sharpness = Window.ROUND_OBJECT_DETAIL_LEVEL;
            int hCount = sharpness;
            float divide = 1 / percent;
            float PI = (float)Math.PI;
            float hStep = 2 * PI / hCount;
            float hAngle;


            for (int j = 0; j <= hCount / divide; j++)
            {
                hAngle = j * hStep;
                float x = 0;
                float y = 0;

                x = (float)0.5 * (float)Math.Cos(hAngle);
                y = (float)0.5 * (float)Math.Sin(hAngle);

                float z = -0.005f;

                //patch rotation dibawah
                vertices.Add(new Vector3(x, -z, y));
                normals.Add(new Vector3(0,-1,0));
                //vertices.Add(new Vector3(x, y, z));
                //normals.Add(new Vector3(x, y, z));
            }

            vertices.Add(new Vector3(0, 0, 0));
            normals.Add(new Vector3(0, -1, 0));

            for (int j = 0; j <= hCount / divide; j++)
            {
                hAngle = j * hStep;
                float x = 0;
                float y = 0;

                x = (float)0.5 * (float)Math.Cos(hAngle);
                y = (float)0.5 * (float)Math.Sin(hAngle);

                float z = 0.005f;

                //patch rotation dibawah
                vertices.Add(new Vector3(x, -z, y));
                normals.Add(new Vector3(0, 1, 0));
                //vertices.Add(new Vector3(x, y, z));
                //normals.Add(new Vector3(x, y, z));
            }

            vertices.Add(new Vector3(0, 0, 0));
            normals.Add(new Vector3(0,1,0));

            uint k1 = 0, k2 = 1;
            for (int j = 0; j < hCount / divide; j++, k1++, k2++)
            {
                vertexIndices.Add(k1);
                vertexIndices.Add((uint)(vertices.Count/2.0f - 1));
                vertexIndices.Add(k2);
            }

            k1 = (uint)(vertices.Count / 2.0f);
            k2 = (uint)(vertices.Count / 2.0f);
            for (int j = 0; j < hCount / divide; j++, k1++, k2++)
            {
                vertexIndices.Add(k1);
                vertexIndices.Add((uint)(vertices.Count - 1));
                vertexIndices.Add(k2);
            }

            init();
            //rotateX(90f);
            centerOrigin();
        }



        public void createTerrain(float bumpyness = 0.1f, float detail = 3, int seed = 0)
        {

            if (detail >= 3)
            {
                delete();
                List<List<Vector3>> planePoints = new List<List<Vector3>>();

                Random rand = new Random();
                if (seed != 0)
                    rand = new Random(seed);

                float curvedetail = Window.ROUND_OBJECT_DETAIL_LEVEL;
                float xdet = detail;
                float ydet = detail;
                float xstep = 1 / (xdet - 1);
                float ystep = 1 / (ydet - 1);
                float xdif, ydif;

                for (int i = 0; i < ydet; i++)
                {
                    ydif = i * ystep - 0.5f;
                    List<Vector3> xPlanePoints = new List<Vector3>();
                    for (int j = 0; j < xdet; j++)
                    {
                        xdif = j * xstep - 0.5f;
                        float x = xdif;
                        float y = ydif;

                        float z = (float)(rand.NextDouble() - 0.5) * bumpyness / 2;
                        xPlanePoints.Add(new Vector3(x, y, z));
                    }
                    planePoints.Add(xPlanePoints);
                }

                // curving y axis
                List<List<Vector3>> curvedXPoints = new List<List<Vector3>>();
                foreach (var xPoints in planePoints)
                {
                    curvedXPoints.Add(generateBezier(xPoints, 1, curvedetail));
                }

                // curving x axis and store to temp
                List<List<Vector3>> allCurved = new List<List<Vector3>>();
                for (int i = 0; i < curvedXPoints[0].Count; i++)
                {
                    List<Vector3> yPlanePoints = new List<Vector3>();
                    for (int j = 0; j < curvedXPoints.Count; j++)
                    {
                        yPlanePoints.Add(curvedXPoints[j][i]);
                    }
                    allCurved.Add(generateBezier(yPlanePoints, 0, curvedetail));
                }

                for (int i = 0; i < allCurved[0].Count; i++)
                {
                    for (int j = 0; j < allCurved.Count; j++)
                    {
                        //vertices.Add(allCurved[j][i]);
                        //normals.Add(allCurved[j][i]);
                        //patch rotation dibawah
                        vertices.Add(new Vector3(allCurved[j][i].X, -allCurved[j][i].Z, allCurved[j][i].Y));
                        normals.Add(new Vector3(0,1,0));
                        //normals.Add(new Vector3(allCurved[j][i].X, -allCurved[j][i].Z, allCurved[j][i].Y));
                    }
                }

                uint k1, k2;
                for (int i = 0; i < allCurved[0].Count; i++)
                {
                    k1 = (uint)i * ((uint)(allCurved.Count));
                    k2 = (uint)k1 + (uint)(allCurved.Count);

                    for (int j = 0; j < allCurved.Count; j++, k1++, k2++)
                    {
                        if (i < allCurved[0].Count - 1 && j < allCurved.Count - 1)
                        {
                            vertexIndices.Add(k2 + 1);
                            vertexIndices.Add(k1 + 1);
                            vertexIndices.Add(k1);

                            vertexIndices.Add(k1);
                            vertexIndices.Add(k2);
                            vertexIndices.Add(k2 + 1);
                        }

                    }
                }

                init();
                //rotateX(90f);
                centerOrigin();
            }
        }

        public void createFreeformTube(List<Vector2> path, float percent = 1, float tubedia = 0.2f)
        {
            delete();
            int sharpness = Window.ROUND_OBJECT_DETAIL_LEVEL * 10;
            int hCount = sharpness;
            float divide = 1 / percent;
            float PI = (float)Math.PI;
            float hStep = 2 * PI / hCount;
            float hAngle, firstAngle = 0, lastAngle = 0;
            Quaternion rotfix = new Quaternion(0.7071068f, 0.7071068f, 0, 0);

            //smoothify path 
            path = generateBezier(path, sharpness);
            int vCount = path.Count;

            for (int i = 0; i < vCount; i++)
            {
                for (int j = 0; j <= hCount / divide; j++)
                {
                    hAngle = j * hStep;
                    float x = 0;
                    float y = 0;

                    x = 0 + tubedia / 2 * (float)Math.Cos(hAngle);
                    y = path[i].X + tubedia / 2 * (float)Math.Sin(hAngle);

                    float z = path[i].Y;
                    if (i == 0)
                    {
                        firstAngle = (float)Math.Atan2((path[i + 1].X - path[i].X), (path[i + 1].Y - path[i].Y));
                    }
                    if (i != vCount - 1)
                    {
                        lastAngle = (float)Math.Atan2((path[i + 1].X - path[i].X), (path[i + 1].Y - path[i].Y));
                    }
                    Vector3 temp = new Vector3(x, y, z);
                    //x always 0, no correction needed
                    Vector3 clone = new Vector3(temp);
                    temp = temp + new Vector3(0, -path[i].X, -clone.Z);
                    temp = new Vector3(new Vector4(temp, 1f) * Matrix4.CreateRotationX(-lastAngle));
                    temp = temp + new Vector3(0, path[i].X, clone.Z);
                    //patch rotation dibawah
                    temp *= Matrix3.CreateFromQuaternion(rotfix);

                    vertices.Add(temp);
                    normals.Add(temp);
                    //vertices.Add(new Vector3(temp.Z, -temp.Y, temp.X));
                    //normals.Add(new Vector3(temp.Z, -temp.Y, temp.X));
                }
            }

            vertices.Add(new Vector3(0, path[0].X, path[0].Y) * Matrix3.CreateFromQuaternion(rotfix));
            normals.Add(new Vector3(0, path[0].X, path[0].Y) * Matrix3.CreateFromQuaternion(rotfix));

            vertices.Add(new Vector3(0, path.Last().X, path.Last().Y) * Matrix3.CreateFromQuaternion(rotfix));
            normals.Add(new Vector3(0, path.Last().X, path.Last().Y) * Matrix3.CreateFromQuaternion(rotfix));

            //vertices.Add(new Vector3(path[0].Y, -path[0].X, 0));
            //normals.Add(new Vector3(path[0].Y, -path[0].X, 0));

            //vertices.Add(new Vector3(path.Last().Y, -path.Last().X, 0));
            //normals.Add(new Vector3(path.Last().Y, -path.Last().X, 0));

            uint k1, k2;
            for (int i = 0; i < vCount; i++)
            {
                k1 = (uint)i * ((uint)(hCount / divide) + 1);
                k2 = (uint)k1 + (uint)(hCount / divide) + 1;

                for (int j = 0; j < hCount / divide; j++, k1++, k2++)
                {
                    if (i != vCount - 1)
                    {
                        vertexIndices.Add(k1);
                        vertexIndices.Add(k2);
                        vertexIndices.Add(k1 + 1);

                        vertexIndices.Add(k1 + 1);
                        vertexIndices.Add(k2);
                        vertexIndices.Add(k2 + 1);
                    }
                    if (i == 0)
                    {
                        vertexIndices.Add(k1);
                        vertexIndices.Add((uint)vertices.Count - 2);
                        vertexIndices.Add(k1 + 1);

                    }
                    else if (i == vCount - 1)
                    {
                        vertexIndices.Add(k1);
                        vertexIndices.Add((uint)vertices.Count - 1);
                        vertexIndices.Add(k1 + 1);
                    }
                }
            }

            //rotateX(180);
            //rotateY(90);
            init();
            centerOrigin();
        }

        // misc tool functions
        private static int bCoeff(int n, int k)
        {
            int res = 1;

            if (k > n - k)
                k = n - k;

            for (int i = 0; i < k; ++i)
            {
                res *= (n - i);
                res /= (i + 1);
            }
            return res;
        }

        private static Vector2 setBezier(List<Vector2> parr, float t)
        {
            Vector2 resvect;
            resvect.X = 0;
            resvect.Y = 0;

            for (int i = 0; i < parr.Count; i++)
            {
                resvect.X += bCoeff(parr.Count - 1, i) * (float)Math.Pow((1 - t), parr.Count - 1 - i) * (float)Math.Pow(t, i) * parr[i].X;
                resvect.Y += bCoeff(parr.Count - 1, i) * (float)Math.Pow((1 - t), parr.Count - 1 - i) * (float)Math.Pow(t, i) * parr[i].Y;
            }

            return resvect;
        }

        private static List<Vector3> generateBezier(List<Vector3> parr, int nullify, float detail = 10)
        {
            List<Vector3> res = new List<Vector3>();
            List<Vector2> app = new List<Vector2>();
            List<Vector2> proc = new List<Vector2>();
            float storedim = 0;

            foreach (var points in parr)
            {
                if (nullify == 0)
                {
                    app.Add(new Vector2(points.Y, points.Z));
                    storedim = points.X;
                }
                else if (nullify == 1)
                {
                    app.Add(new Vector2(points.X, points.Z));
                    storedim = points.Y;
                }
                else
                {
                    app.Add(new Vector2(points.X, points.Y));
                    storedim = points.Z;
                }
            }

            for (float t = 0.0f; t <= 1.0f; t += 1 / detail)
            {
                proc.Add(setBezier(app, t));
            }

            foreach (var points in proc)
            {
                if (nullify == 0)
                {
                    res.Add(new Vector3(storedim, points.X, points.Y));
                }
                else if (nullify == 1)
                {
                    res.Add(new Vector3(points.X, storedim, points.Y));
                }
                else
                {
                    res.Add(new Vector3(points.X, points.Y, storedim));
                }
            }

            return res;
        }

        private static List<Vector2> generateBezier(List<Vector2> parr, float detail = 10)
        {
            List<Vector2> proc = new List<Vector2>();

            for (float t = 0.0f; t <= 1.0f; t += 1 / detail)
            {
                proc.Add(setBezier(parr, t));
            }

            return proc;
        }
    }
}
