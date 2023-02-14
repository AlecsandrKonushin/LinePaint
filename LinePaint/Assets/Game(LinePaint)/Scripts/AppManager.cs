using UnityEngine;
using UnityEngine.SceneManagement;
using YG;

public class AppManager : Singleton<AppManager>
{
    [SerializeField] private YandexGame yandex;

    protected override void AfterAwaik()
    {
        YandexGame.GetDataEvent += () =>
         {
             SceneManager.LoadScene(1);
         };
    }

    public void ShowAd()
    {
        yandex._FullscreenShow();
    }
}
