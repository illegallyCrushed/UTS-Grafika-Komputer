﻿
#version 330 core
layout (location = 0) in vec3 aPos;
layout (location = 1) in vec3 aNormal;

out vec3 FragPos;
out vec3 Normal;

uniform mat4 model;
uniform mat4 view;
uniform mat4 projection;

void main()
{
    FragPos = vec3(vec4(aPos, 1.0) * model);
    Normal = aNormal * mat3(transpose(inverse(model)));  
    gl_Position = vec4(FragPos, 1.0) * view * projection;
}