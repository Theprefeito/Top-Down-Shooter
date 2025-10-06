using UnityEngine;

public class EnemyController : MonoBehaviour
{

    [SerializeField] float speed;
    GameObject player;
    Animator _anim;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        _anim = GetComponentInChildren<Animator>();

    }


    void Update()
    {
        if (player != null)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet"))
        {
            
        }
    }
}
