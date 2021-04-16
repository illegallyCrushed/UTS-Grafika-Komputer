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
            scene.lastChild().scale(0.197371f, 0.197371f, 0.769748f);
            scene.lastChild().rotateQ(1.0f, 0, 0, 0);
            scene.lastChild().translate(6.77244f, 5.09273f, 1.31062f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(252/255f, 184/255f, 41/255f);

            scene.addChild(new Object("KakiDepanKiri"));
            scene.lastChild().createCylinder();
            scene.lastChild().scale(0.197371f, 0.197371f, 0.769748f);
            scene.lastChild().rotateQ(1.0f, 0, 0, 0);
            scene.lastChild().translate(6.80996f, 6.02619f, 1.31062f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(252 / 255f, 184 / 255f, 41 / 255f);

            scene.addChild(new Object("KakiBelakangKanan"));
            scene.lastChild().createCylinder();
            scene.lastChild().scale(0.197371f, 0.197371f, 0.769748f);
            scene.lastChild().rotateQ(1.0f, 0, 0, 0);
            scene.lastChild().translate(4.12125f, 5.04282f, 1.36744f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(252 / 255f, 184 / 255f, 41 / 255f);

            scene.addChild(new Object("KakiBelakangKiri"));
            scene.lastChild().createCylinder();
            scene.lastChild().scale(0.197371f, 0.197371f, 0.769748f);
            scene.lastChild().rotateQ(1.0f, 0, 0, 0);
            scene.lastChild().translate(4.07313f, 6.02691f, 1.36744f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(252 / 255f, 184 / 255f, 41 / 255f);

            scene.addChild(new Object("BadanUtama"));
            scene.lastChild().createCylinder();
            scene.lastChild().scale(0.722596f, 0.722596f, 1.8226f);
            scene.lastChild().rotateQ(0.707107f, 0, 0.707107f, 0);
            scene.lastChild().translate(5.48215f, 5.54402f, 2.49499f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(252 / 255f, 184 / 255f, 41 / 255f);

            scene.addChild(new Object("OtotDepan"));
            scene.lastChild().createBall();
            scene.lastChild().scale(1.28f, 0.84f, 0.93f);
            scene.lastChild().rotateQ(1.0f, 0, 0, 0);
            scene.lastChild().translate(6.39464f, 5.52542f, 2.48315f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(252 / 255f, 184 / 255f, 41 / 255f);

            scene.addChild(new Object("OtotBelakang"));
            scene.lastChild().createBall();
            scene.lastChild().scale(1.51f, 0.78f, 0.99f);
            scene.lastChild().rotateQ(1.0f, 0, 0, 0);
            scene.lastChild().translate(4.84464f, 5.56542f, 2.48315f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(252 / 255f, 184 / 255f, 41 / 255f);

            scene.addChild(new Object("BokongKanan"));
            scene.lastChild().createBall(0.5f);
            scene.lastChild().scale(0.59f, 0.68f, 0.66f);
            scene.lastChild().rotateQ(0.704252f, -0.063472f, -0.063472f, -0.704252f);
            scene.lastChild().translate(3.88432f, 5.33234f, 2.50868f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(252 / 255f, 184 / 255f, 41 / 255f);

            scene.addChild(new Object("BokongKiri"));
            scene.lastChild().createBall(0.5f);
            scene.lastChild().scale(0.59f, 0.68f, 0.66f);
            scene.lastChild().rotateQ(0.704252f, -0.063472f, -0.063472f, -0.704252f);
            scene.lastChild().translate(3.88432f, 5.77234f, 2.49868f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(252 / 255f, 184 / 255f, 41 / 255f);

            scene.addChild(new Object("Leher"));
            scene.lastChild().createCylinder();
            scene.lastChild().scale(-0.373297f, -0.373297f, -0.753297f);
            scene.lastChild().rotateQ(1.0f, 0, 0, 0);
            scene.lastChild().translate(7.05128f, 5.55019f, 3.59534f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(252 / 255f, 184 / 255f, 41 / 255f);

            scene.addChild(new Object("MulutBawah"));
            scene.lastChild().createCylinder();
            scene.lastChild().scale(0.643924f, 0.643924f, 0.07605f);
            scene.lastChild().rotateQ(1.0f, 0, 0, 0);
            scene.lastChild().translate(7.34f, 5.54f, 3.83f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(252 / 255f, 184 / 255f, 41 / 255f);

            scene.addChild(new Object("MulutAtas"));
            scene.lastChild().createCylinder();
            scene.lastChild().scale(0.824054f, 0.704054f, 0.097324f);
            scene.lastChild().rotateQ(1.0f, 0, 0, 0);
            scene.lastChild().translate(7.37f, 5.54f, 4.03f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(252 / 255f, 184 / 255f, 41 / 255f);

            scene.addChild(new Object("Kepala"));
            scene.lastChild().createCylinder();
            scene.lastChild().scale(0.564093f, 0.564093f, 0.667131f);
            scene.lastChild().rotateQ(1.0f, 0, 0, 0);
            scene.lastChild().translate(7.24f, 5.54f, 4.77f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(252 / 255f, 184 / 255f, 41 / 255f);

            scene.addChild(new Object("MoncongKepala"));
            scene.lastChild().createCylinder();
            scene.lastChild().scale(0.451286f, 0.451286f, 0.398902f);
            scene.lastChild().rotateQ(0.707107f, 0, -0.707107f, 0);
            scene.lastChild().translate(7.85f, 5.54f, 4.42f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(252 / 255f, 184 / 255f, 41 / 255f);

            scene.addChild(new Object("Hidung"));
            scene.lastChild().createBall(0.5f);
            scene.lastChild().scale(0.42832f, 0.42832f, 0.42832f);
            scene.lastChild().rotateQ(0.707107f, 0, 0, 0.707107f);
            scene.lastChild().translate(8.2084f, 5.53289f, 4.42484f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(0, 0, 0);



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










            scene.addChild(new Object("Ground-Dirt"));
            scene.lastChild().createTerrain(0.5f, 30, 3);
            scene.lastChild().scale(10.0f);
            scene.lastChild().translate(0, 0, 0);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(0.607f, 0.4627f, 0.3255f);
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
