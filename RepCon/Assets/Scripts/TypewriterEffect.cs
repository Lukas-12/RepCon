using System.Collections;
using TMPro;
using UnityEngine;

public class TypewriterEffect : MonoBehaviour
{
    public float delay = 0.05f; // Verzögerung zwischen den Buchstaben

    private TextMeshProUGUI textMeshPro;

    void Awake()
    {
        // Hier wird das TextMeshPro-Objekt gefunden (angenommen, es ist ein Kind des Eltern-GameObjects)
        textMeshPro = GetComponentInChildren<TextMeshProUGUI>(); 
    }

    void OnEnable()
    {
        // Wenn das Eltern-GameObject aktiviert wird, starte den Typewriter-Effekt
        StartCoroutine(TypeText());
    }

    IEnumerator TypeText()
    {
        string fullText = textMeshPro.text;
        textMeshPro.text = ""; // Startet leer

        foreach (char letter in fullText)
        {
            textMeshPro.text += letter;
            yield return new WaitForSeconds(delay);
        }
    }
}

