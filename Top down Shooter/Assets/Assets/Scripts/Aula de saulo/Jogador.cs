using UnityEngine;

public class Personagem : MonoBehaviour
{

    [SerializeField] private int vidas;
    [SerializeField] private int energia;
    [SerializeField] private float velocidade;

    // vidas
    public void setVidas(int Vidas)
    {
        this.vidas = Vidas;
    }

    public int getVidas()
    {
        return this.vidas;
    }

    //energia
    public void setEnergia(int energia)
    {
        this.energia = energia;
    }

    public int getEnergia()
    {
        return this.energia;
    }

    //velocidade
    public void setVelocidade(float velocidade)
    {
        this.velocidade = velocidade;

    }

    public float getVelocidade()
    {
        return this.velocidade;
    }
    
    public void recebeDano(int dano)
    {
        // atribui dano ao personagem
        int novaVida = getVidas() - dano;
        setVidas(novaVida);
    }
    
}