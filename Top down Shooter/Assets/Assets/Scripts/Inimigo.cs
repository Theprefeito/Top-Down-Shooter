using UnityEngine;

public class Inimigo : Personagem
{
    [SerializeField] private int dano = 1;

    [SerializeField] private Transform posicaoDoPlayer;
    
    public void setDano(int dano)
    {
        this.dano = dano;
    }
    public int getDano()
    {
        return this.dano;
    }

    void Start()
    {
        if (posicaoDoPlayer == null)
        {
            posicaoDoPlayer =  GameObject.Find("Player").transform;
        }
    }

    void Update()
    {
        if (posicaoDoPlayer != null)
        {
            Debug.Log("Posição do Pluer"+ posicaoDoPlayer.position);
            
            transform.position = Vector3.MoveTowards(transform.position, 
                posicaoDoPlayer.transform.position,
                getVelocidade() * Time.deltaTime);
        }
        
        if (getVidas() <= 0)
        {
            //desativa o objeto do Inimigo
            gameObject.SetActive(false);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Causa dano ao Player
            int novaVida = collision.gameObject.GetComponent<Personagem>().getVidas() - getDano();
            collision.gameObject.GetComponent<Personagem>().setVidas(novaVida);

            //collision.gameObject.GetComponent<Personagem>().recebeDano(getDano());
            
            //desativa quando bate no player
            gameObject.SetActive(false);
        }
    }
}