using UnityEngine;

public class Jogador : Personagem
{
    private Animator _animator;
    public bool IsRunning;

    void Start()
    {
        _animator = GetComponent<Animator>();
    }


    void Update()
    {
        _animator.SetBool("IsRunning", IsRunning);
        IsRunning = false;
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