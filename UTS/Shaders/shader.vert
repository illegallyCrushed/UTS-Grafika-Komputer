#version 330 core
layout (location = 0) in vec3 aPos;
layout (location = 1) in vec3 aNormal;

out VS_OUT {
    vec3 FragPos;
    vec3 Normal;
    vec4 FragPosLightSpace;
} vs_out;

uniform mat4 projection;
uniform mat4 view;
uniform mat4 model;
uniform mat4 lightSpaceMatrix;

void main()
{
    vs_out.FragPos =  vec3(vec4(aPos, 1.0) * model);
    vs_out.Normal = aNormal * mat3(transpose(inverse(model))); 
    vs_out.FragPosLightSpace = vec4(vs_out.FragPos, 1.0) * lightSpaceMatrix;
    gl_Position = vec4(aPos, 1.0) * model * view * projection;
}