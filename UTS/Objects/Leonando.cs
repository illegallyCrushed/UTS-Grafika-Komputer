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

<<<<<<< Updated upstream
<<<<<<< Updated upstream
            scene.addChild(new Object("Leher"));
=======
            scene.addChild(new Object("Leher."));
>>>>>>> Stashed changes
=======
            scene.addChild(new Object("Leher."));
>>>>>>> Stashed changes
            scene.lastChild().createCylinder();
            scene.lastChild().scale(-0.373297f, -0.373297f, -0.753297f);
            scene.lastChild().rotateQ(1.0f, 0, 0, 0);
            scene.lastChild().translate(7.05128f, 5.55019f, 3.59534f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(252 / 255f, 184 / 255f, 41 / 255f);

            scene.addChild(new Object("JariBelakangKiri"));
            scene.lastChild().createCylinder();
<<<<<<< Updated upstream
<<<<<<< Updated upstream
            scene.lastChild().scale(0.643924f, 0.643924f, 0.07605f);
            scene.lastChild().rotateQ(1.0f, 0, 0, 0);
            scene.lastChild().translate(7.34f, 5.54f, 3.83f);
=======
            scene.lastChild().scale(0.37090f, 0.21291f, 0.11286f);
            scene.lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
            scene.lastChild().translate(4.16000f, 6.03000f, 0.45000f);
>>>>>>> Stashed changes
=======
            scene.lastChild().scale(0.37090f, 0.21291f, 0.11286f);
            scene.lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
            scene.lastChild().translate(4.16000f, 6.03000f, 0.45000f);
>>>>>>> Stashed changes
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
            scene.lastChild().setColor(22 / 255, 16 / 255, 2 / 255);

            scene.addChild(new Object("TepiTopi"));
            scene.lastChild().createTorus();
            scene.lastChild().scale(0.567349f, 0.567349f, 0.567349f);
            scene.lastChild().rotateQ(1.0f, 0, 0, 0);
            scene.lastChild().translate(7.28f, 5.54f, 5.33f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(19 / 255f, 82 / 255f, 129 / 255f);

            scene.addChild(new Object("Topi"));
            scene.lastChild().createBall(0.5f);
            scene.lastChild().scale(0.511874f, 0.511874f, 0.511874f);
            scene.lastChild().rotateQ(0.5f, -0.5f, -0.5f, 0.5f);
            scene.lastChild().translate(7.2584f, 5.53289f, 5.38484f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(19 / 255f, 82 / 255f, 129 / 255f);

            scene.addChild(new Object("TelingaKanan"));
            scene.lastChild().createCube();
            scene.lastChild().scale(0.28f, 0.06f, 0.22f);
            scene.lastChild().rotateQ(0.982774f, -0.184809f, 0, 0);
            scene.lastChild().translate(7.21f, 4.96f, 4.75f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(81 / 255f, 49 / 255f, 10 / 255f);

            scene.addChild(new Object("TelingaKiri"));
            scene.lastChild().createCube();
            scene.lastChild().scale(0.28f, 0.06f, 0.22f);
            scene.lastChild().rotateQ(0.982774f, 0.184809f, 0, 0);
            scene.lastChild().translate(7.21f, 6.11f, 4.75f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(81 / 255f, 49 / 255f, 10 / 255f);

            scene.addChild(new Object("MataKanan"));
            scene.lastChild().createBall(0.5f);
            scene.lastChild().scale(0.073119f, 0.093119f, 0.093119f);
            scene.lastChild().rotateQ(0.707107f, 0, 0, 0.707107f);
            scene.lastChild().translate(7.7784f, 5.43289f, 5.03484f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(1, 1, 1);

            scene.addChild(new Object("MataKiri"));
            scene.lastChild().createBall(0.5f);
            scene.lastChild().scale(0.073119f, 0.093119f, 0.093119f);
            scene.lastChild().rotateQ(0.707107f, 0, 0, 0.707107f);
            scene.lastChild().translate(7.7784f, 5.63289f, 5.03484f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(1, 1, 1);

            scene.addChild(new Object("MataHitamKanan"));
            scene.lastChild().createBall(0.5f);
            scene.lastChild().scale(0.035908f, 0.02573f, 0.04573f);
            scene.lastChild().rotateQ(0.707107f, 0, 0, 0.707107f);
            scene.lastChild().translate(7.8584f, 5.43289f, 5.03484f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(0, 0, 0);

            scene.addChild(new Object("MataHitamKiri"));
            scene.lastChild().createBall(0.5f);
            scene.lastChild().scale(0.035908f, 0.02573f, 0.04573f);
            scene.lastChild().rotateQ(0.707107f, 0, 0, 0.707107f);
            scene.lastChild().translate(7.8584f, 5.63289f, 5.03484f);
            scene.lastChild().centerOrigin();
<<<<<<< Updated upstream
            scene.lastChild().setColor(0, 0, 0);
=======
            scene.lastChild().setColor(0.07451f, 0.32157f, 0.50588f);

            scene.addChild(new Object("Semak"));
            scene.lastChild().createBall();
            scene.lastChild().scale(0.55856f, 0.55856f, 0.36915f);
            scene.lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
            scene.lastChild().translate(6.10639f, 2.58508f, 0.91036f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(0.00429f, 0.34933f, 0.00000f);

            scene.addChild(new Object("Semak001"));
            scene.lastChild().createBall();
            scene.lastChild().scale(0.64466f, 0.74223f, 0.28879f);
            scene.lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
            scene.lastChild().translate(6.02698f, 2.10204f, 1.52921f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(0.00429f, 0.34933f, 0.00000f);

            scene.addChild(new Object("Semak002"));
            scene.lastChild().createBall();
            scene.lastChild().scale(0.49542f, 0.73649f, 0.42081f);
            scene.lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
            scene.lastChild().translate(6.50824f, 2.06039f, 0.99822f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(0.00429f, 0.34933f, 0.00000f);

            scene.addChild(new Object("Semak003"));
            scene.lastChild().createBall();
            scene.lastChild().scale(0.55856f, 0.62744f, 0.55856f);
            scene.lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
            scene.lastChild().translate(6.28282f, 1.68634f, 0.97674f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(0.00429f, 0.34933f, 0.00000f);

            scene.addChild(new Object("Semak004"));
            scene.lastChild().createBall();
            scene.lastChild().scale(0.55856f, 0.73075f, 0.52986f);
            scene.lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
            scene.lastChild().translate(5.08623f, 2.03358f, 0.90021f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(0.00429f, 0.34933f, 0.00000f);

            scene.addChild(new Object("Semak005"));
            scene.lastChild().createBall();
            scene.lastChild().scale(0.61022f, 0.68483f, 0.42655f);
            scene.lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
            scene.lastChild().translate(6.01660f, 1.07587f, 0.94501f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(0.00429f, 0.34933f, 0.00000f);

            scene.addChild(new Object("Semak006"));
            scene.lastChild().createBall();
            scene.lastChild().scale(0.66761f, 0.55856f, 0.55856f);
            scene.lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
            scene.lastChild().translate(5.33247f, 0.86226f, 0.93802f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(0.00429f, 0.34933f, 0.00000f);

            scene.addChild(new Object("Semak007"));
            scene.lastChild().createBall();
            scene.lastChild().scale(0.55856f, 0.87998f, 0.55856f);
            scene.lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
            scene.lastChild().translate(4.92727f, 1.54841f, 0.86079f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(0.00429f, 0.34933f, 0.00000f);

            scene.addChild(new Object("Semak008"));
            scene.lastChild().createBall();
            scene.lastChild().scale(0.63318f, 0.48968f, 0.40359f);
            scene.lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
            scene.lastChild().translate(5.65390f, 1.75766f, 1.85784f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(0.00429f, 0.34933f, 0.00000f);

            scene.addChild(new Object("Semak009"));
            scene.lastChild().createBall();
            scene.lastChild().scale(0.52986f, 0.47820f, 0.46672f);
            scene.lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
            scene.lastChild().translate(5.52762f, 2.48660f, 0.93802f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(0.00429f, 0.34933f, 0.00000f);

            scene.addChild(new Object("Semak010"));
            scene.lastChild().createBall();
            scene.lastChild().scale(0.55282f, 0.66761f, 0.38063f);
            scene.lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
            scene.lastChild().translate(5.39561f, 1.53381f, 1.47182f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(0.00000f, 0.80000f, 0.00124f);

            scene.addChild(new Object("MulutBawah"));
            scene.lastChild().createCylinder();
            scene.lastChild().scale(0.64392f, 0.64392f, 0.07605f);
            scene.lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
            scene.lastChild().translate(7.34000f, 5.54000f, 3.83000f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(0.98824f, 0.72157f, 0.16078f);

            scene.addChild(new Object("JariDepanKanan"));
            scene.lastChild().createCylinder();
            scene.lastChild().scale(0.37090f, 0.21291f, 0.11286f);
            scene.lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
            scene.lastChild().translate(6.94000f, 5.12000f, 0.45000f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(0.98824f, 0.72157f, 0.16078f);

            scene.addChild(new Object("JariBelakangKanan"));
            scene.lastChild().createCylinder();
            scene.lastChild().scale(0.37090f, 0.21291f, 0.11286f);
            scene.lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
            scene.lastChild().translate(4.21000f, 4.93000f, 0.45000f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(0.98824f, 0.72157f, 0.16078f);

            scene.addChild(new Object("JariDepanKiri"));
            scene.lastChild().createCylinder();
            scene.lastChild().scale(0.37090f, 0.21291f, 0.11286f);
            scene.lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
            scene.lastChild().translate(6.94000f, 6.03000f, 0.45000f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(0.98824f, 0.72157f, 0.16078f);

            scene.addChild(new Object("Aksesoris"));
            scene.lastChild().createTorus(1f, 0.4f);
            scene.lastChild().scale(0.36307f, 0.47716f, 0.56921f);
            scene.lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
            scene.lastChild().translate(7.06000f, 5.53000f, 3.45000f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(0.00000f, 0.00000f, 0.00000f);

            scene.addChild(new Object("Semak"));
            scene.lastChild().createBall();
            scene.lastChild().scale(0.55856f, 0.55856f, 0.36915f);
            scene.lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
            scene.lastChild().translate(6.10639f, 2.58508f, 0.91036f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(0.00429f, 0.34933f, 0.00000f);

            scene.addChild(new Object("Semak001"));
            scene.lastChild().createBall();
            scene.lastChild().scale(0.64466f, 0.74223f, 0.28879f);
            scene.lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
            scene.lastChild().translate(6.02698f, 2.10204f, 1.52921f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(0.00429f, 0.34933f, 0.00000f);

            scene.addChild(new Object("Semak002"));
            scene.lastChild().createBall();
            scene.lastChild().scale(0.49542f, 0.73649f, 0.42081f);
            scene.lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
            scene.lastChild().translate(6.50824f, 2.06039f, 0.99822f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(0.00429f, 0.34933f, 0.00000f);

            scene.addChild(new Object("Semak003"));
            scene.lastChild().createBall();
            scene.lastChild().scale(0.55856f, 0.62744f, 0.55856f);
            scene.lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
            scene.lastChild().translate(6.28282f, 1.68634f, 0.97674f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(0.00429f, 0.34933f, 0.00000f);

            scene.addChild(new Object("Semak004"));
            scene.lastChild().createBall();
            scene.lastChild().scale(0.55856f, 0.73075f, 0.52986f);
            scene.lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
            scene.lastChild().translate(5.08623f, 2.03358f, 0.90021f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(0.00429f, 0.34933f, 0.00000f);

            scene.addChild(new Object("Semak005"));
            scene.lastChild().createBall();
            scene.lastChild().scale(0.61022f, 0.68483f, 0.42655f);
            scene.lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
            scene.lastChild().translate(6.01660f, 1.07587f, 0.94501f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(0.00429f, 0.34933f, 0.00000f);

            scene.addChild(new Object("Semak006"));
            scene.lastChild().createBall();
            scene.lastChild().scale(0.66761f, 0.55856f, 0.55856f);
            scene.lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
            scene.lastChild().translate(5.33247f, 0.86226f, 0.93802f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(0.00429f, 0.34933f, 0.00000f);

            scene.addChild(new Object("Semak007"));
            scene.lastChild().createBall();
            scene.lastChild().scale(0.55856f, 0.87998f, 0.55856f);
            scene.lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
            scene.lastChild().translate(4.92727f, 1.54841f, 0.86079f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(0.00429f, 0.34933f, 0.00000f);

            scene.addChild(new Object("Semak008"));
            scene.lastChild().createBall();
            scene.lastChild().scale(0.63318f, 0.48968f, 0.40359f);
            scene.lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
            scene.lastChild().translate(5.65390f, 1.75766f, 1.85784f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(0.00429f, 0.34933f, 0.00000f);

            scene.addChild(new Object("Semak009"));
            scene.lastChild().createBall();
            scene.lastChild().scale(0.52986f, 0.47820f, 0.46672f);
            scene.lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
            scene.lastChild().translate(5.52762f, 2.48660f, 0.93802f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(0.00429f, 0.34933f, 0.00000f);

            scene.addChild(new Object("Semak010"));
            scene.lastChild().createBall();
            scene.lastChild().scale(0.55282f, 0.66761f, 0.38063f);
            scene.lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
            scene.lastChild().translate(5.39561f, 1.53381f, 1.47182f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(0.00000f, 0.80000f, 0.00124f);

            scene.addChild(new Object("MulutBawah"));
            scene.lastChild().createCylinder();
            scene.lastChild().scale(0.64392f, 0.64392f, 0.07605f);
            scene.lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
            scene.lastChild().translate(7.34000f, 5.54000f, 3.83000f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(0.98824f, 0.72157f, 0.16078f);

            scene.addChild(new Object("JariDepanKanan"));
            scene.lastChild().createCylinder();
            scene.lastChild().scale(0.37090f, 0.21291f, 0.11286f);
            scene.lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
            scene.lastChild().translate(6.94000f, 5.12000f, 0.45000f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(0.98824f, 0.72157f, 0.16078f);

            scene.addChild(new Object("JariBelakangKanan"));
            scene.lastChild().createCylinder();
            scene.lastChild().scale(0.37090f, 0.21291f, 0.11286f);
            scene.lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
            scene.lastChild().translate(4.21000f, 4.93000f, 0.45000f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(0.98824f, 0.72157f, 0.16078f);

            scene.addChild(new Object("JariDepanKiri"));
            scene.lastChild().createCylinder();
            scene.lastChild().scale(0.37090f, 0.21291f, 0.11286f);
            scene.lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
            scene.lastChild().translate(6.94000f, 6.03000f, 0.45000f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(0.98824f, 0.72157f, 0.16078f);

            scene.addChild(new Object("Aksesoris"));
            scene.lastChild().createTorus(1f, 0.4f);
            scene.lastChild().scale(0.36307f, 0.47716f, 0.56921f);
            scene.lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
            scene.lastChild().translate(7.06000f, 5.53000f, 3.45000f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(0.00000f, 0.00000f, 0.00000f);


>>>>>>> Stashed changes



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
