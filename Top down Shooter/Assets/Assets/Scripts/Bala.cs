using UnityEngine;

public class Bala : MonoBehaviour
{
    [SerializeField] float speedBullet;
    [SerializeField] float timeToDie;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(gameObject, timeToDie);
    }

    private void FixedUpdate()
    {
        transform.Translate(transform.up *  speedBullet * Time.fixedDeltaTime, Space.World);
    }
}