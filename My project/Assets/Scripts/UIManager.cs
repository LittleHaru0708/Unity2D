using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    [SerializeField] private TextMeshProUGUI messageText;
    [SerializeField] private GameObject panel;

    private void Awake()
    {
        Instance = this;

        panel.SetActive(false);
        messageText.text = "";
    }

    public void ShowMessage(string text)
    {
        panel.SetActive(true);
        messageText.text = text;
    }
}