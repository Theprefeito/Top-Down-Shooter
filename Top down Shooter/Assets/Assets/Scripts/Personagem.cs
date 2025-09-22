using UnityEngine;

public class Jogador : Personagem
{
    private Animator _animator;
    private bool IsRunning;

    void Start()
    {
        _animator = GetComponent<Animator>();
        IsRunning = false;
        _animator.SetBool("IsRunning", IsRunning);
    }


    void Update()
    {
        if (Input.GetKey(KeyCode.A)) //Esquerda
        {
            transform.position -= new Vector3(getVelocidade() * Time.deltaTime, 0, 0);
            IsRunning = true;
        }

        if (Input.GetKey(KeyCode.D)) //Direita
        {
            transform.position += new Vector3(getVelocidade() * Time.deltaTime, 0, 0);
            IsRunning = true;
        }

        if (Input.GetKey(KeyCode.W)) //Cima
        {
            transform.position += new Vector3(0, getVelocidade() * Time.deltaTime, 0);
            IsRunning = true;
        }

        if (Input.GetKey(KeyCode.S)) //Baixo
        {
            transform.position -= new Vector3(0, getVelocidade() * Time.deltaTime, 0);
            IsRunning = true;   
        }
    }
}