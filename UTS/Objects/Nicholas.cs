﻿using System;
using System.Collections.Generic;
using System.Text;
using OpenTK.Mathematics;

namespace UTS
{
    class Nicholas
    {

        public static Animator DaunPohonAnimator = new Animator();
        public static Animator RumahAnimator = new Animator();


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
			scene.lastChild().scale(2.07208f, 1.40352f, 1.06670f);
			scene.lastChild().rotateQ(0.78965f, -0.00342f, 0.02680f, -0.61296f);
			scene.lastChild().translate(-1.83364f, 1.50153f, 17.05134f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(1.00000f, 1.00000f, 1.00000f);

			scene.addChild(new Object("Awan.002"));
			scene.lastChild().createBall();
			scene.lastChild().scale(1.67567f, 1.13501f, 0.86263f);
			scene.lastChild().rotateQ(0.78965f, -0.00342f, 0.02680f, -0.61296f);
			scene.lastChild().translate(-2.23724f, 2.98004f, 17.61919f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(1.00000f, 1.00000f, 1.00000f);

			scene.addChild(new Object("Awan.003"));
			scene.lastChild().createBall();
			scene.lastChild().scale(1.67567f, 1.13501f, 0.86263f);
			scene.lastChild().rotateQ(0.78965f, -0.00342f, 0.02680f, -0.61296f);
			scene.lastChild().translate(-2.26396f, 3.50819f, 16.68179f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(1.00000f, 1.00000f, 1.00000f);

			scene.addChild(new Object("Awan.006"));
			scene.lastChild().createBall();
			scene.lastChild().scale(1.90952f, 0.82185f, 0.62462f);
			scene.lastChild().rotateQ(0.88356f, 0.03150f, 0.01511f, -0.46702f);
			scene.lastChild().translate(-7.08742f, -9.34892f, 14.52589f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(1.00000f, 1.00000f, 1.00000f);

			scene.addChild(new Object("Awan.005"));
			scene.lastChild().createBall();
			scene.lastChild().scale(1.31232f, 0.66462f, 0.50513f);
			scene.lastChild().rotateQ(0.88993f, 0.01477f, 0.02182f, -0.45534f);
			scene.lastChild().translate(-7.40539f, -8.93529f, 15.14743f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(1.00000f, 1.00000f, 1.00000f);

			scene.addChild(new Object("Awan.004"));
			scene.lastChild().createBall();
			scene.lastChild().scale(0.98121f, 0.66462f, 0.50513f);
			scene.lastChild().rotateQ(0.88356f, 0.03150f, 0.01511f, -0.46702f);
			scene.lastChild().translate(-7.59711f, -8.28659f, 14.62639f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(1.00000f, 1.00000f, 1.00000f);

			scene.addChild(new Object("Awan.007"));
			scene.lastChild().createBall();
			scene.lastChild().scale(2.41138f, 0.57665f, 0.53432f);
			scene.lastChild().rotateQ(0.39859f, -0.25507f, 0.42354f, -0.77245f);
			scene.lastChild().translate(-9.06234f, 0.17659f, 16.12335f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(1.00000f, 1.00000f, 1.00000f);

			scene.addChild(new Object("Awan.008"));
			scene.lastChild().createBall();
			scene.lastChild().scale(1.06658f, 0.57665f, 0.43826f);
			scene.lastChild().rotateQ(0.39859f, -0.25507f, 0.42354f, -0.77245f);
			scene.lastChild().translate(-8.48477f, 0.78060f, 16.55188f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(1.00000f, 1.00000f, 1.00000f);

			scene.addChild(new Object("Awan"));
			scene.lastChild().createBall();
			scene.lastChild().scale(1.33849f, 0.78395f, 0.64813f);
			scene.lastChild().rotateQ(0.39859f, -0.25507f, 0.42354f, -0.77245f);
			scene.lastChild().translate(-9.64145f, -0.40077f, 16.67460f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(1.00000f, 1.00000f, 1.00000f);

			scene.addChild(new Object("PelangiBlue"));
			scene.lastChild().createTorus(0.5f, 0.25f);
			scene.lastChild().scale(6.56084f, 6.56084f, 6.56083f);
			scene.lastChild().rotateQ(0.43320f, -0.33389f, 0.63576f, -0.54467f);
			scene.lastChild().translate(-4.57739f, -2.79034f, 15.86984f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(0.00000f, 0.00000f, 1.00000f);

			scene.addChild(new Object("PelangiGreen"));
			scene.lastChild().createTorus(0.5f, 0.25f);
			scene.lastChild().scale(6.83390f, 6.56083f, 6.56083f);
			scene.lastChild().rotateQ(0.43320f, -0.33389f, 0.63576f, -0.54467f);
			scene.lastChild().translate(-4.64768f, -2.91066f, 16.33429f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(0.00000f, 1.00000f, 0.00000f);

			scene.addChild(new Object("PelangiRed"));
			scene.lastChild().createTorus(0.5f, 0.25f);
			scene.lastChild().scale(7.05235f, 6.56084f, 6.56084f);
			scene.lastChild().rotateQ(0.43320f, -0.33389f, 0.63576f, -0.54467f);
			scene.lastChild().translate(-4.66383f, -3.06085f, 16.72635f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(1.00000f, 0.00000f, 0.00000f);

			scene.addChild(new Object("Pohon"));

			{ // Children of 'Pohon'

				scene.lastChild().addChild(new Object("BatangPohon"));
				scene.lastChild().lastChild().createCylinder();
				scene.lastChild().lastChild().scale(-0.25413f, -0.25413f, -3.04938f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, -0.00000f);
				scene.lastChild().lastChild().translate(0.00000f, 0.00000f, 2.82216f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.10946f, 0.07036f, 0.03071f);

				scene.lastChild().addChild(new Object("CabangPohon"));
				scene.lastChild().lastChild().createCylinder();
				scene.lastChild().lastChild().scale(0.05501f, 0.05501f, 1.07105f);
				scene.lastChild().lastChild().rotateQ(0.94119f, 0.16041f, 0.23142f, -0.18674f);
				scene.lastChild().lastChild().translate(0.60468f, -0.51829f, 4.65493f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.10946f, 0.07036f, 0.03071f);

				scene.lastChild().addChild(new Object("CabangPohon.001"));
				scene.lastChild().lastChild().createCylinder();
				scene.lastChild().lastChild().scale(0.05501f, 0.05501f, 0.49105f);
				scene.lastChild().lastChild().rotateQ(0.91689f, -0.28363f, 0.27890f, -0.03282f);
				scene.lastChild().lastChild().translate(0.38745f, 0.43689f, 4.82984f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.10946f, 0.07036f, 0.03071f);

				scene.lastChild().addChild(new Object("CabangPohon.002"));
				scene.lastChild().lastChild().createCylinder();
				scene.lastChild().lastChild().scale(0.05501f, 0.05501f, 0.57105f);
				scene.lastChild().lastChild().rotateQ(0.34812f, -0.25946f, -0.15753f, 0.88695f);
				scene.lastChild().lastChild().translate(-0.44541f, 0.09240f, 4.58072f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.10946f, 0.07036f, 0.03071f);

				scene.lastChild().addChild(new Object("CabangPohon.003"));
				scene.lastChild().lastChild().createCylinder();
				scene.lastChild().lastChild().scale(0.13503f, 0.13503f, 0.75786f);
				scene.lastChild().lastChild().rotateQ(0.86250f, 0.47713f, 0.13920f, -0.09520f);
				scene.lastChild().lastChild().translate(0.18068f, -0.79254f, 2.88265f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.10946f, 0.07036f, 0.03071f);

				scene.lastChild().addChild(new Object("DaunPohon"));
				scene.lastChild().lastChild().createBall();
				scene.lastChild().lastChild().scale(1.93883f, 1.81343f, 0.73310f);
				scene.lastChild().lastChild().rotateQ(0.93909f, 0.00000f, 0.00000f, -0.34366f);
				scene.lastChild().lastChild().translate(0.62925f, 0.89236f, 6.59788f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.57758f, 0.52712f, 0.14996f);

				scene.lastChild().addChild(new Object("DaunPohon.001"));
				scene.lastChild().lastChild().createBall();
				scene.lastChild().lastChild().scale(2.64469f, 2.47364f, 1.00000f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(0.29603f, -0.55908f, 5.76141f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.57758f, 0.52712f, 0.14996f);

				scene.lastChild().addChild(new Object("DaunPohon.002"));
				scene.lastChild().lastChild().createBall();
				scene.lastChild().lastChild().scale(2.64469f, 2.55364f, 1.13000f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-0.03109f, -2.43850f, 3.95017f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.57758f, 0.52712f, 0.14996f);

			} // Children of 'Pohon'

			scene.lastChild().scale(1.00000f, 1.00000f, 1.00000f);
			scene.lastChild().rotateQ(0.90446f, 0.00000f, 0.00000f, -0.42657f);
			scene.lastChild().translate(-6.14679f, -6.76785f, 0.00000f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(1.0f, 1.0f, 0.0f);

			scene.addChild(new Object("Rumah"));

			{ // Children of 'Rumah'

				scene.lastChild().addChild(new Object("BalokRumah"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(2.54186f, 5.48506f, 2.38957f);
				scene.lastChild().lastChild().rotateQ(0.70711f, 0.00000f, 0.00000f, 0.70711f);
				scene.lastChild().lastChild().translate(-1.72000f, 4.97521f, 0.98627f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.88248f, 0.91310f, 0.61404f);

				scene.lastChild().addChild(new Object("BalokRumah.001"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(2.54186f, 5.48506f, 2.38957f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-4.69363f, 2.04552f, 0.98627f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.88248f, 0.91310f, 0.61404f);

				scene.lastChild().addChild(new Object("BalokRumah.002"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(1.18731f, 0.71908f, 1.05175f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-0.99790f, 1.81140f, -0.36827f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.88248f, 0.91310f, 0.61404f);

				scene.lastChild().addChild(new Object("BalokRumah.003"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(1.67227f, 0.98664f, 1.43637f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-5.56321f, -4.32584f, 0.01635f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.88248f, 0.91310f, 0.61404f);

				scene.lastChild().addChild(new Object("CerobongAsap"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.15050f, 0.61874f, 2.20562f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-5.30378f, 5.10084f, 5.91710f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.88248f, 0.91310f, 0.61404f);

				scene.lastChild().addChild(new Object("CerobongAsap.001"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.15050f, 0.61874f, 2.20562f);
				scene.lastChild().lastChild().rotateQ(0.70711f, 0.00000f, 0.00000f, 0.70711f);
				scene.lastChild().lastChild().translate(-4.80210f, 5.56908f, 5.91710f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.88248f, 0.91310f, 0.61404f);

				scene.lastChild().addChild(new Object("CerobongAsap.002"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.15050f, 0.61874f, 2.20562f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-4.33387f, 5.10084f, 5.91710f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.88248f, 0.91310f, 0.61404f);

				scene.lastChild().addChild(new Object("CerobongAsap.003"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.15050f, 0.61874f, 2.20562f);
				scene.lastChild().lastChild().rotateQ(0.70711f, 0.00000f, 0.00000f, 0.70711f);
				scene.lastChild().lastChild().translate(-4.80210f, 4.63260f, 5.91710f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.88248f, 0.91310f, 0.61404f);

				scene.lastChild().addChild(new Object("Door"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.05052f, 0.49785f, 0.93264f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(0.20352f, 1.76259f, -0.44064f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.20155f, 0.34238f, 0.07519f);

				scene.lastChild().addChild(new Object("Door.001"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.05052f, 0.49785f, 0.93264f);
				scene.lastChild().lastChild().rotateQ(0.70712f, 0.00000f, 0.00000f, -0.70710f);
				scene.lastChild().lastChild().translate(-5.99708f, -5.31530f, -0.45538f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.20155f, 0.34238f, 0.07519f);

				scene.lastChild().addChild(new Object("Matt"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.20102f, 0.49785f, 0.05153f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(0.29336f, 1.75813f, -1.35851f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.10247f, 0.09255f, 0.10184f);

				scene.lastChild().addChild(new Object("Matt.001"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.20102f, 0.49785f, 0.05153f);
				scene.lastChild().lastChild().rotateQ(0.70712f, 0.00000f, 0.00000f, -0.70710f);
				scene.lastChild().lastChild().translate(-6.00154f, -5.40513f, -1.37325f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.10247f, 0.09255f, 0.10184f);

				scene.lastChild().addChild(new Object("Window"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.01707f, 0.19643f, 0.46502f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(0.25291f, 1.54611f, -0.05785f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.001"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.01707f, 0.19643f, 0.46502f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(0.25291f, 1.98718f, -0.05785f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.002"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.01707f, 0.19643f, 0.46502f);
				scene.lastChild().lastChild().rotateQ(0.70712f, 0.00000f, 0.00000f, -0.70710f);
				scene.lastChild().lastChild().translate(-5.77249f, -5.36468f, -0.07260f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.003"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.01707f, 0.19643f, 0.46502f);
				scene.lastChild().lastChild().rotateQ(0.70712f, 0.00000f, 0.00000f, -0.70710f);
				scene.lastChild().lastChild().translate(-6.21356f, -5.36469f, -0.07260f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.004"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.02362f, 0.24862f, 0.24862f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-2.08545f, -2.41336f, 1.25848f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.005"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.02362f, 0.24862f, 0.24862f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-2.08545f, -1.86085f, 1.25848f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.006"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.02362f, 0.24862f, 0.24862f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-2.08545f, -1.86085f, 1.81724f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.007"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.02362f, 0.24862f, 0.24862f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-2.08545f, -2.41336f, 1.81724f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.008"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.02362f, 0.24862f, 0.24862f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-2.08545f, -2.41336f, 0.14803f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.009"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.02362f, 0.24862f, 0.24862f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-2.08545f, -1.86085f, 0.14803f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.010"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.02362f, 0.24862f, 0.24862f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-2.08545f, -1.86085f, -0.41073f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.011"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.02362f, 0.24862f, 0.24862f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-2.08545f, -2.41336f, -0.41073f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.012"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.02362f, 0.24862f, 0.24862f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-2.08545f, -0.38968f, -0.41073f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.013"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.02362f, 0.24862f, 0.24862f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-2.08545f, 0.16284f, -0.41073f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.014"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.02362f, 0.24862f, 0.24862f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-2.08545f, 0.16284f, 0.14803f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.015"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.02362f, 0.24862f, 0.24862f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-2.08545f, -0.38968f, 0.14803f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.016"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.02362f, 0.24862f, 0.24862f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-2.08545f, -0.38968f, 1.81868f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.017"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.02362f, 0.24862f, 0.24862f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-2.08545f, 0.16284f, 1.81868f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.018"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.02362f, 0.24862f, 0.24862f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-2.08545f, 0.16284f, 1.25992f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.019"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.02362f, 0.24862f, 0.24862f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-2.08545f, -0.38968f, 1.25992f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.020"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.02362f, 0.24862f, 0.24862f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(3.80966f, 3.53351f, 1.25992f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.021"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.02362f, 0.24862f, 0.24862f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(3.80966f, 4.08602f, 1.25992f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.022"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.02362f, 0.24862f, 0.24862f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(3.80966f, 4.08602f, 1.81868f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.023"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.02362f, 0.24862f, 0.24862f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(3.80966f, 3.53351f, 1.81868f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.024"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.02362f, 0.24862f, 0.24862f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(3.80966f, 3.53351f, 0.14803f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.025"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.02362f, 0.24862f, 0.24862f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(3.80966f, 4.08602f, 0.14803f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.026"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.02362f, 0.24862f, 0.24862f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(3.80966f, 4.08602f, -0.41073f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.027"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.02362f, 0.24862f, 0.24862f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(3.80966f, 3.53351f, -0.41073f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.028"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.02362f, 0.24862f, 0.24862f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(3.80966f, 5.86446f, -0.41073f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.029"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.02362f, 0.24862f, 0.24862f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(3.80966f, 6.41698f, -0.41073f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.030"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.02362f, 0.24862f, 0.24862f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(3.80966f, 6.41698f, 0.14803f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.031"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.02362f, 0.24862f, 0.24862f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(3.80966f, 5.86446f, 0.14803f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.032"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.02362f, 0.24862f, 0.24862f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(3.80966f, 5.86446f, 1.81868f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.033"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.02362f, 0.24862f, 0.24862f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(3.80966f, 6.41698f, 1.81868f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.034"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.02362f, 0.24862f, 0.24862f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(3.80966f, 6.41698f, 1.25992f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.035"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.02362f, 0.24862f, 0.24862f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(3.80966f, 5.86446f, 1.25992f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.036"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.02362f, 0.24862f, 0.24862f);
				scene.lastChild().lastChild().rotateQ(0.70711f, 0.00000f, 0.00000f, -0.70711f);
				scene.lastChild().lastChild().translate(-4.96208f, -3.68486f, 3.73373f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.037"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.02362f, 0.24862f, 0.24862f);
				scene.lastChild().lastChild().rotateQ(0.70711f, 0.00000f, 0.00000f, -0.70711f);
				scene.lastChild().lastChild().translate(-4.40957f, -3.68486f, 3.73373f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.038"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.02362f, 0.24862f, 0.24862f);
				scene.lastChild().lastChild().rotateQ(0.70711f, 0.00000f, 0.00000f, -0.70711f);
				scene.lastChild().lastChild().translate(-4.40957f, -3.68486f, 4.29249f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.039"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.02362f, 0.24862f, 0.24862f);
				scene.lastChild().lastChild().rotateQ(0.70711f, 0.00000f, 0.00000f, -0.70711f);
				scene.lastChild().lastChild().translate(-4.96208f, -3.68486f, 4.29249f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.040"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.02362f, 0.24862f, 0.24862f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(3.84389f, 4.68401f, 4.29249f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.041"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.02362f, 0.24862f, 0.24862f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(3.84389f, 5.23653f, 4.29249f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.042"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.02362f, 0.24862f, 0.24862f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(3.84389f, 5.23653f, 3.73373f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.043"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.02362f, 0.24862f, 0.24862f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(3.84389f, 4.68401f, 3.73373f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.044"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.02927f, 0.30813f, 0.30813f);
				scene.lastChild().lastChild().rotateQ(0.70711f, 0.00000f, 0.00000f, 0.70711f);
				scene.lastChild().lastChild().translate(-0.97602f, 1.03937f, -0.02413f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.045"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.02927f, 0.30813f, 0.30813f);
				scene.lastChild().lastChild().rotateQ(0.00000f, 0.00000f, 0.00000f, 1.00000f);
				scene.lastChild().lastChild().translate(-3.85334f, -4.38410f, 0.60650f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("WindowFrame"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.05052f, 0.58530f, 0.58530f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-2.13046f, -2.13668f, 1.53122f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.20155f, 0.34238f, 0.07519f);

				scene.lastChild().addChild(new Object("WindowFrame.001"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.05052f, 0.58530f, 0.58530f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-2.13046f, -2.13668f, -0.13799f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.20155f, 0.34238f, 0.07519f);

				scene.lastChild().addChild(new Object("WindowFrame.002"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.05052f, 0.58530f, 0.58530f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-2.13046f, -0.11300f, -0.13799f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.20155f, 0.34238f, 0.07519f);

				scene.lastChild().addChild(new Object("WindowFrame.003"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.05052f, 0.58530f, 0.58530f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-2.13046f, -0.11300f, 1.53266f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.20155f, 0.34238f, 0.07519f);

				scene.lastChild().addChild(new Object("WindowFrame.004"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.05052f, 0.58530f, 0.58530f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(3.76465f, 3.81019f, 1.53266f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.20155f, 0.34238f, 0.07519f);

				scene.lastChild().addChild(new Object("WindowFrame.005"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.05052f, 0.58530f, 0.58530f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(3.76465f, 3.81019f, -0.13799f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.20155f, 0.34238f, 0.07519f);

				scene.lastChild().addChild(new Object("WindowFrame.006"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.05052f, 0.58530f, 0.58530f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(3.76465f, 6.14114f, -0.13799f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.20155f, 0.34238f, 0.07519f);

				scene.lastChild().addChild(new Object("WindowFrame.007"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.05052f, 0.58530f, 0.58530f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(3.76465f, 6.14114f, 1.53266f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.20155f, 0.34238f, 0.07519f);

				scene.lastChild().addChild(new Object("WindowFrame.008"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.05052f, 0.58530f, 0.58530f);
				scene.lastChild().lastChild().rotateQ(0.70711f, 0.00000f, 0.00000f, -0.70711f);
				scene.lastChild().lastChild().translate(-4.68540f, -3.63985f, 4.00647f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.20155f, 0.34238f, 0.07519f);

				scene.lastChild().addChild(new Object("WindowFrame.009"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.05052f, 0.58530f, 0.58530f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(3.79887f, 4.96069f, 4.00647f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.20155f, 0.34238f, 0.07519f);

				scene.lastChild().addChild(new Object("WindowFrame.010"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.03273f, 0.37922f, 0.37922f);
				scene.lastChild().lastChild().rotateQ(0.70711f, 0.00000f, 0.00000f, 0.70711f);
				scene.lastChild().lastChild().translate(-0.97602f, 1.07825f, -0.02430f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.20155f, 0.34238f, 0.07519f);

				scene.lastChild().addChild(new Object("WindowFrame.011"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.03273f, 0.37922f, 0.37922f);
				scene.lastChild().lastChild().rotateQ(0.00000f, 0.00000f, 0.00000f, 1.00000f);
				scene.lastChild().lastChild().translate(-3.89221f, -4.38410f, 0.60633f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.20155f, 0.34238f, 0.07519f);

				scene.lastChild().addChild(new Object("ConnectorAtap"));
				scene.lastChild().lastChild().createCylinder();
				scene.lastChild().lastChild().scale(0.25409f, 0.25409f, 2.37788f);
				scene.lastChild().lastChild().rotateQ(0.38302f, -0.84944f, -0.32289f, 0.16582f);
				scene.lastChild().lastChild().translate(-6.52306f, 6.77074f, 4.19306f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.68596f, 0.68087f, 0.27177f);

				scene.lastChild().addChild(new Object("ConnectorAtap.001"));
				scene.lastChild().lastChild().createCylinder();
				scene.lastChild().lastChild().scale(0.25409f, 0.25409f, 5.87293f);
				scene.lastChild().lastChild().rotateQ(0.50000f, 0.50000f, 0.50000f, 0.50000f);
				scene.lastChild().lastChild().translate(-1.80846f, 1.80498f, 2.71051f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.68596f, 0.68087f, 0.27177f);

				scene.lastChild().addChild(new Object("ConnectorAtap.002"));
				scene.lastChild().lastChild().createCylinder();
				scene.lastChild().lastChild().scale(0.25409f, 0.25409f, 5.87293f);
				scene.lastChild().lastChild().rotateQ(-0.00000f, -0.00000f, 0.70711f, 0.70711f);
				scene.lastChild().lastChild().translate(-7.77848f, 2.09838f, 2.71051f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.68596f, 0.68087f, 0.27177f);

				scene.lastChild().addChild(new Object("ConnectorAtap.003"));
				scene.lastChild().lastChild().createCylinder();
				scene.lastChild().lastChild().scale(0.25409f, 0.25409f, 5.87293f);
				scene.lastChild().lastChild().rotateQ(0.50000f, 0.50000f, 0.50000f, 0.50000f);
				scene.lastChild().lastChild().translate(-1.80846f, 8.03495f, 2.71051f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.68596f, 0.68087f, 0.27177f);

				scene.lastChild().addChild(new Object("ConnectorAtap.004"));
				scene.lastChild().lastChild().createCylinder();
				scene.lastChild().lastChild().scale(0.25409f, 0.25409f, 5.87293f);
				scene.lastChild().lastChild().rotateQ(-0.00000f, -0.00000f, 0.70711f, 0.70711f);
				scene.lastChild().lastChild().translate(-1.64640f, 2.09838f, 2.71051f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.68596f, 0.68087f, 0.27177f);

				scene.lastChild().addChild(new Object("ConnectorAtap.005"));
				scene.lastChild().lastChild().createCylinder();
				scene.lastChild().lastChild().scale(0.25409f, 0.25409f, 2.81267f);
				scene.lastChild().lastChild().rotateQ(0.49725f, -0.40926f, 0.09676f, 0.75887f);
				scene.lastChild().lastChild().translate(-2.92401f, 3.16613f, 4.38777f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.68596f, 0.68087f, 0.27177f);

				scene.lastChild().addChild(new Object("ConnectorAtap.006"));
				scene.lastChild().lastChild().createCylinder();
				scene.lastChild().lastChild().scale(0.25409f, 0.25409f, 2.51166f);
				scene.lastChild().lastChild().rotateQ(0.93969f, 0.34202f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(4.08836f, 6.39815f, 4.64297f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.68596f, 0.68087f, 0.27177f);

				scene.lastChild().addChild(new Object("ConnectorAtap.007"));
				scene.lastChild().lastChild().createCylinder();
				scene.lastChild().lastChild().scale(0.25409f, 0.25409f, 2.51166f);
				scene.lastChild().lastChild().rotateQ(0.33935f, 0.94066f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(4.08836f, 3.38512f, 4.62275f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.68596f, 0.68087f, 0.27177f);

				scene.lastChild().addChild(new Object("ConnectorAtap.008"));
				scene.lastChild().lastChild().createCylinder();
				scene.lastChild().lastChild().scale(0.25409f, 0.25409f, 2.51166f);
				scene.lastChild().lastChild().rotateQ(0.23995f, 0.66515f, -0.66515f, -0.23995f);
				scene.lastChild().lastChild().translate(-6.20592f, -3.69575f, 4.52470f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.68596f, 0.68087f, 0.27177f);

				scene.lastChild().addChild(new Object("ConnectorAtap.009"));
				scene.lastChild().lastChild().createCylinder();
				scene.lastChild().lastChild().scale(0.25409f, 0.25409f, 2.51166f);
				scene.lastChild().lastChild().rotateQ(0.66446f, 0.24184f, -0.24184f, -0.66446f);
				scene.lastChild().lastChild().translate(-3.19290f, -3.69575f, 4.54492f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.68596f, 0.68087f, 0.27177f);

				scene.lastChild().addChild(new Object("ConnectorAtap.010"));
				scene.lastChild().lastChild().createCylinder();
				scene.lastChild().lastChild().scale(0.25409f, 0.25409f, 4.15049f);
				scene.lastChild().lastChild().rotateQ(0.50000f, 0.50000f, 0.50000f, 0.50000f);
				scene.lastChild().lastChild().translate(-0.07269f, 4.93591f, 6.45235f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.68596f, 0.68087f, 0.27177f);

				scene.lastChild().addChild(new Object("ConnectorAtap.011"));
				scene.lastChild().lastChild().createCylinder();
				scene.lastChild().lastChild().scale(0.25409f, 0.25409f, 4.15049f);
				scene.lastChild().lastChild().rotateQ(-0.00000f, -0.00000f, 0.70711f, 0.70711f);
				scene.lastChild().lastChild().translate(-4.70969f, 0.36572f, 6.39088f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.68596f, 0.68087f, 0.27177f);

				scene.lastChild().addChild(new Object("ConnectorAtap.012"));
				scene.lastChild().lastChild().createCylinder();
				scene.lastChild().lastChild().scale(0.09710f, 0.09710f, 1.99662f);
				scene.lastChild().lastChild().rotateQ(0.33492f, 0.62276f, 0.33492f, 0.62276f);
				scene.lastChild().lastChild().translate(-5.56635f, -5.50573f, 1.30624f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.68596f, 0.68087f, 0.27177f);

				scene.lastChild().addChild(new Object("ConnectorAtap.013"));
				scene.lastChild().lastChild().createCylinder();
				scene.lastChild().lastChild().scale(0.09710f, 0.09710f, 1.27754f);
				scene.lastChild().lastChild().rotateQ(0.47365f, 0.88071f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-7.57291f, -4.45211f, 2.00702f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.68596f, 0.68087f, 0.27177f);

				scene.lastChild().addChild(new Object("ConnectorAtap.014"));
				scene.lastChild().lastChild().createCylinder();
				scene.lastChild().lastChild().scale(0.09710f, 0.09710f, 1.27754f);
				scene.lastChild().lastChild().rotateQ(0.47365f, 0.88071f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-3.58261f, -4.45211f, 2.00702f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.68596f, 0.68087f, 0.27177f);

				scene.lastChild().addChild(new Object("ConnectorAtap.016"));
				scene.lastChild().lastChild().createCylinder();
				scene.lastChild().lastChild().scale(0.09710f, 0.09710f, 0.89292f);
				scene.lastChild().lastChild().rotateQ(0.50033f, 0.86584f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(0.31917f, 1.72059f, 1.02609f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.68596f, 0.68087f, 0.27177f);

				scene.lastChild().addChild(new Object("ConnectorAtap.017"));
				scene.lastChild().lastChild().createCylinder();
				scene.lastChild().lastChild().scale(0.09710f, 0.09710f, 1.24410f);
				scene.lastChild().lastChild().rotateQ(0.33492f, 0.62276f, 0.33492f, 0.62276f);
				scene.lastChild().lastChild().translate(-0.90089f, 0.96145f, 0.59608f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.68596f, 0.68087f, 0.27177f);

				scene.lastChild().addChild(new Object("ConnectorAtap.018"));
				scene.lastChild().lastChild().createCylinder();
				scene.lastChild().lastChild().scale(0.09710f, 0.09710f, 0.89292f);
				scene.lastChild().lastChild().rotateQ(0.50033f, 0.86584f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-2.13797f, 1.72059f, 1.02609f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.68596f, 0.68087f, 0.27177f);

				scene.lastChild().addChild(new Object("AtapBesar.001"));
				scene.lastChild().lastChild().createPlane();
				scene.lastChild().lastChild().scale(4.43153f, 2.45824f, 1.67227f);
				scene.lastChild().lastChild().rotateQ(0.64086f, 0.29884f, 0.29884f, 0.64086f);
				scene.lastChild().lastChild().translate(-3.11602f, 0.50926f, 4.53679f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.99110f, 0.88792f, 0.47932f);

				scene.lastChild().addChild(new Object("AtapBesar.002"));
				scene.lastChild().lastChild().createPlane();
				scene.lastChild().lastChild().scale(4.43153f, 2.45824f, 1.67227f);
				scene.lastChild().lastChild().rotateQ(0.64086f, 0.29884f, -0.29884f, -0.64086f);
				scene.lastChild().lastChild().translate(-6.27663f, 0.50926f, 4.53678f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.99110f, 0.88792f, 0.47932f);

				scene.lastChild().addChild(new Object("AtapBesar.003"));
				scene.lastChild().lastChild().createPlane();
				scene.lastChild().lastChild().scale(4.43153f, 2.45824f, 1.67227f);
				scene.lastChild().lastChild().rotateQ(0.90631f, 0.42262f, -0.00046f, -0.00099f);
				scene.lastChild().lastChild().translate(-0.13388f, 3.36891f, 4.59378f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.99110f, 0.88792f, 0.47932f);

				scene.lastChild().addChild(new Object("AtapBesar"));
				scene.lastChild().lastChild().createPlane();
				scene.lastChild().lastChild().scale(4.43153f, 2.45824f, 1.67227f);
				scene.lastChild().lastChild().rotateQ(0.00099f, 0.00046f, 0.42262f, 0.90631f);
				scene.lastChild().lastChild().translate(-0.12696f, 6.52951f, 4.59378f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.99110f, 0.88792f, 0.47932f);

				scene.lastChild().addChild(new Object("AtapBesar.004"));
				scene.lastChild().lastChild().createPlane();
				scene.lastChild().lastChild().scale(4.43153f, 2.45824f, 1.67227f);
				scene.lastChild().lastChild().rotateQ(0.64086f, 0.29884f, -0.29884f, -0.64086f);
				scene.lastChild().lastChild().translate(-6.27663f, 0.50926f, 4.53678f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.99110f, 0.88792f, 0.47932f);

				scene.lastChild().addChild(new Object("AtapKecil"));
				scene.lastChild().lastChild().createPlane();
				scene.lastChild().lastChild().scale(1.25421f, 0.85286f, 1.67228f);
				scene.lastChild().lastChild().rotateQ(0.25207f, -0.96771f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-0.89769f, 1.70380f, 1.02529f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.99110f, 0.88792f, 0.47932f);

				scene.lastChild().addChild(new Object("AtapKecil.001"));
				scene.lastChild().lastChild().createPlane();
				scene.lastChild().lastChild().scale(1.99001f, 1.22076f, 1.67227f);
				scene.lastChild().lastChild().rotateQ(0.96126f, 0.27564f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-5.59499f, -4.47799f, 1.97896f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.99110f, 0.88792f, 0.47932f);

				scene.lastChild().addChild(new Object("CerobongTutup"));
				scene.lastChild().lastChild().createPlane();
				scene.lastChild().lastChild().scale(0.37717f, 0.37717f, 0.37717f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-4.81823f, 5.07119f, 6.70331f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.88248f, 0.91310f, 0.61404f);

				scene.lastChild().addChild(new Object("AtapConnect"));
				scene.lastChild().lastChild().createTriangle(true);
				scene.lastChild().lastChild().scale(1.50505f, 2.45824f, 1.67227f);
				scene.lastChild().lastChild().rotateQ(0.64086f, 0.29884f, -0.29884f, -0.64086f);
				scene.lastChild().lastChild().translate(-6.27663f, 6.34279f, 4.53678f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.99110f, 0.88792f, 0.47932f);

				scene.lastChild().addChild(new Object("AtapConnect.001"));
				scene.lastChild().lastChild().createTriangle(true);
				scene.lastChild().lastChild().scale(1.73917f, 2.45824f, 1.67227f);
				scene.lastChild().lastChild().rotateQ(0.41978f, 0.90762f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-6.27093f, 6.52951f, 4.59378f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.99110f, 0.88792f, 0.47932f);

				scene.lastChild().addChild(new Object("DindingSegitiga"));
				scene.lastChild().lastChild().createTriangle(true);
				scene.lastChild().lastChild().scale(0.36814f, 0.67169f, 0.31736f);
				scene.lastChild().lastChild().rotateQ(0.00000f, -0.70711f, 0.00000f, 0.70711f);
				scene.lastChild().lastChild().translate(0.18757f, 1.76325f, 1.03454f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.88248f, 0.91310f, 0.61404f);

				scene.lastChild().addChild(new Object("DindingSegitiga.001"));
				scene.lastChild().lastChild().createTriangle(true);
				scene.lastChild().lastChild().scale(0.62530f, 0.98834f, 0.46698f);
				scene.lastChild().lastChild().rotateQ(0.00000f, -0.70711f, 0.00000f, 0.70711f);
				scene.lastChild().lastChild().translate(-7.22947f, -4.40457f, 2.01354f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.88248f, 0.91310f, 0.61404f);

				scene.lastChild().addChild(new Object("DindingSegitiga.002"));
				scene.lastChild().lastChild().createTriangle(true);
				scene.lastChild().lastChild().scale(0.62530f, 0.98834f, 0.46698f);
				scene.lastChild().lastChild().rotateQ(0.00000f, -0.70711f, 0.00000f, 0.70711f);
				scene.lastChild().lastChild().translate(-3.88492f, -4.40457f, 2.01354f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.88248f, 0.91310f, 0.61404f);

				scene.lastChild().addChild(new Object("ConnectBallAtap"));
				scene.lastChild().lastChild().createBall();
				scene.lastChild().lastChild().scale(0.29710f, 0.29562f, 0.29562f);
				scene.lastChild().lastChild().rotateQ(0.99977f, 0.01269f, -0.01360f, -0.01036f);
				scene.lastChild().lastChild().translate(-7.74996f, 8.01522f, 2.70473f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.59258f, 0.53168f, 0.28980f);

				scene.lastChild().addChild(new Object("ConnectBallAtap.001"));
				scene.lastChild().lastChild().createBall();
				scene.lastChild().lastChild().scale(0.29710f, 0.29562f, 0.29562f);
				scene.lastChild().lastChild().rotateQ(0.99977f, 0.01269f, -0.01360f, -0.01036f);
				scene.lastChild().lastChild().translate(-7.74996f, -3.74087f, 2.70473f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.59258f, 0.53168f, 0.28980f);

				scene.lastChild().addChild(new Object("ConnectBallAtap.002"));
				scene.lastChild().lastChild().createBall();
				scene.lastChild().lastChild().scale(0.31588f, 0.31432f, 0.31432f);
				scene.lastChild().lastChild().rotateQ(0.99977f, 0.01269f, -0.01360f, -0.01036f);
				scene.lastChild().lastChild().translate(-1.51237f, 1.66819f, 2.82179f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.59258f, 0.53168f, 0.28980f);

				scene.lastChild().addChild(new Object("ConnectBallAtap.003"));
				scene.lastChild().lastChild().createBall();
				scene.lastChild().lastChild().scale(0.29710f, 0.29562f, 0.29562f);
				scene.lastChild().lastChild().rotateQ(0.99977f, 0.01269f, -0.01360f, -0.01036f);
				scene.lastChild().lastChild().translate(4.10647f, 8.01522f, 2.73818f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.59258f, 0.53168f, 0.28980f);

				scene.lastChild().addChild(new Object("ConnectBallAtap.004"));
				scene.lastChild().lastChild().createBall();
				scene.lastChild().lastChild().scale(0.29710f, 0.29562f, 0.29562f);
				scene.lastChild().lastChild().rotateQ(0.99977f, 0.01269f, -0.01360f, -0.01036f);
				scene.lastChild().lastChild().translate(-1.61787f, -3.74087f, 2.70473f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.59258f, 0.53168f, 0.28980f);

				scene.lastChild().addChild(new Object("ConnectBallAtap.005"));
				scene.lastChild().lastChild().createBall();
				scene.lastChild().lastChild().scale(0.29710f, 0.29562f, 0.29562f);
				scene.lastChild().lastChild().rotateQ(0.99977f, 0.01269f, -0.01360f, -0.01036f);
				scene.lastChild().lastChild().translate(4.07302f, 1.78525f, 2.73818f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.59258f, 0.53168f, 0.28980f);

				scene.lastChild().addChild(new Object("ConnectBallAtap.006"));
				scene.lastChild().lastChild().createBall();
				scene.lastChild().lastChild().scale(0.29710f, 0.29562f, 0.29562f);
				scene.lastChild().lastChild().rotateQ(0.99977f, 0.01269f, -0.01360f, -0.01036f);
				scene.lastChild().lastChild().translate(4.09120f, 4.88409f, 6.47848f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.59258f, 0.53168f, 0.28980f);

				scene.lastChild().addChild(new Object("ConnectBallAtap.007"));
				scene.lastChild().lastChild().createBall();
				scene.lastChild().lastChild().scale(0.29710f, 0.29562f, 0.29562f);
				scene.lastChild().lastChild().rotateQ(0.69962f, -0.00064f, -0.01859f, -0.71427f);
				scene.lastChild().lastChild().translate(-4.70696f, -3.69859f, 6.38044f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.59258f, 0.53168f, 0.28980f);

				scene.lastChild().addChild(new Object("ConnectBallAtap.008"));
				scene.lastChild().lastChild().createBall();
				scene.lastChild().lastChild().scale(0.16167f, 0.16087f, 0.16087f);
				scene.lastChild().lastChild().rotateQ(0.99977f, 0.01269f, -0.01360f, -0.01036f);
				scene.lastChild().lastChild().translate(-3.63372f, -5.49400f, 1.30622f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.59258f, 0.53168f, 0.28980f);

				scene.lastChild().addChild(new Object("ConnectBallAtap.009"));
				scene.lastChild().lastChild().createBall();
				scene.lastChild().lastChild().scale(0.16167f, 0.16087f, 0.16087f);
				scene.lastChild().lastChild().rotateQ(0.99977f, 0.01269f, -0.01360f, -0.01036f);
				scene.lastChild().lastChild().translate(-7.56104f, -5.49400f, 1.30622f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.59258f, 0.53168f, 0.28980f);

				scene.lastChild().addChild(new Object("ConnectBallAtap.010"));
				scene.lastChild().lastChild().createBall();
				scene.lastChild().lastChild().scale(0.16167f, 0.16087f, 0.16087f);
				scene.lastChild().lastChild().rotateQ(0.99977f, 0.01269f, -0.01360f, -0.01036f);
				scene.lastChild().lastChild().translate(-2.09494f, 0.98356f, 0.61408f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.59258f, 0.53168f, 0.28980f);

				scene.lastChild().addChild(new Object("ConnectBallAtap.011"));
				scene.lastChild().lastChild().createBall();
				scene.lastChild().lastChild().scale(0.16167f, 0.16087f, 0.16087f);
				scene.lastChild().lastChild().rotateQ(0.99977f, 0.01269f, -0.01360f, -0.01036f);
				scene.lastChild().lastChild().translate(0.28175f, 0.99008f, 0.61403f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.59258f, 0.53168f, 0.28980f);

				scene.lastChild().addChild(new Object("DindingSegitiga"));
				scene.lastChild().lastChild().createTriangle();
				scene.lastChild().lastChild().scale(1.55522f, 2.52513f, 1.67227f);
				scene.lastChild().lastChild().rotateQ(0.50000f, -0.50000f, 0.50000f, 0.50000f);
				scene.lastChild().lastChild().translate(-4.68849f, -3.46457f, 4.82516f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.88248f, 0.91310f, 0.61404f);

				scene.lastChild().addChild(new Object("DindingSegitiga.001"));
				scene.lastChild().lastChild().createTriangle();
				scene.lastChild().lastChild().scale(1.55522f, 2.59203f, 1.67227f);
				scene.lastChild().lastChild().rotateQ(0.70711f, 0.00000f, 0.70711f, 0.00000f);
				scene.lastChild().lastChild().translate(3.74475f, 4.96849f, 4.89699f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.88248f, 0.91310f, 0.61404f);

			} // Children of 'Rumah'

			scene.lastChild().scale(1.00000f, 1.00000f, 1.00000f);
			scene.lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
			scene.lastChild().translate(-2.76970f, 2.49096f, 1.42000f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(1.0f, 1.0f, 0.0f);



			scene.addChild(new Object("Ground-Grass"));
            scene.lastChild().createTerrain(0.5f, 30, 3);
            scene.lastChild().scale(10.0f);
            scene.lastChild().translate(0, 0, 0);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(38/255f, 139/255f, 7/255f);

            DaunPohonAnimator.s = 0.2f;
            RumahAnimator.s = 1.5f;
		}

        public static void Animations(ref Object scene)
        {
            scene.findChild("Pohon").findChild("DaunPohon").scaleZ(DaunPohonAnimator.MinMaxBounce(0.999f, 1.001f));
            scene.findChild("Pohon").findChild("DaunPohon.001").scaleZ(DaunPohonAnimator.MinMaxBounce(0.999f, 1.001f));
			scene.findChild("Pohon").findChild("DaunPohon.002").scaleZ(DaunPohonAnimator.MinMaxBounce(0.999f, 1.001f));
			scene.findChild("Pohon").findChild("DaunPohon").translateZ(DaunPohonAnimator.MinMaxBounce(-0.001f, 0.001f));
            scene.findChild("Pohon").findChild("DaunPohon.001").translateZ(DaunPohonAnimator.MinMaxBounce(-0.001f, 0.001f));
            scene.findChild("Pohon").findChild("DaunPohon.002").translateZ(DaunPohonAnimator.MinMaxBounce(-0.001f, 0.001f));
		}
    }
}
