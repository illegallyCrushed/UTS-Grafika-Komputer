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

            scene.addChild(new Object("Pelangi"));
            scene.lastChild().createTorus(0.5f, 0.75f);
            scene.lastChild().scale(7.20812f, 7.20812f, 7.20812f);
            scene.lastChild().rotateQ(0.752707f, -0.330415f, 0.499329f, -0.273732f);
            scene.lastChild().translate(0.62205f, -0.233987f, 9.71695f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(1, 1, 1);

            scene.addChild(new Object("AwanKananDepan.001"));
            scene.lastChild().createBall();
            scene.lastChild().scale(2.09333f, 1.41791f, 1.07764f);
            scene.lastChild().rotateQ(0.657184f, -0.077822f, 0.140104f, -0.736494f);
            scene.lastChild().translate(-1.19971f, 7.65007f, 14.1134f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(1,1,1);

            scene.addChild(new Object("AwanKananDepan.002"));
            scene.lastChild().createBall();
            scene.lastChild().scale(2.09333f, 1.41791f, 1.07764f);
            scene.lastChild().rotateQ(0.657184f, -0.077822f, 0.140104f, -0.736494f);
            scene.lastChild().translate(-1.0862f, 6.94712f, 15.2539f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(1, 1, 1);

            scene.addChild(new Object("AwanKananDepan.003"));
            scene.lastChild().createBall();
            scene.lastChild().scale(2.58855f, 1.75335f, 1.33258f);
            scene.lastChild().rotateQ(0.657184f, -0.077822f, 0.140104f, -0.736494f);
            scene.lastChild().translate(-1.46339f, 5.08741f, 14.5001f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(1, 1, 1);

            scene.addChild(new Object("AwanKiriDepan.001"));
            scene.lastChild().createBall();
            scene.lastChild().scale(2.38547f, 1.0267f, 0.780312f);
            scene.lastChild().rotateQ(0.906644f, 0.021601f, 0.057317f, -0.417426f);
            scene.lastChild().translate(-6.8706f, -5.74656f, 13.535f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(1, 1, 1);

            scene.addChild(new Object("AwanKiriDepan.002"));
            scene.lastChild().createBall();
            scene.lastChild().scale(2.09333f, 1.41791f, 1.07764f);
            scene.lastChild().rotateQ(0.657184f, -0.077822f, 0.140104f, -0.736494f);
            scene.lastChild().translate(-7.63844f, -4.50209f, 13.7452f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(1, 1, 1);

            scene.addChild(new Object("AwanKiriDepan.003"));
            scene.lastChild().createBall();
            scene.lastChild().scale(2.58855f, 1.75335f, 1.33258f);
            scene.lastChild().rotateQ(0.657184f, -0.077822f, 0.140104f, -0.736494f);
            scene.lastChild().translate(-1.46339f, 5.08741f, 14.5001f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(1, 1, 1);

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
<<<<<<< Updated upstream
            scene.rotateZ(0.1f);
=======
            scene.rotateZ(0.2f);
>>>>>>> Stashed changes
        }
    }
}
