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
            scene.addChild(new Object("bulu1"));
            scene.lastChild().createBall(0.5f);
            scene.lastChild().scale(0.21f, 0.14f, 0.22f);
            scene.lastChild().rotateQ(0.950216f, 0.950216f, -0.08222f, 0.09006f);
            scene.lastChild().translate(5.8184f, -1.48711f, 1.11484f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(252 / 255f, 184 / 255f, 41 / 255f);

            scene.addChild(new Object("badan"));
            scene.lastChild().createBall();
            scene.lastChild().scale(1.59f, 1.22f, 0.92f);
            scene.lastChild().rotateQ(1.0f,0,0,0);
            scene.lastChild().translate(4.96225f, 0.638524f, 1.41977f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(252 / 255f, 184 / 255f, 41 / 255f);
           
            scene.addChild(new Object("Kepala"));
            scene.lastChild().createBall();
            scene.lastChild().scale(0.34f, 0.41f, 0.48f);
            scene.lastChild().rotateQ(1.0f, 0, 0, 0);
            scene.lastChild().translate(6.56663f, -0.763425f, 1.9673f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(252 / 255f, 184 / 255f, 41 / 255f);
        }

        public static void Animations(ref Object scene)
        {

        }
    }
}
