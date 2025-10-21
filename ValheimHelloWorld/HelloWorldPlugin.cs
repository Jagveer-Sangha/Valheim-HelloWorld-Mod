using BepInEx;
using UnityEngine;
using static System.Runtime.CompilerServices.RuntimeHelpers;

//[BepInPlugin("com.yourname.helloworld", "HelloWorld", "1.0.0")]
public class HelloWorldPlugin : BaseUnityPlugin
{
    private void Start()
    {
        Logger.LogInfo("Hello, Valheim modding world!");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F5))
        {
            Logger.LogInfo("You pressed F5!");
        }
    }

    private void OnDestroy()
    {
        Logger.LogInfo("Goodbye, Valheim modding world!");
    }
}
