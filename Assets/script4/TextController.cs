using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour
{
    public Text textLabel;
    public string charaName;
    public string[] word;
    public AudioClip sound;
    private int num = 0;

    private void Start()
    {
        textLabel.text = charaName + "\n" + word[num];
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (num == word.Length - 1)
            {
                return;
            }

            AudioSource.PlayClipAtPoint(sound, Camera.main.transform.position);

            num += 1;

            textLabel.text = charaName + "\n" + word[num];
        }
    }
}
