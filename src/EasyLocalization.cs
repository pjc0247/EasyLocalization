using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class EasyLocalization : MonoBehaviour
{
    public Transform korean, english, japanese;

    public void Awake()
    {
        if (Application.isEditor)
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                var child = transform.GetChild(i);

                if (child.name.Contains("ko"))
                    korean = child;
                else if (child.name.Contains("en"))
                    english = child;
                else if (child.name.Contains("jp"))
                    japanese = child;
            }
        }
        //else
        {
            SetActive(Application.systemLanguage);
        }
    }


    public void SetActive(SystemLanguage lang)
    {
        switch (lang)
        {
            case SystemLanguage.Korean:
                korean.gameObject.SetActive(true);
                english.gameObject.SetActive(false);
                japanese.gameObject.SetActive(false);
                break;
            case SystemLanguage.English:
                english.gameObject.SetActive(true);
                korean.gameObject.SetActive(false);
                japanese.gameObject.SetActive(false);
                break;
            case SystemLanguage.Japanese:
                japanese.gameObject.SetActive(true);
                english.gameObject.SetActive(false);
                korean.gameObject.SetActive(false);
                break;
        }
    }
}
