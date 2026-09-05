using TMPro;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public TextMeshProUGUI text;

    private void Update()
    {
        text.text = $"Viruses Score: {GlobalVariableHolder.GetScore()}";
    }
}

