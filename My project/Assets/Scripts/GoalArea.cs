using UnityEngine;
using Cysharp.Threading.Tasks;

public class GoalArea : MonoBehaviour
{
    private async void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player"))
            return;

        Time.timeScale = 0;

        UIManager.Instance.ShowMessage(
    "<color=#00FF00><size=80>STAGE CLEAR!</size></color>"
);

        await UniTask.Delay(
            3000,
            ignoreTimeScale: true
        );

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}