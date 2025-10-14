using UnityEngine;

public class EnemyController : Personagem
{

    [SerializeField] private Transform posicaoDoPlayer;
    [SerializeField] float speed;
    [SerializeField] AudioClip deadFx;
    private int dano = 1;
    GameObject player;
    Animator _anim;
    AudioSource enemyFx;
    bool isAlive = true;
    

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
        player = GameObject.FindGameObjectWithTag("Player");
        _anim = GetComponentInChildren<Animator>();
        enemyFx = GetComponent<AudioSource>();

    }


    void Update()
    {
        if (player != null && isAlive == true)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
        }


        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            enemyFx.PlayOneShot(deadFx);
            Destroy(gameObject, 0.1f);

        }

        if (collision.gameObject.CompareTag( "Bullet"))
        {
            int novaVida = collision.gameObject.GetComponent<Personagem>().getVidas() - getDano();
            collision.gameObject.GetComponent<Personagem>().setVidas(novaVida);
        }

        if(getVidas() <= 0 )
        {
            _anim.SetTrigger("Dead");
            isAlive = false;
            enemyFx.PlayOneShot(deadFx);

            Destroy(gameObject, 0.5f);
            
        }

   
    }




   /* private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet"))
        {
            _anim.SetTrigger("Dead");
            isAlive = false;
            enemyFx.PlayOneShot(deadFx);
            Destroy(gameObject, 0.5f);
        }

    }*/
    
}

