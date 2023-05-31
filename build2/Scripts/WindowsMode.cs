using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WindowsMode : MonoBehaviour
{
    public Toggle Toggle;

    // Start is called before the first frame update
    void Start()
    {
        Screen.fullScreen = true;
        Toggle.isOn = false;
    }

    public void ScreenMode()
    {
        Screen.fullScreen = !Toggle.isOn;
    }
}
