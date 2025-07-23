using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class CRT_FX : MonoBehaviour
{
    private Toggle _toggle; 
    public TextMeshProUGUI _texto;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _toggle = GetComponent<Toggle>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_toggle.isOn == true)
        {
            _texto.text = "Ligado";
            _texto.color = Color.blue;
        }
        else
        {
            _texto.text = "Desligado";
            _texto.color = Color.red;
        }
    }
}
