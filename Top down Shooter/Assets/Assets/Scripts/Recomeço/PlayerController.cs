using Unity.Mathematics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : Personagem
{
    [SerializeField] float moveSpeed;
    Vector2 moveInput;
    Animator _anim;


    void Start()
    {
        _anim = GetComponentInChildren<Animator>();
    }


    void Update()
    {
        moveInput.x = Input.GetAxis("Horizontal");
        moveInput.y = Input.GetAxis("Vertical");

        transform.Translate(moveInput * Time.deltaTime * moveSpeed);

        _anim.SetBool("isRunning", (Mathf.Abs(moveInput.x) > 0 || Mathf.Abs(moveInput.y) > 0));


        
        if(getVidas() <= 0 )
        {
            Debug.Log("Jogador morreu!!!");

            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    
    
   

   private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            int vidas = getVidas() - 1;
            setVidas(vidas);
            
        } 

    }
}
