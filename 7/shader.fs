#version 330 core
out vec4 FragColor;

vec3 ourColor;
in vec2 TexCoord;

// texture sampler
uniform sampler2D texture1;
uniform sampler2D texture2;


void main()
{	//leni
	//ourColor = vec3(1, 0.32, 0.77);

	//bbm
	ourColor = vec3(1, 0, 0);
	FragColor = texture(texture1, TexCoord) * vec4(ourColor, 1.0); 
}