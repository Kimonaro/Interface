using TMPro;
using UnityEngine;

public class TrocaTexto : MonoBehaviour
{
    public TextMeshProUGUI _texto;
    public TMP_InputField _inputField;

    public void Troca()
    {
        _texto.text = _inputField.text;
    }
}
