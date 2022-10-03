using UnityEngine;
using VavilichevGD.Tools.Async;

public class Boot : MonoBehaviour
{
    private void Start()
    {
        SlicerGame.StartGameAsync().RunAsync();
    }
}
