using System;
using System.Collections.Generic;
using System.Text;
using OpenTK.Mathematics;

namespace UTS
{
    class Jeremy
    {
		public static Animator TanganTimmyRot = new Animator();
        public static void Objects(ref Object scene)
        {
			scene.addChild(new Object("badan"));
			scene.lastChild().createBall();
			scene.lastChild().scale(1.59000f, 1.22000f, 0.92000f);
			scene.lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
			scene.lastChild().translate(4.04428f, -0.31014f, 1.46904f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(0.80000f, 0.80000f, 0.80000f);

			scene.addChild(new Object("Kakikiridepan"));
			scene.lastChild().createCylinder();
			scene.lastChild().scale(0.08000f, 0.06000f, 0.40000f);
			scene.lastChild().rotateQ(0.00000f, 0.00000f, 0.00000f, 1.00000f);
			scene.lastChild().translate(3.48126f, 0.13530f, 0.47908f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(0.00000f, 0.00000f, 0.00000f);

			scene.addChild(new Object("Kepala"));
			scene.lastChild().createBall();
			scene.lastChild().scale(0.30000f, 0.47000f, 0.56000f);
			scene.lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
			scene.lastChild().translate(5.64865f, -0.32101f, 2.03705f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(0.00637f, 0.00637f, 0.00637f);

			scene.addChild(new Object("Bullu1"));
			scene.lastChild().createBall(0.5f);
			scene.lastChild().scale(0.58000f, 0.30000f, 0.57000f);
			scene.lastChild().rotateQ(0.78175f, 0.50912f, -0.35979f, -0.01467f);
			scene.lastChild().translate(4.91171f, -0.84125f, 1.11342f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(0.80066f, 0.80066f, 0.80066f);

			scene.addChild(new Object("kakikiribelakang"));
			scene.lastChild().createCylinder();
			scene.lastChild().scale(0.08000f, 0.06000f, 0.40000f);
			scene.lastChild().rotateQ(0.00000f, 0.00000f, 0.00000f, 1.00000f);
			scene.lastChild().translate(4.91126f, 0.13530f, 0.47908f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(0.00000f, 0.00000f, 0.00000f);

			scene.addChild(new Object("kakikananbelakang"));
			scene.lastChild().createCylinder();
			scene.lastChild().scale(0.08000f, 0.06000f, 0.40000f);
			scene.lastChild().rotateQ(0.00000f, 0.00000f, 0.00000f, 1.00000f);
			scene.lastChild().translate(3.40126f, -0.64470f, 0.47908f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(0.00000f, 0.00000f, 0.00000f);

			scene.addChild(new Object("kakikanandepan"));
			scene.lastChild().createCylinder();
			scene.lastChild().scale(0.08000f, 0.06000f, 0.40000f);
			scene.lastChild().rotateQ(0.00000f, 0.00000f, 0.00000f, 1.00000f);
			scene.lastChild().translate(4.80126f, -0.64470f, 0.47908f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(0.00000f, 0.00000f, 0.00000f);

			scene.addChild(new Object("bulu2"));
			scene.lastChild().createBall(0.5f);
			scene.lastChild().scale(0.58000f, 0.30000f, 0.57000f);
			scene.lastChild().rotateQ(0.91617f, 0.34975f, -0.16377f, -0.10715f);
			scene.lastChild().translate(4.12171f, -1.13125f, 1.05342f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(0.80000f, 0.80000f, 0.80000f);

			scene.addChild(new Object("bulu3"));
			scene.lastChild().createBall(0.5f);
			scene.lastChild().scale(0.58000f, 0.30000f, 0.57000f);
			scene.lastChild().rotateQ(0.90273f, 0.31213f, -0.07533f, -0.28632f);
			scene.lastChild().translate(3.20171f, -0.88125f, 1.05342f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(0.80000f, 0.80000f, 0.80000f);

			scene.addChild(new Object("bulu4"));
			scene.lastChild().createBall(0.5f);
			scene.lastChild().scale(0.58000f, 0.30000f, 0.57000f);
			scene.lastChild().rotateQ(0.92830f, -0.26674f, -0.04208f, -0.25561f);
			scene.lastChild().translate(3.23171f, -1.10125f, 1.67341f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(0.80000f, 0.80000f, 0.80000f);

			scene.addChild(new Object("bulu5"));
			scene.lastChild().createBall(0.5f);
			scene.lastChild().scale(0.58000f, 0.30000f, 0.57000f);
			scene.lastChild().rotateQ(0.97521f, -0.17940f, 0.12339f, -0.03946f);
			scene.lastChild().translate(4.13171f, -1.30125f, 1.64341f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(0.80000f, 0.80000f, 0.80000f);

			scene.addChild(new Object("bulu6"));
			scene.lastChild().createBall(0.5f);
			scene.lastChild().scale(0.58000f, 0.30000f, 0.57000f);
			scene.lastChild().rotateQ(0.70567f, -0.09161f, -0.54826f, 0.43937f);
			scene.lastChild().translate(4.96171f, -0.89125f, 1.85342f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(0.80000f, 0.80000f, 0.80000f);

			scene.addChild(new Object("bulu7"));
			scene.lastChild().createBall(0.5f);
			scene.lastChild().scale(0.58000f, 0.30000f, 0.57000f);
			scene.lastChild().rotateQ(0.14589f, -0.58735f, 0.70547f, 0.36884f);
			scene.lastChild().translate(5.31171f, -0.34125f, 1.36342f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(0.80000f, 0.80000f, 0.80000f);

			scene.addChild(new Object("bulu8"));
			scene.lastChild().createBall(0.5f);
			scene.lastChild().scale(0.58000f, 0.30000f, 0.57000f);
			scene.lastChild().rotateQ(0.31729f, -0.86060f, 0.36553f, -0.15835f);
			scene.lastChild().translate(4.91171f, 0.24875f, 1.85342f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(0.80000f, 0.80000f, 0.80000f);

			scene.addChild(new Object("bulu9"));
			scene.lastChild().createBall(0.5f);
			scene.lastChild().scale(0.58000f, 0.30000f, 0.57000f);
			scene.lastChild().rotateQ(0.04645f, -0.51647f, 0.41641f, 0.74680f);
			scene.lastChild().translate(4.95171f, 0.24875f, 1.18342f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(0.80000f, 0.80000f, 0.80000f);

			scene.addChild(new Object("bulu10"));
			scene.lastChild().createBall(0.5f);
			scene.lastChild().scale(0.58000f, 0.30000f, 0.57000f);
			scene.lastChild().rotateQ(0.32599f, -0.94537f, 0.00000f, 0.00000f);
			scene.lastChild().translate(4.05171f, 0.49875f, 1.85342f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(0.80000f, 0.80000f, 0.80000f);

			scene.addChild(new Object("bulu11"));
			scene.lastChild().createBall(0.5f);
			scene.lastChild().scale(0.58000f, 0.30000f, 0.57000f);
			scene.lastChild().rotateQ(0.28952f, 0.95542f, -0.00000f, 0.05790f);
			scene.lastChild().translate(4.17171f, 0.58875f, 1.18342f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(0.80000f, 0.80000f, 0.80000f);

			scene.addChild(new Object("bulu12"));
			scene.lastChild().createBall(0.5f);
			scene.lastChild().scale(0.58000f, 0.30000f, 0.57000f);
			scene.lastChild().rotateQ(0.40308f, -0.84646f, -0.34261f, 0.06046f);
			scene.lastChild().translate(3.18171f, 0.21875f, 1.85342f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(0.80000f, 0.80000f, 0.80000f);

			scene.addChild(new Object("bulu13"));
			scene.lastChild().createBall(0.5f);
			scene.lastChild().scale(0.58000f, 0.30000f, 0.57000f);
			scene.lastChild().rotateQ(0.32246f, 0.92131f, 0.11516f, -0.18426f);
			scene.lastChild().translate(3.32171f, 0.42875f, 1.18342f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(0.80000f, 0.80000f, 0.80000f);

			scene.addChild(new Object("bulu14"));
			scene.lastChild().createBall(0.5f);
			scene.lastChild().scale(0.58000f, 0.30000f, 0.57000f);
			scene.lastChild().rotateQ(0.33743f, -0.72678f, -0.59700f, 0.03893f);
			scene.lastChild().translate(2.82171f, -0.33125f, 1.72342f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(0.80000f, 0.80000f, 0.80000f);

			scene.addChild(new Object("bulu15"));
			scene.lastChild().createBall(0.5f);
			scene.lastChild().scale(0.58000f, 0.30000f, 0.57000f);
			scene.lastChild().rotateQ(0.33287f, 0.78053f, 0.52800f, -0.03444f);
			scene.lastChild().translate(2.82171f, -0.16125f, 1.22342f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(0.80000f, 0.80000f, 0.80000f);

			scene.addChild(new Object("bulu16"));
			scene.lastChild().createBall(0.5f);
			scene.lastChild().scale(0.58000f, 0.30000f, 0.57000f);
			scene.lastChild().rotateQ(0.64018f, -0.76822f, 0.00000f, 0.00000f);
			scene.lastChild().translate(4.86171f, -0.39125f, 2.05342f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(0.80000f, 0.80000f, 0.80000f);

			scene.addChild(new Object("bulu17"));
			scene.lastChild().createBall(0.5f);
			scene.lastChild().scale(0.58000f, 0.30000f, 0.57000f);
			scene.lastChild().rotateQ(0.78087f, -0.62470f, 0.00000f, 0.00000f);
			scene.lastChild().translate(4.08171f, -0.81125f, 2.12342f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(0.80000f, 0.80000f, 0.80000f);

			scene.addChild(new Object("bulu18"));
			scene.lastChild().createBall(0.5f);
			scene.lastChild().scale(0.58000f, 0.30000f, 0.57000f);
			scene.lastChild().rotateQ(0.74125f, -0.66712f, -0.07412f, 0.00000f);
			scene.lastChild().translate(3.36171f, -0.53125f, 2.12342f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(0.80000f, 0.80000f, 0.80000f);

			scene.addChild(new Object("bulu19"));
			scene.lastChild().createBall(0.5f);
			scene.lastChild().scale(0.58000f, 0.30000f, 0.57000f);
			scene.lastChild().rotateQ(0.63888f, -0.76665f, -0.06389f, -0.00000f);
			scene.lastChild().translate(3.87171f, -0.06125f, 2.17342f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(0.80000f, 0.80000f, 0.80000f);

			scene.addChild(new Object("bulu20"));
			scene.lastChild().createBall(0.5f);
			scene.lastChild().scale(0.58000f, 0.30000f, 0.57000f);
			scene.lastChild().rotateQ(0.63888f, -0.76665f, -0.06389f, -0.00000f);
			scene.lastChild().translate(4.35171f, -0.18125f, 2.17342f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(0.80000f, 0.80000f, 0.80000f);

			scene.addChild(new Object("telapakkiridepan"));
			scene.lastChild().createBall(0.5f);
			scene.lastChild().scale(0.21000f, 0.14000f, 0.15000f);
			scene.lastChild().rotateQ(0.70711f, -0.70711f, 0.00000f, 0.00000f);
			scene.lastChild().translate(5.05833f, 0.14451f, 0.06685f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(0.00000f, 0.00000f, 0.00000f);

			scene.addChild(new Object("telapakkiribelakang"));
			scene.lastChild().createBall(0.5f);
			scene.lastChild().scale(0.21000f, 0.14000f, 0.15000f);
			scene.lastChild().rotateQ(0.70711f, -0.70711f, 0.00000f, 0.00000f);
			scene.lastChild().translate(3.60833f, 0.14451f, 0.06685f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(0.00000f, 0.00000f, 0.00000f);

			scene.addChild(new Object("telapakkananibelakang.001"));
			scene.lastChild().createBall(0.5f);
			scene.lastChild().scale(0.21000f, 0.14000f, 0.15000f);
			scene.lastChild().rotateQ(0.70711f, -0.70711f, 0.00000f, 0.00000f);
			scene.lastChild().translate(3.52833f, -0.67549f, 0.06685f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(0.00000f, 0.00000f, 0.00000f);

			scene.addChild(new Object("telapakkanandepan.001"));
			scene.lastChild().createBall(0.5f);
			scene.lastChild().scale(0.21000f, 0.14000f, 0.15000f);
			scene.lastChild().rotateQ(0.70711f, -0.70711f, 0.00000f, 0.00000f);
			scene.lastChild().translate(4.92833f, -0.62549f, 0.06685f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(0.00000f, 0.00000f, 0.00000f);

			scene.addChild(new Object("dauntelingakanan"));
			scene.lastChild().createTorus();
			scene.lastChild().scale(0.12000f, 0.13000f, 0.22000f);
			scene.lastChild().rotateQ(0.83597f, -0.00692f, 0.54747f, -0.03719f);
			scene.lastChild().translate(5.61695f, -0.71472f, 2.46059f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(0.00000f, 0.00000f, 0.00000f);

			scene.addChild(new Object("dauntelingakiri"));
			scene.lastChild().createTorus();
			scene.lastChild().scale(0.12000f, 0.13000f, 0.22000f);
			scene.lastChild().rotateQ(0.83597f, -0.00692f, 0.54747f, -0.03719f);
			scene.lastChild().translate(5.61695f, 0.07528f, 2.46059f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(0.00000f, 0.00000f, 0.00000f);

			scene.addChild(new Object("telinga"));
			scene.lastChild().createCircle();
			scene.lastChild().scale(0.12000f, 0.13000f, 1.00000f);
			scene.lastChild().rotateQ(0.80953f, 0.00000f, 0.58708f, 0.00000f);
			scene.lastChild().translate(5.63695f, -0.71472f, 2.47059f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(1.00000f, 0.01795f, 0.00876f);

			scene.addChild(new Object("telinga2"));
			scene.lastChild().createCircle();
			scene.lastChild().scale(-0.12000f, -0.15000f, -1.00000f);
			scene.lastChild().rotateQ(0.31068f, 0.00000f, 0.95052f, 0.00000f);
			scene.lastChild().translate(5.63695f, 0.09125f, 2.45011f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(1.00000f, 0.01795f, 0.00876f);

			scene.addChild(new Object("mata kiri"));
			scene.lastChild().createBall();
			scene.lastChild().scale(-0.06000f, -0.11000f, -0.12000f);
			scene.lastChild().rotateQ(0.93203f, 0.05510f, -0.35802f, -0.01046f);
			scene.lastChild().translate(5.84382f, -0.15875f, 2.33011f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(0.80000f, 0.80000f, 0.80000f);

			scene.addChild(new Object("mata kanan"));
			scene.lastChild().createBall();
			scene.lastChild().scale(-0.06000f, -0.11000f, -0.12000f);
			scene.lastChild().rotateQ(0.92956f, -0.06651f, -0.36240f, 0.01293f);
			scene.lastChild().translate(5.83421f, -0.52472f, 2.33059f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(0.80000f, 0.80000f, 0.80000f);

			scene.addChild(new Object("bolamatakiri"));
			scene.lastChild().createBall();
			scene.lastChild().scale(0.05000f, 0.05000f, 0.05000f);
			scene.lastChild().rotateQ(0.15021f, 0.15632f, 0.02406f, -0.97592f);
			scene.lastChild().translate(5.88382f, -0.15472f, 2.35058f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(0.00000f, 0.00000f, 0.00000f);

			scene.addChild(new Object("bolamatakanan"));
			scene.lastChild().createBall();
			scene.lastChild().scale(0.05000f, 0.05000f, 0.05000f);
			scene.lastChild().rotateQ(0.15021f, 0.15632f, 0.02406f, -0.97592f);
			scene.lastChild().translate(5.86421f, -0.52472f, 2.35058f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(0.00000f, 0.00000f, 0.00000f);

			scene.addChild(new Object("ekor"));
			scene.lastChild().createBall();
			scene.lastChild().scale(0.44000f, 0.17000f, 0.16000f);
			scene.lastChild().rotateQ(0.93327f, 0.00000f, 0.35918f, 0.00000f);
			scene.lastChild().translate(2.55695f, -0.23875f, 1.88011f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(0.01002f, 0.01002f, 0.01002f);

			scene.addChild(new Object("timmy"));

			{ // Children of 'timmy'

				scene.lastChild().addChild(new Object("kakiKanantim"));
				scene.lastChild().lastChild().createCylinder();
				scene.lastChild().lastChild().scale(0.07000f, 0.05000f, 0.31000f);
				scene.lastChild().lastChild().rotateQ(0.49606f, 0.50391f, 0.50391f, 0.49606f);
				scene.lastChild().lastChild().translate(0.25000f, -0.27958f, -0.58512f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.03522f, 0.03522f, 0.03522f);

				scene.lastChild().addChild(new Object("kakikiritim"));
				scene.lastChild().lastChild().createCylinder();
				scene.lastChild().lastChild().scale(0.07000f, 0.05000f, 0.31000f);
				scene.lastChild().lastChild().rotateQ(0.49606f, 0.50391f, 0.50391f, 0.49606f);
				scene.lastChild().lastChild().translate(0.25000f, 0.06042f, -0.58512f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.03522f, 0.03522f, 0.03522f);

				scene.lastChild().addChild(new Object("tangankiritimmy"));
				scene.lastChild().lastChild().createCylinder();
				scene.lastChild().lastChild().scale(0.08000f, 0.06000f, 0.27000f);
				scene.lastChild().lastChild().rotateQ(0.00000f, 0.00000f, -0.45166f, 0.89219f);
				scene.lastChild().lastChild().translate(0.00431f, 0.37447f, 0.20897f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.00000f, 0.00000f, 0.00000f);

				scene.lastChild().addChild(new Object("matakanantimmy.001"));
				scene.lastChild().lastChild().createBall(0.5f);
				scene.lastChild().lastChild().scale(0.08000f, 0.05000f, 0.08000f);
				scene.lastChild().lastChild().rotateQ(0.83093f, -0.05009f, -0.03335f, 0.55311f);
				scene.lastChild().lastChild().translate(0.50433f, -0.23794f, 0.63473f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.62666f, 0.62666f, 0.62666f);

				scene.lastChild().addChild(new Object("matakiritimmy"));
				scene.lastChild().lastChild().createBall(0.5f);
				scene.lastChild().lastChild().scale(0.08000f, 0.05000f, 0.08000f);
				scene.lastChild().lastChild().rotateQ(0.57569f, -0.00553f, -0.00785f, 0.81761f);
				scene.lastChild().lastChild().translate(0.50433f, 0.01206f, 0.63473f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.62666f, 0.62666f, 0.62666f);

				scene.lastChild().addChild(new Object("matakiritimmy.001"));
				scene.lastChild().lastChild().createBall(0.5f);
				scene.lastChild().lastChild().scale(0.04000f, 0.01000f, 0.04000f);
				scene.lastChild().lastChild().rotateQ(-0.00785f, 0.81761f, -0.57569f, 0.00553f);
				scene.lastChild().lastChild().translate(0.55433f, 0.01206f, 0.63473f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.02539f, 0.02539f, 0.02539f);

				scene.lastChild().addChild(new Object("matkananitimmy.002"));
				scene.lastChild().lastChild().createBall(0.5f);
				scene.lastChild().lastChild().scale(-0.04000f, -0.01000f, -0.04000f);
				scene.lastChild().lastChild().rotateQ(0.99991f, -0.00980f, -0.00960f, -0.00009f);
				scene.lastChild().lastChild().translate(0.55433f, -0.23794f, 0.63473f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.02539f, 0.02539f, 0.02539f);

				scene.lastChild().addChild(new Object("mpengtengah"));
				scene.lastChild().lastChild().createBall(0.5f);
				scene.lastChild().lastChild().scale(-0.07000f, -0.07000f, -0.06000f);
				scene.lastChild().lastChild().rotateQ(0.89668f, 0.30438f, 0.30438f, -0.10332f);
				scene.lastChild().lastChild().translate(0.61433f, -0.12794f, 0.16472f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.05839f, 0.82756f, 0.12567f);

				scene.lastChild().addChild(new Object("telapaktabgabtimmykiri.001"));
				scene.lastChild().lastChild().createBall(0.5f);
				scene.lastChild().lastChild().scale(-0.11000f, -0.14000f, -0.14000f);
				scene.lastChild().lastChild().rotateQ(0.81513f, -0.57928f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(0.05433f, 0.63206f, 0.13472f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.01109f, 0.01109f, 0.01109f);

				scene.lastChild().addChild(new Object("telapaktimmykanan"));
				scene.lastChild().lastChild().createBall(0.5f);
				scene.lastChild().lastChild().scale(-0.11000f, -0.14000f, -0.14000f);
				scene.lastChild().lastChild().rotateQ(0.99992f, -0.00793f, 0.00945f, 0.00009f);
				scene.lastChild().lastChild().translate(0.62433f, -0.30794f, -0.55527f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.01109f, 0.01109f, 0.01109f);

				scene.lastChild().addChild(new Object("telapaktimmykiri"));
				scene.lastChild().lastChild().createBall(0.5f);
				scene.lastChild().lastChild().scale(-0.11000f, -0.14000f, -0.14000f);
				scene.lastChild().lastChild().rotateQ(0.99992f, -0.00793f, 0.00945f, 0.00009f);
				scene.lastChild().lastChild().translate(0.62433f, 0.01206f, -0.55527f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.01109f, 0.01109f, 0.01109f);

				scene.lastChild().addChild(new Object("telingtimmyanan"));
				scene.lastChild().lastChild().createBall(0.5f);
				scene.lastChild().lastChild().scale(-0.07000f, -0.14000f, -0.17000f);
				scene.lastChild().lastChild().rotateQ(0.00000f, 0.00000f, -0.00000f, 1.00000f);
				scene.lastChild().lastChild().translate(0.40048f, -0.42644f, 0.77948f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.01109f, 0.01109f, 0.01109f);

				scene.lastChild().addChild(new Object("telingtimmykiri"));
				scene.lastChild().lastChild().createBall(0.5f);
				scene.lastChild().lastChild().scale(-0.07000f, -0.14000f, -0.17000f);
				scene.lastChild().lastChild().rotateQ(0.42262f, -0.90631f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(0.40048f, 0.12356f, 0.77948f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.01109f, 0.01109f, 0.01109f);

				scene.lastChild().addChild(new Object("mpengdasar"));
				scene.lastChild().lastChild().createTorus(0.5f);
				scene.lastChild().lastChild().scale(0.17000f, 0.28000f, 0.32000f);
				scene.lastChild().lastChild().rotateQ(0.70424f, 0.19729f, 0.18398f, 0.65671f);
				scene.lastChild().lastChild().translate(0.34884f, -0.11399f, 0.32662f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.57776f, 0.80000f, 0.00000f);

				scene.lastChild().addChild(new Object("Tangantimmy"));

				{ // Children of 'Tangantimmy'

					scene.lastChild().lastChild().addChild(new Object("tangankannantimy"));
					scene.lastChild().lastChild().lastChild().createCylinder();
					scene.lastChild().lastChild().lastChild().scale(0.08000f, 0.06000f, 0.27000f);
					scene.lastChild().lastChild().lastChild().rotateQ(0.00000f, 0.00000f, -0.42572f, 0.90485f);
					scene.lastChild().lastChild().lastChild().translate(0.03431f, -0.26553f, 0.15897f);
					scene.lastChild().lastChild().lastChild().centerOrigin();
					scene.lastChild().lastChild().lastChild().setColor(0.00000f, 0.00000f, 0.00000f);

					scene.lastChild().lastChild().addChild(new Object("telapaktabgabtimmyabab.002"));
					scene.lastChild().lastChild().lastChild().createBall(0.5f);
					scene.lastChild().lastChild().lastChild().scale(-0.11000f, -0.14000f, -0.14000f);
					scene.lastChild().lastChild().lastChild().rotateQ(0.66017f, -0.39719f, 0.41445f, -0.48440f);
					scene.lastChild().lastChild().lastChild().translate(0.12434f, -0.50794f, 0.37472f);
					scene.lastChild().lastChild().lastChild().centerOrigin();
					scene.lastChild().lastChild().lastChild().setColor(0.01109f, 0.01109f, 0.01109f);

				} // Children of 'Tangantimmy'

				scene.lastChild().lastChild().scale(1.00000f, 1.00000f, 1.00000f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-0.16000f, -0.36000f, 0.25000f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(1.0f, 1.0f, 0.0f);

				scene.lastChild().addChild(new Object("badanTimmy"));
				scene.lastChild().lastChild().createBall();
				scene.lastChild().lastChild().scale(0.39000f, 0.44000f, 0.63000f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-0.03431f, -0.09682f, -0.03489f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.80000f, 0.80000f, 0.80000f);

				scene.lastChild().addChild(new Object("kepalatimmy"));
				scene.lastChild().lastChild().createBall();
				scene.lastChild().lastChild().scale(0.22000f, 0.31000f, 0.36000f);
				scene.lastChild().lastChild().rotateQ(0.69403f, -0.71995f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(0.37000f, -0.11958f, 0.29488f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.02910f, 0.02910f, 0.02910f);

				scene.lastChild().addChild(new Object("kepalatimmy.001"));
				scene.lastChild().lastChild().createBall();
				scene.lastChild().lastChild().scale(0.20000f, 0.33000f, 0.43000f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(0.37000f, -0.11958f, 0.44488f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.02910f, 0.02910f, 0.02910f);

				scene.lastChild().addChild(new Object("mpengdpn"));
				scene.lastChild().lastChild().createTorus();
				scene.lastChild().lastChild().scale(0.06000f, 0.06000f, 0.07000f);
				scene.lastChild().lastChild().rotateQ(0.81259f, 0.00000f, 0.58283f, 0.00000f);
				scene.lastChild().lastChild().translate(0.63000f, -0.13958f, 0.08000f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(1.0f, 1.0f, 0.0f);

			} // Children of 'timmy'

			scene.lastChild().scale(1.00000f, 1.00000f, 1.00000f);
			scene.lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
			scene.lastChild().translate(4.61407f, 2.89125f, 7.25011f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(1.0f, 1.0f, 0.0f);

			scene.addChild(new Object("Tramp"));

			{ // Children of 'Tramp'

				scene.lastChild().addChild(new Object("kakitramp1"));
				scene.lastChild().lastChild().createCylinder();
				scene.lastChild().lastChild().scale(0.15000f, 0.14000f, 0.31000f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-0.02000f, 0.93000f, 0.09000f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.80000f, 0.04247f, 0.06105f);

				scene.lastChild().addChild(new Object("kakitramp2"));
				scene.lastChild().lastChild().createCylinder();
				scene.lastChild().lastChild().scale(0.15000f, 0.14000f, 0.31000f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-0.02000f, -0.91000f, 0.09000f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.80000f, 0.04247f, 0.06105f);

				scene.lastChild().addChild(new Object("kakitramp3"));
				scene.lastChild().lastChild().createCylinder();
				scene.lastChild().lastChild().scale(0.15000f, 0.14000f, 0.31000f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-1.06000f, 0.08000f, 0.09000f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.80000f, 0.04247f, 0.06105f);

				scene.lastChild().addChild(new Object("kakitramp4"));
				scene.lastChild().lastChild().createCylinder();
				scene.lastChild().lastChild().scale(0.15000f, 0.14000f, 0.31000f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(1.04000f, 0.08000f, 0.09000f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.80000f, 0.04247f, 0.06105f);

				scene.lastChild().addChild(new Object("Trampkaret"));

				{ // Children of 'Trampkaret'

					scene.lastChild().lastChild().addChild(new Object("karet"));
					scene.lastChild().lastChild().lastChild().createBall(0.5f);
					scene.lastChild().lastChild().lastChild().scale(-1.11681f, -0.01117f, -1.11681f);
					scene.lastChild().lastChild().lastChild().rotateQ(1.00000f, -0.00000f, 0.00000f, 0.00000f);
					scene.lastChild().lastChild().lastChild().translate(-0.05567f, -0.04836f, 0.64472f);
					scene.lastChild().lastChild().lastChild().centerOrigin();
					scene.lastChild().lastChild().lastChild().setColor(0.14524f, 0.14731f, 0.14318f);

					scene.lastChild().lastChild().addChild(new Object("Trampolinepinggir"));
					scene.lastChild().lastChild().lastChild().createTorus(1f, 0.2f);
					scene.lastChild().lastChild().lastChild().scale(1.00000f, 1.00000f, 1.00000f);
					scene.lastChild().lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
					scene.lastChild().lastChild().lastChild().translate(-0.03000f, 0.00000f, 0.57000f);
					scene.lastChild().lastChild().lastChild().centerOrigin();
					scene.lastChild().lastChild().lastChild().setColor(0.35884f, 0.00000f, 0.00245f);

				} // Children of 'Trampkaret'

				scene.lastChild().lastChild().scale(1.00000f, 1.00000f, 1.00000f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(0.04000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(1.0f, 1.0f, 0.0f);

			} // Children of 'Tramp'

			scene.lastChild().scale(1.00000f, 1.00000f, 1.00000f);
			scene.lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
			scene.lastChild().translate(4.61407f, 2.82125f, 0.00011f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(1.0f, 1.0f, 0.0f);



			TanganTimmyRot.s = 0.1f;
		}

		public static void Animations(ref Object scene)
        {

			scene.findChild("timmy").findChild("Tangantimmy").rotateX(TanganTimmyRot.MinMaxBounce(-0.2f, 0.2f));
			scene.findChild("timmy").rotateZ(0.1f);
			scene.findChild("timmy").translateZ(TanganTimmyRot.MinMaxBounce(-0.05f, 0.05f));

        }
    }
}
