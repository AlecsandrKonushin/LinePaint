using UnityEngine;
using UnityEngine.SceneManagement;
using YG;

public class AppManager : MonoBehaviour
{
    private void Awake()
    {
        YandexGame.GetDataEvent += () =>
         {
             SceneManager.LoadScene(1);
         };
    }
}
