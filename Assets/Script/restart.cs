using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
