using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UILoader : MonoBehaviour
{
    private void Awake()
    {
        SceneManager.LoadScene("UI", LoadSceneMode.Additive);
    }
}
