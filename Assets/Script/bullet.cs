using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Reset lại trò chơi khi viên đạn va chạm với người chơi
            ResetGame();
        }
    }

    void ResetGame()
    {
        // Lấy lại tên của cảnh hiện tại
        string currentSceneName = SceneManager.GetActiveScene().name;
        // Tải lại cảnh hiện tại
        SceneManager.LoadScene(currentSceneName);
    }
}
