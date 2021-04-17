using System;
using System.Collections.Generic;
using System.Text;
using OpenTK.Mathematics;

namespace UTS
{
    class Leonando
    {
		public static Animator KepalaAnjingScale = new Animator();
		public static Animator GoyangBuntutScale = new Animator();
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
			scene.lastChild().rotateQ(0.00000f, 0.00000f, 0.00000f, 1.00000f);
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

			scene.addChild(new Object("KepalaAnjing"));

			{ // Children of 'KepalaAnjing'

				scene.lastChild().addChild(new Object("Kumis"));
				scene.lastChild().lastChild().createFreeformTube(new List<Vector2> {
												new Vector2(-4.10252f, -1.10510f),
												new Vector2(-3.96997f, -1.35472f),
												new Vector2(-3.63807f, -1.58429f),
												new Vector2(-3.20549f, -1.75488f),
												new Vector2(-2.77087f, -1.82761f),
												new Vector2(-2.43286f, -1.76356f),
												new Vector2(-2.10398f, -1.49187f),
												new Vector2(-1.93332f, -1.18185f),
												new Vector2(-1.82638f, -0.84463f),
												new Vector2(-1.68866f, -0.49130f),
												new Vector2(-1.42569f, -0.13298f),
												new Vector2(-1.16385f, 0.03774f),
												new Vector2(-0.86970f, 0.08804f),
												new Vector2(-0.57907f, 0.02631f),
												new Vector2(-0.32781f, -0.13903f),
												new Vector2(-0.15177f, -0.39961f),
												new Vector2(0.00710f, -0.51349f),
												new Vector2(0.21059f, -0.31534f),
												new Vector2(0.45692f, 0.01971f),
												new Vector2(0.74434f, 0.31652f),
												new Vector2(1.07109f, 0.39995f),
												new Vector2(1.51746f, 0.11590f),
												new Vector2(1.83045f, -0.38407f),
												new Vector2(2.09897f, -0.95601f),
												new Vector2(2.41196f, -1.45598f),
												new Vector2(2.85833f, -1.74004f),
												new Vector2(3.20083f, -1.70400f),
												new Vector2(3.53665f, -1.50595f),
												new Vector2(3.82352f, -1.24597f),
												new Vector2(4.01912f, -1.02413f),
												new Vector2(4.08118f, -0.94048f),
									}, 1f, 0.01f);
				scene.lastChild().lastChild().scale(0.10553f, 0.16553f, 0.20553f);
				scene.lastChild().lastChild().rotateQ(0.50000f, 0.50000f, 0.50000f, 0.50000f);
				scene.lastChild().lastChild().translate(0.68000f, -0.03000f, 0.84000f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.00000f, 0.00000f, 0.00000f);

				scene.lastChild().addChild(new Object("TelingaKanan"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.28000f, 0.06000f, 0.22000f);
				scene.lastChild().lastChild().rotateQ(0.98277f, -0.18481f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-0.09000f, -0.58000f, 0.71000f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.31765f, 0.19216f, 0.03922f);

				scene.lastChild().addChild(new Object("TelingaKiri"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.28000f, 0.06000f, 0.22000f);
				scene.lastChild().lastChild().rotateQ(0.98277f, 0.18481f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-0.09000f, 0.57000f, 0.71000f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.31765f, 0.19216f, 0.03922f);

				scene.lastChild().addChild(new Object("Kepala"));
				scene.lastChild().lastChild().createCylinder();
				scene.lastChild().lastChild().scale(0.56409f, 0.56409f, 0.66713f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-0.06000f, -0.00000f, 0.73000f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.98824f, 0.72157f, 0.16078f);

				scene.lastChild().addChild(new Object("Lidah"));
				scene.lastChild().lastChild().createCylinder();
				scene.lastChild().lastChild().scale(0.37987f, 0.18635f, 0.06451f);
				scene.lastChild().lastChild().rotateQ(0.96858f, 0.00000f, 0.24869f, 0.00000f);
				scene.lastChild().lastChild().translate(0.66000f, -0.03000f, -0.19000f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.80000f, 0.04368f, 0.06054f);

				scene.lastChild().addChild(new Object("MoncongHidung"));
				scene.lastChild().lastChild().createCylinder();
				scene.lastChild().lastChild().scale(0.45129f, 0.45129f, 0.39890f);
				scene.lastChild().lastChild().rotateQ(0.70711f, 0.00000f, -0.70711f, 0.00000f);
				scene.lastChild().lastChild().translate(0.55000f, -0.00000f, 0.38000f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.98824f, 0.72157f, 0.16078f);

				scene.lastChild().addChild(new Object("MulutAtas"));
				scene.lastChild().lastChild().createCylinder();
				scene.lastChild().lastChild().scale(0.82405f, 0.70405f, 0.09732f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(0.07000f, -0.00000f, -0.01000f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.98824f, 0.72157f, 0.16078f);

				scene.lastChild().addChild(new Object("MulutBawah"));
				scene.lastChild().lastChild().createCylinder();
				scene.lastChild().lastChild().scale(0.64392f, 0.64392f, 0.07605f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(0.04000f, -0.00000f, -0.21000f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.98824f, 0.72157f, 0.16078f);

				scene.lastChild().addChild(new Object("HidungDepan"));
				scene.lastChild().lastChild().createBall(0.5f);
				scene.lastChild().lastChild().scale(0.42832f, 0.42832f, 0.42832f);
				scene.lastChild().lastChild().rotateQ(0.70711f, 0.00000f, 0.00000f, 0.70711f);
				scene.lastChild().lastChild().translate(0.90840f, -0.00711f, 0.38484f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.08627f, 0.06275f, 0.01290f);

				scene.lastChild().addChild(new Object("MataKanan"));
				scene.lastChild().lastChild().createBall(0.5f);
				scene.lastChild().lastChild().scale(0.07312f, 0.09312f, 0.09312f);
				scene.lastChild().lastChild().rotateQ(0.70711f, 0.00000f, 0.00000f, 0.70711f);
				scene.lastChild().lastChild().translate(0.47840f, -0.10711f, 0.99484f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(1.00000f, 1.00000f, 1.00000f);

				scene.lastChild().addChild(new Object("MataKiri"));
				scene.lastChild().lastChild().createBall(0.5f);
				scene.lastChild().lastChild().scale(0.07312f, 0.09312f, 0.09312f);
				scene.lastChild().lastChild().rotateQ(0.70711f, 0.00000f, 0.00000f, 0.70711f);
				scene.lastChild().lastChild().translate(0.47840f, 0.09289f, 0.99484f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(1.00000f, 1.00000f, 1.00000f);

				scene.lastChild().addChild(new Object("PupilKanan"));
				scene.lastChild().lastChild().createBall(0.5f);
				scene.lastChild().lastChild().scale(0.03591f, 0.02573f, 0.04573f);
				scene.lastChild().lastChild().rotateQ(0.70711f, 0.00000f, 0.00000f, 0.70711f);
				scene.lastChild().lastChild().translate(0.55840f, -0.10711f, 0.99484f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.00000f, 0.00000f, 0.00000f);

				scene.lastChild().addChild(new Object("PupilKiri"));
				scene.lastChild().lastChild().createBall(0.5f);
				scene.lastChild().lastChild().scale(0.03591f, 0.02573f, 0.04573f);
				scene.lastChild().lastChild().rotateQ(0.70711f, 0.00000f, 0.00000f, 0.70711f);
				scene.lastChild().lastChild().translate(0.55840f, 0.09289f, 0.99484f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.00000f, 0.00000f, 0.00000f);

				scene.lastChild().addChild(new Object("TopiAtas"));
				scene.lastChild().lastChild().createBall(0.5f);
				scene.lastChild().lastChild().scale(0.51187f, 0.51187f, 0.51187f);
				scene.lastChild().lastChild().rotateQ(0.50000f, -0.50000f, -0.50000f, 0.50000f);
				scene.lastChild().lastChild().translate(-0.04160f, -0.00711f, 1.34484f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.07451f, 0.32157f, 0.50588f);

				scene.lastChild().addChild(new Object("TopiTepi"));
				scene.lastChild().lastChild().createTorus();
				scene.lastChild().lastChild().scale(0.56735f, 0.56735f, 0.56735f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-0.02000f, -0.00000f, 1.29000f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.07451f, 0.32157f, 0.50588f);

			} // Children of 'KepalaAnjing'

			scene.lastChild().scale(1.00000f, 1.00000f, 1.00000f);
			scene.lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
			scene.lastChild().translate(7.30000f, 5.54000f, 4.04000f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(1.0f, 1.0f, 0.0f);

			scene.addChild(new Object("Pagar.017"));
			scene.lastChild().createCube();
			scene.lastChild().scale(0.10000f, 0.10000f, 1.00000f);
			scene.lastChild().rotateQ(0.92388f, 0.00000f, 0.00000f, 0.38268f);
			scene.lastChild().translate(9.27560f, -7.68000f, 0.91000f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(0.08627f, 0.06275f, 0.01290f);

			scene.addChild(new Object("Pagar.001"));
			scene.lastChild().createCube();
			scene.lastChild().scale(0.10000f, 0.10000f, 1.64000f);
			scene.lastChild().rotateQ(0.70711f, 0.70711f, 0.00000f, 0.00000f);
			scene.lastChild().translate(9.27560f, -6.16000f, 0.26000f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(0.31765f, 0.19216f, 0.03922f);

			scene.addChild(new Object("Pagar.002"));
			scene.lastChild().createCube();
			scene.lastChild().scale(0.10000f, 0.10000f, 1.00000f);
			scene.lastChild().rotateQ(0.92388f, 0.00000f, 0.00000f, 0.38268f);
			scene.lastChild().translate(9.27560f, -4.55000f, 0.91000f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(0.08627f, 0.06275f, 0.01290f);

			scene.addChild(new Object("Pagar.003"));
			scene.lastChild().createCube();
			scene.lastChild().scale(0.10000f, 0.10000f, 1.64000f);
			scene.lastChild().rotateQ(0.70711f, 0.70711f, 0.00000f, 0.00000f);
			scene.lastChild().translate(9.27560f, -6.16000f, 1.38000f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(0.31765f, 0.19216f, 0.03922f);

			scene.addChild(new Object("Pagar.004"));
			scene.lastChild().createCube();
			scene.lastChild().scale(0.10000f, 0.10000f, 1.64000f);
			scene.lastChild().rotateQ(0.65328f, 0.65328f, 0.27060f, -0.27060f);
			scene.lastChild().translate(9.27560f, -6.16000f, 0.78000f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(0.31765f, 0.19216f, 0.03922f);

			scene.addChild(new Object("Pagar.005"));
			scene.lastChild().createCube();
			scene.lastChild().scale(0.10000f, 0.10000f, 1.64000f);
			scene.lastChild().rotateQ(0.81915f, -0.57358f, 0.00000f, 0.00000f);
			scene.lastChild().translate(9.27560f, -6.16000f, 0.78000f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(0.31765f, 0.19216f, 0.03922f);

			scene.addChild(new Object("Pagar.006"));
			scene.lastChild().createCube();
			scene.lastChild().scale(0.10000f, 0.10000f, 1.64000f);
			scene.lastChild().rotateQ(0.81915f, 0.57358f, 0.00000f, 0.00000f);
			scene.lastChild().translate(9.27560f, -6.16000f, 0.78000f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(0.31765f, 0.19216f, 0.03922f);

			scene.addChild(new Object("Pagar.013"));
			scene.lastChild().createCube();
			scene.lastChild().scale(0.10000f, 0.10000f, 0.60000f);
			scene.lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
			scene.lastChild().translate(9.69717f, -2.12241f, 1.02326f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(0.08627f, 0.06275f, 0.01290f);

			scene.addChild(new Object("Pagar.012"));
			scene.lastChild().createCube();
			scene.lastChild().scale(0.10000f, 0.10000f, 0.46000f);
			scene.lastChild().rotateQ(0.70711f, 0.70711f, 0.00000f, 0.00000f);
			scene.lastChild().translate(9.69717f, -2.48241f, 0.93326f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(0.31765f, 0.19216f, 0.03922f);

			scene.addChild(new Object("Pagar.011"));
			scene.lastChild().createCube();
			scene.lastChild().scale(0.10000f, 0.10000f, 1.00000f);
			scene.lastChild().rotateQ(0.92388f, 0.00000f, 0.00000f, 0.38268f);
			scene.lastChild().translate(9.69717f, -0.92241f, 1.02326f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(0.08627f, 0.06275f, 0.01290f);

			scene.addChild(new Object("Pagar.010"));
			scene.lastChild().createCube();
			scene.lastChild().scale(0.10000f, 0.10000f, 1.64000f);
			scene.lastChild().rotateQ(0.70711f, 0.70711f, 0.00000f, 0.00000f);
			scene.lastChild().translate(9.69717f, -2.53241f, 1.49326f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(0.31765f, 0.19216f, 0.03922f);

			scene.addChild(new Object("Pagar.009"));
			scene.lastChild().createCube();
			scene.lastChild().scale(0.10000f, 0.10000f, 0.71000f);
			scene.lastChild().rotateQ(0.65328f, 0.65328f, 0.27060f, -0.27060f);
			scene.lastChild().translate(9.69717f, -3.45241f, 0.89326f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(0.31765f, 0.19216f, 0.03922f);

			scene.addChild(new Object("Pagar.016"));
			scene.lastChild().createCube();
			scene.lastChild().scale(0.10000f, 0.10000f, 1.00000f);
			scene.lastChild().rotateQ(0.92388f, 0.00000f, 0.00000f, 0.38268f);
			scene.lastChild().translate(9.69717f, -4.05241f, 1.02326f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(0.08627f, 0.06275f, 0.01290f);

			scene.addChild(new Object("Pagar.007"));
			scene.lastChild().createCube();
			scene.lastChild().scale(0.10000f, 0.10000f, 0.60000f);
			scene.lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
			scene.lastChild().translate(9.69717f, -2.81241f, 1.02326f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(0.08627f, 0.06275f, 0.01290f);

			scene.addChild(new Object("Pagar.008"));
			scene.lastChild().createCube();
			scene.lastChild().scale(0.10000f, 0.10000f, 0.72000f);
			scene.lastChild().rotateQ(0.65328f, 0.65328f, 0.27060f, -0.27060f);
			scene.lastChild().translate(9.69717f, -3.46241f, 0.44326f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(0.31765f, 0.19216f, 0.03922f);

			scene.addChild(new Object("Pagar.015"));
			scene.lastChild().createCube();
			scene.lastChild().scale(0.10000f, 0.10000f, 0.72000f);
			scene.lastChild().rotateQ(0.65328f, 0.65328f, 0.27060f, -0.27060f);
			scene.lastChild().translate(9.69717f, -1.51241f, 0.46326f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(0.31765f, 0.19216f, 0.03922f);

			scene.addChild(new Object("Pagar"));
			scene.lastChild().createCube();
			scene.lastChild().scale(0.10000f, 0.10000f, 0.71000f);
			scene.lastChild().rotateQ(0.65328f, 0.65328f, 0.27060f, -0.27060f);
			scene.lastChild().translate(9.69717f, -1.50241f, 0.89326f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(0.31765f, 0.19216f, 0.03922f);

			scene.addChild(new Object("BuntutPusat"));

			{ // Children of 'BuntutPusat'

				scene.lastChild().addChild(new Object("EkorLengkung"));
				scene.lastChild().lastChild().createFreeformTube(new List<Vector2> {
												new Vector2(-1.80755f, -0.98517f),
												new Vector2(-1.66045f, -0.82033f),
												new Vector2(-1.48165f, -0.71185f),
												new Vector2(-1.28969f, -0.67060f),
												new Vector2(-1.10305f, -0.70741f),
												new Vector2(-0.94028f, -0.83312f),
												new Vector2(-0.80743f, -1.10283f),
												new Vector2(-0.73521f, -1.43205f),
												new Vector2(-0.66919f, -1.75419f),
												new Vector2(-0.55495f, -2.00264f),
												new Vector2(-0.33807f, -2.11081f),
												new Vector2(0.17896f, -1.93905f),
												new Vector2(0.47532f, -1.43880f),
												new Vector2(0.63550f, -0.74143f),
												new Vector2(0.74398f, 0.02171f),
												new Vector2(0.88525f, 0.71925f),
												new Vector2(1.06257f, 0.99636f),
												new Vector2(1.38102f, 1.26436f),
												new Vector2(1.75946f, 1.47754f),
												new Vector2(2.11679f, 1.59022f),
												new Vector2(2.37188f, 1.55669f),
									});
				scene.lastChild().lastChild().scale(0.21116f, 0.21116f, 0.21116f);
				scene.lastChild().lastChild().rotateQ(0.15425f, -0.15425f, -0.69008f, -0.69008f);
				scene.lastChild().lastChild().translate(-0.28384f, -0.05000f, 0.57896f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.98824f, 0.72157f, 0.16078f);

			} // Children of 'BuntutPusat'

			scene.lastChild().scale(1.00000f, 1.00000f, 1.00000f);
			scene.lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
			scene.lastChild().translate(3.56384f, 5.62000f, 3.04104f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(1.0f, 1.0f, 0.0f);












			KepalaAnjingScale.s = 0.2f;
			GoyangBuntutScale.s = 0.8f;
		}

		public static void Animations(ref Object scene)
        {
			scene.findChild("KepalaAnjing").rotateX(KepalaAnjingScale.MinMaxBounce(-0.4f, 0.4f));
			scene.findChild("KepalaAnjing").findChild("TelingaKanan").rotateX(KepalaAnjingScale.MinMaxBounce(-0.4f, 0.4f));
			scene.findChild("KepalaAnjing").findChild("TelingaKiri").rotateX(KepalaAnjingScale.MinMaxBounce(0.4f, -0.4f));
			scene.findChild("KepalaAnjing").findChild("Lidah").translateX(KepalaAnjingScale.MinMaxBounce(-0.005f, 0.005f));
			scene.findChild("BuntutPusat").rotateX(GoyangBuntutScale.MinMaxBounce(-0.8f, 0.8f));
		}
    }
}
