using UnityEngine;

public class Personagem : MonoBehaviour
{

    [SerializeField] private int vidas;
    [SerializeField] private int energia;


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


    
    public void getDano(int dano)
    {
        // atribui dano ao personagem
        int novaVida = getVidas() - dano;
        setVidas(novaVida);
    }
    
}