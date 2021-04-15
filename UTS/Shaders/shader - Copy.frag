#version 330 core

in vec3 FragPos;
in vec3 Normal;
in vec3 EyeDir;

out vec4 outputColor;

uniform mat4 mvp_transform;
uniform mat4 m_transform;
uniform mat4 v_transform;
uniform vec3 LightPos_World;
uniform vec3 LightColor;
uniform float LightPower;

struct Material {
    vec3 ambient;
    vec3 diffuse;
    vec3 specular;

    float shininess;
};
  
uniform Material material;



void main(){

	float distance = length( LightPos_World - FragPos );

	vec3 n = normalize( Normal );
	vec3 l = normalize( vec3( v_transform * vec4(LightPos_World,1.0)) + EyeDir);
	float cosTheta = clamp( dot( n,l ), 0,1 );
	
	vec3 E = normalize(EyeDir);
	vec3 R = reflect(-l,n);
	float cosAlpha = clamp( dot( E,R ), 0,1 );
	
	vec3 result = 
		material.ambient +(material.diffuse * LightColor * LightPower * cosTheta / (distance*distance))+(material.specular * LightColor * LightPower * pow(cosAlpha, material.shininess) / (distance*distance));
    outputColor = vec4(result, 1.0);
}

