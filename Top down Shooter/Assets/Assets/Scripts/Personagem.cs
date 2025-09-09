using UnityEngine;

public class Jogador : Personagem
{

    void Start()
    {
        
    }


    void Update()
    {
        if (Input.GetKey(KeyCode.A)) //Esquerda
        {
            transform.position -= new Vector3(getVelocidade() * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.D)) //Direita
        {
            transform.position += new Vector3(getVelocidade() * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.W)) //Cima
        {
            transform.position += new Vector3(0, getVelocidade() * Time.deltaTime, 0);
        }

        if (Input.GetKey(KeyCode.S)) //Baixo
        {
            transform.position -= new Vector3(0, getVelocidade() * Time.deltaTime, 0);
        }
    }
}