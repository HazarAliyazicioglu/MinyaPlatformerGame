using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishMenu : MonoBehaviour
{
    public void Github()
    {
        Application.OpenURL("https://github.com/HazarAliyazicioglu");
    }

    public void Linkedin()
    {
        Application.OpenURL("https://www.linkedin.com/in/hazar-aliyazicioglu/");
    }

    public void BB()
    {
        Application.Quit();
    }
}
