using UnityEngine;

public class EnemyController : Personagem
{

    [SerializeField] private int dano = 1;
    [SerializeField] private Transform posicaoDoPlayer;
    [SerializeField] float speed;
    [SerializeField] AudioClip deadFx;
    GameObject player;
    Animator _anim;
    AudioSource enemyFx;
    bool isAlive = true;
    

   /* public void setDano(int dano)
    {
        this.dano = dano;
    }
    public int getDano()
    {
        return this.dano;
    }*/

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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet"))
        {
            _anim.SetTrigger("Dead");
            isAlive = false;
            enemyFx.PlayOneShot(deadFx);
            Destroy(gameObject, 0.5f);
        }

        /*if (getVidas() <= 0)
        {
            //desativa o objeto do Inimigo
            gameObject.SetActive(false);
        }*/
    }
    
}
