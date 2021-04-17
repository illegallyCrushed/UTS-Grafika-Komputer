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

            scene.addChild(new Object("Leher."));
            scene.lastChild().createCylinder();
            scene.lastChild().scale(-0.37330f, -0.37330f, -0.75330f);
            scene.lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
            scene.lastChild().translate(7.05128f, 5.55019f, 3.59534f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(0.98824f, 0.72157f, 0.16078f);

            scene.addChild(new Object("JariBelakangKiri"));
            scene.lastChild().createCylinder();
            scene.lastChild().scale(0.37090f, 0.21291f, 0.11286f);
            scene.lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
            scene.lastChild().translate(4.16000f, 6.03000f, 0.45000f);
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

            scene.addChild(new Object("Semak"));
            scene.lastChild().createBall();
            scene.lastChild().scale(0.55856f, 0.55856f, 0.36915f);
            scene.lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
            scene.lastChild().translate(6.38623f, 4.21208f, 0.22172f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(0.00429f, 0.34933f, 0.00000f);

            scene.addChild(new Object("Semak001"));
            scene.lastChild().createBall();
            scene.lastChild().scale(0.64466f, 0.74223f, 0.28879f);
            scene.lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
            scene.lastChild().translate(6.30682f, 3.72904f, 0.84058f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(0.00429f, 0.34933f, 0.00000f);

            scene.addChild(new Object("Semak002"));
            scene.lastChild().createBall();
            scene.lastChild().scale(0.49542f, 0.73649f, 0.42081f);
            scene.lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
            scene.lastChild().translate(6.78808f, 3.68739f, 0.30959f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(0.00429f, 0.34933f, 0.00000f);

            scene.addChild(new Object("Semak003"));
            scene.lastChild().createBall();
            scene.lastChild().scale(0.55856f, 0.62744f, 0.55856f);
            scene.lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
            scene.lastChild().translate(6.56266f, 3.31333f, 0.28810f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(0.00429f, 0.34933f, 0.00000f);

            scene.addChild(new Object("Semak004"));
            scene.lastChild().createBall();
            scene.lastChild().scale(0.55856f, 0.73075f, 0.52986f);
            scene.lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
            scene.lastChild().translate(5.36607f, 3.66058f, 0.21157f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(0.00429f, 0.34933f, 0.00000f);

            scene.addChild(new Object("Semak005"));
            scene.lastChild().createBall();
            scene.lastChild().scale(0.61022f, 0.68483f, 0.42655f);
            scene.lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
            scene.lastChild().translate(6.29645f, 2.70287f, 0.25637f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(0.00429f, 0.34933f, 0.00000f);

            scene.addChild(new Object("Semak006"));
            scene.lastChild().createBall();
            scene.lastChild().scale(0.66761f, 0.55856f, 0.55856f);
            scene.lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
            scene.lastChild().translate(5.61232f, 2.48926f, 0.24939f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(0.00429f, 0.34933f, 0.00000f);

            scene.addChild(new Object("Semak007"));
            scene.lastChild().createBall();
            scene.lastChild().scale(0.55856f, 0.87998f, 0.55856f);
            scene.lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
            scene.lastChild().translate(5.20712f, 3.17540f, 0.17215f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(0.00429f, 0.34933f, 0.00000f);

            scene.addChild(new Object("Semak008"));
            scene.lastChild().createBall();
            scene.lastChild().scale(0.63318f, 0.48968f, 0.40359f);
            scene.lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
            scene.lastChild().translate(5.93374f, 3.38466f, 1.16920f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(0.00429f, 0.34933f, 0.00000f);

            scene.addChild(new Object("Semak009"));
            scene.lastChild().createBall();
            scene.lastChild().scale(0.52986f, 0.47820f, 0.46672f);
            scene.lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
            scene.lastChild().translate(5.80747f, 4.11360f, 0.24939f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(0.00429f, 0.34933f, 0.00000f);

            scene.addChild(new Object("Semak010"));
            scene.lastChild().createBall();
            scene.lastChild().scale(0.55282f, 0.66761f, 0.38063f);
            scene.lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
            scene.lastChild().translate(5.67545f, 3.16081f, 0.78318f);
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

        }

        public static void Animations(ref Object scene)
        {

        }
    }
}
