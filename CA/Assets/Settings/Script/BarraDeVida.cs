using UnityEngine;
using UnityEngine.UI;
public class BarraDeVida : MonoBehaviour
{
    public Slider sliderVidasRestantes;
    public Slider SliderEnergiaRestantes;
    public Jogador jogador;
    
    [SerializeField] private int vidasRestantes;
    [SerializeField] private int energiaRestantes;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (jogador == null)
        {
            jogador = GameObject.FindWithTag("Player").GetComponent<Jogador>();
        }

        if (jogador != null)
        {
            sliderVidasRestantes.minValue = 0;
            sliderVidasRestantes.maxValue = jogador.getVidas();
            
            SliderEnergiaRestantes.minValue = 0;
            SliderEnergiaRestantes.maxValue = jogador.getEnergia();
        }
    }

    // Update is called once per frame
    void Update()
    {
        vidasRestantes = jogador.getVidas();
        SliderEnergiaRestantes.value = vidasRestantes;
        
        energiaRestantes = jogador.getEnergia();
        sliderVidasRestantes.value = energiaRestantes;
        
    }
}
