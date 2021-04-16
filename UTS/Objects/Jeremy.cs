using System;
using System.Collections.Generic;
using System.Text;
using OpenTK.Mathematics;

namespace UTS
{
    class Jeremy
    {
        public static void Objects(ref Object scene)
        {
            scene.addChild(new Object("badan"));
            scene.lastChild().createBall();
            scene.lastChild().scale(1.59f, 1.22f, 0.92f);
            scene.lastChild().rotateQ(1.0f,0,0,0);
            scene.lastChild().translate(7.03607f, -1.8448f, 1.19008f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(0.90f, 0.90f, 0.90f);

            scene.addChild(new Object("Kepala"));
            scene.lastChild().createBall();
            scene.lastChild().scale(0.34f, 0.41f, 0.48f);
            scene.lastChild().rotateQ(1.0f, 0, 0, 0);
            scene.lastChild().translate(8.64044f, -1.9697f, 1.73761f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(0, 0, 0);

            scene.addChild(new Object("KakiKananBelakang"));
            scene.lastChild().createCylinder();
            scene.lastChild().scale(-0.08f, -0.06f, 0.4f);
            scene.lastChild().rotateQ(1.0f, 0, 0, 0);
            scene.lastChild().translate(6.39305f, -2.17936f, 0.200114f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(0, 0, 0);

            scene.addChild(new Object("KakiKananDepan"));
            scene.lastChild().createCylinder();
            scene.lastChild().scale(-0.08f, -0.06f, 0.4f);
            scene.lastChild().rotateQ(1.0f, 0, 0, 0);
            scene.lastChild().translate(7.79305f, -2.17936f, 0.200114f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(0, 0, 0);

            scene.addChild(new Object("KakikirinDepan"));
            scene.lastChild().createCylinder();
            scene.lastChild().scale(-0.08f, -0.06f, 0.4f);
            scene.lastChild().rotateQ(1.0f, 0, 0, 0);
            scene.lastChild().translate(7.90305f, -1.39936f, 0.200114f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(0, 0, 0);

            scene.addChild(new Object("KakikirinBelakang"));
            scene.lastChild().createCylinder();
            scene.lastChild().scale(-0.08f, -0.06f, 0.4f);
            scene.lastChild().rotateQ(1.0f, 0, 0, 0);
            scene.lastChild().translate(6.47305f, -1.39936f, 0.200114f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(0, 0, 0);

            scene.addChild(new Object("bulu1"));
            scene.lastChild().createBall(0.5f);
            scene.lastChild().scale(0.58f, 0.3f, 0.57f);
            scene.lastChild().rotateQ(1.05484f, 0.686975f, -0.485476f, -0.019801f);
            scene.lastChild().translate(7.9035f, -2.37591f, 0.834452f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(0.90f, 0.90f, 0.90f);


            scene.addChild(new Object("bulu2"));
            scene.lastChild().createBall(0.5f);
            scene.lastChild().scale(0.58f, 0.3f, 0.57f);
            scene.lastChild().rotateQ(1.23622f, 0.471926f, -0.220983f, -0.144586f);
            scene.lastChild().translate(7.1135f, -2.66591f, 0.774452f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(0.90f, 0.90f, 0.90f);


            scene.addChild(new Object("bulu3"));
            scene.lastChild().createBall(0.5f);
            scene.lastChild().scale(0.58f, 0.3f, 0.57f);
            scene.lastChild().rotateQ(1.23622f, 0.421171f, -0.101639f, -0.386334f);
            scene.lastChild().translate(6.1935f, -2.41591f, 0.774452f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(0.90f, 0.90f, 0.90f);


            scene.addChild(new Object("bulu4"));
            scene.lastChild().createBall(0.5f);
            scene.lastChild().scale(0.58f, 0.3f, 0.57f);
            scene.lastChild().rotateQ(2.44148f, -0.701533f, -0.11068f, -0.672269f);
            scene.lastChild().translate(6.2235f, -2.63591f, 1.39445f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(0.90f, 0.90f, 0.90f);

            scene.addChild(new Object("bulu5"));
            scene.lastChild().createBall(0.5f);
            scene.lastChild().scale(0.58f, 0.3f, 0.57f);
            scene.lastChild().rotateQ(14.1415f, -2.60153f, 1.78932f, -0.572269f);
            scene.lastChild().translate(7.1935f, -2.83591f, 1.36445f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(0.90f, 0.90f, 0.90f);



        }

        public static void Animations(ref Object scene)
        {

        }
    }
}
