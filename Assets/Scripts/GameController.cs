using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static GameController instance;
    [SerializeField] Animator transitonAnim;

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void getHit()
    {

    }
    public void EndGame()
    {

    }
    public void NextLevel()
    {
        StartCoroutine(LoadLevel());
    }
    IEnumerator LoadLevel()
    {
        transitonAnim.SetTrigger("End");
        yield return new WaitForSeconds(1);
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1);
        transitonAnim.SetTrigger("Start");
    }
}
