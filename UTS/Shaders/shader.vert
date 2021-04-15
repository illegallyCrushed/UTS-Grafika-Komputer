#version 330 core

layout(location = 0) in vec3 aPosition;
layout(location = 1) in vec3 aNormal;

out vec3 FragPos;
out vec3 Normal;
out vec3 LightPos_View;

uniform mat4 mvp_transform;
uniform mat4 v_transform;
uniform mat4 m_transform;
uniform vec3 LightPos_World;

void main(void){
    gl_Position =  vec4(aPosition, 1.0) * mvp_transform;
    FragPos = vec3(v_transform * m_transform * vec4(aPosition, 1.0));
    Normal = mat3(transpose(inverse(v_transform * m_transform))) * aNormal; 
    LightPos_View = vec3(v_transform * vec4(LightPos_World, 1.0));
}

