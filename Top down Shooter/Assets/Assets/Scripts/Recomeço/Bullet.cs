using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] int dano = 1;
    [SerializeField] float speed;
    [SerializeField] ParticleSystem effect;

    public void setDano(int dano)
    {
        this.dano = dano;
    }
    public int getDano()
    {
        return this.dano;
    }

    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * speed);

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            int novaVida = collision.gameObject.GetComponent<Personagem>().getVidas() - getDano();
            collision.gameObject.GetComponent<Personagem>().setVidas(novaVida);
        }
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Instantiate(effect, transform.position, transform.rotation);
        Destroy(gameObject, 0.1f);

        
    }
}

