using System;
using System.Collections.Generic;
using System.Text;
using OpenTK.Mathematics;

namespace UTS
{
    class Leonando
    {
        public static void Objects(ref Object scene)
        {
            // ProjectionMatrix = Matrix4.CreateOrthographic(15, 15, 0.1f, 100.0f);

            // test object blender
            // steps:
            // 1. design dek blender
            // 2. buka object properties
            // 3. ganti mode rotation ke quartenion biar gak ngurusi urutan
            // 4. masukno object, location, rotation, scale ke code (contoh dibawah)
            // 5. see the magic
            // -nsv

            scene.addChild(new Object("KakiDepanKanan"));
            scene.lastChild().createCylinder();
            scene.lastChild().scale(0.19737f, 0.19737f, 0.76975f);
            scene.lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
            scene.lastChild().translate(6.77244f, 5.09273f, 1.31062f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(0.98824f, 0.72157f, 0.16078f);

            scene.addChild(new Object("KakiDepanKiri"));
            scene.lastChild().createCylinder();
            scene.lastChild().scale(0.19737f, 0.19737f, 0.76975f);
            scene.lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
            scene.lastChild().translate(6.80996f, 6.02619f, 1.31027f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(0.98824f, 0.72157f, 0.16078f);

            scene.addChild(new Object("KakiBelakangKiri"));
            scene.lastChild().createCylinder();
            scene.lastChild().scale(0.19737f, 0.19737f, 0.76975f);
            scene.lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
            scene.lastChild().translate(4.07313f, 6.02691f, 1.39525f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(0.98824f, 0.72157f, 0.16078f);

            scene.addChild(new Object("KakiBelakangKanan"));
            scene.lastChild().createCylinder();
            scene.lastChild().scale(0.19737f, 0.19737f, 0.76975f);
            scene.lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
            scene.lastChild().translate(4.12125f, 5.04282f, 1.36744f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(0.98824f, 0.72157f, 0.16078f);

            scene.addChild(new Object("Badan"));
            scene.lastChild().createCylinder();
            scene.lastChild().scale(0.72260f, 0.72260f, 1.82260f);
            scene.lastChild().rotateQ(0.70711f, 0.00000f, 0.70711f, 0.00000f);
            scene.lastChild().translate(5.48215f, 5.54402f, 2.49499f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(0.98824f, 0.72157f, 0.16078f);

            scene.addChild(new Object("BadanDepan"));
            scene.lastChild().createBall();
            scene.lastChild().scale(1.28000f, 0.84000f, 0.93000f);
            scene.lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
            scene.lastChild().translate(6.39464f, 5.52542f, 2.48315f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(0.98824f, 0.72157f, 0.16078f);

            scene.addChild(new Object("BadanBelakang"));
            scene.lastChild().createBall();
            scene.lastChild().scale(1.51000f, 0.78000f, 0.99000f);
            scene.lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
            scene.lastChild().translate(4.84464f, 5.56542f, 2.48315f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(0.98824f, 0.72157f, 0.16078f);

            scene.addChild(new Object("PantatKiri"));
            scene.lastChild().createBall(0.5f);
            scene.lastChild().scale(0.59000f, 0.68000f, 0.66000f);
            scene.lastChild().rotateQ(0.70425f, -0.06347f, -0.06347f, -0.70425f);
            scene.lastChild().translate(3.88432f, 5.77234f, 2.49868f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(0.98824f, 0.72157f, 0.16078f);

            scene.addChild(new Object("PantatKanan"));
            scene.lastChild().createBall(0.5f);
            scene.lastChild().scale(0.59000f, 0.68000f, 0.66000f);
            scene.lastChild().rotateQ(0.70425f, -0.06347f, -0.06347f, -0.70425f);
            scene.lastChild().translate(3.88432f, 5.33234f, 2.50868f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(0.98824f, 0.72157f, 0.16078f);

            scene.addChild(new Object("Leher.001"));
            scene.lastChild().createCylinder();
            scene.lastChild().scale(-0.37330f, -0.37330f, -0.75330f);
            scene.lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
            scene.lastChild().translate(7.05128f, 5.55019f, 3.59534f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(0.98824f, 0.72157f, 0.16078f);

            scene.addChild(new Object("MulutBawah"));
            scene.lastChild().createCylinder();
            scene.lastChild().scale(0.64392f, 0.64392f, 0.07605f);
            scene.lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
            scene.lastChild().translate(7.34000f, 5.54000f, 3.83000f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(0.98824f, 0.72157f, 0.16078f);

            scene.addChild(new Object("MoncongHidung"));
            scene.lastChild().createCylinder();
            scene.lastChild().scale(0.45129f, 0.45129f, 0.39890f);
            scene.lastChild().rotateQ(0.70711f, 0.00000f, -0.70711f, 0.00000f);
            scene.lastChild().translate(7.85000f, 5.54000f, 4.42000f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(0.98824f, 0.72157f, 0.16078f);

            scene.addChild(new Object("MulutAtas"));
            scene.lastChild().createCylinder();
            scene.lastChild().scale(0.82405f, 0.70405f, 0.09732f);
            scene.lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
            scene.lastChild().translate(7.37000f, 5.54000f, 4.03000f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(0.98824f, 0.72157f, 0.16078f);

            scene.addChild(new Object("Kepala"));
            scene.lastChild().createCylinder();
            scene.lastChild().scale(0.56409f, 0.56409f, 0.66713f);
            scene.lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
            scene.lastChild().translate(7.24000f, 5.54000f, 4.77000f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(0.98824f, 0.72157f, 0.16078f);

            scene.addChild(new Object("TopiTepi"));
            scene.lastChild().createTorus();
            scene.lastChild().scale(0.56735f, 0.56735f, 0.56735f);
            scene.lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
            scene.lastChild().translate(7.28000f, 5.54000f, 5.33000f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(0.07451f, 0.32157f, 0.50588f);

            scene.addChild(new Object("MataKiri"));
            scene.lastChild().createBall(0.5f);
            scene.lastChild().scale(0.07312f, 0.09312f, 0.09312f);
            scene.lastChild().rotateQ(0.70711f, 0.00000f, 0.00000f, 0.70711f);
            scene.lastChild().translate(7.77840f, 5.63289f, 5.03484f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(1.00000f, 1.00000f, 1.00000f);

            scene.addChild(new Object("TelingaKanan"));
            scene.lastChild().createCube();
            scene.lastChild().scale(0.28000f, 0.06000f, 0.22000f);
            scene.lastChild().rotateQ(0.98277f, -0.18481f, 0.00000f, 0.00000f);
            scene.lastChild().translate(7.21000f, 4.96000f, 4.75000f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(0.31765f, 0.19216f, 0.03922f);

            scene.addChild(new Object("TelingaKiri"));
            scene.lastChild().createCube();
            scene.lastChild().scale(0.28000f, 0.06000f, 0.22000f);
            scene.lastChild().rotateQ(0.98277f, 0.18481f, 0.00000f, 0.00000f);
            scene.lastChild().translate(7.21000f, 6.11000f, 4.75000f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(0.31765f, 0.19216f, 0.03922f);

            scene.addChild(new Object("HidungDepan"));
            scene.lastChild().createBall(0.5f);
            scene.lastChild().scale(0.42832f, 0.42832f, 0.42832f);
            scene.lastChild().rotateQ(0.70711f, 0.00000f, 0.00000f, 0.70711f);
            scene.lastChild().translate(8.20840f, 5.53289f, 4.42484f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(0.08627f, 0.06275f, 0.01290f);

            scene.addChild(new Object("MataKanan"));
            scene.lastChild().createBall(0.5f);
            scene.lastChild().scale(0.07312f, 0.09312f, 0.09312f);
            scene.lastChild().rotateQ(0.70711f, 0.00000f, 0.00000f, 0.70711f);
            scene.lastChild().translate(7.77840f, 5.43289f, 5.03484f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(1.00000f, 1.00000f, 1.00000f);

            scene.addChild(new Object("PupilKiri"));
            scene.lastChild().createBall(0.5f);
            scene.lastChild().scale(0.03591f, 0.02573f, 0.04573f);
            scene.lastChild().rotateQ(0.70711f, 0.00000f, 0.00000f, 0.70711f);
            scene.lastChild().translate(7.85840f, 5.63289f, 5.03484f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(0.00000f, 0.00000f, 0.00000f);

            scene.addChild(new Object("PupilKanan"));
            scene.lastChild().createBall(0.5f);
            scene.lastChild().scale(0.03591f, 0.02573f, 0.04573f);
            scene.lastChild().rotateQ(0.70711f, 0.00000f, 0.00000f, 0.70711f);
            scene.lastChild().translate(7.85840f, 5.43289f, 5.03484f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(0.00000f, 0.00000f, 0.00000f);

            scene.addChild(new Object("Lidah"));
            scene.lastChild().createCylinder();
            scene.lastChild().scale(0.37987f, 0.18635f, 0.06451f);
            scene.lastChild().rotateQ(0.96858f, 0.00000f, 0.24869f, 0.00000f);
            scene.lastChild().translate(7.96000f, 5.51000f, 3.85000f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(0.80000f, 0.04368f, 0.06054f);

            scene.addChild(new Object("Buntut"));
            scene.lastChild().createTorus(0.5f);
            scene.lastChild().scale(1.04584f, 0.51622f, 0.56139f);
            scene.lastChild().rotateQ(0.68953f, 0.68473f, 0.16745f, -0.16629f);
            scene.lastChild().translate(3.09290f, 5.59000f, 3.55000f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(0.98824f, 0.72157f, 0.16078f);

            scene.addChild(new Object("TopiAtas"));
            scene.lastChild().createBall(0.5f);
            scene.lastChild().scale(0.51187f, 0.51187f, 0.51187f);
            scene.lastChild().rotateQ(0.50000f, -0.50000f, -0.50000f, 0.50000f);
            scene.lastChild().translate(7.25840f, 5.53289f, 5.38484f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(0.07451f, 0.32157f, 0.50588f);





            //scene.addChild(new Object("AlasBawah"));
            //scene.lastChild().createCube();
            //scene.lastChild().scale(4.72572f, 6.98252f, 1.24357f);
            //scene.lastChild().rotateQ(0.977971f, -0.07693f, 0.191149f, 0.033437f);
            //scene.lastChild().translate(0.904938f, -2.93781f, -2.07596f);
            //scene.lastChild().centerOrigin();
            //scene.lastChild().setColor(1, 0, 0);

            //scene.addChild(new Object("TorusBelakang"));
            //scene.lastChild().createTorus();
            //scene.lastChild().scale(4.44471f, 4.44471f, 4.44471f);
            //scene.lastChild().rotateQ(0.537345f, -0.344379f, -0.759482f, 0.125895f);
            //scene.lastChild().translate(-1.55693f, -1.52772f, 2.72807f);
            //scene.lastChild().centerOrigin();
            //scene.lastChild().setColor(0, 1, 0);

            //scene.addChild(new Object("CylinderBelakang"));
            //scene.lastChild().createCylinder();
            //scene.lastChild().scale(1f, 1f, 4.37f);
            //scene.lastChild().rotateQ(0.912323f, 0.244885f, 0.316602f, 0.086376f);
            //scene.lastChild().translate(6.54322f, -8.66801f, 1.92454f);
            //scene.lastChild().centerOrigin();
            //scene.lastChild().setColor(0, 0, 1);

            //scene.addChild(new Object("ConeBelakang"));
            //scene.lastChild().createCone();
            //scene.lastChild().scale(2.4855f, 1.43733f, 3.55189f);
            //scene.lastChild().rotateQ(-0.296283f, 0.873758f, 0.374085f, -0.093935f);
            //scene.lastChild().translate(2.38629f, -4.11895f, -0.635218f);
            //scene.lastChild().centerOrigin();
            //scene.lastChild().setColor(1, 0, 1);

            //scene.addChild(new Object("BallBelakang"));
            //scene.lastChild().createBall();
            //scene.lastChild().scale(3.28019f, 1f, 1f);
            //scene.lastChild().rotateQ(0.106523f, 0.676977f, -0.034213f, -0.72745f);
            //scene.lastChild().translate(3.37629f, 0.889843f, 0.593867f);
            //scene.lastChild().centerOrigin();
            //scene.lastChild().setColor(0, 1, 1);

            //scene.addChild(new Object("PlaneBelakang"));
            //scene.lastChild().createPlane();
            //scene.lastChild().scale(7.12102f, 7.12102f, 7.12102f);
            //scene.lastChild().rotateQ(0.634758f, -0.510032f, 0.441492f, -0.376876f);
            //scene.lastChild().translate(-5.96289f, -6.94331f, 4.16836f);
            //scene.lastChild().centerOrigin();
            //scene.lastChild().setColor(1, 1, 0);

            //scene.addChild(new Object("CircleBelakang"));
            //scene.lastChild().createCircle();
            //scene.lastChild().scale(6.48237f, 6.48237f, 6.48237f);
            //scene.lastChild().rotateQ(0.829922f, 0.310495f, 0.463401f, -0.009089f);
            //scene.lastChild().translate(-5.39524f, 6.06731f, 1.73872f);
            //scene.lastChild().centerOrigin();
            //scene.lastChild().setColor(0.5f, 0.25f, 0.75f);

            //scene.addChild(new Object("Torus.001"));
            //scene.lastChild().createTorus(1f);
            //scene.lastChild().scale(1.0f);
            //scene.lastChild().translate(2.0f, 0, 2.0f);
            //scene.lastChild().centerOrigin();

            //scene.addChild(new Object("Capsule.001"));
            //scene.lastChild().createCapsule(1f);
            //scene.lastChild().scale(1.0f);
            //scene.lastChild().translate(-2.0f, 0, -2.0f);
            //scene.lastChild().centerOrigin();

            //scene.addChild(new Object("Cylinder.001"));
            //scene.lastChild().createCylinder();
            //scene.lastChild().scale(1.0f);
            //scene.lastChild().translate(2.0f, 0, -2.0f);
            //scene.lastChild().centerOrigin();

            //scene.addChild(new Object("Cone.001"));
            //scene.lastChild().createCone();
            //scene.lastChild().scale(1.0f);
            //scene.lastChild().translate(-2.0f, 0, 2.0f);
            //scene.lastChild().centerOrigin();

            //scene.addChild(new Object("Ball.001"));
            //scene.lastChild().createBall();
            //scene.lastChild().scale(1.0f);
            //scene.lastChild().translate(-2.0f, 0, 0);
            //scene.lastChild().centerOrigin();

            //scene.addChild(new Object("Plane.001"));
            //scene.lastChild().createPlane();
            //scene.lastChild().scale(1.0f);
            //scene.lastChild().centerOrigin();

            //scene.addChild(new Object("Circle.001"));
            //scene.lastChild().createCircle();
            //scene.lastChild().scale(1.0f);
            //scene.lastChild().centerOrigin();

            //scene.addChild(new Object("Cube.001"));
            //scene.lastChild().createCube();
            //scene.lastChild().scale(1.0f);
            //scene.lastChild().centerOrigin();
            //scene.lastChild().addChild(new Object("Cube.002"));
            //scene.lastChild().lastChild().createCube();
            //scene.lastChild().lastChild().translate(0f, 1f, 0f);
            //scene.lastChild().lastChild().scale(0.5f);
            //scene.lastChild().lastChild().centerOrigin();
        }

        public static void Animations(ref Object scene)
        {
            //scene.findChild("Cube.001").rotateY(-0.2f);
            //scene.findChild("Cube.001").findChild("Cube.002").rotateY(0.4f);
            //scene.findChild("Cube.001").rotateZ(-0.2f);
            //scene.findChild("Cylinder.001").rotateY(-0.2f);
            //scene.findChild("Capsule.001").rotateY(-0.2f);
            //scene.findChild("Torus.001").rotateY(-0.2f);
            //scene.findChild("Cone.001").rotateY(-0.2f);
            //scene.findChild("Ball.001").rotateY(-0.2f);
        }
    }
}
