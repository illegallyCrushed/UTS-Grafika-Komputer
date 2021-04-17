using System;
using System.Collections.Generic;
using System.Text;
using OpenTK.Mathematics;

namespace UTS
{
    class Nicholas
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
            scene.addChild(new Object("Awan.001"));
            scene.lastChild().createBall();
            scene.lastChild().scale(2.58855f, 1.75335f, 1.33258f);
            scene.lastChild().rotateQ(0.79691f, 0.08030f, 0.02969f, -0.59801f);
            scene.lastChild().translate(-0.84614f, 5.14307f, 14.38020f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(1.00000f, 1.00000f, 1.00000f);

            scene.addChild(new Object("Awan.002"));
            scene.lastChild().createBall();
            scene.lastChild().scale(2.09333f, 1.41791f, 1.07764f);
            scene.lastChild().rotateQ(0.79691f, 0.08030f, 0.02969f, -0.59801f);
            scene.lastChild().translate(-1.47981f, 6.86393f, 15.27800f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(1.00000f, 1.00000f, 1.00000f);

            scene.addChild(new Object("Awan.003"));
            scene.lastChild().createBall();
            scene.lastChild().scale(2.09333f, 1.41791f, 1.07764f);
            scene.lastChild().rotateQ(0.79691f, 0.08030f, 0.02969f, -0.59801f);
            scene.lastChild().translate(-1.42335f, 7.67760f, 14.20910f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(1.00000f, 1.00000f, 1.00000f);

            scene.addChild(new Object("Awan.006"));
            scene.lastChild().createBall();
            scene.lastChild().scale(2.38547f, 1.02670f, 0.78031f);
            scene.lastChild().rotateQ(0.88547f, 0.11449f, 0.00394f, -0.45036f);
            scene.lastChild().translate(-6.60263f, -7.98543f, 8.78807f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(1.00000f, 1.00000f, 1.00000f);

            scene.addChild(new Object("Awan.005"));
            scene.lastChild().createBall();
            scene.lastChild().scale(1.63942f, 0.83028f, 0.63103f);
            scene.lastChild().rotateQ(0.89313f, 0.09758f, 0.00928f, -0.43900f);
            scene.lastChild().translate(-7.09028f, -7.58888f, 9.58345f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(1.00000f, 1.00000f, 1.00000f);

            scene.addChild(new Object("Awan.004"));
            scene.lastChild().createBall();
            scene.lastChild().scale(1.22578f, 0.83028f, 0.63103f);
            scene.lastChild().rotateQ(0.88547f, 0.11449f, 0.00394f, -0.45036f);
            scene.lastChild().translate(-7.29405f, -6.70196f, 9.02701f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(1.00000f, 1.00000f, 1.00000f);

            scene.addChild(new Object("Awan.007"));
            scene.lastChild().createBall();
            scene.lastChild().scale(3.01242f, 0.72038f, 0.66750f);
            scene.lastChild().rotateQ(0.41887f, -0.28102f, 0.38085f, -0.77494f);
            scene.lastChild().translate(-9.69324f, 3.38415f, 12.10990f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(1.00000f, 1.00000f, 1.00000f);

            scene.addChild(new Object("Awan.008"));
            scene.lastChild().createBall();
            scene.lastChild().scale(1.33242f, 0.72038f, 0.54750f);
            scene.lastChild().rotateQ(0.41887f, -0.28102f, 0.38085f, -0.77494f);
            scene.lastChild().translate(-9.03657f, 4.22907f, 12.59100f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(1.00000f, 1.00000f, 1.00000f);

            scene.addChild(new Object("Awan"));
            scene.lastChild().createBall();
            scene.lastChild().scale(1.67211f, 0.97935f, 0.80967f);
            scene.lastChild().rotateQ(0.41887f, -0.28102f, 0.38085f, -0.77494f);
            scene.lastChild().translate(-10.37290f, 2.66747f, 12.84630f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(1.00000f, 1.00000f, 1.00000f);

            scene.addChild(new Object("PelangiBlue"));
            scene.lastChild().createTorus(0.5f, 0.25f);
            scene.lastChild().scale(8.19613f, 8.19613f, 8.19613f);
            scene.lastChild().rotateQ(0.49332f, -0.28521f, 0.64466f, -0.50961f);
            scene.lastChild().translate(-3.92839f, -0.03614f, 11.86033f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(0.00000f, 0.00000f, 1.00000f);

            scene.addChild(new Object("PelangiGreen"));
            scene.lastChild().createTorus(0.5f, 0.25f);
            scene.lastChild().scale(8.53725f, 8.19613f, 8.19613f);
            scene.lastChild().rotateQ(0.49332f, -0.28521f, 0.64466f, -0.50961f);
            scene.lastChild().translate(-4.06628f, -0.26662f, 12.40329f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(0.00000f, 1.00000f, 0.00000f);

            scene.addChild(new Object("PelangiRed"));
            scene.lastChild().createTorus(0.5f, 0.25f);
            scene.lastChild().scale(8.81015f, 8.19613f, 8.19613f);
            scene.lastChild().rotateQ(0.49332f, -0.28521f, 0.64466f, -0.50961f);
            scene.lastChild().translate(-4.12691f, -0.52018f, 12.85885f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(1.00000f, 0.00000f, 0.00000f);

            scene.addChild(new Object("BalokRumah"));
            scene.lastChild().createCube();
            scene.lastChild().scale(1.52000f, 3.28000f, 1.42893f);
            scene.lastChild().rotateQ(0.70711f, 0.00000f, 0.00000f, 0.70711f);
            scene.lastChild().translate(-4.23960f, 6.14272f, 1.41289f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(1.0f, 1.0f, 0.0f);

            scene.addChild(new Object("BalokRumah.002"));
            scene.lastChild().createCube();
            scene.lastChild().scale(0.71000f, 0.43000f, 0.62893f);
            scene.lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
            scene.lastChild().translate(-3.80779f, 4.25080f, 0.60289f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(1.0f, 1.0f, 0.0f);

            scene.addChild(new Object("BalokRumah.001"));
            scene.lastChild().createCube();
            scene.lastChild().scale(1.52000f, 3.28000f, 1.42893f);
            scene.lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
            scene.lastChild().translate(-6.01779f, 4.39080f, 1.41289f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(1.0f, 1.0f, 0.0f);

            scene.addChild(new Object("BalokRumah.003"));
            scene.lastChild().createCube();
            scene.lastChild().scale(1.00000f, 0.59000f, 0.85893f);
            scene.lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
            scene.lastChild().translate(-6.53779f, 0.58080f, 0.83289f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(1.0f, 1.0f, 0.0f);

            scene.addChild(new Object("AtapKecil.001"));
            scene.lastChild().createPlane();
            scene.lastChild().scale(1.19000f, 0.73000f, 1.00000f);
            scene.lastChild().rotateQ(0.96126f, 0.27564f, 0.00000f, 0.00000f);
            scene.lastChild().translate(-6.55680f, 0.48981f, 2.00650f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(1.0f, 1.0f, 0.0f);

            scene.addChild(new Object("AtapBesar.002"));
            scene.lastChild().createPlane();
            scene.lastChild().scale(2.65000f, 1.47000f, 1.00000f);
            scene.lastChild().rotateQ(0.64086f, 0.29884f, -0.29884f, -0.64086f);
            scene.lastChild().translate(-6.96441f, 3.47213f, 3.53605f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(1.0f, 1.0f, 0.0f);

            scene.addChild(new Object("AtapBesar.001"));
            scene.lastChild().createPlane();
            scene.lastChild().scale(2.65000f, 1.47000f, 1.00000f);
            scene.lastChild().rotateQ(0.64086f, 0.29884f, 0.29884f, 0.64086f);
            scene.lastChild().translate(-5.07441f, 3.47213f, 3.53605f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(1.0f, 1.0f, 0.0f);

            scene.addChild(new Object("AtapBesar"));
            scene.lastChild().createPlane();
            scene.lastChild().scale(2.65000f, 1.47000f, 1.00000f);
            scene.lastChild().rotateQ(0.00099f, 0.00046f, 0.42262f, 0.90631f);
            scene.lastChild().translate(-3.28698f, 7.07217f, 3.57013f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(1.0f, 1.0f, 0.0f);

            scene.addChild(new Object("AtapBesar.003"));
            scene.lastChild().createPlane();
            scene.lastChild().scale(2.65000f, 1.47000f, 1.00000f);
            scene.lastChild().rotateQ(0.90631f, 0.42262f, -0.00046f, -0.00099f);
            scene.lastChild().translate(-3.29112f, 5.18217f, 3.57013f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(1.0f, 1.0f, 0.0f);

            scene.addChild(new Object("CerobongAsap"));
            scene.lastChild().createCube();
            scene.lastChild().scale(0.38000f, 0.37000f, 1.31893f);
            scene.lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
            scene.lastChild().translate(-6.12266f, 6.21784f, 4.36146f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(1.0f, 1.0f, 0.0f);

            scene.addChild(new Object("DindingSegitiga.001"));
            scene.lastChild().createTriangle();
            scene.lastChild().scale(0.93000f, 1.55000f, 1.00000f);
            scene.lastChild().rotateQ(0.70711f, 0.00000f, 0.70711f, 0.00000f);
            scene.lastChild().translate(-0.97175f, 6.13870f, 3.75145f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(1.0f, 1.0f, 0.0f);

            scene.addChild(new Object("DindingSegitiga"));
            scene.lastChild().createTriangle();
            scene.lastChild().scale(0.93000f, 1.51000f, 1.00000f);
            scene.lastChild().rotateQ(0.50000f, -0.50000f, 0.50000f, 0.50000f);
            scene.lastChild().translate(-6.01472f, 1.09583f, 3.70850f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(1.0f, 1.0f, 0.0f);

            scene.addChild(new Object("AtapConnect"));
            scene.lastChild().createTriangle(true);
            scene.lastChild().scale(0.90000f, 1.47000f, 1.00000f);
            scene.lastChild().rotateQ(0.64086f, 0.29884f, -0.29884f, -0.64086f);
            scene.lastChild().translate(-6.96441f, 6.96051f, 3.53605f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(1.0f, 1.0f, 0.0f);

            scene.addChild(new Object("AtapConnect.001"));
            scene.lastChild().createTriangle(true);
            scene.lastChild().scale(1.04000f, 1.47000f, 1.00000f);
            scene.lastChild().rotateQ(0.41978f, 0.90762f, 0.00000f, 0.00000f);
            scene.lastChild().translate(-6.96100f, 7.07217f, 3.57013f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(1.0f, 1.0f, 0.0f);

            scene.addChild(new Object("ConnectorAtap"));
            scene.lastChild().createCylinder();
            scene.lastChild().scale(0.15194f, 0.15194f, 1.42194f);
            scene.lastChild().rotateQ(0.38302f, -0.84944f, -0.32289f, 0.16582f);
            scene.lastChild().translate(-7.11177f, 7.21642f, 3.33051f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(1.0f, 1.0f, 0.0f);

            scene.addChild(new Object("ConnectBallAtap"));
            scene.lastChild().createBall();
            scene.lastChild().scale(0.15194f, 0.15119f, 0.15119f);
            scene.lastChild().rotateQ(0.99977f, 0.01269f, -0.01360f, -0.01036f);
            scene.lastChild().translate(-7.85539f, 7.98027f, 2.41101f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(1.0f, 1.0f, 0.0f);

            scene.addChild(new Object("AtapKecil"));
            scene.lastChild().createPlane();
            scene.lastChild().scale(0.75000f, 0.51000f, 1.00000f);
            scene.lastChild().rotateQ(0.25207f, -0.96771f, 0.00000f, 0.00000f);
            scene.lastChild().translate(-3.74787f, 4.18645f, 1.43622f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(1.0f, 1.0f, 0.0f);

            scene.addChild(new Object("DindingSegitiga"));
            scene.lastChild().createTriangle(true);
            scene.lastChild().scale(0.22014f, 0.40166f, 0.18978f);
            scene.lastChild().rotateQ(0.00000f, -0.70711f, 0.00000f, 0.70711f);
            scene.lastChild().translate(-3.09890f, 4.22200f, 1.44175f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(1.0f, 1.0f, 0.0f);

            scene.addChild(new Object("DindingSegitiga.001"));
            scene.lastChild().createTriangle(true);
            scene.lastChild().scale(0.37392f, 0.59102f, 0.27925f);
            scene.lastChild().rotateQ(0.00000f, -0.70711f, 0.00000f, 0.70711f);
            scene.lastChild().translate(-7.53420f, 0.53372f, 2.02718f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(1.0f, 1.0f, 0.0f);

            scene.addChild(new Object("DindingSegitiga.002"));
            scene.lastChild().createTriangle(true);
            scene.lastChild().scale(0.37392f, 0.59102f, 0.27925f);
            scene.lastChild().rotateQ(0.00000f, -0.70711f, 0.00000f, 0.70711f);
            scene.lastChild().translate(-5.53420f, 0.53372f, 2.02718f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(1.0f, 1.0f, 0.0f);

            scene.addChild(new Object("Pohon"));

            { // Children of 'Pohon'

                scene.lastChild().addChild(new Object("BatangPohon"));
                scene.lastChild().lastChild().createCylinder();
                scene.lastChild().lastChild().scale(-0.25413f, -0.25413f, -1.99938f);
                scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
                scene.lastChild().lastChild().translate(0.00000f, 0.00000f, 1.99546f);
                scene.lastChild().lastChild().centerOrigin();
                scene.lastChild().lastChild().setColor(1.0f, 1.0f, 0.0f);

                scene.lastChild().addChild(new Object("CabangPohon"));
                scene.lastChild().lastChild().createCylinder();
                scene.lastChild().lastChild().scale(0.05501f, 0.05501f, 1.07105f);
                scene.lastChild().lastChild().rotateQ(0.94119f, 0.16041f, 0.23142f, -0.18674f);
                scene.lastChild().lastChild().translate(0.60468f, -0.51829f, 3.82823f);
                scene.lastChild().lastChild().centerOrigin();
                scene.lastChild().lastChild().setColor(1.0f, 1.0f, 0.0f);

                scene.lastChild().addChild(new Object("CabangPohon.001"));
                scene.lastChild().lastChild().createCylinder();
                scene.lastChild().lastChild().scale(0.05501f, 0.05501f, 0.49105f);
                scene.lastChild().lastChild().rotateQ(0.91689f, -0.28363f, 0.27890f, -0.03282f);
                scene.lastChild().lastChild().translate(0.38745f, 0.43689f, 4.00314f);
                scene.lastChild().lastChild().centerOrigin();
                scene.lastChild().lastChild().setColor(1.0f, 1.0f, 0.0f);

                scene.lastChild().addChild(new Object("CabangPohon.002"));
                scene.lastChild().lastChild().createCylinder();
                scene.lastChild().lastChild().scale(0.05501f, 0.05501f, 0.57105f);
                scene.lastChild().lastChild().rotateQ(0.34812f, -0.25946f, -0.15753f, 0.88695f);
                scene.lastChild().lastChild().translate(-0.44541f, 0.09240f, 3.75402f);
                scene.lastChild().lastChild().centerOrigin();
                scene.lastChild().lastChild().setColor(1.0f, 1.0f, 0.0f);

                scene.lastChild().addChild(new Object("DaunPohon"));
                scene.lastChild().lastChild().createBall();
                scene.lastChild().lastChild().scale(1.93883f, 1.81343f, 0.73310f);
                scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
                scene.lastChild().lastChild().translate(-0.13095f, 0.78689f, 5.72422f);
                scene.lastChild().lastChild().centerOrigin();
                scene.lastChild().lastChild().setColor(1.0f, 1.0f, 0.0f);

                scene.lastChild().addChild(new Object("DaunPohon.001"));
                scene.lastChild().lastChild().createBall();
                scene.lastChild().lastChild().scale(2.64469f, 2.47364f, 1.00000f);
                scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
                scene.lastChild().lastChild().translate(0.29603f, -0.55908f, 4.93471f);
                scene.lastChild().lastChild().centerOrigin();
                scene.lastChild().lastChild().setColor(1.0f, 1.0f, 0.0f);

            } // Children of 'Pohon'

            scene.lastChild().scale(1.00000f, 1.00000f, 1.00000f);
            scene.lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
            scene.lastChild().translate(4.10321f, -4.96785f, 0.00000f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(1.0f, 1.0f, 0.0f);





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
            //scene.lastChild().scale(3f,3f,10f);
            //scene.lastChild().translate(-2.0f, 0, 5f);
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

            //scene.addChild(new Object("Triangle.001"));
            //scene.lastChild().createTriangle();
            //scene.lastChild().scale(5.0f);
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










            scene.addChild(new Object("Ground-Grass"));
            scene.lastChild().createTerrain(0.5f, 30, 3);
            scene.lastChild().scale(10.0f);
            scene.lastChild().translate(0, 0, 0);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(38/255f, 139/255f, 7/255f);
        }

        public static void Animations(ref Object scene)
        {


            scene.findChild("Pohon").rotateX(-0.05f);

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
