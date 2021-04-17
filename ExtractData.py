import bpy

file = open(bpy.data.filepath+".txt","w")

collections = bpy.data.collections

for collection in collections:
    for object in collection.all_objects:
        name = object.name.split("-")
        if name[0] == "Ignore" or len(name) < 2:
            continue
        else:
            file.write("scene.addChild(new Object(\"{}\"));\n".format(name[1]))
            if name[0] == "Plane":
                file.write("scene.lastChild().createPlane();\n")
            elif name[0] == "Cube":
                file.write("scene.lastChild().createCube();\n")
            elif name[0] == "Circle":
                file.write("scene.lastChild().createCircle();\n")
            elif name[0] == "Sphere":
                file.write("scene.lastChild().createBall();\n")
            elif name[0] == "Cylinder":
                file.write("scene.lastChild().createCylinder();\n")
            elif name[0] == "Cone":
                file.write("scene.lastChild().createCone();\n")
            elif name[0] == "Torus":
                file.write("scene.lastChild().createTorus();\n")
            elif name[0] == "Triangle":
                file.write("scene.lastChild().createTriangle();\n")
            elif name[0] == "RightTriangle":
                file.write("scene.lastChild().createTriangle(true);\n")
            elif name[0] == "HalfCircle":
                file.write("scene.lastChild().createCircle(0.5f);\n")
            elif name[0] == "HalfSphere":
                file.write("scene.lastChild().createBall(0.5f);\n")
            elif name[0] == "HalfCylinder":
                file.write("scene.lastChild().createCylinder(0.5f);\n")
            elif name[0] == "HalfCone":
                file.write("scene.lastChild().createCone(0.5f);\n")
            elif name[0] == "HalfTorus":
                if len(name) == 2:
                    file.write("scene.lastChild().createTorus(0.5f);\n")
                else:
                    file.write("scene.lastChild().createTorus(0.5f,{}f);\n".format(name[2]))
            elif name[0] == "BezierCurve":
                file.write("scene.lastChild().createFreeformTube(new List<Vector2> {\n")
                object.data.dimensions = "2D"
                object.data.render_resolution_u = 5
                object.data.render_resolution_v = 5
                object.data.resolution_u = 5
                object.data.resolution_v = 5
                curvetemp = object.to_mesh()
                for vert in curvetemp.vertices:
                    file.write("\t\t\t\tnew Vector2({:.5f}f, {:.5f}f),\n".format(vert.co[0],vert.co[1],vert.co[2]))
                file.write("\t\t\t});\n")
            else:
                continue
        
            file.write("scene.lastChild().scale({:.5f}f, {:.5f}f, {:.5f}f);\n".format(object.scale[0],object.scale[1],object.scale[2]))
            object.rotation_mode = "QUATERNION"
            file.write("scene.lastChild().rotateQ({:.5f}f, {:.5f}f, {:.5f}f,{:.5f}f);\n".format(object.rotation_quaternion[0],object.rotation_quaternion[1],object.rotation_quaternion[2],object.rotation_quaternion[3]))
            file.write("scene.lastChild().translate({:.5f}f, {:.5f}f, {:.5f}f);\n".format(object.location[0],object.location[1],object.location[2]))
            file.write("scene.lastChild().centerOrigin();\n")
            
            try:
                nodes = object.material_slots[0].material.node_tree.nodes
                principled = next(n for n in nodes if n.type == 'BSDF_PRINCIPLED')
                base_color = principled.inputs[0]
                value = base_color.default_value
                file.write("scene.lastChild().setColor({:.5f}f, {:.5f}f, {:.5f}f);\n".format(value[0], value[1], value[2])) 
            except:
                file.write("scene.lastChild().setColor(1.0f, 1.0f, 0.0f);\n")
            file.write("\n")

file.close()