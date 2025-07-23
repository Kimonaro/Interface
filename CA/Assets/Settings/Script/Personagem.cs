using UnityEngine;

public class Personagem : MonoBehaviour
{
    [SerializeField] private int vidas;
    [SerializeField] private int energia;
    [SerializeField] private int velocidade;

    public int getVidas()
    {
        return vidas;
    }

    public void setVidas(int vidas)
    {
        this.vidas = vidas;
    }

    
    public int getEnergia()
    {
        return energia;
    }

    public void setEnergia(int energia)
    {
        this.energia = energia;
    }


    public int getVelocidade()
    {
        return velocidade;
    }

    public void setVelocidade(int velocidade)
    {
        this.velocidade = velocidade;
    }
}
