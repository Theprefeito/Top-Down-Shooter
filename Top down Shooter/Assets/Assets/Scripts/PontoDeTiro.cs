using UnityEngine;

public class PontoDeTiro : MonoBehaviour
{
    private SpriteRenderer srGun;
    Vector2 dirGun;

    public float angle;

    public float tempoEntreTiros;
    bool canFire = true;

    [SerializeField] Transform pontoDeFogo;
    [SerializeField] GameObject tiro;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        srGun = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        PonteiroCam();
    }

    void PonteiroCam()
    {
        Vector2 mousePos = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.up = (Vector3)(mousePos - new Vector2(transform.position.x, transform.position.y));
       
       
        if (Input.GetMouseButtonDown(0) && canFire)
        {
            canFire = false;
            Instantiate(tiro, pontoDeFogo.position, pontoDeFogo.rotation);
            Invoke("CDtiros", tempoEntreTiros);
        }

    }

    void CDtiros()
    {
        canFire = true;
    }
}
