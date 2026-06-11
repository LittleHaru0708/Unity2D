using UnityEngine;
using UnityEngine.SceneManagement;
using Cysharp.Threading.Tasks;

public class DeathArea : MonoBehaviour
{
    private async void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player"))
            return;

        Time.timeScale = 0;

        UIManager.Instance.ShowMessage(
     "<color=red><size=80>ÇÕÇ¢É_ÉÅÅ[ÅI</size></color>"
 );

        await UniTask.Delay(
            3000,
            ignoreTimeScale: true
        );

        Time.timeScale = 1;

        SceneManager.LoadScene(
            SceneManager.GetActiveScene().buildIndex
        );
    }
}