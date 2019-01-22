using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class screenshot : MonoBehaviour
{
    [SerializeField] string name = "Sample.png";
    // Start is called before the first frame update
    void Start()
    {
        ScreenCapture.CaptureScreenshot(Application.dataPath + "/" + name);
    }
}
