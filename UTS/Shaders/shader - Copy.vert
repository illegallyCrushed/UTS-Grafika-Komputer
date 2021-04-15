#version 330 core

layout(location = 0) in vec3 aPosition;
layout(location = 1) in vec3 aNormal;

out vec3 FragPos;
out vec3 Normal;
out vec3 EyeDir;

uniform mat4 mvp_transform;
uniform mat4 v_transform;
uniform mat4 m_transform;
uniform vec3 LightPos_World;

void main(void){

    gl_Position = vec4(aPosition, 1.0) * mvp_transform;

    FragPos = vec3(m_transform * vec4(aPosition, 1.0));

    vec3 EyeDir = vec3(0,0,0) - vec3(v_transform * m_transform * vec4(aPosition, 1.0));

    Normal = vec3(v_transform * inverse(transpose(m_transform)) * vec4(aNormal, 1.0)); 
}

