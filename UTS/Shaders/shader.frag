#version 330 core

in vec3 FragPos;
in vec3 Normal;
in vec3 LightPos_View;

out vec4 FragColor;

uniform mat4 mvp_transform;
uniform mat4 m_transform;
uniform mat4 v_transform;
uniform vec3 LightPos_World;
uniform vec3 LightDir_World;
uniform vec3 LightColor;
uniform vec3 ViewPos;
uniform float LightPower;

struct Material {
    vec3 ambient;
    vec3 diffuse;
    vec3 specular;

    float shininess;
};
  
uniform Material material;

void main()
{
    // ambient
    vec3 ambient = LightColor * material.diffuse;
  	
    // diffuse 
    vec3 norm = normalize(Normal);
    vec3 lightDir = normalize(LightPos_View - FragPos);
    float diff = max(dot(norm, lightDir), 0.0);
    vec3 diffuse = LightColor * diff * material.diffuse;  
    
    // specular
    vec3 viewDir = normalize(-FragPos);
    vec3 reflectDir = reflect(-lightDir, norm);  
    float spec = pow(max(dot(viewDir, reflectDir), 0.0), material.shininess);
    vec3 specular = LightColor * spec * material.specular;  
        
    vec3 result = ambient + diffuse + specular;
    FragColor = vec4(result, 1.0);
} 
