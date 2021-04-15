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

            scene.addChild(new Object("BatangPohon"));
            scene.lastChild().createCylinder();
            scene.lastChild().scale(0.254126f, 0.254126f, -2.85938f);
            scene.lastChild().rotateQ(1.0f,0,0,0);
            scene.lastChild().translate(4.10321f, -4.96785f, 2.69006f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(105/255.0f, 75/255.0f, 55/255.0f);

            scene.addChild(new Object("BatangKecil.001"));
            scene.lastChild().createCylinder();
            scene.lastChild().scale(0.055009f, 0.055009f, 1.07105f);
            scene.lastChild().rotateQ(0.941193f, 0.160407f, 0.231418f, -0.186737f);
            scene.lastChild().translate(4.70789f, -5.48614f, 4.63283f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(105 / 255.0f, 75 / 255.0f, 55 / 255.0f);

            scene.addChild(new Object("BatangKecil.002"));
            scene.lastChild().createCylinder();
            scene.lastChild().scale(0.055009f, 0.055009f, 0.491048f);
            scene.lastChild().rotateQ(0.916892f, -0.28363f, 0.278902f, -0.032815f);
            scene.lastChild().translate(4.49066f, -4.53096f, 4.80774f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(105 / 255.0f, 75 / 255.0f, 55 / 255.0f);

            scene.addChild(new Object("BatangKecil.003"));
            scene.lastChild().createCylinder();
            scene.lastChild().scale(0.055009f, 0.055009f, 0.571048f);
            scene.lastChild().rotateQ(0.348117f, -0.25946f, -0.157528f, 0.88695f);
            scene.lastChild().translate(3.6578f, -4.87545f, 4.55862f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(105 / 255f, 75 / 255f, 55 / 255f);

            scene.addChild(new Object("DaunPohon.001"));
            scene.lastChild().createBall();
            scene.lastChild().scale(2.64469f, 2.47364f,1);
            scene.lastChild().rotateQ(1.0f,0,0,0);
            scene.lastChild().translate(4.39924f, -5.52693f, 5.73931f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(109/ 255f, 179/ 255f, 63/255f);

            scene.addChild(new Object("DaunPohon.002"));
            scene.lastChild().createBall();
            scene.lastChild().scale(1.93883f, 1.81343f, 0.733102f);
            scene.lastChild().rotateQ(1.0f, 0, 0, 0);
            scene.lastChild().translate(3.97226f, -4.18096f, 6.52882f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(109 / 255f, 179 / 255f, 63 / 255f);

            scene.addChild(new Object("AwanKananDepan.001"));
            scene.lastChild().createBall();
            scene.lastChild().scale(2.58855f, 1.75335f, 1.33258f);
            scene.lastChild().rotateQ(0.796907f, 0.080296f, 0.029686f, -0.598006f);
            scene.lastChild().translate(-0.846137f, 5.14307f, 14.3802f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(1,1,1);

            scene.addChild(new Object("AwanKananDepan.002"));
            scene.lastChild().createBall();
            scene.lastChild().scale(2.09333f, 1.41791f, 1.07764f);
            scene.lastChild().rotateQ(0.796907f, 0.080296f, 0.029686f, -0.598005f);
            scene.lastChild().translate(-1.42335f, 7.6776f, 14.2091f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(1, 1, 1);

            scene.addChild(new Object("AwanKananDepan.003"));
            scene.lastChild().createBall();
            scene.lastChild().scale(2.09333f, 1.41791f, 1.07764f);
            scene.lastChild().rotateQ(0.796907f, 0.080296f, 0.029686f, -0.598005f);
            scene.lastChild().translate(-1.47981f, 6.86393f, 15.278f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(1, 1, 1);

            scene.addChild(new Object("AwanKiriDepan.001"));
            scene.lastChild().createBall();
            scene.lastChild().scale(1.22578f, 0.830279f, 0.631028f);
            scene.lastChild().rotateQ(0.885467f, 0.11449f, 0.003938f, -0.450362f);
            scene.lastChild().translate(-7.29405f, -6.70196f, 9.02701f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(1, 1, 1);

            scene.addChild(new Object("AwanKiriDepan.002"));
            scene.lastChild().createBall();
            scene.lastChild().scale(2.38547f, 1.0267f, 0.780312f);
            scene.lastChild().rotateQ(0.885466f, 0.11449f, 0.003939f, -0.450361f);
            scene.lastChild().translate(-6.60263f, -7.98543f, 8.78807f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(1, 1, 1);

            scene.addChild(new Object("AwanKiriDepan.003"));
            scene.lastChild().createBall();
            scene.lastChild().scale(1.63942f, 0.830279f, 0.631028f);
            scene.lastChild().rotateQ(0.893125f, 0.097581f, 0.00928f, -0.438998f);
            scene.lastChild().translate(-7.09028f, -7.58888f, 9.58345f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(1, 1, 1);

            scene.addChild(new Object("Pelangi.Merah"));
            scene.lastChild().createTorus(0.5f, 0.15f);
            scene.lastChild().scale(8.81015f, 8.19613f, 8.19613f);
            scene.lastChild().rotateQ(0.502488f, -0.278319f, 0.647409f, -0.500905f);
            scene.lastChild().translate(-4.17152f, -0.515738f, 13.0207f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(1, 0,0);

            scene.addChild(new Object("Pelangi.Yellow"));
            scene.lastChild().createTorus(0.5f, 0.15f);
            scene.lastChild().scale(8.53725f, 8.19613f, 8.19613f);
            scene.lastChild().rotateQ(0.502488f, -0.278319f, 0.647409f, -0.500905f);
            scene.lastChild().translate(-4.10779f, -0.249941f, 12.5726f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(0, 1, 0);

            scene.addChild(new Object("Pelangi.Biru"));
            scene.lastChild().createTorus(0.5f, 0.15f);
            scene.lastChild().scale(8.19613f, 8.19613f, 8.19613f);
            scene.lastChild().rotateQ(0.502488f, -0.278319f, 0.647409f, -0.500905f);
            scene.lastChild().translate(-3.96566f, -0.004374f, 12.0374f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(0, 0, 1);

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
            scene.rotateZ(0.2f);
        }
    }
}
